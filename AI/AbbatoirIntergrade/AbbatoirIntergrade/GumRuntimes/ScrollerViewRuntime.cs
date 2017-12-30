using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class ScrollerViewRuntime
    {
        public EventHandler CloseButtonClick;

        partial void CustomInitialize()
        {
            CloseButton.Click += window => CloseButtonClick?.Invoke(CloseButton, null);
        }
    }
}
