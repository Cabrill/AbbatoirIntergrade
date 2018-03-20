using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Gui;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall;

namespace AbbatoirIntergrade.Screens
{
    public partial class GameScreen
    {
        private void SetInfoBarControls()
        {
            //Settings button
            TopStatusBarInstance.MenuButtonInstanceClick += OnMenuButtonClick;
            TopStatusBarInstance.PauseButtonInstanceClick += OnPauseButtonClick;
            TopStatusBarInstance.PlayButtonInstanceClick += OnPlayButtonClick;
            TopStatusBarInstance.FastForwardButtonInstanceClick += OnFastForwardButtonClick;

            MenuWindowInstance.AssignEventToCloseButton(OnMenuCloseButtonClick);
            MenuWindowInstance.AssignEventToButton0(window =>
            {
                AnalyticsManager.FlushDeferredEvents();
                PlayerDataManager.LoadData();
                LoadingScreen.TransitionToScreen(typeof(MapScreen));
            });

            if (CurrentLevel.MapName != "Chapter1")
            {
                MenuWindowInstance.ButtonType3State = ButtonFrameRuntime.ButtonType.History;
                MenuWindowInstance.AssignEventToButton2(window =>
                {
                    ChatHistoryInstance.PopulateWithAllChatHistory();
                    ChatHistoryInstance.Visible = true;
                    ChatHistoryInstance.CloseButtonClick = (sender, args) => ChatHistoryInstance.Visible = false;
                });
            }

            //MenuWindowInstance.AssignEventToButton4(window => OkMessageInstance.ShowMessage(Messages["Intro"].MessageText));
        }

        private void OnFastForwardButtonClick(IWindow obj)
        {
            if (IsPaused) UnpauseThisScreen();
        }

        private void OnPlayButtonClick(IWindow obj)
        {
            if (IsPaused) UnpauseThisScreen();
        }

        private void OnPauseButtonClick(IWindow obj)
        {
            if (IsPaused) UnpauseThisScreen();
            else PauseThisScreen();
        }

        private void OnMenuButtonClick(IWindow window)
        {
            MenuWindowInstance.RefreshOptions();
            MenuWindowInstance.Visible = true;
            ScreenShadeInstance.Visible = true;
            if (!IsPaused) PauseThisScreen();
            TopStatusBarInstance.PauseForMenu(IsPaused);
        }

        private void OnMenuCloseButtonClick(IWindow window)
        {
            ScreenShadeInstance.Visible = false;
            MenuWindowInstance.Visible = false;
            if (!TopStatusBarInstance.WasPausedWhenMenuClicked) UnpauseThisScreen();
            TopStatusBarInstance.PauseForMenu(IsPaused);
        }

        private void UpdateInfoBar()
        {
            TopStatusBarInstance.UpdateWave(CurrentLevel.CurrentWaveNumber);
        }
    }
}
