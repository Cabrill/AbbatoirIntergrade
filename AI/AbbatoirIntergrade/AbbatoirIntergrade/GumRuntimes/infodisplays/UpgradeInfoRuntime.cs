using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GumRuntimes.infodisplays
{
    public partial class UpgradeInfoRuntime
    {
        public Action OnUpgradeButton1Click;
        public Action OnUpgradeButton2Click;

        partial void CustomInitialize()
        {
            Upgrade1Type.Click += window => OnUpgradeButton1Click?.Invoke();
            Upgrade2Type.Click += window => OnUpgradeButton2Click?.Invoke();
        }
    }
}
