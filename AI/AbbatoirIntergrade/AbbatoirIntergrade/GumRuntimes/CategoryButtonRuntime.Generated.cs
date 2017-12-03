    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class CategoryButtonRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Category
            {
                Utility,
                Energy,
                Combat
            }
            public enum Highlighted
            {
                True,
                False
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Category mCurrentCategoryState;
            Highlighted mCurrentHighlightedState;
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            ClipsChildren = false;
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            RingSprite.Height = 100f;
                            RingSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("RingSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            RingSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            RingSprite.TextureHeight = 512;
                            RingSprite.TextureLeft = 662;
                            RingSprite.TextureTop = 561;
                            RingSprite.TextureWidth = 512;
                            RingSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            RingSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            RingSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            RingSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            RingSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            CircleSprite.Height = 85f;
                            CircleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("CircleSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            CircleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            CircleSprite.TextureHeight = 480;
                            CircleSprite.TextureLeft = 516;
                            CircleSprite.TextureTop = 1076;
                            CircleSprite.TextureWidth = 480;
                            CircleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            CircleSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            CircleSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            CircleSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            CircleSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SymbolSprite.Height = 60f;
                            SymbolSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("SymbolSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            SymbolSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SymbolSprite.TextureHeight = 341;
                            SymbolSprite.TextureLeft = 365;
                            SymbolSprite.TextureTop = 561;
                            SymbolSprite.TextureWidth = 289;
                            SymbolSprite.Width = 83.1168f;
                            SymbolSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            SymbolSprite.X = 50f;
                            SymbolSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SymbolSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SymbolSprite.Y = 50f;
                            SymbolSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SymbolSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            break;
                    }
                }
            }
            public Category CurrentCategoryState
            {
                get
                {
                    return mCurrentCategoryState;
                }
                set
                {
                    mCurrentCategoryState = value;
                    switch(mCurrentCategoryState)
                    {
                        case  Category.Utility:
                            RingSprite.Blue = 85;
                            RingSprite.Green = 192;
                            RingSprite.Red = 111;
                            CircleSprite.Blue = 212;
                            CircleSprite.Green = 210;
                            CircleSprite.Red = 209;
                            SymbolSprite.Height = 60f;
                            SymbolSprite.TextureHeight = 254;
                            SymbolSprite.TextureLeft = 1453;
                            SymbolSprite.TextureTop = 1375;
                            SymbolSprite.TextureWidth = 260;
                            SymbolSprite.Width = 102.36f;
                            SymbolSprite.X = 52f;
                            SymbolSprite.Y = 52f;
                            break;
                        case  Category.Energy:
                            RingSprite.Blue = 0;
                            RingSprite.Green = 255;
                            RingSprite.Red = 255;
                            CircleSprite.Blue = 3;
                            CircleSprite.Green = 213;
                            CircleSprite.Red = 255;
                            SymbolSprite.Height = 60f;
                            SymbolSprite.TextureHeight = 373;
                            SymbolSprite.TextureLeft = 1308;
                            SymbolSprite.TextureTop = 158;
                            SymbolSprite.TextureWidth = 226;
                            SymbolSprite.Width = 60.589f;
                            SymbolSprite.X = 52f;
                            SymbolSprite.Y = 52f;
                            break;
                        case  Category.Combat:
                            RingSprite.Blue = 204;
                            RingSprite.Green = 155;
                            RingSprite.Red = 0;
                            CircleSprite.Blue = 236;
                            CircleSprite.Green = 207;
                            CircleSprite.Red = 113;
                            SymbolSprite.Height = 60f;
                            SymbolSprite.TextureHeight = 341;
                            SymbolSprite.TextureLeft = 365;
                            SymbolSprite.TextureTop = 561;
                            SymbolSprite.TextureWidth = 289;
                            SymbolSprite.Width = 84.75f;
                            SymbolSprite.X = 51f;
                            SymbolSprite.Y = 53f;
                            break;
                    }
                }
            }
            public Highlighted CurrentHighlightedState
            {
                get
                {
                    return mCurrentHighlightedState;
                }
                set
                {
                    mCurrentHighlightedState = value;
                    switch(mCurrentHighlightedState)
                    {
                        case  Highlighted.True:
                            RingSprite.Height = 100f;
                            break;
                        case  Highlighted.False:
                            RingSprite.Height = 0f;
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
                bool setCircleSpriteHeightFirstValue = false;
                bool setCircleSpriteHeightSecondValue = false;
                float CircleSpriteHeightFirstValue= 0;
                float CircleSpriteHeightSecondValue= 0;
                bool setCircleSpriteTextureHeightFirstValue = false;
                bool setCircleSpriteTextureHeightSecondValue = false;
                int CircleSpriteTextureHeightFirstValue= 0;
                int CircleSpriteTextureHeightSecondValue= 0;
                bool setCircleSpriteTextureLeftFirstValue = false;
                bool setCircleSpriteTextureLeftSecondValue = false;
                int CircleSpriteTextureLeftFirstValue= 0;
                int CircleSpriteTextureLeftSecondValue= 0;
                bool setCircleSpriteTextureTopFirstValue = false;
                bool setCircleSpriteTextureTopSecondValue = false;
                int CircleSpriteTextureTopFirstValue= 0;
                int CircleSpriteTextureTopSecondValue= 0;
                bool setCircleSpriteTextureWidthFirstValue = false;
                bool setCircleSpriteTextureWidthSecondValue = false;
                int CircleSpriteTextureWidthFirstValue= 0;
                int CircleSpriteTextureWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setRingSpriteHeightFirstValue = false;
                bool setRingSpriteHeightSecondValue = false;
                float RingSpriteHeightFirstValue= 0;
                float RingSpriteHeightSecondValue= 0;
                bool setRingSpriteTextureHeightFirstValue = false;
                bool setRingSpriteTextureHeightSecondValue = false;
                int RingSpriteTextureHeightFirstValue= 0;
                int RingSpriteTextureHeightSecondValue= 0;
                bool setRingSpriteTextureLeftFirstValue = false;
                bool setRingSpriteTextureLeftSecondValue = false;
                int RingSpriteTextureLeftFirstValue= 0;
                int RingSpriteTextureLeftSecondValue= 0;
                bool setRingSpriteTextureTopFirstValue = false;
                bool setRingSpriteTextureTopSecondValue = false;
                int RingSpriteTextureTopFirstValue= 0;
                int RingSpriteTextureTopSecondValue= 0;
                bool setRingSpriteTextureWidthFirstValue = false;
                bool setRingSpriteTextureWidthSecondValue = false;
                int RingSpriteTextureWidthFirstValue= 0;
                int RingSpriteTextureWidthSecondValue= 0;
                bool setSymbolSpriteHeightFirstValue = false;
                bool setSymbolSpriteHeightSecondValue = false;
                float SymbolSpriteHeightFirstValue= 0;
                float SymbolSpriteHeightSecondValue= 0;
                bool setSymbolSpriteTextureHeightFirstValue = false;
                bool setSymbolSpriteTextureHeightSecondValue = false;
                int SymbolSpriteTextureHeightFirstValue= 0;
                int SymbolSpriteTextureHeightSecondValue= 0;
                bool setSymbolSpriteTextureLeftFirstValue = false;
                bool setSymbolSpriteTextureLeftSecondValue = false;
                int SymbolSpriteTextureLeftFirstValue= 0;
                int SymbolSpriteTextureLeftSecondValue= 0;
                bool setSymbolSpriteTextureTopFirstValue = false;
                bool setSymbolSpriteTextureTopSecondValue = false;
                int SymbolSpriteTextureTopFirstValue= 0;
                int SymbolSpriteTextureTopSecondValue= 0;
                bool setSymbolSpriteTextureWidthFirstValue = false;
                bool setSymbolSpriteTextureWidthSecondValue = false;
                int SymbolSpriteTextureWidthFirstValue= 0;
                int SymbolSpriteTextureWidthSecondValue= 0;
                bool setSymbolSpriteWidthFirstValue = false;
                bool setSymbolSpriteWidthSecondValue = false;
                float SymbolSpriteWidthFirstValue= 0;
                float SymbolSpriteWidthSecondValue= 0;
                bool setSymbolSpriteXFirstValue = false;
                bool setSymbolSpriteXSecondValue = false;
                float SymbolSpriteXFirstValue= 0;
                float SymbolSpriteXSecondValue= 0;
                bool setSymbolSpriteYFirstValue = false;
                bool setSymbolSpriteYSecondValue = false;
                float SymbolSpriteYFirstValue= 0;
                float SymbolSpriteYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setCircleSpriteHeightFirstValue = true;
                        CircleSpriteHeightFirstValue = 85f;
                        if (interpolationValue < 1)
                        {
                            this.CircleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("CircleSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CircleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setCircleSpriteTextureHeightFirstValue = true;
                        CircleSpriteTextureHeightFirstValue = 480;
                        setCircleSpriteTextureLeftFirstValue = true;
                        CircleSpriteTextureLeftFirstValue = 516;
                        setCircleSpriteTextureTopFirstValue = true;
                        CircleSpriteTextureTopFirstValue = 1076;
                        setCircleSpriteTextureWidthFirstValue = true;
                        CircleSpriteTextureWidthFirstValue = 480;
                        if (interpolationValue < 1)
                        {
                            this.CircleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CircleSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CircleSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CircleSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CircleSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setRingSpriteHeightFirstValue = true;
                        RingSpriteHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.RingSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("RingSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.RingSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setRingSpriteTextureHeightFirstValue = true;
                        RingSpriteTextureHeightFirstValue = 512;
                        setRingSpriteTextureLeftFirstValue = true;
                        RingSpriteTextureLeftFirstValue = 662;
                        setRingSpriteTextureTopFirstValue = true;
                        RingSpriteTextureTopFirstValue = 561;
                        setRingSpriteTextureWidthFirstValue = true;
                        RingSpriteTextureWidthFirstValue = 512;
                        if (interpolationValue < 1)
                        {
                            this.RingSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RingSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RingSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RingSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RingSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSymbolSpriteHeightFirstValue = true;
                        SymbolSpriteHeightFirstValue = 60f;
                        if (interpolationValue < 1)
                        {
                            this.SymbolSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SymbolSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SymbolSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSymbolSpriteTextureHeightFirstValue = true;
                        SymbolSpriteTextureHeightFirstValue = 341;
                        setSymbolSpriteTextureLeftFirstValue = true;
                        SymbolSpriteTextureLeftFirstValue = 365;
                        setSymbolSpriteTextureTopFirstValue = true;
                        SymbolSpriteTextureTopFirstValue = 561;
                        setSymbolSpriteTextureWidthFirstValue = true;
                        SymbolSpriteTextureWidthFirstValue = 289;
                        setSymbolSpriteWidthFirstValue = true;
                        SymbolSpriteWidthFirstValue = 83.1168f;
                        if (interpolationValue < 1)
                        {
                            this.SymbolSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setSymbolSpriteXFirstValue = true;
                        SymbolSpriteXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.SymbolSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SymbolSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSymbolSpriteYFirstValue = true;
                        SymbolSpriteYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.SymbolSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SymbolSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setCircleSpriteHeightSecondValue = true;
                        CircleSpriteHeightSecondValue = 85f;
                        if (interpolationValue >= 1)
                        {
                            this.CircleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CircleSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CircleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setCircleSpriteTextureHeightSecondValue = true;
                        CircleSpriteTextureHeightSecondValue = 480;
                        setCircleSpriteTextureLeftSecondValue = true;
                        CircleSpriteTextureLeftSecondValue = 516;
                        setCircleSpriteTextureTopSecondValue = true;
                        CircleSpriteTextureTopSecondValue = 1076;
                        setCircleSpriteTextureWidthSecondValue = true;
                        CircleSpriteTextureWidthSecondValue = 480;
                        if (interpolationValue >= 1)
                        {
                            this.CircleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CircleSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CircleSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CircleSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CircleSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setRingSpriteHeightSecondValue = true;
                        RingSpriteHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.RingSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("RingSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RingSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setRingSpriteTextureHeightSecondValue = true;
                        RingSpriteTextureHeightSecondValue = 512;
                        setRingSpriteTextureLeftSecondValue = true;
                        RingSpriteTextureLeftSecondValue = 662;
                        setRingSpriteTextureTopSecondValue = true;
                        RingSpriteTextureTopSecondValue = 561;
                        setRingSpriteTextureWidthSecondValue = true;
                        RingSpriteTextureWidthSecondValue = 512;
                        if (interpolationValue >= 1)
                        {
                            this.RingSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RingSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RingSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RingSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RingSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSymbolSpriteHeightSecondValue = true;
                        SymbolSpriteHeightSecondValue = 60f;
                        if (interpolationValue >= 1)
                        {
                            this.SymbolSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SymbolSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SymbolSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSymbolSpriteTextureHeightSecondValue = true;
                        SymbolSpriteTextureHeightSecondValue = 341;
                        setSymbolSpriteTextureLeftSecondValue = true;
                        SymbolSpriteTextureLeftSecondValue = 365;
                        setSymbolSpriteTextureTopSecondValue = true;
                        SymbolSpriteTextureTopSecondValue = 561;
                        setSymbolSpriteTextureWidthSecondValue = true;
                        SymbolSpriteTextureWidthSecondValue = 289;
                        setSymbolSpriteWidthSecondValue = true;
                        SymbolSpriteWidthSecondValue = 83.1168f;
                        if (interpolationValue >= 1)
                        {
                            this.SymbolSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setSymbolSpriteXSecondValue = true;
                        SymbolSpriteXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.SymbolSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SymbolSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSymbolSpriteYSecondValue = true;
                        SymbolSpriteYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.SymbolSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SymbolSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                if (setCircleSpriteHeightFirstValue && setCircleSpriteHeightSecondValue)
                {
                    CircleSprite.Height = CircleSpriteHeightFirstValue * (1 - interpolationValue) + CircleSpriteHeightSecondValue * interpolationValue;
                }
                if (setCircleSpriteTextureHeightFirstValue && setCircleSpriteTextureHeightSecondValue)
                {
                    CircleSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(CircleSpriteTextureHeightFirstValue* (1 - interpolationValue) + CircleSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setCircleSpriteTextureLeftFirstValue && setCircleSpriteTextureLeftSecondValue)
                {
                    CircleSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(CircleSpriteTextureLeftFirstValue* (1 - interpolationValue) + CircleSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setCircleSpriteTextureTopFirstValue && setCircleSpriteTextureTopSecondValue)
                {
                    CircleSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(CircleSpriteTextureTopFirstValue* (1 - interpolationValue) + CircleSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setCircleSpriteTextureWidthFirstValue && setCircleSpriteTextureWidthSecondValue)
                {
                    CircleSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(CircleSpriteTextureWidthFirstValue* (1 - interpolationValue) + CircleSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setRingSpriteHeightFirstValue && setRingSpriteHeightSecondValue)
                {
                    RingSprite.Height = RingSpriteHeightFirstValue * (1 - interpolationValue) + RingSpriteHeightSecondValue * interpolationValue;
                }
                if (setRingSpriteTextureHeightFirstValue && setRingSpriteTextureHeightSecondValue)
                {
                    RingSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(RingSpriteTextureHeightFirstValue* (1 - interpolationValue) + RingSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setRingSpriteTextureLeftFirstValue && setRingSpriteTextureLeftSecondValue)
                {
                    RingSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(RingSpriteTextureLeftFirstValue* (1 - interpolationValue) + RingSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setRingSpriteTextureTopFirstValue && setRingSpriteTextureTopSecondValue)
                {
                    RingSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(RingSpriteTextureTopFirstValue* (1 - interpolationValue) + RingSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setRingSpriteTextureWidthFirstValue && setRingSpriteTextureWidthSecondValue)
                {
                    RingSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(RingSpriteTextureWidthFirstValue* (1 - interpolationValue) + RingSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setSymbolSpriteHeightFirstValue && setSymbolSpriteHeightSecondValue)
                {
                    SymbolSprite.Height = SymbolSpriteHeightFirstValue * (1 - interpolationValue) + SymbolSpriteHeightSecondValue * interpolationValue;
                }
                if (setSymbolSpriteTextureHeightFirstValue && setSymbolSpriteTextureHeightSecondValue)
                {
                    SymbolSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SymbolSpriteTextureHeightFirstValue* (1 - interpolationValue) + SymbolSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setSymbolSpriteTextureLeftFirstValue && setSymbolSpriteTextureLeftSecondValue)
                {
                    SymbolSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SymbolSpriteTextureLeftFirstValue* (1 - interpolationValue) + SymbolSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setSymbolSpriteTextureTopFirstValue && setSymbolSpriteTextureTopSecondValue)
                {
                    SymbolSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SymbolSpriteTextureTopFirstValue* (1 - interpolationValue) + SymbolSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setSymbolSpriteTextureWidthFirstValue && setSymbolSpriteTextureWidthSecondValue)
                {
                    SymbolSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SymbolSpriteTextureWidthFirstValue* (1 - interpolationValue) + SymbolSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setSymbolSpriteWidthFirstValue && setSymbolSpriteWidthSecondValue)
                {
                    SymbolSprite.Width = SymbolSpriteWidthFirstValue * (1 - interpolationValue) + SymbolSpriteWidthSecondValue * interpolationValue;
                }
                if (setSymbolSpriteXFirstValue && setSymbolSpriteXSecondValue)
                {
                    SymbolSprite.X = SymbolSpriteXFirstValue * (1 - interpolationValue) + SymbolSpriteXSecondValue * interpolationValue;
                }
                if (setSymbolSpriteYFirstValue && setSymbolSpriteYSecondValue)
                {
                    SymbolSprite.Y = SymbolSpriteYFirstValue * (1 - interpolationValue) + SymbolSpriteYSecondValue * interpolationValue;
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
            public void InterpolateBetween (Category firstState, Category secondState, float interpolationValue)
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setCircleSpriteBlueFirstValue = false;
                bool setCircleSpriteBlueSecondValue = false;
                int CircleSpriteBlueFirstValue= 0;
                int CircleSpriteBlueSecondValue= 0;
                bool setCircleSpriteGreenFirstValue = false;
                bool setCircleSpriteGreenSecondValue = false;
                int CircleSpriteGreenFirstValue= 0;
                int CircleSpriteGreenSecondValue= 0;
                bool setCircleSpriteRedFirstValue = false;
                bool setCircleSpriteRedSecondValue = false;
                int CircleSpriteRedFirstValue= 0;
                int CircleSpriteRedSecondValue= 0;
                bool setRingSpriteBlueFirstValue = false;
                bool setRingSpriteBlueSecondValue = false;
                int RingSpriteBlueFirstValue= 0;
                int RingSpriteBlueSecondValue= 0;
                bool setRingSpriteGreenFirstValue = false;
                bool setRingSpriteGreenSecondValue = false;
                int RingSpriteGreenFirstValue= 0;
                int RingSpriteGreenSecondValue= 0;
                bool setRingSpriteRedFirstValue = false;
                bool setRingSpriteRedSecondValue = false;
                int RingSpriteRedFirstValue= 0;
                int RingSpriteRedSecondValue= 0;
                bool setSymbolSpriteHeightFirstValue = false;
                bool setSymbolSpriteHeightSecondValue = false;
                float SymbolSpriteHeightFirstValue= 0;
                float SymbolSpriteHeightSecondValue= 0;
                bool setSymbolSpriteTextureHeightFirstValue = false;
                bool setSymbolSpriteTextureHeightSecondValue = false;
                int SymbolSpriteTextureHeightFirstValue= 0;
                int SymbolSpriteTextureHeightSecondValue= 0;
                bool setSymbolSpriteTextureLeftFirstValue = false;
                bool setSymbolSpriteTextureLeftSecondValue = false;
                int SymbolSpriteTextureLeftFirstValue= 0;
                int SymbolSpriteTextureLeftSecondValue= 0;
                bool setSymbolSpriteTextureTopFirstValue = false;
                bool setSymbolSpriteTextureTopSecondValue = false;
                int SymbolSpriteTextureTopFirstValue= 0;
                int SymbolSpriteTextureTopSecondValue= 0;
                bool setSymbolSpriteTextureWidthFirstValue = false;
                bool setSymbolSpriteTextureWidthSecondValue = false;
                int SymbolSpriteTextureWidthFirstValue= 0;
                int SymbolSpriteTextureWidthSecondValue= 0;
                bool setSymbolSpriteWidthFirstValue = false;
                bool setSymbolSpriteWidthSecondValue = false;
                float SymbolSpriteWidthFirstValue= 0;
                float SymbolSpriteWidthSecondValue= 0;
                bool setSymbolSpriteXFirstValue = false;
                bool setSymbolSpriteXSecondValue = false;
                float SymbolSpriteXFirstValue= 0;
                float SymbolSpriteXSecondValue= 0;
                bool setSymbolSpriteYFirstValue = false;
                bool setSymbolSpriteYSecondValue = false;
                float SymbolSpriteYFirstValue= 0;
                float SymbolSpriteYSecondValue= 0;
                switch(firstState)
                {
                    case  Category.Utility:
                        setCircleSpriteBlueFirstValue = true;
                        CircleSpriteBlueFirstValue = 212;
                        setCircleSpriteGreenFirstValue = true;
                        CircleSpriteGreenFirstValue = 210;
                        setCircleSpriteRedFirstValue = true;
                        CircleSpriteRedFirstValue = 209;
                        setRingSpriteBlueFirstValue = true;
                        RingSpriteBlueFirstValue = 85;
                        setRingSpriteGreenFirstValue = true;
                        RingSpriteGreenFirstValue = 192;
                        setRingSpriteRedFirstValue = true;
                        RingSpriteRedFirstValue = 111;
                        setSymbolSpriteHeightFirstValue = true;
                        SymbolSpriteHeightFirstValue = 60f;
                        setSymbolSpriteTextureHeightFirstValue = true;
                        SymbolSpriteTextureHeightFirstValue = 254;
                        setSymbolSpriteTextureLeftFirstValue = true;
                        SymbolSpriteTextureLeftFirstValue = 1453;
                        setSymbolSpriteTextureTopFirstValue = true;
                        SymbolSpriteTextureTopFirstValue = 1375;
                        setSymbolSpriteTextureWidthFirstValue = true;
                        SymbolSpriteTextureWidthFirstValue = 260;
                        setSymbolSpriteWidthFirstValue = true;
                        SymbolSpriteWidthFirstValue = 102.36f;
                        setSymbolSpriteXFirstValue = true;
                        SymbolSpriteXFirstValue = 52f;
                        setSymbolSpriteYFirstValue = true;
                        SymbolSpriteYFirstValue = 52f;
                        break;
                    case  Category.Energy:
                        setCircleSpriteBlueFirstValue = true;
                        CircleSpriteBlueFirstValue = 3;
                        setCircleSpriteGreenFirstValue = true;
                        CircleSpriteGreenFirstValue = 213;
                        setCircleSpriteRedFirstValue = true;
                        CircleSpriteRedFirstValue = 255;
                        setRingSpriteBlueFirstValue = true;
                        RingSpriteBlueFirstValue = 0;
                        setRingSpriteGreenFirstValue = true;
                        RingSpriteGreenFirstValue = 255;
                        setRingSpriteRedFirstValue = true;
                        RingSpriteRedFirstValue = 255;
                        setSymbolSpriteHeightFirstValue = true;
                        SymbolSpriteHeightFirstValue = 60f;
                        setSymbolSpriteTextureHeightFirstValue = true;
                        SymbolSpriteTextureHeightFirstValue = 373;
                        setSymbolSpriteTextureLeftFirstValue = true;
                        SymbolSpriteTextureLeftFirstValue = 1308;
                        setSymbolSpriteTextureTopFirstValue = true;
                        SymbolSpriteTextureTopFirstValue = 158;
                        setSymbolSpriteTextureWidthFirstValue = true;
                        SymbolSpriteTextureWidthFirstValue = 226;
                        setSymbolSpriteWidthFirstValue = true;
                        SymbolSpriteWidthFirstValue = 60.589f;
                        setSymbolSpriteXFirstValue = true;
                        SymbolSpriteXFirstValue = 52f;
                        setSymbolSpriteYFirstValue = true;
                        SymbolSpriteYFirstValue = 52f;
                        break;
                    case  Category.Combat:
                        setCircleSpriteBlueFirstValue = true;
                        CircleSpriteBlueFirstValue = 236;
                        setCircleSpriteGreenFirstValue = true;
                        CircleSpriteGreenFirstValue = 207;
                        setCircleSpriteRedFirstValue = true;
                        CircleSpriteRedFirstValue = 113;
                        setRingSpriteBlueFirstValue = true;
                        RingSpriteBlueFirstValue = 204;
                        setRingSpriteGreenFirstValue = true;
                        RingSpriteGreenFirstValue = 155;
                        setRingSpriteRedFirstValue = true;
                        RingSpriteRedFirstValue = 0;
                        setSymbolSpriteHeightFirstValue = true;
                        SymbolSpriteHeightFirstValue = 60f;
                        setSymbolSpriteTextureHeightFirstValue = true;
                        SymbolSpriteTextureHeightFirstValue = 341;
                        setSymbolSpriteTextureLeftFirstValue = true;
                        SymbolSpriteTextureLeftFirstValue = 365;
                        setSymbolSpriteTextureTopFirstValue = true;
                        SymbolSpriteTextureTopFirstValue = 561;
                        setSymbolSpriteTextureWidthFirstValue = true;
                        SymbolSpriteTextureWidthFirstValue = 289;
                        setSymbolSpriteWidthFirstValue = true;
                        SymbolSpriteWidthFirstValue = 84.75f;
                        setSymbolSpriteXFirstValue = true;
                        SymbolSpriteXFirstValue = 51f;
                        setSymbolSpriteYFirstValue = true;
                        SymbolSpriteYFirstValue = 53f;
                        break;
                }
                switch(secondState)
                {
                    case  Category.Utility:
                        setCircleSpriteBlueSecondValue = true;
                        CircleSpriteBlueSecondValue = 212;
                        setCircleSpriteGreenSecondValue = true;
                        CircleSpriteGreenSecondValue = 210;
                        setCircleSpriteRedSecondValue = true;
                        CircleSpriteRedSecondValue = 209;
                        setRingSpriteBlueSecondValue = true;
                        RingSpriteBlueSecondValue = 85;
                        setRingSpriteGreenSecondValue = true;
                        RingSpriteGreenSecondValue = 192;
                        setRingSpriteRedSecondValue = true;
                        RingSpriteRedSecondValue = 111;
                        setSymbolSpriteHeightSecondValue = true;
                        SymbolSpriteHeightSecondValue = 60f;
                        setSymbolSpriteTextureHeightSecondValue = true;
                        SymbolSpriteTextureHeightSecondValue = 254;
                        setSymbolSpriteTextureLeftSecondValue = true;
                        SymbolSpriteTextureLeftSecondValue = 1453;
                        setSymbolSpriteTextureTopSecondValue = true;
                        SymbolSpriteTextureTopSecondValue = 1375;
                        setSymbolSpriteTextureWidthSecondValue = true;
                        SymbolSpriteTextureWidthSecondValue = 260;
                        setSymbolSpriteWidthSecondValue = true;
                        SymbolSpriteWidthSecondValue = 102.36f;
                        setSymbolSpriteXSecondValue = true;
                        SymbolSpriteXSecondValue = 52f;
                        setSymbolSpriteYSecondValue = true;
                        SymbolSpriteYSecondValue = 52f;
                        break;
                    case  Category.Energy:
                        setCircleSpriteBlueSecondValue = true;
                        CircleSpriteBlueSecondValue = 3;
                        setCircleSpriteGreenSecondValue = true;
                        CircleSpriteGreenSecondValue = 213;
                        setCircleSpriteRedSecondValue = true;
                        CircleSpriteRedSecondValue = 255;
                        setRingSpriteBlueSecondValue = true;
                        RingSpriteBlueSecondValue = 0;
                        setRingSpriteGreenSecondValue = true;
                        RingSpriteGreenSecondValue = 255;
                        setRingSpriteRedSecondValue = true;
                        RingSpriteRedSecondValue = 255;
                        setSymbolSpriteHeightSecondValue = true;
                        SymbolSpriteHeightSecondValue = 60f;
                        setSymbolSpriteTextureHeightSecondValue = true;
                        SymbolSpriteTextureHeightSecondValue = 373;
                        setSymbolSpriteTextureLeftSecondValue = true;
                        SymbolSpriteTextureLeftSecondValue = 1308;
                        setSymbolSpriteTextureTopSecondValue = true;
                        SymbolSpriteTextureTopSecondValue = 158;
                        setSymbolSpriteTextureWidthSecondValue = true;
                        SymbolSpriteTextureWidthSecondValue = 226;
                        setSymbolSpriteWidthSecondValue = true;
                        SymbolSpriteWidthSecondValue = 60.589f;
                        setSymbolSpriteXSecondValue = true;
                        SymbolSpriteXSecondValue = 52f;
                        setSymbolSpriteYSecondValue = true;
                        SymbolSpriteYSecondValue = 52f;
                        break;
                    case  Category.Combat:
                        setCircleSpriteBlueSecondValue = true;
                        CircleSpriteBlueSecondValue = 236;
                        setCircleSpriteGreenSecondValue = true;
                        CircleSpriteGreenSecondValue = 207;
                        setCircleSpriteRedSecondValue = true;
                        CircleSpriteRedSecondValue = 113;
                        setRingSpriteBlueSecondValue = true;
                        RingSpriteBlueSecondValue = 204;
                        setRingSpriteGreenSecondValue = true;
                        RingSpriteGreenSecondValue = 155;
                        setRingSpriteRedSecondValue = true;
                        RingSpriteRedSecondValue = 0;
                        setSymbolSpriteHeightSecondValue = true;
                        SymbolSpriteHeightSecondValue = 60f;
                        setSymbolSpriteTextureHeightSecondValue = true;
                        SymbolSpriteTextureHeightSecondValue = 341;
                        setSymbolSpriteTextureLeftSecondValue = true;
                        SymbolSpriteTextureLeftSecondValue = 365;
                        setSymbolSpriteTextureTopSecondValue = true;
                        SymbolSpriteTextureTopSecondValue = 561;
                        setSymbolSpriteTextureWidthSecondValue = true;
                        SymbolSpriteTextureWidthSecondValue = 289;
                        setSymbolSpriteWidthSecondValue = true;
                        SymbolSpriteWidthSecondValue = 84.75f;
                        setSymbolSpriteXSecondValue = true;
                        SymbolSpriteXSecondValue = 51f;
                        setSymbolSpriteYSecondValue = true;
                        SymbolSpriteYSecondValue = 53f;
                        break;
                }
                if (setCircleSpriteBlueFirstValue && setCircleSpriteBlueSecondValue)
                {
                    CircleSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CircleSpriteBlueFirstValue* (1 - interpolationValue) + CircleSpriteBlueSecondValue * interpolationValue);
                }
                if (setCircleSpriteGreenFirstValue && setCircleSpriteGreenSecondValue)
                {
                    CircleSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CircleSpriteGreenFirstValue* (1 - interpolationValue) + CircleSpriteGreenSecondValue * interpolationValue);
                }
                if (setCircleSpriteRedFirstValue && setCircleSpriteRedSecondValue)
                {
                    CircleSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CircleSpriteRedFirstValue* (1 - interpolationValue) + CircleSpriteRedSecondValue * interpolationValue);
                }
                if (setRingSpriteBlueFirstValue && setRingSpriteBlueSecondValue)
                {
                    RingSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(RingSpriteBlueFirstValue* (1 - interpolationValue) + RingSpriteBlueSecondValue * interpolationValue);
                }
                if (setRingSpriteGreenFirstValue && setRingSpriteGreenSecondValue)
                {
                    RingSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(RingSpriteGreenFirstValue* (1 - interpolationValue) + RingSpriteGreenSecondValue * interpolationValue);
                }
                if (setRingSpriteRedFirstValue && setRingSpriteRedSecondValue)
                {
                    RingSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(RingSpriteRedFirstValue* (1 - interpolationValue) + RingSpriteRedSecondValue * interpolationValue);
                }
                if (setSymbolSpriteHeightFirstValue && setSymbolSpriteHeightSecondValue)
                {
                    SymbolSprite.Height = SymbolSpriteHeightFirstValue * (1 - interpolationValue) + SymbolSpriteHeightSecondValue * interpolationValue;
                }
                if (setSymbolSpriteTextureHeightFirstValue && setSymbolSpriteTextureHeightSecondValue)
                {
                    SymbolSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SymbolSpriteTextureHeightFirstValue* (1 - interpolationValue) + SymbolSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setSymbolSpriteTextureLeftFirstValue && setSymbolSpriteTextureLeftSecondValue)
                {
                    SymbolSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SymbolSpriteTextureLeftFirstValue* (1 - interpolationValue) + SymbolSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setSymbolSpriteTextureTopFirstValue && setSymbolSpriteTextureTopSecondValue)
                {
                    SymbolSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SymbolSpriteTextureTopFirstValue* (1 - interpolationValue) + SymbolSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setSymbolSpriteTextureWidthFirstValue && setSymbolSpriteTextureWidthSecondValue)
                {
                    SymbolSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SymbolSpriteTextureWidthFirstValue* (1 - interpolationValue) + SymbolSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setSymbolSpriteWidthFirstValue && setSymbolSpriteWidthSecondValue)
                {
                    SymbolSprite.Width = SymbolSpriteWidthFirstValue * (1 - interpolationValue) + SymbolSpriteWidthSecondValue * interpolationValue;
                }
                if (setSymbolSpriteXFirstValue && setSymbolSpriteXSecondValue)
                {
                    SymbolSprite.X = SymbolSpriteXFirstValue * (1 - interpolationValue) + SymbolSpriteXSecondValue * interpolationValue;
                }
                if (setSymbolSpriteYFirstValue && setSymbolSpriteYSecondValue)
                {
                    SymbolSprite.Y = SymbolSpriteYFirstValue * (1 - interpolationValue) + SymbolSpriteYSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentCategoryState = firstState;
                }
                else
                {
                    mCurrentCategoryState = secondState;
                }
            }
            public void InterpolateBetween (Highlighted firstState, Highlighted secondState, float interpolationValue)
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setRingSpriteHeightFirstValue = false;
                bool setRingSpriteHeightSecondValue = false;
                float RingSpriteHeightFirstValue= 0;
                float RingSpriteHeightSecondValue= 0;
                switch(firstState)
                {
                    case  Highlighted.True:
                        setRingSpriteHeightFirstValue = true;
                        RingSpriteHeightFirstValue = 100f;
                        break;
                    case  Highlighted.False:
                        setRingSpriteHeightFirstValue = true;
                        RingSpriteHeightFirstValue = 0f;
                        break;
                }
                switch(secondState)
                {
                    case  Highlighted.True:
                        setRingSpriteHeightSecondValue = true;
                        RingSpriteHeightSecondValue = 100f;
                        break;
                    case  Highlighted.False:
                        setRingSpriteHeightSecondValue = true;
                        RingSpriteHeightSecondValue = 0f;
                        break;
                }
                if (setRingSpriteHeightFirstValue && setRingSpriteHeightSecondValue)
                {
                    RingSprite.Height = RingSpriteHeightFirstValue * (1 - interpolationValue) + RingSpriteHeightSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentHighlightedState = firstState;
                }
                else
                {
                    mCurrentHighlightedState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category fromState,AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Category toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Category").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Category toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
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
                tweener.Ended += ()=> this.CurrentCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted fromState,AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Highlighted toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Highlighted").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentHighlightedState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Highlighted toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
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
                tweener.Ended += ()=> this.CurrentHighlightedState = toState;
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
                            Name = "Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Clips Children",
                            Type = "bool",
                            Value = ClipsChildren
                        }
                        );
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
                            Name = "Visible",
                            Type = "bool",
                            Value = Visible
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Height",
                            Type = "float",
                            Value = RingSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = RingSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.SourceFile",
                            Type = "string",
                            Value = RingSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = RingSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Texture Height",
                            Type = "int",
                            Value = RingSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Texture Left",
                            Type = "int",
                            Value = RingSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Texture Top",
                            Type = "int",
                            Value = RingSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Texture Width",
                            Type = "int",
                            Value = RingSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = RingSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = RingSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.X Units",
                            Type = "PositionUnitType",
                            Value = RingSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = RingSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = RingSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Height",
                            Type = "float",
                            Value = CircleSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CircleSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.SourceFile",
                            Type = "string",
                            Value = CircleSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = CircleSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Texture Height",
                            Type = "int",
                            Value = CircleSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Texture Left",
                            Type = "int",
                            Value = CircleSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Texture Top",
                            Type = "int",
                            Value = CircleSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Texture Width",
                            Type = "int",
                            Value = CircleSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CircleSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CircleSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.X Units",
                            Type = "PositionUnitType",
                            Value = CircleSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CircleSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = CircleSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Height",
                            Type = "float",
                            Value = SymbolSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SymbolSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.SourceFile",
                            Type = "string",
                            Value = SymbolSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SymbolSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Height",
                            Type = "int",
                            Value = SymbolSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Left",
                            Type = "int",
                            Value = SymbolSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Top",
                            Type = "int",
                            Value = SymbolSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Width",
                            Type = "int",
                            Value = SymbolSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Width",
                            Type = "float",
                            Value = SymbolSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SymbolSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X",
                            Type = "float",
                            Value = SymbolSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SymbolSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X Units",
                            Type = "PositionUnitType",
                            Value = SymbolSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y",
                            Type = "float",
                            Value = SymbolSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SymbolSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = SymbolSprite.YUnits
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
                            Name = "Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Clips Children",
                            Type = "bool",
                            Value = ClipsChildren
                        }
                        );
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
                            Name = "Visible",
                            Type = "bool",
                            Value = Visible
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Height",
                            Type = "float",
                            Value = RingSprite.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = RingSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.SourceFile",
                            Type = "string",
                            Value = RingSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = RingSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Texture Height",
                            Type = "int",
                            Value = RingSprite.TextureHeight + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Texture Left",
                            Type = "int",
                            Value = RingSprite.TextureLeft + 662
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Texture Top",
                            Type = "int",
                            Value = RingSprite.TextureTop + 561
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Texture Width",
                            Type = "int",
                            Value = RingSprite.TextureWidth + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = RingSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = RingSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.X Units",
                            Type = "PositionUnitType",
                            Value = RingSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = RingSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = RingSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Height",
                            Type = "float",
                            Value = CircleSprite.Height + 85f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CircleSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.SourceFile",
                            Type = "string",
                            Value = CircleSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = CircleSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Texture Height",
                            Type = "int",
                            Value = CircleSprite.TextureHeight + 480
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Texture Left",
                            Type = "int",
                            Value = CircleSprite.TextureLeft + 516
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Texture Top",
                            Type = "int",
                            Value = CircleSprite.TextureTop + 1076
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Texture Width",
                            Type = "int",
                            Value = CircleSprite.TextureWidth + 480
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CircleSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CircleSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.X Units",
                            Type = "PositionUnitType",
                            Value = CircleSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CircleSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = CircleSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Height",
                            Type = "float",
                            Value = SymbolSprite.Height + 60f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SymbolSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.SourceFile",
                            Type = "string",
                            Value = SymbolSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SymbolSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Height",
                            Type = "int",
                            Value = SymbolSprite.TextureHeight + 341
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Left",
                            Type = "int",
                            Value = SymbolSprite.TextureLeft + 365
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Top",
                            Type = "int",
                            Value = SymbolSprite.TextureTop + 561
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Width",
                            Type = "int",
                            Value = SymbolSprite.TextureWidth + 289
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Width",
                            Type = "float",
                            Value = SymbolSprite.Width + 83.1168f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SymbolSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X",
                            Type = "float",
                            Value = SymbolSprite.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SymbolSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X Units",
                            Type = "PositionUnitType",
                            Value = SymbolSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y",
                            Type = "float",
                            Value = SymbolSprite.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SymbolSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = SymbolSprite.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Category state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Category.Utility:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Blue",
                            Type = "int",
                            Value = RingSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Green",
                            Type = "int",
                            Value = RingSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Red",
                            Type = "int",
                            Value = RingSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Blue",
                            Type = "int",
                            Value = CircleSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Green",
                            Type = "int",
                            Value = CircleSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Red",
                            Type = "int",
                            Value = CircleSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Height",
                            Type = "float",
                            Value = SymbolSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Height",
                            Type = "int",
                            Value = SymbolSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Left",
                            Type = "int",
                            Value = SymbolSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Top",
                            Type = "int",
                            Value = SymbolSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Width",
                            Type = "int",
                            Value = SymbolSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Width",
                            Type = "float",
                            Value = SymbolSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X",
                            Type = "float",
                            Value = SymbolSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y",
                            Type = "float",
                            Value = SymbolSprite.Y
                        }
                        );
                        break;
                    case  Category.Energy:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Blue",
                            Type = "int",
                            Value = RingSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Green",
                            Type = "int",
                            Value = RingSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Red",
                            Type = "int",
                            Value = RingSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Blue",
                            Type = "int",
                            Value = CircleSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Green",
                            Type = "int",
                            Value = CircleSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Red",
                            Type = "int",
                            Value = CircleSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Height",
                            Type = "float",
                            Value = SymbolSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Height",
                            Type = "int",
                            Value = SymbolSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Left",
                            Type = "int",
                            Value = SymbolSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Top",
                            Type = "int",
                            Value = SymbolSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Width",
                            Type = "int",
                            Value = SymbolSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Width",
                            Type = "float",
                            Value = SymbolSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X",
                            Type = "float",
                            Value = SymbolSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y",
                            Type = "float",
                            Value = SymbolSprite.Y
                        }
                        );
                        break;
                    case  Category.Combat:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Blue",
                            Type = "int",
                            Value = RingSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Green",
                            Type = "int",
                            Value = RingSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Red",
                            Type = "int",
                            Value = RingSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Blue",
                            Type = "int",
                            Value = CircleSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Green",
                            Type = "int",
                            Value = CircleSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Red",
                            Type = "int",
                            Value = CircleSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Height",
                            Type = "float",
                            Value = SymbolSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Height",
                            Type = "int",
                            Value = SymbolSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Left",
                            Type = "int",
                            Value = SymbolSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Top",
                            Type = "int",
                            Value = SymbolSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Width",
                            Type = "int",
                            Value = SymbolSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Width",
                            Type = "float",
                            Value = SymbolSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X",
                            Type = "float",
                            Value = SymbolSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y",
                            Type = "float",
                            Value = SymbolSprite.Y
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Category state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Category.Utility:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Blue",
                            Type = "int",
                            Value = RingSprite.Blue + 85
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Green",
                            Type = "int",
                            Value = RingSprite.Green + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Red",
                            Type = "int",
                            Value = RingSprite.Red + 111
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Blue",
                            Type = "int",
                            Value = CircleSprite.Blue + 212
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Green",
                            Type = "int",
                            Value = CircleSprite.Green + 210
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Red",
                            Type = "int",
                            Value = CircleSprite.Red + 209
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Height",
                            Type = "float",
                            Value = SymbolSprite.Height + 60f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Height",
                            Type = "int",
                            Value = SymbolSprite.TextureHeight + 254
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Left",
                            Type = "int",
                            Value = SymbolSprite.TextureLeft + 1453
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Top",
                            Type = "int",
                            Value = SymbolSprite.TextureTop + 1375
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Width",
                            Type = "int",
                            Value = SymbolSprite.TextureWidth + 260
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Width",
                            Type = "float",
                            Value = SymbolSprite.Width + 102.36f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X",
                            Type = "float",
                            Value = SymbolSprite.X + 52f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y",
                            Type = "float",
                            Value = SymbolSprite.Y + 52f
                        }
                        );
                        break;
                    case  Category.Energy:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Blue",
                            Type = "int",
                            Value = RingSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Green",
                            Type = "int",
                            Value = RingSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Red",
                            Type = "int",
                            Value = RingSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Blue",
                            Type = "int",
                            Value = CircleSprite.Blue + 3
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Green",
                            Type = "int",
                            Value = CircleSprite.Green + 213
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Red",
                            Type = "int",
                            Value = CircleSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Height",
                            Type = "float",
                            Value = SymbolSprite.Height + 60f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Height",
                            Type = "int",
                            Value = SymbolSprite.TextureHeight + 373
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Left",
                            Type = "int",
                            Value = SymbolSprite.TextureLeft + 1308
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Top",
                            Type = "int",
                            Value = SymbolSprite.TextureTop + 158
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Width",
                            Type = "int",
                            Value = SymbolSprite.TextureWidth + 226
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Width",
                            Type = "float",
                            Value = SymbolSprite.Width + 60.589f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X",
                            Type = "float",
                            Value = SymbolSprite.X + 52f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y",
                            Type = "float",
                            Value = SymbolSprite.Y + 52f
                        }
                        );
                        break;
                    case  Category.Combat:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Blue",
                            Type = "int",
                            Value = RingSprite.Blue + 204
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Green",
                            Type = "int",
                            Value = RingSprite.Green + 155
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Red",
                            Type = "int",
                            Value = RingSprite.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Blue",
                            Type = "int",
                            Value = CircleSprite.Blue + 236
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Green",
                            Type = "int",
                            Value = CircleSprite.Green + 207
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleSprite.Red",
                            Type = "int",
                            Value = CircleSprite.Red + 113
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Height",
                            Type = "float",
                            Value = SymbolSprite.Height + 60f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Height",
                            Type = "int",
                            Value = SymbolSprite.TextureHeight + 341
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Left",
                            Type = "int",
                            Value = SymbolSprite.TextureLeft + 365
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Top",
                            Type = "int",
                            Value = SymbolSprite.TextureTop + 561
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Texture Width",
                            Type = "int",
                            Value = SymbolSprite.TextureWidth + 289
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Width",
                            Type = "float",
                            Value = SymbolSprite.Width + 84.75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.X",
                            Type = "float",
                            Value = SymbolSprite.X + 51f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SymbolSprite.Y",
                            Type = "float",
                            Value = SymbolSprite.Y + 53f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Highlighted state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Highlighted.True:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Height",
                            Type = "float",
                            Value = RingSprite.Height
                        }
                        );
                        break;
                    case  Highlighted.False:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Height",
                            Type = "float",
                            Value = RingSprite.Height
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Highlighted state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Highlighted.True:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Height",
                            Type = "float",
                            Value = RingSprite.Height + 100f
                        }
                        );
                        break;
                    case  Highlighted.False:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RingSprite.Height",
                            Type = "float",
                            Value = RingSprite.Height + 0f
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
                    else if (category.Name == "Category")
                    {
                        if(state.Name == "Utility") this.mCurrentCategoryState = Category.Utility;
                        if(state.Name == "Energy") this.mCurrentCategoryState = Category.Energy;
                        if(state.Name == "Combat") this.mCurrentCategoryState = Category.Combat;
                    }
                    else if (category.Name == "Highlighted")
                    {
                        if(state.Name == "True") this.mCurrentHighlightedState = Highlighted.True;
                        if(state.Name == "False") this.mCurrentHighlightedState = Highlighted.False;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime RingSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime CircleSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SymbolSprite { get; set; }
            public CategoryButtonRuntime (bool fullInstantiation = true)
            	: base(false)
            {
                this.HasEvents = true;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "CategoryButton");
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
                RingSprite = this.GetGraphicalUiElementByName("RingSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                CircleSprite = this.GetGraphicalUiElementByName("CircleSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                SymbolSprite = this.GetGraphicalUiElementByName("SymbolSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
