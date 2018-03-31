
using System;

namespace AbbatoirIntergrade.Screens
{
    public partial class GameScreen
    {
        void OnStartButtonInstanceClick (FlatRedBall.Gui.IWindow window)
        {
            ChangeGameModeToNormal();
        }
        void OnAfterCurrentSatoshisSet (object sender, EventArgs e) 
        {
            BuildMenuInstance.UpdateAffordability(CurrentSatoshis);
            LivesPointsDisplayInstance.SatoshiText = CurrentSatoshis.ToString();
        }
    }
}
