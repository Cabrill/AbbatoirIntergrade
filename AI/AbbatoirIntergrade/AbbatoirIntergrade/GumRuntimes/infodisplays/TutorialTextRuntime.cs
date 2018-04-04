using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GumRuntimes
{
    partial class TutorialTextRuntime
    {
        public bool HasBeenConfirmed;

        public void ShowText(string text, bool allowConfirmation)
        {
            HasBeenConfirmed = false;
            TextInstance.Text = text;
            CurrentConfirmationState = allowConfirmation ? Confirmation.Allow : Confirmation.Denied;
            ConfirmationButton.Click += window => HasBeenConfirmed = true;
        }
    }
}
