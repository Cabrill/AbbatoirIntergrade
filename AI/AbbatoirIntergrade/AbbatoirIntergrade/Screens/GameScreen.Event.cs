
using System;

namespace AbbatoirIntergrade.Screens
{
    public partial class GameScreen
    {
        void OnStartButtonInstanceClick (FlatRedBall.Gui.IWindow window)
        {
            //StartButtonInstance.Visible = false;
            GameHasStarted = true;
            //UpdateMusic();
        }
        void OnAfterCurrentSatoshisSet (object sender, EventArgs e) 
        {
            BuildMenuInstance.UpdateAffordability(CurrentSatoshis);
            LivesPointsDisplayInstance.SatoshiText = CurrentSatoshis.ToString();
        }
    }
}
