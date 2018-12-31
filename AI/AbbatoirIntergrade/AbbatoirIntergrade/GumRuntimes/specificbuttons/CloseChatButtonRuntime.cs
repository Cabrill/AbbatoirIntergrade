using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Gui;

namespace AbbatoirIntergrade.GumRuntimes.specificbuttons
{
    partial class CloseChatButtonRuntime
    {
        partial void CustomInitialize()
        {
            RollOn += OnRollOn;
            RollOff += OnRollOff;
        }

        private void OnRollOff(IWindow window)
        {
            CurrentHighlightState = Highlight.NotHighlighted;
        }

        private void OnRollOn(IWindow window)
        {
            CurrentHighlightState = Highlight.Highlighted;
        }
    }
}
