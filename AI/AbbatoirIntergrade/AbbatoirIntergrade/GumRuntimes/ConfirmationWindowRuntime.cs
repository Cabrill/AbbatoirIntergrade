using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Gui;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class ConfirmationWindowRuntime
    {
        private Action _onConfirm;
        private Action _onCancel;

        partial void CustomInitialize()
        {
            ConfirmButton.Click += ConfirmButtonOnClick;
            CancelButton.Click += CancelButtonOnClick;
        }

        public void Confirm(string message, Action onConfirm, Action onCancel = null)
        {
            Visible = true;
            MessageText.Text = message;
            _onConfirm = onConfirm;
            _onCancel = onCancel;
        }

        private void CancelButtonOnClick(IWindow window)
        {
            Visible = false;
            _onCancel?.Invoke();
        }

        private void ConfirmButtonOnClick(IWindow window)
        {
            Visible = false;
            _onConfirm?.Invoke();
        }
    }
}
