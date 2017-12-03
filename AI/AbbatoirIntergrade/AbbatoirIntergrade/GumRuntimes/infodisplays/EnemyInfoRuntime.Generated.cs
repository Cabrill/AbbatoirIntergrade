    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class EnemyInfoRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum HasMelee
            {
                True,
                False
            }
            public enum HasRanged
            {
                True,
                False
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            HasMelee mCurrentHasMeleeState;
            HasRanged mCurrentHasRangedState;
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
                            Height = 35.55556f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 20f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                            StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            StatsContainer.Height = 88.80209f;
                            StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TallInfoFrameInstance");
                            StatsContainer.Width = 67.44791f;
                            StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StatsContainer.WrapsChildren = true;
                            StatsContainer.X = 83f;
                            StatsContainer.Y = 29f;
                            NameContainer.Height = 20f;
                            NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                            NameContainer.Width = 100f;
                            NameContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("NameText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            NameText.Font = "Moire ExtraBold";
                            NameText.FontScale = 0.8f;
                            NameText.FontSize = 50;
                            NameText.Height = 100f;
                            NameText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NameText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            NameText.OutlineThickness = 2;
                            NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer");
                            NameText.Text = "Enemy";
                            NameText.UseCustomFont = true;
                            NameText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            NameText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NameText.X = 0f;
                            NameText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            NameText.Y = 0f;
                            NameText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            HealthContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            HealthContainer.Height = 20f;
                            HealthContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            HealthContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                            HealthContainer.Width = 100f;
                            HealthContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            HealthSprite.Height = 100f;
                            HealthSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            HealthSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "HealthContainer");
                            SetProperty("HealthSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            HealthSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            HealthSprite.TextureHeight = 64;
                            HealthSprite.TextureLeft = 68;
                            HealthSprite.TextureTop = 29;
                            HealthSprite.TextureWidth = 64;
                            HealthSprite.Width = 20f;
                            HealthSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            HealthSprite.X = 5f;
                            HealthSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("HealthText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            HealthText.Font = "Moire ExtraBold";
                            HealthText.FontScale = 0.8f;
                            HealthText.FontSize = 50;
                            HealthText.Height = 100f;
                            HealthText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            HealthText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            HealthText.OutlineThickness = 2;
                            HealthText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "HealthContainer");
                            HealthText.Text = "0";
                            HealthText.UseCustomFont = true;
                            HealthText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            HealthText.Width = 70f;
                            HealthText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MeleeContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            MeleeContainer.Height = 20f;
                            MeleeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MeleeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                            MeleeContainer.Width = 100f;
                            MeleeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MeleeSprite.Height = 100f;
                            MeleeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MeleeSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MeleeContainer");
                            SetProperty("MeleeSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            MeleeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            MeleeSprite.TextureHeight = 64;
                            MeleeSprite.TextureLeft = 132;
                            MeleeSprite.TextureTop = 29;
                            MeleeSprite.TextureWidth = 64;
                            MeleeSprite.Width = 20f;
                            MeleeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MeleeSprite.X = 5f;
                            MeleeSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("MeleeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            MeleeText.Font = "Moire ExtraBold";
                            MeleeText.FontScale = 0.8f;
                            MeleeText.FontSize = 50;
                            MeleeText.Height = 100f;
                            MeleeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MeleeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MeleeText.OutlineThickness = 2;
                            MeleeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MeleeContainer");
                            MeleeText.Text = "0";
                            MeleeText.UseCustomFont = true;
                            MeleeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MeleeText.Width = 70f;
                            MeleeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RangedContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            RangedContainer.Height = 20f;
                            RangedContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RangedContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                            RangedContainer.Width = 100f;
                            RangedContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RangedSprite.Height = 100f;
                            RangedSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RangedSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangedContainer");
                            SetProperty("RangedSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            RangedSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            RangedSprite.TextureHeight = 64;
                            RangedSprite.TextureLeft = 196;
                            RangedSprite.TextureTop = 29;
                            RangedSprite.TextureWidth = 64;
                            RangedSprite.Width = 20f;
                            RangedSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RangedSprite.X = 5f;
                            RangedSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("RangedText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            RangedText.Font = "Moire ExtraBold";
                            RangedText.FontScale = 0.8f;
                            RangedText.FontSize = 50;
                            RangedText.Height = 100f;
                            RangedText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RangedText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            RangedText.OutlineThickness = 2;
                            RangedText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangedContainer");
                            RangedText.Text = "0";
                            RangedText.UseCustomFont = true;
                            RangedText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            RangedText.Width = 70f;
                            RangedText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TallInfoFrameInstance.Height = 100f;
                            TallInfoFrameInstance.Width = 100f;
                            break;
                    }
                }
            }
            public HasMelee CurrentHasMeleeState
            {
                get
                {
                    return mCurrentHasMeleeState;
                }
                set
                {
                    mCurrentHasMeleeState = value;
                    switch(mCurrentHasMeleeState)
                    {
                        case  HasMelee.True:
                            MeleeContainer.Height = 20f;
                            MeleeContainer.Visible = true;
                            break;
                        case  HasMelee.False:
                            MeleeContainer.Height = 0f;
                            MeleeContainer.Visible = false;
                            break;
                    }
                }
            }
            public HasRanged CurrentHasRangedState
            {
                get
                {
                    return mCurrentHasRangedState;
                }
                set
                {
                    mCurrentHasRangedState = value;
                    switch(mCurrentHasRangedState)
                    {
                        case  HasRanged.True:
                            RangedContainer.Height = 20f;
                            RangedContainer.Visible = true;
                            break;
                        case  HasRanged.False:
                            RangedContainer.Height = 0f;
                            RangedContainer.Visible = false;
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
                bool setHealthContainerHeightFirstValue = false;
                bool setHealthContainerHeightSecondValue = false;
                float HealthContainerHeightFirstValue= 0;
                float HealthContainerHeightSecondValue= 0;
                bool setHealthContainerWidthFirstValue = false;
                bool setHealthContainerWidthSecondValue = false;
                float HealthContainerWidthFirstValue= 0;
                float HealthContainerWidthSecondValue= 0;
                bool setHealthSpriteHeightFirstValue = false;
                bool setHealthSpriteHeightSecondValue = false;
                float HealthSpriteHeightFirstValue= 0;
                float HealthSpriteHeightSecondValue= 0;
                bool setHealthSpriteTextureHeightFirstValue = false;
                bool setHealthSpriteTextureHeightSecondValue = false;
                int HealthSpriteTextureHeightFirstValue= 0;
                int HealthSpriteTextureHeightSecondValue= 0;
                bool setHealthSpriteTextureLeftFirstValue = false;
                bool setHealthSpriteTextureLeftSecondValue = false;
                int HealthSpriteTextureLeftFirstValue= 0;
                int HealthSpriteTextureLeftSecondValue= 0;
                bool setHealthSpriteTextureTopFirstValue = false;
                bool setHealthSpriteTextureTopSecondValue = false;
                int HealthSpriteTextureTopFirstValue= 0;
                int HealthSpriteTextureTopSecondValue= 0;
                bool setHealthSpriteTextureWidthFirstValue = false;
                bool setHealthSpriteTextureWidthSecondValue = false;
                int HealthSpriteTextureWidthFirstValue= 0;
                int HealthSpriteTextureWidthSecondValue= 0;
                bool setHealthSpriteWidthFirstValue = false;
                bool setHealthSpriteWidthSecondValue = false;
                float HealthSpriteWidthFirstValue= 0;
                float HealthSpriteWidthSecondValue= 0;
                bool setHealthSpriteXFirstValue = false;
                bool setHealthSpriteXSecondValue = false;
                float HealthSpriteXFirstValue= 0;
                float HealthSpriteXSecondValue= 0;
                bool setHealthTextFontScaleFirstValue = false;
                bool setHealthTextFontScaleSecondValue = false;
                float HealthTextFontScaleFirstValue= 0;
                float HealthTextFontScaleSecondValue= 0;
                bool setHealthTextFontSizeFirstValue = false;
                bool setHealthTextFontSizeSecondValue = false;
                int HealthTextFontSizeFirstValue= 0;
                int HealthTextFontSizeSecondValue= 0;
                bool setHealthTextHeightFirstValue = false;
                bool setHealthTextHeightSecondValue = false;
                float HealthTextHeightFirstValue= 0;
                float HealthTextHeightSecondValue= 0;
                bool setHealthTextOutlineThicknessFirstValue = false;
                bool setHealthTextOutlineThicknessSecondValue = false;
                int HealthTextOutlineThicknessFirstValue= 0;
                int HealthTextOutlineThicknessSecondValue= 0;
                bool setHealthTextWidthFirstValue = false;
                bool setHealthTextWidthSecondValue = false;
                float HealthTextWidthFirstValue= 0;
                float HealthTextWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMeleeContainerHeightFirstValue = false;
                bool setMeleeContainerHeightSecondValue = false;
                float MeleeContainerHeightFirstValue= 0;
                float MeleeContainerHeightSecondValue= 0;
                bool setMeleeContainerWidthFirstValue = false;
                bool setMeleeContainerWidthSecondValue = false;
                float MeleeContainerWidthFirstValue= 0;
                float MeleeContainerWidthSecondValue= 0;
                bool setMeleeSpriteHeightFirstValue = false;
                bool setMeleeSpriteHeightSecondValue = false;
                float MeleeSpriteHeightFirstValue= 0;
                float MeleeSpriteHeightSecondValue= 0;
                bool setMeleeSpriteTextureHeightFirstValue = false;
                bool setMeleeSpriteTextureHeightSecondValue = false;
                int MeleeSpriteTextureHeightFirstValue= 0;
                int MeleeSpriteTextureHeightSecondValue= 0;
                bool setMeleeSpriteTextureLeftFirstValue = false;
                bool setMeleeSpriteTextureLeftSecondValue = false;
                int MeleeSpriteTextureLeftFirstValue= 0;
                int MeleeSpriteTextureLeftSecondValue= 0;
                bool setMeleeSpriteTextureTopFirstValue = false;
                bool setMeleeSpriteTextureTopSecondValue = false;
                int MeleeSpriteTextureTopFirstValue= 0;
                int MeleeSpriteTextureTopSecondValue= 0;
                bool setMeleeSpriteTextureWidthFirstValue = false;
                bool setMeleeSpriteTextureWidthSecondValue = false;
                int MeleeSpriteTextureWidthFirstValue= 0;
                int MeleeSpriteTextureWidthSecondValue= 0;
                bool setMeleeSpriteWidthFirstValue = false;
                bool setMeleeSpriteWidthSecondValue = false;
                float MeleeSpriteWidthFirstValue= 0;
                float MeleeSpriteWidthSecondValue= 0;
                bool setMeleeSpriteXFirstValue = false;
                bool setMeleeSpriteXSecondValue = false;
                float MeleeSpriteXFirstValue= 0;
                float MeleeSpriteXSecondValue= 0;
                bool setMeleeTextFontScaleFirstValue = false;
                bool setMeleeTextFontScaleSecondValue = false;
                float MeleeTextFontScaleFirstValue= 0;
                float MeleeTextFontScaleSecondValue= 0;
                bool setMeleeTextFontSizeFirstValue = false;
                bool setMeleeTextFontSizeSecondValue = false;
                int MeleeTextFontSizeFirstValue= 0;
                int MeleeTextFontSizeSecondValue= 0;
                bool setMeleeTextHeightFirstValue = false;
                bool setMeleeTextHeightSecondValue = false;
                float MeleeTextHeightFirstValue= 0;
                float MeleeTextHeightSecondValue= 0;
                bool setMeleeTextOutlineThicknessFirstValue = false;
                bool setMeleeTextOutlineThicknessSecondValue = false;
                int MeleeTextOutlineThicknessFirstValue= 0;
                int MeleeTextOutlineThicknessSecondValue= 0;
                bool setMeleeTextWidthFirstValue = false;
                bool setMeleeTextWidthSecondValue = false;
                float MeleeTextWidthFirstValue= 0;
                float MeleeTextWidthSecondValue= 0;
                bool setNameContainerHeightFirstValue = false;
                bool setNameContainerHeightSecondValue = false;
                float NameContainerHeightFirstValue= 0;
                float NameContainerHeightSecondValue= 0;
                bool setNameContainerWidthFirstValue = false;
                bool setNameContainerWidthSecondValue = false;
                float NameContainerWidthFirstValue= 0;
                float NameContainerWidthSecondValue= 0;
                bool setNameTextFontScaleFirstValue = false;
                bool setNameTextFontScaleSecondValue = false;
                float NameTextFontScaleFirstValue= 0;
                float NameTextFontScaleSecondValue= 0;
                bool setNameTextFontSizeFirstValue = false;
                bool setNameTextFontSizeSecondValue = false;
                int NameTextFontSizeFirstValue= 0;
                int NameTextFontSizeSecondValue= 0;
                bool setNameTextHeightFirstValue = false;
                bool setNameTextHeightSecondValue = false;
                float NameTextHeightFirstValue= 0;
                float NameTextHeightSecondValue= 0;
                bool setNameTextOutlineThicknessFirstValue = false;
                bool setNameTextOutlineThicknessSecondValue = false;
                int NameTextOutlineThicknessFirstValue= 0;
                int NameTextOutlineThicknessSecondValue= 0;
                bool setNameTextXFirstValue = false;
                bool setNameTextXSecondValue = false;
                float NameTextXFirstValue= 0;
                float NameTextXSecondValue= 0;
                bool setNameTextYFirstValue = false;
                bool setNameTextYSecondValue = false;
                float NameTextYFirstValue= 0;
                float NameTextYSecondValue= 0;
                bool setRangedContainerHeightFirstValue = false;
                bool setRangedContainerHeightSecondValue = false;
                float RangedContainerHeightFirstValue= 0;
                float RangedContainerHeightSecondValue= 0;
                bool setRangedContainerWidthFirstValue = false;
                bool setRangedContainerWidthSecondValue = false;
                float RangedContainerWidthFirstValue= 0;
                float RangedContainerWidthSecondValue= 0;
                bool setRangedSpriteHeightFirstValue = false;
                bool setRangedSpriteHeightSecondValue = false;
                float RangedSpriteHeightFirstValue= 0;
                float RangedSpriteHeightSecondValue= 0;
                bool setRangedSpriteTextureHeightFirstValue = false;
                bool setRangedSpriteTextureHeightSecondValue = false;
                int RangedSpriteTextureHeightFirstValue= 0;
                int RangedSpriteTextureHeightSecondValue= 0;
                bool setRangedSpriteTextureLeftFirstValue = false;
                bool setRangedSpriteTextureLeftSecondValue = false;
                int RangedSpriteTextureLeftFirstValue= 0;
                int RangedSpriteTextureLeftSecondValue= 0;
                bool setRangedSpriteTextureTopFirstValue = false;
                bool setRangedSpriteTextureTopSecondValue = false;
                int RangedSpriteTextureTopFirstValue= 0;
                int RangedSpriteTextureTopSecondValue= 0;
                bool setRangedSpriteTextureWidthFirstValue = false;
                bool setRangedSpriteTextureWidthSecondValue = false;
                int RangedSpriteTextureWidthFirstValue= 0;
                int RangedSpriteTextureWidthSecondValue= 0;
                bool setRangedSpriteWidthFirstValue = false;
                bool setRangedSpriteWidthSecondValue = false;
                float RangedSpriteWidthFirstValue= 0;
                float RangedSpriteWidthSecondValue= 0;
                bool setRangedSpriteXFirstValue = false;
                bool setRangedSpriteXSecondValue = false;
                float RangedSpriteXFirstValue= 0;
                float RangedSpriteXSecondValue= 0;
                bool setRangedTextFontScaleFirstValue = false;
                bool setRangedTextFontScaleSecondValue = false;
                float RangedTextFontScaleFirstValue= 0;
                float RangedTextFontScaleSecondValue= 0;
                bool setRangedTextFontSizeFirstValue = false;
                bool setRangedTextFontSizeSecondValue = false;
                int RangedTextFontSizeFirstValue= 0;
                int RangedTextFontSizeSecondValue= 0;
                bool setRangedTextHeightFirstValue = false;
                bool setRangedTextHeightSecondValue = false;
                float RangedTextHeightFirstValue= 0;
                float RangedTextHeightSecondValue= 0;
                bool setRangedTextOutlineThicknessFirstValue = false;
                bool setRangedTextOutlineThicknessSecondValue = false;
                int RangedTextOutlineThicknessFirstValue= 0;
                int RangedTextOutlineThicknessSecondValue= 0;
                bool setRangedTextWidthFirstValue = false;
                bool setRangedTextWidthSecondValue = false;
                float RangedTextWidthFirstValue= 0;
                float RangedTextWidthSecondValue= 0;
                bool setStatsContainerHeightFirstValue = false;
                bool setStatsContainerHeightSecondValue = false;
                float StatsContainerHeightFirstValue= 0;
                float StatsContainerHeightSecondValue= 0;
                bool setStatsContainerWidthFirstValue = false;
                bool setStatsContainerWidthSecondValue = false;
                float StatsContainerWidthFirstValue= 0;
                float StatsContainerWidthSecondValue= 0;
                bool setStatsContainerXFirstValue = false;
                bool setStatsContainerXSecondValue = false;
                float StatsContainerXFirstValue= 0;
                float StatsContainerXSecondValue= 0;
                bool setStatsContainerYFirstValue = false;
                bool setStatsContainerYSecondValue = false;
                float StatsContainerYFirstValue= 0;
                float StatsContainerYSecondValue= 0;
                bool setTallInfoFrameInstanceHeightFirstValue = false;
                bool setTallInfoFrameInstanceHeightSecondValue = false;
                float TallInfoFrameInstanceHeightFirstValue= 0;
                float TallInfoFrameInstanceHeightSecondValue= 0;
                bool setTallInfoFrameInstanceWidthFirstValue = false;
                bool setTallInfoFrameInstanceWidthSecondValue = false;
                float TallInfoFrameInstanceWidthFirstValue= 0;
                float TallInfoFrameInstanceWidthSecondValue= 0;
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
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setHealthContainerHeightFirstValue = true;
                        HealthContainerHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.HealthContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setHealthContainerWidthFirstValue = true;
                        HealthContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HealthContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHealthSpriteHeightFirstValue = true;
                        HealthSpriteHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HealthSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "HealthContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("HealthSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setHealthSpriteTextureHeightFirstValue = true;
                        HealthSpriteTextureHeightFirstValue = 64;
                        setHealthSpriteTextureLeftFirstValue = true;
                        HealthSpriteTextureLeftFirstValue = 68;
                        setHealthSpriteTextureTopFirstValue = true;
                        HealthSpriteTextureTopFirstValue = 29;
                        setHealthSpriteTextureWidthFirstValue = true;
                        HealthSpriteTextureWidthFirstValue = 64;
                        setHealthSpriteWidthFirstValue = true;
                        HealthSpriteWidthFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.HealthSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHealthSpriteXFirstValue = true;
                        HealthSpriteXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.HealthSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("HealthText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthText.Font = "Moire ExtraBold";
                        }
                        setHealthTextFontScaleFirstValue = true;
                        HealthTextFontScaleFirstValue = 0.8f;
                        setHealthTextFontSizeFirstValue = true;
                        HealthTextFontSizeFirstValue = 50;
                        setHealthTextHeightFirstValue = true;
                        HealthTextHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HealthText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setHealthTextOutlineThicknessFirstValue = true;
                        HealthTextOutlineThicknessFirstValue = 2;
                        if (interpolationValue < 1)
                        {
                            this.HealthText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "HealthContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthText.Text = "0";
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setHealthTextWidthFirstValue = true;
                        HealthTextWidthFirstValue = 70f;
                        if (interpolationValue < 1)
                        {
                            this.HealthText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 35.55556f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MeleeContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setMeleeContainerHeightFirstValue = true;
                        MeleeContainerHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.MeleeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MeleeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setMeleeContainerWidthFirstValue = true;
                        MeleeContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MeleeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMeleeSpriteHeightFirstValue = true;
                        MeleeSpriteHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MeleeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MeleeSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MeleeContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MeleeSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MeleeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMeleeSpriteTextureHeightFirstValue = true;
                        MeleeSpriteTextureHeightFirstValue = 64;
                        setMeleeSpriteTextureLeftFirstValue = true;
                        MeleeSpriteTextureLeftFirstValue = 132;
                        setMeleeSpriteTextureTopFirstValue = true;
                        MeleeSpriteTextureTopFirstValue = 29;
                        setMeleeSpriteTextureWidthFirstValue = true;
                        MeleeSpriteTextureWidthFirstValue = 64;
                        setMeleeSpriteWidthFirstValue = true;
                        MeleeSpriteWidthFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.MeleeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMeleeSpriteXFirstValue = true;
                        MeleeSpriteXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.MeleeSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MeleeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MeleeText.Font = "Moire ExtraBold";
                        }
                        setMeleeTextFontScaleFirstValue = true;
                        MeleeTextFontScaleFirstValue = 0.8f;
                        setMeleeTextFontSizeFirstValue = true;
                        MeleeTextFontSizeFirstValue = 50;
                        setMeleeTextHeightFirstValue = true;
                        MeleeTextHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MeleeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MeleeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setMeleeTextOutlineThicknessFirstValue = true;
                        MeleeTextOutlineThicknessFirstValue = 2;
                        if (interpolationValue < 1)
                        {
                            this.MeleeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MeleeContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MeleeText.Text = "0";
                        }
                        if (interpolationValue < 1)
                        {
                            this.MeleeText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MeleeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMeleeTextWidthFirstValue = true;
                        MeleeTextWidthFirstValue = 70f;
                        if (interpolationValue < 1)
                        {
                            this.MeleeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNameContainerHeightFirstValue = true;
                        NameContainerHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setNameContainerWidthFirstValue = true;
                        NameContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("NameText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.Font = "Moire ExtraBold";
                        }
                        setNameTextFontScaleFirstValue = true;
                        NameTextFontScaleFirstValue = 0.8f;
                        setNameTextFontSizeFirstValue = true;
                        NameTextFontSizeFirstValue = 50;
                        setNameTextHeightFirstValue = true;
                        NameTextHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.NameText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setNameTextOutlineThicknessFirstValue = true;
                        NameTextOutlineThicknessFirstValue = 2;
                        if (interpolationValue < 1)
                        {
                            this.NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.Text = "Enemy";
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNameTextXFirstValue = true;
                        NameTextXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NameText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setNameTextYFirstValue = true;
                        NameTextYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NameText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangedContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRangedContainerHeightFirstValue = true;
                        RangedContainerHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.RangedContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangedContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setRangedContainerWidthFirstValue = true;
                        RangedContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.RangedContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setRangedSpriteHeightFirstValue = true;
                        RangedSpriteHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.RangedSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangedSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangedContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("RangedSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangedSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setRangedSpriteTextureHeightFirstValue = true;
                        RangedSpriteTextureHeightFirstValue = 64;
                        setRangedSpriteTextureLeftFirstValue = true;
                        RangedSpriteTextureLeftFirstValue = 196;
                        setRangedSpriteTextureTopFirstValue = true;
                        RangedSpriteTextureTopFirstValue = 29;
                        setRangedSpriteTextureWidthFirstValue = true;
                        RangedSpriteTextureWidthFirstValue = 64;
                        setRangedSpriteWidthFirstValue = true;
                        RangedSpriteWidthFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.RangedSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setRangedSpriteXFirstValue = true;
                        RangedSpriteXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.RangedSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("RangedText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangedText.Font = "Moire ExtraBold";
                        }
                        setRangedTextFontScaleFirstValue = true;
                        RangedTextFontScaleFirstValue = 0.8f;
                        setRangedTextFontSizeFirstValue = true;
                        RangedTextFontSizeFirstValue = 50;
                        setRangedTextHeightFirstValue = true;
                        RangedTextHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.RangedText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangedText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setRangedTextOutlineThicknessFirstValue = true;
                        RangedTextOutlineThicknessFirstValue = 2;
                        if (interpolationValue < 1)
                        {
                            this.RangedText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangedContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangedText.Text = "0";
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangedText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangedText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setRangedTextWidthFirstValue = true;
                        RangedTextWidthFirstValue = 70f;
                        if (interpolationValue < 1)
                        {
                            this.RangedText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setStatsContainerHeightFirstValue = true;
                        StatsContainerHeightFirstValue = 88.80209f;
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TallInfoFrameInstance");
                        }
                        setStatsContainerWidthFirstValue = true;
                        StatsContainerWidthFirstValue = 67.44791f;
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.WrapsChildren = true;
                        }
                        setStatsContainerXFirstValue = true;
                        StatsContainerXFirstValue = 83f;
                        setStatsContainerYFirstValue = true;
                        StatsContainerYFirstValue = 29f;
                        setTallInfoFrameInstanceHeightFirstValue = true;
                        TallInfoFrameInstanceHeightFirstValue = 100f;
                        setTallInfoFrameInstanceWidthFirstValue = true;
                        TallInfoFrameInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 20f;
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
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
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
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setHealthContainerHeightSecondValue = true;
                        HealthContainerHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.HealthContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setHealthContainerWidthSecondValue = true;
                        HealthContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HealthContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHealthSpriteHeightSecondValue = true;
                        HealthSpriteHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HealthSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "HealthContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("HealthSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setHealthSpriteTextureHeightSecondValue = true;
                        HealthSpriteTextureHeightSecondValue = 64;
                        setHealthSpriteTextureLeftSecondValue = true;
                        HealthSpriteTextureLeftSecondValue = 68;
                        setHealthSpriteTextureTopSecondValue = true;
                        HealthSpriteTextureTopSecondValue = 29;
                        setHealthSpriteTextureWidthSecondValue = true;
                        HealthSpriteTextureWidthSecondValue = 64;
                        setHealthSpriteWidthSecondValue = true;
                        HealthSpriteWidthSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.HealthSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHealthSpriteXSecondValue = true;
                        HealthSpriteXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.HealthSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("HealthText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthText.Font = "Moire ExtraBold";
                        }
                        setHealthTextFontScaleSecondValue = true;
                        HealthTextFontScaleSecondValue = 0.8f;
                        setHealthTextFontSizeSecondValue = true;
                        HealthTextFontSizeSecondValue = 50;
                        setHealthTextHeightSecondValue = true;
                        HealthTextHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HealthText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setHealthTextOutlineThicknessSecondValue = true;
                        HealthTextOutlineThicknessSecondValue = 2;
                        if (interpolationValue >= 1)
                        {
                            this.HealthText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "HealthContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthText.Text = "0";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setHealthTextWidthSecondValue = true;
                        HealthTextWidthSecondValue = 70f;
                        if (interpolationValue >= 1)
                        {
                            this.HealthText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 35.55556f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MeleeContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setMeleeContainerHeightSecondValue = true;
                        MeleeContainerHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.MeleeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MeleeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setMeleeContainerWidthSecondValue = true;
                        MeleeContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MeleeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMeleeSpriteHeightSecondValue = true;
                        MeleeSpriteHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MeleeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MeleeSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MeleeContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MeleeSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MeleeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMeleeSpriteTextureHeightSecondValue = true;
                        MeleeSpriteTextureHeightSecondValue = 64;
                        setMeleeSpriteTextureLeftSecondValue = true;
                        MeleeSpriteTextureLeftSecondValue = 132;
                        setMeleeSpriteTextureTopSecondValue = true;
                        MeleeSpriteTextureTopSecondValue = 29;
                        setMeleeSpriteTextureWidthSecondValue = true;
                        MeleeSpriteTextureWidthSecondValue = 64;
                        setMeleeSpriteWidthSecondValue = true;
                        MeleeSpriteWidthSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.MeleeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMeleeSpriteXSecondValue = true;
                        MeleeSpriteXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.MeleeSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MeleeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MeleeText.Font = "Moire ExtraBold";
                        }
                        setMeleeTextFontScaleSecondValue = true;
                        MeleeTextFontScaleSecondValue = 0.8f;
                        setMeleeTextFontSizeSecondValue = true;
                        MeleeTextFontSizeSecondValue = 50;
                        setMeleeTextHeightSecondValue = true;
                        MeleeTextHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MeleeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MeleeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setMeleeTextOutlineThicknessSecondValue = true;
                        MeleeTextOutlineThicknessSecondValue = 2;
                        if (interpolationValue >= 1)
                        {
                            this.MeleeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MeleeContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MeleeText.Text = "0";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MeleeText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MeleeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMeleeTextWidthSecondValue = true;
                        MeleeTextWidthSecondValue = 70f;
                        if (interpolationValue >= 1)
                        {
                            this.MeleeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNameContainerHeightSecondValue = true;
                        NameContainerHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setNameContainerWidthSecondValue = true;
                        NameContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("NameText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.Font = "Moire ExtraBold";
                        }
                        setNameTextFontScaleSecondValue = true;
                        NameTextFontScaleSecondValue = 0.8f;
                        setNameTextFontSizeSecondValue = true;
                        NameTextFontSizeSecondValue = 50;
                        setNameTextHeightSecondValue = true;
                        NameTextHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setNameTextOutlineThicknessSecondValue = true;
                        NameTextOutlineThicknessSecondValue = 2;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.Text = "Enemy";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNameTextXSecondValue = true;
                        NameTextXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setNameTextYSecondValue = true;
                        NameTextYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangedContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRangedContainerHeightSecondValue = true;
                        RangedContainerHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.RangedContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangedContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setRangedContainerWidthSecondValue = true;
                        RangedContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.RangedContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setRangedSpriteHeightSecondValue = true;
                        RangedSpriteHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.RangedSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangedSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangedContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("RangedSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangedSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setRangedSpriteTextureHeightSecondValue = true;
                        RangedSpriteTextureHeightSecondValue = 64;
                        setRangedSpriteTextureLeftSecondValue = true;
                        RangedSpriteTextureLeftSecondValue = 196;
                        setRangedSpriteTextureTopSecondValue = true;
                        RangedSpriteTextureTopSecondValue = 29;
                        setRangedSpriteTextureWidthSecondValue = true;
                        RangedSpriteTextureWidthSecondValue = 64;
                        setRangedSpriteWidthSecondValue = true;
                        RangedSpriteWidthSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.RangedSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setRangedSpriteXSecondValue = true;
                        RangedSpriteXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.RangedSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("RangedText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangedText.Font = "Moire ExtraBold";
                        }
                        setRangedTextFontScaleSecondValue = true;
                        RangedTextFontScaleSecondValue = 0.8f;
                        setRangedTextFontSizeSecondValue = true;
                        RangedTextFontSizeSecondValue = 50;
                        setRangedTextHeightSecondValue = true;
                        RangedTextHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.RangedText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangedText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setRangedTextOutlineThicknessSecondValue = true;
                        RangedTextOutlineThicknessSecondValue = 2;
                        if (interpolationValue >= 1)
                        {
                            this.RangedText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangedContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangedText.Text = "0";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangedText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangedText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setRangedTextWidthSecondValue = true;
                        RangedTextWidthSecondValue = 70f;
                        if (interpolationValue >= 1)
                        {
                            this.RangedText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setStatsContainerHeightSecondValue = true;
                        StatsContainerHeightSecondValue = 88.80209f;
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TallInfoFrameInstance");
                        }
                        setStatsContainerWidthSecondValue = true;
                        StatsContainerWidthSecondValue = 67.44791f;
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.WrapsChildren = true;
                        }
                        setStatsContainerXSecondValue = true;
                        StatsContainerXSecondValue = 83f;
                        setStatsContainerYSecondValue = true;
                        StatsContainerYSecondValue = 29f;
                        setTallInfoFrameInstanceHeightSecondValue = true;
                        TallInfoFrameInstanceHeightSecondValue = 100f;
                        setTallInfoFrameInstanceWidthSecondValue = true;
                        TallInfoFrameInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 20f;
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
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        break;
                }
                if (setHealthContainerHeightFirstValue && setHealthContainerHeightSecondValue)
                {
                    HealthContainer.Height = HealthContainerHeightFirstValue * (1 - interpolationValue) + HealthContainerHeightSecondValue * interpolationValue;
                }
                if (setHealthContainerWidthFirstValue && setHealthContainerWidthSecondValue)
                {
                    HealthContainer.Width = HealthContainerWidthFirstValue * (1 - interpolationValue) + HealthContainerWidthSecondValue * interpolationValue;
                }
                if (setHealthSpriteHeightFirstValue && setHealthSpriteHeightSecondValue)
                {
                    HealthSprite.Height = HealthSpriteHeightFirstValue * (1 - interpolationValue) + HealthSpriteHeightSecondValue * interpolationValue;
                }
                if (setHealthSpriteTextureHeightFirstValue && setHealthSpriteTextureHeightSecondValue)
                {
                    HealthSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(HealthSpriteTextureHeightFirstValue* (1 - interpolationValue) + HealthSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setHealthSpriteTextureLeftFirstValue && setHealthSpriteTextureLeftSecondValue)
                {
                    HealthSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(HealthSpriteTextureLeftFirstValue* (1 - interpolationValue) + HealthSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setHealthSpriteTextureTopFirstValue && setHealthSpriteTextureTopSecondValue)
                {
                    HealthSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(HealthSpriteTextureTopFirstValue* (1 - interpolationValue) + HealthSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setHealthSpriteTextureWidthFirstValue && setHealthSpriteTextureWidthSecondValue)
                {
                    HealthSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(HealthSpriteTextureWidthFirstValue* (1 - interpolationValue) + HealthSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setHealthSpriteWidthFirstValue && setHealthSpriteWidthSecondValue)
                {
                    HealthSprite.Width = HealthSpriteWidthFirstValue * (1 - interpolationValue) + HealthSpriteWidthSecondValue * interpolationValue;
                }
                if (setHealthSpriteXFirstValue && setHealthSpriteXSecondValue)
                {
                    HealthSprite.X = HealthSpriteXFirstValue * (1 - interpolationValue) + HealthSpriteXSecondValue * interpolationValue;
                }
                if (setHealthTextFontScaleFirstValue && setHealthTextFontScaleSecondValue)
                {
                    HealthText.FontScale = HealthTextFontScaleFirstValue * (1 - interpolationValue) + HealthTextFontScaleSecondValue * interpolationValue;
                }
                if (setHealthTextFontSizeFirstValue && setHealthTextFontSizeSecondValue)
                {
                    HealthText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(HealthTextFontSizeFirstValue* (1 - interpolationValue) + HealthTextFontSizeSecondValue * interpolationValue);
                }
                if (setHealthTextHeightFirstValue && setHealthTextHeightSecondValue)
                {
                    HealthText.Height = HealthTextHeightFirstValue * (1 - interpolationValue) + HealthTextHeightSecondValue * interpolationValue;
                }
                if (setHealthTextOutlineThicknessFirstValue && setHealthTextOutlineThicknessSecondValue)
                {
                    HealthText.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(HealthTextOutlineThicknessFirstValue* (1 - interpolationValue) + HealthTextOutlineThicknessSecondValue * interpolationValue);
                }
                if (setHealthTextWidthFirstValue && setHealthTextWidthSecondValue)
                {
                    HealthText.Width = HealthTextWidthFirstValue * (1 - interpolationValue) + HealthTextWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMeleeContainerHeightFirstValue && setMeleeContainerHeightSecondValue)
                {
                    MeleeContainer.Height = MeleeContainerHeightFirstValue * (1 - interpolationValue) + MeleeContainerHeightSecondValue * interpolationValue;
                }
                if (setMeleeContainerWidthFirstValue && setMeleeContainerWidthSecondValue)
                {
                    MeleeContainer.Width = MeleeContainerWidthFirstValue * (1 - interpolationValue) + MeleeContainerWidthSecondValue * interpolationValue;
                }
                if (setMeleeSpriteHeightFirstValue && setMeleeSpriteHeightSecondValue)
                {
                    MeleeSprite.Height = MeleeSpriteHeightFirstValue * (1 - interpolationValue) + MeleeSpriteHeightSecondValue * interpolationValue;
                }
                if (setMeleeSpriteTextureHeightFirstValue && setMeleeSpriteTextureHeightSecondValue)
                {
                    MeleeSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(MeleeSpriteTextureHeightFirstValue* (1 - interpolationValue) + MeleeSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setMeleeSpriteTextureLeftFirstValue && setMeleeSpriteTextureLeftSecondValue)
                {
                    MeleeSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(MeleeSpriteTextureLeftFirstValue* (1 - interpolationValue) + MeleeSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setMeleeSpriteTextureTopFirstValue && setMeleeSpriteTextureTopSecondValue)
                {
                    MeleeSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(MeleeSpriteTextureTopFirstValue* (1 - interpolationValue) + MeleeSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setMeleeSpriteTextureWidthFirstValue && setMeleeSpriteTextureWidthSecondValue)
                {
                    MeleeSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(MeleeSpriteTextureWidthFirstValue* (1 - interpolationValue) + MeleeSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setMeleeSpriteWidthFirstValue && setMeleeSpriteWidthSecondValue)
                {
                    MeleeSprite.Width = MeleeSpriteWidthFirstValue * (1 - interpolationValue) + MeleeSpriteWidthSecondValue * interpolationValue;
                }
                if (setMeleeSpriteXFirstValue && setMeleeSpriteXSecondValue)
                {
                    MeleeSprite.X = MeleeSpriteXFirstValue * (1 - interpolationValue) + MeleeSpriteXSecondValue * interpolationValue;
                }
                if (setMeleeTextFontScaleFirstValue && setMeleeTextFontScaleSecondValue)
                {
                    MeleeText.FontScale = MeleeTextFontScaleFirstValue * (1 - interpolationValue) + MeleeTextFontScaleSecondValue * interpolationValue;
                }
                if (setMeleeTextFontSizeFirstValue && setMeleeTextFontSizeSecondValue)
                {
                    MeleeText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(MeleeTextFontSizeFirstValue* (1 - interpolationValue) + MeleeTextFontSizeSecondValue * interpolationValue);
                }
                if (setMeleeTextHeightFirstValue && setMeleeTextHeightSecondValue)
                {
                    MeleeText.Height = MeleeTextHeightFirstValue * (1 - interpolationValue) + MeleeTextHeightSecondValue * interpolationValue;
                }
                if (setMeleeTextOutlineThicknessFirstValue && setMeleeTextOutlineThicknessSecondValue)
                {
                    MeleeText.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(MeleeTextOutlineThicknessFirstValue* (1 - interpolationValue) + MeleeTextOutlineThicknessSecondValue * interpolationValue);
                }
                if (setMeleeTextWidthFirstValue && setMeleeTextWidthSecondValue)
                {
                    MeleeText.Width = MeleeTextWidthFirstValue * (1 - interpolationValue) + MeleeTextWidthSecondValue * interpolationValue;
                }
                if (setNameContainerHeightFirstValue && setNameContainerHeightSecondValue)
                {
                    NameContainer.Height = NameContainerHeightFirstValue * (1 - interpolationValue) + NameContainerHeightSecondValue * interpolationValue;
                }
                if (setNameContainerWidthFirstValue && setNameContainerWidthSecondValue)
                {
                    NameContainer.Width = NameContainerWidthFirstValue * (1 - interpolationValue) + NameContainerWidthSecondValue * interpolationValue;
                }
                if (setNameTextFontScaleFirstValue && setNameTextFontScaleSecondValue)
                {
                    NameText.FontScale = NameTextFontScaleFirstValue * (1 - interpolationValue) + NameTextFontScaleSecondValue * interpolationValue;
                }
                if (setNameTextFontSizeFirstValue && setNameTextFontSizeSecondValue)
                {
                    NameText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextFontSizeFirstValue* (1 - interpolationValue) + NameTextFontSizeSecondValue * interpolationValue);
                }
                if (setNameTextHeightFirstValue && setNameTextHeightSecondValue)
                {
                    NameText.Height = NameTextHeightFirstValue * (1 - interpolationValue) + NameTextHeightSecondValue * interpolationValue;
                }
                if (setNameTextOutlineThicknessFirstValue && setNameTextOutlineThicknessSecondValue)
                {
                    NameText.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextOutlineThicknessFirstValue* (1 - interpolationValue) + NameTextOutlineThicknessSecondValue * interpolationValue);
                }
                if (setNameTextXFirstValue && setNameTextXSecondValue)
                {
                    NameText.X = NameTextXFirstValue * (1 - interpolationValue) + NameTextXSecondValue * interpolationValue;
                }
                if (setNameTextYFirstValue && setNameTextYSecondValue)
                {
                    NameText.Y = NameTextYFirstValue * (1 - interpolationValue) + NameTextYSecondValue * interpolationValue;
                }
                if (setRangedContainerHeightFirstValue && setRangedContainerHeightSecondValue)
                {
                    RangedContainer.Height = RangedContainerHeightFirstValue * (1 - interpolationValue) + RangedContainerHeightSecondValue * interpolationValue;
                }
                if (setRangedContainerWidthFirstValue && setRangedContainerWidthSecondValue)
                {
                    RangedContainer.Width = RangedContainerWidthFirstValue * (1 - interpolationValue) + RangedContainerWidthSecondValue * interpolationValue;
                }
                if (setRangedSpriteHeightFirstValue && setRangedSpriteHeightSecondValue)
                {
                    RangedSprite.Height = RangedSpriteHeightFirstValue * (1 - interpolationValue) + RangedSpriteHeightSecondValue * interpolationValue;
                }
                if (setRangedSpriteTextureHeightFirstValue && setRangedSpriteTextureHeightSecondValue)
                {
                    RangedSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(RangedSpriteTextureHeightFirstValue* (1 - interpolationValue) + RangedSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setRangedSpriteTextureLeftFirstValue && setRangedSpriteTextureLeftSecondValue)
                {
                    RangedSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(RangedSpriteTextureLeftFirstValue* (1 - interpolationValue) + RangedSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setRangedSpriteTextureTopFirstValue && setRangedSpriteTextureTopSecondValue)
                {
                    RangedSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(RangedSpriteTextureTopFirstValue* (1 - interpolationValue) + RangedSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setRangedSpriteTextureWidthFirstValue && setRangedSpriteTextureWidthSecondValue)
                {
                    RangedSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(RangedSpriteTextureWidthFirstValue* (1 - interpolationValue) + RangedSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setRangedSpriteWidthFirstValue && setRangedSpriteWidthSecondValue)
                {
                    RangedSprite.Width = RangedSpriteWidthFirstValue * (1 - interpolationValue) + RangedSpriteWidthSecondValue * interpolationValue;
                }
                if (setRangedSpriteXFirstValue && setRangedSpriteXSecondValue)
                {
                    RangedSprite.X = RangedSpriteXFirstValue * (1 - interpolationValue) + RangedSpriteXSecondValue * interpolationValue;
                }
                if (setRangedTextFontScaleFirstValue && setRangedTextFontScaleSecondValue)
                {
                    RangedText.FontScale = RangedTextFontScaleFirstValue * (1 - interpolationValue) + RangedTextFontScaleSecondValue * interpolationValue;
                }
                if (setRangedTextFontSizeFirstValue && setRangedTextFontSizeSecondValue)
                {
                    RangedText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(RangedTextFontSizeFirstValue* (1 - interpolationValue) + RangedTextFontSizeSecondValue * interpolationValue);
                }
                if (setRangedTextHeightFirstValue && setRangedTextHeightSecondValue)
                {
                    RangedText.Height = RangedTextHeightFirstValue * (1 - interpolationValue) + RangedTextHeightSecondValue * interpolationValue;
                }
                if (setRangedTextOutlineThicknessFirstValue && setRangedTextOutlineThicknessSecondValue)
                {
                    RangedText.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(RangedTextOutlineThicknessFirstValue* (1 - interpolationValue) + RangedTextOutlineThicknessSecondValue * interpolationValue);
                }
                if (setRangedTextWidthFirstValue && setRangedTextWidthSecondValue)
                {
                    RangedText.Width = RangedTextWidthFirstValue * (1 - interpolationValue) + RangedTextWidthSecondValue * interpolationValue;
                }
                if (setStatsContainerHeightFirstValue && setStatsContainerHeightSecondValue)
                {
                    StatsContainer.Height = StatsContainerHeightFirstValue * (1 - interpolationValue) + StatsContainerHeightSecondValue * interpolationValue;
                }
                if (setStatsContainerWidthFirstValue && setStatsContainerWidthSecondValue)
                {
                    StatsContainer.Width = StatsContainerWidthFirstValue * (1 - interpolationValue) + StatsContainerWidthSecondValue * interpolationValue;
                }
                if (setStatsContainerXFirstValue && setStatsContainerXSecondValue)
                {
                    StatsContainer.X = StatsContainerXFirstValue * (1 - interpolationValue) + StatsContainerXSecondValue * interpolationValue;
                }
                if (setStatsContainerYFirstValue && setStatsContainerYSecondValue)
                {
                    StatsContainer.Y = StatsContainerYFirstValue * (1 - interpolationValue) + StatsContainerYSecondValue * interpolationValue;
                }
                if (setTallInfoFrameInstanceHeightFirstValue && setTallInfoFrameInstanceHeightSecondValue)
                {
                    TallInfoFrameInstance.Height = TallInfoFrameInstanceHeightFirstValue * (1 - interpolationValue) + TallInfoFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setTallInfoFrameInstanceWidthFirstValue && setTallInfoFrameInstanceWidthSecondValue)
                {
                    TallInfoFrameInstance.Width = TallInfoFrameInstanceWidthFirstValue * (1 - interpolationValue) + TallInfoFrameInstanceWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (HasMelee firstState, HasMelee secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setMeleeContainerHeightFirstValue = false;
                bool setMeleeContainerHeightSecondValue = false;
                float MeleeContainerHeightFirstValue= 0;
                float MeleeContainerHeightSecondValue= 0;
                switch(firstState)
                {
                    case  HasMelee.True:
                        setMeleeContainerHeightFirstValue = true;
                        MeleeContainerHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.MeleeContainer.Visible = true;
                        }
                        break;
                    case  HasMelee.False:
                        setMeleeContainerHeightFirstValue = true;
                        MeleeContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MeleeContainer.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  HasMelee.True:
                        setMeleeContainerHeightSecondValue = true;
                        MeleeContainerHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.MeleeContainer.Visible = true;
                        }
                        break;
                    case  HasMelee.False:
                        setMeleeContainerHeightSecondValue = true;
                        MeleeContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MeleeContainer.Visible = false;
                        }
                        break;
                }
                if (setMeleeContainerHeightFirstValue && setMeleeContainerHeightSecondValue)
                {
                    MeleeContainer.Height = MeleeContainerHeightFirstValue * (1 - interpolationValue) + MeleeContainerHeightSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentHasMeleeState = firstState;
                }
                else
                {
                    mCurrentHasMeleeState = secondState;
                }
            }
            public void InterpolateBetween (HasRanged firstState, HasRanged secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setRangedContainerHeightFirstValue = false;
                bool setRangedContainerHeightSecondValue = false;
                float RangedContainerHeightFirstValue= 0;
                float RangedContainerHeightSecondValue= 0;
                switch(firstState)
                {
                    case  HasRanged.True:
                        setRangedContainerHeightFirstValue = true;
                        RangedContainerHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.RangedContainer.Visible = true;
                        }
                        break;
                    case  HasRanged.False:
                        setRangedContainerHeightFirstValue = true;
                        RangedContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.RangedContainer.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  HasRanged.True:
                        setRangedContainerHeightSecondValue = true;
                        RangedContainerHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.RangedContainer.Visible = true;
                        }
                        break;
                    case  HasRanged.False:
                        setRangedContainerHeightSecondValue = true;
                        RangedContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.RangedContainer.Visible = false;
                        }
                        break;
                }
                if (setRangedContainerHeightFirstValue && setRangedContainerHeightSecondValue)
                {
                    RangedContainer.Height = RangedContainerHeightFirstValue * (1 - interpolationValue) + RangedContainerHeightSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentHasRangedState = firstState;
                }
                else
                {
                    mCurrentHasRangedState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime.HasMelee fromState,AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime.HasMelee toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (HasMelee toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "HasMelee").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentHasMeleeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (HasMelee toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentHasMeleeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime.HasRanged fromState,AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime.HasRanged toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (HasRanged toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "HasRanged").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentHasRangedState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (HasRanged toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentHasRangedState = toState;
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
                TallInfoFrameInstance.StopAnimations();
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
                            Name = "StatsContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = StatsContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height",
                            Type = "float",
                            Value = StatsContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Parent",
                            Type = "string",
                            Value = StatsContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width",
                            Type = "float",
                            Value = StatsContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Wraps Children",
                            Type = "bool",
                            Value = StatsContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.X",
                            Type = "float",
                            Value = StatsContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Y",
                            Type = "float",
                            Value = StatsContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height",
                            Type = "float",
                            Value = NameContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Parent",
                            Type = "string",
                            Value = NameContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width",
                            Type = "float",
                            Value = NameContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.CustomFontFile",
                            Type = "string",
                            Value = NameText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font",
                            Type = "string",
                            Value = NameText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font Scale",
                            Type = "float",
                            Value = NameText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.FontSize",
                            Type = "int",
                            Value = NameText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height",
                            Type = "float",
                            Value = NameText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = NameText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.OutlineThickness",
                            Type = "int",
                            Value = NameText.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Parent",
                            Type = "string",
                            Value = NameText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Text",
                            Type = "string",
                            Value = NameText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.UseCustomFont",
                            Type = "bool",
                            Value = NameText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = NameText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.X",
                            Type = "float",
                            Value = NameText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.X Units",
                            Type = "PositionUnitType",
                            Value = NameText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Y",
                            Type = "float",
                            Value = NameText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Y Units",
                            Type = "PositionUnitType",
                            Value = NameText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = HealthContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Height",
                            Type = "float",
                            Value = HealthContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = HealthContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Parent",
                            Type = "string",
                            Value = HealthContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Width",
                            Type = "float",
                            Value = HealthContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = HealthContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Height",
                            Type = "float",
                            Value = HealthSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = HealthSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Parent",
                            Type = "string",
                            Value = HealthSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.SourceFile",
                            Type = "string",
                            Value = HealthSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = HealthSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Texture Height",
                            Type = "int",
                            Value = HealthSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Texture Left",
                            Type = "int",
                            Value = HealthSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Texture Top",
                            Type = "int",
                            Value = HealthSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Texture Width",
                            Type = "int",
                            Value = HealthSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Width",
                            Type = "float",
                            Value = HealthSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = HealthSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.X",
                            Type = "float",
                            Value = HealthSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.X Units",
                            Type = "PositionUnitType",
                            Value = HealthSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.CustomFontFile",
                            Type = "string",
                            Value = HealthText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Font",
                            Type = "string",
                            Value = HealthText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Font Scale",
                            Type = "float",
                            Value = HealthText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.FontSize",
                            Type = "int",
                            Value = HealthText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Height",
                            Type = "float",
                            Value = HealthText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Height Units",
                            Type = "DimensionUnitType",
                            Value = HealthText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = HealthText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.OutlineThickness",
                            Type = "int",
                            Value = HealthText.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Parent",
                            Type = "string",
                            Value = HealthText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Text",
                            Type = "string",
                            Value = HealthText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.UseCustomFont",
                            Type = "bool",
                            Value = HealthText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = HealthText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Width",
                            Type = "float",
                            Value = HealthText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Width Units",
                            Type = "DimensionUnitType",
                            Value = HealthText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = MeleeContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Height",
                            Type = "float",
                            Value = MeleeContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = MeleeContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Parent",
                            Type = "string",
                            Value = MeleeContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Width",
                            Type = "float",
                            Value = MeleeContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = MeleeContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Height",
                            Type = "float",
                            Value = MeleeSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = MeleeSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Parent",
                            Type = "string",
                            Value = MeleeSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.SourceFile",
                            Type = "string",
                            Value = MeleeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = MeleeSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Texture Height",
                            Type = "int",
                            Value = MeleeSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Texture Left",
                            Type = "int",
                            Value = MeleeSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Texture Top",
                            Type = "int",
                            Value = MeleeSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Texture Width",
                            Type = "int",
                            Value = MeleeSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Width",
                            Type = "float",
                            Value = MeleeSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = MeleeSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.X",
                            Type = "float",
                            Value = MeleeSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.X Units",
                            Type = "PositionUnitType",
                            Value = MeleeSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.CustomFontFile",
                            Type = "string",
                            Value = MeleeText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Font",
                            Type = "string",
                            Value = MeleeText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Font Scale",
                            Type = "float",
                            Value = MeleeText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.FontSize",
                            Type = "int",
                            Value = MeleeText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Height",
                            Type = "float",
                            Value = MeleeText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MeleeText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MeleeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.OutlineThickness",
                            Type = "int",
                            Value = MeleeText.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Parent",
                            Type = "string",
                            Value = MeleeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Text",
                            Type = "string",
                            Value = MeleeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.UseCustomFont",
                            Type = "bool",
                            Value = MeleeText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MeleeText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Width",
                            Type = "float",
                            Value = MeleeText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MeleeText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = RangedContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Height",
                            Type = "float",
                            Value = RangedContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = RangedContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Parent",
                            Type = "string",
                            Value = RangedContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Width",
                            Type = "float",
                            Value = RangedContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = RangedContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Height",
                            Type = "float",
                            Value = RangedSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = RangedSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Parent",
                            Type = "string",
                            Value = RangedSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.SourceFile",
                            Type = "string",
                            Value = RangedSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = RangedSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Texture Height",
                            Type = "int",
                            Value = RangedSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Texture Left",
                            Type = "int",
                            Value = RangedSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Texture Top",
                            Type = "int",
                            Value = RangedSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Texture Width",
                            Type = "int",
                            Value = RangedSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Width",
                            Type = "float",
                            Value = RangedSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = RangedSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.X",
                            Type = "float",
                            Value = RangedSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.X Units",
                            Type = "PositionUnitType",
                            Value = RangedSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.CustomFontFile",
                            Type = "string",
                            Value = RangedText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Font",
                            Type = "string",
                            Value = RangedText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Font Scale",
                            Type = "float",
                            Value = RangedText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.FontSize",
                            Type = "int",
                            Value = RangedText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Height",
                            Type = "float",
                            Value = RangedText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Height Units",
                            Type = "DimensionUnitType",
                            Value = RangedText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = RangedText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.OutlineThickness",
                            Type = "int",
                            Value = RangedText.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Parent",
                            Type = "string",
                            Value = RangedText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Text",
                            Type = "string",
                            Value = RangedText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.UseCustomFont",
                            Type = "bool",
                            Value = RangedText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = RangedText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Width",
                            Type = "float",
                            Value = RangedText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Width Units",
                            Type = "DimensionUnitType",
                            Value = RangedText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Height",
                            Type = "float",
                            Value = TallInfoFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Width",
                            Type = "float",
                            Value = TallInfoFrameInstance.Width
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
                            Value = Height + 35.55556f
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
                            Value = Width + 20f
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
                            Name = "StatsContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = StatsContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height",
                            Type = "float",
                            Value = StatsContainer.Height + 88.80209f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Parent",
                            Type = "string",
                            Value = StatsContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width",
                            Type = "float",
                            Value = StatsContainer.Width + 67.44791f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Wraps Children",
                            Type = "bool",
                            Value = StatsContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.X",
                            Type = "float",
                            Value = StatsContainer.X + 83f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Y",
                            Type = "float",
                            Value = StatsContainer.Y + 29f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height",
                            Type = "float",
                            Value = NameContainer.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Parent",
                            Type = "string",
                            Value = NameContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width",
                            Type = "float",
                            Value = NameContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.CustomFontFile",
                            Type = "string",
                            Value = NameText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font",
                            Type = "string",
                            Value = NameText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font Scale",
                            Type = "float",
                            Value = NameText.FontScale + 0.8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.FontSize",
                            Type = "int",
                            Value = NameText.FontSize + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height",
                            Type = "float",
                            Value = NameText.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = NameText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.OutlineThickness",
                            Type = "int",
                            Value = NameText.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Parent",
                            Type = "string",
                            Value = NameText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Text",
                            Type = "string",
                            Value = NameText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.UseCustomFont",
                            Type = "bool",
                            Value = NameText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = NameText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.X",
                            Type = "float",
                            Value = NameText.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.X Units",
                            Type = "PositionUnitType",
                            Value = NameText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Y",
                            Type = "float",
                            Value = NameText.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Y Units",
                            Type = "PositionUnitType",
                            Value = NameText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = HealthContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Height",
                            Type = "float",
                            Value = HealthContainer.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = HealthContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Parent",
                            Type = "string",
                            Value = HealthContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Width",
                            Type = "float",
                            Value = HealthContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = HealthContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Height",
                            Type = "float",
                            Value = HealthSprite.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = HealthSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Parent",
                            Type = "string",
                            Value = HealthSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.SourceFile",
                            Type = "string",
                            Value = HealthSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = HealthSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Texture Height",
                            Type = "int",
                            Value = HealthSprite.TextureHeight + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Texture Left",
                            Type = "int",
                            Value = HealthSprite.TextureLeft + 68
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Texture Top",
                            Type = "int",
                            Value = HealthSprite.TextureTop + 29
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Texture Width",
                            Type = "int",
                            Value = HealthSprite.TextureWidth + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Width",
                            Type = "float",
                            Value = HealthSprite.Width + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = HealthSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.X",
                            Type = "float",
                            Value = HealthSprite.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthSprite.X Units",
                            Type = "PositionUnitType",
                            Value = HealthSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.CustomFontFile",
                            Type = "string",
                            Value = HealthText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Font",
                            Type = "string",
                            Value = HealthText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Font Scale",
                            Type = "float",
                            Value = HealthText.FontScale + 0.8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.FontSize",
                            Type = "int",
                            Value = HealthText.FontSize + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Height",
                            Type = "float",
                            Value = HealthText.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Height Units",
                            Type = "DimensionUnitType",
                            Value = HealthText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = HealthText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.OutlineThickness",
                            Type = "int",
                            Value = HealthText.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Parent",
                            Type = "string",
                            Value = HealthText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Text",
                            Type = "string",
                            Value = HealthText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.UseCustomFont",
                            Type = "bool",
                            Value = HealthText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = HealthText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Width",
                            Type = "float",
                            Value = HealthText.Width + 70f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthText.Width Units",
                            Type = "DimensionUnitType",
                            Value = HealthText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = MeleeContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Height",
                            Type = "float",
                            Value = MeleeContainer.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = MeleeContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Parent",
                            Type = "string",
                            Value = MeleeContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Width",
                            Type = "float",
                            Value = MeleeContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = MeleeContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Height",
                            Type = "float",
                            Value = MeleeSprite.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = MeleeSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Parent",
                            Type = "string",
                            Value = MeleeSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.SourceFile",
                            Type = "string",
                            Value = MeleeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = MeleeSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Texture Height",
                            Type = "int",
                            Value = MeleeSprite.TextureHeight + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Texture Left",
                            Type = "int",
                            Value = MeleeSprite.TextureLeft + 132
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Texture Top",
                            Type = "int",
                            Value = MeleeSprite.TextureTop + 29
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Texture Width",
                            Type = "int",
                            Value = MeleeSprite.TextureWidth + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Width",
                            Type = "float",
                            Value = MeleeSprite.Width + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = MeleeSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.X",
                            Type = "float",
                            Value = MeleeSprite.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeSprite.X Units",
                            Type = "PositionUnitType",
                            Value = MeleeSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.CustomFontFile",
                            Type = "string",
                            Value = MeleeText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Font",
                            Type = "string",
                            Value = MeleeText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Font Scale",
                            Type = "float",
                            Value = MeleeText.FontScale + 0.8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.FontSize",
                            Type = "int",
                            Value = MeleeText.FontSize + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Height",
                            Type = "float",
                            Value = MeleeText.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MeleeText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MeleeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.OutlineThickness",
                            Type = "int",
                            Value = MeleeText.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Parent",
                            Type = "string",
                            Value = MeleeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Text",
                            Type = "string",
                            Value = MeleeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.UseCustomFont",
                            Type = "bool",
                            Value = MeleeText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MeleeText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Width",
                            Type = "float",
                            Value = MeleeText.Width + 70f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MeleeText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = RangedContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Height",
                            Type = "float",
                            Value = RangedContainer.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = RangedContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Parent",
                            Type = "string",
                            Value = RangedContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Width",
                            Type = "float",
                            Value = RangedContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = RangedContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Height",
                            Type = "float",
                            Value = RangedSprite.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = RangedSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Parent",
                            Type = "string",
                            Value = RangedSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.SourceFile",
                            Type = "string",
                            Value = RangedSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = RangedSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Texture Height",
                            Type = "int",
                            Value = RangedSprite.TextureHeight + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Texture Left",
                            Type = "int",
                            Value = RangedSprite.TextureLeft + 196
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Texture Top",
                            Type = "int",
                            Value = RangedSprite.TextureTop + 29
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Texture Width",
                            Type = "int",
                            Value = RangedSprite.TextureWidth + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Width",
                            Type = "float",
                            Value = RangedSprite.Width + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = RangedSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.X",
                            Type = "float",
                            Value = RangedSprite.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedSprite.X Units",
                            Type = "PositionUnitType",
                            Value = RangedSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.CustomFontFile",
                            Type = "string",
                            Value = RangedText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Font",
                            Type = "string",
                            Value = RangedText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Font Scale",
                            Type = "float",
                            Value = RangedText.FontScale + 0.8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.FontSize",
                            Type = "int",
                            Value = RangedText.FontSize + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Height",
                            Type = "float",
                            Value = RangedText.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Height Units",
                            Type = "DimensionUnitType",
                            Value = RangedText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = RangedText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.OutlineThickness",
                            Type = "int",
                            Value = RangedText.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Parent",
                            Type = "string",
                            Value = RangedText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Text",
                            Type = "string",
                            Value = RangedText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.UseCustomFont",
                            Type = "bool",
                            Value = RangedText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = RangedText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Width",
                            Type = "float",
                            Value = RangedText.Width + 70f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedText.Width Units",
                            Type = "DimensionUnitType",
                            Value = RangedText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Height",
                            Type = "float",
                            Value = TallInfoFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Width",
                            Type = "float",
                            Value = TallInfoFrameInstance.Width + 100f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (HasMelee state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HasMelee.True:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Height",
                            Type = "float",
                            Value = MeleeContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Visible",
                            Type = "bool",
                            Value = MeleeContainer.Visible
                        }
                        );
                        break;
                    case  HasMelee.False:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Height",
                            Type = "float",
                            Value = MeleeContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Visible",
                            Type = "bool",
                            Value = MeleeContainer.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (HasMelee state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HasMelee.True:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Height",
                            Type = "float",
                            Value = MeleeContainer.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Visible",
                            Type = "bool",
                            Value = MeleeContainer.Visible
                        }
                        );
                        break;
                    case  HasMelee.False:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Height",
                            Type = "float",
                            Value = MeleeContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MeleeContainer.Visible",
                            Type = "bool",
                            Value = MeleeContainer.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (HasRanged state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HasRanged.True:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Height",
                            Type = "float",
                            Value = RangedContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Visible",
                            Type = "bool",
                            Value = RangedContainer.Visible
                        }
                        );
                        break;
                    case  HasRanged.False:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Height",
                            Type = "float",
                            Value = RangedContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Visible",
                            Type = "bool",
                            Value = RangedContainer.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (HasRanged state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HasRanged.True:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Height",
                            Type = "float",
                            Value = RangedContainer.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Visible",
                            Type = "bool",
                            Value = RangedContainer.Visible
                        }
                        );
                        break;
                    case  HasRanged.False:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Height",
                            Type = "float",
                            Value = RangedContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangedContainer.Visible",
                            Type = "bool",
                            Value = RangedContainer.Visible
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
                    else if (category.Name == "HasMelee")
                    {
                        if(state.Name == "True") this.mCurrentHasMeleeState = HasMelee.True;
                        if(state.Name == "False") this.mCurrentHasMeleeState = HasMelee.False;
                    }
                    else if (category.Name == "HasRanged")
                    {
                        if(state.Name == "True") this.mCurrentHasRangedState = HasRanged.True;
                        if(state.Name == "False") this.mCurrentHasRangedState = HasRanged.False;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime StatsContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime NameContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime NameText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime HealthContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime HealthSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime HealthText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime MeleeContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime MeleeSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime MeleeText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime RangedContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime RangedSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime RangedText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TallInfoFrameRuntime TallInfoFrameInstance { get; set; }
            public string EnemyHealth
            {
                get
                {
                    return HealthText.Text;
                }
                set
                {
                    if (HealthText.Text != value)
                    {
                        HealthText.Text = value;
                        EnemyHealthChanged?.Invoke(this, null);
                    }
                }
            }
            public string EnemyMelee
            {
                get
                {
                    return MeleeText.Text;
                }
                set
                {
                    if (MeleeText.Text != value)
                    {
                        MeleeText.Text = value;
                        EnemyMeleeChanged?.Invoke(this, null);
                    }
                }
            }
            public string EnemyName
            {
                get
                {
                    return NameText.Text;
                }
                set
                {
                    if (NameText.Text != value)
                    {
                        NameText.Text = value;
                        EnemyNameChanged?.Invoke(this, null);
                    }
                }
            }
            public string EnemyRanged
            {
                get
                {
                    return RangedText.Text;
                }
                set
                {
                    if (RangedText.Text != value)
                    {
                        RangedText.Text = value;
                        EnemyRangedChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent StatsContainerClick;
            public event FlatRedBall.Gui.WindowEvent NameContainerClick;
            public event FlatRedBall.Gui.WindowEvent MeleeContainerClick;
            public event FlatRedBall.Gui.WindowEvent TallInfoFrameInstanceClick;
            public event System.EventHandler EnemyHealthChanged;
            public event System.EventHandler EnemyMeleeChanged;
            public event System.EventHandler EnemyNameChanged;
            public event System.EventHandler EnemyRangedChanged;
            public EnemyInfoRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/EnemyInfo");
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
                StatsContainer = this.GetGraphicalUiElementByName("StatsContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                NameContainer = this.GetGraphicalUiElementByName("NameContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                NameText = this.GetGraphicalUiElementByName("NameText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                HealthContainer = this.GetGraphicalUiElementByName("HealthContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                HealthSprite = this.GetGraphicalUiElementByName("HealthSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                HealthText = this.GetGraphicalUiElementByName("HealthText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                MeleeContainer = this.GetGraphicalUiElementByName("MeleeContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                MeleeSprite = this.GetGraphicalUiElementByName("MeleeSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                MeleeText = this.GetGraphicalUiElementByName("MeleeText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                RangedContainer = this.GetGraphicalUiElementByName("RangedContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                RangedSprite = this.GetGraphicalUiElementByName("RangedSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                RangedText = this.GetGraphicalUiElementByName("RangedText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                TallInfoFrameInstance = this.GetGraphicalUiElementByName("TallInfoFrameInstance") as AbbatoirIntergrade.GumRuntimes.TallInfoFrameRuntime;
                StatsContainer.Click += (unused) => StatsContainerClick?.Invoke(this);
                NameContainer.Click += (unused) => NameContainerClick?.Invoke(this);
                MeleeContainer.Click += (unused) => MeleeContainerClick?.Invoke(this);
                TallInfoFrameInstance.Click += (unused) => TallInfoFrameInstanceClick?.Invoke(this);
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
