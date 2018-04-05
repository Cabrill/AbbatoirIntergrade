    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class WindowFullscreenRadioRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum RadioButtonCategory
            {
                EnabledOn,
                EnabledOff,
                DisabledOn,
                DisabledOff,
                HighlightedOn,
                HighlightedOff,
                PushedOn,
                PushedOff
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            RadioButtonCategory mCurrentRadioButtonCategoryState;
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
                            break;
                    }
                }
            }
            public RadioButtonCategory CurrentRadioButtonCategoryState
            {
                get
                {
                    return mCurrentRadioButtonCategoryState;
                }
                set
                {
                    mCurrentRadioButtonCategoryState = value;
                    switch(mCurrentRadioButtonCategoryState)
                    {
                        case  RadioButtonCategory.EnabledOn:
                            break;
                        case  RadioButtonCategory.EnabledOff:
                            break;
                        case  RadioButtonCategory.DisabledOn:
                            break;
                        case  RadioButtonCategory.DisabledOff:
                            break;
                        case  RadioButtonCategory.HighlightedOn:
                            break;
                        case  RadioButtonCategory.HighlightedOff:
                            break;
                        case  RadioButtonCategory.PushedOn:
                            break;
                        case  RadioButtonCategory.PushedOff:
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
                switch(firstState)
                {
                    case  VariableState.Default:
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        break;
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
            public void InterpolateBetween (RadioButtonCategory firstState, RadioButtonCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  RadioButtonCategory.EnabledOn:
                        break;
                    case  RadioButtonCategory.EnabledOff:
                        break;
                    case  RadioButtonCategory.DisabledOn:
                        break;
                    case  RadioButtonCategory.DisabledOff:
                        break;
                    case  RadioButtonCategory.HighlightedOn:
                        break;
                    case  RadioButtonCategory.HighlightedOff:
                        break;
                    case  RadioButtonCategory.PushedOn:
                        break;
                    case  RadioButtonCategory.PushedOff:
                        break;
                }
                switch(secondState)
                {
                    case  RadioButtonCategory.EnabledOn:
                        break;
                    case  RadioButtonCategory.EnabledOff:
                        break;
                    case  RadioButtonCategory.DisabledOn:
                        break;
                    case  RadioButtonCategory.DisabledOff:
                        break;
                    case  RadioButtonCategory.HighlightedOn:
                        break;
                    case  RadioButtonCategory.HighlightedOff:
                        break;
                    case  RadioButtonCategory.PushedOn:
                        break;
                    case  RadioButtonCategory.PushedOff:
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentRadioButtonCategoryState = firstState;
                }
                else
                {
                    mCurrentRadioButtonCategoryState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.WindowFullscreenRadioRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.WindowFullscreenRadioRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.WindowFullscreenRadioRuntime.RadioButtonCategory fromState,AbbatoirIntergrade.GumRuntimes.WindowFullscreenRadioRuntime.RadioButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (RadioButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "RadioButtonCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentRadioButtonCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (RadioButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentRadioButtonCategoryState = toState;
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (RadioButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  RadioButtonCategory.EnabledOn:
                        break;
                    case  RadioButtonCategory.EnabledOff:
                        break;
                    case  RadioButtonCategory.DisabledOn:
                        break;
                    case  RadioButtonCategory.DisabledOff:
                        break;
                    case  RadioButtonCategory.HighlightedOn:
                        break;
                    case  RadioButtonCategory.HighlightedOff:
                        break;
                    case  RadioButtonCategory.PushedOn:
                        break;
                    case  RadioButtonCategory.PushedOff:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (RadioButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  RadioButtonCategory.EnabledOn:
                        break;
                    case  RadioButtonCategory.EnabledOff:
                        break;
                    case  RadioButtonCategory.DisabledOn:
                        break;
                    case  RadioButtonCategory.DisabledOff:
                        break;
                    case  RadioButtonCategory.HighlightedOn:
                        break;
                    case  RadioButtonCategory.HighlightedOff:
                        break;
                    case  RadioButtonCategory.PushedOn:
                        break;
                    case  RadioButtonCategory.PushedOff:
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
                    else if (category.Name == "RadioButtonCategory")
                    {
                        if(state.Name == "EnabledOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.EnabledOn;
                        if(state.Name == "EnabledOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.EnabledOff;
                        if(state.Name == "DisabledOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.DisabledOn;
                        if(state.Name == "DisabledOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.DisabledOff;
                        if(state.Name == "HighlightedOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedOn;
                        if(state.Name == "HighlightedOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedOff;
                        if(state.Name == "PushedOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.PushedOn;
                        if(state.Name == "PushedOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.PushedOff;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public WindowFullscreenRadioRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "WindowFullscreenRadio");
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
                if (tryCreateFormsObject)
                {
                    FormsControl = new FlatRedBall.Forms.Controls.RadioButton(this);
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
            public FlatRedBall.Forms.Controls.RadioButton FormsControl {get; private set;}
            public override object FormsControlAsObject { get { return FormsControl; } }
        }
    }
