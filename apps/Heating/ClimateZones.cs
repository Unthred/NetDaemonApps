using System.Collections.Generic;
using HomeAssistantGenerated;

namespace NetDaemonApps.apps.Heating;

public record ClimateZone(ClimateEntity Climate, BinarySensorEntity[]? Windows = null);

public class ClimateZones
{
    public ClimateZones(IHaContext ha)
    {
        var entities = new Entities(ha);
        var climate = entities.Climate;
        var binarySensor = entities.BinarySensor;

        Zones = new ClimateZone[]
        {
            new (climate.Vestibule, new []
            {
                binarySensor.FrontDoorSensorContact
            }),
            new (climate.Livingroom, new []
            {
                binarySensor.LivingroomWindowOneSensorContact, binarySensor.LivingroomWindowTwoSensorContact
            }),
            new (climate.Office, new []
            {
                binarySensor.OfficeWindowSensorOneContact, binarySensor.OfficeWindowSensorTwoContact
            }),
            new (climate.Bathroom, new[]
            {
                binarySensor.BathroomWindowSensorContact
            }),
            new (climate.Bedroom, new[]
            {
                binarySensor.BedroomWindowSensorOneContact, binarySensor.BedroomWindowSensorTwoContact
            }),
            new (climate.Kitchen, new[]
            {
                binarySensor.KitchenWindowSensorContact, binarySensor.BackDoorSensorContact
            }),
            new (climate.Weebear, new []
            {
                binarySensor.WeeBearWindowSensorOneContact, binarySensor.WeeBearWindowSensorTwoContact
            }),
        };
    }
    public IEnumerable<ClimateZone> Zones { get; }

}