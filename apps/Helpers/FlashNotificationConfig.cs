using System.Collections.Generic;
using HomeAssistantGenerated;

namespace NetDaemonApps.apps.Helpers
{
    public class FlashNotificationTest
    {
        public string? Name { get; set; }
    }

    public class FlashNotification
    {
        public string? Name { get; set; }
        public BinarySensorEntity? MotionSensor { get; set; }
        public string? Colour { get; set; }
        public int Duration { get; set; }
        public int Brightness { get; set; }
        public List<LightEntity>? LightEntities { get; set; }
    }
    public class FlashNotificationConfig
    {
        public IList<FlashNotification>? FlashNotifications { get; set; }  
    }
}
