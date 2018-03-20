using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class LocationTimeAnnouncementRuntime
    {
        public void Display(string location, DateTime time)
        {
            LocationText.Text = location;
            DateTimeText.Text = time.ToString("F") + " UTC";
            AppearAnimation.PlayAfter(1f);
        }
    }
}
