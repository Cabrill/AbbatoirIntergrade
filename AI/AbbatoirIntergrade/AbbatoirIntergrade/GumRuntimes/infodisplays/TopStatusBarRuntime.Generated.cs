    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class TopStatusBarRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum TimeDisplay
            {
                TimeStart,
                TimeEnd,
                DefaultTime
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            TimeDisplay mCurrentTimeDisplayState;
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
                            Height = 0f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            Width = 0f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MenuButton.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Menu;
                            MenuButton.Height = 64f;
                            MenuButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            MenuButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            MenuButton.Width = 64f;
                            MenuButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("SpriteInstance.SourceFile", "AllUIAssets.png");
                            SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SpriteInstance.TextureHeight = 70;
                            SpriteInstance.TextureLeft = 0;
                            SpriteInstance.TextureTop = 3840;
                            SpriteInstance.TextureWidth = 1320;
                            InfoContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            InfoContainer.Height = 0f;
                            InfoContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            InfoContainer.Width = 1245f;
                            InfoContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            InfoContainer.X = 35f;
                            WaveLabel.Blue = 255;
                            SetProperty("WaveLabel.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            WaveLabel.Green = 191;
                            WaveLabel.Height = 0f;
                            WaveLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            WaveLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            WaveLabel.Red = 0;
                            WaveLabel.Text = "Wave";
                            WaveLabel.UseCustomFont = true;
                            WaveLabel.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            WaveLabel.Width = 0f;
                            WaveLabel.X = 100f;
                            WaveLabel.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            WaveLabel.Y = 0f;
                            SetProperty("WaveTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            WaveTextInstance.Height = 0f;
                            WaveTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            WaveTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            WaveTextInstance.Text = "0/15";
                            WaveTextInstance.UseCustomFont = true;
                            WaveTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            WaveTextInstance.Width = 0f;
                            WaveTextInstance.X = 100f;
                            WaveTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            WaveTextInstance.Y = 0f;
                            TimeLabel.Blue = 255;
                            SetProperty("TimeLabel.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            TimeLabel.FontScale = 0.7f;
                            TimeLabel.Green = 191;
                            TimeLabel.Height = 0f;
                            TimeLabel.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TimeLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TimeLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            TimeLabel.Red = 0;
                            TimeLabel.Text = "Time:";
                            TimeLabel.UseCustomFont = true;
                            TimeLabel.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TimeLabel.Width = 0f;
                            TimeLabel.X = -500f;
                            TimeLabel.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TimeLabel.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            TimeLabel.Y = 0f;
                            TimeLabel.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TimeLabel.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TimeTextInstance.Blue = 255;
                            SetProperty("TimeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            TimeTextInstance.FontScale = 0.7f;
                            TimeTextInstance.Green = 255;
                            TimeTextInstance.Height = 0f;
                            TimeTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TimeTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TimeTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            TimeTextInstance.Red = 255;
                            TimeTextInstance.Text = "00:00.00";
                            TimeTextInstance.UseCustomFont = true;
                            TimeTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TimeTextInstance.Width = 200f;
                            TimeTextInstance.X = -300f;
                            TimeTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TimeTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            TimeTextInstance.Y = 0f;
                            TimeTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TimeTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            PauseButton.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Pause;
                            PauseButton.Height = 64f;
                            PauseButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            PauseButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimeButtonContainer");
                            PauseButton.Width = 64f;
                            PauseButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            PauseButton.X = 0f;
                            PauseButton.Y = 0f;
                            PlayButton.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Play;
                            PlayButton.Height = 64f;
                            PlayButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            PlayButton.CurrentHighlightState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.Highlight.NotHighlighted;
                            PlayButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimeButtonContainer");
                            PlayButton.CurrentSelectState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.Select.Selected;
                            PlayButton.Width = 64f;
                            PlayButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            PlayButton.X = 15f;
                            PlayButton.Y = 0f;
                            FastForwardButton.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.FastForward;
                            FastForwardButton.Height = 64f;
                            FastForwardButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            FastForwardButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimeButtonContainer");
                            FastForwardButton.Width = 64f;
                            FastForwardButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            FastForwardButton.X = 15f;
                            FastForwardButton.Y = 0f;
                            TimeButtonContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            TimeButtonContainer.Height = 0f;
                            TimeButtonContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TimeButtonContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            TimeButtonContainer.Width = 0f;
                            TimeButtonContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TimeButtonContainer.X = 0f;
                            TimeButtonContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TimeButtonContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            TimeButtonContainer.Y = 0f;
                            break;
                    }
                }
            }
            public TimeDisplay CurrentTimeDisplayState
            {
                get
                {
                    return mCurrentTimeDisplayState;
                }
                set
                {
                    mCurrentTimeDisplayState = value;
                    switch(mCurrentTimeDisplayState)
                    {
                        case  TimeDisplay.TimeStart:
                            TimeTextInstance.Blue = 169;
                            TimeTextInstance.Green = 169;
                            TimeTextInstance.Red = 169;
                            break;
                        case  TimeDisplay.TimeEnd:
                            TimeTextInstance.Blue = 203;
                            TimeTextInstance.Green = 192;
                            TimeTextInstance.Red = 255;
                            break;
                        case  TimeDisplay.DefaultTime:
                            TimeTextInstance.Blue = 255;
                            TimeTextInstance.Green = 255;
                            TimeTextInstance.Red = 255;
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
                bool setFastForwardButtonCurrentButtonTypeStateFirstValue = false;
                bool setFastForwardButtonCurrentButtonTypeStateSecondValue = false;
                ButtonFrameRuntime.ButtonType FastForwardButtonCurrentButtonTypeStateFirstValue= ButtonFrameRuntime.ButtonType.Check;
                ButtonFrameRuntime.ButtonType FastForwardButtonCurrentButtonTypeStateSecondValue= ButtonFrameRuntime.ButtonType.Check;
                bool setFastForwardButtonHeightFirstValue = false;
                bool setFastForwardButtonHeightSecondValue = false;
                float FastForwardButtonHeightFirstValue= 0;
                float FastForwardButtonHeightSecondValue= 0;
                bool setFastForwardButtonWidthFirstValue = false;
                bool setFastForwardButtonWidthSecondValue = false;
                float FastForwardButtonWidthFirstValue= 0;
                float FastForwardButtonWidthSecondValue= 0;
                bool setFastForwardButtonXFirstValue = false;
                bool setFastForwardButtonXSecondValue = false;
                float FastForwardButtonXFirstValue= 0;
                float FastForwardButtonXSecondValue= 0;
                bool setFastForwardButtonYFirstValue = false;
                bool setFastForwardButtonYSecondValue = false;
                float FastForwardButtonYFirstValue= 0;
                float FastForwardButtonYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setInfoContainerHeightFirstValue = false;
                bool setInfoContainerHeightSecondValue = false;
                float InfoContainerHeightFirstValue= 0;
                float InfoContainerHeightSecondValue= 0;
                bool setInfoContainerWidthFirstValue = false;
                bool setInfoContainerWidthSecondValue = false;
                float InfoContainerWidthFirstValue= 0;
                float InfoContainerWidthSecondValue= 0;
                bool setInfoContainerXFirstValue = false;
                bool setInfoContainerXSecondValue = false;
                float InfoContainerXFirstValue= 0;
                float InfoContainerXSecondValue= 0;
                bool setMenuButtonCurrentButtonTypeStateFirstValue = false;
                bool setMenuButtonCurrentButtonTypeStateSecondValue = false;
                ButtonFrameRuntime.ButtonType MenuButtonCurrentButtonTypeStateFirstValue= ButtonFrameRuntime.ButtonType.Check;
                ButtonFrameRuntime.ButtonType MenuButtonCurrentButtonTypeStateSecondValue= ButtonFrameRuntime.ButtonType.Check;
                bool setMenuButtonHeightFirstValue = false;
                bool setMenuButtonHeightSecondValue = false;
                float MenuButtonHeightFirstValue= 0;
                float MenuButtonHeightSecondValue= 0;
                bool setMenuButtonWidthFirstValue = false;
                bool setMenuButtonWidthSecondValue = false;
                float MenuButtonWidthFirstValue= 0;
                float MenuButtonWidthSecondValue= 0;
                bool setPauseButtonCurrentButtonTypeStateFirstValue = false;
                bool setPauseButtonCurrentButtonTypeStateSecondValue = false;
                ButtonFrameRuntime.ButtonType PauseButtonCurrentButtonTypeStateFirstValue= ButtonFrameRuntime.ButtonType.Check;
                ButtonFrameRuntime.ButtonType PauseButtonCurrentButtonTypeStateSecondValue= ButtonFrameRuntime.ButtonType.Check;
                bool setPauseButtonHeightFirstValue = false;
                bool setPauseButtonHeightSecondValue = false;
                float PauseButtonHeightFirstValue= 0;
                float PauseButtonHeightSecondValue= 0;
                bool setPauseButtonWidthFirstValue = false;
                bool setPauseButtonWidthSecondValue = false;
                float PauseButtonWidthFirstValue= 0;
                float PauseButtonWidthSecondValue= 0;
                bool setPauseButtonXFirstValue = false;
                bool setPauseButtonXSecondValue = false;
                float PauseButtonXFirstValue= 0;
                float PauseButtonXSecondValue= 0;
                bool setPauseButtonYFirstValue = false;
                bool setPauseButtonYSecondValue = false;
                float PauseButtonYFirstValue= 0;
                float PauseButtonYSecondValue= 0;
                bool setPlayButtonCurrentButtonTypeStateFirstValue = false;
                bool setPlayButtonCurrentButtonTypeStateSecondValue = false;
                ButtonFrameRuntime.ButtonType PlayButtonCurrentButtonTypeStateFirstValue= ButtonFrameRuntime.ButtonType.Check;
                ButtonFrameRuntime.ButtonType PlayButtonCurrentButtonTypeStateSecondValue= ButtonFrameRuntime.ButtonType.Check;
                bool setPlayButtonHeightFirstValue = false;
                bool setPlayButtonHeightSecondValue = false;
                float PlayButtonHeightFirstValue= 0;
                float PlayButtonHeightSecondValue= 0;
                bool setPlayButtonCurrentHighlightStateFirstValue = false;
                bool setPlayButtonCurrentHighlightStateSecondValue = false;
                ButtonFrameRuntime.Highlight PlayButtonCurrentHighlightStateFirstValue= ButtonFrameRuntime.Highlight.Highlighted;
                ButtonFrameRuntime.Highlight PlayButtonCurrentHighlightStateSecondValue= ButtonFrameRuntime.Highlight.Highlighted;
                bool setPlayButtonCurrentSelectStateFirstValue = false;
                bool setPlayButtonCurrentSelectStateSecondValue = false;
                ButtonFrameRuntime.Select PlayButtonCurrentSelectStateFirstValue= ButtonFrameRuntime.Select.Selected;
                ButtonFrameRuntime.Select PlayButtonCurrentSelectStateSecondValue= ButtonFrameRuntime.Select.Selected;
                bool setPlayButtonWidthFirstValue = false;
                bool setPlayButtonWidthSecondValue = false;
                float PlayButtonWidthFirstValue= 0;
                float PlayButtonWidthSecondValue= 0;
                bool setPlayButtonXFirstValue = false;
                bool setPlayButtonXSecondValue = false;
                float PlayButtonXFirstValue= 0;
                float PlayButtonXSecondValue= 0;
                bool setPlayButtonYFirstValue = false;
                bool setPlayButtonYSecondValue = false;
                float PlayButtonYFirstValue= 0;
                float PlayButtonYSecondValue= 0;
                bool setSpriteInstanceTextureHeightFirstValue = false;
                bool setSpriteInstanceTextureHeightSecondValue = false;
                int SpriteInstanceTextureHeightFirstValue= 0;
                int SpriteInstanceTextureHeightSecondValue= 0;
                bool setSpriteInstanceTextureLeftFirstValue = false;
                bool setSpriteInstanceTextureLeftSecondValue = false;
                int SpriteInstanceTextureLeftFirstValue= 0;
                int SpriteInstanceTextureLeftSecondValue= 0;
                bool setSpriteInstanceTextureTopFirstValue = false;
                bool setSpriteInstanceTextureTopSecondValue = false;
                int SpriteInstanceTextureTopFirstValue= 0;
                int SpriteInstanceTextureTopSecondValue= 0;
                bool setSpriteInstanceTextureWidthFirstValue = false;
                bool setSpriteInstanceTextureWidthSecondValue = false;
                int SpriteInstanceTextureWidthFirstValue= 0;
                int SpriteInstanceTextureWidthSecondValue= 0;
                bool setTimeButtonContainerHeightFirstValue = false;
                bool setTimeButtonContainerHeightSecondValue = false;
                float TimeButtonContainerHeightFirstValue= 0;
                float TimeButtonContainerHeightSecondValue= 0;
                bool setTimeButtonContainerWidthFirstValue = false;
                bool setTimeButtonContainerWidthSecondValue = false;
                float TimeButtonContainerWidthFirstValue= 0;
                float TimeButtonContainerWidthSecondValue= 0;
                bool setTimeButtonContainerXFirstValue = false;
                bool setTimeButtonContainerXSecondValue = false;
                float TimeButtonContainerXFirstValue= 0;
                float TimeButtonContainerXSecondValue= 0;
                bool setTimeButtonContainerYFirstValue = false;
                bool setTimeButtonContainerYSecondValue = false;
                float TimeButtonContainerYFirstValue= 0;
                float TimeButtonContainerYSecondValue= 0;
                bool setTimeLabelBlueFirstValue = false;
                bool setTimeLabelBlueSecondValue = false;
                int TimeLabelBlueFirstValue= 0;
                int TimeLabelBlueSecondValue= 0;
                bool setTimeLabelFontScaleFirstValue = false;
                bool setTimeLabelFontScaleSecondValue = false;
                float TimeLabelFontScaleFirstValue= 0;
                float TimeLabelFontScaleSecondValue= 0;
                bool setTimeLabelGreenFirstValue = false;
                bool setTimeLabelGreenSecondValue = false;
                int TimeLabelGreenFirstValue= 0;
                int TimeLabelGreenSecondValue= 0;
                bool setTimeLabelHeightFirstValue = false;
                bool setTimeLabelHeightSecondValue = false;
                float TimeLabelHeightFirstValue= 0;
                float TimeLabelHeightSecondValue= 0;
                bool setTimeLabelRedFirstValue = false;
                bool setTimeLabelRedSecondValue = false;
                int TimeLabelRedFirstValue= 0;
                int TimeLabelRedSecondValue= 0;
                bool setTimeLabelWidthFirstValue = false;
                bool setTimeLabelWidthSecondValue = false;
                float TimeLabelWidthFirstValue= 0;
                float TimeLabelWidthSecondValue= 0;
                bool setTimeLabelXFirstValue = false;
                bool setTimeLabelXSecondValue = false;
                float TimeLabelXFirstValue= 0;
                float TimeLabelXSecondValue= 0;
                bool setTimeLabelYFirstValue = false;
                bool setTimeLabelYSecondValue = false;
                float TimeLabelYFirstValue= 0;
                float TimeLabelYSecondValue= 0;
                bool setTimeTextInstanceBlueFirstValue = false;
                bool setTimeTextInstanceBlueSecondValue = false;
                int TimeTextInstanceBlueFirstValue= 0;
                int TimeTextInstanceBlueSecondValue= 0;
                bool setTimeTextInstanceFontScaleFirstValue = false;
                bool setTimeTextInstanceFontScaleSecondValue = false;
                float TimeTextInstanceFontScaleFirstValue= 0;
                float TimeTextInstanceFontScaleSecondValue= 0;
                bool setTimeTextInstanceGreenFirstValue = false;
                bool setTimeTextInstanceGreenSecondValue = false;
                int TimeTextInstanceGreenFirstValue= 0;
                int TimeTextInstanceGreenSecondValue= 0;
                bool setTimeTextInstanceHeightFirstValue = false;
                bool setTimeTextInstanceHeightSecondValue = false;
                float TimeTextInstanceHeightFirstValue= 0;
                float TimeTextInstanceHeightSecondValue= 0;
                bool setTimeTextInstanceRedFirstValue = false;
                bool setTimeTextInstanceRedSecondValue = false;
                int TimeTextInstanceRedFirstValue= 0;
                int TimeTextInstanceRedSecondValue= 0;
                bool setTimeTextInstanceWidthFirstValue = false;
                bool setTimeTextInstanceWidthSecondValue = false;
                float TimeTextInstanceWidthFirstValue= 0;
                float TimeTextInstanceWidthSecondValue= 0;
                bool setTimeTextInstanceXFirstValue = false;
                bool setTimeTextInstanceXSecondValue = false;
                float TimeTextInstanceXFirstValue= 0;
                float TimeTextInstanceXSecondValue= 0;
                bool setTimeTextInstanceYFirstValue = false;
                bool setTimeTextInstanceYSecondValue = false;
                float TimeTextInstanceYFirstValue= 0;
                float TimeTextInstanceYSecondValue= 0;
                bool setWaveLabelBlueFirstValue = false;
                bool setWaveLabelBlueSecondValue = false;
                int WaveLabelBlueFirstValue= 0;
                int WaveLabelBlueSecondValue= 0;
                bool setWaveLabelGreenFirstValue = false;
                bool setWaveLabelGreenSecondValue = false;
                int WaveLabelGreenFirstValue= 0;
                int WaveLabelGreenSecondValue= 0;
                bool setWaveLabelHeightFirstValue = false;
                bool setWaveLabelHeightSecondValue = false;
                float WaveLabelHeightFirstValue= 0;
                float WaveLabelHeightSecondValue= 0;
                bool setWaveLabelRedFirstValue = false;
                bool setWaveLabelRedSecondValue = false;
                int WaveLabelRedFirstValue= 0;
                int WaveLabelRedSecondValue= 0;
                bool setWaveLabelWidthFirstValue = false;
                bool setWaveLabelWidthSecondValue = false;
                float WaveLabelWidthFirstValue= 0;
                float WaveLabelWidthSecondValue= 0;
                bool setWaveLabelXFirstValue = false;
                bool setWaveLabelXSecondValue = false;
                float WaveLabelXFirstValue= 0;
                float WaveLabelXSecondValue= 0;
                bool setWaveLabelYFirstValue = false;
                bool setWaveLabelYSecondValue = false;
                float WaveLabelYFirstValue= 0;
                float WaveLabelYSecondValue= 0;
                bool setWaveTextInstanceHeightFirstValue = false;
                bool setWaveTextInstanceHeightSecondValue = false;
                float WaveTextInstanceHeightFirstValue= 0;
                float WaveTextInstanceHeightSecondValue= 0;
                bool setWaveTextInstanceWidthFirstValue = false;
                bool setWaveTextInstanceWidthSecondValue = false;
                float WaveTextInstanceWidthFirstValue= 0;
                float WaveTextInstanceWidthSecondValue= 0;
                bool setWaveTextInstanceXFirstValue = false;
                bool setWaveTextInstanceXSecondValue = false;
                float WaveTextInstanceXFirstValue= 0;
                float WaveTextInstanceXSecondValue= 0;
                bool setWaveTextInstanceYFirstValue = false;
                bool setWaveTextInstanceYSecondValue = false;
                float WaveTextInstanceYFirstValue= 0;
                float WaveTextInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setFastForwardButtonCurrentButtonTypeStateFirstValue = true;
                        FastForwardButtonCurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.FastForward;
                        setFastForwardButtonHeightFirstValue = true;
                        FastForwardButtonHeightFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.FastForwardButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FastForwardButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimeButtonContainer");
                        }
                        setFastForwardButtonWidthFirstValue = true;
                        FastForwardButtonWidthFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.FastForwardButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setFastForwardButtonXFirstValue = true;
                        FastForwardButtonXFirstValue = 15f;
                        setFastForwardButtonYFirstValue = true;
                        FastForwardButtonYFirstValue = 0f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InfoContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setInfoContainerHeightFirstValue = true;
                        InfoContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InfoContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setInfoContainerWidthFirstValue = true;
                        InfoContainerWidthFirstValue = 1245f;
                        if (interpolationValue < 1)
                        {
                            this.InfoContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setInfoContainerXFirstValue = true;
                        InfoContainerXFirstValue = 35f;
                        setMenuButtonCurrentButtonTypeStateFirstValue = true;
                        MenuButtonCurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Menu;
                        setMenuButtonHeightFirstValue = true;
                        MenuButtonHeightFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.MenuButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MenuButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setMenuButtonWidthFirstValue = true;
                        MenuButtonWidthFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.MenuButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPauseButtonCurrentButtonTypeStateFirstValue = true;
                        PauseButtonCurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Pause;
                        setPauseButtonHeightFirstValue = true;
                        PauseButtonHeightFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.PauseButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PauseButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimeButtonContainer");
                        }
                        setPauseButtonWidthFirstValue = true;
                        PauseButtonWidthFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.PauseButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPauseButtonXFirstValue = true;
                        PauseButtonXFirstValue = 0f;
                        setPauseButtonYFirstValue = true;
                        PauseButtonYFirstValue = 0f;
                        setPlayButtonCurrentButtonTypeStateFirstValue = true;
                        PlayButtonCurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Play;
                        setPlayButtonHeightFirstValue = true;
                        PlayButtonHeightFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.PlayButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPlayButtonCurrentHighlightStateFirstValue = true;
                        PlayButtonCurrentHighlightStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.Highlight.NotHighlighted;
                        if (interpolationValue < 1)
                        {
                            this.PlayButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimeButtonContainer");
                        }
                        setPlayButtonCurrentSelectStateFirstValue = true;
                        PlayButtonCurrentSelectStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.Select.Selected;
                        setPlayButtonWidthFirstValue = true;
                        PlayButtonWidthFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.PlayButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPlayButtonXFirstValue = true;
                        PlayButtonXFirstValue = 15f;
                        setPlayButtonYFirstValue = true;
                        PlayButtonYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 70;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 0;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 3840;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 1320;
                        if (interpolationValue < 1)
                        {
                            this.TimeButtonContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setTimeButtonContainerHeightFirstValue = true;
                        TimeButtonContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimeButtonContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeButtonContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setTimeButtonContainerWidthFirstValue = true;
                        TimeButtonContainerWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimeButtonContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTimeButtonContainerXFirstValue = true;
                        TimeButtonContainerXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimeButtonContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeButtonContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTimeButtonContainerYFirstValue = true;
                        TimeButtonContainerYFirstValue = 0f;
                        setTimeLabelBlueFirstValue = true;
                        TimeLabelBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("TimeLabel.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTimeLabelFontScaleFirstValue = true;
                        TimeLabelFontScaleFirstValue = 0.7f;
                        setTimeLabelGreenFirstValue = true;
                        TimeLabelGreenFirstValue = 191;
                        setTimeLabelHeightFirstValue = true;
                        TimeLabelHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimeLabel.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setTimeLabelRedFirstValue = true;
                        TimeLabelRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TimeLabel.Text = "Time:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeLabel.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeLabel.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTimeLabelWidthFirstValue = true;
                        TimeLabelWidthFirstValue = 0f;
                        setTimeLabelXFirstValue = true;
                        TimeLabelXFirstValue = -500f;
                        if (interpolationValue < 1)
                        {
                            this.TimeLabel.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeLabel.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTimeLabelYFirstValue = true;
                        TimeLabelYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimeLabel.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeLabel.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTimeTextInstanceBlueFirstValue = true;
                        TimeTextInstanceBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("TimeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTimeTextInstanceFontScaleFirstValue = true;
                        TimeTextInstanceFontScaleFirstValue = 0.7f;
                        setTimeTextInstanceGreenFirstValue = true;
                        TimeTextInstanceGreenFirstValue = 255;
                        setTimeTextInstanceHeightFirstValue = true;
                        TimeTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setTimeTextInstanceRedFirstValue = true;
                        TimeTextInstanceRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.Text = "00:00.00";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTimeTextInstanceWidthFirstValue = true;
                        TimeTextInstanceWidthFirstValue = 200f;
                        setTimeTextInstanceXFirstValue = true;
                        TimeTextInstanceXFirstValue = -300f;
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTimeTextInstanceYFirstValue = true;
                        TimeTextInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWaveLabelBlueFirstValue = true;
                        WaveLabelBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("WaveLabel.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setWaveLabelGreenFirstValue = true;
                        WaveLabelGreenFirstValue = 191;
                        setWaveLabelHeightFirstValue = true;
                        WaveLabelHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WaveLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WaveLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setWaveLabelRedFirstValue = true;
                        WaveLabelRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.WaveLabel.Text = "Wave";
                        }
                        if (interpolationValue < 1)
                        {
                            this.WaveLabel.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WaveLabel.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setWaveLabelWidthFirstValue = true;
                        WaveLabelWidthFirstValue = 0f;
                        setWaveLabelXFirstValue = true;
                        WaveLabelXFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WaveLabel.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setWaveLabelYFirstValue = true;
                        WaveLabelYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("WaveTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setWaveTextInstanceHeightFirstValue = true;
                        WaveTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WaveTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WaveTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.WaveTextInstance.Text = "0/15";
                        }
                        if (interpolationValue < 1)
                        {
                            this.WaveTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WaveTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setWaveTextInstanceWidthFirstValue = true;
                        WaveTextInstanceWidthFirstValue = 0f;
                        setWaveTextInstanceXFirstValue = true;
                        WaveTextInstanceXFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WaveTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setWaveTextInstanceYFirstValue = true;
                        WaveTextInstanceYFirstValue = 0f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setFastForwardButtonCurrentButtonTypeStateSecondValue = true;
                        FastForwardButtonCurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.FastForward;
                        setFastForwardButtonHeightSecondValue = true;
                        FastForwardButtonHeightSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.FastForwardButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FastForwardButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimeButtonContainer");
                        }
                        setFastForwardButtonWidthSecondValue = true;
                        FastForwardButtonWidthSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.FastForwardButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setFastForwardButtonXSecondValue = true;
                        FastForwardButtonXSecondValue = 15f;
                        setFastForwardButtonYSecondValue = true;
                        FastForwardButtonYSecondValue = 0f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InfoContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setInfoContainerHeightSecondValue = true;
                        InfoContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InfoContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setInfoContainerWidthSecondValue = true;
                        InfoContainerWidthSecondValue = 1245f;
                        if (interpolationValue >= 1)
                        {
                            this.InfoContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setInfoContainerXSecondValue = true;
                        InfoContainerXSecondValue = 35f;
                        setMenuButtonCurrentButtonTypeStateSecondValue = true;
                        MenuButtonCurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Menu;
                        setMenuButtonHeightSecondValue = true;
                        MenuButtonHeightSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.MenuButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MenuButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setMenuButtonWidthSecondValue = true;
                        MenuButtonWidthSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.MenuButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPauseButtonCurrentButtonTypeStateSecondValue = true;
                        PauseButtonCurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Pause;
                        setPauseButtonHeightSecondValue = true;
                        PauseButtonHeightSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.PauseButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PauseButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimeButtonContainer");
                        }
                        setPauseButtonWidthSecondValue = true;
                        PauseButtonWidthSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.PauseButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPauseButtonXSecondValue = true;
                        PauseButtonXSecondValue = 0f;
                        setPauseButtonYSecondValue = true;
                        PauseButtonYSecondValue = 0f;
                        setPlayButtonCurrentButtonTypeStateSecondValue = true;
                        PlayButtonCurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Play;
                        setPlayButtonHeightSecondValue = true;
                        PlayButtonHeightSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.PlayButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPlayButtonCurrentHighlightStateSecondValue = true;
                        PlayButtonCurrentHighlightStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.Highlight.NotHighlighted;
                        if (interpolationValue >= 1)
                        {
                            this.PlayButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimeButtonContainer");
                        }
                        setPlayButtonCurrentSelectStateSecondValue = true;
                        PlayButtonCurrentSelectStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.Select.Selected;
                        setPlayButtonWidthSecondValue = true;
                        PlayButtonWidthSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.PlayButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPlayButtonXSecondValue = true;
                        PlayButtonXSecondValue = 15f;
                        setPlayButtonYSecondValue = true;
                        PlayButtonYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 70;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 0;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 3840;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 1320;
                        if (interpolationValue >= 1)
                        {
                            this.TimeButtonContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setTimeButtonContainerHeightSecondValue = true;
                        TimeButtonContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimeButtonContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeButtonContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setTimeButtonContainerWidthSecondValue = true;
                        TimeButtonContainerWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimeButtonContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTimeButtonContainerXSecondValue = true;
                        TimeButtonContainerXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimeButtonContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeButtonContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTimeButtonContainerYSecondValue = true;
                        TimeButtonContainerYSecondValue = 0f;
                        setTimeLabelBlueSecondValue = true;
                        TimeLabelBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TimeLabel.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTimeLabelFontScaleSecondValue = true;
                        TimeLabelFontScaleSecondValue = 0.7f;
                        setTimeLabelGreenSecondValue = true;
                        TimeLabelGreenSecondValue = 191;
                        setTimeLabelHeightSecondValue = true;
                        TimeLabelHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimeLabel.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setTimeLabelRedSecondValue = true;
                        TimeLabelRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TimeLabel.Text = "Time:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeLabel.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeLabel.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTimeLabelWidthSecondValue = true;
                        TimeLabelWidthSecondValue = 0f;
                        setTimeLabelXSecondValue = true;
                        TimeLabelXSecondValue = -500f;
                        if (interpolationValue >= 1)
                        {
                            this.TimeLabel.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeLabel.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTimeLabelYSecondValue = true;
                        TimeLabelYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimeLabel.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeLabel.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTimeTextInstanceBlueSecondValue = true;
                        TimeTextInstanceBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TimeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTimeTextInstanceFontScaleSecondValue = true;
                        TimeTextInstanceFontScaleSecondValue = 0.7f;
                        setTimeTextInstanceGreenSecondValue = true;
                        TimeTextInstanceGreenSecondValue = 255;
                        setTimeTextInstanceHeightSecondValue = true;
                        TimeTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setTimeTextInstanceRedSecondValue = true;
                        TimeTextInstanceRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.Text = "00:00.00";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTimeTextInstanceWidthSecondValue = true;
                        TimeTextInstanceWidthSecondValue = 200f;
                        setTimeTextInstanceXSecondValue = true;
                        TimeTextInstanceXSecondValue = -300f;
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTimeTextInstanceYSecondValue = true;
                        TimeTextInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWaveLabelBlueSecondValue = true;
                        WaveLabelBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("WaveLabel.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setWaveLabelGreenSecondValue = true;
                        WaveLabelGreenSecondValue = 191;
                        setWaveLabelHeightSecondValue = true;
                        WaveLabelHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WaveLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WaveLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setWaveLabelRedSecondValue = true;
                        WaveLabelRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.WaveLabel.Text = "Wave";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WaveLabel.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WaveLabel.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setWaveLabelWidthSecondValue = true;
                        WaveLabelWidthSecondValue = 0f;
                        setWaveLabelXSecondValue = true;
                        WaveLabelXSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WaveLabel.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setWaveLabelYSecondValue = true;
                        WaveLabelYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("WaveTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setWaveTextInstanceHeightSecondValue = true;
                        WaveTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WaveTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WaveTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WaveTextInstance.Text = "0/15";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WaveTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WaveTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setWaveTextInstanceWidthSecondValue = true;
                        WaveTextInstanceWidthSecondValue = 0f;
                        setWaveTextInstanceXSecondValue = true;
                        WaveTextInstanceXSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WaveTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setWaveTextInstanceYSecondValue = true;
                        WaveTextInstanceYSecondValue = 0f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                }
                if (setFastForwardButtonCurrentButtonTypeStateFirstValue && setFastForwardButtonCurrentButtonTypeStateSecondValue)
                {
                    FastForwardButton.InterpolateBetween(FastForwardButtonCurrentButtonTypeStateFirstValue, FastForwardButtonCurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setFastForwardButtonHeightFirstValue && setFastForwardButtonHeightSecondValue)
                {
                    FastForwardButton.Height = FastForwardButtonHeightFirstValue * (1 - interpolationValue) + FastForwardButtonHeightSecondValue * interpolationValue;
                }
                if (setFastForwardButtonWidthFirstValue && setFastForwardButtonWidthSecondValue)
                {
                    FastForwardButton.Width = FastForwardButtonWidthFirstValue * (1 - interpolationValue) + FastForwardButtonWidthSecondValue * interpolationValue;
                }
                if (setFastForwardButtonXFirstValue && setFastForwardButtonXSecondValue)
                {
                    FastForwardButton.X = FastForwardButtonXFirstValue * (1 - interpolationValue) + FastForwardButtonXSecondValue * interpolationValue;
                }
                if (setFastForwardButtonYFirstValue && setFastForwardButtonYSecondValue)
                {
                    FastForwardButton.Y = FastForwardButtonYFirstValue * (1 - interpolationValue) + FastForwardButtonYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setInfoContainerHeightFirstValue && setInfoContainerHeightSecondValue)
                {
                    InfoContainer.Height = InfoContainerHeightFirstValue * (1 - interpolationValue) + InfoContainerHeightSecondValue * interpolationValue;
                }
                if (setInfoContainerWidthFirstValue && setInfoContainerWidthSecondValue)
                {
                    InfoContainer.Width = InfoContainerWidthFirstValue * (1 - interpolationValue) + InfoContainerWidthSecondValue * interpolationValue;
                }
                if (setInfoContainerXFirstValue && setInfoContainerXSecondValue)
                {
                    InfoContainer.X = InfoContainerXFirstValue * (1 - interpolationValue) + InfoContainerXSecondValue * interpolationValue;
                }
                if (setMenuButtonCurrentButtonTypeStateFirstValue && setMenuButtonCurrentButtonTypeStateSecondValue)
                {
                    MenuButton.InterpolateBetween(MenuButtonCurrentButtonTypeStateFirstValue, MenuButtonCurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setMenuButtonHeightFirstValue && setMenuButtonHeightSecondValue)
                {
                    MenuButton.Height = MenuButtonHeightFirstValue * (1 - interpolationValue) + MenuButtonHeightSecondValue * interpolationValue;
                }
                if (setMenuButtonWidthFirstValue && setMenuButtonWidthSecondValue)
                {
                    MenuButton.Width = MenuButtonWidthFirstValue * (1 - interpolationValue) + MenuButtonWidthSecondValue * interpolationValue;
                }
                if (setPauseButtonCurrentButtonTypeStateFirstValue && setPauseButtonCurrentButtonTypeStateSecondValue)
                {
                    PauseButton.InterpolateBetween(PauseButtonCurrentButtonTypeStateFirstValue, PauseButtonCurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setPauseButtonHeightFirstValue && setPauseButtonHeightSecondValue)
                {
                    PauseButton.Height = PauseButtonHeightFirstValue * (1 - interpolationValue) + PauseButtonHeightSecondValue * interpolationValue;
                }
                if (setPauseButtonWidthFirstValue && setPauseButtonWidthSecondValue)
                {
                    PauseButton.Width = PauseButtonWidthFirstValue * (1 - interpolationValue) + PauseButtonWidthSecondValue * interpolationValue;
                }
                if (setPauseButtonXFirstValue && setPauseButtonXSecondValue)
                {
                    PauseButton.X = PauseButtonXFirstValue * (1 - interpolationValue) + PauseButtonXSecondValue * interpolationValue;
                }
                if (setPauseButtonYFirstValue && setPauseButtonYSecondValue)
                {
                    PauseButton.Y = PauseButtonYFirstValue * (1 - interpolationValue) + PauseButtonYSecondValue * interpolationValue;
                }
                if (setPlayButtonCurrentButtonTypeStateFirstValue && setPlayButtonCurrentButtonTypeStateSecondValue)
                {
                    PlayButton.InterpolateBetween(PlayButtonCurrentButtonTypeStateFirstValue, PlayButtonCurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setPlayButtonHeightFirstValue && setPlayButtonHeightSecondValue)
                {
                    PlayButton.Height = PlayButtonHeightFirstValue * (1 - interpolationValue) + PlayButtonHeightSecondValue * interpolationValue;
                }
                if (setPlayButtonCurrentHighlightStateFirstValue && setPlayButtonCurrentHighlightStateSecondValue)
                {
                    PlayButton.InterpolateBetween(PlayButtonCurrentHighlightStateFirstValue, PlayButtonCurrentHighlightStateSecondValue, interpolationValue);
                }
                if (setPlayButtonCurrentSelectStateFirstValue && setPlayButtonCurrentSelectStateSecondValue)
                {
                    PlayButton.InterpolateBetween(PlayButtonCurrentSelectStateFirstValue, PlayButtonCurrentSelectStateSecondValue, interpolationValue);
                }
                if (setPlayButtonWidthFirstValue && setPlayButtonWidthSecondValue)
                {
                    PlayButton.Width = PlayButtonWidthFirstValue * (1 - interpolationValue) + PlayButtonWidthSecondValue * interpolationValue;
                }
                if (setPlayButtonXFirstValue && setPlayButtonXSecondValue)
                {
                    PlayButton.X = PlayButtonXFirstValue * (1 - interpolationValue) + PlayButtonXSecondValue * interpolationValue;
                }
                if (setPlayButtonYFirstValue && setPlayButtonYSecondValue)
                {
                    PlayButton.Y = PlayButtonYFirstValue * (1 - interpolationValue) + PlayButtonYSecondValue * interpolationValue;
                }
                if (setSpriteInstanceTextureHeightFirstValue && setSpriteInstanceTextureHeightSecondValue)
                {
                    SpriteInstance.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureHeightFirstValue* (1 - interpolationValue) + SpriteInstanceTextureHeightSecondValue * interpolationValue);
                }
                if (setSpriteInstanceTextureLeftFirstValue && setSpriteInstanceTextureLeftSecondValue)
                {
                    SpriteInstance.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureLeftFirstValue* (1 - interpolationValue) + SpriteInstanceTextureLeftSecondValue * interpolationValue);
                }
                if (setSpriteInstanceTextureTopFirstValue && setSpriteInstanceTextureTopSecondValue)
                {
                    SpriteInstance.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureTopFirstValue* (1 - interpolationValue) + SpriteInstanceTextureTopSecondValue * interpolationValue);
                }
                if (setSpriteInstanceTextureWidthFirstValue && setSpriteInstanceTextureWidthSecondValue)
                {
                    SpriteInstance.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureWidthFirstValue* (1 - interpolationValue) + SpriteInstanceTextureWidthSecondValue * interpolationValue);
                }
                if (setTimeButtonContainerHeightFirstValue && setTimeButtonContainerHeightSecondValue)
                {
                    TimeButtonContainer.Height = TimeButtonContainerHeightFirstValue * (1 - interpolationValue) + TimeButtonContainerHeightSecondValue * interpolationValue;
                }
                if (setTimeButtonContainerWidthFirstValue && setTimeButtonContainerWidthSecondValue)
                {
                    TimeButtonContainer.Width = TimeButtonContainerWidthFirstValue * (1 - interpolationValue) + TimeButtonContainerWidthSecondValue * interpolationValue;
                }
                if (setTimeButtonContainerXFirstValue && setTimeButtonContainerXSecondValue)
                {
                    TimeButtonContainer.X = TimeButtonContainerXFirstValue * (1 - interpolationValue) + TimeButtonContainerXSecondValue * interpolationValue;
                }
                if (setTimeButtonContainerYFirstValue && setTimeButtonContainerYSecondValue)
                {
                    TimeButtonContainer.Y = TimeButtonContainerYFirstValue * (1 - interpolationValue) + TimeButtonContainerYSecondValue * interpolationValue;
                }
                if (setTimeLabelBlueFirstValue && setTimeLabelBlueSecondValue)
                {
                    TimeLabel.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TimeLabelBlueFirstValue* (1 - interpolationValue) + TimeLabelBlueSecondValue * interpolationValue);
                }
                if (setTimeLabelFontScaleFirstValue && setTimeLabelFontScaleSecondValue)
                {
                    TimeLabel.FontScale = TimeLabelFontScaleFirstValue * (1 - interpolationValue) + TimeLabelFontScaleSecondValue * interpolationValue;
                }
                if (setTimeLabelGreenFirstValue && setTimeLabelGreenSecondValue)
                {
                    TimeLabel.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TimeLabelGreenFirstValue* (1 - interpolationValue) + TimeLabelGreenSecondValue * interpolationValue);
                }
                if (setTimeLabelHeightFirstValue && setTimeLabelHeightSecondValue)
                {
                    TimeLabel.Height = TimeLabelHeightFirstValue * (1 - interpolationValue) + TimeLabelHeightSecondValue * interpolationValue;
                }
                if (setTimeLabelRedFirstValue && setTimeLabelRedSecondValue)
                {
                    TimeLabel.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TimeLabelRedFirstValue* (1 - interpolationValue) + TimeLabelRedSecondValue * interpolationValue);
                }
                if (setTimeLabelWidthFirstValue && setTimeLabelWidthSecondValue)
                {
                    TimeLabel.Width = TimeLabelWidthFirstValue * (1 - interpolationValue) + TimeLabelWidthSecondValue * interpolationValue;
                }
                if (setTimeLabelXFirstValue && setTimeLabelXSecondValue)
                {
                    TimeLabel.X = TimeLabelXFirstValue * (1 - interpolationValue) + TimeLabelXSecondValue * interpolationValue;
                }
                if (setTimeLabelYFirstValue && setTimeLabelYSecondValue)
                {
                    TimeLabel.Y = TimeLabelYFirstValue * (1 - interpolationValue) + TimeLabelYSecondValue * interpolationValue;
                }
                if (setTimeTextInstanceBlueFirstValue && setTimeTextInstanceBlueSecondValue)
                {
                    TimeTextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TimeTextInstanceBlueFirstValue* (1 - interpolationValue) + TimeTextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTimeTextInstanceFontScaleFirstValue && setTimeTextInstanceFontScaleSecondValue)
                {
                    TimeTextInstance.FontScale = TimeTextInstanceFontScaleFirstValue * (1 - interpolationValue) + TimeTextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setTimeTextInstanceGreenFirstValue && setTimeTextInstanceGreenSecondValue)
                {
                    TimeTextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TimeTextInstanceGreenFirstValue* (1 - interpolationValue) + TimeTextInstanceGreenSecondValue * interpolationValue);
                }
                if (setTimeTextInstanceHeightFirstValue && setTimeTextInstanceHeightSecondValue)
                {
                    TimeTextInstance.Height = TimeTextInstanceHeightFirstValue * (1 - interpolationValue) + TimeTextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTimeTextInstanceRedFirstValue && setTimeTextInstanceRedSecondValue)
                {
                    TimeTextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TimeTextInstanceRedFirstValue* (1 - interpolationValue) + TimeTextInstanceRedSecondValue * interpolationValue);
                }
                if (setTimeTextInstanceWidthFirstValue && setTimeTextInstanceWidthSecondValue)
                {
                    TimeTextInstance.Width = TimeTextInstanceWidthFirstValue * (1 - interpolationValue) + TimeTextInstanceWidthSecondValue * interpolationValue;
                }
                if (setTimeTextInstanceXFirstValue && setTimeTextInstanceXSecondValue)
                {
                    TimeTextInstance.X = TimeTextInstanceXFirstValue * (1 - interpolationValue) + TimeTextInstanceXSecondValue * interpolationValue;
                }
                if (setTimeTextInstanceYFirstValue && setTimeTextInstanceYSecondValue)
                {
                    TimeTextInstance.Y = TimeTextInstanceYFirstValue * (1 - interpolationValue) + TimeTextInstanceYSecondValue * interpolationValue;
                }
                if (setWaveLabelBlueFirstValue && setWaveLabelBlueSecondValue)
                {
                    WaveLabel.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(WaveLabelBlueFirstValue* (1 - interpolationValue) + WaveLabelBlueSecondValue * interpolationValue);
                }
                if (setWaveLabelGreenFirstValue && setWaveLabelGreenSecondValue)
                {
                    WaveLabel.Green = FlatRedBall.Math.MathFunctions.RoundToInt(WaveLabelGreenFirstValue* (1 - interpolationValue) + WaveLabelGreenSecondValue * interpolationValue);
                }
                if (setWaveLabelHeightFirstValue && setWaveLabelHeightSecondValue)
                {
                    WaveLabel.Height = WaveLabelHeightFirstValue * (1 - interpolationValue) + WaveLabelHeightSecondValue * interpolationValue;
                }
                if (setWaveLabelRedFirstValue && setWaveLabelRedSecondValue)
                {
                    WaveLabel.Red = FlatRedBall.Math.MathFunctions.RoundToInt(WaveLabelRedFirstValue* (1 - interpolationValue) + WaveLabelRedSecondValue * interpolationValue);
                }
                if (setWaveLabelWidthFirstValue && setWaveLabelWidthSecondValue)
                {
                    WaveLabel.Width = WaveLabelWidthFirstValue * (1 - interpolationValue) + WaveLabelWidthSecondValue * interpolationValue;
                }
                if (setWaveLabelXFirstValue && setWaveLabelXSecondValue)
                {
                    WaveLabel.X = WaveLabelXFirstValue * (1 - interpolationValue) + WaveLabelXSecondValue * interpolationValue;
                }
                if (setWaveLabelYFirstValue && setWaveLabelYSecondValue)
                {
                    WaveLabel.Y = WaveLabelYFirstValue * (1 - interpolationValue) + WaveLabelYSecondValue * interpolationValue;
                }
                if (setWaveTextInstanceHeightFirstValue && setWaveTextInstanceHeightSecondValue)
                {
                    WaveTextInstance.Height = WaveTextInstanceHeightFirstValue * (1 - interpolationValue) + WaveTextInstanceHeightSecondValue * interpolationValue;
                }
                if (setWaveTextInstanceWidthFirstValue && setWaveTextInstanceWidthSecondValue)
                {
                    WaveTextInstance.Width = WaveTextInstanceWidthFirstValue * (1 - interpolationValue) + WaveTextInstanceWidthSecondValue * interpolationValue;
                }
                if (setWaveTextInstanceXFirstValue && setWaveTextInstanceXSecondValue)
                {
                    WaveTextInstance.X = WaveTextInstanceXFirstValue * (1 - interpolationValue) + WaveTextInstanceXSecondValue * interpolationValue;
                }
                if (setWaveTextInstanceYFirstValue && setWaveTextInstanceYSecondValue)
                {
                    WaveTextInstance.Y = WaveTextInstanceYFirstValue * (1 - interpolationValue) + WaveTextInstanceYSecondValue * interpolationValue;
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
            public void InterpolateBetween (TimeDisplay firstState, TimeDisplay secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setTimeTextInstanceBlueFirstValue = false;
                bool setTimeTextInstanceBlueSecondValue = false;
                int TimeTextInstanceBlueFirstValue= 0;
                int TimeTextInstanceBlueSecondValue= 0;
                bool setTimeTextInstanceGreenFirstValue = false;
                bool setTimeTextInstanceGreenSecondValue = false;
                int TimeTextInstanceGreenFirstValue= 0;
                int TimeTextInstanceGreenSecondValue= 0;
                bool setTimeTextInstanceRedFirstValue = false;
                bool setTimeTextInstanceRedSecondValue = false;
                int TimeTextInstanceRedFirstValue= 0;
                int TimeTextInstanceRedSecondValue= 0;
                switch(firstState)
                {
                    case  TimeDisplay.TimeStart:
                        setTimeTextInstanceBlueFirstValue = true;
                        TimeTextInstanceBlueFirstValue = 169;
                        setTimeTextInstanceGreenFirstValue = true;
                        TimeTextInstanceGreenFirstValue = 169;
                        setTimeTextInstanceRedFirstValue = true;
                        TimeTextInstanceRedFirstValue = 169;
                        break;
                    case  TimeDisplay.TimeEnd:
                        setTimeTextInstanceBlueFirstValue = true;
                        TimeTextInstanceBlueFirstValue = 203;
                        setTimeTextInstanceGreenFirstValue = true;
                        TimeTextInstanceGreenFirstValue = 192;
                        setTimeTextInstanceRedFirstValue = true;
                        TimeTextInstanceRedFirstValue = 255;
                        break;
                    case  TimeDisplay.DefaultTime:
                        setTimeTextInstanceBlueFirstValue = true;
                        TimeTextInstanceBlueFirstValue = 255;
                        setTimeTextInstanceGreenFirstValue = true;
                        TimeTextInstanceGreenFirstValue = 255;
                        setTimeTextInstanceRedFirstValue = true;
                        TimeTextInstanceRedFirstValue = 255;
                        break;
                }
                switch(secondState)
                {
                    case  TimeDisplay.TimeStart:
                        setTimeTextInstanceBlueSecondValue = true;
                        TimeTextInstanceBlueSecondValue = 169;
                        setTimeTextInstanceGreenSecondValue = true;
                        TimeTextInstanceGreenSecondValue = 169;
                        setTimeTextInstanceRedSecondValue = true;
                        TimeTextInstanceRedSecondValue = 169;
                        break;
                    case  TimeDisplay.TimeEnd:
                        setTimeTextInstanceBlueSecondValue = true;
                        TimeTextInstanceBlueSecondValue = 203;
                        setTimeTextInstanceGreenSecondValue = true;
                        TimeTextInstanceGreenSecondValue = 192;
                        setTimeTextInstanceRedSecondValue = true;
                        TimeTextInstanceRedSecondValue = 255;
                        break;
                    case  TimeDisplay.DefaultTime:
                        setTimeTextInstanceBlueSecondValue = true;
                        TimeTextInstanceBlueSecondValue = 255;
                        setTimeTextInstanceGreenSecondValue = true;
                        TimeTextInstanceGreenSecondValue = 255;
                        setTimeTextInstanceRedSecondValue = true;
                        TimeTextInstanceRedSecondValue = 255;
                        break;
                }
                if (setTimeTextInstanceBlueFirstValue && setTimeTextInstanceBlueSecondValue)
                {
                    TimeTextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TimeTextInstanceBlueFirstValue* (1 - interpolationValue) + TimeTextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTimeTextInstanceGreenFirstValue && setTimeTextInstanceGreenSecondValue)
                {
                    TimeTextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TimeTextInstanceGreenFirstValue* (1 - interpolationValue) + TimeTextInstanceGreenSecondValue * interpolationValue);
                }
                if (setTimeTextInstanceRedFirstValue && setTimeTextInstanceRedSecondValue)
                {
                    TimeTextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TimeTextInstanceRedFirstValue* (1 - interpolationValue) + TimeTextInstanceRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentTimeDisplayState = firstState;
                }
                else
                {
                    mCurrentTimeDisplayState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TopStatusBarRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.TopStatusBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TopStatusBarRuntime.TimeDisplay fromState,AbbatoirIntergrade.GumRuntimes.TopStatusBarRuntime.TimeDisplay toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (TimeDisplay toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "TimeDisplay").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentTimeDisplayState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (TimeDisplay toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentTimeDisplayState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> PulseTimeAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentTimeDisplayState = TimeDisplay.TimeStart);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(TimeDisplay.TimeEnd, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, PulseTimeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(TimeDisplay.TimeStart, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, PulseTimeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => FlatRedBall.Instructions.InstructionManager.Instructions.AddRange(this.PulseTimeAnimationInstructions(target)));
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 2;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> PulseTimeAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "TimeDisplay/TimeStart").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "TimeDisplay/TimeEnd").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(TimeDisplay.TimeEnd);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "TimeDisplay/TimeEnd").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "TimeDisplay/TimeStart").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(TimeDisplay.TimeStart);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => FlatRedBall.Instructions.InstructionManager.Instructions.AddRange(this.PulseTimeAnimationRelativeInstructions(target)));
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 2;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation pulseTimeAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation PulseTimeAnimation
            {
                get
                {
                    if (pulseTimeAnimation == null)
                    {
                        pulseTimeAnimation = new FlatRedBall.Gum.Animation.GumAnimation(2, PulseTimeAnimationInstructions);
                    }
                    return pulseTimeAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation pulseTimeAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation PulseTimeAnimationRelative
            {
                get
                {
                    if (pulseTimeAnimationRelative == null)
                    {
                        pulseTimeAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(2, PulseTimeAnimationRelativeInstructions);
                    }
                    return pulseTimeAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                MenuButton.StopAnimations();
                PauseButton.StopAnimations();
                PlayButton.StopAnimations();
                FastForwardButton.StopAnimations();
                PulseTimeAnimation.Stop();
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
                            Name = "MenuButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = MenuButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuButton.Height",
                            Type = "float",
                            Value = MenuButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = MenuButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuButton.Parent",
                            Type = "string",
                            Value = MenuButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuButton.Width",
                            Type = "float",
                            Value = MenuButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = MenuButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.SourceFile",
                            Type = "string",
                            Value = SpriteInstance.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Address",
                            Type = "TextureAddress",
                            Value = SpriteInstance.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InfoContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Height",
                            Type = "float",
                            Value = InfoContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = InfoContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Width",
                            Type = "float",
                            Value = InfoContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = InfoContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.X",
                            Type = "float",
                            Value = InfoContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Blue",
                            Type = "int",
                            Value = WaveLabel.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.CustomFontFile",
                            Type = "string",
                            Value = WaveLabel.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Green",
                            Type = "int",
                            Value = WaveLabel.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Height",
                            Type = "float",
                            Value = WaveLabel.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = WaveLabel.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Parent",
                            Type = "string",
                            Value = WaveLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Red",
                            Type = "int",
                            Value = WaveLabel.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Text",
                            Type = "string",
                            Value = WaveLabel.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.UseCustomFont",
                            Type = "bool",
                            Value = WaveLabel.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = WaveLabel.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Width",
                            Type = "float",
                            Value = WaveLabel.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.X",
                            Type = "float",
                            Value = WaveLabel.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.X Units",
                            Type = "PositionUnitType",
                            Value = WaveLabel.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Y",
                            Type = "float",
                            Value = WaveLabel.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.CustomFontFile",
                            Type = "string",
                            Value = WaveTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.Height",
                            Type = "float",
                            Value = WaveTextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = WaveTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.Parent",
                            Type = "string",
                            Value = WaveTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.Text",
                            Type = "string",
                            Value = WaveTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = WaveTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = WaveTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.Width",
                            Type = "float",
                            Value = WaveTextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.X",
                            Type = "float",
                            Value = WaveTextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = WaveTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.Y",
                            Type = "float",
                            Value = WaveTextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Blue",
                            Type = "int",
                            Value = TimeLabel.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.CustomFontFile",
                            Type = "string",
                            Value = TimeLabel.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Font Scale",
                            Type = "float",
                            Value = TimeLabel.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Green",
                            Type = "int",
                            Value = TimeLabel.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Height",
                            Type = "float",
                            Value = TimeLabel.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Height Units",
                            Type = "DimensionUnitType",
                            Value = TimeLabel.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TimeLabel.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Parent",
                            Type = "string",
                            Value = TimeLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Red",
                            Type = "int",
                            Value = TimeLabel.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Text",
                            Type = "string",
                            Value = TimeLabel.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.UseCustomFont",
                            Type = "bool",
                            Value = TimeLabel.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TimeLabel.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Width",
                            Type = "float",
                            Value = TimeLabel.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.X",
                            Type = "float",
                            Value = TimeLabel.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TimeLabel.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.X Units",
                            Type = "PositionUnitType",
                            Value = TimeLabel.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Y",
                            Type = "float",
                            Value = TimeLabel.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TimeLabel.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Y Units",
                            Type = "PositionUnitType",
                            Value = TimeLabel.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Blue",
                            Type = "int",
                            Value = TimeTextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.CustomFontFile",
                            Type = "string",
                            Value = TimeTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Font Scale",
                            Type = "float",
                            Value = TimeTextInstance.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Green",
                            Type = "int",
                            Value = TimeTextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Height",
                            Type = "float",
                            Value = TimeTextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TimeTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TimeTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Parent",
                            Type = "string",
                            Value = TimeTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Red",
                            Type = "int",
                            Value = TimeTextInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Text",
                            Type = "string",
                            Value = TimeTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = TimeTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TimeTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Width",
                            Type = "float",
                            Value = TimeTextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.X",
                            Type = "float",
                            Value = TimeTextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TimeTextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TimeTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Y",
                            Type = "float",
                            Value = TimeTextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TimeTextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TimeTextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = PauseButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Height",
                            Type = "float",
                            Value = PauseButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = PauseButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Parent",
                            Type = "string",
                            Value = PauseButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Width",
                            Type = "float",
                            Value = PauseButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = PauseButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.X",
                            Type = "float",
                            Value = PauseButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Y",
                            Type = "float",
                            Value = PauseButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = PlayButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Height",
                            Type = "float",
                            Value = PlayButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = PlayButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.HighlightState",
                            Type = "HighlightState",
                            Value = PlayButton.CurrentHighlightState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Parent",
                            Type = "string",
                            Value = PlayButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.SelectState",
                            Type = "SelectState",
                            Value = PlayButton.CurrentSelectState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Width",
                            Type = "float",
                            Value = PlayButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = PlayButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.X",
                            Type = "float",
                            Value = PlayButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Y",
                            Type = "float",
                            Value = PlayButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = FastForwardButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Height",
                            Type = "float",
                            Value = FastForwardButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = FastForwardButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Parent",
                            Type = "string",
                            Value = FastForwardButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Width",
                            Type = "float",
                            Value = FastForwardButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = FastForwardButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.X",
                            Type = "float",
                            Value = FastForwardButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Y",
                            Type = "float",
                            Value = FastForwardButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = TimeButtonContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Height",
                            Type = "float",
                            Value = TimeButtonContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = TimeButtonContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Parent",
                            Type = "string",
                            Value = TimeButtonContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Width",
                            Type = "float",
                            Value = TimeButtonContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = TimeButtonContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.X",
                            Type = "float",
                            Value = TimeButtonContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TimeButtonContainer.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.X Units",
                            Type = "PositionUnitType",
                            Value = TimeButtonContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Y",
                            Type = "float",
                            Value = TimeButtonContainer.Y
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
                            Value = Height + 0f
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
                            Value = Width + 0f
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
                            Name = "MenuButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = MenuButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuButton.Height",
                            Type = "float",
                            Value = MenuButton.Height + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = MenuButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuButton.Parent",
                            Type = "string",
                            Value = MenuButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuButton.Width",
                            Type = "float",
                            Value = MenuButton.Width + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = MenuButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.SourceFile",
                            Type = "string",
                            Value = SpriteInstance.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Address",
                            Type = "TextureAddress",
                            Value = SpriteInstance.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 70
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 3840
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 1320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InfoContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Height",
                            Type = "float",
                            Value = InfoContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = InfoContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Width",
                            Type = "float",
                            Value = InfoContainer.Width + 1245f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = InfoContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.X",
                            Type = "float",
                            Value = InfoContainer.X + 35f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Blue",
                            Type = "int",
                            Value = WaveLabel.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.CustomFontFile",
                            Type = "string",
                            Value = WaveLabel.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Green",
                            Type = "int",
                            Value = WaveLabel.Green + 191
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Height",
                            Type = "float",
                            Value = WaveLabel.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = WaveLabel.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Parent",
                            Type = "string",
                            Value = WaveLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Red",
                            Type = "int",
                            Value = WaveLabel.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Text",
                            Type = "string",
                            Value = WaveLabel.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.UseCustomFont",
                            Type = "bool",
                            Value = WaveLabel.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = WaveLabel.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Width",
                            Type = "float",
                            Value = WaveLabel.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.X",
                            Type = "float",
                            Value = WaveLabel.X + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.X Units",
                            Type = "PositionUnitType",
                            Value = WaveLabel.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveLabel.Y",
                            Type = "float",
                            Value = WaveLabel.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.CustomFontFile",
                            Type = "string",
                            Value = WaveTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.Height",
                            Type = "float",
                            Value = WaveTextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = WaveTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.Parent",
                            Type = "string",
                            Value = WaveTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.Text",
                            Type = "string",
                            Value = WaveTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = WaveTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = WaveTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.Width",
                            Type = "float",
                            Value = WaveTextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.X",
                            Type = "float",
                            Value = WaveTextInstance.X + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = WaveTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.Y",
                            Type = "float",
                            Value = WaveTextInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Blue",
                            Type = "int",
                            Value = TimeLabel.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.CustomFontFile",
                            Type = "string",
                            Value = TimeLabel.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Font Scale",
                            Type = "float",
                            Value = TimeLabel.FontScale + 0.7f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Green",
                            Type = "int",
                            Value = TimeLabel.Green + 191
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Height",
                            Type = "float",
                            Value = TimeLabel.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Height Units",
                            Type = "DimensionUnitType",
                            Value = TimeLabel.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TimeLabel.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Parent",
                            Type = "string",
                            Value = TimeLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Red",
                            Type = "int",
                            Value = TimeLabel.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Text",
                            Type = "string",
                            Value = TimeLabel.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.UseCustomFont",
                            Type = "bool",
                            Value = TimeLabel.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TimeLabel.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Width",
                            Type = "float",
                            Value = TimeLabel.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.X",
                            Type = "float",
                            Value = TimeLabel.X + -500f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TimeLabel.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.X Units",
                            Type = "PositionUnitType",
                            Value = TimeLabel.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Y",
                            Type = "float",
                            Value = TimeLabel.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TimeLabel.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeLabel.Y Units",
                            Type = "PositionUnitType",
                            Value = TimeLabel.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Blue",
                            Type = "int",
                            Value = TimeTextInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.CustomFontFile",
                            Type = "string",
                            Value = TimeTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Font Scale",
                            Type = "float",
                            Value = TimeTextInstance.FontScale + 0.7f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Green",
                            Type = "int",
                            Value = TimeTextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Height",
                            Type = "float",
                            Value = TimeTextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TimeTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TimeTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Parent",
                            Type = "string",
                            Value = TimeTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Red",
                            Type = "int",
                            Value = TimeTextInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Text",
                            Type = "string",
                            Value = TimeTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = TimeTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TimeTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Width",
                            Type = "float",
                            Value = TimeTextInstance.Width + 200f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.X",
                            Type = "float",
                            Value = TimeTextInstance.X + -300f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TimeTextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TimeTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Y",
                            Type = "float",
                            Value = TimeTextInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TimeTextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TimeTextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = PauseButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Height",
                            Type = "float",
                            Value = PauseButton.Height + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = PauseButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Parent",
                            Type = "string",
                            Value = PauseButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Width",
                            Type = "float",
                            Value = PauseButton.Width + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = PauseButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.X",
                            Type = "float",
                            Value = PauseButton.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PauseButton.Y",
                            Type = "float",
                            Value = PauseButton.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = PlayButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Height",
                            Type = "float",
                            Value = PlayButton.Height + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = PlayButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.HighlightState",
                            Type = "HighlightState",
                            Value = PlayButton.CurrentHighlightState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Parent",
                            Type = "string",
                            Value = PlayButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.SelectState",
                            Type = "SelectState",
                            Value = PlayButton.CurrentSelectState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Width",
                            Type = "float",
                            Value = PlayButton.Width + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = PlayButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.X",
                            Type = "float",
                            Value = PlayButton.X + 15f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButton.Y",
                            Type = "float",
                            Value = PlayButton.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = FastForwardButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Height",
                            Type = "float",
                            Value = FastForwardButton.Height + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = FastForwardButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Parent",
                            Type = "string",
                            Value = FastForwardButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Width",
                            Type = "float",
                            Value = FastForwardButton.Width + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = FastForwardButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.X",
                            Type = "float",
                            Value = FastForwardButton.X + 15f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FastForwardButton.Y",
                            Type = "float",
                            Value = FastForwardButton.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = TimeButtonContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Height",
                            Type = "float",
                            Value = TimeButtonContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = TimeButtonContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Parent",
                            Type = "string",
                            Value = TimeButtonContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Width",
                            Type = "float",
                            Value = TimeButtonContainer.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = TimeButtonContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.X",
                            Type = "float",
                            Value = TimeButtonContainer.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TimeButtonContainer.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.X Units",
                            Type = "PositionUnitType",
                            Value = TimeButtonContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeButtonContainer.Y",
                            Type = "float",
                            Value = TimeButtonContainer.Y + 0f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (TimeDisplay state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  TimeDisplay.TimeStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Blue",
                            Type = "int",
                            Value = TimeTextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Green",
                            Type = "int",
                            Value = TimeTextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Red",
                            Type = "int",
                            Value = TimeTextInstance.Red
                        }
                        );
                        break;
                    case  TimeDisplay.TimeEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Blue",
                            Type = "int",
                            Value = TimeTextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Green",
                            Type = "int",
                            Value = TimeTextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Red",
                            Type = "int",
                            Value = TimeTextInstance.Red
                        }
                        );
                        break;
                    case  TimeDisplay.DefaultTime:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Blue",
                            Type = "int",
                            Value = TimeTextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Green",
                            Type = "int",
                            Value = TimeTextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Red",
                            Type = "int",
                            Value = TimeTextInstance.Red
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (TimeDisplay state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  TimeDisplay.TimeStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Blue",
                            Type = "int",
                            Value = TimeTextInstance.Blue + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Green",
                            Type = "int",
                            Value = TimeTextInstance.Green + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Red",
                            Type = "int",
                            Value = TimeTextInstance.Red + 169
                        }
                        );
                        break;
                    case  TimeDisplay.TimeEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Blue",
                            Type = "int",
                            Value = TimeTextInstance.Blue + 203
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Green",
                            Type = "int",
                            Value = TimeTextInstance.Green + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Red",
                            Type = "int",
                            Value = TimeTextInstance.Red + 255
                        }
                        );
                        break;
                    case  TimeDisplay.DefaultTime:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Blue",
                            Type = "int",
                            Value = TimeTextInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Green",
                            Type = "int",
                            Value = TimeTextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.Red",
                            Type = "int",
                            Value = TimeTextInstance.Red + 255
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
                    else if (category.Name == "TimeDisplay")
                    {
                        if(state.Name == "TimeStart") this.mCurrentTimeDisplayState = TimeDisplay.TimeStart;
                        if(state.Name == "TimeEnd") this.mCurrentTimeDisplayState = TimeDisplay.TimeEnd;
                        if(state.Name == "DefaultTime") this.mCurrentTimeDisplayState = TimeDisplay.DefaultTime;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime MenuButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime InfoContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime WaveLabel { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime WaveTextInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TimeLabel { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TimeTextInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime PauseButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime PlayButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime FastForwardButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime TimeButtonContainer { get; set; }
            public TopStatusBarRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "InfoDisplays/TopStatusBar");
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
                MenuButton = this.GetGraphicalUiElementByName("MenuButton") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                InfoContainer = this.GetGraphicalUiElementByName("InfoContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                WaveLabel = this.GetGraphicalUiElementByName("WaveLabel") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                WaveTextInstance = this.GetGraphicalUiElementByName("WaveTextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                TimeLabel = this.GetGraphicalUiElementByName("TimeLabel") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                TimeTextInstance = this.GetGraphicalUiElementByName("TimeTextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                PauseButton = this.GetGraphicalUiElementByName("PauseButton") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                PlayButton = this.GetGraphicalUiElementByName("PlayButton") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                FastForwardButton = this.GetGraphicalUiElementByName("FastForwardButton") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                TimeButtonContainer = this.GetGraphicalUiElementByName("TimeButtonContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
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
