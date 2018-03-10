    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class LevelButtonRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum ButtonCategory
            {
                Enabled,
                Disabled,
                Highlighted,
                Pushed
            }
            public enum LevelNumber
            {
                Level1,
                Level2,
                Level3,
                Level4,
                Level5,
                Level6,
                Level7,
                Level8,
                Level9,
                Level10
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ButtonCategory mCurrentButtonCategoryState;
            LevelNumber mCurrentLevelNumberState;
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
                            FrameSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("FrameSprite.SourceFile", "AllUIAssets.png");
                            FrameSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            FrameSprite.TextureHeight = 263;
                            FrameSprite.TextureLeft = 0;
                            FrameSprite.TextureTop = 2306;
                            FrameSprite.TextureWidth = 250;
                            FrameSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            HighlightSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("HighlightSprite.SourceFile", "AllUIAssets.png");
                            HighlightSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            HighlightSprite.TextureHeight = 156;
                            HighlightSprite.TextureLeft = 2435;
                            HighlightSprite.TextureTop = 601;
                            HighlightSprite.TextureWidth = 156;
                            HighlightSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            HighlightSprite.X = 0f;
                            HighlightSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            HighlightSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            HighlightSprite.Y = 0f;
                            HighlightSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            HighlightSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NumberSprite.Height = 50f;
                            NumberSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("NumberSprite.SourceFile", "AllUIAssets.png");
                            NumberSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 105;
                            NumberSprite.TextureTop = 2055;
                            NumberSprite.TextureWidth = 37;
                            NumberSprite.Width = 20f;
                            NumberSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NumberSprite.X = 50f;
                            NumberSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            NumberSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            NumberSprite.Y = 50f;
                            NumberSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            NumberSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            break;
                    }
                }
            }
            public ButtonCategory CurrentButtonCategoryState
            {
                get
                {
                    return mCurrentButtonCategoryState;
                }
                set
                {
                    mCurrentButtonCategoryState = value;
                    switch(mCurrentButtonCategoryState)
                    {
                        case  ButtonCategory.Enabled:
                            FrameSprite.TextureLeft = 0;
                            HighlightSprite.Blue = 255;
                            HighlightSprite.Red = 255;
                            HighlightSprite.Visible = false;
                            NumberSprite.Blue = 255;
                            NumberSprite.Green = 255;
                            NumberSprite.Red = 255;
                            NumberSprite.Visible = true;
                            break;
                        case  ButtonCategory.Disabled:
                            FrameSprite.TextureLeft = 256;
                            HighlightSprite.Blue = 255;
                            HighlightSprite.Red = 255;
                            HighlightSprite.Visible = false;
                            NumberSprite.Blue = 255;
                            NumberSprite.Green = 255;
                            NumberSprite.Red = 255;
                            NumberSprite.Visible = false;
                            break;
                        case  ButtonCategory.Highlighted:
                            FrameSprite.TextureLeft = 0;
                            HighlightSprite.Blue = 255;
                            HighlightSprite.Red = 255;
                            HighlightSprite.Visible = true;
                            NumberSprite.Blue = 255;
                            NumberSprite.Green = 255;
                            NumberSprite.Red = 255;
                            NumberSprite.Visible = true;
                            break;
                        case  ButtonCategory.Pushed:
                            FrameSprite.TextureLeft = 0;
                            HighlightSprite.Blue = 50;
                            HighlightSprite.Red = 50;
                            HighlightSprite.Visible = true;
                            NumberSprite.Blue = 0;
                            NumberSprite.Green = 255;
                            NumberSprite.Red = 50;
                            NumberSprite.Visible = true;
                            break;
                    }
                }
            }
            public LevelNumber CurrentLevelNumberState
            {
                get
                {
                    return mCurrentLevelNumberState;
                }
                set
                {
                    mCurrentLevelNumberState = value;
                    switch(mCurrentLevelNumberState)
                    {
                        case  LevelNumber.Level1:
                            NumberSprite.FlipHorizontal = false;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 100;
                            NumberSprite.TextureTop = 2055;
                            NumberSprite.TextureWidth = 40;
                            NumberSprite.Width = 20f;
                            break;
                        case  LevelNumber.Level2:
                            NumberSprite.FlipHorizontal = false;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 162;
                            NumberSprite.TextureTop = 2055;
                            NumberSprite.TextureWidth = 100;
                            NumberSprite.Width = 35f;
                            break;
                        case  LevelNumber.Level3:
                            NumberSprite.FlipHorizontal = false;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 260;
                            NumberSprite.TextureTop = 2055;
                            NumberSprite.TextureWidth = 85;
                            NumberSprite.Width = 35f;
                            break;
                        case  LevelNumber.Level4:
                            NumberSprite.FlipHorizontal = false;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 355;
                            NumberSprite.TextureTop = 2055;
                            NumberSprite.TextureWidth = 90;
                            NumberSprite.Width = 35f;
                            break;
                        case  LevelNumber.Level5:
                            NumberSprite.FlipHorizontal = false;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 0;
                            NumberSprite.TextureTop = 2180;
                            NumberSprite.TextureWidth = 95;
                            NumberSprite.Width = 35f;
                            break;
                        case  LevelNumber.Level6:
                            NumberSprite.FlipHorizontal = false;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 100;
                            NumberSprite.TextureTop = 2180;
                            NumberSprite.TextureWidth = 95;
                            NumberSprite.Width = 35f;
                            break;
                        case  LevelNumber.Level7:
                            NumberSprite.FlipHorizontal = false;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 190;
                            NumberSprite.TextureTop = 2180;
                            NumberSprite.TextureWidth = 95;
                            NumberSprite.Width = 35f;
                            break;
                        case  LevelNumber.Level8:
                            NumberSprite.FlipHorizontal = false;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 290;
                            NumberSprite.TextureTop = 2180;
                            NumberSprite.TextureWidth = 95;
                            NumberSprite.Width = 35f;
                            break;
                        case  LevelNumber.Level9:
                            NumberSprite.FlipHorizontal = false;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 385;
                            NumberSprite.TextureTop = 2180;
                            NumberSprite.TextureWidth = 95;
                            NumberSprite.Width = 35f;
                            break;
                        case  LevelNumber.Level10:
                            NumberSprite.FlipHorizontal = true;
                            NumberSprite.TextureHeight = 116;
                            NumberSprite.TextureLeft = 0;
                            NumberSprite.TextureTop = 2055;
                            NumberSprite.TextureWidth = 150;
                            NumberSprite.Width = 50f;
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
                bool setFrameSpriteTextureHeightFirstValue = false;
                bool setFrameSpriteTextureHeightSecondValue = false;
                int FrameSpriteTextureHeightFirstValue= 0;
                int FrameSpriteTextureHeightSecondValue= 0;
                bool setFrameSpriteTextureLeftFirstValue = false;
                bool setFrameSpriteTextureLeftSecondValue = false;
                int FrameSpriteTextureLeftFirstValue= 0;
                int FrameSpriteTextureLeftSecondValue= 0;
                bool setFrameSpriteTextureTopFirstValue = false;
                bool setFrameSpriteTextureTopSecondValue = false;
                int FrameSpriteTextureTopFirstValue= 0;
                int FrameSpriteTextureTopSecondValue= 0;
                bool setFrameSpriteTextureWidthFirstValue = false;
                bool setFrameSpriteTextureWidthSecondValue = false;
                int FrameSpriteTextureWidthFirstValue= 0;
                int FrameSpriteTextureWidthSecondValue= 0;
                bool setHighlightSpriteTextureHeightFirstValue = false;
                bool setHighlightSpriteTextureHeightSecondValue = false;
                int HighlightSpriteTextureHeightFirstValue= 0;
                int HighlightSpriteTextureHeightSecondValue= 0;
                bool setHighlightSpriteTextureLeftFirstValue = false;
                bool setHighlightSpriteTextureLeftSecondValue = false;
                int HighlightSpriteTextureLeftFirstValue= 0;
                int HighlightSpriteTextureLeftSecondValue= 0;
                bool setHighlightSpriteTextureTopFirstValue = false;
                bool setHighlightSpriteTextureTopSecondValue = false;
                int HighlightSpriteTextureTopFirstValue= 0;
                int HighlightSpriteTextureTopSecondValue= 0;
                bool setHighlightSpriteTextureWidthFirstValue = false;
                bool setHighlightSpriteTextureWidthSecondValue = false;
                int HighlightSpriteTextureWidthFirstValue= 0;
                int HighlightSpriteTextureWidthSecondValue= 0;
                bool setHighlightSpriteXFirstValue = false;
                bool setHighlightSpriteXSecondValue = false;
                float HighlightSpriteXFirstValue= 0;
                float HighlightSpriteXSecondValue= 0;
                bool setHighlightSpriteYFirstValue = false;
                bool setHighlightSpriteYSecondValue = false;
                float HighlightSpriteYFirstValue= 0;
                float HighlightSpriteYSecondValue= 0;
                bool setNumberSpriteHeightFirstValue = false;
                bool setNumberSpriteHeightSecondValue = false;
                float NumberSpriteHeightFirstValue= 0;
                float NumberSpriteHeightSecondValue= 0;
                bool setNumberSpriteTextureHeightFirstValue = false;
                bool setNumberSpriteTextureHeightSecondValue = false;
                int NumberSpriteTextureHeightFirstValue= 0;
                int NumberSpriteTextureHeightSecondValue= 0;
                bool setNumberSpriteTextureLeftFirstValue = false;
                bool setNumberSpriteTextureLeftSecondValue = false;
                int NumberSpriteTextureLeftFirstValue= 0;
                int NumberSpriteTextureLeftSecondValue= 0;
                bool setNumberSpriteTextureTopFirstValue = false;
                bool setNumberSpriteTextureTopSecondValue = false;
                int NumberSpriteTextureTopFirstValue= 0;
                int NumberSpriteTextureTopSecondValue= 0;
                bool setNumberSpriteTextureWidthFirstValue = false;
                bool setNumberSpriteTextureWidthSecondValue = false;
                int NumberSpriteTextureWidthFirstValue= 0;
                int NumberSpriteTextureWidthSecondValue= 0;
                bool setNumberSpriteWidthFirstValue = false;
                bool setNumberSpriteWidthSecondValue = false;
                float NumberSpriteWidthFirstValue= 0;
                float NumberSpriteWidthSecondValue= 0;
                bool setNumberSpriteXFirstValue = false;
                bool setNumberSpriteXSecondValue = false;
                float NumberSpriteXFirstValue= 0;
                float NumberSpriteXSecondValue= 0;
                bool setNumberSpriteYFirstValue = false;
                bool setNumberSpriteYSecondValue = false;
                float NumberSpriteYFirstValue= 0;
                float NumberSpriteYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.FrameSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("FrameSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.FrameSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setFrameSpriteTextureHeightFirstValue = true;
                        FrameSpriteTextureHeightFirstValue = 263;
                        setFrameSpriteTextureLeftFirstValue = true;
                        FrameSpriteTextureLeftFirstValue = 0;
                        setFrameSpriteTextureTopFirstValue = true;
                        FrameSpriteTextureTopFirstValue = 2306;
                        setFrameSpriteTextureWidthFirstValue = true;
                        FrameSpriteTextureWidthFirstValue = 250;
                        if (interpolationValue < 1)
                        {
                            this.FrameSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("HighlightSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setHighlightSpriteTextureHeightFirstValue = true;
                        HighlightSpriteTextureHeightFirstValue = 156;
                        setHighlightSpriteTextureLeftFirstValue = true;
                        HighlightSpriteTextureLeftFirstValue = 2435;
                        setHighlightSpriteTextureTopFirstValue = true;
                        HighlightSpriteTextureTopFirstValue = 601;
                        setHighlightSpriteTextureWidthFirstValue = true;
                        HighlightSpriteTextureWidthFirstValue = 156;
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHighlightSpriteXFirstValue = true;
                        HighlightSpriteXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHighlightSpriteYFirstValue = true;
                        HighlightSpriteYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNumberSpriteHeightFirstValue = true;
                        NumberSpriteHeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("NumberSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 105;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2055;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 37;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNumberSpriteXFirstValue = true;
                        NumberSpriteXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setNumberSpriteYFirstValue = true;
                        NumberSpriteYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.FrameSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("FrameSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FrameSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setFrameSpriteTextureHeightSecondValue = true;
                        FrameSpriteTextureHeightSecondValue = 263;
                        setFrameSpriteTextureLeftSecondValue = true;
                        FrameSpriteTextureLeftSecondValue = 0;
                        setFrameSpriteTextureTopSecondValue = true;
                        FrameSpriteTextureTopSecondValue = 2306;
                        setFrameSpriteTextureWidthSecondValue = true;
                        FrameSpriteTextureWidthSecondValue = 250;
                        if (interpolationValue >= 1)
                        {
                            this.FrameSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("HighlightSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setHighlightSpriteTextureHeightSecondValue = true;
                        HighlightSpriteTextureHeightSecondValue = 156;
                        setHighlightSpriteTextureLeftSecondValue = true;
                        HighlightSpriteTextureLeftSecondValue = 2435;
                        setHighlightSpriteTextureTopSecondValue = true;
                        HighlightSpriteTextureTopSecondValue = 601;
                        setHighlightSpriteTextureWidthSecondValue = true;
                        HighlightSpriteTextureWidthSecondValue = 156;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHighlightSpriteXSecondValue = true;
                        HighlightSpriteXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHighlightSpriteYSecondValue = true;
                        HighlightSpriteYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNumberSpriteHeightSecondValue = true;
                        NumberSpriteHeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("NumberSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 105;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2055;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 37;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNumberSpriteXSecondValue = true;
                        NumberSpriteXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setNumberSpriteYSecondValue = true;
                        NumberSpriteYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        break;
                }
                if (setFrameSpriteTextureHeightFirstValue && setFrameSpriteTextureHeightSecondValue)
                {
                    FrameSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(FrameSpriteTextureHeightFirstValue* (1 - interpolationValue) + FrameSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setFrameSpriteTextureLeftFirstValue && setFrameSpriteTextureLeftSecondValue)
                {
                    FrameSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(FrameSpriteTextureLeftFirstValue* (1 - interpolationValue) + FrameSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setFrameSpriteTextureTopFirstValue && setFrameSpriteTextureTopSecondValue)
                {
                    FrameSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(FrameSpriteTextureTopFirstValue* (1 - interpolationValue) + FrameSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setFrameSpriteTextureWidthFirstValue && setFrameSpriteTextureWidthSecondValue)
                {
                    FrameSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(FrameSpriteTextureWidthFirstValue* (1 - interpolationValue) + FrameSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setHighlightSpriteTextureHeightFirstValue && setHighlightSpriteTextureHeightSecondValue)
                {
                    HighlightSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightSpriteTextureHeightFirstValue* (1 - interpolationValue) + HighlightSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setHighlightSpriteTextureLeftFirstValue && setHighlightSpriteTextureLeftSecondValue)
                {
                    HighlightSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightSpriteTextureLeftFirstValue* (1 - interpolationValue) + HighlightSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setHighlightSpriteTextureTopFirstValue && setHighlightSpriteTextureTopSecondValue)
                {
                    HighlightSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightSpriteTextureTopFirstValue* (1 - interpolationValue) + HighlightSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setHighlightSpriteTextureWidthFirstValue && setHighlightSpriteTextureWidthSecondValue)
                {
                    HighlightSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightSpriteTextureWidthFirstValue* (1 - interpolationValue) + HighlightSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setHighlightSpriteXFirstValue && setHighlightSpriteXSecondValue)
                {
                    HighlightSprite.X = HighlightSpriteXFirstValue * (1 - interpolationValue) + HighlightSpriteXSecondValue * interpolationValue;
                }
                if (setHighlightSpriteYFirstValue && setHighlightSpriteYSecondValue)
                {
                    HighlightSprite.Y = HighlightSpriteYFirstValue * (1 - interpolationValue) + HighlightSpriteYSecondValue * interpolationValue;
                }
                if (setNumberSpriteHeightFirstValue && setNumberSpriteHeightSecondValue)
                {
                    NumberSprite.Height = NumberSpriteHeightFirstValue * (1 - interpolationValue) + NumberSpriteHeightSecondValue * interpolationValue;
                }
                if (setNumberSpriteTextureHeightFirstValue && setNumberSpriteTextureHeightSecondValue)
                {
                    NumberSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteTextureHeightFirstValue* (1 - interpolationValue) + NumberSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setNumberSpriteTextureLeftFirstValue && setNumberSpriteTextureLeftSecondValue)
                {
                    NumberSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteTextureLeftFirstValue* (1 - interpolationValue) + NumberSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setNumberSpriteTextureTopFirstValue && setNumberSpriteTextureTopSecondValue)
                {
                    NumberSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteTextureTopFirstValue* (1 - interpolationValue) + NumberSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setNumberSpriteTextureWidthFirstValue && setNumberSpriteTextureWidthSecondValue)
                {
                    NumberSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteTextureWidthFirstValue* (1 - interpolationValue) + NumberSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setNumberSpriteWidthFirstValue && setNumberSpriteWidthSecondValue)
                {
                    NumberSprite.Width = NumberSpriteWidthFirstValue * (1 - interpolationValue) + NumberSpriteWidthSecondValue * interpolationValue;
                }
                if (setNumberSpriteXFirstValue && setNumberSpriteXSecondValue)
                {
                    NumberSprite.X = NumberSpriteXFirstValue * (1 - interpolationValue) + NumberSpriteXSecondValue * interpolationValue;
                }
                if (setNumberSpriteYFirstValue && setNumberSpriteYSecondValue)
                {
                    NumberSprite.Y = NumberSpriteYFirstValue * (1 - interpolationValue) + NumberSpriteYSecondValue * interpolationValue;
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
            public void InterpolateBetween (ButtonCategory firstState, ButtonCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setFrameSpriteTextureLeftFirstValue = false;
                bool setFrameSpriteTextureLeftSecondValue = false;
                int FrameSpriteTextureLeftFirstValue= 0;
                int FrameSpriteTextureLeftSecondValue= 0;
                bool setHighlightSpriteBlueFirstValue = false;
                bool setHighlightSpriteBlueSecondValue = false;
                int HighlightSpriteBlueFirstValue= 0;
                int HighlightSpriteBlueSecondValue= 0;
                bool setHighlightSpriteRedFirstValue = false;
                bool setHighlightSpriteRedSecondValue = false;
                int HighlightSpriteRedFirstValue= 0;
                int HighlightSpriteRedSecondValue= 0;
                bool setNumberSpriteBlueFirstValue = false;
                bool setNumberSpriteBlueSecondValue = false;
                int NumberSpriteBlueFirstValue= 0;
                int NumberSpriteBlueSecondValue= 0;
                bool setNumberSpriteGreenFirstValue = false;
                bool setNumberSpriteGreenSecondValue = false;
                int NumberSpriteGreenFirstValue= 0;
                int NumberSpriteGreenSecondValue= 0;
                bool setNumberSpriteRedFirstValue = false;
                bool setNumberSpriteRedSecondValue = false;
                int NumberSpriteRedFirstValue= 0;
                int NumberSpriteRedSecondValue= 0;
                switch(firstState)
                {
                    case  ButtonCategory.Enabled:
                        setFrameSpriteTextureLeftFirstValue = true;
                        FrameSpriteTextureLeftFirstValue = 0;
                        setHighlightSpriteBlueFirstValue = true;
                        HighlightSpriteBlueFirstValue = 255;
                        setHighlightSpriteRedFirstValue = true;
                        HighlightSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.Visible = false;
                        }
                        setNumberSpriteBlueFirstValue = true;
                        NumberSpriteBlueFirstValue = 255;
                        setNumberSpriteGreenFirstValue = true;
                        NumberSpriteGreenFirstValue = 255;
                        setNumberSpriteRedFirstValue = true;
                        NumberSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.Visible = true;
                        }
                        break;
                    case  ButtonCategory.Disabled:
                        setFrameSpriteTextureLeftFirstValue = true;
                        FrameSpriteTextureLeftFirstValue = 256;
                        setHighlightSpriteBlueFirstValue = true;
                        HighlightSpriteBlueFirstValue = 255;
                        setHighlightSpriteRedFirstValue = true;
                        HighlightSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.Visible = false;
                        }
                        setNumberSpriteBlueFirstValue = true;
                        NumberSpriteBlueFirstValue = 255;
                        setNumberSpriteGreenFirstValue = true;
                        NumberSpriteGreenFirstValue = 255;
                        setNumberSpriteRedFirstValue = true;
                        NumberSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.Visible = false;
                        }
                        break;
                    case  ButtonCategory.Highlighted:
                        setFrameSpriteTextureLeftFirstValue = true;
                        FrameSpriteTextureLeftFirstValue = 0;
                        setHighlightSpriteBlueFirstValue = true;
                        HighlightSpriteBlueFirstValue = 255;
                        setHighlightSpriteRedFirstValue = true;
                        HighlightSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.Visible = true;
                        }
                        setNumberSpriteBlueFirstValue = true;
                        NumberSpriteBlueFirstValue = 255;
                        setNumberSpriteGreenFirstValue = true;
                        NumberSpriteGreenFirstValue = 255;
                        setNumberSpriteRedFirstValue = true;
                        NumberSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.Visible = true;
                        }
                        break;
                    case  ButtonCategory.Pushed:
                        setFrameSpriteTextureLeftFirstValue = true;
                        FrameSpriteTextureLeftFirstValue = 0;
                        setHighlightSpriteBlueFirstValue = true;
                        HighlightSpriteBlueFirstValue = 50;
                        setHighlightSpriteRedFirstValue = true;
                        HighlightSpriteRedFirstValue = 50;
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.Visible = true;
                        }
                        setNumberSpriteBlueFirstValue = true;
                        NumberSpriteBlueFirstValue = 0;
                        setNumberSpriteGreenFirstValue = true;
                        NumberSpriteGreenFirstValue = 255;
                        setNumberSpriteRedFirstValue = true;
                        NumberSpriteRedFirstValue = 50;
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  ButtonCategory.Enabled:
                        setFrameSpriteTextureLeftSecondValue = true;
                        FrameSpriteTextureLeftSecondValue = 0;
                        setHighlightSpriteBlueSecondValue = true;
                        HighlightSpriteBlueSecondValue = 255;
                        setHighlightSpriteRedSecondValue = true;
                        HighlightSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.Visible = false;
                        }
                        setNumberSpriteBlueSecondValue = true;
                        NumberSpriteBlueSecondValue = 255;
                        setNumberSpriteGreenSecondValue = true;
                        NumberSpriteGreenSecondValue = 255;
                        setNumberSpriteRedSecondValue = true;
                        NumberSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.Visible = true;
                        }
                        break;
                    case  ButtonCategory.Disabled:
                        setFrameSpriteTextureLeftSecondValue = true;
                        FrameSpriteTextureLeftSecondValue = 256;
                        setHighlightSpriteBlueSecondValue = true;
                        HighlightSpriteBlueSecondValue = 255;
                        setHighlightSpriteRedSecondValue = true;
                        HighlightSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.Visible = false;
                        }
                        setNumberSpriteBlueSecondValue = true;
                        NumberSpriteBlueSecondValue = 255;
                        setNumberSpriteGreenSecondValue = true;
                        NumberSpriteGreenSecondValue = 255;
                        setNumberSpriteRedSecondValue = true;
                        NumberSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.Visible = false;
                        }
                        break;
                    case  ButtonCategory.Highlighted:
                        setFrameSpriteTextureLeftSecondValue = true;
                        FrameSpriteTextureLeftSecondValue = 0;
                        setHighlightSpriteBlueSecondValue = true;
                        HighlightSpriteBlueSecondValue = 255;
                        setHighlightSpriteRedSecondValue = true;
                        HighlightSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.Visible = true;
                        }
                        setNumberSpriteBlueSecondValue = true;
                        NumberSpriteBlueSecondValue = 255;
                        setNumberSpriteGreenSecondValue = true;
                        NumberSpriteGreenSecondValue = 255;
                        setNumberSpriteRedSecondValue = true;
                        NumberSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.Visible = true;
                        }
                        break;
                    case  ButtonCategory.Pushed:
                        setFrameSpriteTextureLeftSecondValue = true;
                        FrameSpriteTextureLeftSecondValue = 0;
                        setHighlightSpriteBlueSecondValue = true;
                        HighlightSpriteBlueSecondValue = 50;
                        setHighlightSpriteRedSecondValue = true;
                        HighlightSpriteRedSecondValue = 50;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.Visible = true;
                        }
                        setNumberSpriteBlueSecondValue = true;
                        NumberSpriteBlueSecondValue = 0;
                        setNumberSpriteGreenSecondValue = true;
                        NumberSpriteGreenSecondValue = 255;
                        setNumberSpriteRedSecondValue = true;
                        NumberSpriteRedSecondValue = 50;
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.Visible = true;
                        }
                        break;
                }
                if (setFrameSpriteTextureLeftFirstValue && setFrameSpriteTextureLeftSecondValue)
                {
                    FrameSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(FrameSpriteTextureLeftFirstValue* (1 - interpolationValue) + FrameSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setHighlightSpriteBlueFirstValue && setHighlightSpriteBlueSecondValue)
                {
                    HighlightSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightSpriteBlueFirstValue* (1 - interpolationValue) + HighlightSpriteBlueSecondValue * interpolationValue);
                }
                if (setHighlightSpriteRedFirstValue && setHighlightSpriteRedSecondValue)
                {
                    HighlightSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightSpriteRedFirstValue* (1 - interpolationValue) + HighlightSpriteRedSecondValue * interpolationValue);
                }
                if (setNumberSpriteBlueFirstValue && setNumberSpriteBlueSecondValue)
                {
                    NumberSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteBlueFirstValue* (1 - interpolationValue) + NumberSpriteBlueSecondValue * interpolationValue);
                }
                if (setNumberSpriteGreenFirstValue && setNumberSpriteGreenSecondValue)
                {
                    NumberSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteGreenFirstValue* (1 - interpolationValue) + NumberSpriteGreenSecondValue * interpolationValue);
                }
                if (setNumberSpriteRedFirstValue && setNumberSpriteRedSecondValue)
                {
                    NumberSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteRedFirstValue* (1 - interpolationValue) + NumberSpriteRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentButtonCategoryState = firstState;
                }
                else
                {
                    mCurrentButtonCategoryState = secondState;
                }
            }
            public void InterpolateBetween (LevelNumber firstState, LevelNumber secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setNumberSpriteTextureHeightFirstValue = false;
                bool setNumberSpriteTextureHeightSecondValue = false;
                int NumberSpriteTextureHeightFirstValue= 0;
                int NumberSpriteTextureHeightSecondValue= 0;
                bool setNumberSpriteTextureLeftFirstValue = false;
                bool setNumberSpriteTextureLeftSecondValue = false;
                int NumberSpriteTextureLeftFirstValue= 0;
                int NumberSpriteTextureLeftSecondValue= 0;
                bool setNumberSpriteTextureTopFirstValue = false;
                bool setNumberSpriteTextureTopSecondValue = false;
                int NumberSpriteTextureTopFirstValue= 0;
                int NumberSpriteTextureTopSecondValue= 0;
                bool setNumberSpriteTextureWidthFirstValue = false;
                bool setNumberSpriteTextureWidthSecondValue = false;
                int NumberSpriteTextureWidthFirstValue= 0;
                int NumberSpriteTextureWidthSecondValue= 0;
                bool setNumberSpriteWidthFirstValue = false;
                bool setNumberSpriteWidthSecondValue = false;
                float NumberSpriteWidthFirstValue= 0;
                float NumberSpriteWidthSecondValue= 0;
                switch(firstState)
                {
                    case  LevelNumber.Level1:
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 100;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2055;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 40;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 20f;
                        break;
                    case  LevelNumber.Level2:
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 162;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2055;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 100;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 35f;
                        break;
                    case  LevelNumber.Level3:
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 260;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2055;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 85;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 35f;
                        break;
                    case  LevelNumber.Level4:
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 355;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2055;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 90;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 35f;
                        break;
                    case  LevelNumber.Level5:
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 0;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2180;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 95;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 35f;
                        break;
                    case  LevelNumber.Level6:
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 100;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2180;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 95;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 35f;
                        break;
                    case  LevelNumber.Level7:
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 190;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2180;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 95;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 35f;
                        break;
                    case  LevelNumber.Level8:
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 290;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2180;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 95;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 35f;
                        break;
                    case  LevelNumber.Level9:
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 385;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2180;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 95;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 35f;
                        break;
                    case  LevelNumber.Level10:
                        if (interpolationValue < 1)
                        {
                            this.NumberSprite.FlipHorizontal = true;
                        }
                        setNumberSpriteTextureHeightFirstValue = true;
                        NumberSpriteTextureHeightFirstValue = 116;
                        setNumberSpriteTextureLeftFirstValue = true;
                        NumberSpriteTextureLeftFirstValue = 0;
                        setNumberSpriteTextureTopFirstValue = true;
                        NumberSpriteTextureTopFirstValue = 2055;
                        setNumberSpriteTextureWidthFirstValue = true;
                        NumberSpriteTextureWidthFirstValue = 150;
                        setNumberSpriteWidthFirstValue = true;
                        NumberSpriteWidthFirstValue = 50f;
                        break;
                }
                switch(secondState)
                {
                    case  LevelNumber.Level1:
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 100;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2055;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 40;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 20f;
                        break;
                    case  LevelNumber.Level2:
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 162;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2055;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 100;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 35f;
                        break;
                    case  LevelNumber.Level3:
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 260;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2055;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 85;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 35f;
                        break;
                    case  LevelNumber.Level4:
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 355;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2055;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 90;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 35f;
                        break;
                    case  LevelNumber.Level5:
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 0;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2180;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 95;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 35f;
                        break;
                    case  LevelNumber.Level6:
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 100;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2180;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 95;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 35f;
                        break;
                    case  LevelNumber.Level7:
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 190;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2180;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 95;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 35f;
                        break;
                    case  LevelNumber.Level8:
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 290;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2180;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 95;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 35f;
                        break;
                    case  LevelNumber.Level9:
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.FlipHorizontal = false;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 385;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2180;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 95;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 35f;
                        break;
                    case  LevelNumber.Level10:
                        if (interpolationValue >= 1)
                        {
                            this.NumberSprite.FlipHorizontal = true;
                        }
                        setNumberSpriteTextureHeightSecondValue = true;
                        NumberSpriteTextureHeightSecondValue = 116;
                        setNumberSpriteTextureLeftSecondValue = true;
                        NumberSpriteTextureLeftSecondValue = 0;
                        setNumberSpriteTextureTopSecondValue = true;
                        NumberSpriteTextureTopSecondValue = 2055;
                        setNumberSpriteTextureWidthSecondValue = true;
                        NumberSpriteTextureWidthSecondValue = 150;
                        setNumberSpriteWidthSecondValue = true;
                        NumberSpriteWidthSecondValue = 50f;
                        break;
                }
                if (setNumberSpriteTextureHeightFirstValue && setNumberSpriteTextureHeightSecondValue)
                {
                    NumberSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteTextureHeightFirstValue* (1 - interpolationValue) + NumberSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setNumberSpriteTextureLeftFirstValue && setNumberSpriteTextureLeftSecondValue)
                {
                    NumberSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteTextureLeftFirstValue* (1 - interpolationValue) + NumberSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setNumberSpriteTextureTopFirstValue && setNumberSpriteTextureTopSecondValue)
                {
                    NumberSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteTextureTopFirstValue* (1 - interpolationValue) + NumberSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setNumberSpriteTextureWidthFirstValue && setNumberSpriteTextureWidthSecondValue)
                {
                    NumberSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(NumberSpriteTextureWidthFirstValue* (1 - interpolationValue) + NumberSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setNumberSpriteWidthFirstValue && setNumberSpriteWidthSecondValue)
                {
                    NumberSprite.Width = NumberSpriteWidthFirstValue * (1 - interpolationValue) + NumberSpriteWidthSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentLevelNumberState = firstState;
                }
                else
                {
                    mCurrentLevelNumberState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory fromState,AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ButtonCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentButtonCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentButtonCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber fromState,AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (LevelNumber toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "LevelNumber").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentLevelNumberState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (LevelNumber toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentLevelNumberState = toState;
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
                            Name = "FrameSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = FrameSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.SourceFile",
                            Type = "string",
                            Value = FrameSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = FrameSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Height",
                            Type = "int",
                            Value = FrameSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Left",
                            Type = "int",
                            Value = FrameSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Top",
                            Type = "int",
                            Value = FrameSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Width",
                            Type = "int",
                            Value = FrameSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = FrameSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = HighlightSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.SourceFile",
                            Type = "string",
                            Value = HighlightSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = HighlightSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Height",
                            Type = "int",
                            Value = HighlightSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Left",
                            Type = "int",
                            Value = HighlightSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Top",
                            Type = "int",
                            Value = HighlightSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Width",
                            Type = "int",
                            Value = HighlightSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = HighlightSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.X",
                            Type = "float",
                            Value = HighlightSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = HighlightSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.X Units",
                            Type = "PositionUnitType",
                            Value = HighlightSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Y",
                            Type = "float",
                            Value = HighlightSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = HighlightSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = HighlightSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Height",
                            Type = "float",
                            Value = NumberSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = NumberSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.SourceFile",
                            Type = "string",
                            Value = NumberSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = NumberSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = NumberSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.X",
                            Type = "float",
                            Value = NumberSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NumberSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.X Units",
                            Type = "PositionUnitType",
                            Value = NumberSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Y",
                            Type = "float",
                            Value = NumberSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = NumberSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = NumberSprite.YUnits
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
                            Name = "FrameSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = FrameSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.SourceFile",
                            Type = "string",
                            Value = FrameSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = FrameSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Height",
                            Type = "int",
                            Value = FrameSprite.TextureHeight + 263
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Left",
                            Type = "int",
                            Value = FrameSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Top",
                            Type = "int",
                            Value = FrameSprite.TextureTop + 2306
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Width",
                            Type = "int",
                            Value = FrameSprite.TextureWidth + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = FrameSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = HighlightSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.SourceFile",
                            Type = "string",
                            Value = HighlightSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = HighlightSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Height",
                            Type = "int",
                            Value = HighlightSprite.TextureHeight + 156
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Left",
                            Type = "int",
                            Value = HighlightSprite.TextureLeft + 2435
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Top",
                            Type = "int",
                            Value = HighlightSprite.TextureTop + 601
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Width",
                            Type = "int",
                            Value = HighlightSprite.TextureWidth + 156
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = HighlightSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.X",
                            Type = "float",
                            Value = HighlightSprite.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = HighlightSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.X Units",
                            Type = "PositionUnitType",
                            Value = HighlightSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Y",
                            Type = "float",
                            Value = HighlightSprite.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = HighlightSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = HighlightSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Height",
                            Type = "float",
                            Value = NumberSprite.Height + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = NumberSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.SourceFile",
                            Type = "string",
                            Value = NumberSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = NumberSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 105
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2055
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 37
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = NumberSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.X",
                            Type = "float",
                            Value = NumberSprite.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NumberSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.X Units",
                            Type = "PositionUnitType",
                            Value = NumberSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Y",
                            Type = "float",
                            Value = NumberSprite.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = NumberSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = NumberSprite.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ButtonCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Left",
                            Type = "int",
                            Value = FrameSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Blue",
                            Type = "int",
                            Value = HighlightSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Red",
                            Type = "int",
                            Value = HighlightSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Blue",
                            Type = "int",
                            Value = NumberSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Green",
                            Type = "int",
                            Value = NumberSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Red",
                            Type = "int",
                            Value = NumberSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Visible",
                            Type = "bool",
                            Value = NumberSprite.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Left",
                            Type = "int",
                            Value = FrameSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Blue",
                            Type = "int",
                            Value = HighlightSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Red",
                            Type = "int",
                            Value = HighlightSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Blue",
                            Type = "int",
                            Value = NumberSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Green",
                            Type = "int",
                            Value = NumberSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Red",
                            Type = "int",
                            Value = NumberSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Visible",
                            Type = "bool",
                            Value = NumberSprite.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Left",
                            Type = "int",
                            Value = FrameSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Blue",
                            Type = "int",
                            Value = HighlightSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Red",
                            Type = "int",
                            Value = HighlightSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Blue",
                            Type = "int",
                            Value = NumberSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Green",
                            Type = "int",
                            Value = NumberSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Red",
                            Type = "int",
                            Value = NumberSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Visible",
                            Type = "bool",
                            Value = NumberSprite.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Left",
                            Type = "int",
                            Value = FrameSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Blue",
                            Type = "int",
                            Value = HighlightSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Red",
                            Type = "int",
                            Value = HighlightSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Blue",
                            Type = "int",
                            Value = NumberSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Green",
                            Type = "int",
                            Value = NumberSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Red",
                            Type = "int",
                            Value = NumberSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Visible",
                            Type = "bool",
                            Value = NumberSprite.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ButtonCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Left",
                            Type = "int",
                            Value = FrameSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Blue",
                            Type = "int",
                            Value = HighlightSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Red",
                            Type = "int",
                            Value = HighlightSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Blue",
                            Type = "int",
                            Value = NumberSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Green",
                            Type = "int",
                            Value = NumberSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Red",
                            Type = "int",
                            Value = NumberSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Visible",
                            Type = "bool",
                            Value = NumberSprite.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Left",
                            Type = "int",
                            Value = FrameSprite.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Blue",
                            Type = "int",
                            Value = HighlightSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Red",
                            Type = "int",
                            Value = HighlightSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Blue",
                            Type = "int",
                            Value = NumberSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Green",
                            Type = "int",
                            Value = NumberSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Red",
                            Type = "int",
                            Value = NumberSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Visible",
                            Type = "bool",
                            Value = NumberSprite.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Left",
                            Type = "int",
                            Value = FrameSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Blue",
                            Type = "int",
                            Value = HighlightSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Red",
                            Type = "int",
                            Value = HighlightSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Blue",
                            Type = "int",
                            Value = NumberSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Green",
                            Type = "int",
                            Value = NumberSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Red",
                            Type = "int",
                            Value = NumberSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Visible",
                            Type = "bool",
                            Value = NumberSprite.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrameSprite.Texture Left",
                            Type = "int",
                            Value = FrameSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Blue",
                            Type = "int",
                            Value = HighlightSprite.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Red",
                            Type = "int",
                            Value = HighlightSprite.Red + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Blue",
                            Type = "int",
                            Value = NumberSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Green",
                            Type = "int",
                            Value = NumberSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Red",
                            Type = "int",
                            Value = NumberSprite.Red + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Visible",
                            Type = "bool",
                            Value = NumberSprite.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (LevelNumber state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  LevelNumber.Level1:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        break;
                    case  LevelNumber.Level2:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        break;
                    case  LevelNumber.Level3:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        break;
                    case  LevelNumber.Level4:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        break;
                    case  LevelNumber.Level5:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        break;
                    case  LevelNumber.Level6:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        break;
                    case  LevelNumber.Level7:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        break;
                    case  LevelNumber.Level8:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        break;
                    case  LevelNumber.Level9:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        break;
                    case  LevelNumber.Level10:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (LevelNumber state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  LevelNumber.Level1:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2055
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 40
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 20f
                        }
                        );
                        break;
                    case  LevelNumber.Level2:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 162
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2055
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 35f
                        }
                        );
                        break;
                    case  LevelNumber.Level3:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 260
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2055
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 85
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 35f
                        }
                        );
                        break;
                    case  LevelNumber.Level4:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 355
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2055
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 90
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 35f
                        }
                        );
                        break;
                    case  LevelNumber.Level5:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2180
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 95
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 35f
                        }
                        );
                        break;
                    case  LevelNumber.Level6:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2180
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 95
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 35f
                        }
                        );
                        break;
                    case  LevelNumber.Level7:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 190
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2180
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 95
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 35f
                        }
                        );
                        break;
                    case  LevelNumber.Level8:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 290
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2180
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 95
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 35f
                        }
                        );
                        break;
                    case  LevelNumber.Level9:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 385
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2180
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 95
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 35f
                        }
                        );
                        break;
                    case  LevelNumber.Level10:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.FlipHorizontal",
                            Type = "bool",
                            Value = NumberSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Height",
                            Type = "int",
                            Value = NumberSprite.TextureHeight + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Left",
                            Type = "int",
                            Value = NumberSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Top",
                            Type = "int",
                            Value = NumberSprite.TextureTop + 2055
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Texture Width",
                            Type = "int",
                            Value = NumberSprite.TextureWidth + 150
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NumberSprite.Width",
                            Type = "float",
                            Value = NumberSprite.Width + 50f
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
                    else if (category.Name == "ButtonCategory")
                    {
                        if(state.Name == "Enabled") this.mCurrentButtonCategoryState = ButtonCategory.Enabled;
                        if(state.Name == "Disabled") this.mCurrentButtonCategoryState = ButtonCategory.Disabled;
                        if(state.Name == "Highlighted") this.mCurrentButtonCategoryState = ButtonCategory.Highlighted;
                        if(state.Name == "Pushed") this.mCurrentButtonCategoryState = ButtonCategory.Pushed;
                    }
                    else if (category.Name == "LevelNumber")
                    {
                        if(state.Name == "Level1") this.mCurrentLevelNumberState = LevelNumber.Level1;
                        if(state.Name == "Level2") this.mCurrentLevelNumberState = LevelNumber.Level2;
                        if(state.Name == "Level3") this.mCurrentLevelNumberState = LevelNumber.Level3;
                        if(state.Name == "Level4") this.mCurrentLevelNumberState = LevelNumber.Level4;
                        if(state.Name == "Level5") this.mCurrentLevelNumberState = LevelNumber.Level5;
                        if(state.Name == "Level6") this.mCurrentLevelNumberState = LevelNumber.Level6;
                        if(state.Name == "Level7") this.mCurrentLevelNumberState = LevelNumber.Level7;
                        if(state.Name == "Level8") this.mCurrentLevelNumberState = LevelNumber.Level8;
                        if(state.Name == "Level9") this.mCurrentLevelNumberState = LevelNumber.Level9;
                        if(state.Name == "Level10") this.mCurrentLevelNumberState = LevelNumber.Level10;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime FrameSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime HighlightSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime NumberSprite { get; set; }
            public LevelButtonRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "specificbuttons/LevelButton");
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
                FrameSprite = this.GetGraphicalUiElementByName("FrameSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                HighlightSprite = this.GetGraphicalUiElementByName("HighlightSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                NumberSprite = this.GetGraphicalUiElementByName("NumberSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControl = new FlatRedBall.Forms.Controls.Button(this);
                }
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
            public FlatRedBall.Forms.Controls.Button FormsControl {get; private set;}
            public override object FormsControlAsObject { get { return FormsControl; } }
        }
    }
