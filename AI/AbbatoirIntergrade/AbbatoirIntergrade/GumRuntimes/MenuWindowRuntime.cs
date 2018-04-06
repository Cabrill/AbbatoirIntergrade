using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall;
using FlatRedBall.Gui;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class MenuWindowRuntime
    {
        partial void CustomInitialize()
        {
            CloseButton.Click += window => PlayerDataManager.SaveData();
        }

        public void AssignEventToCloseButton(Action<IWindow> assignedEvent)
        {
            CloseButton.Click += assignedEvent.Invoke;
        }

        public void AssignEventToButton1(Action<IWindow> assignedEvent)
        {
            ButtonFrameInstance.Click += assignedEvent.Invoke;
        }

        public void AssignEventToButton2(Action<IWindow> assignedEvent)
        {
            ButtonFrameInstance1.Click += assignedEvent.Invoke;
        }

        public void AssignEventToButton3(Action<IWindow> assignedEvent)
        {
            ButtonFrameInstance2.Click += assignedEvent.Invoke;
        }

        public void AssignEventToButton4(Action<IWindow> assignedEvent)
        {
            ButtonFrameInstance3.Click += assignedEvent.Invoke;
        }

        public void RefreshOptions()
        {
            OptionsControlsInstance.RefreshValues();
        }

        public void SimulateCloseButtonClick()
        {
            CloseButton.CallClick();
        }
    }
}
