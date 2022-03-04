using System.Collections.Generic;
using HomeAssistantGenerated;

namespace NetDaemonApps.apps.Models
{
    public class NotificationFlash
    {
        private const int DefaultDuration = 500;

        public NotificationFlash(List<LightEntity> notificationLights, string notificationColour, int duration = DefaultDuration, int brightness = 255)
        {
            NotificationColour = notificationColour;
            Duration = duration;
            NotificationBrightness = brightness;
            NotificationLights = notificationLights;
        }

        /// <summary>
        /// List of lights to flash with this notification
        /// </summary>
        public List<LightEntity> NotificationLights { get; set; }
        /// <summary>
        /// Notification notificationColour name
        /// </summary>
        public string NotificationColour { get; set; }
        /// <summary>
        /// How long should the notify notificationColour be visible in milliseconds
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// How bright the light should be when it flashes the notification
        /// </summary>
        public int NotificationBrightness { get; set; }

    }
}
