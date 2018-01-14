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

        public void PopulateWithChatHistory()
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
    }
}
