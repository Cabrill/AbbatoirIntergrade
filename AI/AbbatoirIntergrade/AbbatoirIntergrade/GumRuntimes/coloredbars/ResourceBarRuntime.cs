using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GumRuntimes.coloredbars
{
    public partial class ResourceBarRuntime
    {
        public void UpdateBar(double current, double total)
        {

            if (total > 0)
            {
                BarFillPercent = (float)(current / total) * 100f;
            }
            else
            {
                BarFillPercent = 100;
            }
        }
    }
}
