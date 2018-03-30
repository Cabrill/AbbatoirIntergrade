using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Gui;
using OpenTK;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class TopStatusBarRuntime
    {
        public double TimeScale { get; private set; } = 1.0;

        public event Action<IWindow> MenuButtonInstanceClick;
        public event Action<IWindow> PauseButtonInstanceClick;
        public event Action<IWindow> PlayButtonInstanceClick;
        public event Action<IWindow> FastForwardButtonInstanceClick;

        public bool WasPausedWhenMenuClicked;

        partial void CustomInitialize()
        {
            PauseButton.Click += OnPauseButtonClick;
            MenuButton.Click += OnMenuButtonClick;
            PlayButton.Click += OnPlayButtonOnClick;
            FastForwardButton.Click += OnFastForwardButtonClick;
        }

        private void OnPauseButtonClick(IWindow window)
        {
            PauseButtonInstanceClick?.Invoke(window);
            PlayButton.CurrentSelectState = ButtonFrameRuntime.Select.NotSelected;
            PauseButton.CurrentSelectState = ButtonFrameRuntime.Select.Selected;
            FastForwardButton.CurrentSelectState = ButtonFrameRuntime.Select.NotSelected;
        }

        private void OnFastForwardButtonClick(IWindow window)
        {
            FastForwardButtonInstanceClick?.Invoke(window);
            TimeScale = 2.5;
            SetFRBTimeScale();
            PlayButton.CurrentSelectState = ButtonFrameRuntime.Select.NotSelected;
            PauseButton.CurrentSelectState = ButtonFrameRuntime.Select.NotSelected;
            FastForwardButton.CurrentSelectState = ButtonFrameRuntime.Select.Selected;
        }

        private void OnPlayButtonOnClick(IWindow window)
        {
            PlayButtonInstanceClick?.Invoke(window);
            TimeScale = 1;
            SetFRBTimeScale();
            PlayButton.CurrentSelectState = ButtonFrameRuntime.Select.Selected;
            PauseButton.CurrentSelectState = ButtonFrameRuntime.Select.NotSelected;
            FastForwardButton.CurrentSelectState = ButtonFrameRuntime.Select.NotSelected;
        }

        private void OnMenuButtonClick(IWindow window)
        {
            WasPausedWhenMenuClicked = PauseButton.CurrentSelectState == ButtonFrameRuntime.Select.Selected;
            MenuButtonInstanceClick?.Invoke(window);
            PlayButton.CurrentSelectState = ButtonFrameRuntime.Select.NotSelected;
            FastForwardButton.CurrentSelectState = ButtonFrameRuntime.Select.NotSelected;
            PauseButton.CurrentSelectState = ButtonFrameRuntime.Select.Selected;
        }

        public void PauseForMenu(bool isPaused)
        {
            if (isPaused || WasPausedWhenMenuClicked)
            {
                PauseButton.CurrentSelectState = ButtonFrameRuntime.Select.Selected;
            }
            else
            {
                PauseButton.CurrentSelectState = ButtonFrameRuntime.Select.NotSelected;

                if (TimeScale > 1)
                {
                    FastForwardButton.CurrentSelectState = ButtonFrameRuntime.Select.Selected;
                }
                else
                {
                    PlayButton.CurrentSelectState = ButtonFrameRuntime.Select.Selected;
                }
            }
        }

        private void SetFRBTimeScale()
        {
            FlatRedBall.TimeManager.TimeFactor = TimeScale;
        }

        public void SimulateMenuButtonClick()
        {
            MenuButton.CallClick();
        }

        public void UpdateWave(int currentLevelCurrentWaveNumber, int totalWaves)
        {
            WaveTextInstance.Text =  $"{currentLevelCurrentWaveNumber} / {totalWaves}";
        }

        public void UpdateTime(double currentTime, bool isPaused)
        {
            var totalSeconds = (int)currentTime;
            var milliSeconds = (int)((currentTime - totalSeconds) * 100);
            var seconds = totalSeconds % 60;
            var minutes = totalSeconds / 60;
            var  time = minutes.ToString("00") + ":" + seconds.ToString("00") + "." + milliSeconds.ToString("00");

            TimeTextInstance.Text = $"{time}";

            if (isPaused && !PulseTimeAnimation.IsPlaying()) PulseTimeAnimation.Play();
            if (!isPaused && PulseTimeAnimation.IsPlaying())
            {
                PulseTimeAnimation.Stop();
                CurrentTimeDisplayState = TimeDisplay.DefaultTime;
            }
        }
    }
}
