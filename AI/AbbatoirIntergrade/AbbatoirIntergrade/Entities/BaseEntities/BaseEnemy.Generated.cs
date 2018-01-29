#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using AbbatoirIntergrade.Screens;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using FlatRedBall.Gui;
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
using FlatRedBall.Graphics.Particle;
namespace AbbatoirIntergrade.Entities.BaseEntities
{
    public partial class BaseEnemy : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Graphics.IVisible, FlatRedBall.Gui.IClickable, FlatRedBall.Math.Geometry.ICollidable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        public enum Action
        {
            Uninitialized = 0, //This exists so that the first set call actually does something
            Unknown = 1, //This exists so that if the entity is actually a child entity and has set a child state, you will get this
            Dying = 2, 
            Hurt = 3, 
            Running = 4, 
            Standing = 5, 
            Drowning = 6
        }
        protected int mCurrentActionState = 0;
        public Entities.BaseEntities.BaseEnemy.Action CurrentActionState
        {
            get
            {
                if (mCurrentActionState >= 0 && mCurrentActionState <= 6)
                {
                    return (Action)mCurrentActionState;
                }
                else
                {
                    return Action.Unknown;
                }
            }
            set
            {
                mCurrentActionState = (int)value;
                switch(CurrentActionState)
                {
                    case  Action.Uninitialized:
                        break;
                    case  Action.Unknown:
                        break;
                    case  Action.Dying:
                        SpriteInstanceCurrentChainName = "Dying";
                        Drag = 2f;
                        break;
                    case  Action.Hurt:
                        SpriteInstanceCurrentChainName = "Hurt";
                        Drag = 1f;
                        break;
                    case  Action.Running:
                        SpriteInstanceCurrentChainName = "Running";
                        SpriteInstanceAnimate = true;
                        Drag = 0f;
                        break;
                    case  Action.Standing:
                        SpriteInstanceCurrentChainName = "";
                        Drag = 20f;
                        break;
                    case  Action.Drowning:
                        SpriteInstanceCurrentChainName = "Drowning";
                        break;
                }
            }
        }
        public enum Direction
        {
            Uninitialized = 0, //This exists so that the first set call actually does something
            Unknown = 1, //This exists so that if the entity is actually a child entity and has set a child state, you will get this
            MovingLeft = 2, 
            MovingRight = 3
        }
        protected int mCurrentDirectionState = 0;
        public Entities.BaseEntities.BaseEnemy.Direction CurrentDirectionState
        {
            get
            {
                if (mCurrentDirectionState >= 0 && mCurrentDirectionState <= 3)
                {
                    return (Direction)mCurrentDirectionState;
                }
                else
                {
                    return Direction.Unknown;
                }
            }
            set
            {
                mCurrentDirectionState = (int)value;
                switch(CurrentDirectionState)
                {
                    case  Direction.Uninitialized:
                        break;
                    case  Direction.Unknown:
                        break;
                    case  Direction.MovingLeft:
                        SpriteInstanceFlipHorizontal = false;
                        break;
                    case  Direction.MovingRight:
                        SpriteInstanceFlipHorizontal = true;
                        break;
                }
            }
        }
        public enum Status
        {
            Uninitialized = 0, //This exists so that the first set call actually does something
            Unknown = 1, //This exists so that if the entity is actually a child entity and has set a child state, you will get this
            Normal = 2, 
            Frozen = 3, 
            Poisoned = 4, 
            FrozenAndPoisoned = 5
        }
        protected int mCurrentStatusState = 0;
        public Entities.BaseEntities.BaseEnemy.Status CurrentStatusState
        {
            get
            {
                if (mCurrentStatusState >= 0 && mCurrentStatusState <= 5)
                {
                    return (Status)mCurrentStatusState;
                }
                else
                {
                    return Status.Unknown;
                }
            }
            set
            {
                mCurrentStatusState = (int)value;
                switch(CurrentStatusState)
                {
                    case  Status.Uninitialized:
                        break;
                    case  Status.Unknown:
                        break;
                    case  Status.Normal:
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                        SpriteInstanceRed = 1f;
                        SpriteInstanceGreen = 1f;
                        SpriteInstanceBlue = 1f;
                        break;
                    case  Status.Frozen:
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                        SpriteInstanceRed = 0.5f;
                        SpriteInstanceGreen = 0.9f;
                        SpriteInstanceBlue = 1f;
                        break;
                    case  Status.Poisoned:
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                        SpriteInstanceRed = 0.5f;
                        SpriteInstanceGreen = 1f;
                        SpriteInstanceBlue = 0.3f;
                        break;
                    case  Status.FrozenAndPoisoned:
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                        SpriteInstanceRed = 0f;
                        SpriteInstanceGreen = 1f;
                        SpriteInstanceBlue = 0.8f;
                        break;
                }
            }
        }
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AllAssetsSheet;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D animation_sheet;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AllParticles;
        protected static FlatRedBall.Graphics.Particle.EmitterList ParticleEmitterListFile;
        protected static FlatRedBall.Graphics.Animation.AnimationChainList ParticleAnimationsChainList;
        
