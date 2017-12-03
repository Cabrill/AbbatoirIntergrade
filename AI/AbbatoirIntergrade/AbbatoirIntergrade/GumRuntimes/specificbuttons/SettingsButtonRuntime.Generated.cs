    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class SettingsButtonRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Highlight
            {
                Highlighted,
                NotHighlighted
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Highlight mCurrentHighlightState;
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            ClipsChildren = false;
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            HighlightSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("HighlightSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            HighlightSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            HighlightSprite.TextureHeight = 83;
                            HighlightSprite.TextureLeft = 0;
                            HighlightSprite.TextureTop = 93;
                            HighlightSprite.TextureWidth = 82;
                            HighlightSprite.Visible = false;
                            HighlightSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SettingsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("SettingsSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            SettingsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SettingsSprite.TextureHeight = 83;
                            SettingsSprite.TextureLeft = 82;
                            SettingsSprite.TextureTop = 93;
                            SettingsSprite.TextureWidth = 82;
                            SettingsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            break;
                    }
                }
            }
            public Highlight CurrentHighlightState
            {
                get
                {
                    return mCurrentHighlightState;
                }
                set
                {
                    mCurrentHighlightState = value;
                    switch(mCurrentHighlightState)
                    {
                        case  Highlight.Highlighted:
                            HighlightSprite.Visible = true;
                            break;
                        case  Highlight.NotHighlighted:
                            HighlightSprite.Visible = false;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setHighlightSpriteTextureHeightFirstValue = false;
                bool setHighlightSpriteTextureHeightSecondValue = false;
                int HighlightSpriteTextureHeightFirstValue= 0;
                int HighlightSpriteTextureHeightSecondValue= 0;
                bool setHighlightSpriteTextureLeftFirstValue = false;
                bool setHighlightSpriteTextureLeftSecondValue = false;
                int HighlightSpriteTextureLeftFirstValue= 0;
                int HighlightSpriteTextureLeftSecondValue= 0;
                bool setHighlightSpriteTextureTopFirstValue = false;
                bool setHighlightSpriteTextureTopSecondValue = false;
                int HighlightSpriteTextureTopFirstValue= 0;
                int HighlightSpriteTextureTopSecondValue= 0;
                bool setHighlightSpriteTextureWidthFirstValue = false;
                bool setHighlightSpriteTextureWidthSecondValue = false;
                int HighlightSpriteTextureWidthFirstValue= 0;
                int HighlightSpriteTextureWidthSecondValue= 0;
                bool setSettingsSpriteTextureHeightFirstValue = false;
                bool setSettingsSpriteTextureHeightSecondValue = false;
                int SettingsSpriteTextureHeightFirstValue= 0;
                int SettingsSpriteTextureHeightSecondValue= 0;
                bool setSettingsSpriteTextureLeftFirstValue = false;
                bool setSettingsSpriteTextureLeftSecondValue = false;
                int SettingsSpriteTextureLeftFirstValue= 0;
                int SettingsSpriteTextureLeftSecondValue= 0;
                bool setSettingsSpriteTextureTopFirstValue = false;
                bool setSettingsSpriteTextureTopSecondValue = false;
                int SettingsSpriteTextureTopFirstValue= 0;
                int SettingsSpriteTextureTopSecondValue= 0;
                bool setSettingsSpriteTextureWidthFirstValue = false;
                bool setSettingsSpriteTextureWidthSecondValue = false;
                int SettingsSpriteTextureWidthFirstValue= 0;
                int SettingsSpriteTextureWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("HighlightSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setHighlightSpriteTextureHeightFirstValue = true;
                        HighlightSpriteTextureHeightFirstValue = 83;
                        setHighlightSpriteTextureLeftFirstValue = true;
                        HighlightSpriteTextureLeftFirstValue = 0;
                        setHighlightSpriteTextureTopFirstValue = true;
                        HighlightSpriteTextureTopFirstValue = 93;
                        setHighlightSpriteTextureWidthFirstValue = true;
                        HighlightSpriteTextureWidthFirstValue = 82;
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SettingsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SettingsSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SettingsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSettingsSpriteTextureHeightFirstValue = true;
                        SettingsSpriteTextureHeightFirstValue = 83;
                        setSettingsSpriteTextureLeftFirstValue = true;
                        SettingsSpriteTextureLeftFirstValue = 82;
                        setSettingsSpriteTextureTopFirstValue = true;
                        SettingsSpriteTextureTopFirstValue = 93;
                        setSettingsSpriteTextureWidthFirstValue = true;
                        SettingsSpriteTextureWidthFirstValue = 82;
                        if (interpolationValue < 1)
                        {
                            this.SettingsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("HighlightSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setHighlightSpriteTextureHeightSecondValue = true;
                        HighlightSpriteTextureHeightSecondValue = 83;
                        setHighlightSpriteTextureLeftSecondValue = true;
                        HighlightSpriteTextureLeftSecondValue = 0;
                        setHighlightSpriteTextureTopSecondValue = true;
                        HighlightSpriteTextureTopSecondValue = 93;
                        setHighlightSpriteTextureWidthSecondValue = true;
                        HighlightSpriteTextureWidthSecondValue = 82;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SettingsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SettingsSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SettingsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSettingsSpriteTextureHeightSecondValue = true;
                        SettingsSpriteTextureHeightSecondValue = 83;
                        setSettingsSpriteTextureLeftSecondValue = true;
                        SettingsSpriteTextureLeftSecondValue = 82;
                        setSettingsSpriteTextureTopSecondValue = true;
                        SettingsSpriteTextureTopSecondValue = 93;
                        setSettingsSpriteTextureWidthSecondValue = true;
                        SettingsSpriteTextureWidthSecondValue = 82;
                        if (interpolationValue >= 1)
                        {
                            this.SettingsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setHighlightSpriteTextureHeightFirstValue && setHighlightSpriteTextureHeightSecondValue)
                {
                    HighlightSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightSpriteTextureHeightFirstValue* (1 - interpolationValue) + HighlightSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setHighlightSpriteTextureLeftFirstValue && setHighlightSpriteTextureLeftSecondValue)
                {
                    HighlightSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightSpriteTextureLeftFirstValue* (1 - interpolationValue) + HighlightSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setHighlightSpriteTextureTopFirstValue && setHighlightSpriteTextureTopSecondValue)
                {
                    HighlightSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightSpriteTextureTopFirstValue* (1 - interpolationValue) + HighlightSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setHighlightSpriteTextureWidthFirstValue && setHighlightSpriteTextureWidthSecondValue)
                {
                    HighlightSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightSpriteTextureWidthFirstValue* (1 - interpolationValue) + HighlightSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setSettingsSpriteTextureHeightFirstValue && setSettingsSpriteTextureHeightSecondValue)
                {
                    SettingsSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SettingsSpriteTextureHeightFirstValue* (1 - interpolationValue) + SettingsSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setSettingsSpriteTextureLeftFirstValue && setSettingsSpriteTextureLeftSecondValue)
                {
                    SettingsSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SettingsSpriteTextureLeftFirstValue* (1 - interpolationValue) + SettingsSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setSettingsSpriteTextureTopFirstValue && setSettingsSpriteTextureTopSecondValue)
                {
                    SettingsSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SettingsSpriteTextureTopFirstValue* (1 - interpolationValue) + SettingsSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setSettingsSpriteTextureWidthFirstValue && setSettingsSpriteTextureWidthSecondValue)
                {
                    SettingsSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SettingsSpriteTextureWidthFirstValue* (1 - interpolationValue) + SettingsSpriteTextureWidthSecondValue * interpolationValue);
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
            public void InterpolateBetween (Highlight firstState, Highlight secondState, float interpolationValue)
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  Highlight.Highlighted:
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.Visible = true;
                        }
                        break;
                    case  Highlight.NotHighlighted:
                        if (interpolationValue < 1)
                        {
                            this.HighlightSprite.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  Highlight.Highlighted:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.Visible = true;
                        }
                        break;
                    case  Highlight.NotHighlighted:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightSprite.Visible = false;
                        }
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentHighlightState = firstState;
                }
                else
                {
                    mCurrentHighlightState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime.Highlight fromState,AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime.Highlight toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Highlight toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Highlight").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentHighlightState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Highlight toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
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
                tweener.Ended += ()=> this.CurrentHighlightState = toState;
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
                            Name = "Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Clips Children",
                            Type = "bool",
                            Value = ClipsChildren
                        }
                        );
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
                            Name = "Visible",
                            Type = "bool",
                            Value = Visible
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = HighlightSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.SourceFile",
                            Type = "string",
                            Value = HighlightSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = HighlightSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Height",
                            Type = "int",
                            Value = HighlightSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Left",
                            Type = "int",
                            Value = HighlightSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Top",
                            Type = "int",
                            Value = HighlightSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Width",
                            Type = "int",
                            Value = HighlightSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = HighlightSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SettingsSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.SourceFile",
                            Type = "string",
                            Value = SettingsSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SettingsSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Texture Height",
                            Type = "int",
                            Value = SettingsSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Texture Left",
                            Type = "int",
                            Value = SettingsSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Texture Top",
                            Type = "int",
                            Value = SettingsSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Texture Width",
                            Type = "int",
                            Value = SettingsSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SettingsSprite.WidthUnits
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
                            Name = "Clips Children",
                            Type = "bool",
                            Value = ClipsChildren
                        }
                        );
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
                            Name = "Visible",
                            Type = "bool",
                            Value = Visible
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = HighlightSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.SourceFile",
                            Type = "string",
                            Value = HighlightSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = HighlightSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Height",
                            Type = "int",
                            Value = HighlightSprite.TextureHeight + 83
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Left",
                            Type = "int",
                            Value = HighlightSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Top",
                            Type = "int",
                            Value = HighlightSprite.TextureTop + 93
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Texture Width",
                            Type = "int",
                            Value = HighlightSprite.TextureWidth + 82
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = HighlightSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SettingsSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.SourceFile",
                            Type = "string",
                            Value = SettingsSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SettingsSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Texture Height",
                            Type = "int",
                            Value = SettingsSprite.TextureHeight + 83
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Texture Left",
                            Type = "int",
                            Value = SettingsSprite.TextureLeft + 82
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Texture Top",
                            Type = "int",
                            Value = SettingsSprite.TextureTop + 93
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Texture Width",
                            Type = "int",
                            Value = SettingsSprite.TextureWidth + 82
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SettingsSprite.WidthUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Highlight state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Highlight.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        break;
                    case  Highlight.NotHighlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Highlight state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Highlight.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
                        }
                        );
                        break;
                    case  Highlight.NotHighlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightSprite.Visible",
                            Type = "bool",
                            Value = HighlightSprite.Visible
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
                    else if (category.Name == "Highlight")
                    {
                        if(state.Name == "Highlighted") this.mCurrentHighlightState = Highlight.Highlighted;
                        if(state.Name == "NotHighlighted") this.mCurrentHighlightState = Highlight.NotHighlighted;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime HighlightSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SettingsSprite { get; set; }
            public SettingsButtonRuntime (bool fullInstantiation = true)
            	: base(false)
            {
                this.HasEvents = true;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "specificbuttons/SettingsButton");
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
                HighlightSprite = this.GetGraphicalUiElementByName("HighlightSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                SettingsSprite = this.GetGraphicalUiElementByName("SettingsSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
