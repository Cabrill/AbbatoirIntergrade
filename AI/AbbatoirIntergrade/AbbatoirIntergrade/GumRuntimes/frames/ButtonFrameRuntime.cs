using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.GumRuntimes;
using FlatRedBall.Gui;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class ButtonFrameRuntime
    {
        partial void CustomInitialize()
        {
            RollOff += CircleButtonInstanceOnRollOff;
            RollOver += OnRollOver;
        }

        private void OnRollOver(IWindow window)
        {
            CurrentHighlightState = HasCursorOver(GuiManager.Cursor) ? Highlight.Highlighted : Highlight.NotHighlighted;
        }

        private void CircleButtonInstanceOnRollOff(IWindow window)
        {
            CurrentHighlightState = Highlight.NotHighlighted;
        }
    }
}
