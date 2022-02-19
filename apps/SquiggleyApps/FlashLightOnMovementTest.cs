// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names

using HomeAssistantGenerated;

namespace NetDaemonApps.apps.SquiggleyApps;

[NetDaemonApp]
public class FlashLightOnMovementTest
{
    private readonly ILogger<FlashLightOnMovementTest> _logger;

    public FlashLightOnMovementTest(IHaContext ha, ILogger<FlashLightOnMovementTest> logger)
    {
        _logger = logger;
        var entities = new Entities(ha);
        var light = entities.Light.InfinityLamp;
        entities.BinarySensor.GarageRoofMotionOccupancy
            .StateChanges()
            .Where(e => e.New?.State == "on")
            .Subscribe(_ => { FlashLight(light, logger); });
    }

    private static void FlashLight(LightEntity light, ILogger logger)
    {
        logger.LogDebug("Motion Sensor Activated");

        light.CallService("turn_on", data: new
        {
            brightness_pct = 60, 
            color_name = "yellow"
        });
        light.CallService("turn_on", data: new
        {
            brightness_pct = 70,
            color_name = "red"
        });
        light.CallService("turn_on", data: new
        {
            brightness_pct = 80,
            color_name = "blue"
        });
        light.CallService("turn_on", data: new
        {
            brightness_pct = 90,
            color_name = "green"
        });
        logger.LogDebug("Colour should be green here");
    }
}