    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class BuildButtonRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Highlight
            {
                Highlighted,
                NotHighlighted,
                HighlightedCantAfford,
                NotHighlightedCantAfford
            }
            public enum Select
            {
                Selected,
                NotSelected
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Highlight mCurrentHighlightState;
            Select mCurrentSelectState;
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
                            Height = 24.47f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                            StructureSprite.Height = 50f;
                            StructureSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StructureSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            StructureSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            StructureSprite.Width = 50f;
                            StructureSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StructureSprite.X = 0f;
                            StructureSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            StructureSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            StructureSprite.Y = 0f;
                            StructureSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            StructureSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                            ContainerInstance.Height = 56.90496f;
                            ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ContainerInstance.Width = 56.27251f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ContainerInstance.X = 21.89936f;
                            ContainerInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ContainerInstance.Y = 21.32949f;
                            ContainerInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            break;
                    }
                }
            }
            public Highlight CurrentHighlightState
            {
                get
                {
                    return mCurrentHighlightState;
                }
                set
                {
                    mCurrentHighlightState = value;
                    switch(mCurrentHighlightState)
                    {
                        case  Highlight.Highlighted:
                            BackgroundSprite.Blue = 255;
                            BackgroundSprite.Green = 255;
                            BackgroundSprite.TextureLeft = 512;
                            break;
                        case  Highlight.NotHighlighted:
                            BackgroundSprite.Blue = 255;
                            BackgroundSprite.Green = 255;
                            BackgroundSprite.TextureLeft = 0;
                            break;
                        case  Highlight.HighlightedCantAfford:
                            BackgroundSprite.Blue = 0;
                            BackgroundSprite.Green = 0;
                            BackgroundSprite.TextureLeft = 512;
                            break;
                        case  Highlight.NotHighlightedCantAfford:
                            BackgroundSprite.Blue = 0;
                            BackgroundSprite.Green = 0;
                            BackgroundSprite.TextureLeft = 0;
                            break;
                    }
                }
            }
            public Select CurrentSelectState
            {
                get
                {
                    return mCurrentSelectState;
                }
                set
                {
                    mCurrentSelectState = value;
                    switch(mCurrentSelectState)
                    {
                        case  Select.Selected:
                            SelectSprite.Visible = true;
                            break;
                        case  Select.NotSelected:
                            SelectSprite.Visible = false;
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
                bool setContainerInstanceHeightFirstValue = false;
                bool setContainerInstanceHeightSecondValue = false;
                float ContainerInstanceHeightFirstValue= 0;
                float ContainerInstanceHeightSecondValue= 0;
                bool setContainerInstanceWidthFirstValue = false;
                bool setContainerInstanceWidthSecondValue = false;
                float ContainerInstanceWidthFirstValue= 0;
                float ContainerInstanceWidthSecondValue= 0;
                bool setContainerInstanceXFirstValue = false;
                bool setContainerInstanceXSecondValue = false;
                float ContainerInstanceXFirstValue= 0;
                float ContainerInstanceXSecondValue= 0;
                bool setContainerInstanceYFirstValue = false;
                bool setContainerInstanceYSecondValue = false;
                float ContainerInstanceYFirstValue= 0;
                float ContainerInstanceYSecondValue= 0;
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
                bool setStructureSpriteHeightFirstValue = false;
                bool setStructureSpriteHeightSecondValue = false;
                float StructureSpriteHeightFirstValue= 0;
                float StructureSpriteHeightSecondValue= 0;
                bool setStructureSpriteWidthFirstValue = false;
                bool setStructureSpriteWidthSecondValue = false;
                float StructureSpriteWidthFirstValue= 0;
                float StructureSpriteWidthSecondValue= 0;
                bool setStructureSpriteXFirstValue = false;
                bool setStructureSpriteXSecondValue = false;
                float StructureSpriteXFirstValue= 0;
                float StructureSpriteXSecondValue= 0;
                bool setStructureSpriteYFirstValue = false;
                bool setStructureSpriteYSecondValue = false;
                float StructureSpriteYFirstValue= 0;
                float StructureSpriteYSecondValue= 0;
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
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = 56.90496f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceWidthFirstValue = true;
                        ContainerInstanceWidthFirstValue = 56.27251f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceXFirstValue = true;
                        ContainerInstanceXFirstValue = 21.89936f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setContainerInstanceYFirstValue = true;
                        ContainerInstanceYFirstValue = 21.32949f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                        setStructureSpriteHeightFirstValue = true;
                        StructureSpriteHeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setStructureSpriteWidthFirstValue = true;
                        StructureSpriteWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setStructureSpriteXFirstValue = true;
                        StructureSpriteXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setStructureSpriteYFirstValue = true;
                        StructureSpriteYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
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
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = 56.90496f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceWidthSecondValue = true;
                        ContainerInstanceWidthSecondValue = 56.27251f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceXSecondValue = true;
                        ContainerInstanceXSecondValue = 21.89936f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setContainerInstanceYSecondValue = true;
                        ContainerInstanceYSecondValue = 21.32949f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                        setStructureSpriteHeightSecondValue = true;
                        StructureSpriteHeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setStructureSpriteWidthSecondValue = true;
                        StructureSpriteWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setStructureSpriteXSecondValue = true;
                        StructureSpriteXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setStructureSpriteYSecondValue = true;
                        StructureSpriteYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
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
                if (setContainerInstanceHeightFirstValue && setContainerInstanceHeightSecondValue)
                {
                    ContainerInstance.Height = ContainerInstanceHeightFirstValue * (1 - interpolationValue) + ContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setContainerInstanceWidthFirstValue && setContainerInstanceWidthSecondValue)
                {
                    ContainerInstance.Width = ContainerInstanceWidthFirstValue * (1 - interpolationValue) + ContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setContainerInstanceXFirstValue && setContainerInstanceXSecondValue)
                {
                    ContainerInstance.X = ContainerInstanceXFirstValue * (1 - interpolationValue) + ContainerInstanceXSecondValue * interpolationValue;
                }
                if (setContainerInstanceYFirstValue && setContainerInstanceYSecondValue)
                {
                    ContainerInstance.Y = ContainerInstanceYFirstValue * (1 - interpolationValue) + ContainerInstanceYSecondValue * interpolationValue;
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
                if (setStructureSpriteHeightFirstValue && setStructureSpriteHeightSecondValue)
                {
                    StructureSprite.Height = StructureSpriteHeightFirstValue * (1 - interpolationValue) + StructureSpriteHeightSecondValue * interpolationValue;
                }
                if (setStructureSpriteWidthFirstValue && setStructureSpriteWidthSecondValue)
                {
                    StructureSprite.Width = StructureSpriteWidthFirstValue * (1 - interpolationValue) + StructureSpriteWidthSecondValue * interpolationValue;
                }
                if (setStructureSpriteXFirstValue && setStructureSpriteXSecondValue)
                {
                    StructureSprite.X = StructureSpriteXFirstValue * (1 - interpolationValue) + StructureSpriteXSecondValue * interpolationValue;
                }
                if (setStructureSpriteYFirstValue && setStructureSpriteYSecondValue)
                {
                    StructureSprite.Y = StructureSpriteYFirstValue * (1 - interpolationValue) + StructureSpriteYSecondValue * interpolationValue;
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
                bool setBackgroundSpriteBlueFirstValue = false;
                bool setBackgroundSpriteBlueSecondValue = false;
                int BackgroundSpriteBlueFirstValue= 0;
                int BackgroundSpriteBlueSecondValue= 0;
                bool setBackgroundSpriteGreenFirstValue = false;
                bool setBackgroundSpriteGreenSecondValue = false;
                int BackgroundSpriteGreenFirstValue= 0;
                int BackgroundSpriteGreenSecondValue= 0;
                bool setBackgroundSpriteTextureLeftFirstValue = false;
                bool setBackgroundSpriteTextureLeftSecondValue = false;
                int BackgroundSpriteTextureLeftFirstValue= 0;
                int BackgroundSpriteTextureLeftSecondValue= 0;
                switch(firstState)
                {
                    case  Highlight.Highlighted:
                        setBackgroundSpriteBlueFirstValue = true;
                        BackgroundSpriteBlueFirstValue = 255;
                        setBackgroundSpriteGreenFirstValue = true;
                        BackgroundSpriteGreenFirstValue = 255;
                        setBackgroundSpriteTextureLeftFirstValue = true;
                        BackgroundSpriteTextureLeftFirstValue = 512;
                        break;
                    case  Highlight.NotHighlighted:
                        setBackgroundSpriteBlueFirstValue = true;
                        BackgroundSpriteBlueFirstValue = 255;
                        setBackgroundSpriteGreenFirstValue = true;
                        BackgroundSpriteGreenFirstValue = 255;
                        setBackgroundSpriteTextureLeftFirstValue = true;
                        BackgroundSpriteTextureLeftFirstValue = 0;
                        break;
                    case  Highlight.HighlightedCantAfford:
                        setBackgroundSpriteBlueFirstValue = true;
                        BackgroundSpriteBlueFirstValue = 0;
                        setBackgroundSpriteGreenFirstValue = true;
                        BackgroundSpriteGreenFirstValue = 0;
                        setBackgroundSpriteTextureLeftFirstValue = true;
                        BackgroundSpriteTextureLeftFirstValue = 512;
                        break;
                    case  Highlight.NotHighlightedCantAfford:
                        setBackgroundSpriteBlueFirstValue = true;
                        BackgroundSpriteBlueFirstValue = 0;
                        setBackgroundSpriteGreenFirstValue = true;
                        BackgroundSpriteGreenFirstValue = 0;
                        setBackgroundSpriteTextureLeftFirstValue = true;
                        BackgroundSpriteTextureLeftFirstValue = 0;
                        break;
                }
                switch(secondState)
                {
                    case  Highlight.Highlighted:
                        setBackgroundSpriteBlueSecondValue = true;
                        BackgroundSpriteBlueSecondValue = 255;
                        setBackgroundSpriteGreenSecondValue = true;
                        BackgroundSpriteGreenSecondValue = 255;
                        setBackgroundSpriteTextureLeftSecondValue = true;
                        BackgroundSpriteTextureLeftSecondValue = 512;
                        break;
                    case  Highlight.NotHighlighted:
                        setBackgroundSpriteBlueSecondValue = true;
                        BackgroundSpriteBlueSecondValue = 255;
                        setBackgroundSpriteGreenSecondValue = true;
                        BackgroundSpriteGreenSecondValue = 255;
                        setBackgroundSpriteTextureLeftSecondValue = true;
                        BackgroundSpriteTextureLeftSecondValue = 0;
                        break;
                    case  Highlight.HighlightedCantAfford:
                        setBackgroundSpriteBlueSecondValue = true;
                        BackgroundSpriteBlueSecondValue = 0;
                        setBackgroundSpriteGreenSecondValue = true;
                        BackgroundSpriteGreenSecondValue = 0;
                        setBackgroundSpriteTextureLeftSecondValue = true;
                        BackgroundSpriteTextureLeftSecondValue = 512;
                        break;
                    case  Highlight.NotHighlightedCantAfford:
                        setBackgroundSpriteBlueSecondValue = true;
                        BackgroundSpriteBlueSecondValue = 0;
                        setBackgroundSpriteGreenSecondValue = true;
                        BackgroundSpriteGreenSecondValue = 0;
                        setBackgroundSpriteTextureLeftSecondValue = true;
                        BackgroundSpriteTextureLeftSecondValue = 0;
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
                switch(firstState)
                {
                    case  Select.Selected:
                        if (interpolationValue < 1)
                        {
                            this.SelectSprite.Visible = true;
                        }
                        break;
                    case  Select.NotSelected:
                        if (interpolationValue < 1)
                        {
                            this.SelectSprite.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  Select.Selected:
                        if (interpolationValue >= 1)
                        {
                            this.SelectSprite.Visible = true;
                        }
                        break;
                    case  Select.NotSelected:
                        if (interpolationValue >= 1)
                        {
                            this.SelectSprite.Visible = false;
                        }
                        break;
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
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.Highlight fromState,AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.Highlight toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.Select fromState,AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.Select toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "StructureSprite.Height",
                            Type = "float",
                            Value = StructureSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = StructureSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Parent",
                            Type = "string",
                            Value = StructureSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = StructureSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Width",
                            Type = "float",
                            Value = StructureSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = StructureSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.X",
                            Type = "float",
                            Value = StructureSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StructureSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.X Units",
                            Type = "PositionUnitType",
                            Value = StructureSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y",
                            Type = "float",
                            Value = StructureSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StructureSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = StructureSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X",
                            Type = "float",
                            Value = ContainerInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ContainerInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ContainerInstance.YUnits
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
                            Value = Height + 24.47f
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
                            Name = "StructureSprite.Height",
                            Type = "float",
                            Value = StructureSprite.Height + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = StructureSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Parent",
                            Type = "string",
                            Value = StructureSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = StructureSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Width",
                            Type = "float",
                            Value = StructureSprite.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = StructureSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.X",
                            Type = "float",
                            Value = StructureSprite.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StructureSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.X Units",
                            Type = "PositionUnitType",
                            Value = StructureSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y",
                            Type = "float",
                            Value = StructureSprite.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StructureSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = StructureSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height + 56.90496f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width + 56.27251f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X",
                            Type = "float",
                            Value = ContainerInstance.X + 21.89936f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ContainerInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y + 21.32949f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ContainerInstance.YUnits
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
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft
                        }
                        );
                        break;
                    case  Highlight.HighlightedCantAfford:
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
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft
                        }
                        );
                        break;
                    case  Highlight.NotHighlightedCantAfford:
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
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft + 0
                        }
                        );
                        break;
                    case  Highlight.HighlightedCantAfford:
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
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft + 512
                        }
                        );
                        break;
                    case  Highlight.NotHighlightedCantAfford:
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
                        if(state.Name == "HighlightedCantAfford") this.mCurrentHighlightState = Highlight.HighlightedCantAfford;
                        if(state.Name == "NotHighlightedCantAfford") this.mCurrentHighlightState = Highlight.NotHighlightedCantAfford;
                    }
                    else if (category.Name == "Select")
                    {
                        if(state.Name == "Selected") this.mCurrentSelectState = Select.Selected;
                        if(state.Name == "NotSelected") this.mCurrentSelectState = Select.NotSelected;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BackgroundSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SelectSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime StructureSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            public BuildButtonRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = true;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "SpecificButtons/BuildButton");
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
                StructureSprite = this.GetGraphicalUiElementByName("StructureSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
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
