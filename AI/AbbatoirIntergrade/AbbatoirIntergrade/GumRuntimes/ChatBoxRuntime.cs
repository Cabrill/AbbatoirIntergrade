using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.GameClasses;
using AbbatoirIntergrade.GumRuntimes.infodisplays;
using FlatRedBall.Glue.StateInterpolation;
using FlatRedBall.Gui;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class ChatBoxRuntime
    {
        public Dialogue SilentDialogue;
        public EventHandler DialogueChosen;
        public EventHandler ChatHistoryButtonClick;

        private bool _hasResponseAvailable;
        public Dialogue CurrentIncomingMessage;

        partial void CustomInitialize()
        {
            CloseChatButtonInstance.Click += CloseChatButtonInstanceOnClick;
            MessageBox.Click += MessageBoxOnClick;
            MessageBox.RollOn += MessageBoxOnRollOn;
            MessageBox.RollOff += MessageBoxOnRollOff;

            ChatOption0.Click += ChatOptionOnClick;
            ChatOption1.Click += ChatOptionOnClick;
            ChatOption2.Click += ChatOptionOnClick;
            ChatHistoryButton.Click += ChatHistoryButtonOnClick;

            DisappearAnimation.AddAction("ChatClosed", SetUnreadMessageIndicator);
            AppearAnimation.AddAction("ChatOpen", SetupResponseAvailability);
        }

        public void SetupResponseAvailability()
        {
            CurrentAppearanceState = Appearance.ChatOpen;

            var newResponseState = _hasResponseAvailable ? ResponseAvailability.AwaitingResponse : ResponseAvailability.AlreadyResponded;
            InterpolateTo(newResponseState, 1f, InterpolationType.Exponential, Easing.Out);
        }

        private void SetUnreadMessageIndicator()
        {
            CurrentAppearanceState = Appearance.ChatClosed;

            CurrentMessageIndicatorState = _hasResponseAvailable
                ? MessageIndicator.NewMessage
                : MessageIndicator.NoMessage;
        }

        private void ChatHistoryButtonOnClick(IWindow window)
        {
            if (CurrentAppearanceState == Appearance.ChatOpen)
            {
                ChatHistoryButtonClick?.Invoke(window, null);
            }
        }

        private void ChatOptionOnClick(IWindow window)
        {
            if (window is ChatOptionRuntime chatoption)
            {
                DialogueShownChatOption.SetDialogue(CurrentIncomingMessage);
                ResponseChosenChatOption.SetDialogue(chatoption.CurrentDialogue);

                DialogueShownChatOption.HasEvents = false;
                ResponseChosenChatOption.HasEvents = false;

                DialogueChosen?.Invoke(chatoption, null);
                _hasResponseAvailable = false;
            }
        }

        private void MessageBoxOnRollOff(IWindow window)
        {
            switch (CurrentMessageIndicatorState)
            {
                case MessageIndicator.NewMessageHighlighted:
                    CurrentMessageIndicatorState = MessageIndicator.NewMessage;
                    break;
                case MessageIndicator.NoMessageHighlighted:
                    CurrentMessageIndicatorState = MessageIndicator.NoMessage;
                    break;
            }
        }

        private void MessageBoxOnRollOn(IWindow window)
        {
            switch (CurrentMessageIndicatorState)
            {
                case MessageIndicator.NewMessage:
                    CurrentMessageIndicatorState = MessageIndicator.NewMessageHighlighted;
                    break;
                case MessageIndicator.NoMessage:
                    CurrentMessageIndicatorState = MessageIndicator.NoMessageHighlighted;
                    break;
            }
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
            CurrentIncomingMessage = aitext;
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

            _hasResponseAvailable = true;

            AlertNewMessage();
        }


        private void AlertNewMessage()
        {
            CurrentMessageIndicatorState = CurrentMessageIndicatorState == MessageIndicator.NoMessageHighlighted ? 
                MessageIndicator.NewMessageHighlighted : 
                MessageIndicator.NewMessage;
        }
    }
}
