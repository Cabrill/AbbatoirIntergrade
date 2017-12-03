    using System.Linq;
    namespace GBC2017.GumRuntimes
    {
        public partial class VictoryDisplayRuntime : GBC2017.GumRuntimes.ContainerRuntime
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
                            ClipsChildren = false;
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RetryButton.ButtonText = "Retry";
                            RetryButton.Height = 10f;
                            RetryButton.Width = 20f;
                            RetryButton.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            RetryButton.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            RetryButton.Y = -50f;
                            RetryButton.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            RetryButton.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            SetProperty("VictorySprite.SourceFile", "../Screens/GameScreen/WinLose.png");
                            VictorySprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            VictorySprite.TextureHeight = 775;
                            VictorySprite.TextureLeft = 0;
                            VictorySprite.TextureTop = 0;
                            VictorySprite.TextureWidth = 990;
                            VictorySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            VictorySprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            VictorySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            VictorySprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Visible = true;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
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
                bool setRetryButtonHeightFirstValue = false;
                bool setRetryButtonHeightSecondValue = false;
                float RetryButtonHeightFirstValue= 0;
                float RetryButtonHeightSecondValue= 0;
                bool setRetryButtonWidthFirstValue = false;
                bool setRetryButtonWidthSecondValue = false;
                float RetryButtonWidthFirstValue= 0;
                float RetryButtonWidthSecondValue= 0;
                bool setRetryButtonYFirstValue = false;
                bool setRetryButtonYSecondValue = false;
                float RetryButtonYFirstValue= 0;
                float RetryButtonYSecondValue= 0;
                bool setVictorySpriteTextureHeightFirstValue = false;
                bool setVictorySpriteTextureHeightSecondValue = false;
                int VictorySpriteTextureHeightFirstValue= 0;
                int VictorySpriteTextureHeightSecondValue= 0;
                bool setVictorySpriteTextureLeftFirstValue = false;
                bool setVictorySpriteTextureLeftSecondValue = false;
                int VictorySpriteTextureLeftFirstValue= 0;
                int VictorySpriteTextureLeftSecondValue= 0;
                bool setVictorySpriteTextureTopFirstValue = false;
                bool setVictorySpriteTextureTopSecondValue = false;
                int VictorySpriteTextureTopFirstValue= 0;
                int VictorySpriteTextureTopSecondValue= 0;
                bool setVictorySpriteTextureWidthFirstValue = false;
                bool setVictorySpriteTextureWidthSecondValue = false;
                int VictorySpriteTextureWidthFirstValue= 0;
                int VictorySpriteTextureWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
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
                            this.RetryButton.ButtonText = "Retry";
                        }
                        setRetryButtonHeightFirstValue = true;
                        RetryButtonHeightFirstValue = 10f;
                        setRetryButtonWidthFirstValue = true;
                        RetryButtonWidthFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.RetryButton.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RetryButton.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRetryButtonYFirstValue = true;
                        RetryButtonYFirstValue = -50f;
                        if (interpolationValue < 1)
                        {
                            this.RetryButton.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RetryButton.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("VictorySprite.SourceFile", "../Screens/GameScreen/WinLose.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.VictorySprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setVictorySpriteTextureHeightFirstValue = true;
                        VictorySpriteTextureHeightFirstValue = 775;
                        setVictorySpriteTextureLeftFirstValue = true;
                        VictorySpriteTextureLeftFirstValue = 0;
                        setVictorySpriteTextureTopFirstValue = true;
                        VictorySpriteTextureTopFirstValue = 0;
                        setVictorySpriteTextureWidthFirstValue = true;
                        VictorySpriteTextureWidthFirstValue = 990;
                        if (interpolationValue < 1)
                        {
                            this.VictorySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VictorySprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VictorySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VictorySprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                            this.RetryButton.ButtonText = "Retry";
                        }
                        setRetryButtonHeightSecondValue = true;
                        RetryButtonHeightSecondValue = 10f;
                        setRetryButtonWidthSecondValue = true;
                        RetryButtonWidthSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.RetryButton.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RetryButton.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRetryButtonYSecondValue = true;
                        RetryButtonYSecondValue = -50f;
                        if (interpolationValue >= 1)
                        {
                            this.RetryButton.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RetryButton.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("VictorySprite.SourceFile", "../Screens/GameScreen/WinLose.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VictorySprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setVictorySpriteTextureHeightSecondValue = true;
                        VictorySpriteTextureHeightSecondValue = 775;
                        setVictorySpriteTextureLeftSecondValue = true;
                        VictorySpriteTextureLeftSecondValue = 0;
                        setVictorySpriteTextureTopSecondValue = true;
                        VictorySpriteTextureTopSecondValue = 0;
                        setVictorySpriteTextureWidthSecondValue = true;
                        VictorySpriteTextureWidthSecondValue = 990;
                        if (interpolationValue >= 1)
                        {
                            this.VictorySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VictorySprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VictorySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VictorySprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                if (setRetryButtonHeightFirstValue && setRetryButtonHeightSecondValue)
                {
                    RetryButton.Height = RetryButtonHeightFirstValue * (1 - interpolationValue) + RetryButtonHeightSecondValue * interpolationValue;
                }
                if (setRetryButtonWidthFirstValue && setRetryButtonWidthSecondValue)
                {
                    RetryButton.Width = RetryButtonWidthFirstValue * (1 - interpolationValue) + RetryButtonWidthSecondValue * interpolationValue;
                }
                if (setRetryButtonYFirstValue && setRetryButtonYSecondValue)
                {
                    RetryButton.Y = RetryButtonYFirstValue * (1 - interpolationValue) + RetryButtonYSecondValue * interpolationValue;
                }
                if (setVictorySpriteTextureHeightFirstValue && setVictorySpriteTextureHeightSecondValue)
                {
                    VictorySprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(VictorySpriteTextureHeightFirstValue* (1 - interpolationValue) + VictorySpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setVictorySpriteTextureLeftFirstValue && setVictorySpriteTextureLeftSecondValue)
                {
                    VictorySprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(VictorySpriteTextureLeftFirstValue* (1 - interpolationValue) + VictorySpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setVictorySpriteTextureTopFirstValue && setVictorySpriteTextureTopSecondValue)
                {
                    VictorySprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(VictorySpriteTextureTopFirstValue* (1 - interpolationValue) + VictorySpriteTextureTopSecondValue * interpolationValue);
                }
                if (setVictorySpriteTextureWidthFirstValue && setVictorySpriteTextureWidthSecondValue)
                {
                    VictorySprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(VictorySpriteTextureWidthFirstValue* (1 - interpolationValue) + VictorySpriteTextureWidthSecondValue * interpolationValue);
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (GBC2017.GumRuntimes.VictoryDisplayRuntime.VariableState fromState,GBC2017.GumRuntimes.VictoryDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
                RetryButton.StopAnimations();
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
                            Name = "RetryButton.ButtonText",
                            Type = "string",
                            Value = RetryButton.ButtonText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.Height",
                            Type = "float",
                            Value = RetryButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.Width",
                            Type = "float",
                            Value = RetryButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.X Origin",
                            Type = "HorizontalAlignment",
                            Value = RetryButton.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.X Units",
                            Type = "PositionUnitType",
                            Value = RetryButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.Y",
                            Type = "float",
                            Value = RetryButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.Y Origin",
                            Type = "VerticalAlignment",
                            Value = RetryButton.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.Y Units",
                            Type = "PositionUnitType",
                            Value = RetryButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.SourceFile",
                            Type = "string",
                            Value = VictorySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Texture Address",
                            Type = "TextureAddress",
                            Value = VictorySprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Texture Height",
                            Type = "int",
                            Value = VictorySprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Texture Left",
                            Type = "int",
                            Value = VictorySprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Texture Top",
                            Type = "int",
                            Value = VictorySprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Texture Width",
                            Type = "int",
                            Value = VictorySprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VictorySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.X Units",
                            Type = "PositionUnitType",
                            Value = VictorySprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = VictorySprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Y Units",
                            Type = "PositionUnitType",
                            Value = VictorySprite.YUnits
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
                            Name = "RetryButton.ButtonText",
                            Type = "string",
                            Value = RetryButton.ButtonText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.Height",
                            Type = "float",
                            Value = RetryButton.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.Width",
                            Type = "float",
                            Value = RetryButton.Width + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.X Origin",
                            Type = "HorizontalAlignment",
                            Value = RetryButton.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.X Units",
                            Type = "PositionUnitType",
                            Value = RetryButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.Y",
                            Type = "float",
                            Value = RetryButton.Y + -50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.Y Origin",
                            Type = "VerticalAlignment",
                            Value = RetryButton.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetryButton.Y Units",
                            Type = "PositionUnitType",
                            Value = RetryButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.SourceFile",
                            Type = "string",
                            Value = VictorySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Texture Address",
                            Type = "TextureAddress",
                            Value = VictorySprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Texture Height",
                            Type = "int",
                            Value = VictorySprite.TextureHeight + 775
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Texture Left",
                            Type = "int",
                            Value = VictorySprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Texture Top",
                            Type = "int",
                            Value = VictorySprite.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Texture Width",
                            Type = "int",
                            Value = VictorySprite.TextureWidth + 990
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VictorySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.X Units",
                            Type = "PositionUnitType",
                            Value = VictorySprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = VictorySprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VictorySprite.Y Units",
                            Type = "PositionUnitType",
                            Value = VictorySprite.YUnits
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
            private GBC2017.GumRuntimes.SpriteRuntime VictorySprite { get; set; }
            private GBC2017.GumRuntimes.ButtonRuntime RetryButton { get; set; }
            public event FlatRedBall.Gui.WindowEvent RetryButtonClick;
            public VictoryDisplayRuntime (bool fullInstantiation = true, bool callAssignReferences = true)
            	: base(fullInstantiation)
            {
                this.HasEvents = true;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "VictoryDisplay");
                    this.ElementSave = elementSave;
                    string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                    FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                    GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                    FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
                    if (callAssignReferences)
                    {
                        this.AssignReferences();
                    }
                }
            }
            public override void AssignReferences ()
            {
                base.AssignReferences();
                VictorySprite = this.GetGraphicalUiElementByName("VictorySprite") as GBC2017.GumRuntimes.SpriteRuntime;
                RetryButton = this.GetGraphicalUiElementByName("RetryButton") as GBC2017.GumRuntimes.ButtonRuntime;
                RetryButton.AssignReferences();
                RetryButton.Click += (unused) => RetryButtonClick?.Invoke(this);
                CallCustomInitialize();
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
