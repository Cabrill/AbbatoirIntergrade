    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class EndingScreenRuntime : Gum.Wireframe.GraphicalUiElement
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Fading
            {
                Faded,
                NotFaded
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Fading mCurrentFadingState;
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
                            BlackFade.Alpha = 0;
                            BlackFade.Blue = 0;
                            BlackFade.Green = 0;
                            BlackFade.Height = 100f;
                            BlackFade.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BlackFade.Red = 0;
                            BlackFade.Width = 100f;
                            BlackFade.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            break;
                    }
                }
            }
            public Fading CurrentFadingState
            {
                get
                {
                    return mCurrentFadingState;
                }
                set
                {
                    mCurrentFadingState = value;
                    switch(mCurrentFadingState)
                    {
                        case  Fading.Faded:
                            BlackFade.Alpha = 255;
                            break;
                        case  Fading.NotFaded:
                            BlackFade.Alpha = 0;
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
                bool setBlackFadeAlphaFirstValue = false;
                bool setBlackFadeAlphaSecondValue = false;
                int BlackFadeAlphaFirstValue= 0;
                int BlackFadeAlphaSecondValue= 0;
                bool setBlackFadeBlueFirstValue = false;
                bool setBlackFadeBlueSecondValue = false;
                int BlackFadeBlueFirstValue= 0;
                int BlackFadeBlueSecondValue= 0;
                bool setBlackFadeGreenFirstValue = false;
                bool setBlackFadeGreenSecondValue = false;
                int BlackFadeGreenFirstValue= 0;
                int BlackFadeGreenSecondValue= 0;
                bool setBlackFadeHeightFirstValue = false;
                bool setBlackFadeHeightSecondValue = false;
                float BlackFadeHeightFirstValue= 0;
                float BlackFadeHeightSecondValue= 0;
                bool setBlackFadeRedFirstValue = false;
                bool setBlackFadeRedSecondValue = false;
                int BlackFadeRedFirstValue= 0;
                int BlackFadeRedSecondValue= 0;
                bool setBlackFadeWidthFirstValue = false;
                bool setBlackFadeWidthSecondValue = false;
                float BlackFadeWidthFirstValue= 0;
                float BlackFadeWidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBlackFadeAlphaFirstValue = true;
                        BlackFadeAlphaFirstValue = 0;
                        setBlackFadeBlueFirstValue = true;
                        BlackFadeBlueFirstValue = 0;
                        setBlackFadeGreenFirstValue = true;
                        BlackFadeGreenFirstValue = 0;
                        setBlackFadeHeightFirstValue = true;
                        BlackFadeHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BlackFade.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBlackFadeRedFirstValue = true;
                        BlackFadeRedFirstValue = 0;
                        setBlackFadeWidthFirstValue = true;
                        BlackFadeWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BlackFade.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBlackFadeAlphaSecondValue = true;
                        BlackFadeAlphaSecondValue = 0;
                        setBlackFadeBlueSecondValue = true;
                        BlackFadeBlueSecondValue = 0;
                        setBlackFadeGreenSecondValue = true;
                        BlackFadeGreenSecondValue = 0;
                        setBlackFadeHeightSecondValue = true;
                        BlackFadeHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BlackFade.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBlackFadeRedSecondValue = true;
                        BlackFadeRedSecondValue = 0;
                        setBlackFadeWidthSecondValue = true;
                        BlackFadeWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BlackFade.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                if (setBlackFadeAlphaFirstValue && setBlackFadeAlphaSecondValue)
                {
                    BlackFade.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(BlackFadeAlphaFirstValue* (1 - interpolationValue) + BlackFadeAlphaSecondValue * interpolationValue);
                }
                if (setBlackFadeBlueFirstValue && setBlackFadeBlueSecondValue)
                {
                    BlackFade.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BlackFadeBlueFirstValue* (1 - interpolationValue) + BlackFadeBlueSecondValue * interpolationValue);
                }
                if (setBlackFadeGreenFirstValue && setBlackFadeGreenSecondValue)
                {
                    BlackFade.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BlackFadeGreenFirstValue* (1 - interpolationValue) + BlackFadeGreenSecondValue * interpolationValue);
                }
                if (setBlackFadeHeightFirstValue && setBlackFadeHeightSecondValue)
                {
                    BlackFade.Height = BlackFadeHeightFirstValue * (1 - interpolationValue) + BlackFadeHeightSecondValue * interpolationValue;
                }
                if (setBlackFadeRedFirstValue && setBlackFadeRedSecondValue)
                {
                    BlackFade.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BlackFadeRedFirstValue* (1 - interpolationValue) + BlackFadeRedSecondValue * interpolationValue);
                }
                if (setBlackFadeWidthFirstValue && setBlackFadeWidthSecondValue)
                {
                    BlackFade.Width = BlackFadeWidthFirstValue * (1 - interpolationValue) + BlackFadeWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (Fading firstState, Fading secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBlackFadeAlphaFirstValue = false;
                bool setBlackFadeAlphaSecondValue = false;
                int BlackFadeAlphaFirstValue= 0;
                int BlackFadeAlphaSecondValue= 0;
                switch(firstState)
                {
                    case  Fading.Faded:
                        setBlackFadeAlphaFirstValue = true;
                        BlackFadeAlphaFirstValue = 255;
                        break;
                    case  Fading.NotFaded:
                        setBlackFadeAlphaFirstValue = true;
                        BlackFadeAlphaFirstValue = 0;
                        break;
                }
                switch(secondState)
                {
                    case  Fading.Faded:
                        setBlackFadeAlphaSecondValue = true;
                        BlackFadeAlphaSecondValue = 255;
                        break;
                    case  Fading.NotFaded:
                        setBlackFadeAlphaSecondValue = true;
                        BlackFadeAlphaSecondValue = 0;
                        break;
                }
                if (setBlackFadeAlphaFirstValue && setBlackFadeAlphaSecondValue)
                {
                    BlackFade.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(BlackFadeAlphaFirstValue* (1 - interpolationValue) + BlackFadeAlphaSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentFadingState = firstState;
                }
                else
                {
                    mCurrentFadingState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.EndingScreenRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.EndingScreenRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.EndingScreenRuntime.Fading fromState,AbbatoirIntergrade.GumRuntimes.EndingScreenRuntime.Fading toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Fading toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Fading").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentFadingState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Fading toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentFadingState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeInAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentFadingState = Fading.Faded);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Fading.NotFaded, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, FadeInAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeInAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fading/Faded").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fading/NotFaded").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Fading.NotFaded);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation fadeInAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation FadeInAnimation
            {
                get
                {
                    if (fadeInAnimation == null)
                    {
                        fadeInAnimation = new FlatRedBall.Gum.Animation.GumAnimation(1, FadeInAnimationInstructions);
                    }
                    return fadeInAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation fadeInAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation FadeInAnimationRelative
            {
                get
                {
                    if (fadeInAnimationRelative == null)
                    {
                        fadeInAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(1, FadeInAnimationRelativeInstructions);
                    }
                    return fadeInAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeOutAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentFadingState = Fading.NotFaded);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Fading.Faded, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, FadeOutAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeOutAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fading/NotFaded").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fading/Faded").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Fading.Faded);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation fadeOutAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation FadeOutAnimation
            {
                get
                {
                    if (fadeOutAnimation == null)
                    {
                        fadeOutAnimation = new FlatRedBall.Gum.Animation.GumAnimation(1, FadeOutAnimationInstructions);
                    }
                    return fadeOutAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation fadeOutAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation FadeOutAnimationRelative
            {
                get
                {
                    if (fadeOutAnimationRelative == null)
                    {
                        fadeOutAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(1, FadeOutAnimationRelativeInstructions);
                    }
                    return fadeOutAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                FadeInAnimation.Stop();
                FadeOutAnimation.Stop();
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
                            Name = "BlackFade.Alpha",
                            Type = "int",
                            Value = BlackFade.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Blue",
                            Type = "int",
                            Value = BlackFade.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Green",
                            Type = "int",
                            Value = BlackFade.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Height",
                            Type = "float",
                            Value = BlackFade.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Height Units",
                            Type = "DimensionUnitType",
                            Value = BlackFade.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Red",
                            Type = "int",
                            Value = BlackFade.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Width",
                            Type = "float",
                            Value = BlackFade.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Width Units",
                            Type = "DimensionUnitType",
                            Value = BlackFade.WidthUnits
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
                            Name = "BlackFade.Alpha",
                            Type = "int",
                            Value = BlackFade.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Blue",
                            Type = "int",
                            Value = BlackFade.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Green",
                            Type = "int",
                            Value = BlackFade.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Height",
                            Type = "float",
                            Value = BlackFade.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Height Units",
                            Type = "DimensionUnitType",
                            Value = BlackFade.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Red",
                            Type = "int",
                            Value = BlackFade.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Width",
                            Type = "float",
                            Value = BlackFade.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Width Units",
                            Type = "DimensionUnitType",
                            Value = BlackFade.WidthUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Fading state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Fading.Faded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Alpha",
                            Type = "int",
                            Value = BlackFade.Alpha
                        }
                        );
                        break;
                    case  Fading.NotFaded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Alpha",
                            Type = "int",
                            Value = BlackFade.Alpha
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Fading state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Fading.Faded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Alpha",
                            Type = "int",
                            Value = BlackFade.Alpha + 255
                        }
                        );
                        break;
                    case  Fading.NotFaded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BlackFade.Alpha",
                            Type = "int",
                            Value = BlackFade.Alpha + 0
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
                    else if (category.Name == "Fading")
                    {
                        if(state.Name == "Faded") this.mCurrentFadingState = Fading.Faded;
                        if(state.Name == "NotFaded") this.mCurrentFadingState = Fading.NotFaded;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime BlackFade { get; set; }
            public EndingScreenRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "EndingScreen");
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
                BlackFade = this.GetGraphicalUiElementByName("BlackFade") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
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
