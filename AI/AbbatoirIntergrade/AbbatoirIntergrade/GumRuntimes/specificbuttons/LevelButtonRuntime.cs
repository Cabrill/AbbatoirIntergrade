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
        public int LevelAsNumber => int.Parse(this.Name.Replace("LevelButtonInstance", ""));
        public bool IsEnabled => Enabled && CurrentButtonCategoryState != ButtonCategory.Disabled;

        public void Disable()
        {
            CurrentButtonCategoryState = ButtonCategory.Disabled;
            Enabled = false;
            FormsControl.IsEnabled = false;
        }
    }
}
