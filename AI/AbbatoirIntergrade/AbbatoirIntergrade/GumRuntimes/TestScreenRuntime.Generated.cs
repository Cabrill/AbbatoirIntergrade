    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class TestScreenRuntime : Gum.Wireframe.GraphicalUiElement
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
                            TestSprite.Height = 100f;
                            TestSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TestSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                            SetProperty("TestSprite.SourceFile", "AllUIAssets.png");
                            TestSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            TestSprite.TextureHeight = 825;
                            TestSprite.TextureLeft = 512;
                            TestSprite.TextureTop = 2720;
                            TestSprite.TextureWidth = 2008;
                            TestSprite.Width = 100f;
                            TestSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TestSprite.X = 82f;
                            TestSprite.Y = 6f;
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
                bool setTestSpriteHeightFirstValue = false;
                bool setTestSpriteHeightSecondValue = false;
                float TestSpriteHeightFirstValue= 0;
                float TestSpriteHeightSecondValue= 0;
                bool setTestSpriteTextureHeightFirstValue = false;
                bool setTestSpriteTextureHeightSecondValue = false;
                int TestSpriteTextureHeightFirstValue= 0;
                int TestSpriteTextureHeightSecondValue= 0;
                bool setTestSpriteTextureLeftFirstValue = false;
                bool setTestSpriteTextureLeftSecondValue = false;
                int TestSpriteTextureLeftFirstValue= 0;
                int TestSpriteTextureLeftSecondValue= 0;
                bool setTestSpriteTextureTopFirstValue = false;
                bool setTestSpriteTextureTopSecondValue = false;
                int TestSpriteTextureTopFirstValue= 0;
                int TestSpriteTextureTopSecondValue= 0;
                bool setTestSpriteTextureWidthFirstValue = false;
                bool setTestSpriteTextureWidthSecondValue = false;
                int TestSpriteTextureWidthFirstValue= 0;
                int TestSpriteTextureWidthSecondValue= 0;
                bool setTestSpriteWidthFirstValue = false;
                bool setTestSpriteWidthSecondValue = false;
                float TestSpriteWidthFirstValue= 0;
                float TestSpriteWidthSecondValue= 0;
                bool setTestSpriteXFirstValue = false;
                bool setTestSpriteXSecondValue = false;
                float TestSpriteXFirstValue= 0;
                float TestSpriteXSecondValue= 0;
                bool setTestSpriteYFirstValue = false;
                bool setTestSpriteYSecondValue = false;
                float TestSpriteYFirstValue= 0;
                float TestSpriteYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setTestSpriteHeightFirstValue = true;
                        TestSpriteHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.TestSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TestSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("TestSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TestSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTestSpriteTextureHeightFirstValue = true;
                        TestSpriteTextureHeightFirstValue = 825;
                        setTestSpriteTextureLeftFirstValue = true;
                        TestSpriteTextureLeftFirstValue = 512;
                        setTestSpriteTextureTopFirstValue = true;
                        TestSpriteTextureTopFirstValue = 2720;
                        setTestSpriteTextureWidthFirstValue = true;
                        TestSpriteTextureWidthFirstValue = 2008;
                        setTestSpriteWidthFirstValue = true;
                        TestSpriteWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.TestSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTestSpriteXFirstValue = true;
                        TestSpriteXFirstValue = 82f;
                        setTestSpriteYFirstValue = true;
                        TestSpriteYFirstValue = 6f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setTestSpriteHeightSecondValue = true;
                        TestSpriteHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.TestSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TestSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "BackgroundContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TestSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TestSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTestSpriteTextureHeightSecondValue = true;
                        TestSpriteTextureHeightSecondValue = 825;
                        setTestSpriteTextureLeftSecondValue = true;
                        TestSpriteTextureLeftSecondValue = 512;
                        setTestSpriteTextureTopSecondValue = true;
                        TestSpriteTextureTopSecondValue = 2720;
                        setTestSpriteTextureWidthSecondValue = true;
                        TestSpriteTextureWidthSecondValue = 2008;
                        setTestSpriteWidthSecondValue = true;
                        TestSpriteWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.TestSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTestSpriteXSecondValue = true;
                        TestSpriteXSecondValue = 82f;
                        setTestSpriteYSecondValue = true;
                        TestSpriteYSecondValue = 6f;
                        break;
                }
                if (setTestSpriteHeightFirstValue && setTestSpriteHeightSecondValue)
                {
                    TestSprite.Height = TestSpriteHeightFirstValue * (1 - interpolationValue) + TestSpriteHeightSecondValue * interpolationValue;
                }
                if (setTestSpriteTextureHeightFirstValue && setTestSpriteTextureHeightSecondValue)
                {
                    TestSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TestSpriteTextureHeightFirstValue* (1 - interpolationValue) + TestSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setTestSpriteTextureLeftFirstValue && setTestSpriteTextureLeftSecondValue)
                {
                    TestSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TestSpriteTextureLeftFirstValue* (1 - interpolationValue) + TestSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setTestSpriteTextureTopFirstValue && setTestSpriteTextureTopSecondValue)
                {
                    TestSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TestSpriteTextureTopFirstValue* (1 - interpolationValue) + TestSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setTestSpriteTextureWidthFirstValue && setTestSpriteTextureWidthSecondValue)
                {
                    TestSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TestSpriteTextureWidthFirstValue* (1 - interpolationValue) + TestSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setTestSpriteWidthFirstValue && setTestSpriteWidthSecondValue)
                {
                    TestSprite.Width = TestSpriteWidthFirstValue * (1 - interpolationValue) + TestSpriteWidthSecondValue * interpolationValue;
                }
                if (setTestSpriteXFirstValue && setTestSpriteXSecondValue)
                {
                    TestSprite.X = TestSpriteXFirstValue * (1 - interpolationValue) + TestSpriteXSecondValue * interpolationValue;
                }
                if (setTestSpriteYFirstValue && setTestSpriteYSecondValue)
                {
                    TestSprite.Y = TestSpriteYFirstValue * (1 - interpolationValue) + TestSpriteYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TestScreenRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.TestScreenRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
                            Name = "TestSprite.Height",
                            Type = "float",
                            Value = TestSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = TestSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Parent",
                            Type = "string",
                            Value = TestSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.SourceFile",
                            Type = "string",
                            Value = TestSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = TestSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Texture Height",
                            Type = "int",
                            Value = TestSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Texture Left",
                            Type = "int",
                            Value = TestSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Texture Top",
                            Type = "int",
                            Value = TestSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Texture Width",
                            Type = "int",
                            Value = TestSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Width",
                            Type = "float",
                            Value = TestSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = TestSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.X",
                            Type = "float",
                            Value = TestSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Y",
                            Type = "float",
                            Value = TestSprite.Y
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
                            Name = "TestSprite.Height",
                            Type = "float",
                            Value = TestSprite.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = TestSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Parent",
                            Type = "string",
                            Value = TestSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.SourceFile",
                            Type = "string",
                            Value = TestSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = TestSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Texture Height",
                            Type = "int",
                            Value = TestSprite.TextureHeight + 825
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Texture Left",
                            Type = "int",
                            Value = TestSprite.TextureLeft + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Texture Top",
                            Type = "int",
                            Value = TestSprite.TextureTop + 2720
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Texture Width",
                            Type = "int",
                            Value = TestSprite.TextureWidth + 2008
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Width",
                            Type = "float",
                            Value = TestSprite.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = TestSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.X",
                            Type = "float",
                            Value = TestSprite.X + 82f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TestSprite.Y",
                            Type = "float",
                            Value = TestSprite.Y + 6f
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
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime TestSprite { get; set; }
            public TestScreenRuntime (bool fullInstantiation = true)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "TestScreen");
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
                TestSprite = this.GetGraphicalUiElementByName("TestSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
