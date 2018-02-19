    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class ThumbRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ButtonCategory mCurrentButtonCategoryState;
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
                            Width = 10f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ThumbSprite.Height = 87.068f;
                            ThumbSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            SetProperty("ThumbSprite.SourceFile", "AllUIAssets.png");
                            ThumbSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            ThumbSprite.TextureHeight = 101;
                            ThumbSprite.TextureLeft = 3590;
                            ThumbSprite.TextureTop = 2017;
                            ThumbSprite.TextureWidth = 116;
                            ThumbSprite.Width = 100f;
                            ThumbSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ThumbSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ThumbSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
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
                            ThumbSprite.Alpha = 255;
                            ThumbSprite.Blue = 255;
                            ThumbSprite.Green = 255;
                            ThumbSprite.Red = 255;
                            break;
                        case  ButtonCategory.Disabled:
                            ThumbSprite.Alpha = 100;
                            ThumbSprite.Blue = 0;
                            ThumbSprite.Green = 0;
                            ThumbSprite.Red = 0;
                            break;
                        case  ButtonCategory.Highlighted:
                            ThumbSprite.Alpha = 255;
                            ThumbSprite.Blue = 210;
                            ThumbSprite.Green = 250;
                            ThumbSprite.Red = 250;
                            break;
                        case  ButtonCategory.Pushed:
                            ThumbSprite.Alpha = 255;
                            ThumbSprite.Blue = 0;
                            ThumbSprite.Green = 255;
                            ThumbSprite.Red = 255;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setThumbSpriteHeightFirstValue = false;
                bool setThumbSpriteHeightSecondValue = false;
                float ThumbSpriteHeightFirstValue= 0;
                float ThumbSpriteHeightSecondValue= 0;
                bool setThumbSpriteTextureHeightFirstValue = false;
                bool setThumbSpriteTextureHeightSecondValue = false;
                int ThumbSpriteTextureHeightFirstValue= 0;
                int ThumbSpriteTextureHeightSecondValue= 0;
                bool setThumbSpriteTextureLeftFirstValue = false;
                bool setThumbSpriteTextureLeftSecondValue = false;
                int ThumbSpriteTextureLeftFirstValue= 0;
                int ThumbSpriteTextureLeftSecondValue= 0;
                bool setThumbSpriteTextureTopFirstValue = false;
                bool setThumbSpriteTextureTopSecondValue = false;
                int ThumbSpriteTextureTopFirstValue= 0;
                int ThumbSpriteTextureTopSecondValue= 0;
                bool setThumbSpriteTextureWidthFirstValue = false;
                bool setThumbSpriteTextureWidthSecondValue = false;
                int ThumbSpriteTextureWidthFirstValue= 0;
                int ThumbSpriteTextureWidthSecondValue= 0;
                bool setThumbSpriteWidthFirstValue = false;
                bool setThumbSpriteWidthSecondValue = false;
                float ThumbSpriteWidthFirstValue= 0;
                float ThumbSpriteWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setThumbSpriteHeightFirstValue = true;
                        ThumbSpriteHeightFirstValue = 87.068f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ThumbSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ThumbSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setThumbSpriteTextureHeightFirstValue = true;
                        ThumbSpriteTextureHeightFirstValue = 101;
                        setThumbSpriteTextureLeftFirstValue = true;
                        ThumbSpriteTextureLeftFirstValue = 3590;
                        setThumbSpriteTextureTopFirstValue = true;
                        ThumbSpriteTextureTopFirstValue = 2017;
                        setThumbSpriteTextureWidthFirstValue = true;
                        ThumbSpriteTextureWidthFirstValue = 116;
                        setThumbSpriteWidthFirstValue = true;
                        ThumbSpriteWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ThumbSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ThumbSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setThumbSpriteHeightSecondValue = true;
                        ThumbSpriteHeightSecondValue = 87.068f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ThumbSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ThumbSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setThumbSpriteTextureHeightSecondValue = true;
                        ThumbSpriteTextureHeightSecondValue = 101;
                        setThumbSpriteTextureLeftSecondValue = true;
                        ThumbSpriteTextureLeftSecondValue = 3590;
                        setThumbSpriteTextureTopSecondValue = true;
                        ThumbSpriteTextureTopSecondValue = 2017;
                        setThumbSpriteTextureWidthSecondValue = true;
                        ThumbSpriteTextureWidthSecondValue = 116;
                        setThumbSpriteWidthSecondValue = true;
                        ThumbSpriteWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ThumbSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ThumbSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setThumbSpriteHeightFirstValue && setThumbSpriteHeightSecondValue)
                {
                    ThumbSprite.Height = ThumbSpriteHeightFirstValue * (1 - interpolationValue) + ThumbSpriteHeightSecondValue * interpolationValue;
                }
                if (setThumbSpriteTextureHeightFirstValue && setThumbSpriteTextureHeightSecondValue)
                {
                    ThumbSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(ThumbSpriteTextureHeightFirstValue* (1 - interpolationValue) + ThumbSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setThumbSpriteTextureLeftFirstValue && setThumbSpriteTextureLeftSecondValue)
                {
                    ThumbSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(ThumbSpriteTextureLeftFirstValue* (1 - interpolationValue) + ThumbSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setThumbSpriteTextureTopFirstValue && setThumbSpriteTextureTopSecondValue)
                {
                    ThumbSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(ThumbSpriteTextureTopFirstValue* (1 - interpolationValue) + ThumbSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setThumbSpriteTextureWidthFirstValue && setThumbSpriteTextureWidthSecondValue)
                {
                    ThumbSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(ThumbSpriteTextureWidthFirstValue* (1 - interpolationValue) + ThumbSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setThumbSpriteWidthFirstValue && setThumbSpriteWidthSecondValue)
                {
                    ThumbSprite.Width = ThumbSpriteWidthFirstValue * (1 - interpolationValue) + ThumbSpriteWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (ButtonCategory firstState, ButtonCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setThumbSpriteAlphaFirstValue = false;
                bool setThumbSpriteAlphaSecondValue = false;
                int ThumbSpriteAlphaFirstValue= 0;
                int ThumbSpriteAlphaSecondValue= 0;
                bool setThumbSpriteBlueFirstValue = false;
                bool setThumbSpriteBlueSecondValue = false;
                int ThumbSpriteBlueFirstValue= 0;
                int ThumbSpriteBlueSecondValue= 0;
                bool setThumbSpriteGreenFirstValue = false;
                bool setThumbSpriteGreenSecondValue = false;
                int ThumbSpriteGreenFirstValue= 0;
                int ThumbSpriteGreenSecondValue= 0;
                bool setThumbSpriteRedFirstValue = false;
                bool setThumbSpriteRedSecondValue = false;
                int ThumbSpriteRedFirstValue= 0;
                int ThumbSpriteRedSecondValue= 0;
                switch(firstState)
                {
                    case  ButtonCategory.Enabled:
                        setThumbSpriteAlphaFirstValue = true;
                        ThumbSpriteAlphaFirstValue = 255;
                        setThumbSpriteBlueFirstValue = true;
                        ThumbSpriteBlueFirstValue = 255;
                        setThumbSpriteGreenFirstValue = true;
                        ThumbSpriteGreenFirstValue = 255;
                        setThumbSpriteRedFirstValue = true;
                        ThumbSpriteRedFirstValue = 255;
                        break;
                    case  ButtonCategory.Disabled:
                        setThumbSpriteAlphaFirstValue = true;
                        ThumbSpriteAlphaFirstValue = 100;
                        setThumbSpriteBlueFirstValue = true;
                        ThumbSpriteBlueFirstValue = 0;
                        setThumbSpriteGreenFirstValue = true;
                        ThumbSpriteGreenFirstValue = 0;
                        setThumbSpriteRedFirstValue = true;
                        ThumbSpriteRedFirstValue = 0;
                        break;
                    case  ButtonCategory.Highlighted:
                        setThumbSpriteAlphaFirstValue = true;
                        ThumbSpriteAlphaFirstValue = 255;
                        setThumbSpriteBlueFirstValue = true;
                        ThumbSpriteBlueFirstValue = 210;
                        setThumbSpriteGreenFirstValue = true;
                        ThumbSpriteGreenFirstValue = 250;
                        setThumbSpriteRedFirstValue = true;
                        ThumbSpriteRedFirstValue = 250;
                        break;
                    case  ButtonCategory.Pushed:
                        setThumbSpriteAlphaFirstValue = true;
                        ThumbSpriteAlphaFirstValue = 255;
                        setThumbSpriteBlueFirstValue = true;
                        ThumbSpriteBlueFirstValue = 0;
                        setThumbSpriteGreenFirstValue = true;
                        ThumbSpriteGreenFirstValue = 255;
                        setThumbSpriteRedFirstValue = true;
                        ThumbSpriteRedFirstValue = 255;
                        break;
                }
                switch(secondState)
                {
                    case  ButtonCategory.Enabled:
                        setThumbSpriteAlphaSecondValue = true;
                        ThumbSpriteAlphaSecondValue = 255;
                        setThumbSpriteBlueSecondValue = true;
                        ThumbSpriteBlueSecondValue = 255;
                        setThumbSpriteGreenSecondValue = true;
                        ThumbSpriteGreenSecondValue = 255;
                        setThumbSpriteRedSecondValue = true;
                        ThumbSpriteRedSecondValue = 255;
                        break;
                    case  ButtonCategory.Disabled:
                        setThumbSpriteAlphaSecondValue = true;
                        ThumbSpriteAlphaSecondValue = 100;
                        setThumbSpriteBlueSecondValue = true;
                        ThumbSpriteBlueSecondValue = 0;
                        setThumbSpriteGreenSecondValue = true;
                        ThumbSpriteGreenSecondValue = 0;
                        setThumbSpriteRedSecondValue = true;
                        ThumbSpriteRedSecondValue = 0;
                        break;
                    case  ButtonCategory.Highlighted:
                        setThumbSpriteAlphaSecondValue = true;
                        ThumbSpriteAlphaSecondValue = 255;
                        setThumbSpriteBlueSecondValue = true;
                        ThumbSpriteBlueSecondValue = 210;
                        setThumbSpriteGreenSecondValue = true;
                        ThumbSpriteGreenSecondValue = 250;
                        setThumbSpriteRedSecondValue = true;
                        ThumbSpriteRedSecondValue = 250;
                        break;
                    case  ButtonCategory.Pushed:
                        setThumbSpriteAlphaSecondValue = true;
                        ThumbSpriteAlphaSecondValue = 255;
                        setThumbSpriteBlueSecondValue = true;
                        ThumbSpriteBlueSecondValue = 0;
                        setThumbSpriteGreenSecondValue = true;
                        ThumbSpriteGreenSecondValue = 255;
                        setThumbSpriteRedSecondValue = true;
                        ThumbSpriteRedSecondValue = 255;
                        break;
                }
                if (setThumbSpriteAlphaFirstValue && setThumbSpriteAlphaSecondValue)
                {
                    ThumbSprite.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(ThumbSpriteAlphaFirstValue* (1 - interpolationValue) + ThumbSpriteAlphaSecondValue * interpolationValue);
                }
                if (setThumbSpriteBlueFirstValue && setThumbSpriteBlueSecondValue)
                {
                    ThumbSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ThumbSpriteBlueFirstValue* (1 - interpolationValue) + ThumbSpriteBlueSecondValue * interpolationValue);
                }
                if (setThumbSpriteGreenFirstValue && setThumbSpriteGreenSecondValue)
                {
                    ThumbSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ThumbSpriteGreenFirstValue* (1 - interpolationValue) + ThumbSpriteGreenSecondValue * interpolationValue);
                }
                if (setThumbSpriteRedFirstValue && setThumbSpriteRedSecondValue)
                {
                    ThumbSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ThumbSpriteRedFirstValue* (1 - interpolationValue) + ThumbSpriteRedSecondValue * interpolationValue);
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
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ThumbRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.ThumbRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ThumbRuntime.ButtonCategory fromState,AbbatoirIntergrade.GumRuntimes.ThumbRuntime.ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "ThumbSprite.Height",
                            Type = "float",
                            Value = ThumbSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ThumbSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.SourceFile",
                            Type = "string",
                            Value = ThumbSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ThumbSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Texture Height",
                            Type = "int",
                            Value = ThumbSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Texture Left",
                            Type = "int",
                            Value = ThumbSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Texture Top",
                            Type = "int",
                            Value = ThumbSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Texture Width",
                            Type = "int",
                            Value = ThumbSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Width",
                            Type = "float",
                            Value = ThumbSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ThumbSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ThumbSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ThumbSprite.YOrigin
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
                            Value = Width + 10f
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
                            Name = "ThumbSprite.Height",
                            Type = "float",
                            Value = ThumbSprite.Height + 87.068f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ThumbSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.SourceFile",
                            Type = "string",
                            Value = ThumbSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ThumbSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Texture Height",
                            Type = "int",
                            Value = ThumbSprite.TextureHeight + 101
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Texture Left",
                            Type = "int",
                            Value = ThumbSprite.TextureLeft + 3590
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Texture Top",
                            Type = "int",
                            Value = ThumbSprite.TextureTop + 2017
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Texture Width",
                            Type = "int",
                            Value = ThumbSprite.TextureWidth + 116
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Width",
                            Type = "float",
                            Value = ThumbSprite.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ThumbSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ThumbSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ThumbSprite.YOrigin
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
                            Name = "ThumbSprite.Alpha",
                            Type = "int",
                            Value = ThumbSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Blue",
                            Type = "int",
                            Value = ThumbSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Green",
                            Type = "int",
                            Value = ThumbSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Red",
                            Type = "int",
                            Value = ThumbSprite.Red
                        }
                        );
                        break;
                    case  ButtonCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Alpha",
                            Type = "int",
                            Value = ThumbSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Blue",
                            Type = "int",
                            Value = ThumbSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Green",
                            Type = "int",
                            Value = ThumbSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Red",
                            Type = "int",
                            Value = ThumbSprite.Red
                        }
                        );
                        break;
                    case  ButtonCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Alpha",
                            Type = "int",
                            Value = ThumbSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Blue",
                            Type = "int",
                            Value = ThumbSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Green",
                            Type = "int",
                            Value = ThumbSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Red",
                            Type = "int",
                            Value = ThumbSprite.Red
                        }
                        );
                        break;
                    case  ButtonCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Alpha",
                            Type = "int",
                            Value = ThumbSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Blue",
                            Type = "int",
                            Value = ThumbSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Green",
                            Type = "int",
                            Value = ThumbSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Red",
                            Type = "int",
                            Value = ThumbSprite.Red
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
                            Name = "ThumbSprite.Alpha",
                            Type = "int",
                            Value = ThumbSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Blue",
                            Type = "int",
                            Value = ThumbSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Green",
                            Type = "int",
                            Value = ThumbSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Red",
                            Type = "int",
                            Value = ThumbSprite.Red + 255
                        }
                        );
                        break;
                    case  ButtonCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Alpha",
                            Type = "int",
                            Value = ThumbSprite.Alpha + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Blue",
                            Type = "int",
                            Value = ThumbSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Green",
                            Type = "int",
                            Value = ThumbSprite.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Red",
                            Type = "int",
                            Value = ThumbSprite.Red + 0
                        }
                        );
                        break;
                    case  ButtonCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Alpha",
                            Type = "int",
                            Value = ThumbSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Blue",
                            Type = "int",
                            Value = ThumbSprite.Blue + 210
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Green",
                            Type = "int",
                            Value = ThumbSprite.Green + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Red",
                            Type = "int",
                            Value = ThumbSprite.Red + 250
                        }
                        );
                        break;
                    case  ButtonCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Alpha",
                            Type = "int",
                            Value = ThumbSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Blue",
                            Type = "int",
                            Value = ThumbSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Green",
                            Type = "int",
                            Value = ThumbSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbSprite.Red",
                            Type = "int",
                            Value = ThumbSprite.Red + 255
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
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime ThumbSprite { get; set; }
            public ThumbRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                this.HasEvents = true;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Thumb");
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
                ThumbSprite = this.GetGraphicalUiElementByName("ThumbSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