        protected FlatRedBall.Sprite mSpriteInstance;
        public FlatRedBall.Sprite SpriteInstance
        {
            get
            {
                return mSpriteInstance;
            }
            protected set
            {
                mSpriteInstance = value;
            }
        }
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
        protected FlatRedBall.Sprite ShadowSprite;
        protected FlatRedBall.Sprite LightSprite;
        private AbbatoirIntergrade.Entities.GraphicalElements.ResourceBar HealthBar;
        protected FlatRedBall.Math.Geometry.AxisAlignedRectangle mAxisAlignedRectangleInstance;
        public FlatRedBall.Math.Geometry.AxisAlignedRectangle AxisAlignedRectangleInstance
        {
            get
            {
                return mAxisAlignedRectangleInstance;
            }
            protected set
            {
                mAxisAlignedRectangleInstance = value;
            }
        }
        protected FlatRedBall.Graphics.Particle.Emitter PoisonedParticles;
        protected FlatRedBall.Graphics.Particle.Emitter FrozenParticles;
        private FlatRedBall.Math.Geometry.Circle mSelfCollisionCircle;
        public FlatRedBall.Math.Geometry.Circle SelfCollisionCircle
        {
            get
            {
                return mSelfCollisionCircle;
            }
            private set
            {
                mSelfCollisionCircle = value;
            }
        }
        public bool SpriteInstanceFlipHorizontal
        {
            get
            {
                return SpriteInstance.FlipHorizontal;
            }
            set
            {
                SpriteInstance.FlipHorizontal = value;
            }
        }
        public event System.EventHandler BeforeSpriteInstanceCurrentChainNameSet;
        public event System.EventHandler AfterSpriteInstanceCurrentChainNameSet;
        public virtual string SpriteInstanceCurrentChainName
        {
            get
            {
                return SpriteInstance.CurrentChainName;
            }
            set
            {
                if (BeforeSpriteInstanceCurrentChainNameSet != null)
                {
                    BeforeSpriteInstanceCurrentChainNameSet(this, null);
                }
                SpriteInstance.CurrentChainName = value;
                if (AfterSpriteInstanceCurrentChainNameSet != null)
                {
                    AfterSpriteInstanceCurrentChainNameSet(this, null);
                }
            }
        }
        public virtual float MaximumHealth { get; set; }
        public virtual float Speed { get; set; }
        string mDisplayName = "Not Set";
        public virtual string DisplayName
        {
            set
            {
                mDisplayName = value;
            }
            get
            {
                return mDisplayName;
            }
        }
        bool mIsFlying = false;
        public virtual bool IsFlying
        {
            set
            {
                mIsFlying = value;
            }
            get
            {
                return mIsFlying;
            }
        }
        public virtual bool HasLightSource
        {
            get
            {
                return LightSprite.Visible;
            }
            set
            {
                LightSprite.Visible = value;
            }
        }
        bool mIsJumper = false;
        public virtual bool IsJumper
        {
            set
            {
                mIsJumper = value;
            }
            get
            {
                return mIsJumper;
            }
        }
        public bool HasReachedGoal;
        float mMass = 0.1f;
        public virtual float Mass
        {
            set
            {
                mMass = value;
            }
            get
            {
                return mMass;
            }
        }
        public bool SpriteInstanceAnimate
        {
            get
            {
                return SpriteInstance.Animate;
            }
            set
            {
                SpriteInstance.Animate = value;
            }
        }
        public virtual System.Double EffectivePiercingResist { get; set; }
        public virtual System.Double EffectiveBombardResist { get; set; }
        public virtual System.Double EffectiveChemicalResist { get; set; }
        public virtual System.Double EffectiveFrostResist { get; set; }
        public virtual System.Double EffectiveFireResist { get; set; }
        public virtual System.Double EffectiveElectricResist { get; set; }
        public virtual float BaseHealth { get; set; }
        public virtual float BasePiercingResist { get; set; }
        public virtual float BaseBombardResist { get; set; }
        public virtual float BaseChemicalResist { get; set; }
        public virtual float BaseFrostResist { get; set; }
        public virtual float BaseFireResist { get; set; }
        public virtual float BaseElectricResist { get; set; }
        public virtual float BaseSpeed { get; set; }
        public FlatRedBall.Graphics.ColorOperation SpriteInstanceColorOperation
        {
            get
            {
                return SpriteInstance.ColorOperation;
            }
            set
            {
                SpriteInstance.ColorOperation = value;
            }
        }
        public float SpriteInstanceRed
        {
            get
            {
                return SpriteInstance.Red;
            }
            set
            {
                SpriteInstance.Red = value;
            }
        }
        public float SpriteInstanceGreen
        {
            get
            {
                return SpriteInstance.Green;
            }
            set
            {
                SpriteInstance.Green = value;
            }
        }
        public float SpriteInstanceBlue
        {
            get
            {
                return SpriteInstance.Blue;
            }
            set
            {
                SpriteInstance.Blue = value;
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
        public BaseEnemy () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public BaseEnemy (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public BaseEnemy (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            ShadowSprite = new FlatRedBall.Sprite();
            ShadowSprite.Name = "ShadowSprite";
            HealthBar = new AbbatoirIntergrade.Entities.GraphicalElements.ResourceBar(ContentManagerName, false);
            HealthBar.Name = "HealthBar";
            PoisonedParticles = ParticleEmitterListFile.FindByName("PoisonedParticles").Clone();
            FrozenParticles = ParticleEmitterListFile.FindByName("FrozenParticles").Clone();
            mSelfCollisionCircle = new FlatRedBall.Math.Geometry.Circle();
            mSelfCollisionCircle.Name = "mSelfCollisionCircle";
            
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
            FlatRedBall.SpriteManager.AddToLayer(ShadowSprite, LayerProvidedByContainer);
            HealthBar.ReAddToManagers(LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddEmitter(PoisonedParticles, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddEmitter(FrozenParticles, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mSelfCollisionCircle, LayerProvidedByContainer);
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            PostInitialize();
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            FlatRedBall.SpriteManager.AddToLayer(ShadowSprite, LayerProvidedByContainer);
            HealthBar.AddToManagers(LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddEmitter(PoisonedParticles, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddEmitter(FrozenParticles, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mSelfCollisionCircle, LayerProvidedByContainer);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            mIsPaused = false;
            
            HealthBar.Activity();
            PoisonedParticles.TimedEmit();
            FrozenParticles.TimedEmit();
            CustomActivity();
        }
        public virtual void Destroy () 
        {
            FlatRedBall.SpriteManager.RemovePositionedObject(this);
            
            if (ShadowSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(ShadowSprite);
            }
            if (HealthBar != null)
            {
                HealthBar.Destroy();
                HealthBar.Detach();
            }
            if (PoisonedParticles != null)
            {
                FlatRedBall.SpriteManager.RemoveEmitterOneWay(PoisonedParticles);
            }
            if (FrozenParticles != null)
            {
                FlatRedBall.SpriteManager.RemoveEmitterOneWay(FrozenParticles);
            }
            if (SelfCollisionCircle != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.Remove(SelfCollisionCircle);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            this.AfterSpriteInstanceCurrentChainNameSet += OnAfterSpriteInstanceCurrentChainNameSet;
            if (SpriteInstance!= null)
            {
                if (mSpriteInstance.Parent == null)
                {
                    mSpriteInstance.CopyAbsoluteToRelative();
                    mSpriteInstance.AttachTo(this, false);
                }
                SpriteInstance.Texture = animation_sheet;
                SpriteInstance.TextureScale = 1f;
                SpriteInstance.IgnoreAnimationChainTextureFlip = true;
            }
            if (CircleInstance!= null)
            {
                if (mCircleInstance.Parent == null)
                {
                    mCircleInstance.CopyAbsoluteToRelative();
                    mCircleInstance.AttachTo(this, false);
                }
                CircleInstance.Radius = 0f;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.CopyAbsoluteToRelative();
                ShadowSprite.AttachTo(this, false);
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.X = 0.9120339f;
            }
            else
            {
                ShadowSprite.RelativeX = 0.9120339f;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.Y = 0f;
            }
            else
            {
                ShadowSprite.RelativeY = 0f;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.Z = -1f;
            }
            else
            {
                ShadowSprite.RelativeZ = -1f;
            }
            ShadowSprite.Texture = AllParticles;
            ShadowSprite.LeftTexturePixel = 1019f;
            ShadowSprite.RightTexturePixel = 1072f;
            ShadowSprite.TopTexturePixel = 1895f;
            ShadowSprite.BottomTexturePixel = 1948f;
            ShadowSprite.TextureScale = 1f;
            #if FRB_MDX
            ShadowSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            ShadowSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            ShadowSprite.Alpha = 0.3f;
            if (LightSprite!= null)
            {
                if (LightSprite.Parent == null)
                {
                    LightSprite.CopyAbsoluteToRelative();
                    LightSprite.AttachTo(this, false);
                }
                LightSprite.Texture = AllAssetsSheet;
                LightSprite.LeftTexturePixel = 1792f;
                LightSprite.RightTexturePixel = 2048f;
                LightSprite.TopTexturePixel = 1792f;
                LightSprite.BottomTexturePixel = 2048f;
                LightSprite.TextureScale = 1f;
                LightSprite.Visible = false;
                #if FRB_MDX
                LightSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
                #else
                LightSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                #endif
            }
            if (HealthBar.Parent == null)
            {
                HealthBar.CopyAbsoluteToRelative();
                HealthBar.AttachTo(this, false);
            }
            if (HealthBar.Parent == null)
            {
                HealthBar.Y = 200f;
            }
            else
            {
                HealthBar.RelativeY = 200f;
            }
            HealthBar.BarSpriteRed = 0f;
            HealthBar.BarSpriteGreen = 1f;
            HealthBar.BarSpriteBlue = 0f;
            if (AxisAlignedRectangleInstance!= null)
            {
                if (mAxisAlignedRectangleInstance.Parent == null)
                {
                    mAxisAlignedRectangleInstance.CopyAbsoluteToRelative();
                    mAxisAlignedRectangleInstance.AttachTo(this, false);
                }
                AxisAlignedRectangleInstance.Width = 0f;
                AxisAlignedRectangleInstance.Height = 0f;
            }
            if (PoisonedParticles.Parent == null)
            {
                PoisonedParticles.CopyAbsoluteToRelative();
                PoisonedParticles.AttachTo(this, false);
            }
            if (FrozenParticles.Parent == null)
            {
                FrozenParticles.CopyAbsoluteToRelative();
                FrozenParticles.AttachTo(this, false);
            }
            if (mSelfCollisionCircle.Parent == null)
            {
                mSelfCollisionCircle.CopyAbsoluteToRelative();
                mSelfCollisionCircle.AttachTo(this, false);
            }
            SelfCollisionCircle.Radius = 16f;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            mGeneratedCollision.Circles.AddOneWay(mCircleInstance);
            mGeneratedCollision.AxisAlignedRectangles.AddOneWay(mAxisAlignedRectangleInstance);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (ShadowSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(ShadowSprite);
            }
            HealthBar.RemoveFromManagers();
            if (PoisonedParticles != null)
            {
                FlatRedBall.SpriteManager.RemoveEmitterOneWay(PoisonedParticles);
            }
            if (FrozenParticles != null)
            {
                FlatRedBall.SpriteManager.RemoveEmitterOneWay(FrozenParticles);
            }
            if (SelfCollisionCircle != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(SelfCollisionCircle);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                HealthBar.AssignCustomVariables(true);
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.X = 0.9120339f;
            }
            else
            {
                ShadowSprite.RelativeX = 0.9120339f;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.Y = 0f;
            }
            else
            {
                ShadowSprite.RelativeY = 0f;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.Z = -1f;
            }
            else
            {
                ShadowSprite.RelativeZ = -1f;
            }
            ShadowSprite.Texture = AllParticles;
            ShadowSprite.LeftTexturePixel = 1019f;
            ShadowSprite.RightTexturePixel = 1072f;
            ShadowSprite.TopTexturePixel = 1895f;
            ShadowSprite.BottomTexturePixel = 1948f;
            ShadowSprite.TextureScale = 1f;
            #if FRB_MDX
            ShadowSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            ShadowSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            ShadowSprite.Alpha = 0.3f;
            if (HealthBar.Parent == null)
            {
                HealthBar.Y = 200f;
            }
            else
            {
                HealthBar.RelativeY = 200f;
            }
            HealthBar.BarSpriteRed = 0f;
            HealthBar.BarSpriteGreen = 1f;
            HealthBar.BarSpriteBlue = 0f;
            SelfCollisionCircle.Radius = 16f;
            if (Parent == null)
            {
                Z = 1f;
            }
            else if (Parent is FlatRedBall.Camera)
            {
                RelativeZ = 1f - 40.0f;
            }
            else
            {
                RelativeZ = 1f;
            }
            SpriteInstanceFlipHorizontal = false;
            DisplayName = "Not Set";
            IsFlying = false;
            HasLightSource = false;
            IsJumper = false;
            Mass = 0.1f;
            SpriteInstanceAnimate = true;
            Drag = 0f;
            SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
            SpriteInstanceRed = 0f;
            SpriteInstanceGreen = 0f;
            SpriteInstanceBlue = 0f;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            }
            if (CircleInstance != null)
            {
            }
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(ShadowSprite);
            if (LightSprite != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(LightSprite);
            }
            HealthBar.ConvertToManuallyUpdated();
            if (AxisAlignedRectangleInstance != null)
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BaseEnemyStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                AllAssetsSheet = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/gamescreen/allassetssheet.png", ContentManagerName);
                animation_sheet = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/gamescreen/animation_sheet.png", ContentManagerName);
                AllParticles = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/projectiles/allparticles.png", ContentManagerName);
                ParticleEmitterListFile = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Particle.EmitterList>(@"content/entities/baseentities/baseenemy/particleemitterlistfile.emix", ContentManagerName);
                ParticleAnimationsChainList = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/baseentities/baseenemy/particleanimationschainlist.achx", ContentManagerName);
            }
            AbbatoirIntergrade.Entities.GraphicalElements.ResourceBar.LoadStaticContent(contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }
        public static void UnloadStaticContent () 
        {
            // Intentionally left blank because this element uses global content, so it should never be unloaded
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (Action stateToInterpolateTo, double secondsToTake) 
        {
            switch(stateToInterpolateTo)
            {
                case  Action.Dying:
                    break;
                case  Action.Hurt:
                    break;
                case  Action.Running:
                    break;
                case  Action.Standing:
                    break;
                case  Action.Drowning:
                    break;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<Action>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (Action stateToStop) 
        {
            switch(stateToStop)
            {
                case  Action.Dying:
                    break;
                case  Action.Hurt:
                    break;
                case  Action.Running:
                    break;
                case  Action.Standing:
                    break;
                case  Action.Drowning:
                    break;
            }
            CurrentActionState = stateToStop;
        }
        public void InterpolateBetween (Action firstState, Action secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setDrag = true;
            float DragFirstValue= 0;
            float DragSecondValue= 0;
            switch(firstState)
            {
                case  Action.Dying:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Dying";
                    }
                    DragFirstValue = 2f;
                    break;
                case  Action.Hurt:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Hurt";
                    }
                    DragFirstValue = 1f;
                    break;
                case  Action.Running:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Running";
                    }
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceAnimate = true;
                    }
                    DragFirstValue = 0f;
                    break;
                case  Action.Standing:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "";
                    }
                    DragFirstValue = 20f;
                    break;
                case  Action.Drowning:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Drowning";
                    }
                    break;
            }
            switch(secondState)
            {
                case  Action.Dying:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Dying";
                    }
                    DragSecondValue = 2f;
                    break;
                case  Action.Hurt:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Hurt";
                    }
                    DragSecondValue = 1f;
                    break;
                case  Action.Running:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Running";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceAnimate = true;
                    }
                    DragSecondValue = 0f;
                    break;
                case  Action.Standing:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "";
                    }
                    DragSecondValue = 20f;
                    break;
                case  Action.Drowning:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Drowning";
                    }
                    break;
            }
            if (setDrag)
            {
                Drag = DragFirstValue * (1 - interpolationValue) + DragSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentActionState = (int)firstState;
            }
            else
            {
                mCurrentActionState = (int)secondState;
            }
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (Direction stateToInterpolateTo, double secondsToTake) 
        {
            switch(stateToInterpolateTo)
            {
                case  Direction.MovingLeft:
                    break;
                case  Direction.MovingRight:
                    break;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<Direction>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (Direction stateToStop) 
        {
            switch(stateToStop)
            {
                case  Direction.MovingLeft:
                    break;
                case  Direction.MovingRight:
                    break;
            }
            CurrentDirectionState = stateToStop;
        }
        public void InterpolateBetween (Direction firstState, Direction secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            switch(firstState)
            {
                case  Direction.MovingLeft:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceFlipHorizontal = false;
                    }
                    break;
                case  Direction.MovingRight:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceFlipHorizontal = true;
                    }
                    break;
            }
            switch(secondState)
            {
                case  Direction.MovingLeft:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceFlipHorizontal = false;
                    }
                    break;
                case  Direction.MovingRight:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceFlipHorizontal = true;
                    }
                    break;
            }
            if (interpolationValue < 1)
            {
                mCurrentDirectionState = (int)firstState;
            }
            else
            {
                mCurrentDirectionState = (int)secondState;
            }
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (Status stateToInterpolateTo, double secondsToTake) 
        {
            switch(stateToInterpolateTo)
            {
                case  Status.Normal:
                    SpriteInstance.RedRate = (1f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (1f - SpriteInstance.Green) / (float)secondsToTake;
                    SpriteInstance.BlueRate = (1f - SpriteInstance.Blue) / (float)secondsToTake;
                    break;
                case  Status.Frozen:
                    SpriteInstance.RedRate = (0.5f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (0.9f - SpriteInstance.Green) / (float)secondsToTake;
                    SpriteInstance.BlueRate = (1f - SpriteInstance.Blue) / (float)secondsToTake;
                    break;
                case  Status.Poisoned:
                    SpriteInstance.RedRate = (0.5f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (1f - SpriteInstance.Green) / (float)secondsToTake;
                    SpriteInstance.BlueRate = (0.3f - SpriteInstance.Blue) / (float)secondsToTake;
                    break;
                case  Status.FrozenAndPoisoned:
                    SpriteInstance.RedRate = (0f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (1f - SpriteInstance.Green) / (float)secondsToTake;
                    SpriteInstance.BlueRate = (0.8f - SpriteInstance.Blue) / (float)secondsToTake;
                    break;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<Status>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (Status stateToStop) 
        {
            switch(stateToStop)
            {
                case  Status.Normal:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    SpriteInstance.BlueRate =  0;
                    break;
                case  Status.Frozen:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    SpriteInstance.BlueRate =  0;
                    break;
                case  Status.Poisoned:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    SpriteInstance.BlueRate =  0;
                    break;
                case  Status.FrozenAndPoisoned:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    SpriteInstance.BlueRate =  0;
                    break;
            }
            CurrentStatusState = stateToStop;
        }
        public void InterpolateBetween (Status firstState, Status secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setSpriteInstanceRed = true;
            float SpriteInstanceRedFirstValue= 0;
            float SpriteInstanceRedSecondValue= 0;
            bool setSpriteInstanceGreen = true;
            float SpriteInstanceGreenFirstValue= 0;
            float SpriteInstanceGreenSecondValue= 0;
            bool setSpriteInstanceBlue = true;
            float SpriteInstanceBlueFirstValue= 0;
            float SpriteInstanceBlueSecondValue= 0;
            switch(firstState)
            {
                case  Status.Normal:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                    }
                    SpriteInstanceRedFirstValue = 1f;
                    SpriteInstanceGreenFirstValue = 1f;
                    SpriteInstanceBlueFirstValue = 1f;
                    break;
                case  Status.Frozen:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    SpriteInstanceRedFirstValue = 0.5f;
                    SpriteInstanceGreenFirstValue = 0.9f;
                    SpriteInstanceBlueFirstValue = 1f;
                    break;
                case  Status.Poisoned:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    SpriteInstanceRedFirstValue = 0.5f;
                    SpriteInstanceGreenFirstValue = 1f;
                    SpriteInstanceBlueFirstValue = 0.3f;
                    break;
                case  Status.FrozenAndPoisoned:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    SpriteInstanceRedFirstValue = 0f;
                    SpriteInstanceGreenFirstValue = 1f;
                    SpriteInstanceBlueFirstValue = 0.8f;
                    break;
            }
            switch(secondState)
            {
                case  Status.Normal:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                    }
                    SpriteInstanceRedSecondValue = 1f;
                    SpriteInstanceGreenSecondValue = 1f;
                    SpriteInstanceBlueSecondValue = 1f;
                    break;
                case  Status.Frozen:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    SpriteInstanceRedSecondValue = 0.5f;
                    SpriteInstanceGreenSecondValue = 0.9f;
                    SpriteInstanceBlueSecondValue = 1f;
                    break;
                case  Status.Poisoned:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    SpriteInstanceRedSecondValue = 0.5f;
                    SpriteInstanceGreenSecondValue = 1f;
                    SpriteInstanceBlueSecondValue = 0.3f;
                    break;
                case  Status.FrozenAndPoisoned:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    SpriteInstanceRedSecondValue = 0f;
                    SpriteInstanceGreenSecondValue = 1f;
                    SpriteInstanceBlueSecondValue = 0.8f;
                    break;
            }
            if (setSpriteInstanceRed)
            {
                SpriteInstanceRed = SpriteInstanceRedFirstValue * (1 - interpolationValue) + SpriteInstanceRedSecondValue * interpolationValue;
            }
            if (setSpriteInstanceGreen)
            {
                SpriteInstanceGreen = SpriteInstanceGreenFirstValue * (1 - interpolationValue) + SpriteInstanceGreenSecondValue * interpolationValue;
            }
            if (setSpriteInstanceBlue)
            {
                SpriteInstanceBlue = SpriteInstanceBlueFirstValue * (1 - interpolationValue) + SpriteInstanceBlueSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentStatusState = (int)firstState;
            }
            else
            {
                mCurrentStatusState = (int)secondState;
            }
        }
        public static void PreloadStateContent (Action state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            switch(state)
            {
                case  Action.Dying:
                    {
                        object throwaway = "Dying";
                    }
                    break;
                case  Action.Hurt:
                    {
                        object throwaway = "Hurt";
                    }
                    break;
                case  Action.Running:
                    {
                        object throwaway = "Running";
                    }
                    break;
                case  Action.Standing:
                    {
                        object throwaway = "";
                    }
                    break;
                case  Action.Drowning:
                    {
                        object throwaway = "Drowning";
                    }
                    break;
            }
        }
        public static void PreloadStateContent (Direction state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            switch(state)
            {
                case  Direction.MovingLeft:
                    break;
                case  Direction.MovingRight:
                    break;
            }
        }
        public static void PreloadStateContent (Status state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            switch(state)
            {
                case  Status.Normal:
                    break;
                case  Status.Frozen:
                    break;
                case  Status.Poisoned:
                    break;
                case  Status.FrozenAndPoisoned:
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
                case  "animation_sheet":
                    return animation_sheet;
                case  "AllParticles":
                    return AllParticles;
                case  "ParticleEmitterListFile":
                    return ParticleEmitterListFile;
                case  "ParticleAnimationsChainList":
                    return ParticleAnimationsChainList;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
                case  "animation_sheet":
                    return animation_sheet;
                case  "AllParticles":
                    return AllParticles;
                case  "ParticleEmitterListFile":
                    return ParticleEmitterListFile;
                case  "ParticleAnimationsChainList":
                    return ParticleAnimationsChainList;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
                case  "animation_sheet":
                    return animation_sheet;
                case  "AllParticles":
                    return AllParticles;
                case  "ParticleEmitterListFile":
                    return ParticleEmitterListFile;
                case  "ParticleAnimationsChainList":
                    return ParticleAnimationsChainList;
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
            if (SpriteInstance.Alpha != 0 && SpriteInstance.AbsoluteVisible && cursor.IsOn3D(SpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (LightSprite.Alpha != 0 && LightSprite.AbsoluteVisible && cursor.IsOn3D(LightSprite, LayerProvidedByContainer))
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
            if (SpriteInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            }
            if (CircleInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(CircleInstance);
            }
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(ShadowSprite);
            if (LightSprite != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightSprite);
            }
            HealthBar.SetToIgnorePausing();
            if (AxisAlignedRectangleInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(AxisAlignedRectangleInstance);
            }
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PoisonedParticles);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(FrozenParticles);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SelfCollisionCircle);
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
                layerToRemoveFrom.Remove(CircleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(CircleInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(ShadowSprite);
            }
            FlatRedBall.SpriteManager.AddToLayer(ShadowSprite, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(LightSprite);
            }
            FlatRedBall.SpriteManager.AddToLayer(LightSprite, layerToMoveTo);
            HealthBar.MoveToLayer(layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(AxisAlignedRectangleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(AxisAlignedRectangleInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(SelfCollisionCircle);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(SelfCollisionCircle, layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
    }
    public static class BaseEnemyExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<BaseEnemy> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
