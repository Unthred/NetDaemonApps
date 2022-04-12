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
        public int Brightness { get; set; }
    }
    public class FlashNotificationConfig
    {
        public int NotificationDuration { get; set; }
        public IList<FlashNotification>? FlashNotifications { get; set; }
        public List<LightEntity> Lights { get; set; }
    }
}
