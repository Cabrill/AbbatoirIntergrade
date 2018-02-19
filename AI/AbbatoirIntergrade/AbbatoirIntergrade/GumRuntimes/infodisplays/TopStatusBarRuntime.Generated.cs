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
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
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
                            InfoContainer.Width = 0f;
                            InfoContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            InfoContainer.X = 35f;
                            SetProperty("WaveTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            WaveTextInstance.Height = 0f;
                            WaveTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            WaveTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            WaveTextInstance.Text = "Wave 0";
                            WaveTextInstance.UseCustomFont = true;
                            WaveTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            WaveTextInstance.Width = 300f;
                            WaveTextInstance.X = 200f;
                            WaveTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            WaveTextInstance.Y = 0f;
                            SetProperty("TimeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            TimeTextInstance.FontScale = 0.7f;
                            TimeTextInstance.Height = 0f;
                            TimeTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            TimeTextInstance.Text = "Time: 00:00.00";
                            TimeTextInstance.UseCustomFont = true;
                            TimeTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TimeTextInstance.Width = 450f;
                            TimeTextInstance.X = 80f;
                            TimeTextInstance.Y = 0f;
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
                            TimeButtonContainer.X = -75f;
                            TimeButtonContainer.Y = 0f;
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
                bool setTimeTextInstanceFontScaleFirstValue = false;
                bool setTimeTextInstanceFontScaleSecondValue = false;
                float TimeTextInstanceFontScaleFirstValue= 0;
                float TimeTextInstanceFontScaleSecondValue= 0;
                bool setTimeTextInstanceHeightFirstValue = false;
                bool setTimeTextInstanceHeightSecondValue = false;
                float TimeTextInstanceHeightFirstValue= 0;
                float TimeTextInstanceHeightSecondValue= 0;
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
                        InfoContainerWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InfoContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
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
                        TimeButtonContainerXFirstValue = -75f;
                        setTimeButtonContainerYFirstValue = true;
                        TimeButtonContainerYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("TimeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTimeTextInstanceFontScaleFirstValue = true;
                        TimeTextInstanceFontScaleFirstValue = 0.7f;
                        setTimeTextInstanceHeightFirstValue = true;
                        TimeTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimeTextInstance.Text = "Time: 00:00.00";
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
                        TimeTextInstanceWidthFirstValue = 450f;
                        setTimeTextInstanceXFirstValue = true;
                        TimeTextInstanceXFirstValue = 80f;
                        setTimeTextInstanceYFirstValue = true;
                        TimeTextInstanceYFirstValue = 0f;
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
                            this.WaveTextInstance.Text = "Wave 0";
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
                        WaveTextInstanceWidthFirstValue = 300f;
                        setWaveTextInstanceXFirstValue = true;
                        WaveTextInstanceXFirstValue = 200f;
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
                        InfoContainerWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InfoContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
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
                        TimeButtonContainerXSecondValue = -75f;
                        setTimeButtonContainerYSecondValue = true;
                        TimeButtonContainerYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TimeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTimeTextInstanceFontScaleSecondValue = true;
                        TimeTextInstanceFontScaleSecondValue = 0.7f;
                        setTimeTextInstanceHeightSecondValue = true;
                        TimeTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimeTextInstance.Text = "Time: 00:00.00";
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
                        TimeTextInstanceWidthSecondValue = 450f;
                        setTimeTextInstanceXSecondValue = true;
                        TimeTextInstanceXSecondValue = 80f;
                        setTimeTextInstanceYSecondValue = true;
                        TimeTextInstanceYSecondValue = 0f;
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
                            this.WaveTextInstance.Text = "Wave 0";
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
                        WaveTextInstanceWidthSecondValue = 300f;
                        setWaveTextInstanceXSecondValue = true;
                        WaveTextInstanceXSecondValue = 200f;
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
                if (setTimeTextInstanceFontScaleFirstValue && setTimeTextInstanceFontScaleSecondValue)
                {
                    TimeTextInstance.FontScale = TimeTextInstanceFontScaleFirstValue * (1 - interpolationValue) + TimeTextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setTimeTextInstanceHeightFirstValue && setTimeTextInstanceHeightSecondValue)
                {
                    TimeTextInstance.Height = TimeTextInstanceHeightFirstValue * (1 - interpolationValue) + TimeTextInstanceHeightSecondValue * interpolationValue;
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
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                MenuButton.StopAnimations();
                PauseButton.StopAnimations();
                PlayButton.StopAnimations();
                FastForwardButton.StopAnimations();
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
                            Name = "TimeTextInstance.Height",
                            Type = "float",
                            Value = TimeTextInstance.Height
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
                            Name = "TimeTextInstance.Y",
                            Type = "float",
                            Value = TimeTextInstance.Y
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
                            Value = InfoContainer.Width + 0f
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
                            Value = WaveTextInstance.Width + 300f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaveTextInstance.X",
                            Type = "float",
                            Value = WaveTextInstance.X + 200f
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
                            Name = "TimeTextInstance.Height",
                            Type = "float",
                            Value = TimeTextInstance.Height + 0f
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
                            Value = TimeTextInstance.Width + 450f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimeTextInstance.X",
                            Type = "float",
                            Value = TimeTextInstance.X + 80f
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
                            Value = TimeButtonContainer.X + -75f
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
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime MenuButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime InfoContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime WaveTextInstance { get; set; }
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
                WaveTextInstance = this.GetGraphicalUiElementByName("WaveTextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
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
