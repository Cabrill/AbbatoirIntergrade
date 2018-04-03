
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
            var allowUpgrade = CurrentGameMode == GameMode.Building;

            BuildMenuInstance.UpdateAffordability(CurrentSatoshis);
            StructureInfoInstance.UpdateAffordability(CurrentSatoshis, allowUpgrade);
            LivesPointsDisplayInstance.SatoshiText = CurrentSatoshis.ToString();
        }
    }
}
