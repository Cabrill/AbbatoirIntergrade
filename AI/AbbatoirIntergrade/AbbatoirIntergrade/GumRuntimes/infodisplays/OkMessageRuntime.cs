using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GumRuntimes.infodisplays
{
    public partial class OkMessageRuntime
    {
        partial void CustomInitialize()
        {
            OKButton.Click += window => Visible = false;
        }

        public void ShowMessage(string text)
        {
            Visible = true;
            MessageText = text;
        }
    }
}
