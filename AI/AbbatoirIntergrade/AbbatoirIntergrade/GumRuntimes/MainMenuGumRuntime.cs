using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class MainMenuGumRuntime
    {
        public void UpdateDimming()
        {
            DimmingInstance.DimmingAlpha = (int)((0.2f - (LeftEye.CurrentEyeHeight / (5*428f))) * 255);
        }
    }
}
