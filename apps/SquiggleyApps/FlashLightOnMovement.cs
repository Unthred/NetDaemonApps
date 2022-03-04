using System.Collections.Concurrent;
using HomeAssistantGenerated;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using NetDaemon.HassModel.Entities;
using NetDaemonApps.apps.Models;

namespace NetDaemonApps.apps.SquiggleyApps;

/// <summary>
/// To detect movement in the garden and flash a light briefly to signify where in the garden the movement is.
/// Primarily for detecting the squirrels that visit us 
/// </summary>
[NetDaemonApp]
public class FlashLightOnMovement
{
    private static bool _processingNotifications;
    private static readonly List<LightState> RestoreLightStates = new();
    private static readonly ConcurrentQueue<NotificationFlash> NotificationQueue = new();
    private static readonly XyColourValue ErrorColour = new()
    {
        // Using White as an error colour
        x = (float) -0.323,
        y = (float) -0.329
    };

    public FlashLightOnMovement(IHaContext ha, ILogger<FlashLightOnMovement> logger)
    {
        var entities = new Entities(ha);

        var notificationLights = new List<LightEntity>
        {
            entities.Light.InfinityLamp,
            entities.Light.DiningCeilingTwo,
            entities.Light.WeeBearCeilingFour,
            entities.Light.DoorLamp,
        };
        // Alert colours depending on which motion sensor set it off
        var notificationList = new Dictionary<BinarySensorEntity, NotificationFlash>
        {
            {entities.BinarySensor.FrontGateMotionOccupancy, new NotificationFlash(notificationLights, "green")},
            {entities.BinarySensor.GardenSquirrelMotionOccupancy, new NotificationFlash(notificationLights, "blue")},
            {entities.BinarySensor.BackGardenMotionOccupancy, new NotificationFlash(notificationLights, "orange")},
            {entities.BinarySensor.GarageRoofMotionOccupancy, new NotificationFlash(notificationLights, "yellow")},

        };

        NotifyOnMovement(notificationList, logger);
    }

    private static void NotifyOnMovement(Dictionary<BinarySensorEntity, NotificationFlash> notificationList, ILogger<FlashLightOnMovement> logger)
    {
        // Register state change event for each motion sensor
        foreach (var motionSensor in notificationList.Keys)
        {
            motionSensor.StateChanges()
                .Where(e => e.New?.State == "on")
                .Subscribe(_ =>
                {
                    if (notificationList.TryGetValue(motionSensor, out var notificationFlash))
                        FlashLights(notificationFlash, logger);
                });
        }
    }

    private static void FlashLights(NotificationFlash notification, ILogger<FlashLightOnMovement> logger)
    {
        logger.LogDebug("FlashLights entered");
        if (!_processingNotifications && NotificationQueue.IsEmpty)
        {
            logger.LogDebug("Not processing notifications and Notification queue is EMPTY!");
            RestoreLightStates.Clear();
            // If the alert queue is empty then we need to save the state of the notification lights
            foreach (var light in notification.NotificationLights)
            {
                var restoreLight = new LightState(light);
                logger.LogDebug("=============Saving Light State ====================");
                if (light.Attributes != null)
                {
                    restoreLight.SavedAttributes = light.Attributes;
                    if (restoreLight.SavedAttributes.XyColor == null)
                    {
                        logger.LogDebug("XyColor is null lamp must be off");
                    }
                    if (restoreLight.LightEntity.Attributes != null)
                    {
                        logger.LogDebug($"{light.Attributes.FriendlyName}");
                        logger.LogDebug($"Brightness = {light.Attributes.Brightness}");
                        logger.LogDebug($"NotificationColour = {light.Attributes.Color}");
                        logger.LogDebug($"Colour_mode = {light.Attributes.ColorMode}");
                        logger.LogDebug($"XY NotificationColour = {light.Attributes.XyColor}");
                    }
                }
                
                logger.LogDebug("=============Saved Light State ====================");

                restoreLight.IsOn = light.IsOn();
                RestoreLightStates.Add(restoreLight);
                logger.LogDebug($"Added light to Restore Light States {RestoreLightStates.Count} items");
            }
        }

        logger.LogDebug($"Adding notification to queue {NotificationQueue.Count} items");
        NotificationQueue.Enqueue(notification);

        if (!NotificationQueue.IsEmpty)
        {
            logger.LogDebug($"Starting processing of Notification queue {NotificationQueue.Count} items");
            _processingNotifications = true;
            while (!NotificationQueue.IsEmpty)
            {
                if (NotificationQueue.TryDequeue(out var notificationFlash))
                    FlashNotification(notificationFlash, logger);
            }

            logger.LogDebug($"Restoring original state of lights Notification Queue {NotificationQueue.Count}");
            RestoreOriginalStates(logger);
        }

        Thread.Sleep(2000);
        logger.LogDebug("FlashLights exited");
        _processingNotifications = false;
    }

    private static void RestoreOriginalStates(ILogger<FlashLightOnMovement> logger)
    {
        logger.LogDebug($"Restore Light States contains {RestoreLightStates.Count} items");
        foreach (var light in RestoreLightStates)
        {
            logger.LogDebug($"Restoring {light.LightEntity.Attributes?.FriendlyName} colour to {light.SavedAttributes.Color}");
            light.LightEntity.TurnOn(CalcTurnOnParameters(light, logger));

            if (!light.IsOn)
            {
                logger.LogDebug("Returning light to off state");
                light.LightEntity.CallService("turn_off");
            }
        }

    }

    private static void FlashNotification(NotificationFlash notification, ILogger<FlashLightOnMovement> logger)
    {
        foreach (var light in notification.NotificationLights)
        {
            logger.LogDebug($"Flashing Notification on light {light.Attributes?.FriendlyName} colour to {notification.NotificationColour}");
            light.TurnOn(brightness: notification.NotificationBrightness, colorName: notification.NotificationColour);
        }
        Thread.Sleep(notification.Duration);
    }

    /// <summary>
    /// Work out how to restore the light to its previous state. If the light is off (at least for my bulbs) we need to take the colour parameter and convert it to the xy_colour
    /// </summary>
    /// <param name="light"></param>
    /// <param name="logger"></param>
    /// <returns></returns>
    private static LightTurnOnParameters CalcTurnOnParameters(LightState light, ILogger logger)
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
        logger.LogDebug($"Deserialised colour to {colour.x}, {colour.y}");
        return new LightTurnOnParameters
        {
            XyColor = new[] {colour.x, colour.y}
        };

    }
}