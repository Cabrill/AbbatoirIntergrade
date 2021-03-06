#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Graphics.Animation;
namespace AbbatoirIntergrade.Entities.Projectiles
{
    public partial class ElectricProjectile : AbbatoirIntergrade.Entities.BaseEntities.BasePlayerProjectile, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Performance.IPoolable, FlatRedBall.Graphics.IVisible, FlatRedBall.Math.Geometry.ICollidable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static new string ContentManagerName
        {
            get
            {
                return AbbatoirIntergrade.Entities.BaseEntities.BasePlayerProjectile.ContentManagerName;
            }
            set
            {
                AbbatoirIntergrade.Entities.BaseEntities.BasePlayerProjectile.ContentManagerName = value;
            }
        }
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static FlatRedBall.Graphics.Animation.AnimationChainList ElectricProjectileAnimationChainListFile;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect ElectricImpact1;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect ElectricImpact2;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect ElectricImpact3;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect ElectricGroundImpact1;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect ElectricGroundImpact2;
        
        private FlatRedBall.Math.Geometry.AxisAlignedRectangle mAxisAlignedRectangleInstance;
        public FlatRedBall.Math.Geometry.AxisAlignedRectangle AxisAlignedRectangleInstance
        {
            get
            {
                return mAxisAlignedRectangleInstance;
            }
            private set
            {
                mAxisAlignedRectangleInstance = value;
            }
        }
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
        public int Index { get; set; }
        public bool Used { get; set; }
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
        private FlatRedBall.Math.Geometry.ShapeCollection mGeneratedCollision;
        public FlatRedBall.Math.Geometry.ShapeCollection Collision
        {
            get
            {
                return mGeneratedCollision;
            }
        }
        public ElectricProjectile () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public ElectricProjectile (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public ElectricProjectile (string contentManagerName, bool addToManagers) 
        	: base(contentManagerName, addToManagers)
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
        }
        protected override void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            mAxisAlignedRectangleInstance = new FlatRedBall.Math.Geometry.AxisAlignedRectangle();
            mAxisAlignedRectangleInstance.Name = "mAxisAlignedRectangleInstance";
            AnimationChainInstance = new FlatRedBall.Graphics.Animation.AnimationChain();
            AnimationChainInstance.Name = "AnimationChainInstance";
            
