    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class ConfirmationWindowRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            MessageFrameInstance.Height = 43.96074f;
                            MessageFrameInstance.WrapsChildren = true;
                            MessageFrameInstance.X = 50f;
                            MessageFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MessageFrameInstance.Y = 50.20832f;
                            MessageFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SetProperty("MessageText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            MessageText.Height = 426f;
                            MessageText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MessageText.Text = "Message";
                            MessageText.UseCustomFont = true;
                            MessageText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MessageText.Width = 1190f;
                            MessageText.X = 676f;
                            MessageText.Y = 425f;
                            ConfirmButton.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Check;
                            ConfirmButton.Height = 10f;
                            ConfirmButton.Width = 6f;
                            ConfirmButton.X = 662f;
                            ConfirmButton.Y = 878f;
                            CancelButton.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                            CancelButton.Height = 10f;
                            CancelButton.Width = 6f;
                            CancelButton.X = 1746f;
                            CancelButton.Y = 878f;
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
                bool setCancelButtonCurrentButtonTypeStateFirstValue = false;
                bool setCancelButtonCurrentButtonTypeStateSecondValue = false;
                ButtonFrameRuntime.ButtonType CancelButtonCurrentButtonTypeStateFirstValue= ButtonFrameRuntime.ButtonType.Check;
                ButtonFrameRuntime.ButtonType CancelButtonCurrentButtonTypeStateSecondValue= ButtonFrameRuntime.ButtonType.Check;
                bool setCancelButtonHeightFirstValue = false;
                bool setCancelButtonHeightSecondValue = false;
                float CancelButtonHeightFirstValue= 0;
                float CancelButtonHeightSecondValue= 0;
                bool setCancelButtonWidthFirstValue = false;
                bool setCancelButtonWidthSecondValue = false;
                float CancelButtonWidthFirstValue= 0;
                float CancelButtonWidthSecondValue= 0;
                bool setCancelButtonXFirstValue = false;
                bool setCancelButtonXSecondValue = false;
                float CancelButtonXFirstValue= 0;
                float CancelButtonXSecondValue= 0;
                bool setCancelButtonYFirstValue = false;
                bool setCancelButtonYSecondValue = false;
                float CancelButtonYFirstValue= 0;
                float CancelButtonYSecondValue= 0;
                bool setConfirmButtonCurrentButtonTypeStateFirstValue = false;
                bool setConfirmButtonCurrentButtonTypeStateSecondValue = false;
                ButtonFrameRuntime.ButtonType ConfirmButtonCurrentButtonTypeStateFirstValue= ButtonFrameRuntime.ButtonType.Check;
                ButtonFrameRuntime.ButtonType ConfirmButtonCurrentButtonTypeStateSecondValue= ButtonFrameRuntime.ButtonType.Check;
                bool setConfirmButtonHeightFirstValue = false;
                bool setConfirmButtonHeightSecondValue = false;
                float ConfirmButtonHeightFirstValue= 0;
                float ConfirmButtonHeightSecondValue= 0;
                bool setConfirmButtonWidthFirstValue = false;
                bool setConfirmButtonWidthSecondValue = false;
                float ConfirmButtonWidthFirstValue= 0;
                float ConfirmButtonWidthSecondValue= 0;
                bool setConfirmButtonXFirstValue = false;
                bool setConfirmButtonXSecondValue = false;
                float ConfirmButtonXFirstValue= 0;
                float ConfirmButtonXSecondValue= 0;
                bool setConfirmButtonYFirstValue = false;
                bool setConfirmButtonYSecondValue = false;
                float ConfirmButtonYFirstValue= 0;
                float ConfirmButtonYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMessageFrameInstanceHeightFirstValue = false;
                bool setMessageFrameInstanceHeightSecondValue = false;
                float MessageFrameInstanceHeightFirstValue= 0;
                float MessageFrameInstanceHeightSecondValue= 0;
                bool setMessageFrameInstanceXFirstValue = false;
                bool setMessageFrameInstanceXSecondValue = false;
                float MessageFrameInstanceXFirstValue= 0;
                float MessageFrameInstanceXSecondValue= 0;
                bool setMessageFrameInstanceYFirstValue = false;
                bool setMessageFrameInstanceYSecondValue = false;
                float MessageFrameInstanceYFirstValue= 0;
                float MessageFrameInstanceYSecondValue= 0;
                bool setMessageTextHeightFirstValue = false;
                bool setMessageTextHeightSecondValue = false;
                float MessageTextHeightFirstValue= 0;
                float MessageTextHeightSecondValue= 0;
                bool setMessageTextWidthFirstValue = false;
                bool setMessageTextWidthSecondValue = false;
                float MessageTextWidthFirstValue= 0;
                float MessageTextWidthSecondValue= 0;
                bool setMessageTextXFirstValue = false;
                bool setMessageTextXSecondValue = false;
                float MessageTextXFirstValue= 0;
                float MessageTextXSecondValue= 0;
                bool setMessageTextYFirstValue = false;
                bool setMessageTextYSecondValue = false;
                float MessageTextYFirstValue= 0;
                float MessageTextYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setCancelButtonCurrentButtonTypeStateFirstValue = true;
                        CancelButtonCurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                        setCancelButtonHeightFirstValue = true;
                        CancelButtonHeightFirstValue = 10f;
                        setCancelButtonWidthFirstValue = true;
                        CancelButtonWidthFirstValue = 6f;
                        setCancelButtonXFirstValue = true;
                        CancelButtonXFirstValue = 1746f;
                        setCancelButtonYFirstValue = true;
                        CancelButtonYFirstValue = 878f;
                        setConfirmButtonCurrentButtonTypeStateFirstValue = true;
                        ConfirmButtonCurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Check;
                        setConfirmButtonHeightFirstValue = true;
                        ConfirmButtonHeightFirstValue = 10f;
                        setConfirmButtonWidthFirstValue = true;
                        ConfirmButtonWidthFirstValue = 6f;
                        setConfirmButtonXFirstValue = true;
                        ConfirmButtonXFirstValue = 662f;
                        setConfirmButtonYFirstValue = true;
                        ConfirmButtonYFirstValue = 878f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMessageFrameInstanceHeightFirstValue = true;
                        MessageFrameInstanceHeightFirstValue = 43.96074f;
                        if (interpolationValue < 1)
                        {
                            this.MessageFrameInstance.WrapsChildren = true;
                        }
                        setMessageFrameInstanceXFirstValue = true;
                        MessageFrameInstanceXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.MessageFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setMessageFrameInstanceYFirstValue = true;
                        MessageFrameInstanceYFirstValue = 50.20832f;
                        if (interpolationValue < 1)
                        {
                            this.MessageFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MessageText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setMessageTextHeightFirstValue = true;
                        MessageTextHeightFirstValue = 426f;
                        if (interpolationValue < 1)
                        {
                            this.MessageText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageText.Text = "Message";
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMessageTextWidthFirstValue = true;
                        MessageTextWidthFirstValue = 1190f;
                        setMessageTextXFirstValue = true;
                        MessageTextXFirstValue = 676f;
                        setMessageTextYFirstValue = true;
                        MessageTextYFirstValue = 425f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setCancelButtonCurrentButtonTypeStateSecondValue = true;
                        CancelButtonCurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                        setCancelButtonHeightSecondValue = true;
                        CancelButtonHeightSecondValue = 10f;
                        setCancelButtonWidthSecondValue = true;
                        CancelButtonWidthSecondValue = 6f;
                        setCancelButtonXSecondValue = true;
                        CancelButtonXSecondValue = 1746f;
                        setCancelButtonYSecondValue = true;
                        CancelButtonYSecondValue = 878f;
                        setConfirmButtonCurrentButtonTypeStateSecondValue = true;
                        ConfirmButtonCurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Check;
                        setConfirmButtonHeightSecondValue = true;
                        ConfirmButtonHeightSecondValue = 10f;
                        setConfirmButtonWidthSecondValue = true;
                        ConfirmButtonWidthSecondValue = 6f;
                        setConfirmButtonXSecondValue = true;
                        ConfirmButtonXSecondValue = 662f;
                        setConfirmButtonYSecondValue = true;
                        ConfirmButtonYSecondValue = 878f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMessageFrameInstanceHeightSecondValue = true;
                        MessageFrameInstanceHeightSecondValue = 43.96074f;
                        if (interpolationValue >= 1)
                        {
                            this.MessageFrameInstance.WrapsChildren = true;
                        }
                        setMessageFrameInstanceXSecondValue = true;
                        MessageFrameInstanceXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.MessageFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setMessageFrameInstanceYSecondValue = true;
                        MessageFrameInstanceYSecondValue = 50.20832f;
                        if (interpolationValue >= 1)
                        {
                            this.MessageFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MessageText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setMessageTextHeightSecondValue = true;
                        MessageTextHeightSecondValue = 426f;
                        if (interpolationValue >= 1)
                        {
                            this.MessageText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageText.Text = "Message";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMessageTextWidthSecondValue = true;
                        MessageTextWidthSecondValue = 1190f;
                        setMessageTextXSecondValue = true;
                        MessageTextXSecondValue = 676f;
                        setMessageTextYSecondValue = true;
                        MessageTextYSecondValue = 425f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                if (setCancelButtonCurrentButtonTypeStateFirstValue && setCancelButtonCurrentButtonTypeStateSecondValue)
                {
                    CancelButton.InterpolateBetween(CancelButtonCurrentButtonTypeStateFirstValue, CancelButtonCurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setCancelButtonHeightFirstValue && setCancelButtonHeightSecondValue)
                {
                    CancelButton.Height = CancelButtonHeightFirstValue * (1 - interpolationValue) + CancelButtonHeightSecondValue * interpolationValue;
                }
                if (setCancelButtonWidthFirstValue && setCancelButtonWidthSecondValue)
                {
                    CancelButton.Width = CancelButtonWidthFirstValue * (1 - interpolationValue) + CancelButtonWidthSecondValue * interpolationValue;
                }
                if (setCancelButtonXFirstValue && setCancelButtonXSecondValue)
                {
                    CancelButton.X = CancelButtonXFirstValue * (1 - interpolationValue) + CancelButtonXSecondValue * interpolationValue;
                }
                if (setCancelButtonYFirstValue && setCancelButtonYSecondValue)
                {
                    CancelButton.Y = CancelButtonYFirstValue * (1 - interpolationValue) + CancelButtonYSecondValue * interpolationValue;
                }
                if (setConfirmButtonCurrentButtonTypeStateFirstValue && setConfirmButtonCurrentButtonTypeStateSecondValue)
                {
                    ConfirmButton.InterpolateBetween(ConfirmButtonCurrentButtonTypeStateFirstValue, ConfirmButtonCurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setConfirmButtonHeightFirstValue && setConfirmButtonHeightSecondValue)
                {
                    ConfirmButton.Height = ConfirmButtonHeightFirstValue * (1 - interpolationValue) + ConfirmButtonHeightSecondValue * interpolationValue;
                }
                if (setConfirmButtonWidthFirstValue && setConfirmButtonWidthSecondValue)
                {
                    ConfirmButton.Width = ConfirmButtonWidthFirstValue * (1 - interpolationValue) + ConfirmButtonWidthSecondValue * interpolationValue;
                }
                if (setConfirmButtonXFirstValue && setConfirmButtonXSecondValue)
                {
                    ConfirmButton.X = ConfirmButtonXFirstValue * (1 - interpolationValue) + ConfirmButtonXSecondValue * interpolationValue;
                }
                if (setConfirmButtonYFirstValue && setConfirmButtonYSecondValue)
                {
                    ConfirmButton.Y = ConfirmButtonYFirstValue * (1 - interpolationValue) + ConfirmButtonYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMessageFrameInstanceHeightFirstValue && setMessageFrameInstanceHeightSecondValue)
                {
                    MessageFrameInstance.Height = MessageFrameInstanceHeightFirstValue * (1 - interpolationValue) + MessageFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setMessageFrameInstanceXFirstValue && setMessageFrameInstanceXSecondValue)
                {
                    MessageFrameInstance.X = MessageFrameInstanceXFirstValue * (1 - interpolationValue) + MessageFrameInstanceXSecondValue * interpolationValue;
                }
                if (setMessageFrameInstanceYFirstValue && setMessageFrameInstanceYSecondValue)
                {
                    MessageFrameInstance.Y = MessageFrameInstanceYFirstValue * (1 - interpolationValue) + MessageFrameInstanceYSecondValue * interpolationValue;
                }
                if (setMessageTextHeightFirstValue && setMessageTextHeightSecondValue)
                {
                    MessageText.Height = MessageTextHeightFirstValue * (1 - interpolationValue) + MessageTextHeightSecondValue * interpolationValue;
                }
                if (setMessageTextWidthFirstValue && setMessageTextWidthSecondValue)
                {
                    MessageText.Width = MessageTextWidthFirstValue * (1 - interpolationValue) + MessageTextWidthSecondValue * interpolationValue;
                }
                if (setMessageTextXFirstValue && setMessageTextXSecondValue)
                {
                    MessageText.X = MessageTextXFirstValue * (1 - interpolationValue) + MessageTextXSecondValue * interpolationValue;
                }
                if (setMessageTextYFirstValue && setMessageTextYSecondValue)
                {
                    MessageText.Y = MessageTextYFirstValue * (1 - interpolationValue) + MessageTextYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ConfirmationWindowRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.ConfirmationWindowRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                DimmingInstance.StopAnimations();
                MessageFrameInstance.StopAnimations();
                ConfirmButton.StopAnimations();
                CancelButton.StopAnimations();
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
                            Name = "MessageFrameInstance.Height",
                            Type = "float",
                            Value = MessageFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Wraps Children",
                            Type = "bool",
                            Value = MessageFrameInstance.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.X",
                            Type = "float",
                            Value = MessageFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MessageFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Y",
                            Type = "float",
                            Value = MessageFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MessageFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.CustomFontFile",
                            Type = "string",
                            Value = MessageText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Height",
                            Type = "float",
                            Value = MessageText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MessageText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Text",
                            Type = "string",
                            Value = MessageText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.UseCustomFont",
                            Type = "bool",
                            Value = MessageText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MessageText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Width",
                            Type = "float",
                            Value = MessageText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.X",
                            Type = "float",
                            Value = MessageText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Y",
                            Type = "float",
                            Value = MessageText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = ConfirmButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Height",
                            Type = "float",
                            Value = ConfirmButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Width",
                            Type = "float",
                            Value = ConfirmButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X",
                            Type = "float",
                            Value = ConfirmButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Y",
                            Type = "float",
                            Value = ConfirmButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CancelButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = CancelButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CancelButton.Height",
                            Type = "float",
                            Value = CancelButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CancelButton.Width",
                            Type = "float",
                            Value = CancelButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CancelButton.X",
                            Type = "float",
                            Value = CancelButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CancelButton.Y",
                            Type = "float",
                            Value = CancelButton.Y
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
                            Name = "MessageFrameInstance.Height",
                            Type = "float",
                            Value = MessageFrameInstance.Height + 43.96074f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Wraps Children",
                            Type = "bool",
                            Value = MessageFrameInstance.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.X",
                            Type = "float",
                            Value = MessageFrameInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MessageFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Y",
                            Type = "float",
                            Value = MessageFrameInstance.Y + 50.20832f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MessageFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.CustomFontFile",
                            Type = "string",
                            Value = MessageText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Height",
                            Type = "float",
                            Value = MessageText.Height + 426f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MessageText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Text",
                            Type = "string",
                            Value = MessageText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.UseCustomFont",
                            Type = "bool",
                            Value = MessageText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MessageText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Width",
                            Type = "float",
                            Value = MessageText.Width + 1190f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.X",
                            Type = "float",
                            Value = MessageText.X + 676f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Y",
                            Type = "float",
                            Value = MessageText.Y + 425f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = ConfirmButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Height",
                            Type = "float",
                            Value = ConfirmButton.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Width",
                            Type = "float",
                            Value = ConfirmButton.Width + 6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X",
                            Type = "float",
                            Value = ConfirmButton.X + 662f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Y",
                            Type = "float",
                            Value = ConfirmButton.Y + 878f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CancelButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = CancelButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CancelButton.Height",
                            Type = "float",
                            Value = CancelButton.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CancelButton.Width",
                            Type = "float",
                            Value = CancelButton.Width + 6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CancelButton.X",
                            Type = "float",
                            Value = CancelButton.X + 1746f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CancelButton.Y",
                            Type = "float",
                            Value = CancelButton.Y + 878f
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
            private AbbatoirIntergrade.GumRuntimes.DimmingRuntime DimmingInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.MessageFrameRuntime MessageFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime MessageText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ConfirmButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime CancelButton { get; set; }
            public ConfirmationWindowRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "ConfirmationWindow");
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
                DimmingInstance = this.GetGraphicalUiElementByName("DimmingInstance") as AbbatoirIntergrade.GumRuntimes.DimmingRuntime;
                MessageFrameInstance = this.GetGraphicalUiElementByName("MessageFrameInstance") as AbbatoirIntergrade.GumRuntimes.MessageFrameRuntime;
                MessageText = this.GetGraphicalUiElementByName("MessageText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                ConfirmButton = this.GetGraphicalUiElementByName("ConfirmButton") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                CancelButton = this.GetGraphicalUiElementByName("CancelButton") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
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
