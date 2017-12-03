#if ANDROID || IOS
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
            StartMeleeAttack = 5, 
            StartRangedAttack = 6, 
            FinishRangedAttack = 7, 
            RangedAim = 8, 
            Standing = 9, 
            FinishMeleeAttack = 10
        }
        protected int mCurrentActionState = 0;
        public Entities.BaseEntities.BaseEnemy.Action CurrentActionState
        {
            get
            {
                if (System.Enum.IsDefined(typeof(Action), mCurrentActionState))
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
                        break;
                    case  Action.Hurt:
                        SpriteInstanceCurrentChainName = "Hurt";
                        break;
                    case  Action.Running:
                        SpriteInstanceCurrentChainName = "Run";
                        break;
                    case  Action.StartMeleeAttack:
                        SpriteInstanceCurrentChainName = "StartMeleeAttack";
                        break;
                    case  Action.StartRangedAttack:
                        SpriteInstanceCurrentChainName = "StartRangedAttack";
                        break;
                    case  Action.FinishRangedAttack:
                        SpriteInstanceCurrentChainName = "FinishRangedAttack";
                        break;
                    case  Action.RangedAim:
                        SpriteInstanceCurrentChainName = "RangedAim";
                        break;
                    case  Action.Standing:
                        SpriteInstanceCurrentChainName = "Standing";
                        break;
                    case  Action.FinishMeleeAttack:
                        SpriteInstanceCurrentChainName = "FinishMeleeAttack";
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
                if (System.Enum.IsDefined(typeof(Direction), mCurrentDirectionState))
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
                        SpriteInstanceFlipHorizontal = true;
                        break;
                    case  Direction.MovingRight:
                        SpriteInstanceFlipHorizontal = false;
                        break;
                }
            }
        }
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AllAssetsSheet;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D animation_sheet;
        
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
        private FlatRedBall.Math.Geometry.Circle mMeleeAttackRadiusCircleInstance;
        public FlatRedBall.Math.Geometry.Circle MeleeAttackRadiusCircleInstance
        {
            get
            {
                return mMeleeAttackRadiusCircleInstance;
            }
            private set
            {
                mMeleeAttackRadiusCircleInstance = value;
            }
        }
        static float MeleeAttackRadiusCircleInstanceXReset;
        static float MeleeAttackRadiusCircleInstanceYReset;
        static float MeleeAttackRadiusCircleInstanceZReset;
        static float MeleeAttackRadiusCircleInstanceXVelocityReset;
        static float MeleeAttackRadiusCircleInstanceYVelocityReset;
        static float MeleeAttackRadiusCircleInstanceZVelocityReset;
        static float MeleeAttackRadiusCircleInstanceRotationXReset;
        static float MeleeAttackRadiusCircleInstanceRotationYReset;
        static float MeleeAttackRadiusCircleInstanceRotationZReset;
        static float MeleeAttackRadiusCircleInstanceRotationXVelocityReset;
        static float MeleeAttackRadiusCircleInstanceRotationYVelocityReset;
        static float MeleeAttackRadiusCircleInstanceRotationZVelocityReset;
        private FlatRedBall.Math.Geometry.Circle mRangedAttackRadiusCircleInstance;
        public FlatRedBall.Math.Geometry.Circle RangedAttackRadiusCircleInstance
        {
            get
            {
                return mRangedAttackRadiusCircleInstance;
            }
            private set
            {
                mRangedAttackRadiusCircleInstance = value;
            }
        }
        static float RangedAttackRadiusCircleInstanceXReset;
        static float RangedAttackRadiusCircleInstanceYReset;
        static float RangedAttackRadiusCircleInstanceZReset;
        static float RangedAttackRadiusCircleInstanceXVelocityReset;
        static float RangedAttackRadiusCircleInstanceYVelocityReset;
        static float RangedAttackRadiusCircleInstanceZVelocityReset;
        static float RangedAttackRadiusCircleInstanceRotationXReset;
        static float RangedAttackRadiusCircleInstanceRotationYReset;
        static float RangedAttackRadiusCircleInstanceRotationZReset;
        static float RangedAttackRadiusCircleInstanceRotationXVelocityReset;
        static float RangedAttackRadiusCircleInstanceRotationYVelocityReset;
        static float RangedAttackRadiusCircleInstanceRotationZVelocityReset;
        protected FlatRedBall.Sprite LightSprite;
        private AbbatoirIntergrade.Entities.GraphicalElements.ResourceBar HealthBar;
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
        public virtual bool IsRangedAttacker { get; set; }
        public virtual float MeleeAttackDamage { get; set; }
        public virtual float RangedAttackDamage { get; set; }
        public virtual float ProjectileSpeed { get; set; }
        public virtual float SecondsBetweenRangedAttack { get; set; }
        public virtual float SecondsBetweenMeleeAttack { get; set; }
        System.Double mMineralsRewardedWhenKilled = 0;
        public virtual System.Double MineralsRewardedWhenKilled
        {
            set
            {
                mMineralsRewardedWhenKilled = value;
            }
            get
            {
                return mMineralsRewardedWhenKilled;
            }
        }
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
        bool mIsMeleeAttacker = false;
        public virtual bool IsMeleeAttacker
        {
            set
            {
                mIsMeleeAttacker = value;
            }
            get
            {
                return mIsMeleeAttacker;
            }
        }
        public virtual float MeleeAttackRadius
        {
            get
            {
                return MeleeAttackRadiusCircleInstance.Radius;
            }
            set
            {
                MeleeAttackRadiusCircleInstance.Radius = value;
            }
        }
        public virtual float RangedAttackRadius
        {
            get
            {
                return RangedAttackRadiusCircleInstance.Radius;
            }
            set
            {
                RangedAttackRadiusCircleInstance.Radius = value;
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
            mMeleeAttackRadiusCircleInstance = new FlatRedBall.Math.Geometry.Circle();
            mMeleeAttackRadiusCircleInstance.Name = "mMeleeAttackRadiusCircleInstance";
            mRangedAttackRadiusCircleInstance = new FlatRedBall.Math.Geometry.Circle();
            mRangedAttackRadiusCircleInstance.Name = "mRangedAttackRadiusCircleInstance";
            HealthBar = new AbbatoirIntergrade.Entities.GraphicalElements.ResourceBar(ContentManagerName, false);
            HealthBar.Name = "HealthBar";
            
            PostInitialize();
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceXReset = MeleeAttackRadiusCircleInstance.X;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceXReset = MeleeAttackRadiusCircleInstance.RelativeX;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceYReset = MeleeAttackRadiusCircleInstance.Y;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceYReset = MeleeAttackRadiusCircleInstance.RelativeY;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceZReset = MeleeAttackRadiusCircleInstance.Z;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceZReset = MeleeAttackRadiusCircleInstance.RelativeZ;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceXVelocityReset = MeleeAttackRadiusCircleInstance.XVelocity;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceXVelocityReset = MeleeAttackRadiusCircleInstance.RelativeXVelocity;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceYVelocityReset = MeleeAttackRadiusCircleInstance.YVelocity;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceYVelocityReset = MeleeAttackRadiusCircleInstance.RelativeYVelocity;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceZVelocityReset = MeleeAttackRadiusCircleInstance.ZVelocity;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceZVelocityReset = MeleeAttackRadiusCircleInstance.RelativeZVelocity;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceRotationXReset = MeleeAttackRadiusCircleInstance.RotationX;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceRotationXReset = MeleeAttackRadiusCircleInstance.RelativeRotationX;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceRotationYReset = MeleeAttackRadiusCircleInstance.RotationY;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceRotationYReset = MeleeAttackRadiusCircleInstance.RelativeRotationY;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceRotationZReset = MeleeAttackRadiusCircleInstance.RotationZ;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceRotationZReset = MeleeAttackRadiusCircleInstance.RelativeRotationZ;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceRotationXVelocityReset = MeleeAttackRadiusCircleInstance.RotationXVelocity;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceRotationXVelocityReset = MeleeAttackRadiusCircleInstance.RelativeRotationXVelocity;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceRotationYVelocityReset = MeleeAttackRadiusCircleInstance.RotationYVelocity;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceRotationYVelocityReset = MeleeAttackRadiusCircleInstance.RelativeRotationYVelocity;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstanceRotationZVelocityReset = MeleeAttackRadiusCircleInstance.RotationZVelocity;
            }
            else
            {
                MeleeAttackRadiusCircleInstanceRotationZVelocityReset = MeleeAttackRadiusCircleInstance.RelativeRotationZVelocity;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceXReset = RangedAttackRadiusCircleInstance.X;
            }
            else
            {
                RangedAttackRadiusCircleInstanceXReset = RangedAttackRadiusCircleInstance.RelativeX;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceYReset = RangedAttackRadiusCircleInstance.Y;
            }
            else
            {
                RangedAttackRadiusCircleInstanceYReset = RangedAttackRadiusCircleInstance.RelativeY;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceZReset = RangedAttackRadiusCircleInstance.Z;
            }
            else
            {
                RangedAttackRadiusCircleInstanceZReset = RangedAttackRadiusCircleInstance.RelativeZ;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceXVelocityReset = RangedAttackRadiusCircleInstance.XVelocity;
            }
            else
            {
                RangedAttackRadiusCircleInstanceXVelocityReset = RangedAttackRadiusCircleInstance.RelativeXVelocity;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceYVelocityReset = RangedAttackRadiusCircleInstance.YVelocity;
            }
            else
            {
                RangedAttackRadiusCircleInstanceYVelocityReset = RangedAttackRadiusCircleInstance.RelativeYVelocity;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceZVelocityReset = RangedAttackRadiusCircleInstance.ZVelocity;
            }
            else
            {
                RangedAttackRadiusCircleInstanceZVelocityReset = RangedAttackRadiusCircleInstance.RelativeZVelocity;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceRotationXReset = RangedAttackRadiusCircleInstance.RotationX;
            }
            else
            {
                RangedAttackRadiusCircleInstanceRotationXReset = RangedAttackRadiusCircleInstance.RelativeRotationX;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceRotationYReset = RangedAttackRadiusCircleInstance.RotationY;
            }
            else
            {
                RangedAttackRadiusCircleInstanceRotationYReset = RangedAttackRadiusCircleInstance.RelativeRotationY;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceRotationZReset = RangedAttackRadiusCircleInstance.RotationZ;
            }
            else
            {
                RangedAttackRadiusCircleInstanceRotationZReset = RangedAttackRadiusCircleInstance.RelativeRotationZ;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceRotationXVelocityReset = RangedAttackRadiusCircleInstance.RotationXVelocity;
            }
            else
            {
                RangedAttackRadiusCircleInstanceRotationXVelocityReset = RangedAttackRadiusCircleInstance.RelativeRotationXVelocity;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceRotationYVelocityReset = RangedAttackRadiusCircleInstance.RotationYVelocity;
            }
            else
            {
                RangedAttackRadiusCircleInstanceRotationYVelocityReset = RangedAttackRadiusCircleInstance.RelativeRotationYVelocity;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstanceRotationZVelocityReset = RangedAttackRadiusCircleInstance.RotationZVelocity;
            }
            else
            {
                RangedAttackRadiusCircleInstanceRotationZVelocityReset = RangedAttackRadiusCircleInstance.RelativeRotationZVelocity;
            }
            if (addToManagers)
            {
                AddToManagers(null);
            }
        }
        public virtual void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            HealthBar.ReAddToManagers(LayerProvidedByContainer);
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            PostInitialize();
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            HealthBar.AddToManagers(LayerProvidedByContainer);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            mIsPaused = false;
            
            HealthBar.Activity();
            CustomActivity();
        }
        public virtual void Destroy () 
        {
            FlatRedBall.SpriteManager.RemovePositionedObject(this);
            
            if (HealthBar != null)
            {
                HealthBar.Destroy();
                HealthBar.Detach();
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
                CircleInstance.Radius = 16f;
            }
            if (ShadowSprite!= null)
            {
                if (ShadowSprite.Parent == null)
                {
                    ShadowSprite.CopyAbsoluteToRelative();
                    ShadowSprite.AttachTo(this, false);
                }
                if (ShadowSprite.Parent == null)
                {
                    ShadowSprite.Z = -1f;
                }
                else
                {
                    ShadowSprite.RelativeZ = -1f;
                }
                ShadowSprite.Texture = AllAssetsSheet;
                ShadowSprite.LeftTexturePixel = 334f;
                ShadowSprite.RightTexturePixel = 396f;
                ShadowSprite.TopTexturePixel = 158f;
                ShadowSprite.BottomTexturePixel = 220f;
                ShadowSprite.TextureScale = 1f;
            }
            if (mMeleeAttackRadiusCircleInstance.Parent == null)
            {
                mMeleeAttackRadiusCircleInstance.CopyAbsoluteToRelative();
                mMeleeAttackRadiusCircleInstance.AttachTo(this, false);
            }
            MeleeAttackRadiusCircleInstance.Radius = 16f;
            MeleeAttackRadiusCircleInstance.Color = Color.Red;
            if (mRangedAttackRadiusCircleInstance.Parent == null)
            {
                mRangedAttackRadiusCircleInstance.CopyAbsoluteToRelative();
                mRangedAttackRadiusCircleInstance.AttachTo(this, false);
            }
            RangedAttackRadiusCircleInstance.Radius = 16f;
            RangedAttackRadiusCircleInstance.Color = Color.Tomato;
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
            HealthBar.BarSpriteRed = 0f;
            HealthBar.BarSpriteGreen = 1f;
            HealthBar.BarSpriteBlue = 0f;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            mGeneratedCollision.Circles.AddOneWay(mCircleInstance);
            mGeneratedCollision.Circles.AddOneWay(mMeleeAttackRadiusCircleInstance);
            mGeneratedCollision.Circles.AddOneWay(mRangedAttackRadiusCircleInstance);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            HealthBar.RemoveFromManagers();
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                HealthBar.AssignCustomVariables(true);
            }
            MeleeAttackRadiusCircleInstance.Radius = 16f;
            MeleeAttackRadiusCircleInstance.Color = Color.Red;
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.X = MeleeAttackRadiusCircleInstanceXReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeX = MeleeAttackRadiusCircleInstanceXReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.Y = MeleeAttackRadiusCircleInstanceYReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeY = MeleeAttackRadiusCircleInstanceYReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.Z = MeleeAttackRadiusCircleInstanceZReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeZ = MeleeAttackRadiusCircleInstanceZReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.XVelocity = MeleeAttackRadiusCircleInstanceXVelocityReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeXVelocity = MeleeAttackRadiusCircleInstanceXVelocityReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.YVelocity = MeleeAttackRadiusCircleInstanceYVelocityReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeYVelocity = MeleeAttackRadiusCircleInstanceYVelocityReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.ZVelocity = MeleeAttackRadiusCircleInstanceZVelocityReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeZVelocity = MeleeAttackRadiusCircleInstanceZVelocityReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.RotationX = MeleeAttackRadiusCircleInstanceRotationXReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeRotationX = MeleeAttackRadiusCircleInstanceRotationXReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.RotationY = MeleeAttackRadiusCircleInstanceRotationYReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeRotationY = MeleeAttackRadiusCircleInstanceRotationYReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.RotationZ = MeleeAttackRadiusCircleInstanceRotationZReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeRotationZ = MeleeAttackRadiusCircleInstanceRotationZReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.RotationXVelocity = MeleeAttackRadiusCircleInstanceRotationXVelocityReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeRotationXVelocity = MeleeAttackRadiusCircleInstanceRotationXVelocityReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.RotationYVelocity = MeleeAttackRadiusCircleInstanceRotationYVelocityReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeRotationYVelocity = MeleeAttackRadiusCircleInstanceRotationYVelocityReset;
            }
            if (MeleeAttackRadiusCircleInstance.Parent == null)
            {
                MeleeAttackRadiusCircleInstance.RotationZVelocity = MeleeAttackRadiusCircleInstanceRotationZVelocityReset;
            }
            else
            {
                MeleeAttackRadiusCircleInstance.RelativeRotationZVelocity = MeleeAttackRadiusCircleInstanceRotationZVelocityReset;
            }
            RangedAttackRadiusCircleInstance.Radius = 16f;
            RangedAttackRadiusCircleInstance.Color = Color.Tomato;
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.X = RangedAttackRadiusCircleInstanceXReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeX = RangedAttackRadiusCircleInstanceXReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.Y = RangedAttackRadiusCircleInstanceYReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeY = RangedAttackRadiusCircleInstanceYReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.Z = RangedAttackRadiusCircleInstanceZReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeZ = RangedAttackRadiusCircleInstanceZReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.XVelocity = RangedAttackRadiusCircleInstanceXVelocityReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeXVelocity = RangedAttackRadiusCircleInstanceXVelocityReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.YVelocity = RangedAttackRadiusCircleInstanceYVelocityReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeYVelocity = RangedAttackRadiusCircleInstanceYVelocityReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.ZVelocity = RangedAttackRadiusCircleInstanceZVelocityReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeZVelocity = RangedAttackRadiusCircleInstanceZVelocityReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.RotationX = RangedAttackRadiusCircleInstanceRotationXReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeRotationX = RangedAttackRadiusCircleInstanceRotationXReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.RotationY = RangedAttackRadiusCircleInstanceRotationYReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeRotationY = RangedAttackRadiusCircleInstanceRotationYReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.RotationZ = RangedAttackRadiusCircleInstanceRotationZReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeRotationZ = RangedAttackRadiusCircleInstanceRotationZReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.RotationXVelocity = RangedAttackRadiusCircleInstanceRotationXVelocityReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeRotationXVelocity = RangedAttackRadiusCircleInstanceRotationXVelocityReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.RotationYVelocity = RangedAttackRadiusCircleInstanceRotationYVelocityReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeRotationYVelocity = RangedAttackRadiusCircleInstanceRotationYVelocityReset;
            }
            if (RangedAttackRadiusCircleInstance.Parent == null)
            {
                RangedAttackRadiusCircleInstance.RotationZVelocity = RangedAttackRadiusCircleInstanceRotationZVelocityReset;
            }
            else
            {
                RangedAttackRadiusCircleInstance.RelativeRotationZVelocity = RangedAttackRadiusCircleInstanceRotationZVelocityReset;
            }
            HealthBar.BarSpriteRed = 0f;
            HealthBar.BarSpriteGreen = 1f;
            HealthBar.BarSpriteBlue = 0f;
            SpriteInstanceFlipHorizontal = false;
            MineralsRewardedWhenKilled = 0;
            DisplayName = "Not Set";
            IsMeleeAttacker = false;
            MeleeAttackRadius = 16f;
            RangedAttackRadius = 16f;
            IsFlying = false;
            HasLightSource = false;
            IsJumper = false;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            }
            if (ShadowSprite != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(ShadowSprite);
            }
            if (LightSprite != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(LightSprite);
            }
            HealthBar.ConvertToManuallyUpdated();
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
                case  Action.StartMeleeAttack:
                    break;
                case  Action.StartRangedAttack:
                    break;
                case  Action.FinishRangedAttack:
                    break;
                case  Action.RangedAim:
                    break;
                case  Action.Standing:
                    break;
                case  Action.FinishMeleeAttack:
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
                case  Action.StartMeleeAttack:
                    break;
                case  Action.StartRangedAttack:
                    break;
                case  Action.FinishRangedAttack:
                    break;
                case  Action.RangedAim:
                    break;
                case  Action.Standing:
                    break;
                case  Action.FinishMeleeAttack:
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
            switch(firstState)
            {
                case  Action.Dying:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Dying";
                    }
                    break;
                case  Action.Hurt:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Hurt";
                    }
                    break;
                case  Action.Running:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Run";
                    }
                    break;
                case  Action.StartMeleeAttack:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "StartMeleeAttack";
                    }
                    break;
                case  Action.StartRangedAttack:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "StartRangedAttack";
                    }
                    break;
                case  Action.FinishRangedAttack:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "FinishRangedAttack";
                    }
                    break;
                case  Action.RangedAim:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "RangedAim";
                    }
                    break;
                case  Action.Standing:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Standing";
                    }
                    break;
                case  Action.FinishMeleeAttack:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "FinishMeleeAttack";
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
                    break;
                case  Action.Hurt:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Hurt";
                    }
                    break;
                case  Action.Running:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Run";
                    }
                    break;
                case  Action.StartMeleeAttack:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "StartMeleeAttack";
                    }
                    break;
                case  Action.StartRangedAttack:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "StartRangedAttack";
                    }
                    break;
                case  Action.FinishRangedAttack:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "FinishRangedAttack";
                    }
                    break;
                case  Action.RangedAim:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "RangedAim";
                    }
                    break;
                case  Action.Standing:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Standing";
                    }
                    break;
                case  Action.FinishMeleeAttack:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "FinishMeleeAttack";
                    }
                    break;
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
                        this.SpriteInstanceFlipHorizontal = true;
                    }
                    break;
                case  Direction.MovingRight:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceFlipHorizontal = false;
                    }
                    break;
            }
            switch(secondState)
            {
                case  Direction.MovingLeft:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceFlipHorizontal = true;
                    }
                    break;
                case  Direction.MovingRight:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceFlipHorizontal = false;
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
                        object throwaway = "Run";
                    }
                    break;
                case  Action.StartMeleeAttack:
                    {
                        object throwaway = "StartMeleeAttack";
                    }
                    break;
                case  Action.StartRangedAttack:
                    {
                        object throwaway = "StartRangedAttack";
                    }
                    break;
                case  Action.FinishRangedAttack:
                    {
                        object throwaway = "FinishRangedAttack";
                    }
                    break;
                case  Action.RangedAim:
                    {
                        object throwaway = "RangedAim";
                    }
                    break;
                case  Action.Standing:
                    {
                        object throwaway = "Standing";
                    }
                    break;
                case  Action.FinishMeleeAttack:
                    {
                        object throwaway = "FinishMeleeAttack";
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
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
                case  "animation_sheet":
                    return animation_sheet;
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
            if (ShadowSprite != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(ShadowSprite);
            }
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(MeleeAttackRadiusCircleInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(RangedAttackRadiusCircleInstance);
            if (LightSprite != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightSprite);
            }
            HealthBar.SetToIgnorePausing();
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
                layerToRemoveFrom.Remove(MeleeAttackRadiusCircleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(MeleeAttackRadiusCircleInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(RangedAttackRadiusCircleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(RangedAttackRadiusCircleInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(LightSprite);
            }
            FlatRedBall.SpriteManager.AddToLayer(LightSprite, layerToMoveTo);
            HealthBar.MoveToLayer(layerToMoveTo);
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
