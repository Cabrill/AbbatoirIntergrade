#if ANDROID || IOS
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using AbbatoirIntergrade.Screens;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities;
using AbbatoirIntergrade.Entities.Enemies;
using AbbatoirIntergrade.Entities.GraphicalElements;
using AbbatoirIntergrade.Entities.Projectiles;
using AbbatoirIntergrade.Entities.Structures;
using AbbatoirIntergrade.Factories;
using FlatRedBall;
using FlatRedBall.Screens;
using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Graphics.Animation;
namespace AbbatoirIntergrade.Entities.BaseEntities
{
    public partial class BasePlayerProjectile : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Graphics.IVisible, FlatRedBall.Math.Geometry.ICollidable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        public enum VariableState
        {
            Uninitialized = 0, //This exists so that the first set call actually does something
            Unknown = 1, //This exists so that if the entity is actually a child entity and has set a child state, you will get this
            Flying = 2, 
            Impact = 3
        }
        protected int mCurrentState = 0;
        public Entities.BaseEntities.BasePlayerProjectile.VariableState CurrentState
        {
            get
            {
                if (System.Enum.IsDefined(typeof(VariableState), mCurrentState))
                {
                    return (VariableState)mCurrentState;
                }
                else
                {
                    return VariableState.Unknown;
                }
            }
            set
            {
                mCurrentState = (int)value;
                switch(CurrentState)
                {
                    case  VariableState.Uninitialized:
                        break;
                    case  VariableState.Unknown:
                        break;
                    case  VariableState.Flying:
                        SpriteInstanceCurrentChainName = "Shot";
                        break;
                    case  VariableState.Impact:
                        Speed = 0f;
                        SpriteInstanceCurrentChainName = "Impact";
                        break;
                }
            }
        }
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AllAssetsSheet;
        
