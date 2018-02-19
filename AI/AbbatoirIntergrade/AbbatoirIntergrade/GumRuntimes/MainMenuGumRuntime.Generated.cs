    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class MainMenuGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            SetProperty("BackgroundSprite.SourceFile", "../Screens/MainMenu/empty_building.png");
                            LeftEye.CurrentEyeOpeningState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
                            LeftEye.CurrentEyePositionState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Left;
                            LeftEye.Y = -150f;
                            LeftEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            LeftEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            RightEye.CurrentEyeOpeningState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
                            RightEye.CurrentEyePositionState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Right;
                            RightEye.X = 0f;
                            RightEye.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            RightEye.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            RightEye.Y = -150f;
                            RightEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            RightEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Font = "Bahnschrift";
                            TextInstance.FontSize = 48;
                            TextInstance.Height = 0f;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.Text = "Press any key to begin...";
                            TextInstance.Width = 0f;
                            TextInstance.X = 0f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Y = 1193f;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
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
                bool setLeftEyeCurrentEyeOpeningStateFirstValue = false;
                bool setLeftEyeCurrentEyeOpeningStateSecondValue = false;
                MainMenuEyeRuntime.EyeOpening LeftEyeCurrentEyeOpeningStateFirstValue= MainMenuEyeRuntime.EyeOpening.Closed;
                MainMenuEyeRuntime.EyeOpening LeftEyeCurrentEyeOpeningStateSecondValue= MainMenuEyeRuntime.EyeOpening.Closed;
                bool setLeftEyeCurrentEyePositionStateFirstValue = false;
                bool setLeftEyeCurrentEyePositionStateSecondValue = false;
                MainMenuEyeRuntime.EyePosition LeftEyeCurrentEyePositionStateFirstValue= MainMenuEyeRuntime.EyePosition.Left;
                MainMenuEyeRuntime.EyePosition LeftEyeCurrentEyePositionStateSecondValue= MainMenuEyeRuntime.EyePosition.Left;
                bool setLeftEyeYFirstValue = false;
                bool setLeftEyeYSecondValue = false;
                float LeftEyeYFirstValue= 0;
                float LeftEyeYSecondValue= 0;
                bool setRightEyeCurrentEyeOpeningStateFirstValue = false;
                bool setRightEyeCurrentEyeOpeningStateSecondValue = false;
                MainMenuEyeRuntime.EyeOpening RightEyeCurrentEyeOpeningStateFirstValue= MainMenuEyeRuntime.EyeOpening.Closed;
                MainMenuEyeRuntime.EyeOpening RightEyeCurrentEyeOpeningStateSecondValue= MainMenuEyeRuntime.EyeOpening.Closed;
                bool setRightEyeCurrentEyePositionStateFirstValue = false;
                bool setRightEyeCurrentEyePositionStateSecondValue = false;
                MainMenuEyeRuntime.EyePosition RightEyeCurrentEyePositionStateFirstValue= MainMenuEyeRuntime.EyePosition.Left;
                MainMenuEyeRuntime.EyePosition RightEyeCurrentEyePositionStateSecondValue= MainMenuEyeRuntime.EyePosition.Left;
                bool setRightEyeXFirstValue = false;
                bool setRightEyeXSecondValue = false;
                float RightEyeXFirstValue= 0;
                float RightEyeXSecondValue= 0;
                bool setRightEyeYFirstValue = false;
                bool setRightEyeYSecondValue = false;
                float RightEyeYFirstValue= 0;
                float RightEyeYSecondValue= 0;
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
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            SetProperty("BackgroundSprite.SourceFile", "../Screens/MainMenu/empty_building.png");
                        }
                        setLeftEyeCurrentEyeOpeningStateFirstValue = true;
                        LeftEyeCurrentEyeOpeningStateFirstValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
                        setLeftEyeCurrentEyePositionStateFirstValue = true;
                        LeftEyeCurrentEyePositionStateFirstValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Left;
                        setLeftEyeYFirstValue = true;
                        LeftEyeYFirstValue = -150f;
                        if (interpolationValue < 1)
                        {
                            this.LeftEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LeftEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRightEyeCurrentEyeOpeningStateFirstValue = true;
                        RightEyeCurrentEyeOpeningStateFirstValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
                        setRightEyeCurrentEyePositionStateFirstValue = true;
                        RightEyeCurrentEyePositionStateFirstValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Right;
                        setRightEyeXFirstValue = true;
                        RightEyeXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.RightEye.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RightEye.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setRightEyeYFirstValue = true;
                        RightEyeYFirstValue = -150f;
                        if (interpolationValue < 1)
                        {
                            this.RightEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RightEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Font = "Bahnschrift";
                        }
                        setTextInstanceFontSizeFirstValue = true;
                        TextInstanceFontSizeFirstValue = 48;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "Press any key to begin...";
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 0f;
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 1193f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BackgroundSprite.SourceFile", "../Screens/MainMenu/empty_building.png");
                        }
                        setLeftEyeCurrentEyeOpeningStateSecondValue = true;
                        LeftEyeCurrentEyeOpeningStateSecondValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
                        setLeftEyeCurrentEyePositionStateSecondValue = true;
                        LeftEyeCurrentEyePositionStateSecondValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Left;
                        setLeftEyeYSecondValue = true;
                        LeftEyeYSecondValue = -150f;
                        if (interpolationValue >= 1)
                        {
                            this.LeftEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LeftEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRightEyeCurrentEyeOpeningStateSecondValue = true;
                        RightEyeCurrentEyeOpeningStateSecondValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
                        setRightEyeCurrentEyePositionStateSecondValue = true;
                        RightEyeCurrentEyePositionStateSecondValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Right;
                        setRightEyeXSecondValue = true;
                        RightEyeXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.RightEye.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RightEye.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setRightEyeYSecondValue = true;
                        RightEyeYSecondValue = -150f;
                        if (interpolationValue >= 1)
                        {
                            this.RightEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RightEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Font = "Bahnschrift";
                        }
                        setTextInstanceFontSizeSecondValue = true;
                        TextInstanceFontSizeSecondValue = 48;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "Press any key to begin...";
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 0f;
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 1193f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                if (setLeftEyeCurrentEyeOpeningStateFirstValue && setLeftEyeCurrentEyeOpeningStateSecondValue)
                {
                    LeftEye.InterpolateBetween(LeftEyeCurrentEyeOpeningStateFirstValue, LeftEyeCurrentEyeOpeningStateSecondValue, interpolationValue);
                }
                if (setLeftEyeCurrentEyePositionStateFirstValue && setLeftEyeCurrentEyePositionStateSecondValue)
                {
                    LeftEye.InterpolateBetween(LeftEyeCurrentEyePositionStateFirstValue, LeftEyeCurrentEyePositionStateSecondValue, interpolationValue);
                }
                if (setLeftEyeYFirstValue && setLeftEyeYSecondValue)
                {
                    LeftEye.Y = LeftEyeYFirstValue * (1 - interpolationValue) + LeftEyeYSecondValue * interpolationValue;
                }
                if (setRightEyeCurrentEyeOpeningStateFirstValue && setRightEyeCurrentEyeOpeningStateSecondValue)
                {
                    RightEye.InterpolateBetween(RightEyeCurrentEyeOpeningStateFirstValue, RightEyeCurrentEyeOpeningStateSecondValue, interpolationValue);
                }
                if (setRightEyeCurrentEyePositionStateFirstValue && setRightEyeCurrentEyePositionStateSecondValue)
                {
                    RightEye.InterpolateBetween(RightEyeCurrentEyePositionStateFirstValue, RightEyeCurrentEyePositionStateSecondValue, interpolationValue);
                }
                if (setRightEyeXFirstValue && setRightEyeXSecondValue)
                {
                    RightEye.X = RightEyeXFirstValue * (1 - interpolationValue) + RightEyeXSecondValue * interpolationValue;
                }
                if (setRightEyeYFirstValue && setRightEyeYSecondValue)
                {
                    RightEye.Y = RightEyeYFirstValue * (1 - interpolationValue) + RightEyeYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MainMenuGumRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.MainMenuGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> OpenEyesAnimationInstructions (object target) 
            {
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>LeftEye.OpenEyeAnimation.Play(OpenEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>RightEye.OpenEyeAnimation.Play(OpenEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> OpenEyesAnimationRelativeInstructions (object target) 
            {
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>LeftEye.OpenEyeAnimationRelative.Play(OpenEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>RightEye.OpenEyeAnimationRelative.Play(OpenEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation openEyesAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation OpenEyesAnimation
            {
                get
                {
                    if (openEyesAnimation == null)
                    {
                        openEyesAnimation = new FlatRedBall.Gum.Animation.GumAnimation(1.8f, OpenEyesAnimationInstructions);
                        openEyesAnimation.SubAnimations.Add(LeftEye.OpenEyeAnimation);
                        openEyesAnimation.SubAnimations.Add(RightEye.OpenEyeAnimation);
                    }
                    return openEyesAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation openEyesAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation OpenEyesAnimationRelative
            {
                get
                {
                    if (openEyesAnimationRelative == null)
                    {
                        openEyesAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(1.8f, OpenEyesAnimationRelativeInstructions);
                        openEyesAnimationRelative.SubAnimations.Add(LeftEye.OpenEyeAnimation);
                        openEyesAnimationRelative.SubAnimations.Add(RightEye.OpenEyeAnimation);
                    }
                    return openEyesAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> BlinkEyesAnimationInstructions (object target) 
            {
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>LeftEye.BlinkEyeAnimation.Play(BlinkEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>RightEye.BlinkEyeAnimation.Play(BlinkEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> BlinkEyesAnimationRelativeInstructions (object target) 
            {
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>LeftEye.BlinkEyeAnimationRelative.Play(BlinkEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>RightEye.BlinkEyeAnimationRelative.Play(BlinkEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation blinkEyesAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation BlinkEyesAnimation
            {
                get
                {
                    if (blinkEyesAnimation == null)
                    {
                        blinkEyesAnimation = new FlatRedBall.Gum.Animation.GumAnimation(0.2f, BlinkEyesAnimationInstructions);
                        blinkEyesAnimation.SubAnimations.Add(LeftEye.BlinkEyeAnimation);
                        blinkEyesAnimation.SubAnimations.Add(RightEye.BlinkEyeAnimation);
                    }
                    return blinkEyesAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation blinkEyesAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation BlinkEyesAnimationRelative
            {
                get
                {
                    if (blinkEyesAnimationRelative == null)
                    {
                        blinkEyesAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(0.2f, BlinkEyesAnimationRelativeInstructions);
                        blinkEyesAnimationRelative.SubAnimations.Add(LeftEye.BlinkEyeAnimation);
                        blinkEyesAnimationRelative.SubAnimations.Add(RightEye.BlinkEyeAnimation);
                    }
                    return blinkEyesAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                LeftEye.StopAnimations();
                RightEye.StopAnimations();
                OpenEyesAnimation.Stop();
                BlinkEyesAnimation.Stop();
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
                            Name = "BackgroundSprite.SourceFile",
                            Type = "string",
                            Value = BackgroundSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.EyeOpeningState",
                            Type = "EyeOpeningState",
                            Value = LeftEye.CurrentEyeOpeningState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.EyePositionState",
                            Type = "EyePositionState",
                            Value = LeftEye.CurrentEyePositionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y",
                            Type = "float",
                            Value = LeftEye.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LeftEye.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y Units",
                            Type = "PositionUnitType",
                            Value = LeftEye.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.EyeOpeningState",
                            Type = "EyeOpeningState",
                            Value = RightEye.CurrentEyeOpeningState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.EyePositionState",
                            Type = "EyePositionState",
                            Value = RightEye.CurrentEyePositionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X",
                            Type = "float",
                            Value = RightEye.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X Origin",
                            Type = "HorizontalAlignment",
                            Value = RightEye.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X Units",
                            Type = "PositionUnitType",
                            Value = RightEye.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y",
                            Type = "float",
                            Value = RightEye.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y Origin",
                            Type = "VerticalAlignment",
                            Value = RightEye.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y Units",
                            Type = "PositionUnitType",
                            Value = RightEye.YUnits
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
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
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
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
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
                            Name = "BackgroundSprite.SourceFile",
                            Type = "string",
                            Value = BackgroundSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.EyeOpeningState",
                            Type = "EyeOpeningState",
                            Value = LeftEye.CurrentEyeOpeningState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.EyePositionState",
                            Type = "EyePositionState",
                            Value = LeftEye.CurrentEyePositionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y",
                            Type = "float",
                            Value = LeftEye.Y + -150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LeftEye.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y Units",
                            Type = "PositionUnitType",
                            Value = LeftEye.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.EyeOpeningState",
                            Type = "EyeOpeningState",
                            Value = RightEye.CurrentEyeOpeningState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.EyePositionState",
                            Type = "EyePositionState",
                            Value = RightEye.CurrentEyePositionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X",
                            Type = "float",
                            Value = RightEye.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X Origin",
                            Type = "HorizontalAlignment",
                            Value = RightEye.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X Units",
                            Type = "PositionUnitType",
                            Value = RightEye.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y",
                            Type = "float",
                            Value = RightEye.Y + -150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y Origin",
                            Type = "VerticalAlignment",
                            Value = RightEye.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y Units",
                            Type = "PositionUnitType",
                            Value = RightEye.YUnits
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
                            Value = TextInstance.FontSize + 48
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y + 1193f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
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
            private AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime LeftEye { get; set; }
            private AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime RightEye { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TextInstance { get; set; }
            public MainMenuGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "MainMenuGum");
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
                LeftEye = this.GetGraphicalUiElementByName("LeftEye") as AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime;
                RightEye = this.GetGraphicalUiElementByName("RightEye") as AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime;
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
