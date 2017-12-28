using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gum.Wireframe;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class LevelButtonRuntime
    {
        public string LevelName => "Chapter" + this.Name.Replace("LevelButtonInstance", "")+ "Level";
    }
}
