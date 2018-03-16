using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall;
using FlatRedBall.Gui;
using Microsoft.Xna.Framework.Graphics;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class MenuWindowRuntime
    {
        public List<DisplayMode> DisplayModes
        {
            get
            {
                var allModes = FlatRedBallServices.GraphicsDevice.Adapter.SupportedDisplayModes;
                return allModes.Where(m => m.Height >= 1024).ToList();
            }
        }

        partial void CustomInitialize()
        {
            
        }

        public void AssignEventToCloseButton(Action<IWindow> assignedEvent)
        {
            CloseButton.Click += assignedEvent.Invoke;
        }

        public void AssignEventToButton0(Action<IWindow> assignedEvent)
        {
            ButtonFrameInstance.Click += assignedEvent.Invoke;
        }

        public void AssignEventToButton1(Action<IWindow> assignedEvent)
        {
            ButtonFrameInstance1.Click += assignedEvent.Invoke;
        }

        public void AssignEventToButton2(Action<IWindow> assignedEvent)
        {
            ButtonFrameInstance2.Click += assignedEvent.Invoke;
        }

        public void AssignEventToButton3(Action<IWindow> assignedEvent)
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
