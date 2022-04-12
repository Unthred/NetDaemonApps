using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using System.Threading;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;
using NetDaemonApps.apps.Helpers;
using NetDaemonApps.apps.Models;

namespace NetDaemonApps.apps.LightNotification;

/// <summary>
/// To detect movement in the garden and flash a light briefly to signify where in the garden the movement is.
/// Primarily for detecting the squirrels that visit us 
/// </summary>
[Focus]
[NetDaemonApp]
public class FlashLightOnMovement
{
    private static readonly object LockObject = new();
    private static readonly List<LightState> RestoreLightStates = new();
    private static readonly ConcurrentQueue<FlashNotification> NotificationQueue = new();
    private static FlashNotificationConfig? _appConfig;
    private static int _notificationDuration = 2000;
    private static ILogger<FlashLightOnMovement> _logger;
    private static readonly XyColourValue ErrorColour = new()
    {
        // Using White as an error colour
        x = (float) -0.323,
        y = (float) -0.329
    };

    /// <summary>
    /// Load the entities from Home Assistant config.yaml
    /// </summary>
    /// <param name="ha">Home Assistant context</param>
    /// <param name="logger"></param>
    /// <param name="config">Automatically loaded from the config.yaml in the same directory as this program</param>
    /// <exception cref="NullReferenceException"></exception>
    public FlashLightOnMovement(IHaContext ha, ILogger<FlashLightOnMovement> logger, IAppConfig<FlashNotificationConfig> config)
    {
        var entities = new Entities(ha);
        _appConfig = config.Value;
        Debug.Assert(_appConfig != null);
        _notificationDuration = _appConfig.NotificationDuration;
        _logger = logger;
        if (_appConfig.FlashNotifications != null)
        {
            NotifyOnMovement(_appConfig ?? throw new NullReferenceException("Config is null"));
        }
    }

    /// <summary>
    /// Subscribe to events for each motion sensor in flashNotifications
    /// </summary>
    /// <param name="appConfig">Config loaded from yaml file</param>
    private static void NotifyOnMovement(FlashNotificationConfig appConfig)
    {
        // Register state change event for each motion sensor
        if (appConfig.FlashNotifications != null)
        {
            foreach (var flashNotification in appConfig.FlashNotifications)
            {
                flashNotification.MotionSensor?.StateChanges()
                    .Where(e => e.New?.State == "on")
                    .Subscribe(_ => { FlashLights(flashNotification); });
            }
        }
    }

    /// <summary>
    /// A Motion sensor has triggered so save the state of lights and show the notifications
    /// </summary>
    /// <param name="flashNotification">Describes the notification event. i.e. sensor, colour, duration, lights etc.</param>
    private static void FlashLights(FlashNotification flashNotification)
    {
        Debug.Assert(_appConfig != null);

        _logger.LogDebug("FlashLights entered");

        NotificationQueue.Enqueue(flashNotification);
        _logger.LogDebug($"Added FlashNotification from {flashNotification.MotionSensor?.Attributes?.FriendlyName} to queue {NotificationQueue.Count} items");

        if (RestoreLightStates.Count == 0)
        {
            // If the restore light queue is empty then we need to save the state of the flashNotification lights
            _logger.LogDebug($"============= Saving {_appConfig.Lights.Count} Lights State =============");

            foreach (var light in _appConfig.Lights)
            {
                var restoreLight = new LightState(light);
                if (light.Attributes != null)
                {
                    restoreLight.SavedAttributes = light.Attributes;
                    if (restoreLight.LightEntity.Attributes != null)
                    {
                        _logger.LogDebug($"{light.Attributes.FriendlyName, -25} = {light.Attributes.Color, 15}");

                        //var lightState = light.IsOn() ? "On" : "Off";
                        //_logger.LogDebug($"{light.Attributes.FriendlyName} is {lightState}");
                        //_logger.LogDebug($"Brightness = {light.Attributes.Brightness}");
                        //_logger.LogDebug($"NotificationColour = {light.Attributes.Color}");
                        //_logger.LogDebug($"Colour_mode = {light.Attributes.ColorMode}");
                        //_logger.LogDebug($"XY NotificationColour = {light.Attributes.XyColor}");
                    }
                }
                restoreLight.IsOn = light.IsOn();
                RestoreLightStates.Add(restoreLight);
            }
            _logger.LogDebug($"============= Saved {_appConfig.Lights.Count} Lights State =============");
        }

        lock (LockObject)
        {

            _logger.LogDebug($"============= Processing {NotificationQueue.Count} Notifications =============");
            do
            {
                if (NotificationQueue.TryDequeue(out var notification))
                    FlashNotification(notification);
            } while (!NotificationQueue.IsEmpty);

            _logger.LogDebug($"Wait {_notificationDuration}ms for notification to finish.");
            Thread.Sleep(_notificationDuration);

            RestoreOriginalStates();
            _logger.LogDebug($"Wait {_notificationDuration}ms for restoration to finish.");
            Thread.Sleep(_notificationDuration);

            _logger.LogDebug($"============= Notifications Count = {NotificationQueue.Count} =============");
        }
    }

    /// <summary>
    /// Turn the light on with the specified colour and duration
    /// </summary>
    /// <param name="notification">Colour and duration of notification</param>
    private static void FlashNotification(FlashNotification notification)
    {
        Debug.Assert(_appConfig != null);
        foreach (var light in _appConfig.Lights)
        {
            _logger.LogDebug($"{light.Attributes?.FriendlyName,-25} = {notification.Colour,15} - {notification.MotionSensor?.Attributes?.FriendlyName}");
            light.TurnOn(brightness: notification.Brightness, colorName: notification.Colour);
        }
    }

    /// <summary>
    /// Notifications have finished so return all lights to original state
    /// </summary>
    private static void RestoreOriginalStates()
    {
        _logger.LogDebug($"============= Restoring {RestoreLightStates.Count} Lights =============");
        foreach (var light in RestoreLightStates)
        {
            light.LightEntity.TurnOn(CalculateTurnOnParameters(light));

            if (!light.IsOn)
            {
                _logger.LogDebug($"Wait {_notificationDuration}ms for light on to finish.");
                Thread.Sleep(_notificationDuration);
                light.LightEntity.CallService("turn_off");
                _logger.LogDebug($"{light.LightEntity.Attributes?.FriendlyName, -25} = {light.SavedAttributes.Color, 15} - returned to OFF state");
            }
            else
            {
                _logger.LogDebug($"{light.LightEntity.Attributes?.FriendlyName, -25} = {light.SavedAttributes.Color, 15}");
            }
        }
        RestoreLightStates.Clear();
        _logger.LogDebug($"============= Restored Lights Count = {RestoreLightStates.Count} =============");
    }

    /// <summary>
    /// Calculate the correct xy_colour (if the light is off we take the 
    /// </summary>
    /// <param name="light"></param>
    /// <returns></returns>
    private static LightTurnOnParameters CalculateTurnOnParameters(LightState light)
    {
        if (light.IsOn)
        {
            return new LightTurnOnParameters
            {
                Brightness = (long?) light.SavedAttributes.Brightness,
                XyColor = light.SavedAttributes.XyColor
            };
        }
        var colour = ((JsonElement?)light.SavedAttributes.Color)?.Deserialize<XyColourValue>(new JsonSerializerOptions());
        if (colour == null)
        {   
            return new LightTurnOnParameters
            {
                XyColor = ErrorColour
            };
        }
        return new LightTurnOnParameters
        {
            XyColor = new[] {colour.x, colour.y}
        };

    }
}