            base.InitializeEntity(addToManagers);
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteXReset = LightOrShadowSprite.X;
            }
            else
            {
                LightOrShadowSpriteXReset = LightOrShadowSprite.RelativeX;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteYReset = LightOrShadowSprite.Y;
            }
            else
            {
                LightOrShadowSpriteYReset = LightOrShadowSprite.RelativeY;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteZReset = LightOrShadowSprite.Z;
            }
            else
            {
                LightOrShadowSpriteZReset = LightOrShadowSprite.RelativeZ;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteXVelocityReset = LightOrShadowSprite.XVelocity;
            }
            else
            {
                LightOrShadowSpriteXVelocityReset = LightOrShadowSprite.RelativeXVelocity;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteYVelocityReset = LightOrShadowSprite.YVelocity;
            }
            else
            {
                LightOrShadowSpriteYVelocityReset = LightOrShadowSprite.RelativeYVelocity;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteZVelocityReset = LightOrShadowSprite.ZVelocity;
            }
            else
            {
                LightOrShadowSpriteZVelocityReset = LightOrShadowSprite.RelativeZVelocity;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteRotationXReset = LightOrShadowSprite.RotationX;
            }
            else
            {
                LightOrShadowSpriteRotationXReset = LightOrShadowSprite.RelativeRotationX;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteRotationYReset = LightOrShadowSprite.RotationY;
            }
            else
            {
                LightOrShadowSpriteRotationYReset = LightOrShadowSprite.RelativeRotationY;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteRotationZReset = LightOrShadowSprite.RotationZ;
            }
            else
            {
                LightOrShadowSpriteRotationZReset = LightOrShadowSprite.RelativeRotationZ;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteRotationXVelocityReset = LightOrShadowSprite.RotationXVelocity;
            }
            else
            {
                LightOrShadowSpriteRotationXVelocityReset = LightOrShadowSprite.RelativeRotationXVelocity;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteRotationYVelocityReset = LightOrShadowSprite.RotationYVelocity;
            }
            else
            {
                LightOrShadowSpriteRotationYVelocityReset = LightOrShadowSprite.RelativeRotationYVelocity;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSpriteRotationZVelocityReset = LightOrShadowSprite.RotationZVelocity;
            }
            else
            {
                LightOrShadowSpriteRotationZVelocityReset = LightOrShadowSprite.RelativeRotationZVelocity;
            }
            LightOrShadowSpriteAlphaReset = LightOrShadowSprite.Alpha;
            LightOrShadowSpriteAlphaRateReset = LightOrShadowSprite.AlphaRate;
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceXReset = SpriteInstance.X;
            }
            else
            {
                SpriteInstanceXReset = SpriteInstance.RelativeX;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceYReset = SpriteInstance.Y;
            }
            else
            {
                SpriteInstanceYReset = SpriteInstance.RelativeY;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceZReset = SpriteInstance.Z;
            }
            else
            {
                SpriteInstanceZReset = SpriteInstance.RelativeZ;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceXVelocityReset = SpriteInstance.XVelocity;
            }
            else
            {
                SpriteInstanceXVelocityReset = SpriteInstance.RelativeXVelocity;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceYVelocityReset = SpriteInstance.YVelocity;
            }
            else
            {
                SpriteInstanceYVelocityReset = SpriteInstance.RelativeYVelocity;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceZVelocityReset = SpriteInstance.ZVelocity;
            }
            else
            {
                SpriteInstanceZVelocityReset = SpriteInstance.RelativeZVelocity;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationXReset = SpriteInstance.RotationX;
            }
            else
            {
                SpriteInstanceRotationXReset = SpriteInstance.RelativeRotationX;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationYReset = SpriteInstance.RotationY;
            }
            else
            {
                SpriteInstanceRotationYReset = SpriteInstance.RelativeRotationY;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationZReset = SpriteInstance.RotationZ;
            }
            else
            {
                SpriteInstanceRotationZReset = SpriteInstance.RelativeRotationZ;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationXVelocityReset = SpriteInstance.RotationXVelocity;
            }
            else
            {
                SpriteInstanceRotationXVelocityReset = SpriteInstance.RelativeRotationXVelocity;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationYVelocityReset = SpriteInstance.RotationYVelocity;
            }
            else
            {
                SpriteInstanceRotationYVelocityReset = SpriteInstance.RelativeRotationYVelocity;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationZVelocityReset = SpriteInstance.RotationZVelocity;
            }
            else
            {
                SpriteInstanceRotationZVelocityReset = SpriteInstance.RelativeRotationZVelocity;
            }
            SpriteInstanceAlphaReset = SpriteInstance.Alpha;
            SpriteInstanceAlphaRateReset = SpriteInstance.AlphaRate;
        }
        public override void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            base.ReAddToManagers(layerToAddTo);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mAxisAlignedRectangleInstance, LayerProvidedByContainer);
        }
        public override void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mAxisAlignedRectangleInstance, LayerProvidedByContainer);
            base.AddToManagers(layerToAddTo);
            CustomInitialize();
        }
        public override void Activity () 
        {
            base.Activity();
            
            CustomActivity();
        }
        public override void Destroy () 
        {
            if (Used)
            {
                Factories.ElectricProjectileFactory.MakeUnused(this, false);
            }
            base.Destroy();
            
            if (AxisAlignedRectangleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(AxisAlignedRectangleInstance);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            if (mAxisAlignedRectangleInstance.Parent == null)
            {
                mAxisAlignedRectangleInstance.CopyAbsoluteToRelative();
                mAxisAlignedRectangleInstance.AttachTo(this, false);
            }
            AxisAlignedRectangleInstance.Width = 32f;
            AxisAlignedRectangleInstance.Height = 32f;
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.CopyAbsoluteToRelative();
                LightOrShadowSprite.AttachTo(this, false);
            }
            if (LightOrShadowSprite.Parent == null)
            {
                base.LightOrShadowSprite.Z = -1f;
            }
            else
            {
                base.LightOrShadowSprite.RelativeZ = -1f;
            }
            base.LightOrShadowSprite.Texture = AllParticles;
            base.LightOrShadowSprite.LeftTexturePixel = 1792f;
            base.LightOrShadowSprite.RightTexturePixel = 2048f;
            base.LightOrShadowSprite.TopTexturePixel = 1792f;
            base.LightOrShadowSprite.BottomTexturePixel = 2048f;
            base.LightOrShadowSprite.TextureScale = 1f;
            base.LightOrShadowSprite.AnimationChains = BaseProjectileLightAnimationChainListFile;
            base.LightOrShadowSprite.CurrentChainName = "Light_Shot";
            #if FRB_MDX
            LightOrShadowSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightOrShadowSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightOrShadowSprite.Red = 0.8f;
            base.LightOrShadowSprite.Green = 0.8f;
            base.LightOrShadowSprite.Blue = 0.9f;
            base.LightOrShadowSprite.Alpha = 0.3f;
            base.LightOrShadowSprite.ParentRotationChangesPosition = false;
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.CopyAbsoluteToRelative();
                SpriteInstance.AttachTo(this, false);
            }
            if (SpriteInstance.Parent == null)
            {
                base.SpriteInstance.Z = 1f;
            }
            else
            {
                base.SpriteInstance.RelativeZ = 1f;
            }
            base.SpriteInstance.TextureScale = 0.5f;
            base.SpriteInstance.AnimationChains = ElectricProjectileAnimationChainListFile;
            base.SpriteInstance.CurrentChainName = "Shot";
            base.SpriteInstance.Visible = true;
            base.SpriteInstance.ParentRotationChangesPosition = false;
            if (mCircleInstance.Parent == null)
            {
                mCircleInstance.CopyAbsoluteToRelative();
                mCircleInstance.AttachTo(this, false);
            }
            base.CircleInstance.Radius = 16f;
            base.CircleInstance.Color = Microsoft.Xna.Framework.Color.Red;
            base.CircleInstance.ParentRotationChangesPosition = false;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            mGeneratedCollision.AxisAlignedRectangles.AddOneWay(mAxisAlignedRectangleInstance);
            mGeneratedCollision.Circles.AddOneWay(mCircleInstance);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            base.AddToManagersBottomUp(layerToAddTo);
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            if (AxisAlignedRectangleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(AxisAlignedRectangleInstance);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
            }
            AxisAlignedRectangleInstance.Width = 32f;
            AxisAlignedRectangleInstance.Height = 32f;
            if (LightOrShadowSprite.Parent == null)
            {
                base.LightOrShadowSprite.Z = -1f;
            }
            else
            {
                base.LightOrShadowSprite.RelativeZ = -1f;
            }
            base.LightOrShadowSprite.Texture = AllParticles;
            base.LightOrShadowSprite.LeftTexturePixel = 1792f;
            base.LightOrShadowSprite.RightTexturePixel = 2048f;
            base.LightOrShadowSprite.TopTexturePixel = 1792f;
            base.LightOrShadowSprite.BottomTexturePixel = 2048f;
            base.LightOrShadowSprite.TextureScale = 1f;
            base.LightOrShadowSprite.AnimationChains = BaseProjectileLightAnimationChainListFile;
            base.LightOrShadowSprite.CurrentChainName = "Light_Shot";
            #if FRB_MDX
            LightOrShadowSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightOrShadowSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightOrShadowSprite.Red = 0.8f;
            base.LightOrShadowSprite.Green = 0.8f;
            base.LightOrShadowSprite.Blue = 0.9f;
            base.LightOrShadowSprite.Alpha = 0.3f;
            base.LightOrShadowSprite.ParentRotationChangesPosition = false;
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.X = LightOrShadowSpriteXReset;
            }
            else
            {
                LightOrShadowSprite.RelativeX = LightOrShadowSpriteXReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.Y = LightOrShadowSpriteYReset;
            }
            else
            {
                LightOrShadowSprite.RelativeY = LightOrShadowSpriteYReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.Z = LightOrShadowSpriteZReset;
            }
            else
            {
                LightOrShadowSprite.RelativeZ = LightOrShadowSpriteZReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.XVelocity = LightOrShadowSpriteXVelocityReset;
            }
            else
            {
                LightOrShadowSprite.RelativeXVelocity = LightOrShadowSpriteXVelocityReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.YVelocity = LightOrShadowSpriteYVelocityReset;
            }
            else
            {
                LightOrShadowSprite.RelativeYVelocity = LightOrShadowSpriteYVelocityReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.ZVelocity = LightOrShadowSpriteZVelocityReset;
            }
            else
            {
                LightOrShadowSprite.RelativeZVelocity = LightOrShadowSpriteZVelocityReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.RotationX = LightOrShadowSpriteRotationXReset;
            }
            else
            {
                LightOrShadowSprite.RelativeRotationX = LightOrShadowSpriteRotationXReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.RotationY = LightOrShadowSpriteRotationYReset;
            }
            else
            {
                LightOrShadowSprite.RelativeRotationY = LightOrShadowSpriteRotationYReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.RotationZ = LightOrShadowSpriteRotationZReset;
            }
            else
            {
                LightOrShadowSprite.RelativeRotationZ = LightOrShadowSpriteRotationZReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.RotationXVelocity = LightOrShadowSpriteRotationXVelocityReset;
            }
            else
            {
                LightOrShadowSprite.RelativeRotationXVelocity = LightOrShadowSpriteRotationXVelocityReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.RotationYVelocity = LightOrShadowSpriteRotationYVelocityReset;
            }
            else
            {
                LightOrShadowSprite.RelativeRotationYVelocity = LightOrShadowSpriteRotationYVelocityReset;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.RotationZVelocity = LightOrShadowSpriteRotationZVelocityReset;
            }
            else
            {
                LightOrShadowSprite.RelativeRotationZVelocity = LightOrShadowSpriteRotationZVelocityReset;
            }
            LightOrShadowSprite.Alpha = LightOrShadowSpriteAlphaReset;
            LightOrShadowSprite.AlphaRate = LightOrShadowSpriteAlphaRateReset;
            if (SpriteInstance.Parent == null)
            {
                base.SpriteInstance.Z = 1f;
            }
            else
            {
                base.SpriteInstance.RelativeZ = 1f;
            }
            base.SpriteInstance.TextureScale = 0.5f;
            base.SpriteInstance.AnimationChains = ElectricProjectileAnimationChainListFile;
            base.SpriteInstance.CurrentChainName = "Shot";
            base.SpriteInstance.Visible = true;
            base.SpriteInstance.ParentRotationChangesPosition = false;
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.X = SpriteInstanceXReset;
            }
            else
            {
                SpriteInstance.RelativeX = SpriteInstanceXReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.Y = SpriteInstanceYReset;
            }
            else
            {
                SpriteInstance.RelativeY = SpriteInstanceYReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.Z = SpriteInstanceZReset;
            }
            else
            {
                SpriteInstance.RelativeZ = SpriteInstanceZReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.XVelocity = SpriteInstanceXVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeXVelocity = SpriteInstanceXVelocityReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.YVelocity = SpriteInstanceYVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeYVelocity = SpriteInstanceYVelocityReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.ZVelocity = SpriteInstanceZVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeZVelocity = SpriteInstanceZVelocityReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationX = SpriteInstanceRotationXReset;
            }
            else
            {
                SpriteInstance.RelativeRotationX = SpriteInstanceRotationXReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationY = SpriteInstanceRotationYReset;
            }
            else
            {
                SpriteInstance.RelativeRotationY = SpriteInstanceRotationYReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationZ = SpriteInstanceRotationZReset;
            }
            else
            {
                SpriteInstance.RelativeRotationZ = SpriteInstanceRotationZReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationXVelocity = SpriteInstanceRotationXVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeRotationXVelocity = SpriteInstanceRotationXVelocityReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationYVelocity = SpriteInstanceRotationYVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeRotationYVelocity = SpriteInstanceRotationYVelocityReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationZVelocity = SpriteInstanceRotationZVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeRotationZVelocity = SpriteInstanceRotationZVelocityReset;
            }
            SpriteInstance.Alpha = SpriteInstanceAlphaReset;
            SpriteInstance.AlphaRate = SpriteInstanceAlphaRateReset;
            base.CircleInstance.Radius = 16f;
            base.CircleInstance.Color = Microsoft.Xna.Framework.Color.Red;
            base.CircleInstance.ParentRotationChangesPosition = false;
            HasLightSource = true;
            Mass = 0.001f;
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
        }
        public static new void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            // Set to use global content
            contentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            AbbatoirIntergrade.Entities.BaseEntities.BasePlayerProjectile.LoadStaticContent(contentManagerName);
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("ElectricProjectileStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                ElectricProjectileAnimationChainListFile = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/projectiles/electricprojectile/electricprojectileanimationchainlistfile.achx", ContentManagerName);
                ElectricImpact1 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/projectiles/electricprojectile/electricimpact1", ContentManagerName);
                ElectricImpact2 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/projectiles/electricprojectile/electricimpact2", ContentManagerName);
                ElectricImpact3 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/projectiles/electricprojectile/electricimpact3", ContentManagerName);
                ElectricGroundImpact1 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/projectiles/electricprojectile/electricgroundimpact1", ContentManagerName);
                ElectricGroundImpact2 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/projectiles/electricprojectile/electricgroundimpact2", ContentManagerName);
            }
            CustomLoadStaticContent(contentManagerName);
        }
        public static new void UnloadStaticContent () 
        {
            // Intentionally left blank because this element uses global content, so it should never be unloaded
        }
        [System.Obsolete("Use GetFile instead")]
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "ElectricProjectileAnimationChainListFile":
                    return ElectricProjectileAnimationChainListFile;
                case  "ElectricImpact1":
                    return ElectricImpact1;
                case  "ElectricImpact2":
                    return ElectricImpact2;
                case  "ElectricImpact3":
                    return ElectricImpact3;
                case  "ElectricGroundImpact1":
                    return ElectricGroundImpact1;
                case  "ElectricGroundImpact2":
                    return ElectricGroundImpact2;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "ElectricProjectileAnimationChainListFile":
                    return ElectricProjectileAnimationChainListFile;
                case  "ElectricImpact1":
                    return ElectricImpact1;
                case  "ElectricImpact2":
                    return ElectricImpact2;
                case  "ElectricImpact3":
                    return ElectricImpact3;
                case  "ElectricGroundImpact1":
                    return ElectricGroundImpact1;
                case  "ElectricGroundImpact2":
                    return ElectricGroundImpact2;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "ElectricProjectileAnimationChainListFile":
                    return ElectricProjectileAnimationChainListFile;
                case  "ElectricImpact1":
                    return ElectricImpact1;
                case  "ElectricImpact2":
                    return ElectricImpact2;
                case  "ElectricImpact3":
                    return ElectricImpact3;
                case  "ElectricGroundImpact1":
                    return ElectricGroundImpact1;
                case  "ElectricGroundImpact2":
                    return ElectricGroundImpact2;
            }
            return null;
        }
        public override void SetToIgnorePausing () 
        {
            base.SetToIgnorePausing();
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(AxisAlignedRectangleInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightOrShadowSprite);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(CircleInstance);
        }
        public override void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer; // assign before calling base so removal is not impacted by base call
            base.MoveToLayer(layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(AxisAlignedRectangleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(AxisAlignedRectangleInstance, layerToMoveTo);
        }
    }
    public static class ElectricProjectileExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<ElectricProjectile> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
