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
using FlatRedBall.Math.Geometry;
using AbbatoirIntergrade.Entities.GraphicalElements;
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
        public class Action
        {
            public float X;
            public float Y;
            public float Z;
            public bool SpriteInstanceFlipHorizontal;
            public string SpriteInstanceCurrentChainName;
            public float MaximumHealth;
            public float EffectiveSpeed;
            public string DisplayName;
            public bool IsFlying;
            public bool HasLightSource;
            public bool IsJumper;
            public bool HasReachedGoal;
            public float Mass;
            public bool SpriteInstanceAnimate;
            public float Drag;
            public System.Double EffectivePiercingResist;
            public System.Double EffectiveBombardResist;
            public System.Double EffectiveChemicalResist;
            public System.Double EffectiveFrostResist;
            public System.Double EffectiveFireResist;
            public System.Double EffectiveElectricResist;
            public float BaseHealth;
            public float BasePiercingResist;
            public float BaseBombardResist;
            public float BaseChemicalResist;
            public float BaseFrostResist;
            public float BaseFireResist;
            public float BaseElectricResist;
            public float BaseSpeed;
            public FlatRedBall.Graphics.ColorOperation SpriteInstanceColorOperation;
            public float SpriteInstanceRed;
            public float SpriteInstanceGreen;
            public float SpriteInstanceBlue;
            public bool FrozenParticlesTimedEmission;
            public bool PoisonedParticlesTimedEmission;
            public bool SmokeParticlesTimedEmission;
            public bool StunParticlesTimedEmission;
            public static Action Dying = new Action()
            {
                SpriteInstanceCurrentChainName = "Dying",
                Drag = 2f,
            }
            ;
            public static Action Hurt = new Action()
            {
                SpriteInstanceCurrentChainName = "Hurt",
                Drag = 1f,
            }
            ;
            public static Action Running = new Action()
            {
                SpriteInstanceCurrentChainName = "Running",
                SpriteInstanceAnimate = true,
                Drag = 0f,
            }
            ;
            public static Action Standing = new Action()
            {
                SpriteInstanceCurrentChainName = "",
                Drag = 20f,
            }
            ;
            public static Action Drowning = new Action()
            {
                SpriteInstanceCurrentChainName = "Drowning",
            }
            ;
        }
        private Action mCurrentActionState = null;
        public Entities.BaseEntities.BaseEnemy.Action CurrentActionState
        {
            get
            {
                return mCurrentActionState;
            }
            set
            {
                mCurrentActionState = value;
                if (CurrentActionState == Action.Dying)
                {
                    SpriteInstanceCurrentChainName = "Dying";
                    Drag = 2f;
                }
                else if (CurrentActionState == Action.Hurt)
                {
                    SpriteInstanceCurrentChainName = "Hurt";
                    Drag = 1f;
                }
                else if (CurrentActionState == Action.Running)
                {
                    SpriteInstanceCurrentChainName = "Running";
                    SpriteInstanceAnimate = true;
                    Drag = 0f;
                }
                else if (CurrentActionState == Action.Standing)
                {
                    SpriteInstanceCurrentChainName = "";
                    Drag = 20f;
                }
                else if (CurrentActionState == Action.Drowning)
                {
                    SpriteInstanceCurrentChainName = "Drowning";
                }
            }
        }
        public class Direction
        {
            public float X;
            public float Y;
            public float Z;
            public bool SpriteInstanceFlipHorizontal;
            public string SpriteInstanceCurrentChainName;
            public float MaximumHealth;
            public float EffectiveSpeed;
            public string DisplayName;
            public bool IsFlying;
            public bool HasLightSource;
            public bool IsJumper;
            public bool HasReachedGoal;
            public float Mass;
            public bool SpriteInstanceAnimate;
            public float Drag;
            public System.Double EffectivePiercingResist;
            public System.Double EffectiveBombardResist;
            public System.Double EffectiveChemicalResist;
            public System.Double EffectiveFrostResist;
            public System.Double EffectiveFireResist;
            public System.Double EffectiveElectricResist;
            public float BaseHealth;
            public float BasePiercingResist;
            public float BaseBombardResist;
            public float BaseChemicalResist;
            public float BaseFrostResist;
            public float BaseFireResist;
            public float BaseElectricResist;
            public float BaseSpeed;
            public FlatRedBall.Graphics.ColorOperation SpriteInstanceColorOperation;
            public float SpriteInstanceRed;
            public float SpriteInstanceGreen;
            public float SpriteInstanceBlue;
            public bool FrozenParticlesTimedEmission;
            public bool PoisonedParticlesTimedEmission;
            public bool SmokeParticlesTimedEmission;
            public bool StunParticlesTimedEmission;
            public static Direction MovingLeft = new Direction()
            {
                SpriteInstanceFlipHorizontal = false,
            }
            ;
            public static Direction MovingRight = new Direction()
            {
                SpriteInstanceFlipHorizontal = true,
            }
            ;
        }
        private Direction mCurrentDirectionState = null;
        public Entities.BaseEntities.BaseEnemy.Direction CurrentDirectionState
        {
            get
            {
                return mCurrentDirectionState;
            }
            set
            {
                mCurrentDirectionState = value;
                if (CurrentDirectionState == Direction.MovingLeft)
                {
                    SpriteInstanceFlipHorizontal = false;
                }
                else if (CurrentDirectionState == Direction.MovingRight)
                {
                    SpriteInstanceFlipHorizontal = true;
                }
            }
        }
        public class Status
        {
            public float X;
            public float Y;
            public float Z;
            public bool SpriteInstanceFlipHorizontal;
            public string SpriteInstanceCurrentChainName;
            public float MaximumHealth;
            public float EffectiveSpeed;
            public string DisplayName;
            public bool IsFlying;
            public bool HasLightSource;
            public bool IsJumper;
            public bool HasReachedGoal;
            public float Mass;
            public bool SpriteInstanceAnimate;
            public float Drag;
            public System.Double EffectivePiercingResist;
            public System.Double EffectiveBombardResist;
            public System.Double EffectiveChemicalResist;
            public System.Double EffectiveFrostResist;
            public System.Double EffectiveFireResist;
            public System.Double EffectiveElectricResist;
            public float BaseHealth;
            public float BasePiercingResist;
            public float BaseBombardResist;
            public float BaseChemicalResist;
            public float BaseFrostResist;
            public float BaseFireResist;
            public float BaseElectricResist;
            public float BaseSpeed;
            public FlatRedBall.Graphics.ColorOperation SpriteInstanceColorOperation;
            public float SpriteInstanceRed;
            public float SpriteInstanceGreen;
            public float SpriteInstanceBlue;
            public bool FrozenParticlesTimedEmission;
            public bool PoisonedParticlesTimedEmission;
            public bool SmokeParticlesTimedEmission;
            public bool StunParticlesTimedEmission;
            public static Status Normal = new Status()
            {
                SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture,
                SpriteInstanceRed = 1f,
                SpriteInstanceGreen = 1f,
                SpriteInstanceBlue = 1f,
                FrozenParticlesTimedEmission = false,
                PoisonedParticlesTimedEmission = false,
                SmokeParticlesTimedEmission = false,
                StunParticlesTimedEmission = false,
            }
            ;
            public static Status Frozen = new Status()
            {
                SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate,
                SpriteInstanceRed = 0.5f,
                SpriteInstanceGreen = 0.9f,
                SpriteInstanceBlue = 1f,
                FrozenParticlesTimedEmission = true,
                PoisonedParticlesTimedEmission = false,
                SmokeParticlesTimedEmission = false,
                StunParticlesTimedEmission = false,
            }
            ;
            public static Status Poisoned = new Status()
            {
                SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate,
                SpriteInstanceRed = 0.5f,
                SpriteInstanceGreen = 1f,
                SpriteInstanceBlue = 0.3f,
                FrozenParticlesTimedEmission = false,
                PoisonedParticlesTimedEmission = true,
                SmokeParticlesTimedEmission = false,
                StunParticlesTimedEmission = false,
            }
            ;
            public static Status FrozenAndPoisoned = new Status()
            {
                SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate,
                SpriteInstanceRed = 0f,
                SpriteInstanceGreen = 1f,
                SpriteInstanceBlue = 0.8f,
                FrozenParticlesTimedEmission = true,
                PoisonedParticlesTimedEmission = true,
                SmokeParticlesTimedEmission = false,
                StunParticlesTimedEmission = false,
            }
            ;
            public static Status Burning = new Status()
            {
                SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate,
                SpriteInstanceRed = 0.3f,
                SpriteInstanceGreen = 0.1f,
                SpriteInstanceBlue = 0.1f,
                FrozenParticlesTimedEmission = false,
                PoisonedParticlesTimedEmission = false,
                SmokeParticlesTimedEmission = true,
                StunParticlesTimedEmission = false,
            }
            ;
            public static Status BurningAndPoisoned = new Status()
            {
                SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate,
                SpriteInstanceRed = 0.1f,
                SpriteInstanceGreen = 0.4f,
                SpriteInstanceBlue = 0f,
                FrozenParticlesTimedEmission = false,
                PoisonedParticlesTimedEmission = true,
                SmokeParticlesTimedEmission = true,
                StunParticlesTimedEmission = false,
            }
            ;
        }
        private Status mCurrentStatusState = null;
        public Entities.BaseEntities.BaseEnemy.Status CurrentStatusState
        {
            get
            {
                return mCurrentStatusState;
            }
            set
            {
                mCurrentStatusState = value;
                if (CurrentStatusState == Status.Normal)
                {
                    SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                    SpriteInstanceRed = 1f;
                    SpriteInstanceGreen = 1f;
                    SpriteInstanceBlue = 1f;
                    FrozenParticlesTimedEmission = false;
                    PoisonedParticlesTimedEmission = false;
                    SmokeParticlesTimedEmission = false;
                    StunParticlesTimedEmission = false;
                }
                else if (CurrentStatusState == Status.Frozen)
                {
                    SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    SpriteInstanceRed = 0.5f;
                    SpriteInstanceGreen = 0.9f;
                    SpriteInstanceBlue = 1f;
                    FrozenParticlesTimedEmission = true;
                    PoisonedParticlesTimedEmission = false;
                    SmokeParticlesTimedEmission = false;
                    StunParticlesTimedEmission = false;
                }
                else if (CurrentStatusState == Status.Poisoned)
                {
                    SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    SpriteInstanceRed = 0.5f;
                    SpriteInstanceGreen = 1f;
                    SpriteInstanceBlue = 0.3f;
                    FrozenParticlesTimedEmission = false;
                    PoisonedParticlesTimedEmission = true;
                    SmokeParticlesTimedEmission = false;
                    StunParticlesTimedEmission = false;
                }
                else if (CurrentStatusState == Status.FrozenAndPoisoned)
                {
                    SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    SpriteInstanceRed = 0f;
                    SpriteInstanceGreen = 1f;
                    SpriteInstanceBlue = 0.8f;
                    FrozenParticlesTimedEmission = true;
                    PoisonedParticlesTimedEmission = true;
                    SmokeParticlesTimedEmission = false;
                    StunParticlesTimedEmission = false;
                }
                else if (CurrentStatusState == Status.Burning)
                {
                    SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    SpriteInstanceRed = 0.3f;
                    SpriteInstanceGreen = 0.1f;
                    SpriteInstanceBlue = 0.1f;
                    FrozenParticlesTimedEmission = false;
                    PoisonedParticlesTimedEmission = false;
                    SmokeParticlesTimedEmission = true;
                    StunParticlesTimedEmission = false;
                }
                else if (CurrentStatusState == Status.BurningAndPoisoned)
                {
                    SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    SpriteInstanceRed = 0.1f;
                    SpriteInstanceGreen = 0.4f;
                    SpriteInstanceBlue = 0f;
                    FrozenParticlesTimedEmission = false;
                    PoisonedParticlesTimedEmission = true;
                    SmokeParticlesTimedEmission = true;
                    StunParticlesTimedEmission = false;
                }
            }
        }
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AllAssetsSheet;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AllParticles;
        protected static FlatRedBall.Graphics.Particle.EmitterList ParticleEmitterListFile;
        protected static FlatRedBall.Graphics.Animation.AnimationChainList ParticleAnimationsChainList;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect DrowningSound;
        
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
        protected FlatRedBall.Graphics.Particle.Emitter SmokeParticles;
        protected FlatRedBall.Graphics.Particle.Emitter StunParticles;
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
        public float MaximumHealth;
        public float EffectiveSpeed;
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
        public System.Double EffectivePiercingResist;
        public System.Double EffectiveBombardResist;
        public System.Double EffectiveChemicalResist;
        public System.Double EffectiveFrostResist;
        public System.Double EffectiveFireResist;
        public System.Double EffectiveElectricResist;
        public float BaseHealth;
        public float BasePiercingResist;
        public float BaseBombardResist;
        public float BaseChemicalResist;
        public float BaseFrostResist;
        public float BaseFireResist;
        public float BaseElectricResist;
        public float BaseSpeed;
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
        public bool FrozenParticlesTimedEmission
        {
            get
            {
                return FrozenParticles.TimedEmission;
            }
            set
            {
                FrozenParticles.TimedEmission = value;
            }
        }
        public bool PoisonedParticlesTimedEmission
        {
            get
            {
                return PoisonedParticles.TimedEmission;
            }
            set
            {
                PoisonedParticles.TimedEmission = value;
            }
        }
        public bool SmokeParticlesTimedEmission
        {
            get
            {
                return SmokeParticles.TimedEmission;
            }
            set
            {
                SmokeParticles.TimedEmission = value;
            }
        }
        public bool StunParticlesTimedEmission
        {
            get
            {
                return StunParticles.TimedEmission;
            }
            set
            {
                StunParticles.TimedEmission = value;
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
            // Not instantiating for Sprite mSpriteInstance in Entities\BaseEntities\BaseEnemy because properties on the object prevent it
            // Not instantiating for Circle mCircleInstance in Entities\BaseEntities\BaseEnemy because properties on the object prevent it
            ShadowSprite = new FlatRedBall.Sprite();
            ShadowSprite.Name = "ShadowSprite";
            // Not instantiating for Sprite LightSprite in Entities\BaseEntities\BaseEnemy because properties on the object prevent it
            HealthBar = new AbbatoirIntergrade.Entities.GraphicalElements.ResourceBar(ContentManagerName, false);
            HealthBar.Name = "HealthBar";
            // Not instantiating for AxisAlignedRectangle mAxisAlignedRectangleInstance in Entities\BaseEntities\BaseEnemy because properties on the object prevent it
            PoisonedParticles = ParticleEmitterListFile.FindByName("PoisonedParticles").Clone();
            FrozenParticles = ParticleEmitterListFile.FindByName("FrozenParticles").Clone();
            mSelfCollisionCircle = new FlatRedBall.Math.Geometry.Circle();
            mSelfCollisionCircle.Name = "mSelfCollisionCircle";
            SmokeParticles = ParticleEmitterListFile.FindByName("SmokeParticles").Clone();
            StunParticles = ParticleEmitterListFile.FindByName("StunParticles").Clone();
            
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
            FlatRedBall.SpriteManager.AddEmitter(SmokeParticles, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddEmitter(StunParticles, LayerProvidedByContainer);
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
            FlatRedBall.SpriteManager.AddEmitter(SmokeParticles, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddEmitter(StunParticles, LayerProvidedByContainer);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            mIsPaused = false;
            
            HealthBar.Activity();
            PoisonedParticles.TimedEmit();
            FrozenParticles.TimedEmit();
            SmokeParticles.TimedEmit();
            StunParticles.TimedEmit();
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
            if (SmokeParticles != null)
            {
                FlatRedBall.SpriteManager.RemoveEmitterOneWay(SmokeParticles);
            }
            if (StunParticles != null)
            {
                FlatRedBall.SpriteManager.RemoveEmitterOneWay(StunParticles);
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
                SpriteInstance.TextureScale = 1f;
                SpriteInstance.IgnoreAnimationChainTextureFlip = true;
                #if FRB_MDX
                SpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Texture;
                #else
                SpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                #endif
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
                ShadowSprite.X = 0f;
            }
            else
            {
                ShadowSprite.RelativeX = 0f;
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
            if (SmokeParticles.Parent == null)
            {
                SmokeParticles.CopyAbsoluteToRelative();
                SmokeParticles.AttachTo(this, false);
            }
            if (StunParticles.Parent == null)
            {
                StunParticles.CopyAbsoluteToRelative();
                StunParticles.AttachTo(this, false);
            }
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
            if (SmokeParticles != null)
            {
                FlatRedBall.SpriteManager.RemoveEmitterOneWay(SmokeParticles);
            }
            if (StunParticles != null)
            {
                FlatRedBall.SpriteManager.RemoveEmitterOneWay(StunParticles);
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
                ShadowSprite.X = 0f;
            }
            else
            {
                ShadowSprite.RelativeX = 0f;
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
                AllParticles = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/projectiles/allparticles.png", ContentManagerName);
                ParticleEmitterListFile = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Particle.EmitterList>(@"content/entities/baseentities/baseenemy/particleemitterlistfile.emix", ContentManagerName);
                ParticleAnimationsChainList = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/baseentities/baseenemy/particleanimationschainlist.achx", ContentManagerName);
                DrowningSound = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/baseentities/baseenemy/drowningsound", ContentManagerName);
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
            if (stateToInterpolateTo == Action.Dying)
            {
            }
            else if (stateToInterpolateTo == Action.Hurt)
            {
            }
            else if (stateToInterpolateTo == Action.Running)
            {
            }
            else if (stateToInterpolateTo == Action.Standing)
            {
            }
            else if (stateToInterpolateTo == Action.Drowning)
            {
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<Action>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (Action stateToStop) 
        {
            if (stateToStop == Action.Dying)
            {
            }
            else if (stateToStop == Action.Hurt)
            {
            }
            else if (stateToStop == Action.Running)
            {
            }
            else if (stateToStop == Action.Standing)
            {
            }
            else if (stateToStop == Action.Drowning)
            {
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
            if (firstState == Action.Dying)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceCurrentChainName = "Dying";
                }
                DragFirstValue = 2f;
            }
            else if (firstState == Action.Hurt)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceCurrentChainName = "Hurt";
                }
                DragFirstValue = 1f;
            }
            else if (firstState == Action.Running)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceCurrentChainName = "Running";
                }
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceAnimate = true;
                }
                DragFirstValue = 0f;
            }
            else if (firstState == Action.Standing)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceCurrentChainName = "";
                }
                DragFirstValue = 20f;
            }
            else if (firstState == Action.Drowning)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceCurrentChainName = "Drowning";
                }
            }
            if (secondState == Action.Dying)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceCurrentChainName = "Dying";
                }
                DragSecondValue = 2f;
            }
            else if (secondState == Action.Hurt)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceCurrentChainName = "Hurt";
                }
                DragSecondValue = 1f;
            }
            else if (secondState == Action.Running)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceCurrentChainName = "Running";
                }
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceAnimate = true;
                }
                DragSecondValue = 0f;
            }
            else if (secondState == Action.Standing)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceCurrentChainName = "";
                }
                DragSecondValue = 20f;
            }
            else if (secondState == Action.Drowning)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceCurrentChainName = "Drowning";
                }
            }
            if (setDrag)
            {
                Drag = DragFirstValue * (1 - interpolationValue) + DragSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentActionState = firstState;
            }
            else
            {
                mCurrentActionState = secondState;
            }
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (Direction stateToInterpolateTo, double secondsToTake) 
        {
            if (stateToInterpolateTo == Direction.MovingLeft)
            {
            }
            else if (stateToInterpolateTo == Direction.MovingRight)
            {
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<Direction>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (Direction stateToStop) 
        {
            if (stateToStop == Direction.MovingLeft)
            {
            }
            else if (stateToStop == Direction.MovingRight)
            {
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
            if (firstState == Direction.MovingLeft)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceFlipHorizontal = false;
                }
            }
            else if (firstState == Direction.MovingRight)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceFlipHorizontal = true;
                }
            }
            if (secondState == Direction.MovingLeft)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceFlipHorizontal = false;
                }
            }
            else if (secondState == Direction.MovingRight)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceFlipHorizontal = true;
                }
            }
            if (interpolationValue < 1)
            {
                mCurrentDirectionState = firstState;
            }
            else
            {
                mCurrentDirectionState = secondState;
            }
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (Status stateToInterpolateTo, double secondsToTake) 
        {
            if (stateToInterpolateTo == Status.Normal)
            {
                SpriteInstance.RedRate = (1f - SpriteInstance.Red) / (float)secondsToTake;
                SpriteInstance.GreenRate = (1f - SpriteInstance.Green) / (float)secondsToTake;
                SpriteInstance.BlueRate = (1f - SpriteInstance.Blue) / (float)secondsToTake;
            }
            else if (stateToInterpolateTo == Status.Frozen)
            {
                SpriteInstance.RedRate = (0.5f - SpriteInstance.Red) / (float)secondsToTake;
                SpriteInstance.GreenRate = (0.9f - SpriteInstance.Green) / (float)secondsToTake;
                SpriteInstance.BlueRate = (1f - SpriteInstance.Blue) / (float)secondsToTake;
            }
            else if (stateToInterpolateTo == Status.Poisoned)
            {
                SpriteInstance.RedRate = (0.5f - SpriteInstance.Red) / (float)secondsToTake;
                SpriteInstance.GreenRate = (1f - SpriteInstance.Green) / (float)secondsToTake;
                SpriteInstance.BlueRate = (0.3f - SpriteInstance.Blue) / (float)secondsToTake;
            }
            else if (stateToInterpolateTo == Status.FrozenAndPoisoned)
            {
                SpriteInstance.RedRate = (0f - SpriteInstance.Red) / (float)secondsToTake;
                SpriteInstance.GreenRate = (1f - SpriteInstance.Green) / (float)secondsToTake;
                SpriteInstance.BlueRate = (0.8f - SpriteInstance.Blue) / (float)secondsToTake;
            }
            else if (stateToInterpolateTo == Status.Burning)
            {
                SpriteInstance.RedRate = (0.3f - SpriteInstance.Red) / (float)secondsToTake;
                SpriteInstance.GreenRate = (0.1f - SpriteInstance.Green) / (float)secondsToTake;
                SpriteInstance.BlueRate = (0.1f - SpriteInstance.Blue) / (float)secondsToTake;
            }
            else if (stateToInterpolateTo == Status.BurningAndPoisoned)
            {
                SpriteInstance.RedRate = (0.1f - SpriteInstance.Red) / (float)secondsToTake;
                SpriteInstance.GreenRate = (0.4f - SpriteInstance.Green) / (float)secondsToTake;
                SpriteInstance.BlueRate = (0f - SpriteInstance.Blue) / (float)secondsToTake;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<Status>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (Status stateToStop) 
        {
            if (stateToStop == Status.Normal)
            {
                SpriteInstance.RedRate =  0;
                SpriteInstance.GreenRate =  0;
                SpriteInstance.BlueRate =  0;
            }
            else if (stateToStop == Status.Frozen)
            {
                SpriteInstance.RedRate =  0;
                SpriteInstance.GreenRate =  0;
                SpriteInstance.BlueRate =  0;
            }
            else if (stateToStop == Status.Poisoned)
            {
                SpriteInstance.RedRate =  0;
                SpriteInstance.GreenRate =  0;
                SpriteInstance.BlueRate =  0;
            }
            else if (stateToStop == Status.FrozenAndPoisoned)
            {
                SpriteInstance.RedRate =  0;
                SpriteInstance.GreenRate =  0;
                SpriteInstance.BlueRate =  0;
            }
            else if (stateToStop == Status.Burning)
            {
                SpriteInstance.RedRate =  0;
                SpriteInstance.GreenRate =  0;
                SpriteInstance.BlueRate =  0;
            }
            else if (stateToStop == Status.BurningAndPoisoned)
            {
                SpriteInstance.RedRate =  0;
                SpriteInstance.GreenRate =  0;
                SpriteInstance.BlueRate =  0;
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
            if (firstState == Status.Normal)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                }
                SpriteInstanceRedFirstValue = 1f;
                SpriteInstanceGreenFirstValue = 1f;
                SpriteInstanceBlueFirstValue = 1f;
                if (interpolationValue < 1)
                {
                    this.FrozenParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.PoisonedParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.SmokeParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            else if (firstState == Status.Frozen)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                }
                SpriteInstanceRedFirstValue = 0.5f;
                SpriteInstanceGreenFirstValue = 0.9f;
                SpriteInstanceBlueFirstValue = 1f;
                if (interpolationValue < 1)
                {
                    this.FrozenParticlesTimedEmission = true;
                }
                if (interpolationValue < 1)
                {
                    this.PoisonedParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.SmokeParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            else if (firstState == Status.Poisoned)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                }
                SpriteInstanceRedFirstValue = 0.5f;
                SpriteInstanceGreenFirstValue = 1f;
                SpriteInstanceBlueFirstValue = 0.3f;
                if (interpolationValue < 1)
                {
                    this.FrozenParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.PoisonedParticlesTimedEmission = true;
                }
                if (interpolationValue < 1)
                {
                    this.SmokeParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            else if (firstState == Status.FrozenAndPoisoned)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                }
                SpriteInstanceRedFirstValue = 0f;
                SpriteInstanceGreenFirstValue = 1f;
                SpriteInstanceBlueFirstValue = 0.8f;
                if (interpolationValue < 1)
                {
                    this.FrozenParticlesTimedEmission = true;
                }
                if (interpolationValue < 1)
                {
                    this.PoisonedParticlesTimedEmission = true;
                }
                if (interpolationValue < 1)
                {
                    this.SmokeParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            else if (firstState == Status.Burning)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                }
                SpriteInstanceRedFirstValue = 0.3f;
                SpriteInstanceGreenFirstValue = 0.1f;
                SpriteInstanceBlueFirstValue = 0.1f;
                if (interpolationValue < 1)
                {
                    this.FrozenParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.PoisonedParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.SmokeParticlesTimedEmission = true;
                }
                if (interpolationValue < 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            else if (firstState == Status.BurningAndPoisoned)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                }
                SpriteInstanceRedFirstValue = 0.1f;
                SpriteInstanceGreenFirstValue = 0.4f;
                SpriteInstanceBlueFirstValue = 0f;
                if (interpolationValue < 1)
                {
                    this.FrozenParticlesTimedEmission = false;
                }
                if (interpolationValue < 1)
                {
                    this.PoisonedParticlesTimedEmission = true;
                }
                if (interpolationValue < 1)
                {
                    this.SmokeParticlesTimedEmission = true;
                }
                if (interpolationValue < 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            if (secondState == Status.Normal)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                }
                SpriteInstanceRedSecondValue = 1f;
                SpriteInstanceGreenSecondValue = 1f;
                SpriteInstanceBlueSecondValue = 1f;
                if (interpolationValue >= 1)
                {
                    this.FrozenParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.PoisonedParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.SmokeParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            else if (secondState == Status.Frozen)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                }
                SpriteInstanceRedSecondValue = 0.5f;
                SpriteInstanceGreenSecondValue = 0.9f;
                SpriteInstanceBlueSecondValue = 1f;
                if (interpolationValue >= 1)
                {
                    this.FrozenParticlesTimedEmission = true;
                }
                if (interpolationValue >= 1)
                {
                    this.PoisonedParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.SmokeParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            else if (secondState == Status.Poisoned)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                }
                SpriteInstanceRedSecondValue = 0.5f;
                SpriteInstanceGreenSecondValue = 1f;
                SpriteInstanceBlueSecondValue = 0.3f;
                if (interpolationValue >= 1)
                {
                    this.FrozenParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.PoisonedParticlesTimedEmission = true;
                }
                if (interpolationValue >= 1)
                {
                    this.SmokeParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            else if (secondState == Status.FrozenAndPoisoned)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                }
                SpriteInstanceRedSecondValue = 0f;
                SpriteInstanceGreenSecondValue = 1f;
                SpriteInstanceBlueSecondValue = 0.8f;
                if (interpolationValue >= 1)
                {
                    this.FrozenParticlesTimedEmission = true;
                }
                if (interpolationValue >= 1)
                {
                    this.PoisonedParticlesTimedEmission = true;
                }
                if (interpolationValue >= 1)
                {
                    this.SmokeParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            else if (secondState == Status.Burning)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                }
                SpriteInstanceRedSecondValue = 0.3f;
                SpriteInstanceGreenSecondValue = 0.1f;
                SpriteInstanceBlueSecondValue = 0.1f;
                if (interpolationValue >= 1)
                {
                    this.FrozenParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.PoisonedParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.SmokeParticlesTimedEmission = true;
                }
                if (interpolationValue >= 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
            }
            else if (secondState == Status.BurningAndPoisoned)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                }
                SpriteInstanceRedSecondValue = 0.1f;
                SpriteInstanceGreenSecondValue = 0.4f;
                SpriteInstanceBlueSecondValue = 0f;
                if (interpolationValue >= 1)
                {
                    this.FrozenParticlesTimedEmission = false;
                }
                if (interpolationValue >= 1)
                {
                    this.PoisonedParticlesTimedEmission = true;
                }
                if (interpolationValue >= 1)
                {
                    this.SmokeParticlesTimedEmission = true;
                }
                if (interpolationValue >= 1)
                {
                    this.StunParticlesTimedEmission = false;
                }
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
                mCurrentStatusState = firstState;
            }
            else
            {
                mCurrentStatusState = secondState;
            }
        }
        public static void PreloadStateContent (Action state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            if (state == Action.Dying)
            {
                {
                    object throwaway = "Dying";
                }
            }
            else if (state == Action.Hurt)
            {
                {
                    object throwaway = "Hurt";
                }
            }
            else if (state == Action.Running)
            {
                {
                    object throwaway = "Running";
                }
            }
            else if (state == Action.Standing)
            {
                {
                    object throwaway = "";
                }
            }
            else if (state == Action.Drowning)
            {
                {
                    object throwaway = "Drowning";
                }
            }
        }
        public static void PreloadStateContent (Direction state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            if (state == Direction.MovingLeft)
            {
            }
            else if (state == Direction.MovingRight)
            {
            }
        }
        public static void PreloadStateContent (Status state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            if (state == Status.Normal)
            {
            }
            else if (state == Status.Frozen)
            {
            }
            else if (state == Status.Poisoned)
            {
            }
            else if (state == Status.FrozenAndPoisoned)
            {
            }
            else if (state == Status.Burning)
            {
            }
            else if (state == Status.BurningAndPoisoned)
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
                case  "AllParticles":
                    return AllParticles;
                case  "ParticleEmitterListFile":
                    return ParticleEmitterListFile;
                case  "ParticleAnimationsChainList":
                    return ParticleAnimationsChainList;
                case  "DrowningSound":
                    return DrowningSound;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
                case  "AllParticles":
                    return AllParticles;
                case  "ParticleEmitterListFile":
                    return ParticleEmitterListFile;
                case  "ParticleAnimationsChainList":
                    return ParticleAnimationsChainList;
                case  "DrowningSound":
                    return DrowningSound;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
                case  "AllParticles":
                    return AllParticles;
                case  "ParticleEmitterListFile":
                    return ParticleEmitterListFile;
                case  "ParticleAnimationsChainList":
                    return ParticleAnimationsChainList;
                case  "DrowningSound":
                    return DrowningSound;
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
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SmokeParticles);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(StunParticles);
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
