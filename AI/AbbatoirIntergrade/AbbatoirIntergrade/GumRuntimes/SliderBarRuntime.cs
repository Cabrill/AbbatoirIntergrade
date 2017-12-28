using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class SliderBarRuntime
    {
        partial void CustomInitialize()
        {
            FormsControl.IsSnapToTickEnabled = false;
            FormsControl.IsMoveToPointEnabled = true;
        }
    }
}