        protected FlatRedBall.Sprite SpriteInstance;
        static float SpriteInstanceXReset;
        static float SpriteInstanceYReset;
        static float SpriteInstanceZReset;
        static float SpriteInstanceXVelocityReset;
        static float SpriteInstanceYVelocityReset;
        static float SpriteInstanceZVelocityReset;
        static float SpriteInstanceRotationXReset;
        static float SpriteInstanceRotationYReset;
        static float SpriteInstanceRotationZReset;
        static float SpriteInstanceRotationXVelocityReset;
        static float SpriteInstanceRotationYVelocityReset;
        static float SpriteInstanceRotationZVelocityReset;
        static float SpriteInstanceAlphaReset;
        static float SpriteInstanceAlphaRateReset;
        protected FlatRedBall.Sprite LightOrShadowSprite;
        static float LightOrShadowSpriteXReset;
        static float LightOrShadowSpriteYReset;
        static float LightOrShadowSpriteZReset;
        static float LightOrShadowSpriteXVelocityReset;
        static float LightOrShadowSpriteYVelocityReset;
        static float LightOrShadowSpriteZVelocityReset;
        static float LightOrShadowSpriteRotationXReset;
        static float LightOrShadowSpriteRotationYReset;
        static float LightOrShadowSpriteRotationZReset;
        static float LightOrShadowSpriteRotationXVelocityReset;
        static float LightOrShadowSpriteRotationYVelocityReset;
        static float LightOrShadowSpriteRotationZVelocityReset;
        static float LightOrShadowSpriteAlphaReset;
        static float LightOrShadowSpriteAlphaRateReset;
        protected FlatRedBall.Math.Geometry.Circle mCircleInstance;
        public FlatRedBall.Math.Geometry.Circle CircleInstance
        {
            get
            {
                return mCircleInstance;
            }
            protected set
            {
                mCircleInstance = value;
            }
        }
        protected FlatRedBall.Graphics.Animation.AnimationChain AnimationChainInstance;
        public virtual float DamageInflicted { get; set; }
        public event System.EventHandler BeforeSpeedSet;
        public event System.EventHandler AfterSpeedSet;
        float mSpeed;
        public float Speed
        {
            set
            {
                if (BeforeSpeedSet != null)
                {
                    BeforeSpeedSet(this, null);
                }
                mSpeed = value;
                if (AfterSpeedSet != null)
                {
                    AfterSpeedSet(this, null);
                }
            }
            get
            {
                return mSpeed;
            }
        }
        bool mHasLightSource = false;
        public virtual bool HasLightSource
        {
            set
            {
                mHasLightSource = value;
            }
            get
            {
                return mHasLightSource;
            }
        }
        public string SpriteInstanceCurrentChainName
        {
            get
            {
                return SpriteInstance.CurrentChainName;
            }
            set
            {
                SpriteInstance.CurrentChainName = value;
            }
        }
        public event System.EventHandler BeforeVisibleSet;
        public event System.EventHandler AfterVisibleSet;
        protected bool mVisible = true;
        public virtual bool Visible
        {
            get
            {
                return mVisible;
            }
            set
            {
                if (BeforeVisibleSet != null)
                {
                    BeforeVisibleSet(this, null);
                }
                mVisible = value;
                if (AfterVisibleSet != null)
                {
                    AfterVisibleSet(this, null);
                }
            }
        }
        public bool IgnoresParentVisibility { get; set; }
        public bool AbsoluteVisible
        {
            get
            {
                return Visible && (Parent == null || IgnoresParentVisibility || Parent is FlatRedBall.Graphics.IVisible == false || (Parent as FlatRedBall.Graphics.IVisible).AbsoluteVisible);
            }
        }
        FlatRedBall.Graphics.IVisible FlatRedBall.Graphics.IVisible.Parent
        {
            get
            {
                if (this.Parent != null && this.Parent is FlatRedBall.Graphics.IVisible)
                {
                    return this.Parent as FlatRedBall.Graphics.IVisible;
                }
                else
                {
                    return null;
                }
            }
        }
        private FlatRedBall.Math.Geometry.ShapeCollection mGeneratedCollision;
        public FlatRedBall.Math.Geometry.ShapeCollection Collision
        {
            get
            {
                return mGeneratedCollision;
            }
        }
        protected FlatRedBall.Graphics.Layer LayerProvidedByContainer = null;
        public BasePlayerProjectile () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public BasePlayerProjectile (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public BasePlayerProjectile (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            
            PostInitialize();
            if (addToManagers)
            {
                AddToManagers(null);
            }
        }
        public virtual void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            
            CustomActivity();
        }
        public virtual void Destroy () 
        {
            FlatRedBall.SpriteManager.RemovePositionedObject(this);
            
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (SpriteInstance!= null)
            {
                if (SpriteInstance.Parent == null)
                {
                    SpriteInstance.CopyAbsoluteToRelative();
                    SpriteInstance.AttachTo(this, false);
                }
                if (SpriteInstance.Parent == null)
                {
                    SpriteInstance.Z = 1f;
                }
                else
                {
                    SpriteInstance.RelativeZ = 1f;
                }
                SpriteInstance.Texture = AllAssetsSheet;
                SpriteInstance.TextureScale = 1f;
                SpriteInstance.ParentRotationChangesPosition = false;
            }
            if (LightOrShadowSprite!= null)
            {
                if (LightOrShadowSprite.Parent == null)
                {
                    LightOrShadowSprite.CopyAbsoluteToRelative();
                    LightOrShadowSprite.AttachTo(this, false);
                }
                if (LightOrShadowSprite.Parent == null)
                {
                    LightOrShadowSprite.Z = -1f;
                }
                else
                {
                    LightOrShadowSprite.RelativeZ = -1f;
                }
                LightOrShadowSprite.Texture = AllAssetsSheet;
                LightOrShadowSprite.LeftTexturePixel = 1792f;
                LightOrShadowSprite.RightTexturePixel = 2048f;
                LightOrShadowSprite.TopTexturePixel = 1792f;
                LightOrShadowSprite.BottomTexturePixel = 2048f;
                LightOrShadowSprite.TextureScale = 1f;
                LightOrShadowSprite.ParentRotationChangesPosition = false;
            }
            if (CircleInstance!= null)
            {
                if (mCircleInstance.Parent == null)
                {
                    mCircleInstance.CopyAbsoluteToRelative();
                    mCircleInstance.AttachTo(this, false);
                }
                CircleInstance.Radius = 16f;
                CircleInstance.Color = Color.Red;
                CircleInstance.ParentRotationChangesPosition = false;
            }
            if (AnimationChainInstance!= null)
            {
            }
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            mGeneratedCollision.Circles.AddOneWay(mCircleInstance);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            HasLightSource = false;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            }
            if (LightOrShadowSprite != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(LightOrShadowSprite);
            }
            if (AnimationChainInstance != null)
            {
            }
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BasePlayerProjectileStaticUnload", UnloadStaticContent);
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
        static VariableState mLoadingState = VariableState.Uninitialized;
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
            switch(stateToInterpolateTo)
            {
                case  VariableState.Flying:
                    break;
                case  VariableState.Impact:
                    break;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<VariableState>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (VariableState stateToStop) 
        {
            switch(stateToStop)
            {
                case  VariableState.Flying:
                    break;
                case  VariableState.Impact:
                    break;
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
            bool setSpeed = true;
            float SpeedFirstValue= 0;
            float SpeedSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Flying:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Shot";
                    }
                    break;
                case  VariableState.Impact:
                    SpeedFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Impact";
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Flying:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Shot";
                    }
                    break;
                case  VariableState.Impact:
                    SpeedSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Impact";
                    }
                    break;
            }
            if (setSpeed)
            {
                Speed = SpeedFirstValue * (1 - interpolationValue) + SpeedSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentState = (int)firstState;
            }
            else
            {
                mCurrentState = (int)secondState;
            }
        }
        public static void PreloadStateContent (VariableState state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            switch(state)
            {
                case  VariableState.Flying:
                    {
                        object throwaway = "Shot";
                    }
                    break;
                case  VariableState.Impact:
                    {
                        object throwaway = "Impact";
                    }
                    break;
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
        protected bool mIsPaused;
        public override void Pause (FlatRedBall.Instructions.InstructionList instructions) 
        {
            base.Pause(instructions);
            mIsPaused = true;
        }
        public virtual void SetToIgnorePausing () 
        {
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(this);
            if (SpriteInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            }
            if (LightOrShadowSprite != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightOrShadowSprite);
            }
            if (CircleInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(CircleInstance);
            }
            if (AnimationChainInstance != null)
            {
            }
        }
        public virtual void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer;
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(SpriteInstance);
            }
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(LightOrShadowSprite);
            }
            FlatRedBall.SpriteManager.AddToLayer(LightOrShadowSprite, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(CircleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(CircleInstance, layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
    }
    public static class BasePlayerProjectileExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<BasePlayerProjectile> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
