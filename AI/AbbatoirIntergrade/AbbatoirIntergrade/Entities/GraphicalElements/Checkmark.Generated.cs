#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using FlatRedBall.Gui;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace AbbatoirIntergrade.Entities.GraphicalElements
{
    public partial class Checkmark : FlatRedBall.Sprite, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Graphics.IVisible, FlatRedBall.Gui.IClickable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        public class VariableState
        {
            public float X;
            public float Y;
            public float Z;
            public float SpriteInstanceAlpha;
            public static VariableState Enabled = new VariableState()
            {
                SpriteInstanceAlpha = 1f,
            }
            ;
            public static VariableState Disabled = new VariableState()
            {
                SpriteInstanceAlpha = 0.1f,
            }
            ;
        }
        private VariableState mCurrentState = null;
        public Entities.GraphicalElements.Checkmark.VariableState CurrentState
        {
            get
            {
                return mCurrentState;
            }
            set
            {
                mCurrentState = value;
                if (CurrentState == VariableState.Enabled)
                {
                    SpriteInstanceAlpha = 1f;
                }
                else if (CurrentState == VariableState.Disabled)
                {
                    SpriteInstanceAlpha = 0.1f;
                }
            }
        }
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AllAssetsSheet;
        
        private FlatRedBall.Sprite BackgroundSprite;
        private FlatRedBall.Sprite mSpriteInstance;
        public FlatRedBall.Sprite SpriteInstance
        {
            get
            {
                return mSpriteInstance;
            }
            private set
            {
                mSpriteInstance = value;
            }
        }
        public float SpriteInstanceAlpha
        {
            get
            {
                return SpriteInstance.Alpha;
            }
            set
            {
                SpriteInstance.Alpha = value;
            }
        }
        public new event System.EventHandler BeforeVisibleSet;
        public new event System.EventHandler AfterVisibleSet;
        public override bool Visible
        {
            get
            {
                return base.Visible;
            }
            set
            {
                if (BeforeVisibleSet != null)
                {
                    BeforeVisibleSet(this, null);
                }
                base.Visible = value;
                if (AfterVisibleSet != null)
                {
                    AfterVisibleSet(this, null);
                }
            }
        }
        protected FlatRedBall.Graphics.Layer LayerProvidedByContainer = null;
        public Checkmark () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public Checkmark (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public Checkmark (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            BackgroundSprite = new FlatRedBall.Sprite();
            BackgroundSprite.Name = "BackgroundSprite";
            mSpriteInstance = this;
            
            PostInitialize();
            if (addToManagers)
            {
                AddToManagers(null);
            }
        }
        public virtual void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddToLayer(this, layerToAddTo);
            FlatRedBall.SpriteManager.AddToLayer(BackgroundSprite, LayerProvidedByContainer);
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddToLayer(this, layerToAddTo);
            FlatRedBall.SpriteManager.AddToLayer(BackgroundSprite, LayerProvidedByContainer);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            mIsPaused = false;
            
            CustomActivity();
        }
        public virtual void Destroy () 
        {
            FlatRedBall.SpriteManager.RemoveSprite(this);
            
            if (BackgroundSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(BackgroundSprite);
            }
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (BackgroundSprite.Parent == null)
            {
                BackgroundSprite.CopyAbsoluteToRelative();
                BackgroundSprite.AttachTo(this, false);
            }
            if (BackgroundSprite.Parent == null)
            {
                BackgroundSprite.Z = -1f;
            }
            else
            {
                BackgroundSprite.RelativeZ = -1f;
            }
            BackgroundSprite.TextureScale = 1f;
            BackgroundSprite.Width = 100f;
            BackgroundSprite.Height = 100f;
            #if FRB_MDX
            BackgroundSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.ColorTextureAlpha;
            #else
            BackgroundSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.ColorTextureAlpha;
            #endif
            BackgroundSprite.Alpha = 0.75f;
            SpriteInstance.Texture = AllAssetsSheet;
            SpriteInstance.LeftTexturePixel = 404f;
            SpriteInstance.RightTexturePixel = 468f;
            SpriteInstance.TopTexturePixel = 30f;
            SpriteInstance.BottomTexturePixel = 92f;
            SpriteInstance.TextureScale = 1f;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.RemoveSprite(this);
            if (BackgroundSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(BackgroundSprite);
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            if (BackgroundSprite.Parent == null)
            {
                BackgroundSprite.Z = -1f;
            }
            else
            {
                BackgroundSprite.RelativeZ = -1f;
            }
            BackgroundSprite.TextureScale = 1f;
            BackgroundSprite.Width = 100f;
            BackgroundSprite.Height = 100f;
            #if FRB_MDX
            BackgroundSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.ColorTextureAlpha;
            #else
            BackgroundSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.ColorTextureAlpha;
            #endif
            BackgroundSprite.Alpha = 0.75f;
            SpriteInstance.Texture = AllAssetsSheet;
            SpriteInstance.LeftTexturePixel = 404f;
            SpriteInstance.RightTexturePixel = 468f;
            SpriteInstance.TopTexturePixel = 30f;
            SpriteInstance.BottomTexturePixel = 92f;
            SpriteInstance.TextureScale = 1f;
            SpriteInstanceAlpha = 1f;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(BackgroundSprite);
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            // Set to use global content
            contentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.GumProject;
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            if (LoadedContentManagers.Contains(contentManagerName) == false)
            {
                LoadedContentManagers.Add(contentManagerName);
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("CheckmarkStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                AllAssetsSheet = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/gamescreen/allassetssheet.png", ContentManagerName);
            }
            CustomLoadStaticContent(contentManagerName);
        }
        public static void UnloadStaticContent () 
        {
            // Intentionally left blank because this element uses global content, so it should never be unloaded
        }
        static VariableState mLoadingState = null;
        public static VariableState LoadingState
        {
            get
            {
                return mLoadingState;
            }
            set
            {
                mLoadingState = value;
            }
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (VariableState stateToInterpolateTo, double secondsToTake) 
        {
            if (stateToInterpolateTo == VariableState.Enabled)
            {
                SpriteInstance.AlphaRate = (1f - SpriteInstance.Alpha) / (float)secondsToTake;
            }
            else if (stateToInterpolateTo == VariableState.Disabled)
            {
                SpriteInstance.AlphaRate = (0.1f - SpriteInstance.Alpha) / (float)secondsToTake;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<VariableState>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (VariableState stateToStop) 
        {
            if (stateToStop == VariableState.Enabled)
            {
                SpriteInstance.AlphaRate =  0;
            }
            else if (stateToStop == VariableState.Disabled)
            {
                SpriteInstance.AlphaRate =  0;
            }
            CurrentState = stateToStop;
        }
        public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setSpriteInstanceAlpha = true;
            float SpriteInstanceAlphaFirstValue= 0;
            float SpriteInstanceAlphaSecondValue= 0;
            if (firstState == VariableState.Enabled)
            {
                SpriteInstanceAlphaFirstValue = 1f;
            }
            else if (firstState == VariableState.Disabled)
            {
                SpriteInstanceAlphaFirstValue = 0.1f;
            }
            if (secondState == VariableState.Enabled)
            {
                SpriteInstanceAlphaSecondValue = 1f;
            }
            else if (secondState == VariableState.Disabled)
            {
                SpriteInstanceAlphaSecondValue = 0.1f;
            }
            if (setSpriteInstanceAlpha)
            {
                SpriteInstanceAlpha = SpriteInstanceAlphaFirstValue * (1 - interpolationValue) + SpriteInstanceAlphaSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentState = firstState;
            }
            else
            {
                mCurrentState = secondState;
            }
        }
        public static void PreloadStateContent (VariableState state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            if (state == VariableState.Enabled)
            {
            }
            else if (state == VariableState.Disabled)
            {
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
            }
            return null;
        }
        public virtual bool HasCursorOver (FlatRedBall.Gui.Cursor cursor) 
        {
            if (mIsPaused)
            {
                return false;
            }
            if (!AbsoluteVisible)
            {
                return false;
            }
            if (LayerProvidedByContainer != null && LayerProvidedByContainer.Visible == false)
            {
                return false;
            }
            if (!cursor.IsOn(LayerProvidedByContainer))
            {
                return false;
            }
            if (BackgroundSprite.Alpha != 0 && BackgroundSprite.AbsoluteVisible && cursor.IsOn3D(BackgroundSprite, LayerProvidedByContainer))
            {
                return true;
            }
            if (SpriteInstance.Alpha != 0 && SpriteInstance.AbsoluteVisible && cursor.IsOn3D(SpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            return false;
        }
        public virtual bool WasClickedThisFrame (FlatRedBall.Gui.Cursor cursor) 
        {
            return cursor.PrimaryClick && HasCursorOver(cursor);
        }
        protected bool mIsPaused;
        public override void Pause (FlatRedBall.Instructions.InstructionList instructions) 
        {
            base.Pause(instructions);
            mIsPaused = true;
        }
        public virtual void SetToIgnorePausing () 
        {
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(this);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(BackgroundSprite);
        }
        public virtual void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer;
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(this);
            }
            FlatRedBall.SpriteManager.AddToLayer(this, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(BackgroundSprite);
            }
            FlatRedBall.SpriteManager.AddToLayer(BackgroundSprite, layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
    }
    public static class CheckmarkExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<Checkmark> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
