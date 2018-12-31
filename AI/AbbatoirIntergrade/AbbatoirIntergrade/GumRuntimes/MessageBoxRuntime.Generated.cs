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
                            Height = 50f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 50f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ChatFrameInstance.Height = 75f;
                            ChatFrameInstance.Width = 90f;
                            ChatFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ChatFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ChatFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ChatFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            YesButton.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                            YesButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatFrameInstance") ?? this;
                            YesButton.X = 894f;
                            YesButton.Y = 342f;
                            YesButton1.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.X;
                            YesButton1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatFrameInstance") ?? this;
                            YesButton1.X = 101f;
                            YesButton1.Y = 339f;
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
                bool setChatFrameInstanceHeightFirstValue = false;
                bool setChatFrameInstanceHeightSecondValue = false;
                float ChatFrameInstanceHeightFirstValue= 0;
                float ChatFrameInstanceHeightSecondValue= 0;
                bool setChatFrameInstanceWidthFirstValue = false;
                bool setChatFrameInstanceWidthSecondValue = false;
                float ChatFrameInstanceWidthFirstValue= 0;
                float ChatFrameInstanceWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setYesButtonCurrentButtonTypeStateFirstValue = false;
                bool setYesButtonCurrentButtonTypeStateSecondValue = false;
                AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType YesButtonCurrentButtonTypeStateFirstValue= AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType YesButtonCurrentButtonTypeStateSecondValue= AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                bool setYesButtonXFirstValue = false;
                bool setYesButtonXSecondValue = false;
                float YesButtonXFirstValue= 0;
                float YesButtonXSecondValue= 0;
                bool setYesButtonYFirstValue = false;
                bool setYesButtonYSecondValue = false;
                float YesButtonYFirstValue= 0;
                float YesButtonYSecondValue= 0;
                bool setYesButton1CurrentButtonTypeStateFirstValue = false;
                bool setYesButton1CurrentButtonTypeStateSecondValue = false;
                AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType YesButton1CurrentButtonTypeStateFirstValue= AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType YesButton1CurrentButtonTypeStateSecondValue= AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                bool setYesButton1XFirstValue = false;
                bool setYesButton1XSecondValue = false;
                float YesButton1XFirstValue= 0;
                float YesButton1XSecondValue= 0;
                bool setYesButton1YFirstValue = false;
                bool setYesButton1YSecondValue = false;
                float YesButton1YFirstValue= 0;
                float YesButton1YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setChatFrameInstanceHeightFirstValue = true;
                        ChatFrameInstanceHeightFirstValue = 75f;
                        setChatFrameInstanceWidthFirstValue = true;
                        ChatFrameInstanceWidthFirstValue = 90f;
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setYesButtonCurrentButtonTypeStateFirstValue = true;
                        YesButtonCurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                        if (interpolationValue < 1)
                        {
                            this.YesButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatFrameInstance") ?? this;
                        }
                        setYesButtonXFirstValue = true;
                        YesButtonXFirstValue = 894f;
                        setYesButtonYFirstValue = true;
                        YesButtonYFirstValue = 342f;
                        setYesButton1CurrentButtonTypeStateFirstValue = true;
                        YesButton1CurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.X;
                        if (interpolationValue < 1)
                        {
                            this.YesButton1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatFrameInstance") ?? this;
                        }
                        setYesButton1XFirstValue = true;
                        YesButton1XFirstValue = 101f;
                        setYesButton1YFirstValue = true;
                        YesButton1YFirstValue = 339f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setChatFrameInstanceHeightSecondValue = true;
                        ChatFrameInstanceHeightSecondValue = 75f;
                        setChatFrameInstanceWidthSecondValue = true;
                        ChatFrameInstanceWidthSecondValue = 90f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setYesButtonCurrentButtonTypeStateSecondValue = true;
                        YesButtonCurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                        if (interpolationValue >= 1)
                        {
                            this.YesButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatFrameInstance") ?? this;
                        }
                        setYesButtonXSecondValue = true;
                        YesButtonXSecondValue = 894f;
                        setYesButtonYSecondValue = true;
                        YesButtonYSecondValue = 342f;
                        setYesButton1CurrentButtonTypeStateSecondValue = true;
                        YesButton1CurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.X;
                        if (interpolationValue >= 1)
                        {
                            this.YesButton1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatFrameInstance") ?? this;
                        }
                        setYesButton1XSecondValue = true;
                        YesButton1XSecondValue = 101f;
                        setYesButton1YSecondValue = true;
                        YesButton1YSecondValue = 339f;
                        break;
                }
                if (setChatFrameInstanceHeightFirstValue && setChatFrameInstanceHeightSecondValue)
                {
                    ChatFrameInstance.Height = ChatFrameInstanceHeightFirstValue * (1 - interpolationValue) + ChatFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setChatFrameInstanceWidthFirstValue && setChatFrameInstanceWidthSecondValue)
                {
                    ChatFrameInstance.Width = ChatFrameInstanceWidthFirstValue * (1 - interpolationValue) + ChatFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setYesButtonCurrentButtonTypeStateFirstValue && setYesButtonCurrentButtonTypeStateSecondValue)
                {
                    YesButton.InterpolateBetween(YesButtonCurrentButtonTypeStateFirstValue, YesButtonCurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setYesButtonXFirstValue && setYesButtonXSecondValue)
                {
                    YesButton.X = YesButtonXFirstValue * (1 - interpolationValue) + YesButtonXSecondValue * interpolationValue;
                }
                if (setYesButtonYFirstValue && setYesButtonYSecondValue)
                {
                    YesButton.Y = YesButtonYFirstValue * (1 - interpolationValue) + YesButtonYSecondValue * interpolationValue;
                }
                if (setYesButton1CurrentButtonTypeStateFirstValue && setYesButton1CurrentButtonTypeStateSecondValue)
                {
                    YesButton1.InterpolateBetween(YesButton1CurrentButtonTypeStateFirstValue, YesButton1CurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setYesButton1XFirstValue && setYesButton1XSecondValue)
                {
                    YesButton1.X = YesButton1XFirstValue * (1 - interpolationValue) + YesButton1XSecondValue * interpolationValue;
                }
                if (setYesButton1YFirstValue && setYesButton1YSecondValue)
                {
                    YesButton1.Y = YesButton1YFirstValue * (1 - interpolationValue) + YesButton1YSecondValue * interpolationValue;
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
                ChatFrameInstance.StopAnimations();
                YesButton.StopAnimations();
                YesButton1.StopAnimations();
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
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Width",
                            Type = "float",
                            Value = ChatFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ChatFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ChatFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ChatFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ChatFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = YesButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton.Parent",
                            Type = "string",
                            Value = YesButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton.X",
                            Type = "float",
                            Value = YesButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton.Y",
                            Type = "float",
                            Value = YesButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton1.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = YesButton1.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton1.Parent",
                            Type = "string",
                            Value = YesButton1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton1.X",
                            Type = "float",
                            Value = YesButton1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton1.Y",
                            Type = "float",
                            Value = YesButton1.Y
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
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Width",
                            Type = "float",
                            Value = ChatFrameInstance.Width + 90f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ChatFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ChatFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ChatFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ChatFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = YesButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton.Parent",
                            Type = "string",
                            Value = YesButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton.X",
                            Type = "float",
                            Value = YesButton.X + 894f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton.Y",
                            Type = "float",
                            Value = YesButton.Y + 342f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton1.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = YesButton1.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton1.Parent",
                            Type = "string",
                            Value = YesButton1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton1.X",
                            Type = "float",
                            Value = YesButton1.X + 101f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "YesButton1.Y",
                            Type = "float",
                            Value = YesButton1.Y + 339f
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
            private AbbatoirIntergrade.GumRuntimes.frames.ChatFrameRuntime ChatFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime YesButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime YesButton1 { get; set; }
            public MessageBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "MessageBox");
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
                ChatFrameInstance = this.GetGraphicalUiElementByName("ChatFrameInstance") as AbbatoirIntergrade.GumRuntimes.frames.ChatFrameRuntime;
                YesButton = this.GetGraphicalUiElementByName("YesButton") as AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime;
                YesButton1 = this.GetGraphicalUiElementByName("YesButton1") as AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime;
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
