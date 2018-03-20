using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.GameClasses;
using AbbatoirIntergrade.StaticManagers;
using Gum.Converters;
using RenderingLibrary.Graphics;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class ChatHistoryRuntime
    {
        public EventHandler CloseButtonClick;

        partial void CustomInitialize()
        {
            CloseButton.Click += window => CloseButtonClick?.Invoke(CloseButton, null);
        }

        public void PopulateWithRecentChatHistory()
        {
            InnerPanelInstance.Children.Clear();

            var dialogueHistory = PlayerDataManager.DialogueHistory;
            var dialogue = GameStateManager.GameDialogue;

            foreach (var dialogueTuple in dialogueHistory)
            {
                var shownBox = new ChatOptionRuntime(true);
                var shownDialogue = dialogue.DialogueList.FirstOrDefault(d => d.Id == dialogueTuple.Key);
                shownBox.SetDialogue(shownDialogue);
                shownBox.CurrentHighlightState = ChatOptionRuntime.Highlight.Highlighted;
                shownBox.HasEvents = false;
                shownBox.XOrigin = HorizontalAlignment.Right;
                shownBox.XUnits = GeneralUnitType.PixelsFromLarge;
                shownBox.Parent = InnerPanelInstance;

                if (dialogueTuple.Value != "")
                {
                    var responseBox = new ChatOptionRuntime(true);
                    var responseDialogue = dialogue.DialogueList.FirstOrDefault(d => d.Id == dialogueTuple.Value);
                    responseBox.SetDialogue(responseDialogue);
                    responseBox.ChatColorState = ChatOptionFrameRuntime.ColorState.Green;
                    responseBox.HasEvents = false;
                    responseBox.Parent = InnerPanelInstance;
                }
            }
        }

        public void PopulateWithAllChatHistory()
        {
            InnerPanelInstance.Children.Clear();

            var chatHistory = PlayerDataManager.DialogueHistory;
            var allDialogue = GameStateManager.GameDialogue;

            foreach (var chat in chatHistory)
            {
                var aiMessage = new ChatOptionRuntime(true)
                {
                    ChatText = allDialogue.GetDialogueText(chat.Key),
                    XOrigin = HorizontalAlignment.Left,
                    XUnits = GeneralUnitType.PixelsFromSmall,
                    Parent = FormsControl.InnerPanel,
                    HasEvents = false,
                    ChatColorState = ChatOptionFrameRuntime.ColorState.Green
                };


                var response = new ChatOptionRuntime(true)
                {
                    ChatText = allDialogue.GetDialogueText(chat.Value),
                    XOrigin = HorizontalAlignment.Right,
                    XUnits = GeneralUnitType.PixelsFromLarge,
                    Parent = FormsControl.InnerPanel,
                    HasEvents = false,
                    ChatColorState = ChatOptionFrameRuntime.ColorState.Black
                };
            }
        }
    }
}
