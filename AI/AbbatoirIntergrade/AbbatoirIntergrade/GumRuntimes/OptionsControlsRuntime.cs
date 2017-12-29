using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.StaticManagers;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class OptionsControlsRuntime
    {
        partial void CustomInitialize()
        {
            RefreshValues();

            SoundSlider.FormsControl.ValueChanged += SoundVolumeSliderValueChanged;

            MusicSlider.FormsControl.ValueChanged += MusicVolumeSliderValueChanged;
        }

        private void MusicVolumeSliderValueChanged(object sender, EventArgs e)
        {
            var newValue = MusicSlider.FormsControl.Value;
            SoundManager.MusicVolumeLevel = newValue;

            var newColorValue = (int)(255 * (newValue/100f));
            MusicSlider.ColoredRectangleBlue = newColorValue;
            MusicSlider.ColoredRectangleGreen = newColorValue;
        }

        private void SoundVolumeSliderValueChanged(object sender, EventArgs e)
        {
            var newValue = SoundSlider.FormsControl.Value;
            SoundManager.SoundVolumeLevel = newValue;

            var newColorValue = (int)(255 * (newValue/100f));
            SoundSlider.ColoredRectangleBlue = newColorValue;
            SoundSlider.ColoredRectangleGreen = newColorValue;
        }

        public void RefreshValues()
        {
            SoundSlider.FormsControl.Value = SoundManager.SoundVolumeLevel;
            MusicSlider.FormsControl.Value = SoundManager.MusicVolumeLevel;
        }
    }
}
