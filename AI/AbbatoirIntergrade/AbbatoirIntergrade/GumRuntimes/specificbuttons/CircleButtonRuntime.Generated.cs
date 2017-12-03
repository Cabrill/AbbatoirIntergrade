    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class CircleButtonRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            CircleInstance.Alpha = 0;
                            CircleInstance.Height = 140f;
                            CircleInstance.Radius = 140f;
                            CircleInstance.Width = 140f;
                            CircleInstance.X = 50f;
                            CircleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            CircleInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CircleInstance.Y = 50f;
                            CircleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            CircleInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                bool setCircleInstanceAlphaFirstValue = false;
                bool setCircleInstanceAlphaSecondValue = false;
                int CircleInstanceAlphaFirstValue= 0;
                int CircleInstanceAlphaSecondValue= 0;
                bool setCircleInstanceHeightFirstValue = false;
                bool setCircleInstanceHeightSecondValue = false;
                float CircleInstanceHeightFirstValue= 0;
                float CircleInstanceHeightSecondValue= 0;
                bool setCircleInstanceRadiusFirstValue = false;
                bool setCircleInstanceRadiusSecondValue = false;
                float CircleInstanceRadiusFirstValue= 0;
                float CircleInstanceRadiusSecondValue= 0;
                bool setCircleInstanceWidthFirstValue = false;
                bool setCircleInstanceWidthSecondValue = false;
                float CircleInstanceWidthFirstValue= 0;
                float CircleInstanceWidthSecondValue= 0;
                bool setCircleInstanceXFirstValue = false;
                bool setCircleInstanceXSecondValue = false;
                float CircleInstanceXFirstValue= 0;
                float CircleInstanceXSecondValue= 0;
                bool setCircleInstanceYFirstValue = false;
                bool setCircleInstanceYSecondValue = false;
                float CircleInstanceYFirstValue= 0;
                float CircleInstanceYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setCircleInstanceAlphaFirstValue = true;
                        CircleInstanceAlphaFirstValue = 0;
                        setCircleInstanceHeightFirstValue = true;
                        CircleInstanceHeightFirstValue = 140f;
                        setCircleInstanceRadiusFirstValue = true;
                        CircleInstanceRadiusFirstValue = 140f;
                        setCircleInstanceWidthFirstValue = true;
                        CircleInstanceWidthFirstValue = 140f;
                        setCircleInstanceXFirstValue = true;
                        CircleInstanceXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.CircleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CircleInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCircleInstanceYFirstValue = true;
                        CircleInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.CircleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CircleInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setCircleInstanceAlphaSecondValue = true;
                        CircleInstanceAlphaSecondValue = 0;
                        setCircleInstanceHeightSecondValue = true;
                        CircleInstanceHeightSecondValue = 140f;
                        setCircleInstanceRadiusSecondValue = true;
                        CircleInstanceRadiusSecondValue = 140f;
                        setCircleInstanceWidthSecondValue = true;
                        CircleInstanceWidthSecondValue = 140f;
                        setCircleInstanceXSecondValue = true;
                        CircleInstanceXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.CircleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CircleInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCircleInstanceYSecondValue = true;
                        CircleInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.CircleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CircleInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        break;
                }
                if (setCircleInstanceAlphaFirstValue && setCircleInstanceAlphaSecondValue)
                {
                    CircleInstance.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(CircleInstanceAlphaFirstValue* (1 - interpolationValue) + CircleInstanceAlphaSecondValue * interpolationValue);
                }
                if (setCircleInstanceHeightFirstValue && setCircleInstanceHeightSecondValue)
                {
                    CircleInstance.Height = CircleInstanceHeightFirstValue * (1 - interpolationValue) + CircleInstanceHeightSecondValue * interpolationValue;
                }
                if (setCircleInstanceRadiusFirstValue && setCircleInstanceRadiusSecondValue)
                {
                    CircleInstance.Radius = CircleInstanceRadiusFirstValue * (1 - interpolationValue) + CircleInstanceRadiusSecondValue * interpolationValue;
                }
                if (setCircleInstanceWidthFirstValue && setCircleInstanceWidthSecondValue)
                {
                    CircleInstance.Width = CircleInstanceWidthFirstValue * (1 - interpolationValue) + CircleInstanceWidthSecondValue * interpolationValue;
                }
                if (setCircleInstanceXFirstValue && setCircleInstanceXSecondValue)
                {
                    CircleInstance.X = CircleInstanceXFirstValue * (1 - interpolationValue) + CircleInstanceXSecondValue * interpolationValue;
                }
                if (setCircleInstanceYFirstValue && setCircleInstanceYSecondValue)
                {
                    CircleInstance.Y = CircleInstanceYFirstValue * (1 - interpolationValue) + CircleInstanceYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.CircleButtonRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.CircleButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "CircleInstance.Alpha",
                            Type = "int",
                            Value = CircleInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Height",
                            Type = "float",
                            Value = CircleInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Radius",
                            Type = "float",
                            Value = CircleInstance.Radius
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Width",
                            Type = "float",
                            Value = CircleInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.X",
                            Type = "float",
                            Value = CircleInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CircleInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.X Units",
                            Type = "PositionUnitType",
                            Value = CircleInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Y",
                            Type = "float",
                            Value = CircleInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CircleInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = CircleInstance.YUnits
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
                            Name = "CircleInstance.Alpha",
                            Type = "int",
                            Value = CircleInstance.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Height",
                            Type = "float",
                            Value = CircleInstance.Height + 140f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Radius",
                            Type = "float",
                            Value = CircleInstance.Radius + 140f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Width",
                            Type = "float",
                            Value = CircleInstance.Width + 140f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.X",
                            Type = "float",
                            Value = CircleInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CircleInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.X Units",
                            Type = "PositionUnitType",
                            Value = CircleInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Y",
                            Type = "float",
                            Value = CircleInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CircleInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = CircleInstance.YUnits
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
            private AbbatoirIntergrade.GumRuntimes.CircleRuntime CircleInstance { get; set; }
            public CircleButtonRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "specificbuttons/CircleButton");
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
                CircleInstance = this.GetGraphicalUiElementByName("CircleInstance") as AbbatoirIntergrade.GumRuntimes.CircleRuntime;
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
