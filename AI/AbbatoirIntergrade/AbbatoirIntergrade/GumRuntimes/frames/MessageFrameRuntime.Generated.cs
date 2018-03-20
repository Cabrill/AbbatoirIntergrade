    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class MessageFrameRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            Height = 31.32184f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 51.48166f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            X = 23.4375f;
                            XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            Y = 24.14021f;
                            YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            TopSprite.Height = 23f;
                            TopSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("TopSprite.SourceFile", "AllUIAssets.png");
                            TopSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            TopSprite.TextureHeight = 70;
                            TopSprite.TextureLeft = 0;
                            TopSprite.TextureTop = 3552;
                            TopSprite.TextureWidth = 1320;
                            TopSprite.Width = 100f;
                            TopSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MiddleSprite.Height = 53f;
                            MiddleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("MiddleSprite.SourceFile", "AllUIAssets.png");
                            MiddleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            MiddleSprite.TextureHeight = 159;
                            MiddleSprite.TextureLeft = 0;
                            MiddleSprite.TextureTop = 3648;
                            MiddleSprite.TextureWidth = 1320;
                            MiddleSprite.Width = 100f;
                            MiddleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BottomSprite.Height = 23f;
                            BottomSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("BottomSprite.SourceFile", "AllUIAssets.png");
                            BottomSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            BottomSprite.TextureHeight = 70;
                            BottomSprite.TextureLeft = 0;
                            BottomSprite.TextureTop = 3840;
                            BottomSprite.TextureWidth = 1320;
                            BottomSprite.Width = 100f;
                            BottomSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                bool setMiddleSpriteHeightFirstValue = false;
                bool setMiddleSpriteHeightSecondValue = false;
                float MiddleSpriteHeightFirstValue= 0;
                float MiddleSpriteHeightSecondValue= 0;
                bool setMiddleSpriteTextureHeightFirstValue = false;
                bool setMiddleSpriteTextureHeightSecondValue = false;
                int MiddleSpriteTextureHeightFirstValue= 0;
                int MiddleSpriteTextureHeightSecondValue= 0;
                bool setMiddleSpriteTextureLeftFirstValue = false;
                bool setMiddleSpriteTextureLeftSecondValue = false;
                int MiddleSpriteTextureLeftFirstValue= 0;
                int MiddleSpriteTextureLeftSecondValue= 0;
                bool setMiddleSpriteTextureTopFirstValue = false;
                bool setMiddleSpriteTextureTopSecondValue = false;
                int MiddleSpriteTextureTopFirstValue= 0;
                int MiddleSpriteTextureTopSecondValue= 0;
                bool setMiddleSpriteTextureWidthFirstValue = false;
                bool setMiddleSpriteTextureWidthSecondValue = false;
                int MiddleSpriteTextureWidthFirstValue= 0;
                int MiddleSpriteTextureWidthSecondValue= 0;
                bool setMiddleSpriteWidthFirstValue = false;
                bool setMiddleSpriteWidthSecondValue = false;
                float MiddleSpriteWidthFirstValue= 0;
                float MiddleSpriteWidthSecondValue= 0;
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
                        setBottomSpriteHeightFirstValue = true;
                        BottomSpriteHeightFirstValue = 23f;
                        if (interpolationValue < 1)
                        {
                            this.BottomSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 31.32184f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMiddleSpriteHeightFirstValue = true;
                        MiddleSpriteHeightFirstValue = 53f;
                        if (interpolationValue < 1)
                        {
                            this.MiddleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MiddleSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MiddleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMiddleSpriteTextureHeightFirstValue = true;
                        MiddleSpriteTextureHeightFirstValue = 159;
                        setMiddleSpriteTextureLeftFirstValue = true;
                        MiddleSpriteTextureLeftFirstValue = 0;
                        setMiddleSpriteTextureTopFirstValue = true;
                        MiddleSpriteTextureTopFirstValue = 3648;
                        setMiddleSpriteTextureWidthFirstValue = true;
                        MiddleSpriteTextureWidthFirstValue = 1320;
                        setMiddleSpriteWidthFirstValue = true;
                        MiddleSpriteWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MiddleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTopSpriteHeightFirstValue = true;
                        TopSpriteHeightFirstValue = 23f;
                        if (interpolationValue < 1)
                        {
                            this.TopSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                        WidthFirstValue = 51.48166f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setXFirstValue = true;
                        XFirstValue = 23.4375f;
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setYFirstValue = true;
                        YFirstValue = 24.14021f;
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBottomSpriteHeightSecondValue = true;
                        BottomSpriteHeightSecondValue = 23f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 31.32184f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMiddleSpriteHeightSecondValue = true;
                        MiddleSpriteHeightSecondValue = 53f;
                        if (interpolationValue >= 1)
                        {
                            this.MiddleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MiddleSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MiddleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMiddleSpriteTextureHeightSecondValue = true;
                        MiddleSpriteTextureHeightSecondValue = 159;
                        setMiddleSpriteTextureLeftSecondValue = true;
                        MiddleSpriteTextureLeftSecondValue = 0;
                        setMiddleSpriteTextureTopSecondValue = true;
                        MiddleSpriteTextureTopSecondValue = 3648;
                        setMiddleSpriteTextureWidthSecondValue = true;
                        MiddleSpriteTextureWidthSecondValue = 1320;
                        setMiddleSpriteWidthSecondValue = true;
                        MiddleSpriteWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MiddleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTopSpriteHeightSecondValue = true;
                        TopSpriteHeightSecondValue = 23f;
                        if (interpolationValue >= 1)
                        {
                            this.TopSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                        WidthSecondValue = 51.48166f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setXSecondValue = true;
                        XSecondValue = 23.4375f;
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setYSecondValue = true;
                        YSecondValue = 24.14021f;
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        break;
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
                if (setMiddleSpriteHeightFirstValue && setMiddleSpriteHeightSecondValue)
                {
                    MiddleSprite.Height = MiddleSpriteHeightFirstValue * (1 - interpolationValue) + MiddleSpriteHeightSecondValue * interpolationValue;
                }
                if (setMiddleSpriteTextureHeightFirstValue && setMiddleSpriteTextureHeightSecondValue)
                {
                    MiddleSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleSpriteTextureHeightFirstValue* (1 - interpolationValue) + MiddleSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setMiddleSpriteTextureLeftFirstValue && setMiddleSpriteTextureLeftSecondValue)
                {
                    MiddleSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleSpriteTextureLeftFirstValue* (1 - interpolationValue) + MiddleSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setMiddleSpriteTextureTopFirstValue && setMiddleSpriteTextureTopSecondValue)
                {
                    MiddleSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleSpriteTextureTopFirstValue* (1 - interpolationValue) + MiddleSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setMiddleSpriteTextureWidthFirstValue && setMiddleSpriteTextureWidthSecondValue)
                {
                    MiddleSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleSpriteTextureWidthFirstValue* (1 - interpolationValue) + MiddleSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setMiddleSpriteWidthFirstValue && setMiddleSpriteWidthSecondValue)
                {
                    MiddleSprite.Width = MiddleSpriteWidthFirstValue * (1 - interpolationValue) + MiddleSpriteWidthSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MessageFrameRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.MessageFrameRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
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
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
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
                            Name = "MiddleSprite.Height",
                            Type = "float",
                            Value = MiddleSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = MiddleSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.SourceFile",
                            Type = "string",
                            Value = MiddleSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = MiddleSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Texture Height",
                            Type = "int",
                            Value = MiddleSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Texture Left",
                            Type = "int",
                            Value = MiddleSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Texture Top",
                            Type = "int",
                            Value = MiddleSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Texture Width",
                            Type = "int",
                            Value = MiddleSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Width",
                            Type = "float",
                            Value = MiddleSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = MiddleSprite.WidthUnits
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
                            Value = Height + 31.32184f
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
                            Value = Width + 51.48166f
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
                            Value = X + 23.4375f
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
                            Name = "Y",
                            Type = "float",
                            Value = Y + 24.14021f
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
                            Name = "TopSprite.Height",
                            Type = "float",
                            Value = TopSprite.Height + 23f
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
                            Name = "MiddleSprite.Height",
                            Type = "float",
                            Value = MiddleSprite.Height + 53f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = MiddleSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.SourceFile",
                            Type = "string",
                            Value = MiddleSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = MiddleSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Texture Height",
                            Type = "int",
                            Value = MiddleSprite.TextureHeight + 159
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Texture Left",
                            Type = "int",
                            Value = MiddleSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Texture Top",
                            Type = "int",
                            Value = MiddleSprite.TextureTop + 3648
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Texture Width",
                            Type = "int",
                            Value = MiddleSprite.TextureWidth + 1320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Width",
                            Type = "float",
                            Value = MiddleSprite.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MiddleSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = MiddleSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomSprite.Height",
                            Type = "float",
                            Value = BottomSprite.Height + 23f
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
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime MiddleSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BottomSprite { get; set; }
            public MessageFrameRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "frames/MessageFrame");
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
                MiddleSprite = this.GetGraphicalUiElementByName("MiddleSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                BottomSprite = this.GetGraphicalUiElementByName("BottomSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
