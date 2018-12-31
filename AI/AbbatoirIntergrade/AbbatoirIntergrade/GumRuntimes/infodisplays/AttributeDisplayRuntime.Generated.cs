    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes.infodisplays
    {
        public partial class AttributeDisplayRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Upgraded
            {
                IsUpgraded,
                NotUpgraded,
                IsUpgradedNoArrow
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Upgraded? mCurrentUpgradedState;
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
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            AttributeIconInstance.Height = 0f;
                            AttributeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            AttributeIconInstance.Width = 100f;
                            AttributeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            AttributeIconInstance.X = 5f;
                            AttributeIconInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("AttributeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            AttributeTextInstance.Height = 0f;
                            AttributeTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            AttributeTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            AttributeTextInstance.Text = "100%";
                            AttributeTextInstance.UseCustomFont = true;
                            AttributeTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            AttributeTextInstance.Width = 0f;
                            AttributeTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            AttributeTextInstance.X = 10f;
                            AttributeTextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            UpgradeSprite.Height = 32f;
                            UpgradeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
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
            public Upgraded? CurrentUpgradedState
            {
                get
                {
                    return mCurrentUpgradedState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentUpgradedState = value;
                        switch(mCurrentUpgradedState)
                        {
                            case  Upgraded.IsUpgraded:
                                AttributeTextInstance.Blue = 0;
                                AttributeTextInstance.Green = 255;
                                AttributeTextInstance.Red = 0;
                                UpgradeSprite.Blue = 140;
                                UpgradeSprite.Green = 230;
                                UpgradeSprite.Red = 240;
                                UpgradeSprite.Visible = true;
                                break;
                            case  Upgraded.NotUpgraded:
                                AttributeTextInstance.Blue = 255;
                                AttributeTextInstance.Green = 255;
                                AttributeTextInstance.Red = 255;
                                UpgradeSprite.Blue = 255;
                                UpgradeSprite.Green = 255;
                                UpgradeSprite.Red = 255;
                                UpgradeSprite.Visible = false;
                                break;
                            case  Upgraded.IsUpgradedNoArrow:
                                AttributeTextInstance.Blue = 0;
                                AttributeTextInstance.Green = 255;
                                AttributeTextInstance.Red = 0;
                                UpgradeSprite.Blue = 255;
                                UpgradeSprite.Green = 255;
                                UpgradeSprite.Red = 255;
                                UpgradeSprite.Visible = false;
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
                bool setAttributeIconInstanceHeightFirstValue = false;
                bool setAttributeIconInstanceHeightSecondValue = false;
                float AttributeIconInstanceHeightFirstValue= 0;
                float AttributeIconInstanceHeightSecondValue= 0;
                bool setAttributeIconInstanceWidthFirstValue = false;
                bool setAttributeIconInstanceWidthSecondValue = false;
                float AttributeIconInstanceWidthFirstValue= 0;
                float AttributeIconInstanceWidthSecondValue= 0;
                bool setAttributeIconInstanceXFirstValue = false;
                bool setAttributeIconInstanceXSecondValue = false;
                float AttributeIconInstanceXFirstValue= 0;
                float AttributeIconInstanceXSecondValue= 0;
                bool setAttributeTextInstanceHeightFirstValue = false;
                bool setAttributeTextInstanceHeightSecondValue = false;
                float AttributeTextInstanceHeightFirstValue= 0;
                float AttributeTextInstanceHeightSecondValue= 0;
                bool setAttributeTextInstanceWidthFirstValue = false;
                bool setAttributeTextInstanceWidthSecondValue = false;
                float AttributeTextInstanceWidthFirstValue= 0;
                float AttributeTextInstanceWidthSecondValue= 0;
                bool setAttributeTextInstanceXFirstValue = false;
                bool setAttributeTextInstanceXSecondValue = false;
                float AttributeTextInstanceXFirstValue= 0;
                float AttributeTextInstanceXSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setUpgradeSpriteHeightFirstValue = false;
                bool setUpgradeSpriteHeightSecondValue = false;
                float UpgradeSpriteHeightFirstValue= 0;
                float UpgradeSpriteHeightSecondValue= 0;
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
                        setAttributeIconInstanceHeightFirstValue = true;
                        AttributeIconInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setAttributeIconInstanceWidthFirstValue = true;
                        AttributeIconInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setAttributeIconInstanceXFirstValue = true;
                        AttributeIconInstanceXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("AttributeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setAttributeTextInstanceHeightFirstValue = true;
                        AttributeTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.Text = "100%";
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setAttributeTextInstanceWidthFirstValue = true;
                        AttributeTextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setAttributeTextInstanceXFirstValue = true;
                        AttributeTextInstanceXFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setUpgradeSpriteHeightFirstValue = true;
                        UpgradeSpriteHeightFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
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
                        setAttributeIconInstanceHeightSecondValue = true;
                        AttributeIconInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setAttributeIconInstanceWidthSecondValue = true;
                        AttributeIconInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setAttributeIconInstanceXSecondValue = true;
                        AttributeIconInstanceXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("AttributeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setAttributeTextInstanceHeightSecondValue = true;
                        AttributeTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.Text = "100%";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setAttributeTextInstanceWidthSecondValue = true;
                        AttributeTextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setAttributeTextInstanceXSecondValue = true;
                        AttributeTextInstanceXSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setUpgradeSpriteHeightSecondValue = true;
                        UpgradeSpriteHeightSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
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
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        break;
                }
                if (setAttributeIconInstanceHeightFirstValue && setAttributeIconInstanceHeightSecondValue)
                {
                    AttributeIconInstance.Height = AttributeIconInstanceHeightFirstValue * (1 - interpolationValue) + AttributeIconInstanceHeightSecondValue * interpolationValue;
                }
                if (setAttributeIconInstanceWidthFirstValue && setAttributeIconInstanceWidthSecondValue)
                {
                    AttributeIconInstance.Width = AttributeIconInstanceWidthFirstValue * (1 - interpolationValue) + AttributeIconInstanceWidthSecondValue * interpolationValue;
                }
                if (setAttributeIconInstanceXFirstValue && setAttributeIconInstanceXSecondValue)
                {
                    AttributeIconInstance.X = AttributeIconInstanceXFirstValue * (1 - interpolationValue) + AttributeIconInstanceXSecondValue * interpolationValue;
                }
                if (setAttributeTextInstanceHeightFirstValue && setAttributeTextInstanceHeightSecondValue)
                {
                    AttributeTextInstance.Height = AttributeTextInstanceHeightFirstValue * (1 - interpolationValue) + AttributeTextInstanceHeightSecondValue * interpolationValue;
                }
                if (setAttributeTextInstanceWidthFirstValue && setAttributeTextInstanceWidthSecondValue)
                {
                    AttributeTextInstance.Width = AttributeTextInstanceWidthFirstValue * (1 - interpolationValue) + AttributeTextInstanceWidthSecondValue * interpolationValue;
                }
                if (setAttributeTextInstanceXFirstValue && setAttributeTextInstanceXSecondValue)
                {
                    AttributeTextInstance.X = AttributeTextInstanceXFirstValue * (1 - interpolationValue) + AttributeTextInstanceXSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setUpgradeSpriteHeightFirstValue && setUpgradeSpriteHeightSecondValue)
                {
                    UpgradeSprite.Height = UpgradeSpriteHeightFirstValue * (1 - interpolationValue) + UpgradeSpriteHeightSecondValue * interpolationValue;
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
                bool setAttributeTextInstanceBlueFirstValue = false;
                bool setAttributeTextInstanceBlueSecondValue = false;
                int AttributeTextInstanceBlueFirstValue= 0;
                int AttributeTextInstanceBlueSecondValue= 0;
                bool setAttributeTextInstanceGreenFirstValue = false;
                bool setAttributeTextInstanceGreenSecondValue = false;
                int AttributeTextInstanceGreenFirstValue= 0;
                int AttributeTextInstanceGreenSecondValue= 0;
                bool setAttributeTextInstanceRedFirstValue = false;
                bool setAttributeTextInstanceRedSecondValue = false;
                int AttributeTextInstanceRedFirstValue= 0;
                int AttributeTextInstanceRedSecondValue= 0;
                bool setUpgradeSpriteBlueFirstValue = false;
                bool setUpgradeSpriteBlueSecondValue = false;
                int UpgradeSpriteBlueFirstValue= 0;
                int UpgradeSpriteBlueSecondValue= 0;
                bool setUpgradeSpriteGreenFirstValue = false;
                bool setUpgradeSpriteGreenSecondValue = false;
                int UpgradeSpriteGreenFirstValue= 0;
                int UpgradeSpriteGreenSecondValue= 0;
                bool setUpgradeSpriteRedFirstValue = false;
                bool setUpgradeSpriteRedSecondValue = false;
                int UpgradeSpriteRedFirstValue= 0;
                int UpgradeSpriteRedSecondValue= 0;
                switch(firstState)
                {
                    case  Upgraded.IsUpgraded:
                        setAttributeTextInstanceBlueFirstValue = true;
                        AttributeTextInstanceBlueFirstValue = 0;
                        setAttributeTextInstanceGreenFirstValue = true;
                        AttributeTextInstanceGreenFirstValue = 255;
                        setAttributeTextInstanceRedFirstValue = true;
                        AttributeTextInstanceRedFirstValue = 0;
                        setUpgradeSpriteBlueFirstValue = true;
                        UpgradeSpriteBlueFirstValue = 140;
                        setUpgradeSpriteGreenFirstValue = true;
                        UpgradeSpriteGreenFirstValue = 230;
                        setUpgradeSpriteRedFirstValue = true;
                        UpgradeSpriteRedFirstValue = 240;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.Visible = true;
                        }
                        break;
                    case  Upgraded.NotUpgraded:
                        setAttributeTextInstanceBlueFirstValue = true;
                        AttributeTextInstanceBlueFirstValue = 255;
                        setAttributeTextInstanceGreenFirstValue = true;
                        AttributeTextInstanceGreenFirstValue = 255;
                        setAttributeTextInstanceRedFirstValue = true;
                        AttributeTextInstanceRedFirstValue = 255;
                        setUpgradeSpriteBlueFirstValue = true;
                        UpgradeSpriteBlueFirstValue = 255;
                        setUpgradeSpriteGreenFirstValue = true;
                        UpgradeSpriteGreenFirstValue = 255;
                        setUpgradeSpriteRedFirstValue = true;
                        UpgradeSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.Visible = false;
                        }
                        break;
                    case  Upgraded.IsUpgradedNoArrow:
                        setAttributeTextInstanceBlueFirstValue = true;
                        AttributeTextInstanceBlueFirstValue = 0;
                        setAttributeTextInstanceGreenFirstValue = true;
                        AttributeTextInstanceGreenFirstValue = 255;
                        setAttributeTextInstanceRedFirstValue = true;
                        AttributeTextInstanceRedFirstValue = 0;
                        setUpgradeSpriteBlueFirstValue = true;
                        UpgradeSpriteBlueFirstValue = 255;
                        setUpgradeSpriteGreenFirstValue = true;
                        UpgradeSpriteGreenFirstValue = 255;
                        setUpgradeSpriteRedFirstValue = true;
                        UpgradeSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeSprite.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  Upgraded.IsUpgraded:
                        setAttributeTextInstanceBlueSecondValue = true;
                        AttributeTextInstanceBlueSecondValue = 0;
                        setAttributeTextInstanceGreenSecondValue = true;
                        AttributeTextInstanceGreenSecondValue = 255;
                        setAttributeTextInstanceRedSecondValue = true;
                        AttributeTextInstanceRedSecondValue = 0;
                        setUpgradeSpriteBlueSecondValue = true;
                        UpgradeSpriteBlueSecondValue = 140;
                        setUpgradeSpriteGreenSecondValue = true;
                        UpgradeSpriteGreenSecondValue = 230;
                        setUpgradeSpriteRedSecondValue = true;
                        UpgradeSpriteRedSecondValue = 240;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.Visible = true;
                        }
                        break;
                    case  Upgraded.NotUpgraded:
                        setAttributeTextInstanceBlueSecondValue = true;
                        AttributeTextInstanceBlueSecondValue = 255;
                        setAttributeTextInstanceGreenSecondValue = true;
                        AttributeTextInstanceGreenSecondValue = 255;
                        setAttributeTextInstanceRedSecondValue = true;
                        AttributeTextInstanceRedSecondValue = 255;
                        setUpgradeSpriteBlueSecondValue = true;
                        UpgradeSpriteBlueSecondValue = 255;
                        setUpgradeSpriteGreenSecondValue = true;
                        UpgradeSpriteGreenSecondValue = 255;
                        setUpgradeSpriteRedSecondValue = true;
                        UpgradeSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.Visible = false;
                        }
                        break;
                    case  Upgraded.IsUpgradedNoArrow:
                        setAttributeTextInstanceBlueSecondValue = true;
                        AttributeTextInstanceBlueSecondValue = 0;
                        setAttributeTextInstanceGreenSecondValue = true;
                        AttributeTextInstanceGreenSecondValue = 255;
                        setAttributeTextInstanceRedSecondValue = true;
                        AttributeTextInstanceRedSecondValue = 0;
                        setUpgradeSpriteBlueSecondValue = true;
                        UpgradeSpriteBlueSecondValue = 255;
                        setUpgradeSpriteGreenSecondValue = true;
                        UpgradeSpriteGreenSecondValue = 255;
                        setUpgradeSpriteRedSecondValue = true;
                        UpgradeSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeSprite.Visible = false;
                        }
                        break;
                }
                if (setAttributeTextInstanceBlueFirstValue && setAttributeTextInstanceBlueSecondValue)
                {
                    AttributeTextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(AttributeTextInstanceBlueFirstValue* (1 - interpolationValue) + AttributeTextInstanceBlueSecondValue * interpolationValue);
                }
                if (setAttributeTextInstanceGreenFirstValue && setAttributeTextInstanceGreenSecondValue)
                {
                    AttributeTextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(AttributeTextInstanceGreenFirstValue* (1 - interpolationValue) + AttributeTextInstanceGreenSecondValue * interpolationValue);
                }
                if (setAttributeTextInstanceRedFirstValue && setAttributeTextInstanceRedSecondValue)
                {
                    AttributeTextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(AttributeTextInstanceRedFirstValue* (1 - interpolationValue) + AttributeTextInstanceRedSecondValue * interpolationValue);
                }
                if (setUpgradeSpriteBlueFirstValue && setUpgradeSpriteBlueSecondValue)
                {
                    UpgradeSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeSpriteBlueFirstValue* (1 - interpolationValue) + UpgradeSpriteBlueSecondValue * interpolationValue);
                }
                if (setUpgradeSpriteGreenFirstValue && setUpgradeSpriteGreenSecondValue)
                {
                    UpgradeSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeSpriteGreenFirstValue* (1 - interpolationValue) + UpgradeSpriteGreenSecondValue * interpolationValue);
                }
                if (setUpgradeSpriteRedFirstValue && setUpgradeSpriteRedSecondValue)
                {
                    UpgradeSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeSpriteRedFirstValue* (1 - interpolationValue) + UpgradeSpriteRedSecondValue * interpolationValue);
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime.Upgraded fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime.Upgraded toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                AttributeIconInstance.StopAnimations();
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
                            Name = "AttributeIconInstance.Height",
                            Type = "float",
                            Value = AttributeIconInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width",
                            Type = "float",
                            Value = AttributeIconInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.X",
                            Type = "float",
                            Value = AttributeIconInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.X Units",
                            Type = "PositionUnitType",
                            Value = AttributeIconInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.CustomFontFile",
                            Type = "string",
                            Value = AttributeTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Height",
                            Type = "float",
                            Value = AttributeTextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = AttributeTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Text",
                            Type = "string",
                            Value = AttributeTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = AttributeTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = AttributeTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Width",
                            Type = "float",
                            Value = AttributeTextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.X",
                            Type = "float",
                            Value = AttributeTextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = AttributeTextInstance.XUnits
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
                            Name = "AttributeIconInstance.Height",
                            Type = "float",
                            Value = AttributeIconInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width",
                            Type = "float",
                            Value = AttributeIconInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.X",
                            Type = "float",
                            Value = AttributeIconInstance.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.X Units",
                            Type = "PositionUnitType",
                            Value = AttributeIconInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.CustomFontFile",
                            Type = "string",
                            Value = AttributeTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Height",
                            Type = "float",
                            Value = AttributeTextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = AttributeTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Text",
                            Type = "string",
                            Value = AttributeTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = AttributeTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = AttributeTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Width",
                            Type = "float",
                            Value = AttributeTextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.X",
                            Type = "float",
                            Value = AttributeTextInstance.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = AttributeTextInstance.XUnits
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
                            Name = "AttributeTextInstance.Blue",
                            Type = "int",
                            Value = AttributeTextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Green",
                            Type = "int",
                            Value = AttributeTextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Red",
                            Type = "int",
                            Value = AttributeTextInstance.Red
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
                            Name = "UpgradeSprite.Red",
                            Type = "int",
                            Value = UpgradeSprite.Red
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
                            Name = "AttributeTextInstance.Blue",
                            Type = "int",
                            Value = AttributeTextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Green",
                            Type = "int",
                            Value = AttributeTextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Red",
                            Type = "int",
                            Value = AttributeTextInstance.Red
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
                            Name = "UpgradeSprite.Red",
                            Type = "int",
                            Value = UpgradeSprite.Red
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
                    case  Upgraded.IsUpgradedNoArrow:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Blue",
                            Type = "int",
                            Value = AttributeTextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Green",
                            Type = "int",
                            Value = AttributeTextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Red",
                            Type = "int",
                            Value = AttributeTextInstance.Red
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
                            Name = "UpgradeSprite.Red",
                            Type = "int",
                            Value = UpgradeSprite.Red
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
                            Name = "AttributeTextInstance.Blue",
                            Type = "int",
                            Value = AttributeTextInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Green",
                            Type = "int",
                            Value = AttributeTextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Red",
                            Type = "int",
                            Value = AttributeTextInstance.Red + 0
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
                            Name = "UpgradeSprite.Red",
                            Type = "int",
                            Value = UpgradeSprite.Red + 240
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
                            Name = "AttributeTextInstance.Blue",
                            Type = "int",
                            Value = AttributeTextInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Green",
                            Type = "int",
                            Value = AttributeTextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Red",
                            Type = "int",
                            Value = AttributeTextInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Blue",
                            Type = "int",
                            Value = UpgradeSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Green",
                            Type = "int",
                            Value = UpgradeSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Red",
                            Type = "int",
                            Value = UpgradeSprite.Red + 255
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
                    case  Upgraded.IsUpgradedNoArrow:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Blue",
                            Type = "int",
                            Value = AttributeTextInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Green",
                            Type = "int",
                            Value = AttributeTextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Red",
                            Type = "int",
                            Value = AttributeTextInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Blue",
                            Type = "int",
                            Value = UpgradeSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Green",
                            Type = "int",
                            Value = UpgradeSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeSprite.Red",
                            Type = "int",
                            Value = UpgradeSprite.Red + 255
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
                        if(state.Name == "IsUpgradedNoArrow") this.mCurrentUpgradedState = Upgraded.IsUpgradedNoArrow;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime AttributeIconInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime AttributeTextInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime UpgradeSprite { get; set; }
            public AttributeIconRuntime.AttributeType? AttributeIconTypeState
            {
                get
                {
                    return AttributeIconInstance.CurrentAttributeTypeState;
                }
                set
                {
                    if (AttributeIconInstance.CurrentAttributeTypeState != value)
                    {
                        AttributeIconInstance.CurrentAttributeTypeState = value;
                        AttributeIconTypeStateChanged?.Invoke(this, null);
                    }
                }
            }
            public float TextInstanceFontScale
            {
                get
                {
                    return AttributeTextInstance.FontScale;
                }
                set
                {
                    if (AttributeTextInstance.FontScale != value)
                    {
                        AttributeTextInstance.FontScale = value;
                        TextInstanceFontScaleChanged?.Invoke(this, null);
                    }
                }
            }
            public RenderingLibrary.Graphics.HorizontalAlignment TextInstanceHorizontalAlignment
            {
                get
                {
                    return AttributeTextInstance.HorizontalAlignment;
                }
                set
                {
                    if (AttributeTextInstance.HorizontalAlignment != value)
                    {
                        AttributeTextInstance.HorizontalAlignment = value;
                        TextInstanceHorizontalAlignmentChanged?.Invoke(this, null);
                    }
                }
            }
            public string AttributeText
            {
                get
                {
                    return AttributeTextInstance.Text;
                }
                set
                {
                    if (AttributeTextInstance.Text != value)
                    {
                        AttributeTextInstance.Text = value;
                        AttributeTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent AttributeIconInstanceClick;
            public event System.EventHandler AttributeIconTypeStateChanged;
            public event System.EventHandler TextInstanceFontScaleChanged;
            public event System.EventHandler TextInstanceHorizontalAlignmentChanged;
            public event System.EventHandler AttributeTextChanged;
            public AttributeDisplayRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/AttributeDisplay");
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
                AttributeIconInstance = this.GetGraphicalUiElementByName("AttributeIconInstance") as AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime;
                AttributeTextInstance = this.GetGraphicalUiElementByName("AttributeTextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                UpgradeSprite = this.GetGraphicalUiElementByName("UpgradeSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                AttributeIconInstance.Click += (unused) => AttributeIconInstanceClick?.Invoke(this);
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
