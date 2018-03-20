using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.StaticManagers;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class CurrentMusicDisplayRuntime
    {
        public void TimedDisplay(bool onlyIfChanged = false)
        {
            var lastTrackName = GameStateManager.CurrentTrackName;
            CurrentAppearingState = Appearing.Hidden;

            var artistName = SoundManager.CurrentArtistName;
            var trackName = SoundManager.CurrentTrackName;

            if (!onlyIfChanged || lastTrackName != trackName)
            {
                if (!string.IsNullOrEmpty(artistName) && !string.IsNullOrEmpty(trackName))
                {
                    ArtistName.Text = artistName;
                    TrackName.Text = trackName;
                    DisplayAnimation.Play();
                    GameStateManager.CurrentTrackName = trackName;
                }
            }
        }

        public void ImmediateDisplay()
        {
            var artistName = SoundManager.CurrentArtistName;
            var trackName = SoundManager.CurrentTrackName;

            if (!string.IsNullOrEmpty(artistName) && !string.IsNullOrEmpty(trackName))
            {
                ArtistName.Text = artistName;
                TrackName.Text = trackName;
                GameStateManager.CurrentTrackName = trackName;
            }
            CurrentAppearingState = Appearing.Displayed;
        }
    }
}
