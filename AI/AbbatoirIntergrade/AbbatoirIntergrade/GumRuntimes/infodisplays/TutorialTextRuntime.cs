using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GumRuntimes.infodisplays
{
    partial class TutorialTextRuntime
    {
        public bool HasBeenConfirmed;
        public Action OnSkipTutorialClicked;

        public void ShowText(string text, bool requireConfirmation, bool allowSkip, bool onLeft)
        {
            HasBeenConfirmed = false;
            TextInstance.Text = text;
            CurrentPlacementState = onLeft ? Placement.Left : Placement.Right;
            CurrentConfirmationState = requireConfirmation ? Confirmation.Allow : Confirmation.Denied;
            CurrentSkipTutorialState = allowSkip ? SkipTutorial.ShowSkip : SkipTutorial.DontShow;
            Visible = true;

            SkipTutorialButton.Click += window =>
            {
                OnSkipTutorialClicked?.Invoke();
                Visible = false;
            };
            ConfirmationButton.Click += window =>
            {
                HasBeenConfirmed = true;
                Visible = false;
            };
        }
    }
}
