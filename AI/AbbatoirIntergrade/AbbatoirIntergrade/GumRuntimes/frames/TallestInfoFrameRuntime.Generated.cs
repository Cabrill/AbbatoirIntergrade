    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class TallestInfoFrameRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BackgroundSprite.Height = 100f;
                            BackgroundSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("BackgroundSprite.SourceFile", "AllUIAssets.png");
                            BackgroundSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            BackgroundSprite.TextureHeight = 1492;
                            BackgroundSprite.TextureLeft = 2560;
                            BackgroundSprite.TextureTop = 2464;
                            BackgroundSprite.TextureWidth = 860;
                            BackgroundSprite.Width = 57.64f;
                            BackgroundSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            BackgroundSprite.X = 0f;
                            BackgroundSprite.Y = 0f;
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
                bool setBackgroundSpriteXFirstValue = false;
                bool setBackgroundSpriteXSecondValue = false;
                float BackgroundSpriteXFirstValue= 0;
                float BackgroundSpriteXSecondValue= 0;
                bool setBackgroundSpriteYFirstValue = false;
                bool setBackgroundSpriteYSecondValue = false;
                float BackgroundSpriteYFirstValue= 0;
                float BackgroundSpriteYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
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
                            this.BackgroundSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                        BackgroundSpriteTextureHeightFirstValue = 1492;
                        setBackgroundSpriteTextureLeftFirstValue = true;
                        BackgroundSpriteTextureLeftFirstValue = 2560;
                        setBackgroundSpriteTextureTopFirstValue = true;
                        BackgroundSpriteTextureTopFirstValue = 2464;
                        setBackgroundSpriteTextureWidthFirstValue = true;
                        BackgroundSpriteTextureWidthFirstValue = 860;
                        setBackgroundSpriteWidthFirstValue = true;
                        BackgroundSpriteWidthFirstValue = 57.64f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setBackgroundSpriteXFirstValue = true;
                        BackgroundSpriteXFirstValue = 0f;
                        setBackgroundSpriteYFirstValue = true;
                        BackgroundSpriteYFirstValue = 0f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                            this.BackgroundSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                        BackgroundSpriteTextureHeightSecondValue = 1492;
                        setBackgroundSpriteTextureLeftSecondValue = true;
                        BackgroundSpriteTextureLeftSecondValue = 2560;
                        setBackgroundSpriteTextureTopSecondValue = true;
                        BackgroundSpriteTextureTopSecondValue = 2464;
                        setBackgroundSpriteTextureWidthSecondValue = true;
                        BackgroundSpriteTextureWidthSecondValue = 860;
                        setBackgroundSpriteWidthSecondValue = true;
                        BackgroundSpriteWidthSecondValue = 57.64f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setBackgroundSpriteXSecondValue = true;
                        BackgroundSpriteXSecondValue = 0f;
                        setBackgroundSpriteYSecondValue = true;
                        BackgroundSpriteYSecondValue = 0f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                if (setBackgroundSpriteXFirstValue && setBackgroundSpriteXSecondValue)
                {
                    BackgroundSprite.X = BackgroundSpriteXFirstValue * (1 - interpolationValue) + BackgroundSpriteXSecondValue * interpolationValue;
                }
                if (setBackgroundSpriteYFirstValue && setBackgroundSpriteYSecondValue)
                {
                    BackgroundSprite.Y = BackgroundSpriteYFirstValue * (1 - interpolationValue) + BackgroundSpriteYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TallestInfoFrameRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.TallestInfoFrameRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
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
                            Name = "BackgroundSprite.X",
                            Type = "float",
                            Value = BackgroundSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Y",
                            Type = "float",
                            Value = BackgroundSprite.Y
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
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
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
                            Value = BackgroundSprite.TextureHeight + 1492
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Left",
                            Type = "int",
                            Value = BackgroundSprite.TextureLeft + 2560
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Top",
                            Type = "int",
                            Value = BackgroundSprite.TextureTop + 2464
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Texture Width",
                            Type = "int",
                            Value = BackgroundSprite.TextureWidth + 860
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Width",
                            Type = "float",
                            Value = BackgroundSprite.Width + 57.64f
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
                            Name = "BackgroundSprite.X",
                            Type = "float",
                            Value = BackgroundSprite.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundSprite.Y",
                            Type = "float",
                            Value = BackgroundSprite.Y + 0f
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
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BackgroundSprite { get; set; }
            public TallestInfoFrameRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "frames/TallestInfoFrame");
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
