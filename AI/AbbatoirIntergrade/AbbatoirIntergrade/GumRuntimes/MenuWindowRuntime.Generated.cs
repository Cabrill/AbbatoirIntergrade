    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class MenuWindowRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Options
            {
                Visible,
                Hidden,
                NoFullScreen
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Options mCurrentOptionsState;
            #endregion
            #region State Properties
            public VariableState CurrentVariableState
            {
                get
                {
                    return mCurrentVariableState;
                }
                set
                {
                    mCurrentVariableState = value;
                    switch(mCurrentVariableState)
                    {
                        case  VariableState.Default:
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ButtonFrameInstance.Height = 100f;
                            ButtonFrameInstance.Width = 7.0845f;
                            ButtonFrameInstance.X = 34.09375f;
                            ButtonFrameInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance.Y = 64.5f;
                            ButtonFrameInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance1.Height = 100f;
                            ButtonFrameInstance1.Width = 7.0845f;
                            ButtonFrameInstance1.X = 43.0625f;
                            ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance1.Y = 64.5f;
                            ButtonFrameInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance2.Height = 100f;
                            ButtonFrameInstance2.Width = 7.0845f;
                            ButtonFrameInstance2.X = 51.6875f;
                            ButtonFrameInstance2.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance2.Y = 64.49998f;
                            ButtonFrameInstance2.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance3.Height = 100f;
                            ButtonFrameInstance3.Width = 7.0845f;
                            ButtonFrameInstance3.X = 60.65625f;
                            ButtonFrameInstance3.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance3.Y = 64.83331f;
                            ButtonFrameInstance3.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("VersionText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            VersionText.FontScale = 0.5f;
                            VersionText.Height = 34f;
                            VersionText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MenuFrameInstance") ?? this;
                            VersionText.Text = "V1.1.0";
                            VersionText.UseCustomFont = true;
                            VersionText.Width = 186f;
                            VersionText.X = 10.95123f;
                            VersionText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            VersionText.Y = 6.962322f;
                            VersionText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            OptionsControlsInstance.Height = 54.47209f;
                            OptionsControlsInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            OptionsControlsInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MenuFrameInstance") ?? this;
                            OptionsControlsInstance.Width = 70.73295f;
                            OptionsControlsInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            OptionsControlsInstance.X = 14.33591f;
                            OptionsControlsInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            OptionsControlsInstance.Y = 16.62892f;
                            OptionsControlsInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CloseButton.Height = 7f;
                            CloseButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CloseButton.Width = 4f;
                            CloseButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CloseButton.X = 67.65625f;
                            CloseButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CloseButton.Y = 18.6111f;
                            CloseButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CurrentMusicBackdrop.Blue = 0;
                            CurrentMusicBackdrop.Green = 0;
                            CurrentMusicBackdrop.Height = -5f;
                            CurrentMusicBackdrop.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            CurrentMusicBackdrop.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CurrentMusicFrame") ?? this;
                            CurrentMusicBackdrop.Red = 0;
                            CurrentMusicBackdrop.Width = -5f;
                            CurrentMusicBackdrop.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            CurrentMusicBackdrop.X = 0f;
                            CurrentMusicBackdrop.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            CurrentMusicBackdrop.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            CurrentMusicBackdrop.Y = 0f;
                            CurrentMusicBackdrop.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            CurrentMusicBackdrop.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SetProperty("MusicInfo.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            MusicInfo.FontScale = 0.4f;
                            MusicInfo.Height = 57f;
                            MusicInfo.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MusicInfo.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CurrentMusicBackdrop") ?? this;
                            MusicInfo.Text = "Anttis Instrumentals - In my Mind I am a Big Star";
                            MusicInfo.UseCustomFont = true;
                            MusicInfo.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MusicInfo.Width = 659f;
                            MusicInfo.X = 594f;
                            MusicInfo.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MusicInfo.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            MusicInfo.Y = 0f;
                            MusicInfo.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MusicInfo.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            MusicLabel.Blue = 255;
                            SetProperty("MusicLabel.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            MusicLabel.FontScale = 0.6f;
                            MusicLabel.Green = 255;
                            MusicLabel.Height = 57f;
                            MusicLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            MusicLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CurrentMusicBackdrop") ?? this;
                            MusicLabel.Red = 0;
                            MusicLabel.Text = "Current Music:";
                            MusicLabel.UseCustomFont = true;
                            MusicLabel.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MusicLabel.Width = 263f;
                            MusicLabel.X = 5f;
                            MusicLabel.Y = 0f;
                            MusicLabel.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MusicLabel.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            CurrentMusicFrame.Blue = 255;
                            CurrentMusicFrame.Green = 255;
                            CurrentMusicFrame.Height = 55f;
                            CurrentMusicFrame.Red = 0;
                            CurrentMusicFrame.Width = 923f;
                            CurrentMusicFrame.X = 845f;
                            CurrentMusicFrame.Y = 868f;
                            break;
                    }
                }
            }
            public Options CurrentOptionsState
            {
                get
                {
                    return mCurrentOptionsState;
                }
                set
                {
                    mCurrentOptionsState = value;
                    switch(mCurrentOptionsState)
                    {
                        case  Options.Visible:
                            OptionsControlsInstance.CurrentVariableState = AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState.Default;
                            OptionsControlsInstance.Visible = true;
                            break;
                        case  Options.Hidden:
                            OptionsControlsInstance.CurrentVariableState = AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState.Default;
                            OptionsControlsInstance.Visible = false;
                            break;
                        case  Options.NoFullScreen:
                            OptionsControlsInstance.CurrentVariableState = AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState.HiddenFullScreen;
                            OptionsControlsInstance.Visible = true;
                            break;
                    }
                }
            }
            #endregion
            #region State Interpolation
            public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setButtonFrameInstanceHeightFirstValue = false;
                bool setButtonFrameInstanceHeightSecondValue = false;
                float ButtonFrameInstanceHeightFirstValue= 0;
                float ButtonFrameInstanceHeightSecondValue= 0;
                bool setButtonFrameInstanceWidthFirstValue = false;
                bool setButtonFrameInstanceWidthSecondValue = false;
                float ButtonFrameInstanceWidthFirstValue= 0;
                float ButtonFrameInstanceWidthSecondValue= 0;
                bool setButtonFrameInstanceXFirstValue = false;
                bool setButtonFrameInstanceXSecondValue = false;
                float ButtonFrameInstanceXFirstValue= 0;
                float ButtonFrameInstanceXSecondValue= 0;
                bool setButtonFrameInstanceYFirstValue = false;
                bool setButtonFrameInstanceYSecondValue = false;
                float ButtonFrameInstanceYFirstValue= 0;
                float ButtonFrameInstanceYSecondValue= 0;
                bool setButtonFrameInstance1HeightFirstValue = false;
                bool setButtonFrameInstance1HeightSecondValue = false;
                float ButtonFrameInstance1HeightFirstValue= 0;
                float ButtonFrameInstance1HeightSecondValue= 0;
                bool setButtonFrameInstance1WidthFirstValue = false;
                bool setButtonFrameInstance1WidthSecondValue = false;
                float ButtonFrameInstance1WidthFirstValue= 0;
                float ButtonFrameInstance1WidthSecondValue= 0;
                bool setButtonFrameInstance1XFirstValue = false;
                bool setButtonFrameInstance1XSecondValue = false;
                float ButtonFrameInstance1XFirstValue= 0;
                float ButtonFrameInstance1XSecondValue= 0;
                bool setButtonFrameInstance1YFirstValue = false;
                bool setButtonFrameInstance1YSecondValue = false;
                float ButtonFrameInstance1YFirstValue= 0;
                float ButtonFrameInstance1YSecondValue= 0;
                bool setButtonFrameInstance2HeightFirstValue = false;
                bool setButtonFrameInstance2HeightSecondValue = false;
                float ButtonFrameInstance2HeightFirstValue= 0;
                float ButtonFrameInstance2HeightSecondValue= 0;
                bool setButtonFrameInstance2WidthFirstValue = false;
                bool setButtonFrameInstance2WidthSecondValue = false;
                float ButtonFrameInstance2WidthFirstValue= 0;
                float ButtonFrameInstance2WidthSecondValue= 0;
                bool setButtonFrameInstance2XFirstValue = false;
                bool setButtonFrameInstance2XSecondValue = false;
                float ButtonFrameInstance2XFirstValue= 0;
                float ButtonFrameInstance2XSecondValue= 0;
                bool setButtonFrameInstance2YFirstValue = false;
                bool setButtonFrameInstance2YSecondValue = false;
                float ButtonFrameInstance2YFirstValue= 0;
                float ButtonFrameInstance2YSecondValue= 0;
                bool setButtonFrameInstance3HeightFirstValue = false;
                bool setButtonFrameInstance3HeightSecondValue = false;
                float ButtonFrameInstance3HeightFirstValue= 0;
                float ButtonFrameInstance3HeightSecondValue= 0;
                bool setButtonFrameInstance3WidthFirstValue = false;
                bool setButtonFrameInstance3WidthSecondValue = false;
                float ButtonFrameInstance3WidthFirstValue= 0;
                float ButtonFrameInstance3WidthSecondValue= 0;
                bool setButtonFrameInstance3XFirstValue = false;
                bool setButtonFrameInstance3XSecondValue = false;
                float ButtonFrameInstance3XFirstValue= 0;
                float ButtonFrameInstance3XSecondValue= 0;
                bool setButtonFrameInstance3YFirstValue = false;
                bool setButtonFrameInstance3YSecondValue = false;
                float ButtonFrameInstance3YFirstValue= 0;
                float ButtonFrameInstance3YSecondValue= 0;
                bool setCloseButtonHeightFirstValue = false;
                bool setCloseButtonHeightSecondValue = false;
                float CloseButtonHeightFirstValue= 0;
                float CloseButtonHeightSecondValue= 0;
                bool setCloseButtonWidthFirstValue = false;
                bool setCloseButtonWidthSecondValue = false;
                float CloseButtonWidthFirstValue= 0;
                float CloseButtonWidthSecondValue= 0;
                bool setCloseButtonXFirstValue = false;
                bool setCloseButtonXSecondValue = false;
                float CloseButtonXFirstValue= 0;
                float CloseButtonXSecondValue= 0;
                bool setCloseButtonYFirstValue = false;
                bool setCloseButtonYSecondValue = false;
                float CloseButtonYFirstValue= 0;
                float CloseButtonYSecondValue= 0;
                bool setCurrentMusicBackdropBlueFirstValue = false;
                bool setCurrentMusicBackdropBlueSecondValue = false;
                int CurrentMusicBackdropBlueFirstValue= 0;
                int CurrentMusicBackdropBlueSecondValue= 0;
                bool setCurrentMusicBackdropGreenFirstValue = false;
                bool setCurrentMusicBackdropGreenSecondValue = false;
                int CurrentMusicBackdropGreenFirstValue= 0;
                int CurrentMusicBackdropGreenSecondValue= 0;
                bool setCurrentMusicBackdropHeightFirstValue = false;
                bool setCurrentMusicBackdropHeightSecondValue = false;
                float CurrentMusicBackdropHeightFirstValue= 0;
                float CurrentMusicBackdropHeightSecondValue= 0;
                bool setCurrentMusicBackdropRedFirstValue = false;
                bool setCurrentMusicBackdropRedSecondValue = false;
                int CurrentMusicBackdropRedFirstValue= 0;
                int CurrentMusicBackdropRedSecondValue= 0;
                bool setCurrentMusicBackdropWidthFirstValue = false;
                bool setCurrentMusicBackdropWidthSecondValue = false;
                float CurrentMusicBackdropWidthFirstValue= 0;
                float CurrentMusicBackdropWidthSecondValue= 0;
                bool setCurrentMusicBackdropXFirstValue = false;
                bool setCurrentMusicBackdropXSecondValue = false;
                float CurrentMusicBackdropXFirstValue= 0;
                float CurrentMusicBackdropXSecondValue= 0;
                bool setCurrentMusicBackdropYFirstValue = false;
                bool setCurrentMusicBackdropYSecondValue = false;
                float CurrentMusicBackdropYFirstValue= 0;
                float CurrentMusicBackdropYSecondValue= 0;
                bool setCurrentMusicFrameBlueFirstValue = false;
                bool setCurrentMusicFrameBlueSecondValue = false;
                int CurrentMusicFrameBlueFirstValue= 0;
                int CurrentMusicFrameBlueSecondValue= 0;
                bool setCurrentMusicFrameGreenFirstValue = false;
                bool setCurrentMusicFrameGreenSecondValue = false;
                int CurrentMusicFrameGreenFirstValue= 0;
                int CurrentMusicFrameGreenSecondValue= 0;
                bool setCurrentMusicFrameHeightFirstValue = false;
                bool setCurrentMusicFrameHeightSecondValue = false;
                float CurrentMusicFrameHeightFirstValue= 0;
                float CurrentMusicFrameHeightSecondValue= 0;
                bool setCurrentMusicFrameRedFirstValue = false;
                bool setCurrentMusicFrameRedSecondValue = false;
                int CurrentMusicFrameRedFirstValue= 0;
                int CurrentMusicFrameRedSecondValue= 0;
                bool setCurrentMusicFrameWidthFirstValue = false;
                bool setCurrentMusicFrameWidthSecondValue = false;
                float CurrentMusicFrameWidthFirstValue= 0;
                float CurrentMusicFrameWidthSecondValue= 0;
                bool setCurrentMusicFrameXFirstValue = false;
                bool setCurrentMusicFrameXSecondValue = false;
                float CurrentMusicFrameXFirstValue= 0;
                float CurrentMusicFrameXSecondValue= 0;
                bool setCurrentMusicFrameYFirstValue = false;
                bool setCurrentMusicFrameYSecondValue = false;
                float CurrentMusicFrameYFirstValue= 0;
                float CurrentMusicFrameYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMusicInfoFontScaleFirstValue = false;
                bool setMusicInfoFontScaleSecondValue = false;
                float MusicInfoFontScaleFirstValue= 0;
                float MusicInfoFontScaleSecondValue= 0;
                bool setMusicInfoHeightFirstValue = false;
                bool setMusicInfoHeightSecondValue = false;
                float MusicInfoHeightFirstValue= 0;
                float MusicInfoHeightSecondValue= 0;
                bool setMusicInfoWidthFirstValue = false;
                bool setMusicInfoWidthSecondValue = false;
                float MusicInfoWidthFirstValue= 0;
                float MusicInfoWidthSecondValue= 0;
                bool setMusicInfoXFirstValue = false;
                bool setMusicInfoXSecondValue = false;
                float MusicInfoXFirstValue= 0;
                float MusicInfoXSecondValue= 0;
                bool setMusicInfoYFirstValue = false;
                bool setMusicInfoYSecondValue = false;
                float MusicInfoYFirstValue= 0;
                float MusicInfoYSecondValue= 0;
                bool setMusicLabelBlueFirstValue = false;
                bool setMusicLabelBlueSecondValue = false;
                int MusicLabelBlueFirstValue= 0;
                int MusicLabelBlueSecondValue= 0;
                bool setMusicLabelFontScaleFirstValue = false;
                bool setMusicLabelFontScaleSecondValue = false;
                float MusicLabelFontScaleFirstValue= 0;
                float MusicLabelFontScaleSecondValue= 0;
                bool setMusicLabelGreenFirstValue = false;
                bool setMusicLabelGreenSecondValue = false;
                int MusicLabelGreenFirstValue= 0;
                int MusicLabelGreenSecondValue= 0;
                bool setMusicLabelHeightFirstValue = false;
                bool setMusicLabelHeightSecondValue = false;
                float MusicLabelHeightFirstValue= 0;
                float MusicLabelHeightSecondValue= 0;
                bool setMusicLabelRedFirstValue = false;
                bool setMusicLabelRedSecondValue = false;
                int MusicLabelRedFirstValue= 0;
                int MusicLabelRedSecondValue= 0;
                bool setMusicLabelWidthFirstValue = false;
                bool setMusicLabelWidthSecondValue = false;
                float MusicLabelWidthFirstValue= 0;
                float MusicLabelWidthSecondValue= 0;
                bool setMusicLabelXFirstValue = false;
                bool setMusicLabelXSecondValue = false;
                float MusicLabelXFirstValue= 0;
                float MusicLabelXSecondValue= 0;
                bool setMusicLabelYFirstValue = false;
                bool setMusicLabelYSecondValue = false;
                float MusicLabelYFirstValue= 0;
                float MusicLabelYSecondValue= 0;
                bool setOptionsControlsInstanceHeightFirstValue = false;
                bool setOptionsControlsInstanceHeightSecondValue = false;
                float OptionsControlsInstanceHeightFirstValue= 0;
                float OptionsControlsInstanceHeightSecondValue= 0;
                bool setOptionsControlsInstanceWidthFirstValue = false;
                bool setOptionsControlsInstanceWidthSecondValue = false;
                float OptionsControlsInstanceWidthFirstValue= 0;
                float OptionsControlsInstanceWidthSecondValue= 0;
                bool setOptionsControlsInstanceXFirstValue = false;
                bool setOptionsControlsInstanceXSecondValue = false;
                float OptionsControlsInstanceXFirstValue= 0;
                float OptionsControlsInstanceXSecondValue= 0;
                bool setOptionsControlsInstanceYFirstValue = false;
                bool setOptionsControlsInstanceYSecondValue = false;
                float OptionsControlsInstanceYFirstValue= 0;
                float OptionsControlsInstanceYSecondValue= 0;
                bool setVersionTextFontScaleFirstValue = false;
                bool setVersionTextFontScaleSecondValue = false;
                float VersionTextFontScaleFirstValue= 0;
                float VersionTextFontScaleSecondValue= 0;
                bool setVersionTextHeightFirstValue = false;
                bool setVersionTextHeightSecondValue = false;
                float VersionTextHeightFirstValue= 0;
                float VersionTextHeightSecondValue= 0;
                bool setVersionTextWidthFirstValue = false;
                bool setVersionTextWidthSecondValue = false;
                float VersionTextWidthFirstValue= 0;
                float VersionTextWidthSecondValue= 0;
                bool setVersionTextXFirstValue = false;
                bool setVersionTextXSecondValue = false;
                float VersionTextXFirstValue= 0;
                float VersionTextXSecondValue= 0;
                bool setVersionTextYFirstValue = false;
                bool setVersionTextYSecondValue = false;
                float VersionTextYFirstValue= 0;
                float VersionTextYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setButtonFrameInstanceHeightFirstValue = true;
                        ButtonFrameInstanceHeightFirstValue = 100f;
                        setButtonFrameInstanceWidthFirstValue = true;
                        ButtonFrameInstanceWidthFirstValue = 7.0845f;
                        setButtonFrameInstanceXFirstValue = true;
                        ButtonFrameInstanceXFirstValue = 34.09375f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstanceYFirstValue = true;
                        ButtonFrameInstanceYFirstValue = 64.5f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1HeightFirstValue = true;
                        ButtonFrameInstance1HeightFirstValue = 100f;
                        setButtonFrameInstance1WidthFirstValue = true;
                        ButtonFrameInstance1WidthFirstValue = 7.0845f;
                        setButtonFrameInstance1XFirstValue = true;
                        ButtonFrameInstance1XFirstValue = 43.0625f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YFirstValue = true;
                        ButtonFrameInstance1YFirstValue = 64.5f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance2HeightFirstValue = true;
                        ButtonFrameInstance2HeightFirstValue = 100f;
                        setButtonFrameInstance2WidthFirstValue = true;
                        ButtonFrameInstance2WidthFirstValue = 7.0845f;
                        setButtonFrameInstance2XFirstValue = true;
                        ButtonFrameInstance2XFirstValue = 51.6875f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance2.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance2YFirstValue = true;
                        ButtonFrameInstance2YFirstValue = 64.49998f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance2.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance3HeightFirstValue = true;
                        ButtonFrameInstance3HeightFirstValue = 100f;
                        setButtonFrameInstance3WidthFirstValue = true;
                        ButtonFrameInstance3WidthFirstValue = 7.0845f;
                        setButtonFrameInstance3XFirstValue = true;
                        ButtonFrameInstance3XFirstValue = 60.65625f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance3.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance3YFirstValue = true;
                        ButtonFrameInstance3YFirstValue = 64.83331f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance3.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCloseButtonHeightFirstValue = true;
                        CloseButtonHeightFirstValue = 7f;
                        if (interpolationValue < 1)
                        {
                            this.CloseButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloseButtonWidthFirstValue = true;
                        CloseButtonWidthFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.CloseButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloseButtonXFirstValue = true;
                        CloseButtonXFirstValue = 67.65625f;
                        if (interpolationValue < 1)
                        {
                            this.CloseButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCloseButtonYFirstValue = true;
                        CloseButtonYFirstValue = 18.6111f;
                        if (interpolationValue < 1)
                        {
                            this.CloseButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCurrentMusicBackdropBlueFirstValue = true;
                        CurrentMusicBackdropBlueFirstValue = 0;
                        setCurrentMusicBackdropGreenFirstValue = true;
                        CurrentMusicBackdropGreenFirstValue = 0;
                        setCurrentMusicBackdropHeightFirstValue = true;
                        CurrentMusicBackdropHeightFirstValue = -5f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicBackdrop.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicBackdrop.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CurrentMusicFrame") ?? this;
                        }
                        setCurrentMusicBackdropRedFirstValue = true;
                        CurrentMusicBackdropRedFirstValue = 0;
                        setCurrentMusicBackdropWidthFirstValue = true;
                        CurrentMusicBackdropWidthFirstValue = -5f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicBackdrop.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setCurrentMusicBackdropXFirstValue = true;
                        CurrentMusicBackdropXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicBackdrop.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicBackdrop.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCurrentMusicBackdropYFirstValue = true;
                        CurrentMusicBackdropYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicBackdrop.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicBackdrop.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCurrentMusicFrameBlueFirstValue = true;
                        CurrentMusicFrameBlueFirstValue = 255;
                        setCurrentMusicFrameGreenFirstValue = true;
                        CurrentMusicFrameGreenFirstValue = 255;
                        setCurrentMusicFrameHeightFirstValue = true;
                        CurrentMusicFrameHeightFirstValue = 55f;
                        setCurrentMusicFrameRedFirstValue = true;
                        CurrentMusicFrameRedFirstValue = 0;
                        setCurrentMusicFrameWidthFirstValue = true;
                        CurrentMusicFrameWidthFirstValue = 923f;
                        setCurrentMusicFrameXFirstValue = true;
                        CurrentMusicFrameXFirstValue = 845f;
                        setCurrentMusicFrameYFirstValue = true;
                        CurrentMusicFrameYFirstValue = 868f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MusicInfo.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setMusicInfoFontScaleFirstValue = true;
                        MusicInfoFontScaleFirstValue = 0.4f;
                        setMusicInfoHeightFirstValue = true;
                        MusicInfoHeightFirstValue = 57f;
                        if (interpolationValue < 1)
                        {
                            this.MusicInfo.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicInfo.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CurrentMusicBackdrop") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicInfo.Text = "Anttis Instrumentals - In my Mind I am a Big Star";
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicInfo.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicInfo.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMusicInfoWidthFirstValue = true;
                        MusicInfoWidthFirstValue = 659f;
                        setMusicInfoXFirstValue = true;
                        MusicInfoXFirstValue = 594f;
                        if (interpolationValue < 1)
                        {
                            this.MusicInfo.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicInfo.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setMusicInfoYFirstValue = true;
                        MusicInfoYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MusicInfo.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicInfo.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMusicLabelBlueFirstValue = true;
                        MusicLabelBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("MusicLabel.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setMusicLabelFontScaleFirstValue = true;
                        MusicLabelFontScaleFirstValue = 0.6f;
                        setMusicLabelGreenFirstValue = true;
                        MusicLabelGreenFirstValue = 255;
                        setMusicLabelHeightFirstValue = true;
                        MusicLabelHeightFirstValue = 57f;
                        if (interpolationValue < 1)
                        {
                            this.MusicLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CurrentMusicBackdrop") ?? this;
                        }
                        setMusicLabelRedFirstValue = true;
                        MusicLabelRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.MusicLabel.Text = "Current Music:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicLabel.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicLabel.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMusicLabelWidthFirstValue = true;
                        MusicLabelWidthFirstValue = 263f;
                        setMusicLabelXFirstValue = true;
                        MusicLabelXFirstValue = 5f;
                        setMusicLabelYFirstValue = true;
                        MusicLabelYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MusicLabel.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicLabel.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setOptionsControlsInstanceHeightFirstValue = true;
                        OptionsControlsInstanceHeightFirstValue = 54.47209f;
                        if (interpolationValue < 1)
                        {
                            this.OptionsControlsInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OptionsControlsInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MenuFrameInstance") ?? this;
                        }
                        setOptionsControlsInstanceWidthFirstValue = true;
                        OptionsControlsInstanceWidthFirstValue = 70.73295f;
                        if (interpolationValue < 1)
                        {
                            this.OptionsControlsInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOptionsControlsInstanceXFirstValue = true;
                        OptionsControlsInstanceXFirstValue = 14.33591f;
                        if (interpolationValue < 1)
                        {
                            this.OptionsControlsInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setOptionsControlsInstanceYFirstValue = true;
                        OptionsControlsInstanceYFirstValue = 16.62892f;
                        if (interpolationValue < 1)
                        {
                            this.OptionsControlsInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("VersionText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setVersionTextFontScaleFirstValue = true;
                        VersionTextFontScaleFirstValue = 0.5f;
                        setVersionTextHeightFirstValue = true;
                        VersionTextHeightFirstValue = 34f;
                        if (interpolationValue < 1)
                        {
                            this.VersionText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MenuFrameInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VersionText.Text = "V1.0.1";
                        }
                        if (interpolationValue < 1)
                        {
                            this.VersionText.UseCustomFont = true;
                        }
                        setVersionTextWidthFirstValue = true;
                        VersionTextWidthFirstValue = 186f;
                        setVersionTextXFirstValue = true;
                        VersionTextXFirstValue = 10.95123f;
                        if (interpolationValue < 1)
                        {
                            this.VersionText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setVersionTextYFirstValue = true;
                        VersionTextYFirstValue = 6.962322f;
                        if (interpolationValue < 1)
                        {
                            this.VersionText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setButtonFrameInstanceHeightSecondValue = true;
                        ButtonFrameInstanceHeightSecondValue = 100f;
                        setButtonFrameInstanceWidthSecondValue = true;
                        ButtonFrameInstanceWidthSecondValue = 7.0845f;
                        setButtonFrameInstanceXSecondValue = true;
                        ButtonFrameInstanceXSecondValue = 34.09375f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstanceYSecondValue = true;
                        ButtonFrameInstanceYSecondValue = 64.5f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1HeightSecondValue = true;
                        ButtonFrameInstance1HeightSecondValue = 100f;
                        setButtonFrameInstance1WidthSecondValue = true;
                        ButtonFrameInstance1WidthSecondValue = 7.0845f;
                        setButtonFrameInstance1XSecondValue = true;
                        ButtonFrameInstance1XSecondValue = 43.0625f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YSecondValue = true;
                        ButtonFrameInstance1YSecondValue = 64.5f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance2HeightSecondValue = true;
                        ButtonFrameInstance2HeightSecondValue = 100f;
                        setButtonFrameInstance2WidthSecondValue = true;
                        ButtonFrameInstance2WidthSecondValue = 7.0845f;
                        setButtonFrameInstance2XSecondValue = true;
                        ButtonFrameInstance2XSecondValue = 51.6875f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance2.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance2YSecondValue = true;
                        ButtonFrameInstance2YSecondValue = 64.49998f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance2.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance3HeightSecondValue = true;
                        ButtonFrameInstance3HeightSecondValue = 100f;
                        setButtonFrameInstance3WidthSecondValue = true;
                        ButtonFrameInstance3WidthSecondValue = 7.0845f;
                        setButtonFrameInstance3XSecondValue = true;
                        ButtonFrameInstance3XSecondValue = 60.65625f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance3.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance3YSecondValue = true;
                        ButtonFrameInstance3YSecondValue = 64.83331f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance3.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCloseButtonHeightSecondValue = true;
                        CloseButtonHeightSecondValue = 7f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloseButtonWidthSecondValue = true;
                        CloseButtonWidthSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloseButtonXSecondValue = true;
                        CloseButtonXSecondValue = 67.65625f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCloseButtonYSecondValue = true;
                        CloseButtonYSecondValue = 18.6111f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCurrentMusicBackdropBlueSecondValue = true;
                        CurrentMusicBackdropBlueSecondValue = 0;
                        setCurrentMusicBackdropGreenSecondValue = true;
                        CurrentMusicBackdropGreenSecondValue = 0;
                        setCurrentMusicBackdropHeightSecondValue = true;
                        CurrentMusicBackdropHeightSecondValue = -5f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicBackdrop.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicBackdrop.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CurrentMusicFrame") ?? this;
                        }
                        setCurrentMusicBackdropRedSecondValue = true;
                        CurrentMusicBackdropRedSecondValue = 0;
                        setCurrentMusicBackdropWidthSecondValue = true;
                        CurrentMusicBackdropWidthSecondValue = -5f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicBackdrop.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setCurrentMusicBackdropXSecondValue = true;
                        CurrentMusicBackdropXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicBackdrop.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicBackdrop.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCurrentMusicBackdropYSecondValue = true;
                        CurrentMusicBackdropYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicBackdrop.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicBackdrop.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCurrentMusicFrameBlueSecondValue = true;
                        CurrentMusicFrameBlueSecondValue = 255;
                        setCurrentMusicFrameGreenSecondValue = true;
                        CurrentMusicFrameGreenSecondValue = 255;
                        setCurrentMusicFrameHeightSecondValue = true;
                        CurrentMusicFrameHeightSecondValue = 55f;
                        setCurrentMusicFrameRedSecondValue = true;
                        CurrentMusicFrameRedSecondValue = 0;
                        setCurrentMusicFrameWidthSecondValue = true;
                        CurrentMusicFrameWidthSecondValue = 923f;
                        setCurrentMusicFrameXSecondValue = true;
                        CurrentMusicFrameXSecondValue = 845f;
                        setCurrentMusicFrameYSecondValue = true;
                        CurrentMusicFrameYSecondValue = 868f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MusicInfo.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setMusicInfoFontScaleSecondValue = true;
                        MusicInfoFontScaleSecondValue = 0.4f;
                        setMusicInfoHeightSecondValue = true;
                        MusicInfoHeightSecondValue = 57f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicInfo.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicInfo.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CurrentMusicBackdrop") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicInfo.Text = "Anttis Instrumentals - In my Mind I am a Big Star";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicInfo.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicInfo.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMusicInfoWidthSecondValue = true;
                        MusicInfoWidthSecondValue = 659f;
                        setMusicInfoXSecondValue = true;
                        MusicInfoXSecondValue = 594f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicInfo.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicInfo.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setMusicInfoYSecondValue = true;
                        MusicInfoYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicInfo.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicInfo.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMusicLabelBlueSecondValue = true;
                        MusicLabelBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MusicLabel.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setMusicLabelFontScaleSecondValue = true;
                        MusicLabelFontScaleSecondValue = 0.6f;
                        setMusicLabelGreenSecondValue = true;
                        MusicLabelGreenSecondValue = 255;
                        setMusicLabelHeightSecondValue = true;
                        MusicLabelHeightSecondValue = 57f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CurrentMusicBackdrop") ?? this;
                        }
                        setMusicLabelRedSecondValue = true;
                        MusicLabelRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.MusicLabel.Text = "Current Music:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicLabel.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicLabel.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMusicLabelWidthSecondValue = true;
                        MusicLabelWidthSecondValue = 263f;
                        setMusicLabelXSecondValue = true;
                        MusicLabelXSecondValue = 5f;
                        setMusicLabelYSecondValue = true;
                        MusicLabelYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicLabel.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicLabel.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setOptionsControlsInstanceHeightSecondValue = true;
                        OptionsControlsInstanceHeightSecondValue = 54.47209f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionsControlsInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OptionsControlsInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MenuFrameInstance") ?? this;
                        }
                        setOptionsControlsInstanceWidthSecondValue = true;
                        OptionsControlsInstanceWidthSecondValue = 70.73295f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionsControlsInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOptionsControlsInstanceXSecondValue = true;
                        OptionsControlsInstanceXSecondValue = 14.33591f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionsControlsInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setOptionsControlsInstanceYSecondValue = true;
                        OptionsControlsInstanceYSecondValue = 16.62892f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionsControlsInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("VersionText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setVersionTextFontScaleSecondValue = true;
                        VersionTextFontScaleSecondValue = 0.5f;
                        setVersionTextHeightSecondValue = true;
                        VersionTextHeightSecondValue = 34f;
                        if (interpolationValue >= 1)
                        {
                            this.VersionText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MenuFrameInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VersionText.Text = "V1.0.1";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VersionText.UseCustomFont = true;
                        }
                        setVersionTextWidthSecondValue = true;
                        VersionTextWidthSecondValue = 186f;
                        setVersionTextXSecondValue = true;
                        VersionTextXSecondValue = 10.95123f;
                        if (interpolationValue >= 1)
                        {
                            this.VersionText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setVersionTextYSecondValue = true;
                        VersionTextYSecondValue = 6.962322f;
                        if (interpolationValue >= 1)
                        {
                            this.VersionText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                if (setButtonFrameInstanceHeightFirstValue && setButtonFrameInstanceHeightSecondValue)
                {
                    ButtonFrameInstance.Height = ButtonFrameInstanceHeightFirstValue * (1 - interpolationValue) + ButtonFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setButtonFrameInstanceWidthFirstValue && setButtonFrameInstanceWidthSecondValue)
                {
                    ButtonFrameInstance.Width = ButtonFrameInstanceWidthFirstValue * (1 - interpolationValue) + ButtonFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setButtonFrameInstanceXFirstValue && setButtonFrameInstanceXSecondValue)
                {
                    ButtonFrameInstance.X = ButtonFrameInstanceXFirstValue * (1 - interpolationValue) + ButtonFrameInstanceXSecondValue * interpolationValue;
                }
                if (setButtonFrameInstanceYFirstValue && setButtonFrameInstanceYSecondValue)
                {
                    ButtonFrameInstance.Y = ButtonFrameInstanceYFirstValue * (1 - interpolationValue) + ButtonFrameInstanceYSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1HeightFirstValue && setButtonFrameInstance1HeightSecondValue)
                {
                    ButtonFrameInstance1.Height = ButtonFrameInstance1HeightFirstValue * (1 - interpolationValue) + ButtonFrameInstance1HeightSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1WidthFirstValue && setButtonFrameInstance1WidthSecondValue)
                {
                    ButtonFrameInstance1.Width = ButtonFrameInstance1WidthFirstValue * (1 - interpolationValue) + ButtonFrameInstance1WidthSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1XFirstValue && setButtonFrameInstance1XSecondValue)
                {
                    ButtonFrameInstance1.X = ButtonFrameInstance1XFirstValue * (1 - interpolationValue) + ButtonFrameInstance1XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1YFirstValue && setButtonFrameInstance1YSecondValue)
                {
                    ButtonFrameInstance1.Y = ButtonFrameInstance1YFirstValue * (1 - interpolationValue) + ButtonFrameInstance1YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance2HeightFirstValue && setButtonFrameInstance2HeightSecondValue)
                {
                    ButtonFrameInstance2.Height = ButtonFrameInstance2HeightFirstValue * (1 - interpolationValue) + ButtonFrameInstance2HeightSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance2WidthFirstValue && setButtonFrameInstance2WidthSecondValue)
                {
                    ButtonFrameInstance2.Width = ButtonFrameInstance2WidthFirstValue * (1 - interpolationValue) + ButtonFrameInstance2WidthSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance2XFirstValue && setButtonFrameInstance2XSecondValue)
                {
                    ButtonFrameInstance2.X = ButtonFrameInstance2XFirstValue * (1 - interpolationValue) + ButtonFrameInstance2XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance2YFirstValue && setButtonFrameInstance2YSecondValue)
                {
                    ButtonFrameInstance2.Y = ButtonFrameInstance2YFirstValue * (1 - interpolationValue) + ButtonFrameInstance2YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance3HeightFirstValue && setButtonFrameInstance3HeightSecondValue)
                {
                    ButtonFrameInstance3.Height = ButtonFrameInstance3HeightFirstValue * (1 - interpolationValue) + ButtonFrameInstance3HeightSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance3WidthFirstValue && setButtonFrameInstance3WidthSecondValue)
                {
                    ButtonFrameInstance3.Width = ButtonFrameInstance3WidthFirstValue * (1 - interpolationValue) + ButtonFrameInstance3WidthSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance3XFirstValue && setButtonFrameInstance3XSecondValue)
                {
                    ButtonFrameInstance3.X = ButtonFrameInstance3XFirstValue * (1 - interpolationValue) + ButtonFrameInstance3XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance3YFirstValue && setButtonFrameInstance3YSecondValue)
                {
                    ButtonFrameInstance3.Y = ButtonFrameInstance3YFirstValue * (1 - interpolationValue) + ButtonFrameInstance3YSecondValue * interpolationValue;
                }
                if (setCloseButtonHeightFirstValue && setCloseButtonHeightSecondValue)
                {
                    CloseButton.Height = CloseButtonHeightFirstValue * (1 - interpolationValue) + CloseButtonHeightSecondValue * interpolationValue;
                }
                if (setCloseButtonWidthFirstValue && setCloseButtonWidthSecondValue)
                {
                    CloseButton.Width = CloseButtonWidthFirstValue * (1 - interpolationValue) + CloseButtonWidthSecondValue * interpolationValue;
                }
                if (setCloseButtonXFirstValue && setCloseButtonXSecondValue)
                {
                    CloseButton.X = CloseButtonXFirstValue * (1 - interpolationValue) + CloseButtonXSecondValue * interpolationValue;
                }
                if (setCloseButtonYFirstValue && setCloseButtonYSecondValue)
                {
                    CloseButton.Y = CloseButtonYFirstValue * (1 - interpolationValue) + CloseButtonYSecondValue * interpolationValue;
                }
                if (setCurrentMusicBackdropBlueFirstValue && setCurrentMusicBackdropBlueSecondValue)
                {
                    CurrentMusicBackdrop.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentMusicBackdropBlueFirstValue* (1 - interpolationValue) + CurrentMusicBackdropBlueSecondValue * interpolationValue);
                }
                if (setCurrentMusicBackdropGreenFirstValue && setCurrentMusicBackdropGreenSecondValue)
                {
                    CurrentMusicBackdrop.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentMusicBackdropGreenFirstValue* (1 - interpolationValue) + CurrentMusicBackdropGreenSecondValue * interpolationValue);
                }
                if (setCurrentMusicBackdropHeightFirstValue && setCurrentMusicBackdropHeightSecondValue)
                {
                    CurrentMusicBackdrop.Height = CurrentMusicBackdropHeightFirstValue * (1 - interpolationValue) + CurrentMusicBackdropHeightSecondValue * interpolationValue;
                }
                if (setCurrentMusicBackdropRedFirstValue && setCurrentMusicBackdropRedSecondValue)
                {
                    CurrentMusicBackdrop.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentMusicBackdropRedFirstValue* (1 - interpolationValue) + CurrentMusicBackdropRedSecondValue * interpolationValue);
                }
                if (setCurrentMusicBackdropWidthFirstValue && setCurrentMusicBackdropWidthSecondValue)
                {
                    CurrentMusicBackdrop.Width = CurrentMusicBackdropWidthFirstValue * (1 - interpolationValue) + CurrentMusicBackdropWidthSecondValue * interpolationValue;
                }
                if (setCurrentMusicBackdropXFirstValue && setCurrentMusicBackdropXSecondValue)
                {
                    CurrentMusicBackdrop.X = CurrentMusicBackdropXFirstValue * (1 - interpolationValue) + CurrentMusicBackdropXSecondValue * interpolationValue;
                }
                if (setCurrentMusicBackdropYFirstValue && setCurrentMusicBackdropYSecondValue)
                {
                    CurrentMusicBackdrop.Y = CurrentMusicBackdropYFirstValue * (1 - interpolationValue) + CurrentMusicBackdropYSecondValue * interpolationValue;
                }
                if (setCurrentMusicFrameBlueFirstValue && setCurrentMusicFrameBlueSecondValue)
                {
                    CurrentMusicFrame.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentMusicFrameBlueFirstValue* (1 - interpolationValue) + CurrentMusicFrameBlueSecondValue * interpolationValue);
                }
                if (setCurrentMusicFrameGreenFirstValue && setCurrentMusicFrameGreenSecondValue)
                {
                    CurrentMusicFrame.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentMusicFrameGreenFirstValue* (1 - interpolationValue) + CurrentMusicFrameGreenSecondValue * interpolationValue);
                }
                if (setCurrentMusicFrameHeightFirstValue && setCurrentMusicFrameHeightSecondValue)
                {
                    CurrentMusicFrame.Height = CurrentMusicFrameHeightFirstValue * (1 - interpolationValue) + CurrentMusicFrameHeightSecondValue * interpolationValue;
                }
                if (setCurrentMusicFrameRedFirstValue && setCurrentMusicFrameRedSecondValue)
                {
                    CurrentMusicFrame.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentMusicFrameRedFirstValue* (1 - interpolationValue) + CurrentMusicFrameRedSecondValue * interpolationValue);
                }
                if (setCurrentMusicFrameWidthFirstValue && setCurrentMusicFrameWidthSecondValue)
                {
                    CurrentMusicFrame.Width = CurrentMusicFrameWidthFirstValue * (1 - interpolationValue) + CurrentMusicFrameWidthSecondValue * interpolationValue;
                }
                if (setCurrentMusicFrameXFirstValue && setCurrentMusicFrameXSecondValue)
                {
                    CurrentMusicFrame.X = CurrentMusicFrameXFirstValue * (1 - interpolationValue) + CurrentMusicFrameXSecondValue * interpolationValue;
                }
                if (setCurrentMusicFrameYFirstValue && setCurrentMusicFrameYSecondValue)
                {
                    CurrentMusicFrame.Y = CurrentMusicFrameYFirstValue * (1 - interpolationValue) + CurrentMusicFrameYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMusicInfoFontScaleFirstValue && setMusicInfoFontScaleSecondValue)
                {
                    MusicInfo.FontScale = MusicInfoFontScaleFirstValue * (1 - interpolationValue) + MusicInfoFontScaleSecondValue * interpolationValue;
                }
                if (setMusicInfoHeightFirstValue && setMusicInfoHeightSecondValue)
                {
                    MusicInfo.Height = MusicInfoHeightFirstValue * (1 - interpolationValue) + MusicInfoHeightSecondValue * interpolationValue;
                }
                if (setMusicInfoWidthFirstValue && setMusicInfoWidthSecondValue)
                {
                    MusicInfo.Width = MusicInfoWidthFirstValue * (1 - interpolationValue) + MusicInfoWidthSecondValue * interpolationValue;
                }
                if (setMusicInfoXFirstValue && setMusicInfoXSecondValue)
                {
                    MusicInfo.X = MusicInfoXFirstValue * (1 - interpolationValue) + MusicInfoXSecondValue * interpolationValue;
                }
                if (setMusicInfoYFirstValue && setMusicInfoYSecondValue)
                {
                    MusicInfo.Y = MusicInfoYFirstValue * (1 - interpolationValue) + MusicInfoYSecondValue * interpolationValue;
                }
                if (setMusicLabelBlueFirstValue && setMusicLabelBlueSecondValue)
                {
                    MusicLabel.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(MusicLabelBlueFirstValue* (1 - interpolationValue) + MusicLabelBlueSecondValue * interpolationValue);
                }
                if (setMusicLabelFontScaleFirstValue && setMusicLabelFontScaleSecondValue)
                {
                    MusicLabel.FontScale = MusicLabelFontScaleFirstValue * (1 - interpolationValue) + MusicLabelFontScaleSecondValue * interpolationValue;
                }
                if (setMusicLabelGreenFirstValue && setMusicLabelGreenSecondValue)
                {
                    MusicLabel.Green = FlatRedBall.Math.MathFunctions.RoundToInt(MusicLabelGreenFirstValue* (1 - interpolationValue) + MusicLabelGreenSecondValue * interpolationValue);
                }
                if (setMusicLabelHeightFirstValue && setMusicLabelHeightSecondValue)
                {
                    MusicLabel.Height = MusicLabelHeightFirstValue * (1 - interpolationValue) + MusicLabelHeightSecondValue * interpolationValue;
                }
                if (setMusicLabelRedFirstValue && setMusicLabelRedSecondValue)
                {
                    MusicLabel.Red = FlatRedBall.Math.MathFunctions.RoundToInt(MusicLabelRedFirstValue* (1 - interpolationValue) + MusicLabelRedSecondValue * interpolationValue);
                }
                if (setMusicLabelWidthFirstValue && setMusicLabelWidthSecondValue)
                {
                    MusicLabel.Width = MusicLabelWidthFirstValue * (1 - interpolationValue) + MusicLabelWidthSecondValue * interpolationValue;
                }
                if (setMusicLabelXFirstValue && setMusicLabelXSecondValue)
                {
                    MusicLabel.X = MusicLabelXFirstValue * (1 - interpolationValue) + MusicLabelXSecondValue * interpolationValue;
                }
                if (setMusicLabelYFirstValue && setMusicLabelYSecondValue)
                {
                    MusicLabel.Y = MusicLabelYFirstValue * (1 - interpolationValue) + MusicLabelYSecondValue * interpolationValue;
                }
                if (setOptionsControlsInstanceHeightFirstValue && setOptionsControlsInstanceHeightSecondValue)
                {
                    OptionsControlsInstance.Height = OptionsControlsInstanceHeightFirstValue * (1 - interpolationValue) + OptionsControlsInstanceHeightSecondValue * interpolationValue;
                }
                if (setOptionsControlsInstanceWidthFirstValue && setOptionsControlsInstanceWidthSecondValue)
                {
                    OptionsControlsInstance.Width = OptionsControlsInstanceWidthFirstValue * (1 - interpolationValue) + OptionsControlsInstanceWidthSecondValue * interpolationValue;
                }
                if (setOptionsControlsInstanceXFirstValue && setOptionsControlsInstanceXSecondValue)
                {
                    OptionsControlsInstance.X = OptionsControlsInstanceXFirstValue * (1 - interpolationValue) + OptionsControlsInstanceXSecondValue * interpolationValue;
                }
                if (setOptionsControlsInstanceYFirstValue && setOptionsControlsInstanceYSecondValue)
                {
                    OptionsControlsInstance.Y = OptionsControlsInstanceYFirstValue * (1 - interpolationValue) + OptionsControlsInstanceYSecondValue * interpolationValue;
                }
                if (setVersionTextFontScaleFirstValue && setVersionTextFontScaleSecondValue)
                {
                    VersionText.FontScale = VersionTextFontScaleFirstValue * (1 - interpolationValue) + VersionTextFontScaleSecondValue * interpolationValue;
                }
                if (setVersionTextHeightFirstValue && setVersionTextHeightSecondValue)
                {
                    VersionText.Height = VersionTextHeightFirstValue * (1 - interpolationValue) + VersionTextHeightSecondValue * interpolationValue;
                }
                if (setVersionTextWidthFirstValue && setVersionTextWidthSecondValue)
                {
                    VersionText.Width = VersionTextWidthFirstValue * (1 - interpolationValue) + VersionTextWidthSecondValue * interpolationValue;
                }
                if (setVersionTextXFirstValue && setVersionTextXSecondValue)
                {
                    VersionText.X = VersionTextXFirstValue * (1 - interpolationValue) + VersionTextXSecondValue * interpolationValue;
                }
                if (setVersionTextYFirstValue && setVersionTextYSecondValue)
                {
                    VersionText.Y = VersionTextYFirstValue * (1 - interpolationValue) + VersionTextYSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentVariableState = firstState;
                }
                else
                {
                    mCurrentVariableState = secondState;
                }
            }
            public void InterpolateBetween (Options firstState, Options secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setOptionsControlsInstanceCurrentVariableStateFirstValue = false;
                bool setOptionsControlsInstanceCurrentVariableStateSecondValue = false;
                OptionsControlsRuntime.VariableState OptionsControlsInstanceCurrentVariableStateFirstValue= OptionsControlsRuntime.VariableState.Default;
                OptionsControlsRuntime.VariableState OptionsControlsInstanceCurrentVariableStateSecondValue= OptionsControlsRuntime.VariableState.Default;
                switch(firstState)
                {
                    case  Options.Visible:
                        setOptionsControlsInstanceCurrentVariableStateFirstValue = true;
                        OptionsControlsInstanceCurrentVariableStateFirstValue = AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState.Default;
                        if (interpolationValue < 1)
                        {
                            this.OptionsControlsInstance.Visible = true;
                        }
                        break;
                    case  Options.Hidden:
                        setOptionsControlsInstanceCurrentVariableStateFirstValue = true;
                        OptionsControlsInstanceCurrentVariableStateFirstValue = AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState.Default;
                        if (interpolationValue < 1)
                        {
                            this.OptionsControlsInstance.Visible = false;
                        }
                        break;
                    case  Options.NoFullScreen:
                        setOptionsControlsInstanceCurrentVariableStateFirstValue = true;
                        OptionsControlsInstanceCurrentVariableStateFirstValue = AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState.HiddenFullScreen;
                        if (interpolationValue < 1)
                        {
                            this.OptionsControlsInstance.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  Options.Visible:
                        setOptionsControlsInstanceCurrentVariableStateSecondValue = true;
                        OptionsControlsInstanceCurrentVariableStateSecondValue = AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState.Default;
                        if (interpolationValue >= 1)
                        {
                            this.OptionsControlsInstance.Visible = true;
                        }
                        break;
                    case  Options.Hidden:
                        setOptionsControlsInstanceCurrentVariableStateSecondValue = true;
                        OptionsControlsInstanceCurrentVariableStateSecondValue = AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState.Default;
                        if (interpolationValue >= 1)
                        {
                            this.OptionsControlsInstance.Visible = false;
                        }
                        break;
                    case  Options.NoFullScreen:
                        setOptionsControlsInstanceCurrentVariableStateSecondValue = true;
                        OptionsControlsInstanceCurrentVariableStateSecondValue = AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState.HiddenFullScreen;
                        if (interpolationValue >= 1)
                        {
                            this.OptionsControlsInstance.Visible = true;
                        }
                        break;
                }
                if (setOptionsControlsInstanceCurrentVariableStateFirstValue && setOptionsControlsInstanceCurrentVariableStateSecondValue)
                {
                    OptionsControlsInstance.InterpolateBetween(OptionsControlsInstanceCurrentVariableStateFirstValue, OptionsControlsInstanceCurrentVariableStateSecondValue, interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentOptionsState = firstState;
                }
                else
                {
                    mCurrentOptionsState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime.Options fromState,AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime.Options toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Options toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Options").States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentOptionsState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Options toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentOptionsState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                MenuFrameInstance.StopAnimations();
                ButtonFrameInstance.StopAnimations();
                ButtonFrameInstance1.StopAnimations();
                ButtonFrameInstance2.StopAnimations();
                ButtonFrameInstance3.StopAnimations();
                OptionsControlsInstance.StopAnimations();
                CloseButton.StopAnimations();
            }
            #region Get Current Values on State
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Height",
                            Type = "float",
                            Value = ButtonFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Width",
                            Type = "float",
                            Value = ButtonFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.X",
                            Type = "float",
                            Value = ButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Y",
                            Type = "float",
                            Value = ButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Height",
                            Type = "float",
                            Value = ButtonFrameInstance1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Width",
                            Type = "float",
                            Value = ButtonFrameInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Height",
                            Type = "float",
                            Value = ButtonFrameInstance2.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Width",
                            Type = "float",
                            Value = ButtonFrameInstance2.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance2.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Height",
                            Type = "float",
                            Value = ButtonFrameInstance3.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Width",
                            Type = "float",
                            Value = ButtonFrameInstance3.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance3.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance3.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.CustomFontFile",
                            Type = "string",
                            Value = VersionText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Font Scale",
                            Type = "float",
                            Value = VersionText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Height",
                            Type = "float",
                            Value = VersionText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Parent",
                            Type = "string",
                            Value = VersionText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Text",
                            Type = "string",
                            Value = VersionText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.UseCustomFont",
                            Type = "bool",
                            Value = VersionText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Width",
                            Type = "float",
                            Value = VersionText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.X",
                            Type = "float",
                            Value = VersionText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.X Units",
                            Type = "PositionUnitType",
                            Value = VersionText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Y",
                            Type = "float",
                            Value = VersionText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Y Units",
                            Type = "PositionUnitType",
                            Value = VersionText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Height",
                            Type = "float",
                            Value = OptionsControlsInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = OptionsControlsInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Parent",
                            Type = "string",
                            Value = OptionsControlsInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Width",
                            Type = "float",
                            Value = OptionsControlsInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = OptionsControlsInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.X",
                            Type = "float",
                            Value = OptionsControlsInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.X Units",
                            Type = "PositionUnitType",
                            Value = OptionsControlsInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Y",
                            Type = "float",
                            Value = OptionsControlsInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = OptionsControlsInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Height",
                            Type = "float",
                            Value = CloseButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = CloseButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Width",
                            Type = "float",
                            Value = CloseButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = CloseButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.X",
                            Type = "float",
                            Value = CloseButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.X Units",
                            Type = "PositionUnitType",
                            Value = CloseButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Y",
                            Type = "float",
                            Value = CloseButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Y Units",
                            Type = "PositionUnitType",
                            Value = CloseButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Blue",
                            Type = "int",
                            Value = CurrentMusicBackdrop.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Green",
                            Type = "int",
                            Value = CurrentMusicBackdrop.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Height",
                            Type = "float",
                            Value = CurrentMusicBackdrop.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Height Units",
                            Type = "DimensionUnitType",
                            Value = CurrentMusicBackdrop.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Parent",
                            Type = "string",
                            Value = CurrentMusicBackdrop.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Red",
                            Type = "int",
                            Value = CurrentMusicBackdrop.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Width",
                            Type = "float",
                            Value = CurrentMusicBackdrop.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Width Units",
                            Type = "DimensionUnitType",
                            Value = CurrentMusicBackdrop.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.X",
                            Type = "float",
                            Value = CurrentMusicBackdrop.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CurrentMusicBackdrop.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.X Units",
                            Type = "PositionUnitType",
                            Value = CurrentMusicBackdrop.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Y",
                            Type = "float",
                            Value = CurrentMusicBackdrop.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CurrentMusicBackdrop.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Y Units",
                            Type = "PositionUnitType",
                            Value = CurrentMusicBackdrop.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.CustomFontFile",
                            Type = "string",
                            Value = MusicInfo.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Font Scale",
                            Type = "float",
                            Value = MusicInfo.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Height",
                            Type = "float",
                            Value = MusicInfo.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MusicInfo.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Parent",
                            Type = "string",
                            Value = MusicInfo.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Text",
                            Type = "string",
                            Value = MusicInfo.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.UseCustomFont",
                            Type = "bool",
                            Value = MusicInfo.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MusicInfo.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Width",
                            Type = "float",
                            Value = MusicInfo.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.X",
                            Type = "float",
                            Value = MusicInfo.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MusicInfo.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.X Units",
                            Type = "PositionUnitType",
                            Value = MusicInfo.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Y",
                            Type = "float",
                            Value = MusicInfo.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MusicInfo.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Y Units",
                            Type = "PositionUnitType",
                            Value = MusicInfo.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Blue",
                            Type = "int",
                            Value = MusicLabel.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.CustomFontFile",
                            Type = "string",
                            Value = MusicLabel.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Font Scale",
                            Type = "float",
                            Value = MusicLabel.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Green",
                            Type = "int",
                            Value = MusicLabel.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Height",
                            Type = "float",
                            Value = MusicLabel.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MusicLabel.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Parent",
                            Type = "string",
                            Value = MusicLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Red",
                            Type = "int",
                            Value = MusicLabel.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Text",
                            Type = "string",
                            Value = MusicLabel.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.UseCustomFont",
                            Type = "bool",
                            Value = MusicLabel.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MusicLabel.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Width",
                            Type = "float",
                            Value = MusicLabel.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.X",
                            Type = "float",
                            Value = MusicLabel.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Y",
                            Type = "float",
                            Value = MusicLabel.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MusicLabel.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Y Units",
                            Type = "PositionUnitType",
                            Value = MusicLabel.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Blue",
                            Type = "int",
                            Value = CurrentMusicFrame.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Green",
                            Type = "int",
                            Value = CurrentMusicFrame.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Height",
                            Type = "float",
                            Value = CurrentMusicFrame.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Red",
                            Type = "int",
                            Value = CurrentMusicFrame.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Width",
                            Type = "float",
                            Value = CurrentMusicFrame.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.X",
                            Type = "float",
                            Value = CurrentMusicFrame.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Y",
                            Type = "float",
                            Value = CurrentMusicFrame.Y
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Height",
                            Type = "float",
                            Value = ButtonFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Width",
                            Type = "float",
                            Value = ButtonFrameInstance.Width + 7.0845f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.X",
                            Type = "float",
                            Value = ButtonFrameInstance.X + 34.09375f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Y",
                            Type = "float",
                            Value = ButtonFrameInstance.Y + 64.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Height",
                            Type = "float",
                            Value = ButtonFrameInstance1.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Width",
                            Type = "float",
                            Value = ButtonFrameInstance1.Width + 7.0845f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X + 43.0625f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y + 64.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Height",
                            Type = "float",
                            Value = ButtonFrameInstance2.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Width",
                            Type = "float",
                            Value = ButtonFrameInstance2.Width + 7.0845f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X + 51.6875f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance2.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y + 64.49998f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Height",
                            Type = "float",
                            Value = ButtonFrameInstance3.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Width",
                            Type = "float",
                            Value = ButtonFrameInstance3.Width + 7.0845f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X + 60.65625f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance3.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y + 64.83331f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance3.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.CustomFontFile",
                            Type = "string",
                            Value = VersionText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Font Scale",
                            Type = "float",
                            Value = VersionText.FontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Height",
                            Type = "float",
                            Value = VersionText.Height + 34f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Parent",
                            Type = "string",
                            Value = VersionText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Text",
                            Type = "string",
                            Value = VersionText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.UseCustomFont",
                            Type = "bool",
                            Value = VersionText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Width",
                            Type = "float",
                            Value = VersionText.Width + 186f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.X",
                            Type = "float",
                            Value = VersionText.X + 10.95123f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.X Units",
                            Type = "PositionUnitType",
                            Value = VersionText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Y",
                            Type = "float",
                            Value = VersionText.Y + 6.962322f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VersionText.Y Units",
                            Type = "PositionUnitType",
                            Value = VersionText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Height",
                            Type = "float",
                            Value = OptionsControlsInstance.Height + 54.47209f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = OptionsControlsInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Parent",
                            Type = "string",
                            Value = OptionsControlsInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Width",
                            Type = "float",
                            Value = OptionsControlsInstance.Width + 70.73295f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = OptionsControlsInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.X",
                            Type = "float",
                            Value = OptionsControlsInstance.X + 14.33591f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.X Units",
                            Type = "PositionUnitType",
                            Value = OptionsControlsInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Y",
                            Type = "float",
                            Value = OptionsControlsInstance.Y + 16.62892f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = OptionsControlsInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Height",
                            Type = "float",
                            Value = CloseButton.Height + 7f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = CloseButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Width",
                            Type = "float",
                            Value = CloseButton.Width + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = CloseButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.X",
                            Type = "float",
                            Value = CloseButton.X + 67.65625f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.X Units",
                            Type = "PositionUnitType",
                            Value = CloseButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Y",
                            Type = "float",
                            Value = CloseButton.Y + 18.6111f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Y Units",
                            Type = "PositionUnitType",
                            Value = CloseButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Blue",
                            Type = "int",
                            Value = CurrentMusicBackdrop.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Green",
                            Type = "int",
                            Value = CurrentMusicBackdrop.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Height",
                            Type = "float",
                            Value = CurrentMusicBackdrop.Height + -5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Height Units",
                            Type = "DimensionUnitType",
                            Value = CurrentMusicBackdrop.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Parent",
                            Type = "string",
                            Value = CurrentMusicBackdrop.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Red",
                            Type = "int",
                            Value = CurrentMusicBackdrop.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Width",
                            Type = "float",
                            Value = CurrentMusicBackdrop.Width + -5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Width Units",
                            Type = "DimensionUnitType",
                            Value = CurrentMusicBackdrop.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.X",
                            Type = "float",
                            Value = CurrentMusicBackdrop.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CurrentMusicBackdrop.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.X Units",
                            Type = "PositionUnitType",
                            Value = CurrentMusicBackdrop.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Y",
                            Type = "float",
                            Value = CurrentMusicBackdrop.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CurrentMusicBackdrop.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicBackdrop.Y Units",
                            Type = "PositionUnitType",
                            Value = CurrentMusicBackdrop.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.CustomFontFile",
                            Type = "string",
                            Value = MusicInfo.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Font Scale",
                            Type = "float",
                            Value = MusicInfo.FontScale + 0.4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Height",
                            Type = "float",
                            Value = MusicInfo.Height + 57f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MusicInfo.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Parent",
                            Type = "string",
                            Value = MusicInfo.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Text",
                            Type = "string",
                            Value = MusicInfo.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.UseCustomFont",
                            Type = "bool",
                            Value = MusicInfo.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MusicInfo.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Width",
                            Type = "float",
                            Value = MusicInfo.Width + 659f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.X",
                            Type = "float",
                            Value = MusicInfo.X + 594f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MusicInfo.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.X Units",
                            Type = "PositionUnitType",
                            Value = MusicInfo.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Y",
                            Type = "float",
                            Value = MusicInfo.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MusicInfo.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicInfo.Y Units",
                            Type = "PositionUnitType",
                            Value = MusicInfo.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Blue",
                            Type = "int",
                            Value = MusicLabel.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.CustomFontFile",
                            Type = "string",
                            Value = MusicLabel.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Font Scale",
                            Type = "float",
                            Value = MusicLabel.FontScale + 0.6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Green",
                            Type = "int",
                            Value = MusicLabel.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Height",
                            Type = "float",
                            Value = MusicLabel.Height + 57f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MusicLabel.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Parent",
                            Type = "string",
                            Value = MusicLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Red",
                            Type = "int",
                            Value = MusicLabel.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Text",
                            Type = "string",
                            Value = MusicLabel.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.UseCustomFont",
                            Type = "bool",
                            Value = MusicLabel.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MusicLabel.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Width",
                            Type = "float",
                            Value = MusicLabel.Width + 263f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.X",
                            Type = "float",
                            Value = MusicLabel.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Y",
                            Type = "float",
                            Value = MusicLabel.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MusicLabel.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicLabel.Y Units",
                            Type = "PositionUnitType",
                            Value = MusicLabel.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Blue",
                            Type = "int",
                            Value = CurrentMusicFrame.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Green",
                            Type = "int",
                            Value = CurrentMusicFrame.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Height",
                            Type = "float",
                            Value = CurrentMusicFrame.Height + 55f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Red",
                            Type = "int",
                            Value = CurrentMusicFrame.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Width",
                            Type = "float",
                            Value = CurrentMusicFrame.Width + 923f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.X",
                            Type = "float",
                            Value = CurrentMusicFrame.X + 845f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicFrame.Y",
                            Type = "float",
                            Value = CurrentMusicFrame.Y + 868f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Options state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Options.Visible:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.State",
                            Type = "State",
                            Value = OptionsControlsInstance.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Visible",
                            Type = "bool",
                            Value = OptionsControlsInstance.Visible
                        }
                        );
                        break;
                    case  Options.Hidden:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.State",
                            Type = "State",
                            Value = OptionsControlsInstance.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Visible",
                            Type = "bool",
                            Value = OptionsControlsInstance.Visible
                        }
                        );
                        break;
                    case  Options.NoFullScreen:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.State",
                            Type = "State",
                            Value = OptionsControlsInstance.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Visible",
                            Type = "bool",
                            Value = OptionsControlsInstance.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Options state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Options.Visible:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.State",
                            Type = "State",
                            Value = OptionsControlsInstance.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Visible",
                            Type = "bool",
                            Value = OptionsControlsInstance.Visible
                        }
                        );
                        break;
                    case  Options.Hidden:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.State",
                            Type = "State",
                            Value = OptionsControlsInstance.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Visible",
                            Type = "bool",
                            Value = OptionsControlsInstance.Visible
                        }
                        );
                        break;
                    case  Options.NoFullScreen:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.State",
                            Type = "State",
                            Value = OptionsControlsInstance.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsControlsInstance.Visible",
                            Type = "bool",
                            Value = OptionsControlsInstance.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            #endregion
            public override void ApplyState (Gum.DataTypes.Variables.StateSave state) 
            {
                bool matches = this.ElementSave.AllStates.Contains(state);
                if (matches)
                {
                    var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                    if (category == null)
                    {
                        if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                    }
                    else if (category.Name == "Options")
                    {
                        if(state.Name == "Visible") this.mCurrentOptionsState = Options.Visible;
                        if(state.Name == "Hidden") this.mCurrentOptionsState = Options.Hidden;
                        if(state.Name == "NoFullScreen") this.mCurrentOptionsState = Options.NoFullScreen;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.MenuFrameRuntime MenuFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance2 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance3 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime VersionText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime OptionsControlsInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.CloseChatButtonRuntime CloseButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime CurrentMusicBackdrop { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime MusicInfo { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime MusicLabel { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime CurrentMusicFrame { get; set; }
            public ButtonFrameRuntime.ButtonType ButtonType1State
            {
                get
                {
                    return ButtonFrameInstance.CurrentButtonTypeState;
                }
                set
                {
                    if (ButtonFrameInstance.CurrentButtonTypeState != value)
                    {
                        ButtonFrameInstance.CurrentButtonTypeState = value;
                        ButtonType1StateChanged?.Invoke(this, null);
                    }
                }
            }
            public ButtonFrameRuntime.ButtonType ButtonType2State
            {
                get
                {
                    return ButtonFrameInstance1.CurrentButtonTypeState;
                }
                set
                {
                    if (ButtonFrameInstance1.CurrentButtonTypeState != value)
                    {
                        ButtonFrameInstance1.CurrentButtonTypeState = value;
                        ButtonType2StateChanged?.Invoke(this, null);
                    }
                }
            }
            public ButtonFrameRuntime.ButtonType ButtonType3State
            {
                get
                {
                    return ButtonFrameInstance2.CurrentButtonTypeState;
                }
                set
                {
                    if (ButtonFrameInstance2.CurrentButtonTypeState != value)
                    {
                        ButtonFrameInstance2.CurrentButtonTypeState = value;
                        ButtonType3StateChanged?.Invoke(this, null);
                    }
                }
            }
            public ButtonFrameRuntime.ButtonType ButtonType4State
            {
                get
                {
                    return ButtonFrameInstance3.CurrentButtonTypeState;
                }
                set
                {
                    if (ButtonFrameInstance3.CurrentButtonTypeState != value)
                    {
                        ButtonFrameInstance3.CurrentButtonTypeState = value;
                        ButtonType4StateChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler ButtonType1StateChanged;
            public event System.EventHandler ButtonType2StateChanged;
            public event System.EventHandler ButtonType3StateChanged;
            public event System.EventHandler ButtonType4StateChanged;
            public MenuWindowRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "MenuWindow");
                    this.ElementSave = elementSave;
                    string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                    FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                    GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                    FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
                }
            }
            public override void SetInitialState () 
            {
                base.SetInitialState();
                this.CurrentVariableState = VariableState.Default;
                CallCustomInitialize();
            }
            public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.SystemManagers systemManagers) 
            {
                base.CreateChildrenRecursively(elementSave, systemManagers);
                this.AssignReferences();
            }
            private void AssignReferences () 
            {
                MenuFrameInstance = this.GetGraphicalUiElementByName("MenuFrameInstance") as AbbatoirIntergrade.GumRuntimes.MenuFrameRuntime;
                ButtonFrameInstance = this.GetGraphicalUiElementByName("ButtonFrameInstance") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                ButtonFrameInstance1 = this.GetGraphicalUiElementByName("ButtonFrameInstance1") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                ButtonFrameInstance2 = this.GetGraphicalUiElementByName("ButtonFrameInstance2") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                ButtonFrameInstance3 = this.GetGraphicalUiElementByName("ButtonFrameInstance3") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                VersionText = this.GetGraphicalUiElementByName("VersionText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                OptionsControlsInstance = this.GetGraphicalUiElementByName("OptionsControlsInstance") as AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime;
                CloseButton = this.GetGraphicalUiElementByName("CloseButton") as AbbatoirIntergrade.GumRuntimes.CloseChatButtonRuntime;
                CurrentMusicBackdrop = this.GetGraphicalUiElementByName("CurrentMusicBackdrop") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                MusicInfo = this.GetGraphicalUiElementByName("MusicInfo") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                MusicLabel = this.GetGraphicalUiElementByName("MusicLabel") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                CurrentMusicFrame = this.GetGraphicalUiElementByName("CurrentMusicFrame") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
            }
            public override void AddToManagers (RenderingLibrary.SystemManagers managers, RenderingLibrary.Graphics.Layer layer) 
            {
                base.AddToManagers(managers, layer);
            }
            private void CallCustomInitialize () 
            {
                CustomInitialize();
            }
            partial void CustomInitialize();
        }
    }
