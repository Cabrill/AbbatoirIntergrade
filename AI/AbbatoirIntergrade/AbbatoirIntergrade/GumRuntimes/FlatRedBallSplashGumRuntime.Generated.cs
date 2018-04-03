    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class FlatRedBallSplashGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            BackgroundColoredRectangle.Blue = 0;
                            BackgroundColoredRectangle.Green = 0;
                            BackgroundColoredRectangle.Height = 100f;
                            BackgroundColoredRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BackgroundColoredRectangle.Red = 0;
                            BackgroundColoredRectangle.Width = 100f;
                            BackgroundColoredRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FRBLogoSprite.Height = 25f;
                            FRBLogoSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("FRBLogoSprite.SourceFile", "frblogo.png");
                            FRBLogoSprite.Width = 80f;
                            FRBLogoSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FRBLogoSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            FRBLogoSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            FRBLogoSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            FRBLogoSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                bool setBackgroundColoredRectangleBlueFirstValue = false;
                bool setBackgroundColoredRectangleBlueSecondValue = false;
                int BackgroundColoredRectangleBlueFirstValue= 0;
                int BackgroundColoredRectangleBlueSecondValue= 0;
                bool setBackgroundColoredRectangleGreenFirstValue = false;
                bool setBackgroundColoredRectangleGreenSecondValue = false;
                int BackgroundColoredRectangleGreenFirstValue= 0;
                int BackgroundColoredRectangleGreenSecondValue= 0;
                bool setBackgroundColoredRectangleHeightFirstValue = false;
                bool setBackgroundColoredRectangleHeightSecondValue = false;
                float BackgroundColoredRectangleHeightFirstValue= 0;
                float BackgroundColoredRectangleHeightSecondValue= 0;
                bool setBackgroundColoredRectangleRedFirstValue = false;
                bool setBackgroundColoredRectangleRedSecondValue = false;
                int BackgroundColoredRectangleRedFirstValue= 0;
                int BackgroundColoredRectangleRedSecondValue= 0;
                bool setBackgroundColoredRectangleWidthFirstValue = false;
                bool setBackgroundColoredRectangleWidthSecondValue = false;
                float BackgroundColoredRectangleWidthFirstValue= 0;
                float BackgroundColoredRectangleWidthSecondValue= 0;
                bool setFRBLogoSpriteHeightFirstValue = false;
                bool setFRBLogoSpriteHeightSecondValue = false;
                float FRBLogoSpriteHeightFirstValue= 0;
                float FRBLogoSpriteHeightSecondValue= 0;
                bool setFRBLogoSpriteWidthFirstValue = false;
                bool setFRBLogoSpriteWidthSecondValue = false;
                float FRBLogoSpriteWidthFirstValue= 0;
                float FRBLogoSpriteWidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBackgroundColoredRectangleBlueFirstValue = true;
                        BackgroundColoredRectangleBlueFirstValue = 0;
                        setBackgroundColoredRectangleGreenFirstValue = true;
                        BackgroundColoredRectangleGreenFirstValue = 0;
                        setBackgroundColoredRectangleHeightFirstValue = true;
                        BackgroundColoredRectangleHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundColoredRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBackgroundColoredRectangleRedFirstValue = true;
                        BackgroundColoredRectangleRedFirstValue = 0;
                        setBackgroundColoredRectangleWidthFirstValue = true;
                        BackgroundColoredRectangleWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundColoredRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setFRBLogoSpriteHeightFirstValue = true;
                        FRBLogoSpriteHeightFirstValue = 25f;
                        if (interpolationValue < 1)
                        {
                            this.FRBLogoSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("FRBLogoSprite.SourceFile", "frblogo.png");
                        }
                        setFRBLogoSpriteWidthFirstValue = true;
                        FRBLogoSpriteWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.FRBLogoSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FRBLogoSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FRBLogoSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FRBLogoSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FRBLogoSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBackgroundColoredRectangleBlueSecondValue = true;
                        BackgroundColoredRectangleBlueSecondValue = 0;
                        setBackgroundColoredRectangleGreenSecondValue = true;
                        BackgroundColoredRectangleGreenSecondValue = 0;
                        setBackgroundColoredRectangleHeightSecondValue = true;
                        BackgroundColoredRectangleHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundColoredRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBackgroundColoredRectangleRedSecondValue = true;
                        BackgroundColoredRectangleRedSecondValue = 0;
                        setBackgroundColoredRectangleWidthSecondValue = true;
                        BackgroundColoredRectangleWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundColoredRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setFRBLogoSpriteHeightSecondValue = true;
                        FRBLogoSpriteHeightSecondValue = 25f;
                        if (interpolationValue >= 1)
                        {
                            this.FRBLogoSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("FRBLogoSprite.SourceFile", "frblogo.png");
                        }
                        setFRBLogoSpriteWidthSecondValue = true;
                        FRBLogoSpriteWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.FRBLogoSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FRBLogoSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FRBLogoSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FRBLogoSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FRBLogoSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                if (setBackgroundColoredRectangleBlueFirstValue && setBackgroundColoredRectangleBlueSecondValue)
                {
                    BackgroundColoredRectangle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundColoredRectangleBlueFirstValue* (1 - interpolationValue) + BackgroundColoredRectangleBlueSecondValue * interpolationValue);
                }
                if (setBackgroundColoredRectangleGreenFirstValue && setBackgroundColoredRectangleGreenSecondValue)
                {
                    BackgroundColoredRectangle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundColoredRectangleGreenFirstValue* (1 - interpolationValue) + BackgroundColoredRectangleGreenSecondValue * interpolationValue);
                }
                if (setBackgroundColoredRectangleHeightFirstValue && setBackgroundColoredRectangleHeightSecondValue)
                {
                    BackgroundColoredRectangle.Height = BackgroundColoredRectangleHeightFirstValue * (1 - interpolationValue) + BackgroundColoredRectangleHeightSecondValue * interpolationValue;
                }
                if (setBackgroundColoredRectangleRedFirstValue && setBackgroundColoredRectangleRedSecondValue)
                {
                    BackgroundColoredRectangle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundColoredRectangleRedFirstValue* (1 - interpolationValue) + BackgroundColoredRectangleRedSecondValue * interpolationValue);
                }
                if (setBackgroundColoredRectangleWidthFirstValue && setBackgroundColoredRectangleWidthSecondValue)
                {
                    BackgroundColoredRectangle.Width = BackgroundColoredRectangleWidthFirstValue * (1 - interpolationValue) + BackgroundColoredRectangleWidthSecondValue * interpolationValue;
                }
                if (setFRBLogoSpriteHeightFirstValue && setFRBLogoSpriteHeightSecondValue)
                {
                    FRBLogoSprite.Height = FRBLogoSpriteHeightFirstValue * (1 - interpolationValue) + FRBLogoSpriteHeightSecondValue * interpolationValue;
                }
                if (setFRBLogoSpriteWidthFirstValue && setFRBLogoSpriteWidthSecondValue)
                {
                    FRBLogoSprite.Width = FRBLogoSpriteWidthFirstValue * (1 - interpolationValue) + FRBLogoSpriteWidthSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.FlatRedBallSplashGumRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.FlatRedBallSplashGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "BackgroundColoredRectangle.Blue",
                            Type = "int",
                            Value = BackgroundColoredRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Green",
                            Type = "int",
                            Value = BackgroundColoredRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Height",
                            Type = "float",
                            Value = BackgroundColoredRectangle.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundColoredRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Red",
                            Type = "int",
                            Value = BackgroundColoredRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Width",
                            Type = "float",
                            Value = BackgroundColoredRectangle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundColoredRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Height",
                            Type = "float",
                            Value = FRBLogoSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = FRBLogoSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.SourceFile",
                            Type = "string",
                            Value = FRBLogoSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Width",
                            Type = "float",
                            Value = FRBLogoSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = FRBLogoSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = FRBLogoSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.X Units",
                            Type = "PositionUnitType",
                            Value = FRBLogoSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = FRBLogoSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = FRBLogoSprite.YUnits
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
                            Name = "BackgroundColoredRectangle.Blue",
                            Type = "int",
                            Value = BackgroundColoredRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Green",
                            Type = "int",
                            Value = BackgroundColoredRectangle.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Height",
                            Type = "float",
                            Value = BackgroundColoredRectangle.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundColoredRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Red",
                            Type = "int",
                            Value = BackgroundColoredRectangle.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Width",
                            Type = "float",
                            Value = BackgroundColoredRectangle.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColoredRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundColoredRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Height",
                            Type = "float",
                            Value = FRBLogoSprite.Height + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = FRBLogoSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.SourceFile",
                            Type = "string",
                            Value = FRBLogoSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Width",
                            Type = "float",
                            Value = FRBLogoSprite.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = FRBLogoSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = FRBLogoSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.X Units",
                            Type = "PositionUnitType",
                            Value = FRBLogoSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = FRBLogoSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FRBLogoSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = FRBLogoSprite.YUnits
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
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime BackgroundColoredRectangle { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime FRBLogoSprite { get; set; }
            public FlatRedBallSplashGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "FlatRedBallSplashGum");
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
                BackgroundColoredRectangle = this.GetGraphicalUiElementByName("BackgroundColoredRectangle") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                FRBLogoSprite = this.GetGraphicalUiElementByName("FRBLogoSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
