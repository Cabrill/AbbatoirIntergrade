using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.GameClasses;
using FlatRedBall.Gui;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class ChatBoxRuntime
    {
        private Dialogue SilentDialogue;
        public EventHandler DialogueChosen;

        partial void CustomInitialize()
        {
            CloseChatButtonInstance.Click += CloseChatButtonInstanceOnClick;
            MessageBox.Click += MessageBoxOnClick;
            MessageBox.RollOn += MessageBoxOnRollOn;
            MessageBox.RollOff += MessageBoxOnRollOff;

            ChatOption0.Click += ChatOptionOnClick;
            ChatOption1.Click += ChatOptionOnClick;
            ChatOption2.Click += ChatOptionOnClick;
        }

        private void ChatOptionOnClick(IWindow window)
        {
            if (window is ChatOptionRuntime chatoption)
            {
                DialogueChosen?.Invoke(chatoption, null);
            }
        }

        private void MessageBoxOnRollOff(IWindow window)
        {
            CurrentMessageIndicatorState = MessageIndicator.NewMessage;
        }

        private void MessageBoxOnRollOn(IWindow window)
        {
            CurrentMessageIndicatorState = MessageIndicator.Highlighted;
        }

        private void CloseChatButtonInstanceOnClick(IWindow window)
        {
            DisappearAnimation.Play();
        }

        private void MessageBoxOnClick(IWindow window)
        {
            if (CurrentAppearanceState == Appearance.ChatClosed)
            {
                AppearAnimation.Play();
            }
        }

        public void UpdateDialogue(Dialogue aitext, List<Dialogue> options)
        {
            CurrentText.Text = aitext.DisplayText;

            var silenceDialogue = options.FirstOrDefault(d => d.DisplayName == "Silence");

            SilentDialogue = silenceDialogue;

            if (silenceDialogue != null)
            {
                options.Remove(silenceDialogue);
            }

            ChatOption0.SetDialogue(options.Count > 0 ? options[0] : null);
            ChatOption1.SetDialogue(options.Count > 1 ? options[1] : null);
            ChatOption2.SetDialogue(options.Count > 2 ? options[2] : null);
        }
    }
}
