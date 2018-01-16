    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class MainMenuEyeRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum EyeOpening
            {
                Closed,
                Open,
                Blink
            }
            public enum EyePosition
            {
                Left,
                Right
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            EyeOpening mCurrentEyeOpeningState;
            EyePosition mCurrentEyePositionState;
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
                            Height = 0f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            Width = 0f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            SetProperty("FaceSprite.SourceFile", "../Screens/MainMenu/blue_eye.png");
                            FaceSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            FaceSprite.TextureHeight = 852;
                            FaceSprite.TextureLeft = 0;
                            FaceSprite.TextureTop = 0;
                            FaceSprite.TextureWidth = 1280;
                            EyeSprite.Rotation = 5f;
                            SetProperty("EyeSprite.SourceFile", "../Screens/MainMenu/blue_eye.png");
                            EyeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            EyeSprite.TextureHeight = 428;
                            EyeSprite.TextureLeft = 0;
                            EyeSprite.TextureTop = 852;
                            EyeSprite.TextureWidth = 833;
                            EyeSprite.X = -75f;
                            EyeSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            EyeSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            EyeSprite.Y = 41f;
                            EyeSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            EyeSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public EyeOpening CurrentEyeOpeningState
            {
                get
                {
                    return mCurrentEyeOpeningState;
                }
                set
                {
                    mCurrentEyeOpeningState = value;
                    switch(mCurrentEyeOpeningState)
                    {
                        case  EyeOpening.Closed:
                            FaceSprite.Alpha = 50;
                            EyeSprite.TextureHeight = 0;
                            EyeSprite.TextureTop = 1066;
                            break;
                        case  EyeOpening.Open:
                            FaceSprite.Alpha = 255;
                            EyeSprite.TextureHeight = 428;
                            EyeSprite.TextureTop = 852;
                            break;
                        case  EyeOpening.Blink:
                            FaceSprite.Alpha = 255;
                            EyeSprite.TextureHeight = 0;
                            EyeSprite.TextureTop = 1066;
                            break;
                    }
                }
            }
            public EyePosition CurrentEyePositionState
            {
                get
                {
                    return mCurrentEyePositionState;
                }
                set
                {
                    mCurrentEyePositionState = value;
                    switch(mCurrentEyePositionState)
                    {
                        case  EyePosition.Left:
                            FaceSprite.FlipHorizontal = true;
                            EyeSprite.FlipHorizontal = true;
                            EyeSprite.Rotation = -5f;
                            EyeSprite.X = 76f;
                            EyeSprite.Y = 40f;
                            break;
                        case  EyePosition.Right:
                            FaceSprite.FlipHorizontal = false;
                            EyeSprite.FlipHorizontal = false;
                            EyeSprite.Rotation = 5f;
                            EyeSprite.X = -75f;
                            EyeSprite.Y = 41f;
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
                bool setEyeSpriteRotationFirstValue = false;
                bool setEyeSpriteRotationSecondValue = false;
                float EyeSpriteRotationFirstValue= 0;
                float EyeSpriteRotationSecondValue= 0;
                bool setEyeSpriteTextureHeightFirstValue = false;
                bool setEyeSpriteTextureHeightSecondValue = false;
                int EyeSpriteTextureHeightFirstValue= 0;
                int EyeSpriteTextureHeightSecondValue= 0;
                bool setEyeSpriteTextureLeftFirstValue = false;
                bool setEyeSpriteTextureLeftSecondValue = false;
                int EyeSpriteTextureLeftFirstValue= 0;
                int EyeSpriteTextureLeftSecondValue= 0;
                bool setEyeSpriteTextureTopFirstValue = false;
                bool setEyeSpriteTextureTopSecondValue = false;
                int EyeSpriteTextureTopFirstValue= 0;
                int EyeSpriteTextureTopSecondValue= 0;
                bool setEyeSpriteTextureWidthFirstValue = false;
                bool setEyeSpriteTextureWidthSecondValue = false;
                int EyeSpriteTextureWidthFirstValue= 0;
                int EyeSpriteTextureWidthSecondValue= 0;
                bool setEyeSpriteXFirstValue = false;
                bool setEyeSpriteXSecondValue = false;
                float EyeSpriteXFirstValue= 0;
                float EyeSpriteXSecondValue= 0;
                bool setEyeSpriteYFirstValue = false;
                bool setEyeSpriteYSecondValue = false;
                float EyeSpriteYFirstValue= 0;
                float EyeSpriteYSecondValue= 0;
                bool setFaceSpriteTextureHeightFirstValue = false;
                bool setFaceSpriteTextureHeightSecondValue = false;
                int FaceSpriteTextureHeightFirstValue= 0;
                int FaceSpriteTextureHeightSecondValue= 0;
                bool setFaceSpriteTextureLeftFirstValue = false;
                bool setFaceSpriteTextureLeftSecondValue = false;
                int FaceSpriteTextureLeftFirstValue= 0;
                int FaceSpriteTextureLeftSecondValue= 0;
                bool setFaceSpriteTextureTopFirstValue = false;
                bool setFaceSpriteTextureTopSecondValue = false;
                int FaceSpriteTextureTopFirstValue= 0;
                int FaceSpriteTextureTopSecondValue= 0;
                bool setFaceSpriteTextureWidthFirstValue = false;
                bool setFaceSpriteTextureWidthSecondValue = false;
                int FaceSpriteTextureWidthFirstValue= 0;
                int FaceSpriteTextureWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setEyeSpriteRotationFirstValue = true;
                        EyeSpriteRotationFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("EyeSprite.SourceFile", "../Screens/MainMenu/blue_eye.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.EyeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setEyeSpriteTextureHeightFirstValue = true;
                        EyeSpriteTextureHeightFirstValue = 428;
                        setEyeSpriteTextureLeftFirstValue = true;
                        EyeSpriteTextureLeftFirstValue = 0;
                        setEyeSpriteTextureTopFirstValue = true;
                        EyeSpriteTextureTopFirstValue = 852;
                        setEyeSpriteTextureWidthFirstValue = true;
                        EyeSpriteTextureWidthFirstValue = 833;
                        setEyeSpriteXFirstValue = true;
                        EyeSpriteXFirstValue = -75f;
                        if (interpolationValue < 1)
                        {
                            this.EyeSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.EyeSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setEyeSpriteYFirstValue = true;
                        EyeSpriteYFirstValue = 41f;
                        if (interpolationValue < 1)
                        {
                            this.EyeSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.EyeSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("FaceSprite.SourceFile", "../Screens/MainMenu/blue_eye.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.FaceSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setFaceSpriteTextureHeightFirstValue = true;
                        FaceSpriteTextureHeightFirstValue = 852;
                        setFaceSpriteTextureLeftFirstValue = true;
                        FaceSpriteTextureLeftFirstValue = 0;
                        setFaceSpriteTextureTopFirstValue = true;
                        FaceSpriteTextureTopFirstValue = 0;
                        setFaceSpriteTextureWidthFirstValue = true;
                        FaceSpriteTextureWidthFirstValue = 1280;
                        setHeightFirstValue = true;
                        HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setEyeSpriteRotationSecondValue = true;
                        EyeSpriteRotationSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("EyeSprite.SourceFile", "../Screens/MainMenu/blue_eye.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EyeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setEyeSpriteTextureHeightSecondValue = true;
                        EyeSpriteTextureHeightSecondValue = 428;
                        setEyeSpriteTextureLeftSecondValue = true;
                        EyeSpriteTextureLeftSecondValue = 0;
                        setEyeSpriteTextureTopSecondValue = true;
                        EyeSpriteTextureTopSecondValue = 852;
                        setEyeSpriteTextureWidthSecondValue = true;
                        EyeSpriteTextureWidthSecondValue = 833;
                        setEyeSpriteXSecondValue = true;
                        EyeSpriteXSecondValue = -75f;
                        if (interpolationValue >= 1)
                        {
                            this.EyeSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EyeSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setEyeSpriteYSecondValue = true;
                        EyeSpriteYSecondValue = 41f;
                        if (interpolationValue >= 1)
                        {
                            this.EyeSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EyeSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("FaceSprite.SourceFile", "../Screens/MainMenu/blue_eye.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FaceSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setFaceSpriteTextureHeightSecondValue = true;
                        FaceSpriteTextureHeightSecondValue = 852;
                        setFaceSpriteTextureLeftSecondValue = true;
                        FaceSpriteTextureLeftSecondValue = 0;
                        setFaceSpriteTextureTopSecondValue = true;
                        FaceSpriteTextureTopSecondValue = 0;
                        setFaceSpriteTextureWidthSecondValue = true;
                        FaceSpriteTextureWidthSecondValue = 1280;
                        setHeightSecondValue = true;
                        HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                }
                if (setEyeSpriteRotationFirstValue && setEyeSpriteRotationSecondValue)
                {
                    EyeSprite.Rotation = EyeSpriteRotationFirstValue * (1 - interpolationValue) + EyeSpriteRotationSecondValue * interpolationValue;
                }
                if (setEyeSpriteTextureHeightFirstValue && setEyeSpriteTextureHeightSecondValue)
                {
                    EyeSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(EyeSpriteTextureHeightFirstValue* (1 - interpolationValue) + EyeSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setEyeSpriteTextureLeftFirstValue && setEyeSpriteTextureLeftSecondValue)
                {
                    EyeSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(EyeSpriteTextureLeftFirstValue* (1 - interpolationValue) + EyeSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setEyeSpriteTextureTopFirstValue && setEyeSpriteTextureTopSecondValue)
                {
                    EyeSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(EyeSpriteTextureTopFirstValue* (1 - interpolationValue) + EyeSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setEyeSpriteTextureWidthFirstValue && setEyeSpriteTextureWidthSecondValue)
                {
                    EyeSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(EyeSpriteTextureWidthFirstValue* (1 - interpolationValue) + EyeSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setEyeSpriteXFirstValue && setEyeSpriteXSecondValue)
                {
                    EyeSprite.X = EyeSpriteXFirstValue * (1 - interpolationValue) + EyeSpriteXSecondValue * interpolationValue;
                }
                if (setEyeSpriteYFirstValue && setEyeSpriteYSecondValue)
                {
                    EyeSprite.Y = EyeSpriteYFirstValue * (1 - interpolationValue) + EyeSpriteYSecondValue * interpolationValue;
                }
                if (setFaceSpriteTextureHeightFirstValue && setFaceSpriteTextureHeightSecondValue)
                {
                    FaceSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(FaceSpriteTextureHeightFirstValue* (1 - interpolationValue) + FaceSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setFaceSpriteTextureLeftFirstValue && setFaceSpriteTextureLeftSecondValue)
                {
                    FaceSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(FaceSpriteTextureLeftFirstValue* (1 - interpolationValue) + FaceSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setFaceSpriteTextureTopFirstValue && setFaceSpriteTextureTopSecondValue)
                {
                    FaceSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(FaceSpriteTextureTopFirstValue* (1 - interpolationValue) + FaceSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setFaceSpriteTextureWidthFirstValue && setFaceSpriteTextureWidthSecondValue)
                {
                    FaceSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(FaceSpriteTextureWidthFirstValue* (1 - interpolationValue) + FaceSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
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
            public void InterpolateBetween (EyeOpening firstState, EyeOpening secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setEyeSpriteTextureHeightFirstValue = false;
                bool setEyeSpriteTextureHeightSecondValue = false;
                int EyeSpriteTextureHeightFirstValue= 0;
                int EyeSpriteTextureHeightSecondValue= 0;
                bool setEyeSpriteTextureTopFirstValue = false;
                bool setEyeSpriteTextureTopSecondValue = false;
                int EyeSpriteTextureTopFirstValue= 0;
                int EyeSpriteTextureTopSecondValue= 0;
                bool setFaceSpriteAlphaFirstValue = false;
                bool setFaceSpriteAlphaSecondValue = false;
                int FaceSpriteAlphaFirstValue= 0;
                int FaceSpriteAlphaSecondValue= 0;
                switch(firstState)
                {
                    case  EyeOpening.Closed:
                        setEyeSpriteTextureHeightFirstValue = true;
                        EyeSpriteTextureHeightFirstValue = 0;
                        setEyeSpriteTextureTopFirstValue = true;
                        EyeSpriteTextureTopFirstValue = 1066;
                        setFaceSpriteAlphaFirstValue = true;
                        FaceSpriteAlphaFirstValue = 50;
                        break;
                    case  EyeOpening.Open:
                        setEyeSpriteTextureHeightFirstValue = true;
                        EyeSpriteTextureHeightFirstValue = 428;
                        setEyeSpriteTextureTopFirstValue = true;
                        EyeSpriteTextureTopFirstValue = 852;
                        setFaceSpriteAlphaFirstValue = true;
                        FaceSpriteAlphaFirstValue = 255;
                        break;
                    case  EyeOpening.Blink:
                        setEyeSpriteTextureHeightFirstValue = true;
                        EyeSpriteTextureHeightFirstValue = 0;
                        setEyeSpriteTextureTopFirstValue = true;
                        EyeSpriteTextureTopFirstValue = 1066;
                        setFaceSpriteAlphaFirstValue = true;
                        FaceSpriteAlphaFirstValue = 255;
                        break;
                }
                switch(secondState)
                {
                    case  EyeOpening.Closed:
                        setEyeSpriteTextureHeightSecondValue = true;
                        EyeSpriteTextureHeightSecondValue = 0;
                        setEyeSpriteTextureTopSecondValue = true;
                        EyeSpriteTextureTopSecondValue = 1066;
                        setFaceSpriteAlphaSecondValue = true;
                        FaceSpriteAlphaSecondValue = 50;
                        break;
                    case  EyeOpening.Open:
                        setEyeSpriteTextureHeightSecondValue = true;
                        EyeSpriteTextureHeightSecondValue = 428;
                        setEyeSpriteTextureTopSecondValue = true;
                        EyeSpriteTextureTopSecondValue = 852;
                        setFaceSpriteAlphaSecondValue = true;
                        FaceSpriteAlphaSecondValue = 255;
                        break;
                    case  EyeOpening.Blink:
                        setEyeSpriteTextureHeightSecondValue = true;
                        EyeSpriteTextureHeightSecondValue = 0;
                        setEyeSpriteTextureTopSecondValue = true;
                        EyeSpriteTextureTopSecondValue = 1066;
                        setFaceSpriteAlphaSecondValue = true;
                        FaceSpriteAlphaSecondValue = 255;
                        break;
                }
                if (setEyeSpriteTextureHeightFirstValue && setEyeSpriteTextureHeightSecondValue)
                {
                    EyeSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(EyeSpriteTextureHeightFirstValue* (1 - interpolationValue) + EyeSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setEyeSpriteTextureTopFirstValue && setEyeSpriteTextureTopSecondValue)
                {
                    EyeSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(EyeSpriteTextureTopFirstValue* (1 - interpolationValue) + EyeSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setFaceSpriteAlphaFirstValue && setFaceSpriteAlphaSecondValue)
                {
                    FaceSprite.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(FaceSpriteAlphaFirstValue* (1 - interpolationValue) + FaceSpriteAlphaSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentEyeOpeningState = firstState;
                }
                else
                {
                    mCurrentEyeOpeningState = secondState;
                }
            }
            public void InterpolateBetween (EyePosition firstState, EyePosition secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setEyeSpriteRotationFirstValue = false;
                bool setEyeSpriteRotationSecondValue = false;
                float EyeSpriteRotationFirstValue= 0;
                float EyeSpriteRotationSecondValue= 0;
                bool setEyeSpriteXFirstValue = false;
                bool setEyeSpriteXSecondValue = false;
                float EyeSpriteXFirstValue= 0;
                float EyeSpriteXSecondValue= 0;
                bool setEyeSpriteYFirstValue = false;
                bool setEyeSpriteYSecondValue = false;
                float EyeSpriteYFirstValue= 0;
                float EyeSpriteYSecondValue= 0;
                switch(firstState)
                {
                    case  EyePosition.Left:
                        if (interpolationValue < 1)
                        {
                            this.EyeSprite.FlipHorizontal = true;
                        }
                        setEyeSpriteRotationFirstValue = true;
                        EyeSpriteRotationFirstValue = -5f;
                        setEyeSpriteXFirstValue = true;
                        EyeSpriteXFirstValue = 76f;
                        setEyeSpriteYFirstValue = true;
                        EyeSpriteYFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.FaceSprite.FlipHorizontal = true;
                        }
                        break;
                    case  EyePosition.Right:
                        if (interpolationValue < 1)
                        {
                            this.EyeSprite.FlipHorizontal = false;
                        }
                        setEyeSpriteRotationFirstValue = true;
                        EyeSpriteRotationFirstValue = 5f;
                        setEyeSpriteXFirstValue = true;
                        EyeSpriteXFirstValue = -75f;
                        setEyeSpriteYFirstValue = true;
                        EyeSpriteYFirstValue = 41f;
                        if (interpolationValue < 1)
                        {
                            this.FaceSprite.FlipHorizontal = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  EyePosition.Left:
                        if (interpolationValue >= 1)
                        {
                            this.EyeSprite.FlipHorizontal = true;
                        }
                        setEyeSpriteRotationSecondValue = true;
                        EyeSpriteRotationSecondValue = -5f;
                        setEyeSpriteXSecondValue = true;
                        EyeSpriteXSecondValue = 76f;
                        setEyeSpriteYSecondValue = true;
                        EyeSpriteYSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.FaceSprite.FlipHorizontal = true;
                        }
                        break;
                    case  EyePosition.Right:
                        if (interpolationValue >= 1)
                        {
                            this.EyeSprite.FlipHorizontal = false;
                        }
                        setEyeSpriteRotationSecondValue = true;
                        EyeSpriteRotationSecondValue = 5f;
                        setEyeSpriteXSecondValue = true;
                        EyeSpriteXSecondValue = -75f;
                        setEyeSpriteYSecondValue = true;
                        EyeSpriteYSecondValue = 41f;
                        if (interpolationValue >= 1)
                        {
                            this.FaceSprite.FlipHorizontal = false;
                        }
                        break;
                }
                if (setEyeSpriteRotationFirstValue && setEyeSpriteRotationSecondValue)
                {
                    EyeSprite.Rotation = EyeSpriteRotationFirstValue * (1 - interpolationValue) + EyeSpriteRotationSecondValue * interpolationValue;
                }
                if (setEyeSpriteXFirstValue && setEyeSpriteXSecondValue)
                {
                    EyeSprite.X = EyeSpriteXFirstValue * (1 - interpolationValue) + EyeSpriteXSecondValue * interpolationValue;
                }
                if (setEyeSpriteYFirstValue && setEyeSpriteYSecondValue)
                {
                    EyeSprite.Y = EyeSpriteYFirstValue * (1 - interpolationValue) + EyeSpriteYSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentEyePositionState = firstState;
                }
                else
                {
                    mCurrentEyePositionState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening fromState,AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (EyeOpening toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "EyeOpening").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentEyeOpeningState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (EyeOpening toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentEyeOpeningState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition fromState,AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (EyePosition toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "EyePosition").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentEyePositionState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (EyePosition toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentEyePositionState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> OpenEyeAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentEyeOpeningState = EyeOpening.Closed);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(EyeOpening.Open, 0.5f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.Out, OpenEyeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(EyeOpening.Open, 0.4f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.In, OpenEyeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.5f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(EyeOpening.Blink, 0.2f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, OpenEyeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.9f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(EyeOpening.Open, 0.1999999f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Bounce, FlatRedBall.Glue.StateInterpolation.Easing.Out, OpenEyeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1.1f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(EyeOpening.Open, 0.2f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.In, OpenEyeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1.3f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(EyeOpening.Blink, 0.04999995f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.In, OpenEyeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1.5f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(EyeOpening.Open, 0.25f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.InOut, OpenEyeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1.55f;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> OpenEyeAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Closed").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(EyeOpening.Open);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.5f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(EyeOpening.Open);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.4f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.In);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.5f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Blink").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(EyeOpening.Blink);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.2f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.9f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Blink").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(EyeOpening.Open);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.1999999f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Bounce, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1.1f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(EyeOpening.Open);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.2f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.In);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1.3f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Blink").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(EyeOpening.Blink);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.04999995f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.In);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Blink").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(EyeOpening.Open);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.25f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1.55f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation openEyeAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation OpenEyeAnimation
            {
                get
                {
                    if (openEyeAnimation == null)
                    {
                        openEyeAnimation = new FlatRedBall.Gum.Animation.GumAnimation(1.8f, OpenEyeAnimationInstructions);
                    }
                    return openEyeAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation openEyeAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation OpenEyeAnimationRelative
            {
                get
                {
                    if (openEyeAnimationRelative == null)
                    {
                        openEyeAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(1.8f, OpenEyeAnimationRelativeInstructions);
                    }
                    return openEyeAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> BlinkEyeAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentEyeOpeningState = EyeOpening.Open);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(EyeOpening.Blink, 0.1f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, BlinkEyeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(EyeOpening.Open, 0.1f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.InOut, BlinkEyeAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.1f;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> BlinkEyeAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Blink").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(EyeOpening.Blink);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.1f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Blink").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "EyeOpening/Open").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(EyeOpening.Open);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.1f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.1f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation blinkEyeAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation BlinkEyeAnimation
            {
                get
                {
                    if (blinkEyeAnimation == null)
                    {
                        blinkEyeAnimation = new FlatRedBall.Gum.Animation.GumAnimation(0.2f, BlinkEyeAnimationInstructions);
                    }
                    return blinkEyeAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation blinkEyeAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation BlinkEyeAnimationRelative
            {
                get
                {
                    if (blinkEyeAnimationRelative == null)
                    {
                        blinkEyeAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(0.2f, BlinkEyeAnimationRelativeInstructions);
                    }
                    return blinkEyeAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                OpenEyeAnimation.Stop();
                BlinkEyeAnimation.Stop();
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
                            Name = "FaceSprite.SourceFile",
                            Type = "string",
                            Value = FaceSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = FaceSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Texture Height",
                            Type = "int",
                            Value = FaceSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Texture Left",
                            Type = "int",
                            Value = FaceSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Texture Top",
                            Type = "int",
                            Value = FaceSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Texture Width",
                            Type = "int",
                            Value = FaceSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Rotation",
                            Type = "float",
                            Value = EyeSprite.Rotation
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.SourceFile",
                            Type = "string",
                            Value = EyeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = EyeSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Height",
                            Type = "int",
                            Value = EyeSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Left",
                            Type = "int",
                            Value = EyeSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Top",
                            Type = "int",
                            Value = EyeSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Width",
                            Type = "int",
                            Value = EyeSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.X",
                            Type = "float",
                            Value = EyeSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = EyeSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.X Units",
                            Type = "PositionUnitType",
                            Value = EyeSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Y",
                            Type = "float",
                            Value = EyeSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = EyeSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = EyeSprite.YUnits
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
                            Name = "Height",
                            Type = "float",
                            Value = Height + 0f
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
                            Name = "FaceSprite.SourceFile",
                            Type = "string",
                            Value = FaceSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = FaceSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Texture Height",
                            Type = "int",
                            Value = FaceSprite.TextureHeight + 852
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Texture Left",
                            Type = "int",
                            Value = FaceSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Texture Top",
                            Type = "int",
                            Value = FaceSprite.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Texture Width",
                            Type = "int",
                            Value = FaceSprite.TextureWidth + 1280
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Rotation",
                            Type = "float",
                            Value = EyeSprite.Rotation + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.SourceFile",
                            Type = "string",
                            Value = EyeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = EyeSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Height",
                            Type = "int",
                            Value = EyeSprite.TextureHeight + 428
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Left",
                            Type = "int",
                            Value = EyeSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Top",
                            Type = "int",
                            Value = EyeSprite.TextureTop + 852
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Width",
                            Type = "int",
                            Value = EyeSprite.TextureWidth + 833
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.X",
                            Type = "float",
                            Value = EyeSprite.X + -75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = EyeSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.X Units",
                            Type = "PositionUnitType",
                            Value = EyeSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Y",
                            Type = "float",
                            Value = EyeSprite.Y + 41f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = EyeSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = EyeSprite.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (EyeOpening state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  EyeOpening.Closed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Alpha",
                            Type = "int",
                            Value = FaceSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Height",
                            Type = "int",
                            Value = EyeSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Top",
                            Type = "int",
                            Value = EyeSprite.TextureTop
                        }
                        );
                        break;
                    case  EyeOpening.Open:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Alpha",
                            Type = "int",
                            Value = FaceSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Height",
                            Type = "int",
                            Value = EyeSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Top",
                            Type = "int",
                            Value = EyeSprite.TextureTop
                        }
                        );
                        break;
                    case  EyeOpening.Blink:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Alpha",
                            Type = "int",
                            Value = FaceSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Height",
                            Type = "int",
                            Value = EyeSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Top",
                            Type = "int",
                            Value = EyeSprite.TextureTop
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (EyeOpening state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  EyeOpening.Closed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Alpha",
                            Type = "int",
                            Value = FaceSprite.Alpha + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Height",
                            Type = "int",
                            Value = EyeSprite.TextureHeight + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Top",
                            Type = "int",
                            Value = EyeSprite.TextureTop + 1066
                        }
                        );
                        break;
                    case  EyeOpening.Open:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Alpha",
                            Type = "int",
                            Value = FaceSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Height",
                            Type = "int",
                            Value = EyeSprite.TextureHeight + 428
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Top",
                            Type = "int",
                            Value = EyeSprite.TextureTop + 852
                        }
                        );
                        break;
                    case  EyeOpening.Blink:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.Alpha",
                            Type = "int",
                            Value = FaceSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Height",
                            Type = "int",
                            Value = EyeSprite.TextureHeight + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Texture Top",
                            Type = "int",
                            Value = EyeSprite.TextureTop + 1066
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (EyePosition state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  EyePosition.Left:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.FlipHorizontal",
                            Type = "bool",
                            Value = FaceSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.FlipHorizontal",
                            Type = "bool",
                            Value = EyeSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Rotation",
                            Type = "float",
                            Value = EyeSprite.Rotation
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.X",
                            Type = "float",
                            Value = EyeSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Y",
                            Type = "float",
                            Value = EyeSprite.Y
                        }
                        );
                        break;
                    case  EyePosition.Right:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.FlipHorizontal",
                            Type = "bool",
                            Value = FaceSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.FlipHorizontal",
                            Type = "bool",
                            Value = EyeSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Rotation",
                            Type = "float",
                            Value = EyeSprite.Rotation
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.X",
                            Type = "float",
                            Value = EyeSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Y",
                            Type = "float",
                            Value = EyeSprite.Y
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (EyePosition state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  EyePosition.Left:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.FlipHorizontal",
                            Type = "bool",
                            Value = FaceSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.FlipHorizontal",
                            Type = "bool",
                            Value = EyeSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Rotation",
                            Type = "float",
                            Value = EyeSprite.Rotation + -5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.X",
                            Type = "float",
                            Value = EyeSprite.X + 76f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Y",
                            Type = "float",
                            Value = EyeSprite.Y + 40f
                        }
                        );
                        break;
                    case  EyePosition.Right:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FaceSprite.FlipHorizontal",
                            Type = "bool",
                            Value = FaceSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.FlipHorizontal",
                            Type = "bool",
                            Value = EyeSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Rotation",
                            Type = "float",
                            Value = EyeSprite.Rotation + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.X",
                            Type = "float",
                            Value = EyeSprite.X + -75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EyeSprite.Y",
                            Type = "float",
                            Value = EyeSprite.Y + 41f
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
                    else if (category.Name == "EyeOpening")
                    {
                        if(state.Name == "Closed") this.mCurrentEyeOpeningState = EyeOpening.Closed;
                        if(state.Name == "Open") this.mCurrentEyeOpeningState = EyeOpening.Open;
                        if(state.Name == "Blink") this.mCurrentEyeOpeningState = EyeOpening.Blink;
                    }
                    else if (category.Name == "EyePosition")
                    {
                        if(state.Name == "Left") this.mCurrentEyePositionState = EyePosition.Left;
                        if(state.Name == "Right") this.mCurrentEyePositionState = EyePosition.Right;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime FaceSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime EyeSprite { get; set; }
            public MainMenuEyeRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "unique/MainMenuEye");
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
                FaceSprite = this.GetGraphicalUiElementByName("FaceSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                EyeSprite = this.GetGraphicalUiElementByName("EyeSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
