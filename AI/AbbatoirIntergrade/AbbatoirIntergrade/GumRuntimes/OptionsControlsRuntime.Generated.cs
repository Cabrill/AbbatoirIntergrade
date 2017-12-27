    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class OptionsControlsRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            WrapsChildren = true;
                            TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer");
                            NamesContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            NamesContainer.Height = 100f;
                            NamesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NamesContainer.Width = 50f;
                            NamesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SliderBarInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer");
                            OptionContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            OptionContainer.Height = 100f;
                            OptionContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            OptionContainer.Width = 50f;
                            OptionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                bool setNamesContainerHeightFirstValue = false;
                bool setNamesContainerHeightSecondValue = false;
                float NamesContainerHeightFirstValue= 0;
                float NamesContainerHeightSecondValue= 0;
                bool setNamesContainerWidthFirstValue = false;
                bool setNamesContainerWidthSecondValue = false;
                float NamesContainerWidthFirstValue= 0;
                float NamesContainerWidthSecondValue= 0;
                bool setOptionContainerHeightFirstValue = false;
                bool setOptionContainerHeightSecondValue = false;
                float OptionContainerHeightFirstValue= 0;
                float OptionContainerHeightSecondValue= 0;
                bool setOptionContainerWidthFirstValue = false;
                bool setOptionContainerWidthSecondValue = false;
                float OptionContainerWidthFirstValue= 0;
                float OptionContainerWidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NamesContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setNamesContainerHeightFirstValue = true;
                        NamesContainerHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.NamesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNamesContainerWidthFirstValue = true;
                        NamesContainerWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.NamesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OptionContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setOptionContainerHeightFirstValue = true;
                        OptionContainerHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.OptionContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOptionContainerWidthFirstValue = true;
                        OptionContainerWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.OptionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SliderBarInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NamesContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setNamesContainerHeightSecondValue = true;
                        NamesContainerHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.NamesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNamesContainerWidthSecondValue = true;
                        NamesContainerWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.NamesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OptionContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setOptionContainerHeightSecondValue = true;
                        OptionContainerHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOptionContainerWidthSecondValue = true;
                        OptionContainerWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SliderBarInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = true;
                        }
                        break;
                }
                if (setNamesContainerHeightFirstValue && setNamesContainerHeightSecondValue)
                {
                    NamesContainer.Height = NamesContainerHeightFirstValue * (1 - interpolationValue) + NamesContainerHeightSecondValue * interpolationValue;
                }
                if (setNamesContainerWidthFirstValue && setNamesContainerWidthSecondValue)
                {
                    NamesContainer.Width = NamesContainerWidthFirstValue * (1 - interpolationValue) + NamesContainerWidthSecondValue * interpolationValue;
                }
                if (setOptionContainerHeightFirstValue && setOptionContainerHeightSecondValue)
                {
                    OptionContainer.Height = OptionContainerHeightFirstValue * (1 - interpolationValue) + OptionContainerHeightSecondValue * interpolationValue;
                }
                if (setOptionContainerWidthFirstValue && setOptionContainerWidthSecondValue)
                {
                    OptionContainer.Width = OptionContainerWidthFirstValue * (1 - interpolationValue) + OptionContainerWidthSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                SliderBarInstance.StopAnimations();
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = NamesContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Height",
                            Type = "float",
                            Value = NamesContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NamesContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Width",
                            Type = "float",
                            Value = NamesContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NamesContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SliderBarInstance.Parent",
                            Type = "string",
                            Value = SliderBarInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = OptionContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Height",
                            Type = "float",
                            Value = OptionContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = OptionContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Width",
                            Type = "float",
                            Value = OptionContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = OptionContainer.WidthUnits
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = NamesContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Height",
                            Type = "float",
                            Value = NamesContainer.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NamesContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Width",
                            Type = "float",
                            Value = NamesContainer.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NamesContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SliderBarInstance.Parent",
                            Type = "string",
                            Value = SliderBarInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = OptionContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Height",
                            Type = "float",
                            Value = OptionContainer.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = OptionContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Width",
                            Type = "float",
                            Value = OptionContainer.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = OptionContainer.WidthUnits
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
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TextInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime NamesContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SliderBarRuntime SliderBarInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime OptionContainer { get; set; }
            public OptionsControlsRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                this.HasEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "OptionsControls");
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
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                NamesContainer = this.GetGraphicalUiElementByName("NamesContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                SliderBarInstance = this.GetGraphicalUiElementByName("SliderBarInstance") as AbbatoirIntergrade.GumRuntimes.SliderBarRuntime;
                OptionContainer = this.GetGraphicalUiElementByName("OptionContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
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
