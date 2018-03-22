    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class CreditsScreenGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            BackgroundRectangle.Blue = 0;
                            BackgroundRectangle.Green = 0;
                            BackgroundRectangle.Height = 100f;
                            BackgroundRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BackgroundRectangle.Red = 0;
                            BackgroundRectangle.Width = 100f;
                            BackgroundRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ContainerInstance.Height = 100f;
                            ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ContainerInstance.Width = 80f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                bool setBackgroundRectangleBlueFirstValue = false;
                bool setBackgroundRectangleBlueSecondValue = false;
                int BackgroundRectangleBlueFirstValue= 0;
                int BackgroundRectangleBlueSecondValue= 0;
                bool setBackgroundRectangleGreenFirstValue = false;
                bool setBackgroundRectangleGreenSecondValue = false;
                int BackgroundRectangleGreenFirstValue= 0;
                int BackgroundRectangleGreenSecondValue= 0;
                bool setBackgroundRectangleHeightFirstValue = false;
                bool setBackgroundRectangleHeightSecondValue = false;
                float BackgroundRectangleHeightFirstValue= 0;
                float BackgroundRectangleHeightSecondValue= 0;
                bool setBackgroundRectangleRedFirstValue = false;
                bool setBackgroundRectangleRedSecondValue = false;
                int BackgroundRectangleRedFirstValue= 0;
                int BackgroundRectangleRedSecondValue= 0;
                bool setBackgroundRectangleWidthFirstValue = false;
                bool setBackgroundRectangleWidthSecondValue = false;
                float BackgroundRectangleWidthFirstValue= 0;
                float BackgroundRectangleWidthSecondValue= 0;
                bool setContainerInstanceHeightFirstValue = false;
                bool setContainerInstanceHeightSecondValue = false;
                float ContainerInstanceHeightFirstValue= 0;
                float ContainerInstanceHeightSecondValue= 0;
                bool setContainerInstanceWidthFirstValue = false;
                bool setContainerInstanceWidthSecondValue = false;
                float ContainerInstanceWidthFirstValue= 0;
                float ContainerInstanceWidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBackgroundRectangleBlueFirstValue = true;
                        BackgroundRectangleBlueFirstValue = 0;
                        setBackgroundRectangleGreenFirstValue = true;
                        BackgroundRectangleGreenFirstValue = 0;
                        setBackgroundRectangleHeightFirstValue = true;
                        BackgroundRectangleHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBackgroundRectangleRedFirstValue = true;
                        BackgroundRectangleRedFirstValue = 0;
                        setBackgroundRectangleWidthFirstValue = true;
                        BackgroundRectangleWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceWidthFirstValue = true;
                        ContainerInstanceWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBackgroundRectangleBlueSecondValue = true;
                        BackgroundRectangleBlueSecondValue = 0;
                        setBackgroundRectangleGreenSecondValue = true;
                        BackgroundRectangleGreenSecondValue = 0;
                        setBackgroundRectangleHeightSecondValue = true;
                        BackgroundRectangleHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBackgroundRectangleRedSecondValue = true;
                        BackgroundRectangleRedSecondValue = 0;
                        setBackgroundRectangleWidthSecondValue = true;
                        BackgroundRectangleWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceWidthSecondValue = true;
                        ContainerInstanceWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                if (setBackgroundRectangleBlueFirstValue && setBackgroundRectangleBlueSecondValue)
                {
                    BackgroundRectangle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundRectangleBlueFirstValue* (1 - interpolationValue) + BackgroundRectangleBlueSecondValue * interpolationValue);
                }
                if (setBackgroundRectangleGreenFirstValue && setBackgroundRectangleGreenSecondValue)
                {
                    BackgroundRectangle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundRectangleGreenFirstValue* (1 - interpolationValue) + BackgroundRectangleGreenSecondValue * interpolationValue);
                }
                if (setBackgroundRectangleHeightFirstValue && setBackgroundRectangleHeightSecondValue)
                {
                    BackgroundRectangle.Height = BackgroundRectangleHeightFirstValue * (1 - interpolationValue) + BackgroundRectangleHeightSecondValue * interpolationValue;
                }
                if (setBackgroundRectangleRedFirstValue && setBackgroundRectangleRedSecondValue)
                {
                    BackgroundRectangle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundRectangleRedFirstValue* (1 - interpolationValue) + BackgroundRectangleRedSecondValue * interpolationValue);
                }
                if (setBackgroundRectangleWidthFirstValue && setBackgroundRectangleWidthSecondValue)
                {
                    BackgroundRectangle.Width = BackgroundRectangleWidthFirstValue * (1 - interpolationValue) + BackgroundRectangleWidthSecondValue * interpolationValue;
                }
                if (setContainerInstanceHeightFirstValue && setContainerInstanceHeightSecondValue)
                {
                    ContainerInstance.Height = ContainerInstanceHeightFirstValue * (1 - interpolationValue) + ContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setContainerInstanceWidthFirstValue && setContainerInstanceWidthSecondValue)
                {
                    ContainerInstance.Width = ContainerInstanceWidthFirstValue * (1 - interpolationValue) + ContainerInstanceWidthSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.CreditsScreenGumRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.CreditsScreenGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "BackgroundRectangle.Blue",
                            Type = "int",
                            Value = BackgroundRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Green",
                            Type = "int",
                            Value = BackgroundRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Height",
                            Type = "float",
                            Value = BackgroundRectangle.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Red",
                            Type = "int",
                            Value = BackgroundRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Width",
                            Type = "float",
                            Value = BackgroundRectangle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ContainerInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ContainerInstance.XUnits
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
                            Name = "BackgroundRectangle.Blue",
                            Type = "int",
                            Value = BackgroundRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Green",
                            Type = "int",
                            Value = BackgroundRectangle.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Height",
                            Type = "float",
                            Value = BackgroundRectangle.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Red",
                            Type = "int",
                            Value = BackgroundRectangle.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Width",
                            Type = "float",
                            Value = BackgroundRectangle.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ContainerInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ContainerInstance.XUnits
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
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime BackgroundRectangle { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            public CreditsScreenGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "CreditsScreenGum");
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
                BackgroundRectangle = this.GetGraphicalUiElementByName("BackgroundRectangle") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
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
