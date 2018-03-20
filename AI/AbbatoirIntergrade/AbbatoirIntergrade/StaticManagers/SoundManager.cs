using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Audio;
using FlatRedBall.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class SoundManager
    {
        public static string CurrentArtistName => (AudioManager.CurrentlyPlayingSong != null
            ? GlobalContent.SongNames[AudioManager.CurrentlyPlayingSong.Name].ArtistName
            : "");
        public static string CurrentTrackName => (AudioManager.CurrentlyPlayingSong != null
            ? GlobalContent.SongNames[AudioManager.CurrentlyPlayingSong.Name].TrackName
            : "");

        private static double _soundVolumeVolumeLevel = 100;
        public static double SoundVolumeLevel
        {
            get => _soundVolumeVolumeLevel;
            set
            {
                _soundVolumeVolumeLevel = value;
                effectiveSoundVolumeLevel = getSmoothedVolumeLevel(_soundVolumeVolumeLevel);
            }
        }

        private static double _musicVolumeLevel = 100;
        public static double MusicVolumeLevel
        {
            get => _musicVolumeLevel;
            set
            {
                _musicVolumeLevel = value;
                effectiveMusicVolumeLevel = getSmoothedVolumeLevel(_musicVolumeLevel);
                MediaPlayer.Volume = effectiveMusicVolumeLevel;
            }
        }

        private static float effectiveSoundVolumeLevel = 1;
        private static float effectiveMusicVolumeLevel = 0.8f;

        private static List<string> _currentPlayList;
        private static int _playlistIndex;
        private static bool _shouldLoopPlaylist;
        private static bool _shouldLoopOneSong;

        public static bool Update()
        {
            if (AudioManager.CurrentlyPlayingSong == null)
            {
                if (_shouldLoopOneSong) AudioManager.PlaySong();
                else if (_currentPlayList != null) PlayNextSongInList();
                return true;
            }
            return false;
        }

        public static void PlaySoundEffect(SoundEffectInstance effect)
        {
            if (SoundVolumeLevel == 0) return;
            try
            {
                effect.Volume = effectiveSoundVolumeLevel;
                effect.Play();
            }
            catch (Exception e)
            {
#if DEBUG
                throw e;//Alert developer if debugging
#endif
                //Else do nothing
            }
        }

        public static void PlaySong(Song songToPlay, bool forceRestart = true, bool shouldLoop = true)
        {
            try
            {
                _shouldLoopOneSong = shouldLoop;
                AudioManager.PlaySong(songToPlay, forceRestart, true);
            }
            catch (Exception e)
            {
#if DEBUG
                throw e;//Alert developer if debugging
#endif
                //Else do nothing
            }
        }

        public static void PlaySongList(List<string> songsToPlay, bool loopPlaylist = true)
        {
            if (songsToPlay == null || songsToPlay.Count < 1) return;
            _currentPlayList = songsToPlay;
            _playlistIndex = 0;
            _shouldLoopPlaylist = loopPlaylist;
            _shouldLoopOneSong = false;
            var firstSongName = _currentPlayList[_playlistIndex];
            var firstSong = GlobalContent.GetFile(firstSongName) as Song;

            AudioManager.PlaySong(firstSong, true, true);
        }

        private static void PlayNextSongInList()
        {
            if (_currentPlayList == null || _currentPlayList.Count < 1) return;

            _playlistIndex += 1;
            if (_playlistIndex > _currentPlayList.Count - 1)
            {
                if (_shouldLoopPlaylist)
                {
                    _playlistIndex = 0;
                }
                else
                {
                    _currentPlayList = null;
                    return;
                }
            }
            var nextSongName = _currentPlayList[_playlistIndex];
            var nextSong = GlobalContent.GetFile(nextSongName) as Song;

            AudioManager.PlaySong(nextSong, true, true);
        }

        private const double a = 1e-3;
        private const double b = 6.908;
        private static float getSmoothedVolumeLevel(double value)
        {
            var x = value / 100f;
            
            var smoothValue = MathHelper.Clamp((float)(a * Math.Exp(b*x)),0f,1f);

            return smoothValue;
        }

    }
   
}
