// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names

using HomeAssistantGenerated;
using System.Collections.Generic;
using System.Threading;
using NetDaemon.HassModel.Entities;

namespace NetDaemonApps.apps.SquiggleyApps;

public class StatusSettings
{
    public StatusSettings(string colour, int duration, bool returnToOriginalState, BinarySensorEntity motionSensor)
    {
        Colour = colour;
        Duration = duration;
        ReturnToOriginalState = returnToOriginalState;
        MotionSensor = motionSensor;
    }

    /// <summary>
    /// Notification colour name
    /// </summary>
    public string Colour { get; set; }
    /// <summary>
    /// How long should the notify colour be visible in milliseconds
    /// </summary>
    public int Duration { get; set; }
    /// <summary>
    /// Should the light return to the original colour
    /// </summary>
    public bool ReturnToOriginalState { get; set; }

    public BinarySensorEntity MotionSensor { get; set; }
}

public class LightsAndAttributes
{
    public LightsAndAttributes(bool isOn, LightEntity lightEntity, LightAttributes savedAttributes)
    {
        IsOn = isOn;
        LightEntity = lightEntity;
        SavedAttributes = savedAttributes;
    }

    /// <summary>
    /// Is the light on when we start
    /// </summary>
    public bool IsOn { get; set; }
    public LightEntity LightEntity { get; set; }
    public LightAttributes SavedAttributes { get; set; }
}

[NetDaemonApp]
public class FlashLightOnMovement
{
    private const int DefaultDuration = 1000;
    private readonly ILogger<FlashLightOnMovement> _logger;

    public FlashLightOnMovement(IHaContext ha, ILogger<FlashLightOnMovement> logger)
    {
        _logger = logger;
        var entities = new Entities(ha);

        // These settings will hopefully be filled in by a gui at some point
        var statusSettings = new List<StatusSettings>
        {
            new("green", DefaultDuration, true, entities.BinarySensor.FrontGateMotionOccupancy),
            new("blue", DefaultDuration, true, entities.BinarySensor.GardenSquirrelMotionOccupancy),
            new("orange", DefaultDuration, true, entities.BinarySensor.BackCornerMotion),
            new("yellow", DefaultDuration, true, entities.BinarySensor.GarageRoofMotionOccupancy)
        };
        var lightsAndAttributes = new List<LightsAndAttributes>
        {
            new(entities.Light.InfinityLamp.IsOn(), entities.Light.InfinityLamp, new LightAttributes())
        };

        NotifyOnMovement(lightsAndAttributes, statusSettings, _logger);
    }

    private static void NotifyOnMovement(List<LightsAndAttributes> lights, List<StatusSettings> statusSettings, ILogger<FlashLightOnMovement> logger)
    {
        foreach (var statusSetting in statusSettings)
        {
            statusSetting.MotionSensor.StateChanges()
                .Where(e => e.New?.State == "on")
                .Subscribe(_ => { FlashLights(lights, logger, statusSetting); });

        }
    }

    private static void FlashLights(List<LightsAndAttributes> lights, ILogger logger, StatusSettings statusSetting)
    {
        foreach (var light in lights)
        {
            if (statusSetting.ReturnToOriginalState)
            {
                logger.LogDebug("=============Saving Light State ====================");
                var lightEntity = light.LightEntity;
                if (lightEntity.Attributes != null)
                {
                    light.SavedAttributes = lightEntity.Attributes;
                    if (light.LightEntity.Attributes != null)
                    {
                        logger.LogDebug($"{light.LightEntity.Attributes.FriendlyName}");
                        logger.LogDebug($"Colour = {light.LightEntity.Attributes.Color}");
                        logger.LogDebug($"Colour_mode = {light.LightEntity.Attributes.ColorMode}");
                        logger.LogDebug($"XY Colour = {light.LightEntity.Attributes.XyColor}");
                    }
                }

                logger.LogDebug("=============Saved Light State ====================");
            }

            light.IsOn = light.LightEntity.IsOn();

            logger.LogDebug($"Changing {light.LightEntity.Attributes?.FriendlyName} colour to {statusSetting.Colour}");
            light.LightEntity.TurnOn(brightness: 255, colorName: statusSetting.Colour);
        }
        Thread.Sleep(statusSetting.Duration);

        if (!statusSetting.ReturnToOriginalState) return;
        foreach (var light in lights)
        {
            logger.LogDebug($"Restoring {light.LightEntity.Attributes?.FriendlyName} colour to {light.SavedAttributes.Color}");
            light.LightEntity.TurnOn(new LightTurnOnParameters
            {
                Brightness = Convert.ToInt64(light.SavedAttributes.Brightness),
                XyColor = light.SavedAttributes.XyColor
            });

            if (!light.IsOn)
            {
                light.LightEntity.CallService("turn_off");
            }
        }
    }
}