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
            var chatHistory = PlayerDataManager.DialogueHistory;
            var allDialogue = GameStateManager.GameDialogue;

            var chatCount = 0;

            foreach (var chat in chatHistory)
            {
                ChatOptionRuntime aiMessage;
                ChatOptionRuntime playerResponse;

                if (FormsControl.InnerPanel.Children.Count < chatCount)
                {
                    aiMessage = FormsControl.InnerPanel.Children[chatCount++] as ChatOptionRuntime;
                    aiMessage.ChatText = allDialogue.GetDialogueText(chat.Key);
                    aiMessage.XOrigin = HorizontalAlignment.Left;
                    aiMessage.XUnits = GeneralUnitType.PixelsFromSmall;
                    aiMessage.Parent = FormsControl.InnerPanel;
                    aiMessage.HasEvents = false;
                    aiMessage.ChatColorState = ChatOptionFrameRuntime.ColorState.Green;
                }
                else
                {
                    aiMessage = new ChatOptionRuntime(true)
                    {
                        ChatText = allDialogue.GetDialogueText(chat.Key),
                        XOrigin = HorizontalAlignment.Left,
                        XUnits = GeneralUnitType.PixelsFromSmall,
                        Parent = FormsControl.InnerPanel,
                        HasEvents = false,
                        ChatColorState = ChatOptionFrameRuntime.ColorState.Green
                    };
                }
                if (FormsControl.InnerPanel.Children.Count < chatCount)
                {
                    playerResponse = FormsControl.InnerPanel.Children[chatCount++] as ChatOptionRuntime;
                    playerResponse.ChatText = allDialogue.GetDialogueText(chat.Value);
                    playerResponse.XOrigin = HorizontalAlignment.Right;
                    playerResponse.XUnits = GeneralUnitType.PixelsFromLarge;
                    playerResponse.Parent = FormsControl.InnerPanel;
                    playerResponse.HasEvents = false;
                    playerResponse.ChatColorState = ChatOptionFrameRuntime.ColorState.Black;
                }
                else
                {
                    playerResponse = new ChatOptionRuntime(true)
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
}
