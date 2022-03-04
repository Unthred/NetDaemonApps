using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAssistantGenerated;

namespace NetDaemonApps.apps.SquiggleyApps
{
    [NetDaemonApp]
    public class LightOnTest
    {

        public LightOnTest(IHaContext ha)
        {
            var entities = new Entities(ha);
            entities.Light.OfficeCeilingFour.TurnOn(brightness: 255, colorName: "blue");
        }
    }
}
