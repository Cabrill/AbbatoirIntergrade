using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class ResistanceDisplayRuntime
    {
        public void SetResistanceText(double resistanceAmt)
        {
            ResistanceText = $"{(resistanceAmt * 100):##0}%";
            ResistanceTextInstance.Green = (int)(255 * Math.Min(1, resistanceAmt * 2));
            ResistanceTextInstance.Red = (int)(255 * Math.Min(1, 2 - resistanceAmt * 2));
            ResistanceTextInstance.Blue = 0;
        }
    }
}
