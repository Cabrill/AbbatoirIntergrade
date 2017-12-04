    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class GameScreenGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            HorizonBoxInstance.Visible = true;
                            EnemyInfoInstance.Visible = false;
                            StructureInfoInstance.Visible = false;
                            ChatBoxInstance.X = 0f;
                            ChatBoxInstance.Y = 50f;
                            LivesPointsDisplayInstance.X = 100f;
                            LivesPointsDisplayInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            LivesPointsDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                bool setChatBoxInstanceXFirstValue = false;
                bool setChatBoxInstanceXSecondValue = false;
                float ChatBoxInstanceXFirstValue= 0;
                float ChatBoxInstanceXSecondValue= 0;
                bool setChatBoxInstanceYFirstValue = false;
                bool setChatBoxInstanceYSecondValue = false;
                float ChatBoxInstanceYFirstValue= 0;
                float ChatBoxInstanceYSecondValue= 0;
                bool setLivesPointsDisplayInstanceXFirstValue = false;
                bool setLivesPointsDisplayInstanceXSecondValue = false;
                float LivesPointsDisplayInstanceXFirstValue= 0;
                float LivesPointsDisplayInstanceXSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setChatBoxInstanceXFirstValue = true;
                        ChatBoxInstanceXFirstValue = 0f;
                        setChatBoxInstanceYFirstValue = true;
                        ChatBoxInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.EnemyInfoInstance.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HorizonBoxInstance.Visible = true;
                        }
                        setLivesPointsDisplayInstanceXFirstValue = true;
                        LivesPointsDisplayInstanceXFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.LivesPointsDisplayInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesPointsDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureInfoInstance.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setChatBoxInstanceXSecondValue = true;
                        ChatBoxInstanceXSecondValue = 0f;
                        setChatBoxInstanceYSecondValue = true;
                        ChatBoxInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.EnemyInfoInstance.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HorizonBoxInstance.Visible = true;
                        }
                        setLivesPointsDisplayInstanceXSecondValue = true;
                        LivesPointsDisplayInstanceXSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesPointsDisplayInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesPointsDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureInfoInstance.Visible = false;
                        }
                        break;
                }
                if (setChatBoxInstanceXFirstValue && setChatBoxInstanceXSecondValue)
                {
                    ChatBoxInstance.X = ChatBoxInstanceXFirstValue * (1 - interpolationValue) + ChatBoxInstanceXSecondValue * interpolationValue;
                }
                if (setChatBoxInstanceYFirstValue && setChatBoxInstanceYSecondValue)
                {
                    ChatBoxInstance.Y = ChatBoxInstanceYFirstValue * (1 - interpolationValue) + ChatBoxInstanceYSecondValue * interpolationValue;
                }
                if (setLivesPointsDisplayInstanceXFirstValue && setLivesPointsDisplayInstanceXSecondValue)
                {
                    LivesPointsDisplayInstance.X = LivesPointsDisplayInstanceXFirstValue * (1 - interpolationValue) + LivesPointsDisplayInstanceXSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                HorizonBoxInstance.StopAnimations();
                EnemyInfoInstance.StopAnimations();
                StructureInfoInstance.StopAnimations();
                ChatBoxInstance.StopAnimations();
                BuildMenuInstance.StopAnimations();
                LivesPointsDisplayInstance.StopAnimations();
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
                            Name = "HorizonBoxInstance.Visible",
                            Type = "bool",
                            Value = HorizonBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnemyInfoInstance.Visible",
                            Type = "bool",
                            Value = EnemyInfoInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance.Visible",
                            Type = "bool",
                            Value = StructureInfoInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X",
                            Type = "float",
                            Value = LivesPointsDisplayInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LivesPointsDisplayInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LivesPointsDisplayInstance.XUnits
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
                            Name = "HorizonBoxInstance.Visible",
                            Type = "bool",
                            Value = HorizonBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnemyInfoInstance.Visible",
                            Type = "bool",
                            Value = EnemyInfoInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance.Visible",
                            Type = "bool",
                            Value = StructureInfoInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X",
                            Type = "float",
                            Value = LivesPointsDisplayInstance.X + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LivesPointsDisplayInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LivesPointsDisplayInstance.XUnits
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
            private AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime HorizonBoxInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime EnemyInfoInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime StructureInfoInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime ChatBoxInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime BuildMenuInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime LivesPointsDisplayInstance { get; set; }
            public GameScreenGumRuntime (bool fullInstantiation = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "GameScreenGum");
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
                HorizonBoxInstance = this.GetGraphicalUiElementByName("HorizonBoxInstance") as AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime;
                EnemyInfoInstance = this.GetGraphicalUiElementByName("EnemyInfoInstance") as AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime;
                StructureInfoInstance = this.GetGraphicalUiElementByName("StructureInfoInstance") as AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime;
                ChatBoxInstance = this.GetGraphicalUiElementByName("ChatBoxInstance") as AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime;
                BuildMenuInstance = this.GetGraphicalUiElementByName("BuildMenuInstance") as AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime;
                LivesPointsDisplayInstance = this.GetGraphicalUiElementByName("LivesPointsDisplayInstance") as AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime;
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
