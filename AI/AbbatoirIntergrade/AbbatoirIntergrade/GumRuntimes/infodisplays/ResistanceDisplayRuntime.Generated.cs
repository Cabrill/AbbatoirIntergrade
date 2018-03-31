    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class ResistanceDisplayRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Upgraded
            {
                IsUpgraded,
                NotUpgraded
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Upgraded mCurrentUpgradedState;
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Visible = true;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            DamageTypeIconInstance.Height = 0f;
                            DamageTypeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            DamageTypeIconInstance.Width = 100f;
                            DamageTypeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            SetProperty("ResistanceTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            ResistanceTextInstance.FontScale = 0.5f;
                            ResistanceTextInstance.Height = 0f;
                            ResistanceTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ResistanceTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ResistanceTextInstance.Text = "100%";
                            ResistanceTextInstance.UseCustomFont = true;
                            ResistanceTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ResistanceTextInstance.Width = 0f;
                            ResistanceTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            UpgradeSprite.Blue = 140;
                            UpgradeSprite.Green = 230;
                            UpgradeSprite.Height = 32f;
                            UpgradeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            UpgradeSprite.Red = 240;
                            SetProperty("UpgradeSprite.SourceFile", "AllUIAssets.png");
                            UpgradeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            UpgradeSprite.TextureHeight = 128;
                            UpgradeSprite.TextureLeft = 2565;
                            UpgradeSprite.TextureTop = 910;
                            UpgradeSprite.TextureWidth = 111;
                            UpgradeSprite.Visible = false;
                            UpgradeSprite.Width = 32f;
                            UpgradeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            UpgradeSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            UpgradeSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public Upgraded CurrentUpgradedState
            {
                get
                {
                    return mCurrentUpgradedState;
                }
                set
                {
                    mCurrentUpgradedState = value;
                    switch(mCurrentUpgradedState)
                    {
                        case  Upgraded.IsUpgraded:
                            ResistanceTextInstance.Blue = 0;
                            ResistanceTextInstance.Green = 255;
                            ResistanceTextInstance.Red = 0;
                            UpgradeSprite.Visible = true;
                            break;
                        case  Upgraded.NotUpgraded:
                            ResistanceTextInstance.Blue = 255;
                            ResistanceTextInstance.Green = 255;
                            ResistanceTextInstance.Red = 255;
                            UpgradeSprite.Visible = false;
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
                bool setDamageTypeIconInstanceHeightFirstValue = false;
                bool setDamageTypeIconInstanceHeightSecondValue = false;
                float DamageTypeIconInstanceHeightFirstValue= 0;
                float DamageTypeIconInstanceHeightSecondValue= 0;
                bool setDamageTypeIconInstanceWidthFirstValue = false;
                bool setDamageTypeIconInstanceWidthSecondValue = false;
                float DamageTypeIconInstanceWidthFirstValue= 0;
                float DamageTypeIconInstanceWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setResistanceTextInstanceFontScaleFirstValue = false;
                bool setResistanceTextInstanceFontScaleSecondValue = false;
                float ResistanceTextInstanceFontScaleFirstValue= 0;
                float ResistanceTextInstanceFontScaleSecondValue= 0;
                bool setResistanceTextInstanceHeightFirstValue = false;
                bool setResistanceTextInstanceHeightSecondValue = false;
                float ResistanceTextInstanceHeightFirstValue= 0;
                float ResistanceTextInstanceHeightSecondValue= 0;
                bool setResistanceTextInstanceWidthFirstValue = false;
                bool setResistanceTextInstanceWidthSecondValue = false;
                float ResistanceTextInstanceWidthFirstValue= 0;
                float ResistanceTextInstanceWidthSecondValue= 0;
                bool setUpgradeSpriteBlueFirstValue = false;
                bool setUpgradeSpriteBlueSecondValue = false;
                int UpgradeSpriteBlueFirstValue= 0;
                int UpgradeSpriteBlueSecondValue= 0;
                bool setUpgradeSpriteGreenFirstValue = false;
                bool setUpgradeSpriteGreenSecondValue = false;
                int UpgradeSpriteGreenFirstValue= 0;
                int UpgradeSpriteGreenSecondValue= 0;
                bool setUpgradeSpriteHeightFirstValue = false;
                bool setUpgradeSpriteHeightSecondValue = false;
                float UpgradeSpriteHeightFirstValue= 0;
                float UpgradeSpriteHeightSecondValue= 0;
                bool setUpgradeSpriteRedFirstValue = false;
                bool setUpgradeSpriteRedSecondValue = false;
                int UpgradeSpriteRedFirstValue= 0;
                int UpgradeSpriteRedSecondValue= 0;
                bool setUpgradeSpriteTextureHeightFirstValue = false;
                bool setUpgradeSpriteTextureHeightSecondValue = false;
                int UpgradeSpriteTextureHeightFirstValue= 0;
                int UpgradeSpriteTextureHeightSecondValue= 0;
                bool setUpgradeSpriteTextureLeftFirstValue = false;
                bool setUpgradeSpriteTextureLeftSecondValue = false;
                int UpgradeSpriteTextureLeftFirstValue= 0;
                int UpgradeSpriteTextureLeftSecondValue= 0;
                bool setUpgradeSpriteTextureTopFirstValue = false;
                bool setUpgradeSpriteTextureTopSecondValue = false;
                int UpgradeSpriteTextureTopFirstValue= 0;
                int UpgradeSpriteTextureTopSecondValue= 0;
                bool setUpgradeSpriteTextureWidthFirstValue = false;
                bool setUpgradeSpriteTextureWidthSecondValue = false;
                int UpgradeSpriteTextureWidthFirstValue= 0;
                int UpgradeSpriteTextureWidthSecondValue= 0;
                bool setUpgradeSpriteWidthFirstValue = false;
                bool setUpgradeSpriteWidthSecondValue = false;
                float UpgradeSpriteWidthFirstValue= 0;
                float UpgradeSpriteWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setDamageTypeIconInstanceHeightFirstValue = true;
                        DamageTypeIconInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.DamageTypeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setDamageTypeIconInstanceWidthFirstValue = true;
                        DamageTypeIconInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.DamageTypeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ResistanceTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setResistanceTextInstanceFontScaleFirstValue = true;
                        ResistanceTextInstanceFontScaleFirstValue = 0.5f;
                        setResistanceTextInstanceHeightFirstValue = true;
                        ResistanceTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.Text = "100%";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setResistanceTextInstanceWidthFirstValue = true;
                        ResistanceTextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setUpgradeSpriteBlueFirstValue = true;
                        UpgradeSpriteBlueFirstValue = 140;
                        setUpgradeSpriteGreenFirstValue = true;
                        UpgradeSpriteGreenFirstValue = 230;
                        setUpgradeSpriteHeightFirstValue = true;
                        UpgradeSpriteHeightFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setUpgradeSpriteRedFirstValue = true;
                        UpgradeSpriteRedFirstValue = 240;
                        if (interpolationValue < 1)
                        {
                            SetProperty("UpgradeSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setUpgradeSpriteTextureHeightFirstValue = true;
                        UpgradeSpriteTextureHeightFirstValue = 128;
                        setUpgradeSpriteTextureLeftFirstValue = true;
                        UpgradeSpriteTextureLeftFirstValue = 2565;
                        setUpgradeSpriteTextureTopFirstValue = true;
                        UpgradeSpriteTextureTopFirstValue = 910;
                        setUpgradeSpriteTextureWidthFirstValue = true;
                        UpgradeSpriteTextureWidthFirstValue = 111;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.Visible = false;
                        }
                        setUpgradeSpriteWidthFirstValue = true;
                        UpgradeSpriteWidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setDamageTypeIconInstanceHeightSecondValue = true;
                        DamageTypeIconInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.DamageTypeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setDamageTypeIconInstanceWidthSecondValue = true;
                        DamageTypeIconInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.DamageTypeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ResistanceTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setResistanceTextInstanceFontScaleSecondValue = true;
                        ResistanceTextInstanceFontScaleSecondValue = 0.5f;
                        setResistanceTextInstanceHeightSecondValue = true;
                        ResistanceTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.Text = "100%";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setResistanceTextInstanceWidthSecondValue = true;
                        ResistanceTextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setUpgradeSpriteBlueSecondValue = true;
                        UpgradeSpriteBlueSecondValue = 140;
                        setUpgradeSpriteGreenSecondValue = true;
                        UpgradeSpriteGreenSecondValue = 230;
                        setUpgradeSpriteHeightSecondValue = true;
                        UpgradeSpriteHeightSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setUpgradeSpriteRedSecondValue = true;
                        UpgradeSpriteRedSecondValue = 240;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("UpgradeSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setUpgradeSpriteTextureHeightSecondValue = true;
                        UpgradeSpriteTextureHeightSecondValue = 128;
                        setUpgradeSpriteTextureLeftSecondValue = true;
                        UpgradeSpriteTextureLeftSecondValue = 2565;
                        setUpgradeSpriteTextureTopSecondValue = true;
                        UpgradeSpriteTextureTopSecondValue = 910;
                        setUpgradeSpriteTextureWidthSecondValue = true;
                        UpgradeSpriteTextureWidthSecondValue = 111;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.Visible = false;
                        }
                        setUpgradeSpriteWidthSecondValue = true;
                        UpgradeSpriteWidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        break;
                }
                if (setDamageTypeIconInstanceHeightFirstValue && setDamageTypeIconInstanceHeightSecondValue)
                {
                    DamageTypeIconInstance.Height = DamageTypeIconInstanceHeightFirstValue * (1 - interpolationValue) + DamageTypeIconInstanceHeightSecondValue * interpolationValue;
                }
                if (setDamageTypeIconInstanceWidthFirstValue && setDamageTypeIconInstanceWidthSecondValue)
                {
                    DamageTypeIconInstance.Width = DamageTypeIconInstanceWidthFirstValue * (1 - interpolationValue) + DamageTypeIconInstanceWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setResistanceTextInstanceFontScaleFirstValue && setResistanceTextInstanceFontScaleSecondValue)
                {
                    ResistanceTextInstance.FontScale = ResistanceTextInstanceFontScaleFirstValue * (1 - interpolationValue) + ResistanceTextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setResistanceTextInstanceHeightFirstValue && setResistanceTextInstanceHeightSecondValue)
                {
                    ResistanceTextInstance.Height = ResistanceTextInstanceHeightFirstValue * (1 - interpolationValue) + ResistanceTextInstanceHeightSecondValue * interpolationValue;
                }
                if (setResistanceTextInstanceWidthFirstValue && setResistanceTextInstanceWidthSecondValue)
                {
                    ResistanceTextInstance.Width = ResistanceTextInstanceWidthFirstValue * (1 - interpolationValue) + ResistanceTextInstanceWidthSecondValue * interpolationValue;
                }
                if (setUpgradeSpriteBlueFirstValue && setUpgradeSpriteBlueSecondValue)
                {
                    UpgradeSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeSpriteBlueFirstValue* (1 - interpolationValue) + UpgradeSpriteBlueSecondValue * interpolationValue);
                }
                if (setUpgradeSpriteGreenFirstValue && setUpgradeSpriteGreenSecondValue)
                {
                    UpgradeSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeSpriteGreenFirstValue* (1 - interpolationValue) + UpgradeSpriteGreenSecondValue * interpolationValue);
                }
                if (setUpgradeSpriteHeightFirstValue && setUpgradeSpriteHeightSecondValue)
                {
                    UpgradeSprite.Height = UpgradeSpriteHeightFirstValue * (1 - interpolationValue) + UpgradeSpriteHeightSecondValue * interpolationValue;
                }
                if (setUpgradeSpriteRedFirstValue && setUpgradeSpriteRedSecondValue)
                {
                    UpgradeSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeSpriteRedFirstValue* (1 - interpolationValue) + UpgradeSpriteRedSecondValue * interpolationValue);
                }
                if (setUpgradeSpriteTextureHeightFirstValue && setUpgradeSpriteTextureHeightSecondValue)
                {
                    UpgradeSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeSpriteTextureHeightFirstValue* (1 - interpolationValue) + UpgradeSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setUpgradeSpriteTextureLeftFirstValue && setUpgradeSpriteTextureLeftSecondValue)
                {
                    UpgradeSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeSpriteTextureLeftFirstValue* (1 - interpolationValue) + UpgradeSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setUpgradeSpriteTextureTopFirstValue && setUpgradeSpriteTextureTopSecondValue)
                {
                    UpgradeSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeSpriteTextureTopFirstValue* (1 - interpolationValue) + UpgradeSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setUpgradeSpriteTextureWidthFirstValue && setUpgradeSpriteTextureWidthSecondValue)
                {
                    UpgradeSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeSpriteTextureWidthFirstValue* (1 - interpolationValue) + UpgradeSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setUpgradeSpriteWidthFirstValue && setUpgradeSpriteWidthSecondValue)
                {
                    UpgradeSprite.Width = UpgradeSpriteWidthFirstValue * (1 - interpolationValue) + UpgradeSpriteWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (Upgraded firstState, Upgraded secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setResistanceTextInstanceBlueFirstValue = false;
                bool setResistanceTextInstanceBlueSecondValue = false;
                int ResistanceTextInstanceBlueFirstValue= 0;
                int ResistanceTextInstanceBlueSecondValue= 0;
                bool setResistanceTextInstanceGreenFirstValue = false;
                bool setResistanceTextInstanceGreenSecondValue = false;
                int ResistanceTextInstanceGreenFirstValue= 0;
                int ResistanceTextInstanceGreenSecondValue= 0;
                bool setResistanceTextInstanceRedFirstValue = false;
                bool setResistanceTextInstanceRedSecondValue = false;
                int ResistanceTextInstanceRedFirstValue= 0;
                int ResistanceTextInstanceRedSecondValue= 0;
                switch(firstState)
                {
                    case  Upgraded.IsUpgraded:
                        setResistanceTextInstanceBlueFirstValue = true;
                        ResistanceTextInstanceBlueFirstValue = 0;
                        setResistanceTextInstanceGreenFirstValue = true;
                        ResistanceTextInstanceGreenFirstValue = 255;
                        setResistanceTextInstanceRedFirstValue = true;
                        ResistanceTextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.Visible = true;
                        }
                        break;
                    case  Upgraded.NotUpgraded:
                        setResistanceTextInstanceBlueFirstValue = true;
                        ResistanceTextInstanceBlueFirstValue = 255;
                        setResistanceTextInstanceGreenFirstValue = true;
                        ResistanceTextInstanceGreenFirstValue = 255;
                        setResistanceTextInstanceRedFirstValue = true;
                        ResistanceTextInstanceRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  Upgraded.IsUpgraded:
                        setResistanceTextInstanceBlueSecondValue = true;
                        ResistanceTextInstanceBlueSecondValue = 0;
                        setResistanceTextInstanceGreenSecondValue = true;
                        ResistanceTextInstanceGreenSecondValue = 255;
                        setResistanceTextInstanceRedSecondValue = true;
                        ResistanceTextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.Visible = true;
                        }
                        break;
                    case  Upgraded.NotUpgraded:
                        setResistanceTextInstanceBlueSecondValue = true;
                        ResistanceTextInstanceBlueSecondValue = 255;
                        setResistanceTextInstanceGreenSecondValue = true;
                        ResistanceTextInstanceGreenSecondValue = 255;
                        setResistanceTextInstanceRedSecondValue = true;
                        ResistanceTextInstanceRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.Visible = false;
                        }
                        break;
                }
                if (setResistanceTextInstanceBlueFirstValue && setResistanceTextInstanceBlueSecondValue)
                {
                    ResistanceTextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ResistanceTextInstanceBlueFirstValue* (1 - interpolationValue) + ResistanceTextInstanceBlueSecondValue * interpolationValue);
                }
                if (setResistanceTextInstanceGreenFirstValue && setResistanceTextInstanceGreenSecondValue)
                {
                    ResistanceTextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ResistanceTextInstanceGreenFirstValue* (1 - interpolationValue) + ResistanceTextInstanceGreenSecondValue * interpolationValue);
                }
                if (setResistanceTextInstanceRedFirstValue && setResistanceTextInstanceRedSecondValue)
                {
                    ResistanceTextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ResistanceTextInstanceRedFirstValue* (1 - interpolationValue) + ResistanceTextInstanceRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentUpgradedState = firstState;
                }
                else
                {
                    mCurrentUpgradedState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ResistanceDisplayRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.ResistanceDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ResistanceDisplayRuntime.Upgraded fromState,AbbatoirIntergrade.GumRuntimes.ResistanceDisplayRuntime.Upgraded toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Upgraded toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Upgraded").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentUpgradedState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Upgraded toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentUpgradedState = toState;
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
                DamageTypeIconInstance.StopAnimations();
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
                            Name = "DamageTypeIconInstance.Height",
                            Type = "float",
                            Value = DamageTypeIconInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = DamageTypeIconInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Width",
                            Type = "float",
                            Value = DamageTypeIconInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = DamageTypeIconInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.CustomFontFile",
                            Type = "string",
                            Value = ResistanceTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Font Scale",
                            Type = "float",
                            Value = ResistanceTextInstance.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Height",
                            Type = "float",
                            Value = ResistanceTextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ResistanceTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Text",
                            Type = "string",
                            Value = ResistanceTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = ResistanceTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = ResistanceTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Width",
                            Type = "float",
                            Value = ResistanceTextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Blue",
                            Type = "int",
                            Value = UpgradeSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Green",
                            Type = "int",
                            Value = UpgradeSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Height",
                            Type = "float",
                            Value = UpgradeSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Red",
                            Type = "int",
                            Value = UpgradeSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.SourceFile",
                            Type = "string",
                            Value = UpgradeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = UpgradeSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Texture Height",
                            Type = "int",
                            Value = UpgradeSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Texture Left",
                            Type = "int",
                            Value = UpgradeSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Texture Top",
                            Type = "int",
                            Value = UpgradeSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Texture Width",
                            Type = "int",
                            Value = UpgradeSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Visible",
                            Type = "bool",
                            Value = UpgradeSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Width",
                            Type = "float",
                            Value = UpgradeSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = UpgradeSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = UpgradeSprite.YUnits
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
                            Name = "DamageTypeIconInstance.Height",
                            Type = "float",
                            Value = DamageTypeIconInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = DamageTypeIconInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Width",
                            Type = "float",
                            Value = DamageTypeIconInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = DamageTypeIconInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.CustomFontFile",
                            Type = "string",
                            Value = ResistanceTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Font Scale",
                            Type = "float",
                            Value = ResistanceTextInstance.FontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Height",
                            Type = "float",
                            Value = ResistanceTextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ResistanceTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Text",
                            Type = "string",
                            Value = ResistanceTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = ResistanceTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = ResistanceTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Width",
                            Type = "float",
                            Value = ResistanceTextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Blue",
                            Type = "int",
                            Value = UpgradeSprite.Blue + 140
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Green",
                            Type = "int",
                            Value = UpgradeSprite.Green + 230
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Height",
                            Type = "float",
                            Value = UpgradeSprite.Height + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Red",
                            Type = "int",
                            Value = UpgradeSprite.Red + 240
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.SourceFile",
                            Type = "string",
                            Value = UpgradeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = UpgradeSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Texture Height",
                            Type = "int",
                            Value = UpgradeSprite.TextureHeight + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Texture Left",
                            Type = "int",
                            Value = UpgradeSprite.TextureLeft + 2565
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Texture Top",
                            Type = "int",
                            Value = UpgradeSprite.TextureTop + 910
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Texture Width",
                            Type = "int",
                            Value = UpgradeSprite.TextureWidth + 111
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Visible",
                            Type = "bool",
                            Value = UpgradeSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Width",
                            Type = "float",
                            Value = UpgradeSprite.Width + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = UpgradeSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = UpgradeSprite.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Upgraded state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Upgraded.IsUpgraded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Blue",
                            Type = "int",
                            Value = ResistanceTextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Green",
                            Type = "int",
                            Value = ResistanceTextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Red",
                            Type = "int",
                            Value = ResistanceTextInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Visible",
                            Type = "bool",
                            Value = UpgradeSprite.Visible
                        }
                        );
                        break;
                    case  Upgraded.NotUpgraded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Blue",
                            Type = "int",
                            Value = ResistanceTextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Green",
                            Type = "int",
                            Value = ResistanceTextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Red",
                            Type = "int",
                            Value = ResistanceTextInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Visible",
                            Type = "bool",
                            Value = UpgradeSprite.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Upgraded state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Upgraded.IsUpgraded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Blue",
                            Type = "int",
                            Value = ResistanceTextInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Green",
                            Type = "int",
                            Value = ResistanceTextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Red",
                            Type = "int",
                            Value = ResistanceTextInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Visible",
                            Type = "bool",
                            Value = UpgradeSprite.Visible
                        }
                        );
                        break;
                    case  Upgraded.NotUpgraded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Blue",
                            Type = "int",
                            Value = ResistanceTextInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Green",
                            Type = "int",
                            Value = ResistanceTextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Red",
                            Type = "int",
                            Value = ResistanceTextInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Visible",
                            Type = "bool",
                            Value = UpgradeSprite.Visible
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
                    else if (category.Name == "Upgraded")
                    {
                        if(state.Name == "IsUpgraded") this.mCurrentUpgradedState = Upgraded.IsUpgraded;
                        if(state.Name == "NotUpgraded") this.mCurrentUpgradedState = Upgraded.NotUpgraded;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.DamageTypeIconRuntime DamageTypeIconInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime ResistanceTextInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime UpgradeSprite { get; set; }
            public DamageTypeIconRuntime.DamageType DamageTypeIconState
            {
                get
                {
                    return DamageTypeIconInstance.CurrentDamageTypeState;
                }
                set
                {
                    if (DamageTypeIconInstance.CurrentDamageTypeState != value)
                    {
                        DamageTypeIconInstance.CurrentDamageTypeState = value;
                        DamageTypeIconStateChanged?.Invoke(this, null);
                    }
                }
            }
            public float TextFontScale
            {
                get
                {
                    return ResistanceTextInstance.FontScale;
                }
                set
                {
                    if (ResistanceTextInstance.FontScale != value)
                    {
                        ResistanceTextInstance.FontScale = value;
                        TextFontScaleChanged?.Invoke(this, null);
                    }
                }
            }
            public RenderingLibrary.Graphics.HorizontalAlignment TextHorizontalAlignment
            {
                get
                {
                    return ResistanceTextInstance.HorizontalAlignment;
                }
                set
                {
                    if (ResistanceTextInstance.HorizontalAlignment != value)
                    {
                        ResistanceTextInstance.HorizontalAlignment = value;
                        TextHorizontalAlignmentChanged?.Invoke(this, null);
                    }
                }
            }
            public string ResistanceText
            {
                get
                {
                    return ResistanceTextInstance.Text;
                }
                set
                {
                    if (ResistanceTextInstance.Text != value)
                    {
                        ResistanceTextInstance.Text = value;
                        ResistanceTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent DamageTypeIconInstanceClick;
            public event System.EventHandler DamageTypeIconStateChanged;
            public event System.EventHandler TextFontScaleChanged;
            public event System.EventHandler TextHorizontalAlignmentChanged;
            public event System.EventHandler ResistanceTextChanged;
            public ResistanceDisplayRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/ResistanceDisplay");
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
                DamageTypeIconInstance = this.GetGraphicalUiElementByName("DamageTypeIconInstance") as AbbatoirIntergrade.GumRuntimes.DamageTypeIconRuntime;
                ResistanceTextInstance = this.GetGraphicalUiElementByName("ResistanceTextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                UpgradeSprite = this.GetGraphicalUiElementByName("UpgradeSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                DamageTypeIconInstance.Click += (unused) => DamageTypeIconInstanceClick?.Invoke(this);
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
