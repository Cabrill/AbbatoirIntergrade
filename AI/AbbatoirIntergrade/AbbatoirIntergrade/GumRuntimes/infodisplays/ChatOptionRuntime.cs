using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.GameClasses;
using FlatRedBall.Gui;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class ChatOptionRuntime
    {
        public Dialogue CurrentDialogue { get; private set; }

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

        public void SetDialogue(Dialogue dialogue)
        {
            CurrentDialogue = dialogue;
            if (dialogue != null)
            {
                TextInstance.Text = dialogue.DisplayText;
            }
            else
            {
                Visible = false;
            }
        }
    }
}
