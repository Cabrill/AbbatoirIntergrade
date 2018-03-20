    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class LocationTimeAnnouncementRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Displaying
            {
                Start,
                Middle,
                End
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Displaying mCurrentDisplayingState;
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
                            Height = 10f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 50f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = true;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Y = 25f;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("LocationText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            LocationText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            LocationText.Text = "The Place";
                            LocationText.UseCustomFont = true;
                            LocationText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            DateTimeText.Blue = 255;
                            SetProperty("DateTimeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            DateTimeText.FontScale = 0.7f;
                            DateTimeText.Green = 255;
                            DateTimeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            DateTimeText.Red = 0;
                            DateTimeText.Text = "The Date and Time";
                            DateTimeText.UseCustomFont = true;
                            DateTimeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            break;
                    }
                }
            }
            public Displaying CurrentDisplayingState
            {
                get
                {
                    return mCurrentDisplayingState;
                }
                set
                {
                    mCurrentDisplayingState = value;
                    switch(mCurrentDisplayingState)
                    {
                        case  Displaying.Start:
                            Y = 0f;
                            LocationText.Alpha = 0;
                            LocationText.FontScale = 1f;
                            DateTimeText.Alpha = 0;
                            DateTimeText.FontScale = 0.7f;
                            break;
                        case  Displaying.Middle:
                            Y = 25f;
                            LocationText.Alpha = 255;
                            LocationText.FontScale = 1f;
                            DateTimeText.Alpha = 255;
                            DateTimeText.FontScale = 0.7f;
                            break;
                        case  Displaying.End:
                            Y = 35f;
                            LocationText.Alpha = 0;
                            LocationText.FontScale = 1.25f;
                            DateTimeText.Alpha = 0;
                            DateTimeText.FontScale = 0.875f;
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
                bool setDateTimeTextBlueFirstValue = false;
                bool setDateTimeTextBlueSecondValue = false;
                int DateTimeTextBlueFirstValue= 0;
                int DateTimeTextBlueSecondValue= 0;
                bool setDateTimeTextFontScaleFirstValue = false;
                bool setDateTimeTextFontScaleSecondValue = false;
                float DateTimeTextFontScaleFirstValue= 0;
                float DateTimeTextFontScaleSecondValue= 0;
                bool setDateTimeTextGreenFirstValue = false;
                bool setDateTimeTextGreenSecondValue = false;
                int DateTimeTextGreenFirstValue= 0;
                int DateTimeTextGreenSecondValue= 0;
                bool setDateTimeTextRedFirstValue = false;
                bool setDateTimeTextRedSecondValue = false;
                int DateTimeTextRedFirstValue= 0;
                int DateTimeTextRedSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setDateTimeTextBlueFirstValue = true;
                        DateTimeTextBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("DateTimeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setDateTimeTextFontScaleFirstValue = true;
                        DateTimeTextFontScaleFirstValue = 0.7f;
                        setDateTimeTextGreenFirstValue = true;
                        DateTimeTextGreenFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.DateTimeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setDateTimeTextRedFirstValue = true;
                        DateTimeTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.DateTimeText.Text = "The Date and Time";
                        }
                        if (interpolationValue < 1)
                        {
                            this.DateTimeText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DateTimeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("LocationText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.LocationText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LocationText.Text = "The Place";
                        }
                        if (interpolationValue < 1)
                        {
                            this.LocationText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LocationText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setYFirstValue = true;
                        YFirstValue = 25f;
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                        setDateTimeTextBlueSecondValue = true;
                        DateTimeTextBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("DateTimeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setDateTimeTextFontScaleSecondValue = true;
                        DateTimeTextFontScaleSecondValue = 0.7f;
                        setDateTimeTextGreenSecondValue = true;
                        DateTimeTextGreenSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.DateTimeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setDateTimeTextRedSecondValue = true;
                        DateTimeTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.DateTimeText.Text = "The Date and Time";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DateTimeText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DateTimeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("LocationText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LocationText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LocationText.Text = "The Place";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LocationText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LocationText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setYSecondValue = true;
                        YSecondValue = 25f;
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        break;
                }
                if (setDateTimeTextBlueFirstValue && setDateTimeTextBlueSecondValue)
                {
                    DateTimeText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(DateTimeTextBlueFirstValue* (1 - interpolationValue) + DateTimeTextBlueSecondValue * interpolationValue);
                }
                if (setDateTimeTextFontScaleFirstValue && setDateTimeTextFontScaleSecondValue)
                {
                    DateTimeText.FontScale = DateTimeTextFontScaleFirstValue * (1 - interpolationValue) + DateTimeTextFontScaleSecondValue * interpolationValue;
                }
                if (setDateTimeTextGreenFirstValue && setDateTimeTextGreenSecondValue)
                {
                    DateTimeText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(DateTimeTextGreenFirstValue* (1 - interpolationValue) + DateTimeTextGreenSecondValue * interpolationValue);
                }
                if (setDateTimeTextRedFirstValue && setDateTimeTextRedSecondValue)
                {
                    DateTimeText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(DateTimeTextRedFirstValue* (1 - interpolationValue) + DateTimeTextRedSecondValue * interpolationValue);
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setYFirstValue && setYSecondValue)
                {
                    Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
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
            public void InterpolateBetween (Displaying firstState, Displaying secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setDateTimeTextAlphaFirstValue = false;
                bool setDateTimeTextAlphaSecondValue = false;
                int DateTimeTextAlphaFirstValue= 0;
                int DateTimeTextAlphaSecondValue= 0;
                bool setDateTimeTextFontScaleFirstValue = false;
                bool setDateTimeTextFontScaleSecondValue = false;
                float DateTimeTextFontScaleFirstValue= 0;
                float DateTimeTextFontScaleSecondValue= 0;
                bool setLocationTextAlphaFirstValue = false;
                bool setLocationTextAlphaSecondValue = false;
                int LocationTextAlphaFirstValue= 0;
                int LocationTextAlphaSecondValue= 0;
                bool setLocationTextFontScaleFirstValue = false;
                bool setLocationTextFontScaleSecondValue = false;
                float LocationTextFontScaleFirstValue= 0;
                float LocationTextFontScaleSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  Displaying.Start:
                        setDateTimeTextAlphaFirstValue = true;
                        DateTimeTextAlphaFirstValue = 0;
                        setDateTimeTextFontScaleFirstValue = true;
                        DateTimeTextFontScaleFirstValue = 0.7f;
                        setLocationTextAlphaFirstValue = true;
                        LocationTextAlphaFirstValue = 0;
                        setLocationTextFontScaleFirstValue = true;
                        LocationTextFontScaleFirstValue = 1f;
                        setYFirstValue = true;
                        YFirstValue = 0f;
                        break;
                    case  Displaying.Middle:
                        setDateTimeTextAlphaFirstValue = true;
                        DateTimeTextAlphaFirstValue = 255;
                        setDateTimeTextFontScaleFirstValue = true;
                        DateTimeTextFontScaleFirstValue = 0.7f;
                        setLocationTextAlphaFirstValue = true;
                        LocationTextAlphaFirstValue = 255;
                        setLocationTextFontScaleFirstValue = true;
                        LocationTextFontScaleFirstValue = 1f;
                        setYFirstValue = true;
                        YFirstValue = 25f;
                        break;
                    case  Displaying.End:
                        setDateTimeTextAlphaFirstValue = true;
                        DateTimeTextAlphaFirstValue = 0;
                        setDateTimeTextFontScaleFirstValue = true;
                        DateTimeTextFontScaleFirstValue = 0.875f;
                        setLocationTextAlphaFirstValue = true;
                        LocationTextAlphaFirstValue = 0;
                        setLocationTextFontScaleFirstValue = true;
                        LocationTextFontScaleFirstValue = 1.25f;
                        setYFirstValue = true;
                        YFirstValue = 35f;
                        break;
                }
                switch(secondState)
                {
                    case  Displaying.Start:
                        setDateTimeTextAlphaSecondValue = true;
                        DateTimeTextAlphaSecondValue = 0;
                        setDateTimeTextFontScaleSecondValue = true;
                        DateTimeTextFontScaleSecondValue = 0.7f;
                        setLocationTextAlphaSecondValue = true;
                        LocationTextAlphaSecondValue = 0;
                        setLocationTextFontScaleSecondValue = true;
                        LocationTextFontScaleSecondValue = 1f;
                        setYSecondValue = true;
                        YSecondValue = 0f;
                        break;
                    case  Displaying.Middle:
                        setDateTimeTextAlphaSecondValue = true;
                        DateTimeTextAlphaSecondValue = 255;
                        setDateTimeTextFontScaleSecondValue = true;
                        DateTimeTextFontScaleSecondValue = 0.7f;
                        setLocationTextAlphaSecondValue = true;
                        LocationTextAlphaSecondValue = 255;
                        setLocationTextFontScaleSecondValue = true;
                        LocationTextFontScaleSecondValue = 1f;
                        setYSecondValue = true;
                        YSecondValue = 25f;
                        break;
                    case  Displaying.End:
                        setDateTimeTextAlphaSecondValue = true;
                        DateTimeTextAlphaSecondValue = 0;
                        setDateTimeTextFontScaleSecondValue = true;
                        DateTimeTextFontScaleSecondValue = 0.875f;
                        setLocationTextAlphaSecondValue = true;
                        LocationTextAlphaSecondValue = 0;
                        setLocationTextFontScaleSecondValue = true;
                        LocationTextFontScaleSecondValue = 1.25f;
                        setYSecondValue = true;
                        YSecondValue = 35f;
                        break;
                }
                if (setDateTimeTextAlphaFirstValue && setDateTimeTextAlphaSecondValue)
                {
                    DateTimeText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(DateTimeTextAlphaFirstValue* (1 - interpolationValue) + DateTimeTextAlphaSecondValue * interpolationValue);
                }
                if (setDateTimeTextFontScaleFirstValue && setDateTimeTextFontScaleSecondValue)
                {
                    DateTimeText.FontScale = DateTimeTextFontScaleFirstValue * (1 - interpolationValue) + DateTimeTextFontScaleSecondValue * interpolationValue;
                }
                if (setLocationTextAlphaFirstValue && setLocationTextAlphaSecondValue)
                {
                    LocationText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(LocationTextAlphaFirstValue* (1 - interpolationValue) + LocationTextAlphaSecondValue * interpolationValue);
                }
                if (setLocationTextFontScaleFirstValue && setLocationTextFontScaleSecondValue)
                {
                    LocationText.FontScale = LocationTextFontScaleFirstValue * (1 - interpolationValue) + LocationTextFontScaleSecondValue * interpolationValue;
                }
                if (setYFirstValue && setYSecondValue)
                {
                    Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentDisplayingState = firstState;
                }
                else
                {
                    mCurrentDisplayingState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime.Displaying fromState,AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime.Displaying toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Displaying toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Displaying").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentDisplayingState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Displaying toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentDisplayingState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> AppearAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentDisplayingState = Displaying.Start);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Displaying.Middle, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quartic, FlatRedBall.Glue.StateInterpolation.Easing.Out, AppearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Displaying.End, 4, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.In, AppearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> AppearAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Displaying/Start").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Displaying/Middle").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Displaying.Middle);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quartic, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Displaying/Middle").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Displaying/End").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Displaying.End);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 4, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.In);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation appearAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation AppearAnimation
            {
                get
                {
                    if (appearAnimation == null)
                    {
                        appearAnimation = new FlatRedBall.Gum.Animation.GumAnimation(5, AppearAnimationInstructions);
                    }
                    return appearAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation appearAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation AppearAnimationRelative
            {
                get
                {
                    if (appearAnimationRelative == null)
                    {
                        appearAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(5, AppearAnimationRelativeInstructions);
                    }
                    return appearAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                AppearAnimation.Stop();
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
                            Name = "Y",
                            Type = "float",
                            Value = Y
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
                            Name = "LocationText.CustomFontFile",
                            Type = "string",
                            Value = LocationText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = LocationText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Text",
                            Type = "string",
                            Value = LocationText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.UseCustomFont",
                            Type = "bool",
                            Value = LocationText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Width Units",
                            Type = "DimensionUnitType",
                            Value = LocationText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Blue",
                            Type = "int",
                            Value = DateTimeText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.CustomFontFile",
                            Type = "string",
                            Value = DateTimeText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Font Scale",
                            Type = "float",
                            Value = DateTimeText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Green",
                            Type = "int",
                            Value = DateTimeText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = DateTimeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Red",
                            Type = "int",
                            Value = DateTimeText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Text",
                            Type = "string",
                            Value = DateTimeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.UseCustomFont",
                            Type = "bool",
                            Value = DateTimeText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = DateTimeText.WidthUnits
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
                            Name = "Height",
                            Type = "float",
                            Value = Height + 10f
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
                            Value = Width + 50f
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
                            Name = "Y",
                            Type = "float",
                            Value = Y + 25f
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
                            Name = "LocationText.CustomFontFile",
                            Type = "string",
                            Value = LocationText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = LocationText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Text",
                            Type = "string",
                            Value = LocationText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.UseCustomFont",
                            Type = "bool",
                            Value = LocationText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Width Units",
                            Type = "DimensionUnitType",
                            Value = LocationText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Blue",
                            Type = "int",
                            Value = DateTimeText.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.CustomFontFile",
                            Type = "string",
                            Value = DateTimeText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Font Scale",
                            Type = "float",
                            Value = DateTimeText.FontScale + 0.7f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Green",
                            Type = "int",
                            Value = DateTimeText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = DateTimeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Red",
                            Type = "int",
                            Value = DateTimeText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Text",
                            Type = "string",
                            Value = DateTimeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.UseCustomFont",
                            Type = "bool",
                            Value = DateTimeText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = DateTimeText.WidthUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Displaying state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Displaying.Start:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Alpha",
                            Type = "int",
                            Value = LocationText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Font Scale",
                            Type = "float",
                            Value = LocationText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Alpha",
                            Type = "int",
                            Value = DateTimeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Font Scale",
                            Type = "float",
                            Value = DateTimeText.FontScale
                        }
                        );
                        break;
                    case  Displaying.Middle:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Alpha",
                            Type = "int",
                            Value = LocationText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Font Scale",
                            Type = "float",
                            Value = LocationText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Alpha",
                            Type = "int",
                            Value = DateTimeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Font Scale",
                            Type = "float",
                            Value = DateTimeText.FontScale
                        }
                        );
                        break;
                    case  Displaying.End:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Alpha",
                            Type = "int",
                            Value = LocationText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Font Scale",
                            Type = "float",
                            Value = LocationText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Alpha",
                            Type = "int",
                            Value = DateTimeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Font Scale",
                            Type = "float",
                            Value = DateTimeText.FontScale
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Displaying state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Displaying.Start:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Alpha",
                            Type = "int",
                            Value = LocationText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Font Scale",
                            Type = "float",
                            Value = LocationText.FontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Alpha",
                            Type = "int",
                            Value = DateTimeText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Font Scale",
                            Type = "float",
                            Value = DateTimeText.FontScale + 0.7f
                        }
                        );
                        break;
                    case  Displaying.Middle:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Alpha",
                            Type = "int",
                            Value = LocationText.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Font Scale",
                            Type = "float",
                            Value = LocationText.FontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Alpha",
                            Type = "int",
                            Value = DateTimeText.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Font Scale",
                            Type = "float",
                            Value = DateTimeText.FontScale + 0.7f
                        }
                        );
                        break;
                    case  Displaying.End:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + 35f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Alpha",
                            Type = "int",
                            Value = LocationText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationText.Font Scale",
                            Type = "float",
                            Value = LocationText.FontScale + 1.25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Alpha",
                            Type = "int",
                            Value = DateTimeText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DateTimeText.Font Scale",
                            Type = "float",
                            Value = DateTimeText.FontScale + 0.875f
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
                    else if (category.Name == "Displaying")
                    {
                        if(state.Name == "Start") this.mCurrentDisplayingState = Displaying.Start;
                        if(state.Name == "Middle") this.mCurrentDisplayingState = Displaying.Middle;
                        if(state.Name == "End") this.mCurrentDisplayingState = Displaying.End;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime LocationText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime DateTimeText { get; set; }
            public LocationTimeAnnouncementRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/LocationTimeAnnouncement");
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
                LocationText = this.GetGraphicalUiElementByName("LocationText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                DateTimeText = this.GetGraphicalUiElementByName("DateTimeText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
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
