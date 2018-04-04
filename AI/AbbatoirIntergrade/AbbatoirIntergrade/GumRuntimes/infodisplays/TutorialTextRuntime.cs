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

        public void ShowText(string text, bool requireConfirmation)
        {
            HasBeenConfirmed = false;
            TextInstance.Text = text;
            CurrentConfirmationState = requireConfirmation ? Confirmation.Allow : Confirmation.Denied;
            Visible = true;

            ConfirmationButton.Click += window =>
            {
                HasBeenConfirmed = true;
                Visible = false;
            };
        }
    }
}
