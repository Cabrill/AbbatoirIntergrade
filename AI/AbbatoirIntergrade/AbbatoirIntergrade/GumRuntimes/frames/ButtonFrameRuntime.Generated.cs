    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes.frames
    {
        public partial class ButtonFrameRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Highlight
            {
                Highlighted,
                NotHighlighted
            }
            public enum Select
            {
                Selected,
                NotSelected
            }
            public enum ButtonType
            {
                Check,
                X,
                Play,
                Disabled,
                Menu,
                Pause,
                FastForward,
                Restart,
                History
            }
            public enum Colors
            {
                Normal,
                Red,
                Green
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Highlight? mCurrentHighlightState;
            Select? mCurrentSelectState;
            ButtonType? mCurrentButtonTypeState;
            Colors? mCurrentColorsState;
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
                            HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            Width = 13.647f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BackgroundSprite.Height = 100f;
                            BackgroundSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            SetProperty("BackgroundSprite.SourceFile", "AllUIAssets.png");
                            BackgroundSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            BackgroundSprite.TextureHeight = 256;
                            BackgroundSprite.TextureLeft = 0;
                            BackgroundSprite.TextureTop = 768;
                            BackgroundSprite.TextureWidth = 256;
                            BackgroundSprite.Width = 100f;
                            BackgroundSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SelectSprite.Height = 100f;
                            SelectSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            SetProperty("SelectSprite.SourceFile", "AllUIAssets.png");
                            SelectSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SelectSprite.TextureHeight = 256;
                            SelectSprite.TextureLeft = 256;
                            SelectSprite.TextureTop = 768;
                            SelectSprite.TextureWidth = 256;
                            SelectSprite.Visible = false;
                            SelectSprite.Width = 100f;
                            SelectSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SpriteInstance.Height = 90f;
                            SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            SetProperty("SpriteInstance.SourceFile", "AllUIAssets.png");
                            SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SpriteInstance.TextureHeight = 200;
                            SpriteInstance.TextureLeft = 3808;
                            SpriteInstance.TextureTop = 1692;
                            SpriteInstance.TextureWidth = 200;
                            SpriteInstance.Visible = false;
                            SpriteInstance.Width = 90f;
                            SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public Highlight? CurrentHighlightState
            {
                get
                {
                    return mCurrentHighlightState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentHighlightState = value;
                        switch(mCurrentHighlightState)
                        {
                            case  Highlight.Highlighted:
                                BackgroundSprite.TextureLeft = 512;
                                break;
                            case  Highlight.NotHighlighted:
                                BackgroundSprite.TextureLeft = 0;
                                break;
                        }
                    }
                }
            }
            public Select? CurrentSelectState
            {
                get
                {
                    return mCurrentSelectState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentSelectState = value;
                        switch(mCurrentSelectState)
                        {
                            case  Select.Selected:
                                SelectSprite.Visible = true;
                                SpriteInstance.Red = 176;
                                break;
                            case  Select.NotSelected:
                                SelectSprite.Visible = false;
                                SpriteInstance.Red = 255;
                                break;
                        }
                    }
                }
            }
            public ButtonType? CurrentButtonTypeState
            {
                get
                {
                    return mCurrentButtonTypeState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentButtonTypeState = value;
                        switch(mCurrentButtonTypeState)
                        {
                            case  ButtonType.Check:
                                BackgroundSprite.Alpha = 255;
                                SpriteInstance.TextureHeight = 256;
                                SpriteInstance.TextureLeft = 3780;
                                SpriteInstance.TextureTop = 1675;
                                SpriteInstance.TextureWidth = 256;
                                SpriteInstance.Visible = true;
                                break;
                            case  ButtonType.X:
                                BackgroundSprite.Alpha = 255;
                                SpriteInstance.TextureHeight = 200;
                                SpriteInstance.TextureLeft = 3550;
                                SpriteInstance.TextureTop = 1692;
                                SpriteInstance.TextureWidth = 200;
                                SpriteInstance.Visible = true;
                                break;
                            case  ButtonType.Play:
                                BackgroundSprite.Alpha = 255;
                                SpriteInstance.TextureHeight = 200;
                                SpriteInstance.TextureLeft = 3720;
                                SpriteInstance.TextureTop = 2750;
                                SpriteInstance.TextureWidth = 200;
                                SpriteInstance.Visible = true;
                                break;
                            case  ButtonType.Disabled:
                                BackgroundSprite.Alpha = 150;
                                SpriteInstance.TextureHeight = 200;
                                SpriteInstance.TextureLeft = 3808;
                                SpriteInstance.TextureTop = 1692;
                                SpriteInstance.TextureWidth = 200;
                                SpriteInstance.Visible = false;
                                break;
                            case  ButtonType.Menu:
                                BackgroundSprite.Alpha = 255;
                                SpriteInstance.TextureHeight = 200;
                                SpriteInstance.TextureLeft = 3707;
                                SpriteInstance.TextureTop = 3770;
                                SpriteInstance.TextureWidth = 200;
                                SpriteInstance.Visible = true;
                                break;
                            case  ButtonType.Pause:
                                BackgroundSprite.Alpha = 255;
                                SpriteInstance.TextureHeight = 200;
                                SpriteInstance.TextureLeft = 3707;
                                SpriteInstance.TextureTop = 3005;
                                SpriteInstance.TextureWidth = 200;
                                SpriteInstance.Visible = true;
                                break;
                            case  ButtonType.FastForward:
                                BackgroundSprite.Alpha = 255;
                                SpriteInstance.TextureHeight = 200;
                                SpriteInstance.TextureLeft = 3550;
                                SpriteInstance.TextureTop = 2212;
                                SpriteInstance.TextureWidth = 200;
                                SpriteInstance.Visible = true;
                                break;
                            case  ButtonType.Restart:
                                BackgroundSprite.Alpha = 255;
                                SpriteInstance.TextureHeight = 200;
                                SpriteInstance.TextureLeft = 3805;
                                SpriteInstance.TextureTop = 2205;
                                SpriteInstance.TextureWidth = 200;
                                SpriteInstance.Visible = true;
                                break;
                            case  ButtonType.History:
                                BackgroundSprite.Alpha = 255;
                                SpriteInstance.TextureHeight = 250;
                                SpriteInstance.TextureLeft = 3522;
                                SpriteInstance.TextureTop = 945;
                                SpriteInstance.TextureWidth = 250;
                                SpriteInstance.Visible = true;
                                break;
                        }
                    }
                }
            }
            public Colors? CurrentColorsState
            {
                get
                {
                    return mCurrentColorsState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentColorsState = value;
                        switch(mCurrentColorsState)
                        {
                            case  Colors.Normal:
                                BackgroundSprite.Blue = 255;
                                BackgroundSprite.Green = 255;
                                BackgroundSprite.Red = 255;
                                SelectSprite.Blue = 255;
                                SelectSprite.Green = 255;
                                SelectSprite.Red = 255;
                                SpriteInstance.Blue = 255;
                                SpriteInstance.Green = 255;
                                SpriteInstance.Red = 255;
                                break;
                            case  Colors.Red:
                                BackgroundSprite.Blue = 0;
                                BackgroundSprite.Green = 0;
                                BackgroundSprite.Red = 255;
                                SelectSprite.Blue = 0;
                                SelectSprite.Green = 0;
                                SelectSprite.Red = 255;
                                SpriteInstance.Blue = 0;
                                SpriteInstance.Green = 0;
                                SpriteInstance.Red = 255;
                                break;
                            case  Colors.Green:
                                BackgroundSprite.Blue = 0;
                                BackgroundSprite.Green = 255;
                                BackgroundSprite.Red = 0;
                                SelectSprite.Blue = 0;
                                SelectSprite.Green = 255;
                                SelectSprite.Red = 0;
                                SpriteInstance.Blue = 0;
                                SpriteInstance.Green = 255;
                                SpriteInstance.Red = 0;
                                break;
                        }
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
                bool setBackgroundSpriteHeightFirstValue = false;
                bool setBackgroundSpriteHeightSecondValue = false;
                float BackgroundSpriteHeightFirstValue= 0;
                float BackgroundSpriteHeightSecondValue= 0;
                bool setBackgroundSpriteTextureHeightFirstValue = false;
                bool setBackgroundSpriteTextureHeightSecondValue = false;
                int BackgroundSpriteTextureHeightFirstValue= 0;
                int BackgroundSpriteTextureHeightSecondValue= 0;
                bool setBackgroundSpriteTextureLeftFirstValue = false;
                bool setBackgroundSpriteTextureLeftSecondValue = false;
                int BackgroundSpriteTextureLeftFirstValue= 0;
                int BackgroundSpriteTextureLeftSecondValue= 0;
                bool setBackgroundSpriteTextureTopFirstValue = false;
                bool setBackgroundSpriteTextureTopSecondValue = false;
                int BackgroundSpriteTextureTopFirstValue= 0;
                int BackgroundSpriteTextureTopSecondValue= 0;
                bool setBackgroundSpriteTextureWidthFirstValue = false;
                bool setBackgroundSpriteTextureWidthSecondValue = false;
                int BackgroundSpriteTextureWidthFirstValue= 0;
                int BackgroundSpriteTextureWidthSecondValue= 0;
                bool setBackgroundSpriteWidthFirstValue = false;
                bool setBackgroundSpriteWidthSecondValue = false;
                float BackgroundSpriteWidthFirstValue= 0;
                float BackgroundSpriteWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setSelectSpriteHeightFirstValue = false;
                bool setSelectSpriteHeightSecondValue = false;
                float SelectSpriteHeightFirstValue= 0;
                float SelectSpriteHeightSecondValue= 0;
                bool setSelectSpriteTextureHeightFirstValue = false;
                bool setSelectSpriteTextureHeightSecondValue = false;
                int SelectSpriteTextureHeightFirstValue= 0;
                int SelectSpriteTextureHeightSecondValue= 0;
                bool setSelectSpriteTextureLeftFirstValue = false;
                bool setSelectSpriteTextureLeftSecondValue = false;
                int SelectSpriteTextureLeftFirstValue= 0;
                int SelectSpriteTextureLeftSecondValue= 0;
                bool setSelectSpriteTextureTopFirstValue = false;
                bool setSelectSpriteTextureTopSecondValue = false;
                int SelectSpriteTextureTopFirstValue= 0;
                int SelectSpriteTextureTopSecondValue= 0;
                bool setSelectSpriteTextureWidthFirstValue = false;
                bool setSelectSpriteTextureWidthSecondValue = false;
                int SelectSpriteTextureWidthFirstValue= 0;
                int SelectSpriteTextureWidthSecondValue= 0;
                bool setSelectSpriteWidthFirstValue = false;
                bool setSelectSpriteWidthSecondValue = false;
                float SelectSpriteWidthFirstValue= 0;
                float SelectSpriteWidthSecondValue= 0;
                bool setSpriteInstanceHeightFirstValue = false;
                bool setSpriteInstanceHeightSecondValue = false;
                float SpriteInstanceHeightFirstValue= 0;
                float SpriteInstanceHeightSecondValue= 0;
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
                bool setSpriteInstanceWidthFirstValue = false;
                bool setSpriteInstanceWidthSecondValue = false;
                float SpriteInstanceWidthFirstValue= 0;
                float SpriteInstanceWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBackgroundSpriteHeightFirstValue = true;
                        BackgroundSpriteHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("BackgroundSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackgroundSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBackgroundSpriteTextureHeightFirstValue = true;
                        BackgroundSpriteTextureHeightFirstValue = 256;
                        setBackgroundSpriteTextureLeftFirstValue = true;
                        BackgroundSpriteTextureLeftFirstValue = 0;
                        setBackgroundSpriteTextureTopFirstValue = true;
                        BackgroundSpriteTextureTopFirstValue = 768;
                        setBackgroundSpriteTextureWidthFirstValue = true;
                        BackgroundSpriteTextureWidthFirstValue = 256;
                        setBackgroundSpriteWidthFirstValue = true;
                        BackgroundSpriteWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setSelectSpriteHeightFirstValue = true;
                        SelectSpriteHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.SelectSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SelectSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SelectSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSelectSpriteTextureHeightFirstValue = true;
                        SelectSpriteTextureHeightFirstValue = 256;
                        setSelectSpriteTextureLeftFirstValue = true;
                        SelectSpriteTextureLeftFirstValue = 256;
                        setSelectSpriteTextureTopFirstValue = true;
                        SelectSpriteTextureTopFirstValue = 768;
                        setSelectSpriteTextureWidthFirstValue = true;
                        SelectSpriteTextureWidthFirstValue = 256;
                        if (interpolationValue < 1)
                        {
                            this.SelectSprite.Visible = false;
                        }
                        setSelectSpriteWidthFirstValue = true;
                        SelectSpriteWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.SelectSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSpriteInstanceHeightFirstValue = true;
                        SpriteInstanceHeightFirstValue = 90f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 200;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3808;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 1692;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 200;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        setSpriteInstanceWidthFirstValue = true;
                        SpriteInstanceWidthFirstValue = 90f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 13.647f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBackgroundSpriteHeightSecondValue = true;
                        BackgroundSpriteHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BackgroundSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBackgroundSpriteTextureHeightSecondValue = true;
                        BackgroundSpriteTextureHeightSecondValue = 256;
                        setBackgroundSpriteTextureLeftSecondValue = true;
                        BackgroundSpriteTextureLeftSecondValue = 0;
                        setBackgroundSpriteTextureTopSecondValue = true;
                        BackgroundSpriteTextureTopSecondValue = 768;
                        setBackgroundSpriteTextureWidthSecondValue = true;
                        BackgroundSpriteTextureWidthSecondValue = 256;
                        setBackgroundSpriteWidthSecondValue = true;
                        BackgroundSpriteWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setSelectSpriteHeightSecondValue = true;
                        SelectSpriteHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.SelectSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SelectSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SelectSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSelectSpriteTextureHeightSecondValue = true;
                        SelectSpriteTextureHeightSecondValue = 256;
                        setSelectSpriteTextureLeftSecondValue = true;
                        SelectSpriteTextureLeftSecondValue = 256;
                        setSelectSpriteTextureTopSecondValue = true;
                        SelectSpriteTextureTopSecondValue = 768;
                        setSelectSpriteTextureWidthSecondValue = true;
                        SelectSpriteTextureWidthSecondValue = 256;
                        if (interpolationValue >= 1)
                        {
                            this.SelectSprite.Visible = false;
                        }
                        setSelectSpriteWidthSecondValue = true;
                        SelectSpriteWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.SelectSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSpriteInstanceHeightSecondValue = true;
                        SpriteInstanceHeightSecondValue = 90f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 200;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3808;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 1692;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 200;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        setSpriteInstanceWidthSecondValue = true;
                        SpriteInstanceWidthSecondValue = 90f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 13.647f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                if (setBackgroundSpriteHeightFirstValue && setBackgroundSpriteHeightSecondValue)
                {
                    BackgroundSprite.Height = BackgroundSpriteHeightFirstValue * (1 - interpolationValue) + BackgroundSpriteHeightSecondValue * interpolationValue;
                }
                if (setBackgroundSpriteTextureHeightFirstValue && setBackgroundSpriteTextureHeightSecondValue)
                {
                    BackgroundSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundSpriteTextureHeightFirstValue* (1 - interpolationValue) + BackgroundSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setBackgroundSpriteTextureLeftFirstValue && setBackgroundSpriteTextureLeftSecondValue)
                {
                    BackgroundSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundSpriteTextureLeftFirstValue* (1 - interpolationValue) + BackgroundSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setBackgroundSpriteTextureTopFirstValue && setBackgroundSpriteTextureTopSecondValue)
                {
                    BackgroundSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundSpriteTextureTopFirstValue* (1 - interpolationValue) + BackgroundSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setBackgroundSpriteTextureWidthFirstValue && setBackgroundSpriteTextureWidthSecondValue)
                {
                    BackgroundSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundSpriteTextureWidthFirstValue* (1 - interpolationValue) + BackgroundSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setBackgroundSpriteWidthFirstValue && setBackgroundSpriteWidthSecondValue)
                {
                    BackgroundSprite.Width = BackgroundSpriteWidthFirstValue * (1 - interpolationValue) + BackgroundSpriteWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setSelectSpriteHeightFirstValue && setSelectSpriteHeightSecondValue)
                {
                    SelectSprite.Height = SelectSpriteHeightFirstValue * (1 - interpolationValue) + SelectSpriteHeightSecondValue * interpolationValue;
                }
                if (setSelectSpriteTextureHeightFirstValue && setSelectSpriteTextureHeightSecondValue)
                {
                    SelectSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SelectSpriteTextureHeightFirstValue* (1 - interpolationValue) + SelectSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setSelectSpriteTextureLeftFirstValue && setSelectSpriteTextureLeftSecondValue)
                {
                    SelectSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SelectSpriteTextureLeftFirstValue* (1 - interpolationValue) + SelectSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setSelectSpriteTextureTopFirstValue && setSelectSpriteTextureTopSecondValue)
                {
                    SelectSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SelectSpriteTextureTopFirstValue* (1 - interpolationValue) + SelectSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setSelectSpriteTextureWidthFirstValue && setSelectSpriteTextureWidthSecondValue)
                {
                    SelectSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SelectSpriteTextureWidthFirstValue* (1 - interpolationValue) + SelectSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setSelectSpriteWidthFirstValue && setSelectSpriteWidthSecondValue)
                {
                    SelectSprite.Width = SelectSpriteWidthFirstValue * (1 - interpolationValue) + SelectSpriteWidthSecondValue * interpolationValue;
                }
                if (setSpriteInstanceHeightFirstValue && setSpriteInstanceHeightSecondValue)
                {
                    SpriteInstance.Height = SpriteInstanceHeightFirstValue * (1 - interpolationValue) + SpriteInstanceHeightSecondValue * interpolationValue;
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
                if (setSpriteInstanceWidthFirstValue && setSpriteInstanceWidthSecondValue)
                {
                    SpriteInstance.Width = SpriteInstanceWidthFirstValue * (1 - interpolationValue) + SpriteInstanceWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (Highlight firstState, Highlight secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBackgroundSpriteTextureLeftFirstValue = false;
                bool setBackgroundSpriteTextureLeftSecondValue = false;
                int BackgroundSpriteTextureLeftFirstValue= 0;
                int BackgroundSpriteTextureLeftSecondValue= 0;
                switch(firstState)
                {
                    case  Highlight.Highlighted:
                        setBackgroundSpriteTextureLeftFirstValue = true;
                        BackgroundSpriteTextureLeftFirstValue = 512;
                        break;
                    case  Highlight.NotHighlighted:
                        setBackgroundSpriteTextureLeftFirstValue = true;
                        BackgroundSpriteTextureLeftFirstValue = 0;
                        break;
                }
                switch(secondState)
                {
                    case  Highlight.Highlighted:
                        setBackgroundSpriteTextureLeftSecondValue = true;
                        BackgroundSpriteTextureLeftSecondValue = 512;
                        break;
                    case  Highlight.NotHighlighted:
                        setBackgroundSpriteTextureLeftSecondValue = true;
                        BackgroundSpriteTextureLeftSecondValue = 0;
                        break;
                }
                if (setBackgroundSpriteTextureLeftFirstValue && setBackgroundSpriteTextureLeftSecondValue)
                {
                    BackgroundSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundSpriteTextureLeftFirstValue* (1 - interpolationValue) + BackgroundSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentHighlightState = firstState;
                }
                else
                {
                    mCurrentHighlightState = secondState;
                }
            }
            public void InterpolateBetween (Select firstState, Select secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setSpriteInstanceRedFirstValue = false;
                bool setSpriteInstanceRedSecondValue = false;
                int SpriteInstanceRedFirstValue= 0;
                int SpriteInstanceRedSecondValue= 0;
                switch(firstState)
                {
                    case  Select.Selected:
                        if (interpolationValue < 1)
                        {
                            this.SelectSprite.Visible = true;
                        }
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 176;
                        break;
                    case  Select.NotSelected:
                        if (interpolationValue < 1)
                        {
                            this.SelectSprite.Visible = false;
                        }
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 255;
                        break;
                }
                switch(secondState)
                {
                    case  Select.Selected:
                        if (interpolationValue >= 1)
                        {
                            this.SelectSprite.Visible = true;
                        }
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 176;
                        break;
                    case  Select.NotSelected:
                        if (interpolationValue >= 1)
                        {
                            this.SelectSprite.Visible = false;
                        }
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 255;
                        break;
                }
                if (setSpriteInstanceRedFirstValue && setSpriteInstanceRedSecondValue)
                {
                    SpriteInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceRedFirstValue* (1 - interpolationValue) + SpriteInstanceRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentSelectState = firstState;
                }
                else
                {
                    mCurrentSelectState = secondState;
                }
            }
            public void InterpolateBetween (ButtonType firstState, ButtonType secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBackgroundSpriteAlphaFirstValue = false;
                bool setBackgroundSpriteAlphaSecondValue = false;
                int BackgroundSpriteAlphaFirstValue= 0;
                int BackgroundSpriteAlphaSecondValue= 0;
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
                switch(firstState)
                {
                    case  ButtonType.Check:
                        setBackgroundSpriteAlphaFirstValue = true;
                        BackgroundSpriteAlphaFirstValue = 255;
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 256;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3780;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 1675;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 256;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.X:
                        setBackgroundSpriteAlphaFirstValue = true;
                        BackgroundSpriteAlphaFirstValue = 255;
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 200;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3550;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 1692;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 200;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.Play:
                        setBackgroundSpriteAlphaFirstValue = true;
                        BackgroundSpriteAlphaFirstValue = 255;
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 200;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3720;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 2750;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 200;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.Disabled:
                        setBackgroundSpriteAlphaFirstValue = true;
                        BackgroundSpriteAlphaFirstValue = 150;
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 200;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3808;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 1692;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 200;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        break;
                    case  ButtonType.Menu:
                        setBackgroundSpriteAlphaFirstValue = true;
                        BackgroundSpriteAlphaFirstValue = 255;
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 200;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3707;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 3770;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 200;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.Pause:
                        setBackgroundSpriteAlphaFirstValue = true;
                        BackgroundSpriteAlphaFirstValue = 255;
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 200;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3707;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 3005;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 200;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.FastForward:
                        setBackgroundSpriteAlphaFirstValue = true;
                        BackgroundSpriteAlphaFirstValue = 255;
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 200;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3550;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 2212;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 200;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.Restart:
                        setBackgroundSpriteAlphaFirstValue = true;
                        BackgroundSpriteAlphaFirstValue = 255;
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 200;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3805;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 2205;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 200;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.History:
                        setBackgroundSpriteAlphaFirstValue = true;
                        BackgroundSpriteAlphaFirstValue = 255;
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 250;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3522;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 945;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 250;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  ButtonType.Check:
                        setBackgroundSpriteAlphaSecondValue = true;
                        BackgroundSpriteAlphaSecondValue = 255;
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 256;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3780;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 1675;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 256;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.X:
                        setBackgroundSpriteAlphaSecondValue = true;
                        BackgroundSpriteAlphaSecondValue = 255;
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 200;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3550;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 1692;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 200;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.Play:
                        setBackgroundSpriteAlphaSecondValue = true;
                        BackgroundSpriteAlphaSecondValue = 255;
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 200;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3720;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 2750;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 200;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.Disabled:
                        setBackgroundSpriteAlphaSecondValue = true;
                        BackgroundSpriteAlphaSecondValue = 150;
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 200;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3808;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 1692;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 200;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        break;
                    case  ButtonType.Menu:
                        setBackgroundSpriteAlphaSecondValue = true;
                        BackgroundSpriteAlphaSecondValue = 255;
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 200;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3707;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 3770;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 200;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.Pause:
                        setBackgroundSpriteAlphaSecondValue = true;
                        BackgroundSpriteAlphaSecondValue = 255;
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 200;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3707;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 3005;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 200;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.FastForward:
                        setBackgroundSpriteAlphaSecondValue = true;
                        BackgroundSpriteAlphaSecondValue = 255;
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 200;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3550;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 2212;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 200;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.Restart:
                        setBackgroundSpriteAlphaSecondValue = true;
                        BackgroundSpriteAlphaSecondValue = 255;
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 200;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3805;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 2205;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 200;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                    case  ButtonType.History:
                        setBackgroundSpriteAlphaSecondValue = true;
                        BackgroundSpriteAlphaSecondValue = 255;
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 250;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3522;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 945;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 250;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        break;
                }
                if (setBackgroundSpriteAlphaFirstValue && setBackgroundSpriteAlphaSecondValue)
                {
                    BackgroundSprite.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundSpriteAlphaFirstValue* (1 - interpolationValue) + BackgroundSpriteAlphaSecondValue * interpolationValue);
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
                if (interpolationValue < 1)
                {
                    mCurrentButtonTypeState = firstState;
                }
                else
                {
                    mCurrentButtonTypeState = secondState;
                }
            }
            public void InterpolateBetween (Colors firstState, Colors secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBackgroundSpriteBlueFirstValue = false;
                bool setBackgroundSpriteBlueSecondValue = false;
                int BackgroundSpriteBlueFirstValue= 0;
                int BackgroundSpriteBlueSecondValue= 0;
                bool setBackgroundSpriteGreenFirstValue = false;
                bool setBackgroundSpriteGreenSecondValue = false;
                int BackgroundSpriteGreenFirstValue= 0;
                int BackgroundSpriteGreenSecondValue= 0;
                bool setBackgroundSpriteRedFirstValue = false;
                bool setBackgroundSpriteRedSecondValue = false;
                int BackgroundSpriteRedFirstValue= 0;
                int BackgroundSpriteRedSecondValue= 0;
                bool setSelectSpriteBlueFirstValue = false;
                bool setSelectSpriteBlueSecondValue = false;
                int SelectSpriteBlueFirstValue= 0;
                int SelectSpriteBlueSecondValue= 0;
                bool setSelectSpriteGreenFirstValue = false;
                bool setSelectSpriteGreenSecondValue = false;
                int SelectSpriteGreenFirstValue= 0;
                int SelectSpriteGreenSecondValue= 0;
                bool setSelectSpriteRedFirstValue = false;
                bool setSelectSpriteRedSecondValue = false;
                int SelectSpriteRedFirstValue= 0;
                int SelectSpriteRedSecondValue= 0;
                bool setSpriteInstanceBlueFirstValue = false;
                bool setSpriteInstanceBlueSecondValue = false;
                int SpriteInstanceBlueFirstValue= 0;
                int SpriteInstanceBlueSecondValue= 0;
                bool setSpriteInstanceGreenFirstValue = false;
                bool setSpriteInstanceGreenSecondValue = false;
                int SpriteInstanceGreenFirstValue= 0;
                int SpriteInstanceGreenSecondValue= 0;
                bool setSpriteInstanceRedFirstValue = false;
                bool setSpriteInstanceRedSecondValue = false;
                int SpriteInstanceRedFirstValue= 0;
                int SpriteInstanceRedSecondValue= 0;
                switch(firstState)
                {
                    case  Colors.Normal:
                        setBackgroundSpriteBlueFirstValue = true;
                        BackgroundSpriteBlueFirstValue = 255;
                        setBackgroundSpriteGreenFirstValue = true;
                        BackgroundSpriteGreenFirstValue = 255;
                        setBackgroundSpriteRedFirstValue = true;
                        BackgroundSpriteRedFirstValue = 255;
                        setSelectSpriteBlueFirstValue = true;
                        SelectSpriteBlueFirstValue = 255;
                        setSelectSpriteGreenFirstValue = true;
                        SelectSpriteGreenFirstValue = 255;
                        setSelectSpriteRedFirstValue = true;
                        SelectSpriteRedFirstValue = 255;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 255;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 255;
                        break;
                    case  Colors.Red:
                        setBackgroundSpriteBlueFirstValue = true;
                        BackgroundSpriteBlueFirstValue = 0;
                        setBackgroundSpriteGreenFirstValue = true;
                        BackgroundSpriteGreenFirstValue = 0;
                        setBackgroundSpriteRedFirstValue = true;
                        BackgroundSpriteRedFirstValue = 255;
                        setSelectSpriteBlueFirstValue = true;
                        SelectSpriteBlueFirstValue = 0;
                        setSelectSpriteGreenFirstValue = true;
                        SelectSpriteGreenFirstValue = 0;
                        setSelectSpriteRedFirstValue = true;
                        SelectSpriteRedFirstValue = 255;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 0;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 0;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 255;
                        break;
                    case  Colors.Green:
                        setBackgroundSpriteBlueFirstValue = true;
                        BackgroundSpriteBlueFirstValue = 0;
                        setBackgroundSpriteGreenFirstValue = true;
                        BackgroundSpriteGreenFirstValue = 255;
                        setBackgroundSpriteRedFirstValue = true;
                        BackgroundSpriteRedFirstValue = 0;
                        setSelectSpriteBlueFirstValue = true;
                        SelectSpriteBlueFirstValue = 0;
                        setSelectSpriteGreenFirstValue = true;
                        SelectSpriteGreenFirstValue = 255;
                        setSelectSpriteRedFirstValue = true;
                        SelectSpriteRedFirstValue = 0;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 0;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 0;
                        break;
                }
                switch(secondState)
                {
                    case  Colors.Normal:
                        setBackgroundSpriteBlueSecondValue = true;
                        BackgroundSpriteBlueSecondValue = 255;
                        setBackgroundSpriteGreenSecondValue = true;
                        BackgroundSpriteGreenSecondValue = 255;
                        setBackgroundSpriteRedSecondValue = true;
                        BackgroundSpriteRedSecondValue = 255;
                        setSelectSpriteBlueSecondValue = true;
                        SelectSpriteBlueSecondValue = 255;
                        setSelectSpriteGreenSecondValue = true;
                        SelectSpriteGreenSecondValue = 255;
                        setSelectSpriteRedSecondValue = true;
                        SelectSpriteRedSecondValue = 255;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 255;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 255;
                        break;
                    case  Colors.Red:
                        setBackgroundSpriteBlueSecondValue = true;
                        BackgroundSpriteBlueSecondValue = 0;
                        setBackgroundSpriteGreenSecondValue = true;
                        BackgroundSpriteGreenSecondValue = 0;
                        setBackgroundSpriteRedSecondValue = true;
                        BackgroundSpriteRedSecondValue = 255;
                        setSelectSpriteBlueSecondValue = true;
                        SelectSpriteBlueSecondValue = 0;
                        setSelectSpriteGreenSecondValue = true;
                        SelectSpriteGreenSecondValue = 0;
                        setSelectSpriteRedSecondValue = true;
                        SelectSpriteRedSecondValue = 255;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 0;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 0;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 255;
                        break;
                    case  Colors.Green:
                        setBackgroundSpriteBlueSecondValue = true;
                        BackgroundSpriteBlueSecondValue = 0;
                        setBackgroundSpriteGreenSecondValue = true;
                        BackgroundSpriteGreenSecondValue = 255;
                        setBackgroundSpriteRedSecondValue = true;
                        BackgroundSpriteRedSecondValue = 0;
                        setSelectSpriteBlueSecondValue = true;
                        SelectSpriteBlueSecondValue = 0;
                        setSelectSpriteGreenSecondValue = true;
                        SelectSpriteGreenSecondValue = 255;
                        setSelectSpriteRedSecondValue = true;
                        SelectSpriteRedSecondValue = 0;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 0;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 0;
                        break;
                }
                if (setBackgroundSpriteBlueFirstValue && setBackgroundSpriteBlueSecondValue)
                {
                    BackgroundSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundSpriteBlueFirstValue* (1 - interpolationValue) + BackgroundSpriteBlueSecondValue * interpolationValue);
                }
                if (setBackgroundSpriteGreenFirstValue && setBackgroundSpriteGreenSecondValue)
                {
                    BackgroundSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundSpriteGreenFirstValue* (1 - interpolationValue) + BackgroundSpriteGreenSecondValue * interpolationValue);
                }
                if (setBackgroundSpriteRedFirstValue && setBackgroundSpriteRedSecondValue)
                {
                    BackgroundSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundSpriteRedFirstValue* (1 - interpolationValue) + BackgroundSpriteRedSecondValue * interpolationValue);
                }
                if (setSelectSpriteBlueFirstValue && setSelectSpriteBlueSecondValue)
                {
                    SelectSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(SelectSpriteBlueFirstValue* (1 - interpolationValue) + SelectSpriteBlueSecondValue * interpolationValue);
                }
                if (setSelectSpriteGreenFirstValue && setSelectSpriteGreenSecondValue)
                {
                    SelectSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(SelectSpriteGreenFirstValue* (1 - interpolationValue) + SelectSpriteGreenSecondValue * interpolationValue);
                }
                if (setSelectSpriteRedFirstValue && setSelectSpriteRedSecondValue)
                {
                    SelectSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(SelectSpriteRedFirstValue* (1 - interpolationValue) + SelectSpriteRedSecondValue * interpolationValue);
                }
                if (setSpriteInstanceBlueFirstValue && setSpriteInstanceBlueSecondValue)
                {
                    SpriteInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceBlueFirstValue* (1 - interpolationValue) + SpriteInstanceBlueSecondValue * interpolationValue);
                }
                if (setSpriteInstanceGreenFirstValue && setSpriteInstanceGreenSecondValue)
                {
                    SpriteInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceGreenFirstValue* (1 - interpolationValue) + SpriteInstanceGreenSecondValue * interpolationValue);
                }
                if (setSpriteInstanceRedFirstValue && setSpriteInstanceRedSecondValue)
                {
                    SpriteInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceRedFirstValue* (1 - interpolationValue) + SpriteInstanceRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentColorsState = firstState;
                }
                else
                {
                    mCurrentColorsState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.Highlight fromState,AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.Highlight toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Highlight toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Highlight").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentHighlightState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Highlight toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentHighlightState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.Select fromState,AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.Select toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Select toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Select").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentSelectState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Select toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentSelectState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType fromState,AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ButtonType toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ButtonType").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentButtonTypeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ButtonType toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentButtonTypeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.Colors fromState,AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.Colors toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Colors toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Colors").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentColorsState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Colors toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentColorsState = toState;
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
                            Name = "BackgroundSprite.Height",
                            Type = "float",
                            Value = BackgroundSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.SourceFile",
                            Type = "string",
                            Value = BackgroundSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = BackgroundSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Height",
                            Type = "int",
                            Value = BackgroundSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Top",
                            Type = "int",
                            Value = BackgroundSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Width",
                            Type = "int",
                            Value = BackgroundSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Width",
                            Type = "float",
                            Value = BackgroundSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Height",
                            Type = "float",
                            Value = SelectSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SelectSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.SourceFile",
                            Type = "string",
                            Value = SelectSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SelectSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Texture Height",
                            Type = "int",
                            Value = SelectSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Texture Left",
                            Type = "int",
                            Value = SelectSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Texture Top",
                            Type = "int",
                            Value = SelectSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Texture Width",
                            Type = "int",
                            Value = SelectSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Visible",
                            Type = "bool",
                            Value = SelectSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Width",
                            Type = "float",
                            Value = SelectSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SelectSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height",
                            Type = "float",
                            Value = SpriteInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.HeightUnits
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width",
                            Type = "float",
                            Value = SpriteInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SpriteInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SpriteInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.YUnits
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
                            Value = Width + 13.647f
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
                            Name = "BackgroundSprite.Height",
                            Type = "float",
                            Value = BackgroundSprite.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.SourceFile",
                            Type = "string",
                            Value = BackgroundSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = BackgroundSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Height",
                            Type = "int",
                            Value = BackgroundSprite.TextureHeight + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Top",
                            Type = "int",
                            Value = BackgroundSprite.TextureTop + 768
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Width",
                            Type = "int",
                            Value = BackgroundSprite.TextureWidth + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Width",
                            Type = "float",
                            Value = BackgroundSprite.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Height",
                            Type = "float",
                            Value = SelectSprite.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SelectSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.SourceFile",
                            Type = "string",
                            Value = SelectSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SelectSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Texture Height",
                            Type = "int",
                            Value = SelectSprite.TextureHeight + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Texture Left",
                            Type = "int",
                            Value = SelectSprite.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Texture Top",
                            Type = "int",
                            Value = SelectSprite.TextureTop + 768
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Texture Width",
                            Type = "int",
                            Value = SelectSprite.TextureWidth + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Visible",
                            Type = "bool",
                            Value = SelectSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Width",
                            Type = "float",
                            Value = SelectSprite.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SelectSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height",
                            Type = "float",
                            Value = SpriteInstance.Height + 90f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.HeightUnits
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
                            Value = SpriteInstance.TextureHeight + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3808
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 1692
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width",
                            Type = "float",
                            Value = SpriteInstance.Width + 90f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SpriteInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SpriteInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Highlight state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Highlight.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft
                        }
                        );
                        break;
                    case  Highlight.NotHighlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Highlight state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Highlight.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft + 512
                        }
                        );
                        break;
                    case  Highlight.NotHighlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft + 0
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Select state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Select.Selected:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Visible",
                            Type = "bool",
                            Value = SelectSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        break;
                    case  Select.NotSelected:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Visible",
                            Type = "bool",
                            Value = SelectSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Select state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Select.Selected:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Visible",
                            Type = "bool",
                            Value = SelectSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 176
                        }
                        );
                        break;
                    case  Select.NotSelected:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Visible",
                            Type = "bool",
                            Value = SelectSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 255
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ButtonType state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ButtonType.Check:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.X:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.Play:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.Menu:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.Pause:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.FastForward:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.Restart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.History:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ButtonType state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ButtonType.Check:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3780
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 1675
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.X:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3550
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 1692
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.Play:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3720
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 2750
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha + 150
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3808
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 1692
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.Menu:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3707
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 3770
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.Pause:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3707
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 3005
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.FastForward:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3550
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 2212
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.Restart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3805
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 2205
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                    case  ButtonType.History:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Alpha",
                            Type = "int",
                            Value = BackgroundSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3522
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 945
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Colors state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Colors.Normal:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Blue",
                            Type = "int",
                            Value = BackgroundSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Green",
                            Type = "int",
                            Value = BackgroundSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Red",
                            Type = "int",
                            Value = BackgroundSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Blue",
                            Type = "int",
                            Value = SelectSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Green",
                            Type = "int",
                            Value = SelectSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Red",
                            Type = "int",
                            Value = SelectSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        break;
                    case  Colors.Red:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Blue",
                            Type = "int",
                            Value = BackgroundSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Green",
                            Type = "int",
                            Value = BackgroundSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Red",
                            Type = "int",
                            Value = BackgroundSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Blue",
                            Type = "int",
                            Value = SelectSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Green",
                            Type = "int",
                            Value = SelectSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Red",
                            Type = "int",
                            Value = SelectSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        break;
                    case  Colors.Green:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Blue",
                            Type = "int",
                            Value = BackgroundSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Green",
                            Type = "int",
                            Value = BackgroundSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Red",
                            Type = "int",
                            Value = BackgroundSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Blue",
                            Type = "int",
                            Value = SelectSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Green",
                            Type = "int",
                            Value = SelectSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Red",
                            Type = "int",
                            Value = SelectSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Colors state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Colors.Normal:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Blue",
                            Type = "int",
                            Value = BackgroundSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Green",
                            Type = "int",
                            Value = BackgroundSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Red",
                            Type = "int",
                            Value = BackgroundSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Blue",
                            Type = "int",
                            Value = SelectSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Green",
                            Type = "int",
                            Value = SelectSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Red",
                            Type = "int",
                            Value = SelectSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 255
                        }
                        );
                        break;
                    case  Colors.Red:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Blue",
                            Type = "int",
                            Value = BackgroundSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Green",
                            Type = "int",
                            Value = BackgroundSprite.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Red",
                            Type = "int",
                            Value = BackgroundSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Blue",
                            Type = "int",
                            Value = SelectSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Green",
                            Type = "int",
                            Value = SelectSprite.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Red",
                            Type = "int",
                            Value = SelectSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 255
                        }
                        );
                        break;
                    case  Colors.Green:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Blue",
                            Type = "int",
                            Value = BackgroundSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Green",
                            Type = "int",
                            Value = BackgroundSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Red",
                            Type = "int",
                            Value = BackgroundSprite.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Blue",
                            Type = "int",
                            Value = SelectSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Green",
                            Type = "int",
                            Value = SelectSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectSprite.Red",
                            Type = "int",
                            Value = SelectSprite.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 0
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
                    else if (category.Name == "Highlight")
                    {
                        if(state.Name == "Highlighted") this.mCurrentHighlightState = Highlight.Highlighted;
                        if(state.Name == "NotHighlighted") this.mCurrentHighlightState = Highlight.NotHighlighted;
                    }
                    else if (category.Name == "Select")
                    {
                        if(state.Name == "Selected") this.mCurrentSelectState = Select.Selected;
                        if(state.Name == "NotSelected") this.mCurrentSelectState = Select.NotSelected;
                    }
                    else if (category.Name == "ButtonType")
                    {
                        if(state.Name == "Check") this.mCurrentButtonTypeState = ButtonType.Check;
                        if(state.Name == "X") this.mCurrentButtonTypeState = ButtonType.X;
                        if(state.Name == "Play") this.mCurrentButtonTypeState = ButtonType.Play;
                        if(state.Name == "Disabled") this.mCurrentButtonTypeState = ButtonType.Disabled;
                        if(state.Name == "Menu") this.mCurrentButtonTypeState = ButtonType.Menu;
                        if(state.Name == "Pause") this.mCurrentButtonTypeState = ButtonType.Pause;
                        if(state.Name == "FastForward") this.mCurrentButtonTypeState = ButtonType.FastForward;
                        if(state.Name == "Restart") this.mCurrentButtonTypeState = ButtonType.Restart;
                        if(state.Name == "History") this.mCurrentButtonTypeState = ButtonType.History;
                    }
                    else if (category.Name == "Colors")
                    {
                        if(state.Name == "Normal") this.mCurrentColorsState = Colors.Normal;
                        if(state.Name == "Red") this.mCurrentColorsState = Colors.Red;
                        if(state.Name == "Green") this.mCurrentColorsState = Colors.Green;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BackgroundSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SelectSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            public ButtonFrameRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = true;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "frames/ButtonFrame");
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
                BackgroundSprite = this.GetGraphicalUiElementByName("BackgroundSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                SelectSprite = this.GetGraphicalUiElementByName("SelectSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
