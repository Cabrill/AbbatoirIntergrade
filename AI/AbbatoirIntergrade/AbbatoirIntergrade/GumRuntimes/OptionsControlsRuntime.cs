using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall;
using FlatRedBall.Forms.Controls;
using FlatRedBall.Gui;
using Microsoft.Xna.Framework.Graphics;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class OptionsControlsRuntime
    {
        private CheckBox FullScreenCheck;

        public List<DisplayMode> DisplayModes
        {
            get
            {
                var allModes = FlatRedBallServices.GraphicsDevice.Adapter.SupportedDisplayModes;
                return allModes.ToList();
            }
        }

        partial void CustomInitialize()
        {
            SoundSlider.FormsControl.ValueChanged += SoundVolumeSliderValueChanged;
            MusicSlider.FormsControl.ValueChanged += MusicVolumeSliderValueChanged;
            //PopulateDisplayModes();

            FullScreenCheck = FullScreenCheckBox.FormsControlAsObject as CheckBox;
            //ResolutionListBox = ResolutionDropDown.FormsControlAsObject as ListBox;
            //ResolutionListBox.IsVisible = !FullScreenCheck.IsChecked.Value;

            //ApplyButton.Click += ApplyDisplay;
            FullScreenCheck.Checked += OnChecked;
            FullScreenCheck.Unchecked += OnChecked;
        }

        private void OnChecked(object sender, EventArgs eventArgs)
        {
            CameraSetup.Data.AllowWidowResizing = !FullScreenCheck.IsChecked.Value;
            CameraSetup.Data.IsFullScreen = FullScreenCheck.IsChecked.Value;
            CameraSetup.Data.Scale = FullScreenCheck.IsChecked.Value ? 100f : 50f;

            CameraSetup.ResetWindow();
            CameraSetup.ResetCamera();
        }

        //private void ApplyDisplay(IWindow window)
        //{
        //    //var currentMode = FlatRedBallServices.GraphicsDevice.Adapter.CurrentDisplayMode;

        //    if (FullScreenCheck.IsChecked.Value)
        //    {
        //        CameraSetup.Data.Scale = 100;
        //        CameraSetup.Data.ResolutionWidth = 2560;
        //        CameraSetup.Data.ResolutionHeight = 1440;
        //        CameraSetup.Data.IsFullScreen = true;
        //    }
        //    else
        //    {
        //        var newResolution = ResolutionListBox.SelectedObject as string;
        //        var newSettings = newResolution.Split('x');
        //        var newWidth = int.Parse(newSettings[0]);
        //        var newHeight = int.Parse(newSettings[1]);

        //        var widthScale = newWidth / 2560f;
        //        var heightScale = newHeight / 1440f;

        //        var newScale = Math.Max(widthScale, heightScale) * 100f;

        //        CameraSetup.Data.Scale = newScale;
        //        CameraSetup.Data.AllowWidowResizing = true;
        //        CameraSetup.Data.IsFullScreen = false;
        //    }
            
        //    CameraSetup.ResetWindow();
        //    CameraSetup.ResetCamera();
        //}

        private void PopulateDisplayModes()
        {
            var listBox = GetGraphicalUiElementByName("ResolutionDropDown")
                .FormsControlAsObject as ListBox;
            listBox.ListBoxItemGumType = typeof(ListBoxItemRuntime);

            var currentMode = FlatRedBallServices.GraphicsDevice.Adapter.CurrentDisplayMode;

            foreach (var mode in DisplayModes)
            {
                var modeScale = mode.Width / (float)mode.Height;
                if (Math.Abs(modeScale - 1.77) < 0.1f)
                {
                    var newItem = $"{mode.Width}x{mode.Height}";
                    listBox.Items.Add(newItem);
                    if (mode == currentMode)
                    {
                        listBox.SelectedObject = newItem;
                    }
                }
            }
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
