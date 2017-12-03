
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

        //void UpdateMusic()
        //{
        //    if (!GameHasStarted || AudioManager.CurrentlyPlayingSong != null) return;

        //    Song songToPlay = null;

        //    var randomChoice = FlatRedBallServices.Random.NextDouble();

        //    if (randomChoice < 0.33)
        //    {
        //        songToPlay = anttisinstrumentals_einszweidreiviolins;
        //    }
        //    else if (randomChoice < 0.66)
        //    {
        //        songToPlay = anttisinstrumentals_harmorsongakaintheyear2000instrumental;
        //    }
        //    else
        //    {
        //        songToPlay = anttisinstrumentals_hjappiermjusic;
        //    }

        //    AudioManager.PlaySong(songToPlay, true, true);
        //}
    }
}
