using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace NetDaemonApps.apps.Models
{
    public class LightState
    {
        public LightState(LightEntity lightEntity)
        {
            LightEntity = lightEntity;
            IsOn = lightEntity.IsOn();
            SavedAttributes = new LightAttributes();
        }

        /// <summary>
        /// Is the light on when we start
        /// </summary>
        public bool IsOn { get; set; }

        public LightEntity LightEntity { get; set; }
        public LightAttributes SavedAttributes { get; set; }
    }
}
