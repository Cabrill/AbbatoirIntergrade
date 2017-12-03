    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class MessageBoxRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            Height = 50f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 50f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            X = 706f;
                            Y = 317f;
                            TopSprite.Height = 23.5f;
                            TopSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TopSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                            SetProperty("TopSprite.SourceFile", "AllUIAssets.png");
                            TopSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            TopSprite.TextureHeight = 70;
                            TopSprite.TextureLeft = 0;
                            TopSprite.TextureTop = 3552;
                            TopSprite.TextureWidth = 1320;
                            TopSprite.Width = 100f;
                            TopSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MiddleSprite1.Height = 53f;
                            MiddleSprite1.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MiddleSprite1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                            SetProperty("MiddleSprite1.SourceFile", "AllUIAssets.png");
                            MiddleSprite1.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            MiddleSprite1.TextureHeight = 159;
                            MiddleSprite1.TextureLeft = 0;
                            MiddleSprite1.TextureTop = 3648;
                            MiddleSprite1.TextureWidth = 1320;
                            MiddleSprite1.Width = 100f;
                            MiddleSprite1.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BottomSprite.Height = 23.5f;
                            BottomSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BottomSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                            SetProperty("BottomSprite.SourceFile", "AllUIAssets.png");
                            BottomSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            BottomSprite.TextureHeight = 70;
                            BottomSprite.TextureLeft = 0;
                            BottomSprite.TextureTop = 3840;
                            BottomSprite.TextureWidth = 1320;
                            BottomSprite.Width = 100f;
                            BottomSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BackgroundContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            BackgroundContainer.Height = 100f;
                            BackgroundContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BackgroundContainer.Width = 100f;
                            BackgroundContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance.Font = "SVI Basic Manual";
                            TextInstance.FontSize = 30;
                            TextInstance.Height = 86.62389f;
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance.Width = 91.03595f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance.X = 57f;
                            TextInstance.Y = 50f;
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
                bool setBackgroundContainerHeightFirstValue = false;
                bool setBackgroundContainerHeightSecondValue = false;
                float BackgroundContainerHeightFirstValue= 0;
                float BackgroundContainerHeightSecondValue= 0;
                bool setBackgroundContainerWidthFirstValue = false;
                bool setBackgroundContainerWidthSecondValue = false;
                float BackgroundContainerWidthFirstValue= 0;
                float BackgroundContainerWidthSecondValue= 0;
                bool setBottomSpriteHeightFirstValue = false;
                bool setBottomSpriteHeightSecondValue = false;
                float BottomSpriteHeightFirstValue= 0;
                float BottomSpriteHeightSecondValue= 0;
                bool setBottomSpriteTextureHeightFirstValue = false;
                bool setBottomSpriteTextureHeightSecondValue = false;
                int BottomSpriteTextureHeightFirstValue= 0;
                int BottomSpriteTextureHeightSecondValue= 0;
                bool setBottomSpriteTextureLeftFirstValue = false;
                bool setBottomSpriteTextureLeftSecondValue = false;
                int BottomSpriteTextureLeftFirstValue= 0;
                int BottomSpriteTextureLeftSecondValue= 0;
                bool setBottomSpriteTextureTopFirstValue = false;
                bool setBottomSpriteTextureTopSecondValue = false;
                int BottomSpriteTextureTopFirstValue= 0;
                int BottomSpriteTextureTopSecondValue= 0;
                bool setBottomSpriteTextureWidthFirstValue = false;
                bool setBottomSpriteTextureWidthSecondValue = false;
                int BottomSpriteTextureWidthFirstValue= 0;
                int BottomSpriteTextureWidthSecondValue= 0;
                bool setBottomSpriteWidthFirstValue = false;
                bool setBottomSpriteWidthSecondValue = false;
                float BottomSpriteWidthFirstValue= 0;
                float BottomSpriteWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMiddleSprite1HeightFirstValue = false;
                bool setMiddleSprite1HeightSecondValue = false;
                float MiddleSprite1HeightFirstValue= 0;
                float MiddleSprite1HeightSecondValue= 0;
                bool setMiddleSprite1TextureHeightFirstValue = false;
                bool setMiddleSprite1TextureHeightSecondValue = false;
                int MiddleSprite1TextureHeightFirstValue= 0;
                int MiddleSprite1TextureHeightSecondValue= 0;
                bool setMiddleSprite1TextureLeftFirstValue = false;
                bool setMiddleSprite1TextureLeftSecondValue = false;
                int MiddleSprite1TextureLeftFirstValue= 0;
                int MiddleSprite1TextureLeftSecondValue= 0;
                bool setMiddleSprite1TextureTopFirstValue = false;
                bool setMiddleSprite1TextureTopSecondValue = false;
                int MiddleSprite1TextureTopFirstValue= 0;
                int MiddleSprite1TextureTopSecondValue= 0;
                bool setMiddleSprite1TextureWidthFirstValue = false;
                bool setMiddleSprite1TextureWidthSecondValue = false;
                int MiddleSprite1TextureWidthFirstValue= 0;
                int MiddleSprite1TextureWidthSecondValue= 0;
                bool setMiddleSprite1WidthFirstValue = false;
                bool setMiddleSprite1WidthSecondValue = false;
                float MiddleSprite1WidthFirstValue= 0;
                float MiddleSprite1WidthSecondValue= 0;
                bool setTextInstanceFontSizeFirstValue = false;
                bool setTextInstanceFontSizeSecondValue = false;
                int TextInstanceFontSizeFirstValue= 0;
                int TextInstanceFontSizeSecondValue= 0;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceWidthFirstValue = false;
                bool setTextInstanceWidthSecondValue = false;
                float TextInstanceWidthFirstValue= 0;
                float TextInstanceWidthSecondValue= 0;
                bool setTextInstanceXFirstValue = false;
                bool setTextInstanceXSecondValue = false;
                float TextInstanceXFirstValue= 0;
                float TextInstanceXSecondValue= 0;
                bool setTextInstanceYFirstValue = false;
                bool setTextInstanceYSecondValue = false;
                float TextInstanceYFirstValue= 0;
                float TextInstanceYSecondValue= 0;
                bool setTopSpriteHeightFirstValue = false;
                bool setTopSpriteHeightSecondValue = false;
                float TopSpriteHeightFirstValue= 0;
                float TopSpriteHeightSecondValue= 0;
                bool setTopSpriteTextureHeightFirstValue = false;
                bool setTopSpriteTextureHeightSecondValue = false;
                int TopSpriteTextureHeightFirstValue= 0;
                int TopSpriteTextureHeightSecondValue= 0;
                bool setTopSpriteTextureLeftFirstValue = false;
                bool setTopSpriteTextureLeftSecondValue = false;
                int TopSpriteTextureLeftFirstValue= 0;
                int TopSpriteTextureLeftSecondValue= 0;
                bool setTopSpriteTextureTopFirstValue = false;
                bool setTopSpriteTextureTopSecondValue = false;
                int TopSpriteTextureTopFirstValue= 0;
                int TopSpriteTextureTopSecondValue= 0;
                bool setTopSpriteTextureWidthFirstValue = false;
                bool setTopSpriteTextureWidthSecondValue = false;
                int TopSpriteTextureWidthFirstValue= 0;
                int TopSpriteTextureWidthSecondValue= 0;
                bool setTopSpriteWidthFirstValue = false;
                bool setTopSpriteWidthSecondValue = false;
                float TopSpriteWidthFirstValue= 0;
                float TopSpriteWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setXFirstValue = false;
                bool setXSecondValue = false;
                float XFirstValue= 0;
                float XSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.BackgroundContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setBackgroundContainerHeightFirstValue = true;
                        BackgroundContainerHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBackgroundContainerWidthFirstValue = true;
                        BackgroundContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBottomSpriteHeightFirstValue = true;
                        BottomSpriteHeightFirstValue = 23.5f;
                        if (interpolationValue < 1)
                        {
                            this.BottomSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("BottomSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomSpriteTextureHeightFirstValue = true;
                        BottomSpriteTextureHeightFirstValue = 70;
                        setBottomSpriteTextureLeftFirstValue = true;
                        BottomSpriteTextureLeftFirstValue = 0;
                        setBottomSpriteTextureTopFirstValue = true;
                        BottomSpriteTextureTopFirstValue = 3840;
                        setBottomSpriteTextureWidthFirstValue = true;
                        BottomSpriteTextureWidthFirstValue = 1320;
                        setBottomSpriteWidthFirstValue = true;
                        BottomSpriteWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BottomSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMiddleSprite1HeightFirstValue = true;
                        MiddleSprite1HeightFirstValue = 53f;
                        if (interpolationValue < 1)
                        {
                            this.MiddleSprite1.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MiddleSprite1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MiddleSprite1.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MiddleSprite1.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMiddleSprite1TextureHeightFirstValue = true;
                        MiddleSprite1TextureHeightFirstValue = 159;
                        setMiddleSprite1TextureLeftFirstValue = true;
                        MiddleSprite1TextureLeftFirstValue = 0;
                        setMiddleSprite1TextureTopFirstValue = true;
                        MiddleSprite1TextureTopFirstValue = 3648;
                        setMiddleSprite1TextureWidthFirstValue = true;
                        MiddleSprite1TextureWidthFirstValue = 1320;
                        setMiddleSprite1WidthFirstValue = true;
                        MiddleSprite1WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MiddleSprite1.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Font = "SVI Basic Manual";
                        }
                        setTextInstanceFontSizeFirstValue = true;
                        TextInstanceFontSizeFirstValue = 30;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 86.62389f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 91.03595f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 57f;
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 50f;
                        setTopSpriteHeightFirstValue = true;
                        TopSpriteHeightFirstValue = 23.5f;
                        if (interpolationValue < 1)
                        {
                            this.TopSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("TopSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopSpriteTextureHeightFirstValue = true;
                        TopSpriteTextureHeightFirstValue = 70;
                        setTopSpriteTextureLeftFirstValue = true;
                        TopSpriteTextureLeftFirstValue = 0;
                        setTopSpriteTextureTopFirstValue = true;
                        TopSpriteTextureTopFirstValue = 3552;
                        setTopSpriteTextureWidthFirstValue = true;
                        TopSpriteTextureWidthFirstValue = 1320;
                        setTopSpriteWidthFirstValue = true;
                        TopSpriteWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.TopSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setXFirstValue = true;
                        XFirstValue = 706f;
                        setYFirstValue = true;
                        YFirstValue = 317f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setBackgroundContainerHeightSecondValue = true;
                        BackgroundContainerHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBackgroundContainerWidthSecondValue = true;
                        BackgroundContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBottomSpriteHeightSecondValue = true;
                        BottomSpriteHeightSecondValue = 23.5f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BottomSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomSpriteTextureHeightSecondValue = true;
                        BottomSpriteTextureHeightSecondValue = 70;
                        setBottomSpriteTextureLeftSecondValue = true;
                        BottomSpriteTextureLeftSecondValue = 0;
                        setBottomSpriteTextureTopSecondValue = true;
                        BottomSpriteTextureTopSecondValue = 3840;
                        setBottomSpriteTextureWidthSecondValue = true;
                        BottomSpriteTextureWidthSecondValue = 1320;
                        setBottomSpriteWidthSecondValue = true;
                        BottomSpriteWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMiddleSprite1HeightSecondValue = true;
                        MiddleSprite1HeightSecondValue = 53f;
                        if (interpolationValue >= 1)
                        {
                            this.MiddleSprite1.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MiddleSprite1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MiddleSprite1.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MiddleSprite1.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMiddleSprite1TextureHeightSecondValue = true;
                        MiddleSprite1TextureHeightSecondValue = 159;
                        setMiddleSprite1TextureLeftSecondValue = true;
                        MiddleSprite1TextureLeftSecondValue = 0;
                        setMiddleSprite1TextureTopSecondValue = true;
                        MiddleSprite1TextureTopSecondValue = 3648;
                        setMiddleSprite1TextureWidthSecondValue = true;
                        MiddleSprite1TextureWidthSecondValue = 1320;
                        setMiddleSprite1WidthSecondValue = true;
                        MiddleSprite1WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MiddleSprite1.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Font = "SVI Basic Manual";
                        }
                        setTextInstanceFontSizeSecondValue = true;
                        TextInstanceFontSizeSecondValue = 30;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 86.62389f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 91.03595f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 57f;
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 50f;
                        setTopSpriteHeightSecondValue = true;
                        TopSpriteHeightSecondValue = 23.5f;
                        if (interpolationValue >= 1)
                        {
                            this.TopSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TopSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopSpriteTextureHeightSecondValue = true;
                        TopSpriteTextureHeightSecondValue = 70;
                        setTopSpriteTextureLeftSecondValue = true;
                        TopSpriteTextureLeftSecondValue = 0;
                        setTopSpriteTextureTopSecondValue = true;
                        TopSpriteTextureTopSecondValue = 3552;
                        setTopSpriteTextureWidthSecondValue = true;
                        TopSpriteTextureWidthSecondValue = 1320;
                        setTopSpriteWidthSecondValue = true;
                        TopSpriteWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.TopSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setXSecondValue = true;
                        XSecondValue = 706f;
                        setYSecondValue = true;
                        YSecondValue = 317f;
                        break;
                }
                if (setBackgroundContainerHeightFirstValue && setBackgroundContainerHeightSecondValue)
                {
                    BackgroundContainer.Height = BackgroundContainerHeightFirstValue * (1 - interpolationValue) + BackgroundContainerHeightSecondValue * interpolationValue;
                }
                if (setBackgroundContainerWidthFirstValue && setBackgroundContainerWidthSecondValue)
                {
                    BackgroundContainer.Width = BackgroundContainerWidthFirstValue * (1 - interpolationValue) + BackgroundContainerWidthSecondValue * interpolationValue;
                }
                if (setBottomSpriteHeightFirstValue && setBottomSpriteHeightSecondValue)
                {
                    BottomSprite.Height = BottomSpriteHeightFirstValue * (1 - interpolationValue) + BottomSpriteHeightSecondValue * interpolationValue;
                }
                if (setBottomSpriteTextureHeightFirstValue && setBottomSpriteTextureHeightSecondValue)
                {
                    BottomSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(BottomSpriteTextureHeightFirstValue* (1 - interpolationValue) + BottomSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setBottomSpriteTextureLeftFirstValue && setBottomSpriteTextureLeftSecondValue)
                {
                    BottomSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomSpriteTextureLeftFirstValue* (1 - interpolationValue) + BottomSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomSpriteTextureTopFirstValue && setBottomSpriteTextureTopSecondValue)
                {
                    BottomSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomSpriteTextureTopFirstValue* (1 - interpolationValue) + BottomSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setBottomSpriteTextureWidthFirstValue && setBottomSpriteTextureWidthSecondValue)
                {
                    BottomSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BottomSpriteTextureWidthFirstValue* (1 - interpolationValue) + BottomSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setBottomSpriteWidthFirstValue && setBottomSpriteWidthSecondValue)
                {
                    BottomSprite.Width = BottomSpriteWidthFirstValue * (1 - interpolationValue) + BottomSpriteWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMiddleSprite1HeightFirstValue && setMiddleSprite1HeightSecondValue)
                {
                    MiddleSprite1.Height = MiddleSprite1HeightFirstValue * (1 - interpolationValue) + MiddleSprite1HeightSecondValue * interpolationValue;
                }
                if (setMiddleSprite1TextureHeightFirstValue && setMiddleSprite1TextureHeightSecondValue)
                {
                    MiddleSprite1.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleSprite1TextureHeightFirstValue* (1 - interpolationValue) + MiddleSprite1TextureHeightSecondValue * interpolationValue);
                }
                if (setMiddleSprite1TextureLeftFirstValue && setMiddleSprite1TextureLeftSecondValue)
                {
                    MiddleSprite1.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleSprite1TextureLeftFirstValue* (1 - interpolationValue) + MiddleSprite1TextureLeftSecondValue * interpolationValue);
                }
                if (setMiddleSprite1TextureTopFirstValue && setMiddleSprite1TextureTopSecondValue)
                {
                    MiddleSprite1.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleSprite1TextureTopFirstValue* (1 - interpolationValue) + MiddleSprite1TextureTopSecondValue * interpolationValue);
                }
                if (setMiddleSprite1TextureWidthFirstValue && setMiddleSprite1TextureWidthSecondValue)
                {
                    MiddleSprite1.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleSprite1TextureWidthFirstValue* (1 - interpolationValue) + MiddleSprite1TextureWidthSecondValue * interpolationValue);
                }
                if (setMiddleSprite1WidthFirstValue && setMiddleSprite1WidthSecondValue)
                {
                    MiddleSprite1.Width = MiddleSprite1WidthFirstValue * (1 - interpolationValue) + MiddleSprite1WidthSecondValue * interpolationValue;
                }
                if (setTextInstanceFontSizeFirstValue && setTextInstanceFontSizeSecondValue)
                {
                    TextInstance.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceFontSizeFirstValue* (1 - interpolationValue) + TextInstanceFontSizeSecondValue * interpolationValue);
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
                {
                    TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
                }
                if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
                {
                    TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
                }
                if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
                {
                    TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
                }
                if (setTopSpriteHeightFirstValue && setTopSpriteHeightSecondValue)
                {
                    TopSprite.Height = TopSpriteHeightFirstValue * (1 - interpolationValue) + TopSpriteHeightSecondValue * interpolationValue;
                }
                if (setTopSpriteTextureHeightFirstValue && setTopSpriteTextureHeightSecondValue)
                {
                    TopSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TopSpriteTextureHeightFirstValue* (1 - interpolationValue) + TopSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setTopSpriteTextureLeftFirstValue && setTopSpriteTextureLeftSecondValue)
                {
                    TopSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopSpriteTextureLeftFirstValue* (1 - interpolationValue) + TopSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setTopSpriteTextureTopFirstValue && setTopSpriteTextureTopSecondValue)
                {
                    TopSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopSpriteTextureTopFirstValue* (1 - interpolationValue) + TopSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setTopSpriteTextureWidthFirstValue && setTopSpriteTextureWidthSecondValue)
                {
                    TopSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TopSpriteTextureWidthFirstValue* (1 - interpolationValue) + TopSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setTopSpriteWidthFirstValue && setTopSpriteWidthSecondValue)
                {
                    TopSprite.Width = TopSpriteWidthFirstValue * (1 - interpolationValue) + TopSpriteWidthSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setXFirstValue && setXSecondValue)
                {
                    X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
                }
                if (setYFirstValue && setYSecondValue)
                {
                    Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MessageBoxRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.MessageBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
                            Name = "X",
                            Type = "float",
                            Value = X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Height",
                            Type = "float",
                            Value = TopSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Parent",
                            Type = "string",
                            Value = TopSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.SourceFile",
                            Type = "string",
                            Value = TopSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = TopSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Texture Height",
                            Type = "int",
                            Value = TopSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Texture Left",
                            Type = "int",
                            Value = TopSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Texture Top",
                            Type = "int",
                            Value = TopSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Texture Width",
                            Type = "int",
                            Value = TopSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Width",
                            Type = "float",
                            Value = TopSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Height",
                            Type = "float",
                            Value = MiddleSprite1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Height Units",
                            Type = "DimensionUnitType",
                            Value = MiddleSprite1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Parent",
                            Type = "string",
                            Value = MiddleSprite1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.SourceFile",
                            Type = "string",
                            Value = MiddleSprite1.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Texture Address",
                            Type = "TextureAddress",
                            Value = MiddleSprite1.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Texture Height",
                            Type = "int",
                            Value = MiddleSprite1.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Texture Left",
                            Type = "int",
                            Value = MiddleSprite1.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Texture Top",
                            Type = "int",
                            Value = MiddleSprite1.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Texture Width",
                            Type = "int",
                            Value = MiddleSprite1.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Width",
                            Type = "float",
                            Value = MiddleSprite1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Width Units",
                            Type = "DimensionUnitType",
                            Value = MiddleSprite1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Height",
                            Type = "float",
                            Value = BottomSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = BottomSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Parent",
                            Type = "string",
                            Value = BottomSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.SourceFile",
                            Type = "string",
                            Value = BottomSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = BottomSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Texture Height",
                            Type = "int",
                            Value = BottomSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Texture Left",
                            Type = "int",
                            Value = BottomSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Texture Top",
                            Type = "int",
                            Value = BottomSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Texture Width",
                            Type = "int",
                            Value = BottomSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Width",
                            Type = "float",
                            Value = BottomSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = BottomSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = BackgroundContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundContainer.Height",
                            Type = "float",
                            Value = BackgroundContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundContainer.Width",
                            Type = "float",
                            Value = BackgroundContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font",
                            Type = "string",
                            Value = TextInstance.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y
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
                            Name = "Height",
                            Type = "float",
                            Value = Height + 50f
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
                            Value = Width + 50f
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
                            Name = "X",
                            Type = "float",
                            Value = X + 706f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + 317f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Height",
                            Type = "float",
                            Value = TopSprite.Height + 23.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Parent",
                            Type = "string",
                            Value = TopSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.SourceFile",
                            Type = "string",
                            Value = TopSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = TopSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Texture Height",
                            Type = "int",
                            Value = TopSprite.TextureHeight + 70
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Texture Left",
                            Type = "int",
                            Value = TopSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Texture Top",
                            Type = "int",
                            Value = TopSprite.TextureTop + 3552
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Texture Width",
                            Type = "int",
                            Value = TopSprite.TextureWidth + 1320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Width",
                            Type = "float",
                            Value = TopSprite.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Height",
                            Type = "float",
                            Value = MiddleSprite1.Height + 53f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Height Units",
                            Type = "DimensionUnitType",
                            Value = MiddleSprite1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Parent",
                            Type = "string",
                            Value = MiddleSprite1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.SourceFile",
                            Type = "string",
                            Value = MiddleSprite1.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Texture Address",
                            Type = "TextureAddress",
                            Value = MiddleSprite1.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Texture Height",
                            Type = "int",
                            Value = MiddleSprite1.TextureHeight + 159
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Texture Left",
                            Type = "int",
                            Value = MiddleSprite1.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Texture Top",
                            Type = "int",
                            Value = MiddleSprite1.TextureTop + 3648
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Texture Width",
                            Type = "int",
                            Value = MiddleSprite1.TextureWidth + 1320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Width",
                            Type = "float",
                            Value = MiddleSprite1.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite1.Width Units",
                            Type = "DimensionUnitType",
                            Value = MiddleSprite1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Height",
                            Type = "float",
                            Value = BottomSprite.Height + 23.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = BottomSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Parent",
                            Type = "string",
                            Value = BottomSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.SourceFile",
                            Type = "string",
                            Value = BottomSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = BottomSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Texture Height",
                            Type = "int",
                            Value = BottomSprite.TextureHeight + 70
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Texture Left",
                            Type = "int",
                            Value = BottomSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Texture Top",
                            Type = "int",
                            Value = BottomSprite.TextureTop + 3840
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Texture Width",
                            Type = "int",
                            Value = BottomSprite.TextureWidth + 1320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Width",
                            Type = "float",
                            Value = BottomSprite.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = BottomSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = BackgroundContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundContainer.Height",
                            Type = "float",
                            Value = BackgroundContainer.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundContainer.Width",
                            Type = "float",
                            Value = BackgroundContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font",
                            Type = "string",
                            Value = TextInstance.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize + 30
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 86.62389f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 91.03595f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X + 57f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y + 50f
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
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime TopSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime MiddleSprite1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BottomSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime BackgroundContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TextInstance { get; set; }
            public string MessageText
            {
                get
                {
                    return TextInstance.Text;
                }
                set
                {
                    if (TextInstance.Text != value)
                    {
                        TextInstance.Text = value;
                        MessageTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler MessageTextChanged;
            public MessageBoxRuntime (bool fullInstantiation = true)
            	: base(false)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "frames/MessageBox");
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
                TopSprite = this.GetGraphicalUiElementByName("TopSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                MiddleSprite1 = this.GetGraphicalUiElementByName("MiddleSprite1") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                BottomSprite = this.GetGraphicalUiElementByName("BottomSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                BackgroundContainer = this.GetGraphicalUiElementByName("BackgroundContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
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
