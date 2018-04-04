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
namespace AbbatoirIntergrade.Entities.BaseEntities
{
    public partial class BaseStructure : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Graphics.IVisible, FlatRedBall.Gui.IClickable, FlatRedBall.Math.Geometry.ICollidable
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
            ValidLocation = 2, 
            InvalidLocation = 3, 
            Built = 4, 
            CantAfford = 5, 
            Selected = 6
        }
        protected int mCurrentState = 0;
        public Entities.BaseEntities.BaseStructure.VariableState CurrentState
        {
            get
            {
                if (mCurrentState >= 0 && mCurrentState <= 6)
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
                    case  VariableState.ValidLocation:
                        SpriteInstanceRed = 0f;
                        SpriteInstanceGreen = 255f;
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                        break;
                    case  VariableState.InvalidLocation:
                        SpriteInstanceRed = 255f;
                        SpriteInstanceGreen = 0f;
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                        break;
                    case  VariableState.Built:
                        SpriteInstanceRed = 0f;
                        SpriteInstanceGreen = 0f;
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                        break;
                    case  VariableState.CantAfford:
                        SpriteInstanceRed = 255f;
                        SpriteInstanceGreen = 255f;
                        break;
                    case  VariableState.Selected:
                        SpriteInstanceRed = 0f;
                        SpriteInstanceGreen = 255f;
                        break;
                }
            }
        }
        public enum OnOff
        {
            Uninitialized = 0, //This exists so that the first set call actually does something
            Unknown = 1, //This exists so that if the entity is actually a child entity and has set a child state, you will get this
            On = 2, 
            Off = 3
        }
        protected int mCurrentOnOffState = 0;
        public Entities.BaseEntities.BaseStructure.OnOff CurrentOnOffState
        {
            get
            {
                if (mCurrentOnOffState >= 0 && mCurrentOnOffState <= 3)
                {
                    return (OnOff)mCurrentOnOffState;
                }
                else
                {
                    return OnOff.Unknown;
                }
            }
            set
            {
                mCurrentOnOffState = (int)value;
                switch(CurrentOnOffState)
                {
                    case  OnOff.Uninitialized:
                        break;
                    case  OnOff.Unknown:
                        break;
                    case  OnOff.On:
                        LightSpriteInstanceRed = 1f;
                        LightSpriteInstanceGreen = 1f;
                        LightSpriteInstanceBlue = 1f;
                        break;
                    case  OnOff.Off:
                        LightSpriteInstanceRed = 1f;
                        LightSpriteInstanceGreen = 0.1f;
                        LightSpriteInstanceBlue = 0.1f;
                        break;
                }
            }
        }
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static FlatRedBall.Graphics.Animation.AnimationChainList BaseStructureAnimationChainListFile;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AllParticles;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D RangeCircleTexture;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D MinRangeCircleTexture;
        protected static FlatRedBall.Graphics.Animation.AnimationChainList StructureGlowAnimationChainList;
        
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
        protected FlatRedBall.Sprite mLightSpriteInstance;
        public FlatRedBall.Sprite LightSpriteInstance
        {
            get
            {
                return mLightSpriteInstance;
            }
            protected set
            {
                mLightSpriteInstance = value;
            }
        }
        private FlatRedBall.Math.Geometry.Circle mRangeCircleInstance;
        public FlatRedBall.Math.Geometry.Circle RangeCircleInstance
        {
            get
            {
                return mRangeCircleInstance;
            }
            private set
            {
                mRangeCircleInstance = value;
            }
        }
        protected FlatRedBall.Sprite mAimSpriteInstance;
        public FlatRedBall.Sprite AimSpriteInstance
        {
            get
            {
                return mAimSpriteInstance;
            }
            protected set
            {
                mAimSpriteInstance = value;
            }
        }
        protected FlatRedBall.PositionedObject mPivotPoint;
        public FlatRedBall.PositionedObject PivotPoint
        {
            get
            {
                return mPivotPoint;
            }
            protected set
            {
                mPivotPoint = value;
            }
        }
        private FlatRedBall.Math.Geometry.Circle mMinimumRangeCircleInstance;
        public FlatRedBall.Math.Geometry.Circle MinimumRangeCircleInstance
        {
            get
            {
                return mMinimumRangeCircleInstance;
            }
            private set
            {
                mMinimumRangeCircleInstance = value;
            }
        }
        private FlatRedBall.Sprite mRangePreviewSprite;
        public FlatRedBall.Sprite RangePreviewSprite
        {
            get
            {
                return mRangePreviewSprite;
            }
            private set
            {
                mRangePreviewSprite = value;
            }
        }
        protected FlatRedBall.Sprite mLightAimSpriteInstance;
        public FlatRedBall.Sprite LightAimSpriteInstance
        {
            get
            {
                return mLightAimSpriteInstance;
            }
            private set
            {
                mLightAimSpriteInstance = value;
            }
        }
        private AbbatoirIntergrade.GumRuntimes.StructureUpgradeStatusRuntime mStructureUpgradeStatusInstance;
        public AbbatoirIntergrade.GumRuntimes.StructureUpgradeStatusRuntime StructureUpgradeStatusInstance
        {
            get
            {
                return mStructureUpgradeStatusInstance;
            }
            private set
            {
                mStructureUpgradeStatusInstance = value;
            }
        }
        private FlatRedBall.Sprite WarpSpriteInstance;
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
        public event System.EventHandler BeforeIsBeingPlacedSet;
        public event System.EventHandler AfterIsBeingPlacedSet;
        bool mIsBeingPlaced = true;
        public bool IsBeingPlaced
        {
            set
            {
                if (BeforeIsBeingPlacedSet != null)
                {
                    BeforeIsBeingPlacedSet(this, null);
                }
                mIsBeingPlaced = value;
                if (AfterIsBeingPlacedSet != null)
                {
                    AfterIsBeingPlacedSet(this, null);
                }
            }
            get
            {
                return mIsBeingPlaced;
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
        public virtual bool HasLightSource
        {
            get
            {
                return LightSpriteInstance.Visible;
            }
            set
            {
                LightSpriteInstance.Visible = value;
            }
        }
        public float LightSpriteInstanceRed
        {
            get
            {
                return LightSpriteInstance.Red;
            }
            set
            {
                LightSpriteInstance.Red = value;
            }
        }
        public float LightSpriteInstanceGreen
        {
            get
            {
                return LightSpriteInstance.Green;
            }
            set
            {
                LightSpriteInstance.Green = value;
            }
        }
        public float LightSpriteInstanceBlue
        {
            get
            {
                return LightSpriteInstance.Blue;
            }
            set
            {
                LightSpriteInstance.Blue = value;
            }
        }
        public virtual string StructureDescription { get; set; }
        public virtual System.Double SecondsBetweenFiring { get; set; }
        public virtual float AttackDamage { get; set; }
        public virtual float ProjectileSpeed { get; set; }
        public virtual float RangedRadius
        {
            get
            {
                return RangeCircleInstance.Radius;
            }
            set
            {
                RangeCircleInstance.Radius = value;
            }
        }
        float mProjectileAltitude = 100f;
        public virtual float ProjectileAltitude
        {
            set
            {
                mProjectileAltitude = value;
            }
            get
            {
                return mProjectileAltitude;
            }
        }
        public virtual bool HasSplashDamage { get; set; }
        public virtual bool SlowsEnemies { get; set; }
        public virtual bool StunsEnemies { get; set; }
        public bool IsPiercing;
        public bool IsBombarding;
        public bool IsChemical;
        public bool IsElectrical;
        public bool IsFire;
        public bool IsFrost;
        public virtual float MinimumRangeRadius
        {
            get
            {
                return MinimumRangeCircleInstance.Radius;
            }
            set
            {
                MinimumRangeCircleInstance.Radius = value;
            }
        }
        public virtual System.Double StatusEffectSeconds { get; set; }
        public virtual float StatusDamageMultiplier { get; set; }
        public virtual int SatoshiCost { get; set; }
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
        public BaseStructure () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public BaseStructure (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public BaseStructure (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            mRangeCircleInstance = new FlatRedBall.Math.Geometry.Circle();
            mRangeCircleInstance.Name = "mRangeCircleInstance";
            mMinimumRangeCircleInstance = new FlatRedBall.Math.Geometry.Circle();
            mMinimumRangeCircleInstance.Name = "mMinimumRangeCircleInstance";
            mRangePreviewSprite = new FlatRedBall.Sprite();
            mRangePreviewSprite.Name = "mRangePreviewSprite";
            mLightAimSpriteInstance = new FlatRedBall.Sprite();
            mLightAimSpriteInstance.Name = "mLightAimSpriteInstance";
            {var oldLayoutSuspended = global::Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended; global::Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true; mStructureUpgradeStatusInstance = new AbbatoirIntergrade.GumRuntimes.StructureUpgradeStatusRuntime();global::Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = oldLayoutSuspended; mStructureUpgradeStatusInstance.UpdateLayout();}
            WarpSpriteInstance = new FlatRedBall.Sprite();
            WarpSpriteInstance.Name = "WarpSpriteInstance";
            
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
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mRangeCircleInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mMinimumRangeCircleInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(mRangePreviewSprite, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(mLightAimSpriteInstance, LayerProvidedByContainer);
            mStructureUpgradeStatusInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(LayerProvidedByContainer)));
            FlatRedBall.SpriteManager.AddToLayer(WarpSpriteInstance, LayerProvidedByContainer);
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mRangeCircleInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mMinimumRangeCircleInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(mRangePreviewSprite, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(mLightAimSpriteInstance, LayerProvidedByContainer);
            mStructureUpgradeStatusInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(LayerProvidedByContainer)));
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
            FlatRedBall.SpriteManager.RemovePositionedObject(this);
            
            if (RangeCircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.Remove(RangeCircleInstance);
            }
            if (MinimumRangeCircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.Remove(MinimumRangeCircleInstance);
            }
            if (RangePreviewSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(RangePreviewSprite);
            }
            if (LightAimSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(LightAimSpriteInstance);
            }
            if (StructureUpgradeStatusInstance != null)
            {
                StructureUpgradeStatusInstance.RemoveFromManagers();
            }
            if (WarpSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(WarpSpriteInstance);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            this.AfterIsBeingPlacedSet += OnAfterIsBeingPlacedSet;
            if (SpriteInstance!= null)
            {
                if (mSpriteInstance.Parent == null)
                {
                    mSpriteInstance.CopyAbsoluteToRelative();
                    mSpriteInstance.AttachTo(this, false);
                }
                SpriteInstance.Texture = AllParticles;
                SpriteInstance.TextureScale = 1f;
                SpriteInstance.UseAnimationRelativePosition = false;
                SpriteInstance.AnimationChains = BaseStructureAnimationChainListFile;
            }
            if (AxisAlignedRectangleInstance!= null)
            {
                if (mAxisAlignedRectangleInstance.Parent == null)
                {
                    mAxisAlignedRectangleInstance.CopyAbsoluteToRelative();
                    mAxisAlignedRectangleInstance.AttachTo(this, false);
                }
                AxisAlignedRectangleInstance.Width = 64f;
                AxisAlignedRectangleInstance.Height = 64f;
            }
            if (LightSpriteInstance!= null)
            {
                if (mLightSpriteInstance.Parent == null)
                {
                    mLightSpriteInstance.CopyAbsoluteToRelative();
                    mLightSpriteInstance.AttachTo(this, false);
                }
                if (LightSpriteInstance.Parent == null)
                {
                    LightSpriteInstance.Z = -1f;
                }
                else
                {
                    LightSpriteInstance.RelativeZ = -1f;
                }
                LightSpriteInstance.Texture = AllParticles;
                LightSpriteInstance.LeftTexturePixel = 1792f;
                LightSpriteInstance.RightTexturePixel = 2048f;
                LightSpriteInstance.TopTexturePixel = 1792f;
                LightSpriteInstance.BottomTexturePixel = 2048f;
                LightSpriteInstance.TextureScale = 1f;
                #if FRB_MDX
                LightSpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
                #else
                LightSpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                #endif
                LightSpriteInstance.Blue = 0.5f;
                LightSpriteInstance.Alpha = 0.25f;
            }
            if (mRangeCircleInstance.Parent == null)
            {
                mRangeCircleInstance.CopyAbsoluteToRelative();
                mRangeCircleInstance.AttachTo(this, false);
            }
            RangeCircleInstance.Radius = 400f;
            if (AimSpriteInstance!= null)
            {
                if (mAimSpriteInstance.Parent == null)
                {
                    mAimSpriteInstance.CopyAbsoluteToRelative();
                    mAimSpriteInstance.AttachTo(this, false);
                }
                if (AimSpriteInstance.Parent == null)
                {
                    AimSpriteInstance.Z = 0f;
                }
                else
                {
                    AimSpriteInstance.RelativeZ = 0f;
                }
                AimSpriteInstance.Texture = AllParticles;
                AimSpriteInstance.TextureScale = 1f;
            }
            if (PivotPoint!= null)
            {
                if (mPivotPoint.Parent == null)
                {
                    mPivotPoint.CopyAbsoluteToRelative();
                    mPivotPoint.AttachTo(this, false);
                }
            }
            if (mMinimumRangeCircleInstance.Parent == null)
            {
                mMinimumRangeCircleInstance.CopyAbsoluteToRelative();
                mMinimumRangeCircleInstance.AttachTo(this, false);
            }
            MinimumRangeCircleInstance.Radius = 16f;
            if (mRangePreviewSprite.Parent == null)
            {
                mRangePreviewSprite.CopyAbsoluteToRelative();
                mRangePreviewSprite.AttachTo(this, false);
            }
            RangePreviewSprite.TextureScale = 1f;
            RangePreviewSprite.Visible = false;
            RangePreviewSprite.Alpha = 0.8f;
            if (mLightAimSpriteInstance.Parent == null)
            {
                mLightAimSpriteInstance.CopyAbsoluteToRelative();
                mLightAimSpriteInstance.AttachTo(this, false);
            }
            if (LightAimSpriteInstance.Parent == null)
            {
                LightAimSpriteInstance.X = 165.2288f;
            }
            else
            {
                LightAimSpriteInstance.RelativeX = 165.2288f;
            }
            if (LightAimSpriteInstance.Parent == null)
            {
                LightAimSpriteInstance.Y = -20.91503f;
            }
            else
            {
                LightAimSpriteInstance.RelativeY = -20.91503f;
            }
            LightAimSpriteInstance.Texture = AllParticles;
            LightAimSpriteInstance.TextureScale = 1f;
            LightAimSpriteInstance.AnimationChains = StructureGlowAnimationChainList;
            LightAimSpriteInstance.Visible = false;
            if (WarpSpriteInstance.Parent == null)
            {
                WarpSpriteInstance.CopyAbsoluteToRelative();
                WarpSpriteInstance.AttachTo(this, false);
            }
            WarpSpriteInstance.TextureScale = 1f;
            WarpSpriteInstance.AnimationChains = BaseStructureAnimationChainListFile;
            WarpSpriteInstance.CurrentChainName = "BuildAnimation";
            WarpSpriteInstance.Visible = false;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            mGeneratedCollision.AxisAlignedRectangles.AddOneWay(mAxisAlignedRectangleInstance);
            mGeneratedCollision.Circles.AddOneWay(mRangeCircleInstance);
            mGeneratedCollision.Circles.AddOneWay(mMinimumRangeCircleInstance);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (RangeCircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(RangeCircleInstance);
            }
            if (MinimumRangeCircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(MinimumRangeCircleInstance);
            }
            if (RangePreviewSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(RangePreviewSprite);
            }
            if (LightAimSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightAimSpriteInstance);
            }
            if (StructureUpgradeStatusInstance != null)
            {
                StructureUpgradeStatusInstance.RemoveFromManagers();
            }
            if (WarpSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(WarpSpriteInstance);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            RangeCircleInstance.Radius = 400f;
            MinimumRangeCircleInstance.Radius = 16f;
            RangePreviewSprite.TextureScale = 1f;
            RangePreviewSprite.Visible = false;
            RangePreviewSprite.Alpha = 0.8f;
            if (LightAimSpriteInstance.Parent == null)
            {
                LightAimSpriteInstance.X = 165.2288f;
            }
            else
            {
                LightAimSpriteInstance.RelativeX = 165.2288f;
            }
            if (LightAimSpriteInstance.Parent == null)
            {
                LightAimSpriteInstance.Y = -20.91503f;
            }
            else
            {
                LightAimSpriteInstance.RelativeY = -20.91503f;
            }
            LightAimSpriteInstance.Texture = AllParticles;
            LightAimSpriteInstance.TextureScale = 1f;
            LightAimSpriteInstance.AnimationChains = StructureGlowAnimationChainList;
            LightAimSpriteInstance.Visible = false;
            WarpSpriteInstance.TextureScale = 1f;
            WarpSpriteInstance.AnimationChains = BaseStructureAnimationChainListFile;
            WarpSpriteInstance.CurrentChainName = "BuildAnimation";
            WarpSpriteInstance.Visible = false;
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
            SpriteInstanceRed = 0f;
            SpriteInstanceGreen = 0f;
            SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
            IsBeingPlaced = true;
            DisplayName = "Not Set";
            HasLightSource = true;
            LightSpriteInstanceRed = 0f;
            LightSpriteInstanceGreen = 0f;
            LightSpriteInstanceBlue = 0.5f;
            RangedRadius = 400f;
            ProjectileAltitude = 100f;
            MinimumRangeRadius = 16f;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            }
            if (AxisAlignedRectangleInstance != null)
            {
            }
            if (LightSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(LightSpriteInstance);
            }
            if (AimSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(AimSpriteInstance);
            }
            if (PivotPoint != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(PivotPoint);
            }
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(RangePreviewSprite);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(LightAimSpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(WarpSpriteInstance);
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            ContentManagerName = contentManagerName;
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
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
            bool registerUnload = false;
            if (LoadedContentManagers.Contains(contentManagerName) == false)
            {
                LoadedContentManagers.Add(contentManagerName);
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BaseStructureStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/baseentities/basestructure/basestructureanimationchainlistfile.achx", ContentManagerName))
                {
                    registerUnload = true;
                }
                BaseStructureAnimationChainListFile = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/baseentities/basestructure/basestructureanimationchainlistfile.achx", ContentManagerName);
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/projectiles/allparticles.png", ContentManagerName))
                {
                    registerUnload = true;
                }
                AllParticles = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/projectiles/allparticles.png", ContentManagerName);
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/baseentities/basestructure/rangecircletexture.png", ContentManagerName))
                {
                    registerUnload = true;
                }
                RangeCircleTexture = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/baseentities/basestructure/rangecircletexture.png", ContentManagerName);
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/baseentities/basestructure/minrangecircletexture.png", ContentManagerName))
                {
                    registerUnload = true;
                }
                MinRangeCircleTexture = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/baseentities/basestructure/minrangecircletexture.png", ContentManagerName);
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/baseentities/basestructure/structureglowanimationchainlist.achx", ContentManagerName))
                {
                    registerUnload = true;
                }
                StructureGlowAnimationChainList = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/baseentities/basestructure/structureglowanimationchainlist.achx", ContentManagerName);
            }
            if (registerUnload && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BaseStructureStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
            }
            CustomLoadStaticContent(contentManagerName);
        }
        public static void UnloadStaticContent () 
        {
            if (LoadedContentManagers.Count != 0)
            {
                LoadedContentManagers.RemoveAt(0);
                mRegisteredUnloads.RemoveAt(0);
            }
            if (LoadedContentManagers.Count == 0)
            {
                if (BaseStructureAnimationChainListFile != null)
                {
                    BaseStructureAnimationChainListFile= null;
                }
                if (AllParticles != null)
                {
                    AllParticles= null;
                }
                if (RangeCircleTexture != null)
                {
                    RangeCircleTexture= null;
                }
                if (MinRangeCircleTexture != null)
                {
                    MinRangeCircleTexture= null;
                }
                if (StructureGlowAnimationChainList != null)
                {
                    StructureGlowAnimationChainList= null;
                }
            }
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
                case  VariableState.ValidLocation:
                    SpriteInstance.RedRate = (0f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (255f - SpriteInstance.Green) / (float)secondsToTake;
                    break;
                case  VariableState.InvalidLocation:
                    SpriteInstance.RedRate = (255f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (0f - SpriteInstance.Green) / (float)secondsToTake;
                    break;
                case  VariableState.Built:
                    SpriteInstance.RedRate = (0f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (0f - SpriteInstance.Green) / (float)secondsToTake;
                    break;
                case  VariableState.CantAfford:
                    SpriteInstance.RedRate = (255f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (255f - SpriteInstance.Green) / (float)secondsToTake;
                    break;
                case  VariableState.Selected:
                    SpriteInstance.RedRate = (0f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (255f - SpriteInstance.Green) / (float)secondsToTake;
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
                case  VariableState.ValidLocation:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    break;
                case  VariableState.InvalidLocation:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    break;
                case  VariableState.Built:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    break;
                case  VariableState.CantAfford:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    break;
                case  VariableState.Selected:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
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
            bool setSpriteInstanceRed = true;
            float SpriteInstanceRedFirstValue= 0;
            float SpriteInstanceRedSecondValue= 0;
            bool setSpriteInstanceGreen = true;
            float SpriteInstanceGreenFirstValue= 0;
            float SpriteInstanceGreenSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.ValidLocation:
                    SpriteInstanceRedFirstValue = 0f;
                    SpriteInstanceGreenFirstValue = 255f;
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    break;
                case  VariableState.InvalidLocation:
                    SpriteInstanceRedFirstValue = 255f;
                    SpriteInstanceGreenFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    break;
                case  VariableState.Built:
                    SpriteInstanceRedFirstValue = 0f;
                    SpriteInstanceGreenFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                    }
                    break;
                case  VariableState.CantAfford:
                    SpriteInstanceRedFirstValue = 255f;
                    SpriteInstanceGreenFirstValue = 255f;
                    break;
                case  VariableState.Selected:
                    SpriteInstanceRedFirstValue = 0f;
                    SpriteInstanceGreenFirstValue = 255f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.ValidLocation:
                    SpriteInstanceRedSecondValue = 0f;
                    SpriteInstanceGreenSecondValue = 255f;
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    break;
                case  VariableState.InvalidLocation:
                    SpriteInstanceRedSecondValue = 255f;
                    SpriteInstanceGreenSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    break;
                case  VariableState.Built:
                    SpriteInstanceRedSecondValue = 0f;
                    SpriteInstanceGreenSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                    }
                    break;
                case  VariableState.CantAfford:
                    SpriteInstanceRedSecondValue = 255f;
                    SpriteInstanceGreenSecondValue = 255f;
                    break;
                case  VariableState.Selected:
                    SpriteInstanceRedSecondValue = 0f;
                    SpriteInstanceGreenSecondValue = 255f;
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
            if (interpolationValue < 1)
            {
                mCurrentState = (int)firstState;
            }
            else
            {
                mCurrentState = (int)secondState;
            }
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (OnOff stateToInterpolateTo, double secondsToTake) 
        {
            switch(stateToInterpolateTo)
            {
                case  OnOff.On:
                    LightSpriteInstance.RedRate = (1f - LightSpriteInstance.Red) / (float)secondsToTake;
                    LightSpriteInstance.GreenRate = (1f - LightSpriteInstance.Green) / (float)secondsToTake;
                    LightSpriteInstance.BlueRate = (1f - LightSpriteInstance.Blue) / (float)secondsToTake;
                    break;
                case  OnOff.Off:
                    LightSpriteInstance.RedRate = (1f - LightSpriteInstance.Red) / (float)secondsToTake;
                    LightSpriteInstance.GreenRate = (0.1f - LightSpriteInstance.Green) / (float)secondsToTake;
                    LightSpriteInstance.BlueRate = (0.1f - LightSpriteInstance.Blue) / (float)secondsToTake;
                    break;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<OnOff>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (OnOff stateToStop) 
        {
            switch(stateToStop)
            {
                case  OnOff.On:
                    LightSpriteInstance.RedRate =  0;
                    LightSpriteInstance.GreenRate =  0;
                    LightSpriteInstance.BlueRate =  0;
                    break;
                case  OnOff.Off:
                    LightSpriteInstance.RedRate =  0;
                    LightSpriteInstance.GreenRate =  0;
                    LightSpriteInstance.BlueRate =  0;
                    break;
            }
            CurrentOnOffState = stateToStop;
        }
        public void InterpolateBetween (OnOff firstState, OnOff secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setLightSpriteInstanceRed = true;
            float LightSpriteInstanceRedFirstValue= 0;
            float LightSpriteInstanceRedSecondValue= 0;
            bool setLightSpriteInstanceGreen = true;
            float LightSpriteInstanceGreenFirstValue= 0;
            float LightSpriteInstanceGreenSecondValue= 0;
            bool setLightSpriteInstanceBlue = true;
            float LightSpriteInstanceBlueFirstValue= 0;
            float LightSpriteInstanceBlueSecondValue= 0;
            switch(firstState)
            {
                case  OnOff.On:
                    LightSpriteInstanceRedFirstValue = 1f;
                    LightSpriteInstanceGreenFirstValue = 1f;
                    LightSpriteInstanceBlueFirstValue = 1f;
                    break;
                case  OnOff.Off:
                    LightSpriteInstanceRedFirstValue = 1f;
                    LightSpriteInstanceGreenFirstValue = 0.1f;
                    LightSpriteInstanceBlueFirstValue = 0.1f;
                    break;
            }
            switch(secondState)
            {
                case  OnOff.On:
                    LightSpriteInstanceRedSecondValue = 1f;
                    LightSpriteInstanceGreenSecondValue = 1f;
                    LightSpriteInstanceBlueSecondValue = 1f;
                    break;
                case  OnOff.Off:
                    LightSpriteInstanceRedSecondValue = 1f;
                    LightSpriteInstanceGreenSecondValue = 0.1f;
                    LightSpriteInstanceBlueSecondValue = 0.1f;
                    break;
            }
            if (setLightSpriteInstanceRed)
            {
                LightSpriteInstanceRed = LightSpriteInstanceRedFirstValue * (1 - interpolationValue) + LightSpriteInstanceRedSecondValue * interpolationValue;
            }
            if (setLightSpriteInstanceGreen)
            {
                LightSpriteInstanceGreen = LightSpriteInstanceGreenFirstValue * (1 - interpolationValue) + LightSpriteInstanceGreenSecondValue * interpolationValue;
            }
            if (setLightSpriteInstanceBlue)
            {
                LightSpriteInstanceBlue = LightSpriteInstanceBlueFirstValue * (1 - interpolationValue) + LightSpriteInstanceBlueSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentOnOffState = (int)firstState;
            }
            else
            {
                mCurrentOnOffState = (int)secondState;
            }
        }
        public static void PreloadStateContent (VariableState state, string contentManagerName) 
        {
            ContentManagerName = contentManagerName;
            switch(state)
            {
                case  VariableState.ValidLocation:
                    break;
                case  VariableState.InvalidLocation:
                    break;
                case  VariableState.Built:
                    break;
                case  VariableState.CantAfford:
                    break;
                case  VariableState.Selected:
                    break;
            }
        }
        public static void PreloadStateContent (OnOff state, string contentManagerName) 
        {
            ContentManagerName = contentManagerName;
            switch(state)
            {
                case  OnOff.On:
                    break;
                case  OnOff.Off:
                    break;
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "BaseStructureAnimationChainListFile":
                    return BaseStructureAnimationChainListFile;
                case  "AllParticles":
                    return AllParticles;
                case  "RangeCircleTexture":
                    return RangeCircleTexture;
                case  "MinRangeCircleTexture":
                    return MinRangeCircleTexture;
                case  "StructureGlowAnimationChainList":
                    return StructureGlowAnimationChainList;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "BaseStructureAnimationChainListFile":
                    return BaseStructureAnimationChainListFile;
                case  "AllParticles":
                    return AllParticles;
                case  "RangeCircleTexture":
                    return RangeCircleTexture;
                case  "MinRangeCircleTexture":
                    return MinRangeCircleTexture;
                case  "StructureGlowAnimationChainList":
                    return StructureGlowAnimationChainList;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "BaseStructureAnimationChainListFile":
                    return BaseStructureAnimationChainListFile;
                case  "AllParticles":
                    return AllParticles;
                case  "RangeCircleTexture":
                    return RangeCircleTexture;
                case  "MinRangeCircleTexture":
                    return MinRangeCircleTexture;
                case  "StructureGlowAnimationChainList":
                    return StructureGlowAnimationChainList;
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
            if (LightSpriteInstance.Alpha != 0 && LightSpriteInstance.AbsoluteVisible && cursor.IsOn3D(LightSpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (cursor.IsOn3D(RangeCircleInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (AimSpriteInstance.Alpha != 0 && AimSpriteInstance.AbsoluteVisible && cursor.IsOn3D(AimSpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (cursor.IsOn3D(MinimumRangeCircleInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (RangePreviewSprite.Alpha != 0 && RangePreviewSprite.AbsoluteVisible && cursor.IsOn3D(RangePreviewSprite, LayerProvidedByContainer))
            {
                return true;
            }
            if (LightAimSpriteInstance.Alpha != 0 && LightAimSpriteInstance.AbsoluteVisible && cursor.IsOn3D(LightAimSpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (WarpSpriteInstance.Alpha != 0 && WarpSpriteInstance.AbsoluteVisible && cursor.IsOn3D(WarpSpriteInstance, LayerProvidedByContainer))
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
            if (AxisAlignedRectangleInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(AxisAlignedRectangleInstance);
            }
            if (LightSpriteInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightSpriteInstance);
            }
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(RangeCircleInstance);
            if (AimSpriteInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(AimSpriteInstance);
            }
            if (PivotPoint != null)
            {
            }
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(MinimumRangeCircleInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(RangePreviewSprite);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightAimSpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(WarpSpriteInstance);
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
                layerToRemoveFrom.Remove(AxisAlignedRectangleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(AxisAlignedRectangleInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(LightSpriteInstance);
            }
            FlatRedBall.SpriteManager.AddToLayer(LightSpriteInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(RangeCircleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(RangeCircleInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(AimSpriteInstance);
            }
            FlatRedBall.SpriteManager.AddToLayer(AimSpriteInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(MinimumRangeCircleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(MinimumRangeCircleInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(RangePreviewSprite);
            }
            FlatRedBall.SpriteManager.AddToLayer(RangePreviewSprite, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(LightAimSpriteInstance);
            }
            FlatRedBall.SpriteManager.AddToLayer(LightAimSpriteInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(WarpSpriteInstance);
            }
            FlatRedBall.SpriteManager.AddToLayer(WarpSpriteInstance, layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
    }
    public static class BaseStructureExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<BaseStructure> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
