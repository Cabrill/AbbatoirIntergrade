    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes.infodisplays
    {
        public partial class CurrentMusicDisplayRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Appearing
            {
                Hidden,
                PartiallyDisplayed,
                Displayed
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Appearing? mCurrentAppearingState;
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            Height = 70f;
                            Width = 0f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            WrapsChildren = true;
                            X = -10f;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            Y = 10f;
                            ArtistName.Blue = 255;
                            SetProperty("ArtistName.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            ArtistName.Green = 255;
                            ArtistName.Height = 0f;
                            ArtistName.Red = 0;
                            ArtistName.Text = "Artist Name";
                            ArtistName.UseCustomFont = true;
                            ArtistName.Width = 0f;
                            ArtistName.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            SetProperty("HyphenText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            HyphenText.Height = 0f;
                            HyphenText.Text = " - ";
                            HyphenText.UseCustomFont = true;
                            HyphenText.Width = 0f;
                            HyphenText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TrackName.Blue = 212;
                            SetProperty("TrackName.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            TrackName.Green = 255;
                            TrackName.Height = 0f;
                            TrackName.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TrackName.Red = 127;
                            TrackName.Text = "Track Title In Full";
                            TrackName.UseCustomFont = true;
                            TrackName.Width = 0f;
                            TrackName.X = 0f;
                            TrackName.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            break;
                    }
                }
            }
            public Appearing? CurrentAppearingState
            {
                get
                {
                    return mCurrentAppearingState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentAppearingState = value;
                        switch(mCurrentAppearingState)
                        {
                            case  Appearing.Hidden:
                                ArtistName.Alpha = 0;
                                HyphenText.Alpha = 0;
                                TrackName.Alpha = 0;
                                break;
                            case  Appearing.PartiallyDisplayed:
                                ArtistName.Alpha = 255;
                                HyphenText.Alpha = 0;
                                TrackName.Alpha = 0;
                                break;
                            case  Appearing.Displayed:
                                ArtistName.Alpha = 255;
                                HyphenText.Alpha = 255;
                                TrackName.Alpha = 255;
                                break;
                        }
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
                bool setArtistNameBlueFirstValue = false;
                bool setArtistNameBlueSecondValue = false;
                int ArtistNameBlueFirstValue= 0;
                int ArtistNameBlueSecondValue= 0;
                bool setArtistNameGreenFirstValue = false;
                bool setArtistNameGreenSecondValue = false;
                int ArtistNameGreenFirstValue= 0;
                int ArtistNameGreenSecondValue= 0;
                bool setArtistNameHeightFirstValue = false;
                bool setArtistNameHeightSecondValue = false;
                float ArtistNameHeightFirstValue= 0;
                float ArtistNameHeightSecondValue= 0;
                bool setArtistNameRedFirstValue = false;
                bool setArtistNameRedSecondValue = false;
                int ArtistNameRedFirstValue= 0;
                int ArtistNameRedSecondValue= 0;
                bool setArtistNameWidthFirstValue = false;
                bool setArtistNameWidthSecondValue = false;
                float ArtistNameWidthFirstValue= 0;
                float ArtistNameWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setHyphenTextHeightFirstValue = false;
                bool setHyphenTextHeightSecondValue = false;
                float HyphenTextHeightFirstValue= 0;
                float HyphenTextHeightSecondValue= 0;
                bool setHyphenTextWidthFirstValue = false;
                bool setHyphenTextWidthSecondValue = false;
                float HyphenTextWidthFirstValue= 0;
                float HyphenTextWidthSecondValue= 0;
                bool setTrackNameBlueFirstValue = false;
                bool setTrackNameBlueSecondValue = false;
                int TrackNameBlueFirstValue= 0;
                int TrackNameBlueSecondValue= 0;
                bool setTrackNameGreenFirstValue = false;
                bool setTrackNameGreenSecondValue = false;
                int TrackNameGreenFirstValue= 0;
                int TrackNameGreenSecondValue= 0;
                bool setTrackNameHeightFirstValue = false;
                bool setTrackNameHeightSecondValue = false;
                float TrackNameHeightFirstValue= 0;
                float TrackNameHeightSecondValue= 0;
                bool setTrackNameRedFirstValue = false;
                bool setTrackNameRedSecondValue = false;
                int TrackNameRedFirstValue= 0;
                int TrackNameRedSecondValue= 0;
                bool setTrackNameWidthFirstValue = false;
                bool setTrackNameWidthSecondValue = false;
                float TrackNameWidthFirstValue= 0;
                float TrackNameWidthSecondValue= 0;
                bool setTrackNameXFirstValue = false;
                bool setTrackNameXSecondValue = false;
                float TrackNameXFirstValue= 0;
                float TrackNameXSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setXFirstValue = false;
                bool setXSecondValue = false;
                float XFirstValue= 0;
                float XSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setArtistNameBlueFirstValue = true;
                        ArtistNameBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("ArtistName.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setArtistNameGreenFirstValue = true;
                        ArtistNameGreenFirstValue = 255;
                        setArtistNameHeightFirstValue = true;
                        ArtistNameHeightFirstValue = 0f;
                        setArtistNameRedFirstValue = true;
                        ArtistNameRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ArtistName.Text = "Artist Name";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ArtistName.UseCustomFont = true;
                        }
                        setArtistNameWidthFirstValue = true;
                        ArtistNameWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ArtistName.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 70f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("HyphenText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setHyphenTextHeightFirstValue = true;
                        HyphenTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HyphenText.Text = " - ";
                        }
                        if (interpolationValue < 1)
                        {
                            this.HyphenText.UseCustomFont = true;
                        }
                        setHyphenTextWidthFirstValue = true;
                        HyphenTextWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HyphenText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTrackNameBlueFirstValue = true;
                        TrackNameBlueFirstValue = 212;
                        if (interpolationValue < 1)
                        {
                            SetProperty("TrackName.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTrackNameGreenFirstValue = true;
                        TrackNameGreenFirstValue = 255;
                        setTrackNameHeightFirstValue = true;
                        TrackNameHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TrackName.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        setTrackNameRedFirstValue = true;
                        TrackNameRedFirstValue = 127;
                        if (interpolationValue < 1)
                        {
                            this.TrackName.Text = "Track Title In Full";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TrackName.UseCustomFont = true;
                        }
                        setTrackNameWidthFirstValue = true;
                        TrackNameWidthFirstValue = 0f;
                        setTrackNameXFirstValue = true;
                        TrackNameXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TrackName.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = true;
                        }
                        setXFirstValue = true;
                        XFirstValue = -10f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setYFirstValue = true;
                        YFirstValue = 10f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setArtistNameBlueSecondValue = true;
                        ArtistNameBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ArtistName.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setArtistNameGreenSecondValue = true;
                        ArtistNameGreenSecondValue = 255;
                        setArtistNameHeightSecondValue = true;
                        ArtistNameHeightSecondValue = 0f;
                        setArtistNameRedSecondValue = true;
                        ArtistNameRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ArtistName.Text = "Artist Name";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ArtistName.UseCustomFont = true;
                        }
                        setArtistNameWidthSecondValue = true;
                        ArtistNameWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ArtistName.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 70f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("HyphenText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setHyphenTextHeightSecondValue = true;
                        HyphenTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HyphenText.Text = " - ";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HyphenText.UseCustomFont = true;
                        }
                        setHyphenTextWidthSecondValue = true;
                        HyphenTextWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HyphenText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTrackNameBlueSecondValue = true;
                        TrackNameBlueSecondValue = 212;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TrackName.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTrackNameGreenSecondValue = true;
                        TrackNameGreenSecondValue = 255;
                        setTrackNameHeightSecondValue = true;
                        TrackNameHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TrackName.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        setTrackNameRedSecondValue = true;
                        TrackNameRedSecondValue = 127;
                        if (interpolationValue >= 1)
                        {
                            this.TrackName.Text = "Track Title In Full";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TrackName.UseCustomFont = true;
                        }
                        setTrackNameWidthSecondValue = true;
                        TrackNameWidthSecondValue = 0f;
                        setTrackNameXSecondValue = true;
                        TrackNameXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TrackName.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = true;
                        }
                        setXSecondValue = true;
                        XSecondValue = -10f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setYSecondValue = true;
                        YSecondValue = 10f;
                        break;
                }
                if (setArtistNameBlueFirstValue && setArtistNameBlueSecondValue)
                {
                    ArtistName.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ArtistNameBlueFirstValue* (1 - interpolationValue) + ArtistNameBlueSecondValue * interpolationValue);
                }
                if (setArtistNameGreenFirstValue && setArtistNameGreenSecondValue)
                {
                    ArtistName.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ArtistNameGreenFirstValue* (1 - interpolationValue) + ArtistNameGreenSecondValue * interpolationValue);
                }
                if (setArtistNameHeightFirstValue && setArtistNameHeightSecondValue)
                {
                    ArtistName.Height = ArtistNameHeightFirstValue * (1 - interpolationValue) + ArtistNameHeightSecondValue * interpolationValue;
                }
                if (setArtistNameRedFirstValue && setArtistNameRedSecondValue)
                {
                    ArtistName.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ArtistNameRedFirstValue* (1 - interpolationValue) + ArtistNameRedSecondValue * interpolationValue);
                }
                if (setArtistNameWidthFirstValue && setArtistNameWidthSecondValue)
                {
                    ArtistName.Width = ArtistNameWidthFirstValue * (1 - interpolationValue) + ArtistNameWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setHyphenTextHeightFirstValue && setHyphenTextHeightSecondValue)
                {
                    HyphenText.Height = HyphenTextHeightFirstValue * (1 - interpolationValue) + HyphenTextHeightSecondValue * interpolationValue;
                }
                if (setHyphenTextWidthFirstValue && setHyphenTextWidthSecondValue)
                {
                    HyphenText.Width = HyphenTextWidthFirstValue * (1 - interpolationValue) + HyphenTextWidthSecondValue * interpolationValue;
                }
                if (setTrackNameBlueFirstValue && setTrackNameBlueSecondValue)
                {
                    TrackName.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TrackNameBlueFirstValue* (1 - interpolationValue) + TrackNameBlueSecondValue * interpolationValue);
                }
                if (setTrackNameGreenFirstValue && setTrackNameGreenSecondValue)
                {
                    TrackName.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TrackNameGreenFirstValue* (1 - interpolationValue) + TrackNameGreenSecondValue * interpolationValue);
                }
                if (setTrackNameHeightFirstValue && setTrackNameHeightSecondValue)
                {
                    TrackName.Height = TrackNameHeightFirstValue * (1 - interpolationValue) + TrackNameHeightSecondValue * interpolationValue;
                }
                if (setTrackNameRedFirstValue && setTrackNameRedSecondValue)
                {
                    TrackName.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TrackNameRedFirstValue* (1 - interpolationValue) + TrackNameRedSecondValue * interpolationValue);
                }
                if (setTrackNameWidthFirstValue && setTrackNameWidthSecondValue)
                {
                    TrackName.Width = TrackNameWidthFirstValue * (1 - interpolationValue) + TrackNameWidthSecondValue * interpolationValue;
                }
                if (setTrackNameXFirstValue && setTrackNameXSecondValue)
                {
                    TrackName.X = TrackNameXFirstValue * (1 - interpolationValue) + TrackNameXSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setXFirstValue && setXSecondValue)
                {
                    X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
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
            public void InterpolateBetween (Appearing firstState, Appearing secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setArtistNameAlphaFirstValue = false;
                bool setArtistNameAlphaSecondValue = false;
                int ArtistNameAlphaFirstValue= 0;
                int ArtistNameAlphaSecondValue= 0;
                bool setHyphenTextAlphaFirstValue = false;
                bool setHyphenTextAlphaSecondValue = false;
                int HyphenTextAlphaFirstValue= 0;
                int HyphenTextAlphaSecondValue= 0;
                bool setTrackNameAlphaFirstValue = false;
                bool setTrackNameAlphaSecondValue = false;
                int TrackNameAlphaFirstValue= 0;
                int TrackNameAlphaSecondValue= 0;
                switch(firstState)
                {
                    case  Appearing.Hidden:
                        setArtistNameAlphaFirstValue = true;
                        ArtistNameAlphaFirstValue = 0;
                        setHyphenTextAlphaFirstValue = true;
                        HyphenTextAlphaFirstValue = 0;
                        setTrackNameAlphaFirstValue = true;
                        TrackNameAlphaFirstValue = 0;
                        break;
                    case  Appearing.PartiallyDisplayed:
                        setArtistNameAlphaFirstValue = true;
                        ArtistNameAlphaFirstValue = 255;
                        setHyphenTextAlphaFirstValue = true;
                        HyphenTextAlphaFirstValue = 0;
                        setTrackNameAlphaFirstValue = true;
                        TrackNameAlphaFirstValue = 0;
                        break;
                    case  Appearing.Displayed:
                        setArtistNameAlphaFirstValue = true;
                        ArtistNameAlphaFirstValue = 255;
                        setHyphenTextAlphaFirstValue = true;
                        HyphenTextAlphaFirstValue = 255;
                        setTrackNameAlphaFirstValue = true;
                        TrackNameAlphaFirstValue = 255;
                        break;
                }
                switch(secondState)
                {
                    case  Appearing.Hidden:
                        setArtistNameAlphaSecondValue = true;
                        ArtistNameAlphaSecondValue = 0;
                        setHyphenTextAlphaSecondValue = true;
                        HyphenTextAlphaSecondValue = 0;
                        setTrackNameAlphaSecondValue = true;
                        TrackNameAlphaSecondValue = 0;
                        break;
                    case  Appearing.PartiallyDisplayed:
                        setArtistNameAlphaSecondValue = true;
                        ArtistNameAlphaSecondValue = 255;
                        setHyphenTextAlphaSecondValue = true;
                        HyphenTextAlphaSecondValue = 0;
                        setTrackNameAlphaSecondValue = true;
                        TrackNameAlphaSecondValue = 0;
                        break;
                    case  Appearing.Displayed:
                        setArtistNameAlphaSecondValue = true;
                        ArtistNameAlphaSecondValue = 255;
                        setHyphenTextAlphaSecondValue = true;
                        HyphenTextAlphaSecondValue = 255;
                        setTrackNameAlphaSecondValue = true;
                        TrackNameAlphaSecondValue = 255;
                        break;
                }
                if (setArtistNameAlphaFirstValue && setArtistNameAlphaSecondValue)
                {
                    ArtistName.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(ArtistNameAlphaFirstValue* (1 - interpolationValue) + ArtistNameAlphaSecondValue * interpolationValue);
                }
                if (setHyphenTextAlphaFirstValue && setHyphenTextAlphaSecondValue)
                {
                    HyphenText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(HyphenTextAlphaFirstValue* (1 - interpolationValue) + HyphenTextAlphaSecondValue * interpolationValue);
                }
                if (setTrackNameAlphaFirstValue && setTrackNameAlphaSecondValue)
                {
                    TrackName.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(TrackNameAlphaFirstValue* (1 - interpolationValue) + TrackNameAlphaSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentAppearingState = firstState;
                }
                else
                {
                    mCurrentAppearingState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.CurrentMusicDisplayRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.CurrentMusicDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.CurrentMusicDisplayRuntime.Appearing fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.CurrentMusicDisplayRuntime.Appearing toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Appearing toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Appearing").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentAppearingState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Appearing toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentAppearingState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> DisplayAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentAppearingState = Appearing.Hidden);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearing.PartiallyDisplayed, 1.5f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Sinusoidal, FlatRedBall.Glue.StateInterpolation.Easing.In, DisplayAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearing.Displayed, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Sinusoidal, FlatRedBall.Glue.StateInterpolation.Easing.InOut, DisplayAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1.5f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearing.Displayed, 1.5f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, DisplayAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 2.5f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearing.Hidden, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quartic, FlatRedBall.Glue.StateInterpolation.Easing.Out, DisplayAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 4;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> DisplayAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearing/Hidden").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearing/PartiallyDisplayed").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearing.PartiallyDisplayed);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1.5f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Sinusoidal, easing: FlatRedBall.Glue.StateInterpolation.Easing.In);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearing/PartiallyDisplayed").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearing/Displayed").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearing.Displayed);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Sinusoidal, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1.5f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearing/Displayed").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearing/Displayed").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearing.Displayed);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1.5f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 2.5f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearing/Displayed").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearing/Hidden").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearing.Hidden);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quartic, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 4;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation displayAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation DisplayAnimation
            {
                get
                {
                    if (displayAnimation == null)
                    {
                        displayAnimation = new FlatRedBall.Gum.Animation.GumAnimation(5, DisplayAnimationInstructions);
                    }
                    return displayAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation displayAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation DisplayAnimationRelative
            {
                get
                {
                    if (displayAnimationRelative == null)
                    {
                        displayAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(5, DisplayAnimationRelativeInstructions);
                    }
                    return displayAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                DisplayAnimation.Stop();
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
                            Name = "X",
                            Type = "float",
                            Value = X
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
                            Name = "ArtistName.Blue",
                            Type = "int",
                            Value = ArtistName.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.CustomFontFile",
                            Type = "string",
                            Value = ArtistName.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Green",
                            Type = "int",
                            Value = ArtistName.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Height",
                            Type = "float",
                            Value = ArtistName.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Red",
                            Type = "int",
                            Value = ArtistName.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Text",
                            Type = "string",
                            Value = ArtistName.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.UseCustomFont",
                            Type = "bool",
                            Value = ArtistName.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Width",
                            Type = "float",
                            Value = ArtistName.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.X Units",
                            Type = "PositionUnitType",
                            Value = ArtistName.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.CustomFontFile",
                            Type = "string",
                            Value = HyphenText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Height",
                            Type = "float",
                            Value = HyphenText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Text",
                            Type = "string",
                            Value = HyphenText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.UseCustomFont",
                            Type = "bool",
                            Value = HyphenText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Width",
                            Type = "float",
                            Value = HyphenText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.X Units",
                            Type = "PositionUnitType",
                            Value = HyphenText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Blue",
                            Type = "int",
                            Value = TrackName.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.CustomFontFile",
                            Type = "string",
                            Value = TrackName.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Green",
                            Type = "int",
                            Value = TrackName.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Height",
                            Type = "float",
                            Value = TrackName.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TrackName.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Red",
                            Type = "int",
                            Value = TrackName.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Text",
                            Type = "string",
                            Value = TrackName.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.UseCustomFont",
                            Type = "bool",
                            Value = TrackName.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Width",
                            Type = "float",
                            Value = TrackName.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.X",
                            Type = "float",
                            Value = TrackName.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.X Units",
                            Type = "PositionUnitType",
                            Value = TrackName.XUnits
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
                            Value = Height + 70f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 0f
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
                            Name = "X",
                            Type = "float",
                            Value = X + -10f
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
                            Value = Y + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Blue",
                            Type = "int",
                            Value = ArtistName.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.CustomFontFile",
                            Type = "string",
                            Value = ArtistName.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Green",
                            Type = "int",
                            Value = ArtistName.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Height",
                            Type = "float",
                            Value = ArtistName.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Red",
                            Type = "int",
                            Value = ArtistName.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Text",
                            Type = "string",
                            Value = ArtistName.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.UseCustomFont",
                            Type = "bool",
                            Value = ArtistName.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Width",
                            Type = "float",
                            Value = ArtistName.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.X Units",
                            Type = "PositionUnitType",
                            Value = ArtistName.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.CustomFontFile",
                            Type = "string",
                            Value = HyphenText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Height",
                            Type = "float",
                            Value = HyphenText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Text",
                            Type = "string",
                            Value = HyphenText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.UseCustomFont",
                            Type = "bool",
                            Value = HyphenText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Width",
                            Type = "float",
                            Value = HyphenText.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.X Units",
                            Type = "PositionUnitType",
                            Value = HyphenText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Blue",
                            Type = "int",
                            Value = TrackName.Blue + 212
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.CustomFontFile",
                            Type = "string",
                            Value = TrackName.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Green",
                            Type = "int",
                            Value = TrackName.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Height",
                            Type = "float",
                            Value = TrackName.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TrackName.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Red",
                            Type = "int",
                            Value = TrackName.Red + 127
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Text",
                            Type = "string",
                            Value = TrackName.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.UseCustomFont",
                            Type = "bool",
                            Value = TrackName.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Width",
                            Type = "float",
                            Value = TrackName.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.X",
                            Type = "float",
                            Value = TrackName.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.X Units",
                            Type = "PositionUnitType",
                            Value = TrackName.XUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Appearing state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Appearing.Hidden:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Alpha",
                            Type = "int",
                            Value = ArtistName.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Alpha",
                            Type = "int",
                            Value = HyphenText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Alpha",
                            Type = "int",
                            Value = TrackName.Alpha
                        }
                        );
                        break;
                    case  Appearing.PartiallyDisplayed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Alpha",
                            Type = "int",
                            Value = ArtistName.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Alpha",
                            Type = "int",
                            Value = HyphenText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Alpha",
                            Type = "int",
                            Value = TrackName.Alpha
                        }
                        );
                        break;
                    case  Appearing.Displayed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Alpha",
                            Type = "int",
                            Value = ArtistName.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Alpha",
                            Type = "int",
                            Value = HyphenText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Alpha",
                            Type = "int",
                            Value = TrackName.Alpha
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Appearing state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Appearing.Hidden:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Alpha",
                            Type = "int",
                            Value = ArtistName.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Alpha",
                            Type = "int",
                            Value = HyphenText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Alpha",
                            Type = "int",
                            Value = TrackName.Alpha + 0
                        }
                        );
                        break;
                    case  Appearing.PartiallyDisplayed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Alpha",
                            Type = "int",
                            Value = ArtistName.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Alpha",
                            Type = "int",
                            Value = HyphenText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Alpha",
                            Type = "int",
                            Value = TrackName.Alpha + 0
                        }
                        );
                        break;
                    case  Appearing.Displayed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ArtistName.Alpha",
                            Type = "int",
                            Value = ArtistName.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HyphenText.Alpha",
                            Type = "int",
                            Value = HyphenText.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TrackName.Alpha",
                            Type = "int",
                            Value = TrackName.Alpha + 255
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
                    else if (category.Name == "Appearing")
                    {
                        if(state.Name == "Hidden") this.mCurrentAppearingState = Appearing.Hidden;
                        if(state.Name == "PartiallyDisplayed") this.mCurrentAppearingState = Appearing.PartiallyDisplayed;
                        if(state.Name == "Displayed") this.mCurrentAppearingState = Appearing.Displayed;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime ArtistName { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime HyphenText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TrackName { get; set; }
            public CurrentMusicDisplayRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/CurrentMusicDisplay");
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
                ArtistName = this.GetGraphicalUiElementByName("ArtistName") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                HyphenText = this.GetGraphicalUiElementByName("HyphenText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                TrackName = this.GetGraphicalUiElementByName("TrackName") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
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
