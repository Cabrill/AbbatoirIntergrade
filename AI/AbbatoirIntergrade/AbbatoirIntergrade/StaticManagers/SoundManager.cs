using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Audio;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class SoundManager
    {
        private static double _soundVolumeVolumeLevel = 100;
        public static double SoundVolumeLevel
        {
            get => _soundVolumeVolumeLevel;
            set
            {
                _soundVolumeVolumeLevel = value;
                effectiveSoundVolumeLevel = getSmoothedVolumeLevel(value);
            }
    }

        private static double _musicVolumeLevel = 100;
        public static double MusicVolumeLevel
        {
            get => _musicVolumeLevel;
            set
            {
                _musicVolumeLevel = value;
                effectiveMusicVolumeLevel = getSmoothedVolumeLevel(value);
                MediaPlayer.Volume = effectiveMusicVolumeLevel;
            }
        }

        private static float effectiveSoundVolumeLevel;
        private static float effectiveMusicVolumeLevel;

        public static void PlaySoundEffect(SoundEffectInstance effect, float pan = 0f)
        {
            if (SoundVolumeLevel == 0) return;
            try
            {
                effect.Volume = effectiveSoundVolumeLevel;
                effect.Pan = pan;
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

        public static void PlaySong(Song songToPlay, bool forceRestart = true)
        {
            try
            {
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

        private const double a = 1e-3;
        private const double b = 6.908;
        private static float getSmoothedVolumeLevel(double value)
        {
            var x = value / 100f;
            
            var smoothValue = a * Math.Exp(b*x);

            return (float)smoothValue;
        }

    }
   
}
