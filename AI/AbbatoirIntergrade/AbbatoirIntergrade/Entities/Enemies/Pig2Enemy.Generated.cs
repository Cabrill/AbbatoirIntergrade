#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using AbbatoirIntergrade.Screens;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using AbbatoirIntergrade.Performance;
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
namespace AbbatoirIntergrade.Entities.Enemies
{
    public partial class Pig2Enemy : AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Performance.IPoolable, FlatRedBall.Graphics.IVisible, FlatRedBall.Gui.IClickable, FlatRedBall.Math.Geometry.ICollidable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static new string ContentManagerName
        {
            get
            {
                return AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy.ContentManagerName;
            }
            set
            {
                AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy.ContentManagerName = value;
            }
        }
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static FlatRedBall.Graphics.Animation.AnimationChainList Pig2Animations;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D Stage2;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Pig2Death1;
        
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
        static float LightSpriteXReset;
        static float LightSpriteYReset;
        static float LightSpriteZReset;
        static float LightSpriteXVelocityReset;
        static float LightSpriteYVelocityReset;
        static float LightSpriteZVelocityReset;
        static float LightSpriteRotationXReset;
        static float LightSpriteRotationYReset;
        static float LightSpriteRotationZReset;
        static float LightSpriteRotationXVelocityReset;
        static float LightSpriteRotationYVelocityReset;
        static float LightSpriteRotationZVelocityReset;
        static float LightSpriteAlphaReset;
        static float LightSpriteAlphaRateReset;
        public override string SpriteInstanceCurrentChainName
        {
            set
            {
                base.SpriteInstanceCurrentChainName = value;
            }
            get
            {
                return base.SpriteInstanceCurrentChainName;
            }
        }
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
        public Pig2Enemy () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public Pig2Enemy (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public Pig2Enemy (string contentManagerName, bool addToManagers) 
        	: base(contentManagerName, addToManagers)
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
           
        }
        protected override void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            mSpriteInstance = new FlatRedBall.Sprite();
            mSpriteInstance.Name = "mSpriteInstance";
            LightSprite = new FlatRedBall.Sprite();
            LightSprite.Name = "LightSprite";
            mAxisAlignedRectangleInstance = new FlatRedBall.Math.Geometry.AxisAlignedRectangle();
            mAxisAlignedRectangleInstance.Name = "mAxisAlignedRectangleInstance";
            
            base.InitializeEntity(addToManagers);
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
            if (LightSprite.Parent == null)
            {
                LightSpriteXReset = LightSprite.X;
            }
            else
            {
                LightSpriteXReset = LightSprite.RelativeX;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteYReset = LightSprite.Y;
            }
            else
            {
                LightSpriteYReset = LightSprite.RelativeY;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteZReset = LightSprite.Z;
            }
            else
            {
                LightSpriteZReset = LightSprite.RelativeZ;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteXVelocityReset = LightSprite.XVelocity;
            }
            else
            {
                LightSpriteXVelocityReset = LightSprite.RelativeXVelocity;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteYVelocityReset = LightSprite.YVelocity;
            }
            else
            {
                LightSpriteYVelocityReset = LightSprite.RelativeYVelocity;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteZVelocityReset = LightSprite.ZVelocity;
            }
            else
            {
                LightSpriteZVelocityReset = LightSprite.RelativeZVelocity;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteRotationXReset = LightSprite.RotationX;
            }
            else
            {
                LightSpriteRotationXReset = LightSprite.RelativeRotationX;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteRotationYReset = LightSprite.RotationY;
            }
            else
            {
                LightSpriteRotationYReset = LightSprite.RelativeRotationY;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteRotationZReset = LightSprite.RotationZ;
            }
            else
            {
                LightSpriteRotationZReset = LightSprite.RelativeRotationZ;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteRotationXVelocityReset = LightSprite.RotationXVelocity;
            }
            else
            {
                LightSpriteRotationXVelocityReset = LightSprite.RelativeRotationXVelocity;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteRotationYVelocityReset = LightSprite.RotationYVelocity;
            }
            else
            {
                LightSpriteRotationYVelocityReset = LightSprite.RelativeRotationYVelocity;
            }
            if (LightSprite.Parent == null)
            {
                LightSpriteRotationZVelocityReset = LightSprite.RotationZVelocity;
            }
            else
            {
                LightSpriteRotationZVelocityReset = LightSprite.RelativeRotationZVelocity;
            }
            LightSpriteAlphaReset = LightSprite.Alpha;
            LightSpriteAlphaRateReset = LightSprite.AlphaRate;
        }
        public override void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            base.ReAddToManagers(layerToAddTo);
            FlatRedBall.SpriteManager.AddToLayer(mSpriteInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(LightSprite, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mAxisAlignedRectangleInstance, LayerProvidedByContainer);
        }
        public override void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddToLayer(mSpriteInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(LightSprite, LayerProvidedByContainer);
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
                Factories.Pig2EnemyFactory.MakeUnused(this, false);
            }
            base.Destroy();
            
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (LightSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightSprite);
            }
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
            if (mSpriteInstance.Parent == null)
            {
                mSpriteInstance.CopyAbsoluteToRelative();
                mSpriteInstance.AttachTo(this, false);
            }
            base.SpriteInstance.Texture = Stage2;
            base.SpriteInstance.LeftTexturePixel = 3f;
            base.SpriteInstance.RightTexturePixel = 142f;
            base.SpriteInstance.TopTexturePixel = 373f;
            base.SpriteInstance.BottomTexturePixel = 760f;
            base.SpriteInstance.TextureScale = 1f;
            base.SpriteInstance.UseAnimationRelativePosition = true;
            base.SpriteInstance.AnimationChains = Pig2Animations;
            base.SpriteInstance.CurrentChainName = "Running";
            base.SpriteInstance.IgnoreAnimationChainTextureFlip = true;
            if (LightSprite.Parent == null)
            {
                LightSprite.CopyAbsoluteToRelative();
                LightSprite.AttachTo(this, false);
            }
            if (LightSprite.Parent == null)
            {
                base.LightSprite.X = 0f;
            }
            else
            {
                base.LightSprite.RelativeX = 0f;
            }
            base.LightSprite.Texture = AllAssetsSheet;
            base.LightSprite.LeftTexturePixel = 1792f;
            base.LightSprite.RightTexturePixel = 2048f;
            base.LightSprite.TopTexturePixel = 1792f;
            base.LightSprite.BottomTexturePixel = 2048f;
            base.LightSprite.TextureScale = 1f;
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.CopyAbsoluteToRelative();
                ShadowSprite.AttachTo(this, false);
            }
            if (ShadowSprite.Parent == null)
            {
                base.ShadowSprite.Y = -96f;
            }
            else
            {
                base.ShadowSprite.RelativeY = -96f;
            }
            if (ShadowSprite.Parent == null)
            {
                base.ShadowSprite.Z = -1f;
            }
            else
            {
                base.ShadowSprite.RelativeZ = -1f;
            }
            base.ShadowSprite.Texture = AllParticles;
            base.ShadowSprite.LeftTexturePixel = 1019f;
            base.ShadowSprite.RightTexturePixel = 1072f;
            base.ShadowSprite.TopTexturePixel = 1895f;
            base.ShadowSprite.BottomTexturePixel = 1948f;
            base.ShadowSprite.TextureScale = 1f;
            base.ShadowSprite.Width = 128f;
            base.ShadowSprite.Height = 64f;
            #if FRB_MDX
            ShadowSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.ShadowSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.ShadowSprite.Alpha = 0.3f;
            if (mAxisAlignedRectangleInstance.Parent == null)
            {
                mAxisAlignedRectangleInstance.CopyAbsoluteToRelative();
                mAxisAlignedRectangleInstance.AttachTo(this, false);
            }
            if (AxisAlignedRectangleInstance.Parent == null)
            {
                base.AxisAlignedRectangleInstance.X = 0f;
            }
            else
            {
                base.AxisAlignedRectangleInstance.RelativeX = 0f;
            }
            if (AxisAlignedRectangleInstance.Parent == null)
            {
                base.AxisAlignedRectangleInstance.Y = 0f;
            }
            else
            {
                base.AxisAlignedRectangleInstance.RelativeY = 0f;
            }
            base.AxisAlignedRectangleInstance.Width = 32f;
            base.AxisAlignedRectangleInstance.Height = 32f;
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
            mGeneratedCollision.AxisAlignedRectangles.AddOneWay(mAxisAlignedRectangleInstance);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            base.AddToManagersBottomUp(layerToAddTo);
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (LightSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightSprite);
            }
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
            base.SpriteInstance.Texture = Stage2;
            base.SpriteInstance.LeftTexturePixel = 3f;
            base.SpriteInstance.RightTexturePixel = 142f;
            base.SpriteInstance.TopTexturePixel = 373f;
            base.SpriteInstance.BottomTexturePixel = 760f;
            base.SpriteInstance.TextureScale = 1f;
            base.SpriteInstance.UseAnimationRelativePosition = true;
            base.SpriteInstance.AnimationChains = Pig2Animations;
            base.SpriteInstance.CurrentChainName = "Running";
            base.SpriteInstance.IgnoreAnimationChainTextureFlip = true;
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
            if (LightSprite.Parent == null)
            {
                base.LightSprite.X = 0f;
            }
            else
            {
                base.LightSprite.RelativeX = 0f;
            }
            base.LightSprite.Texture = AllAssetsSheet;
            base.LightSprite.LeftTexturePixel = 1792f;
            base.LightSprite.RightTexturePixel = 2048f;
            base.LightSprite.TopTexturePixel = 1792f;
            base.LightSprite.BottomTexturePixel = 2048f;
            base.LightSprite.TextureScale = 1f;
            if (LightSprite.Parent == null)
            {
                LightSprite.X = LightSpriteXReset;
            }
            else
            {
                LightSprite.RelativeX = LightSpriteXReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.Y = LightSpriteYReset;
            }
            else
            {
                LightSprite.RelativeY = LightSpriteYReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.Z = LightSpriteZReset;
            }
            else
            {
                LightSprite.RelativeZ = LightSpriteZReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.XVelocity = LightSpriteXVelocityReset;
            }
            else
            {
                LightSprite.RelativeXVelocity = LightSpriteXVelocityReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.YVelocity = LightSpriteYVelocityReset;
            }
            else
            {
                LightSprite.RelativeYVelocity = LightSpriteYVelocityReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.ZVelocity = LightSpriteZVelocityReset;
            }
            else
            {
                LightSprite.RelativeZVelocity = LightSpriteZVelocityReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.RotationX = LightSpriteRotationXReset;
            }
            else
            {
                LightSprite.RelativeRotationX = LightSpriteRotationXReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.RotationY = LightSpriteRotationYReset;
            }
            else
            {
                LightSprite.RelativeRotationY = LightSpriteRotationYReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.RotationZ = LightSpriteRotationZReset;
            }
            else
            {
                LightSprite.RelativeRotationZ = LightSpriteRotationZReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.RotationXVelocity = LightSpriteRotationXVelocityReset;
            }
            else
            {
                LightSprite.RelativeRotationXVelocity = LightSpriteRotationXVelocityReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.RotationYVelocity = LightSpriteRotationYVelocityReset;
            }
            else
            {
                LightSprite.RelativeRotationYVelocity = LightSpriteRotationYVelocityReset;
            }
            if (LightSprite.Parent == null)
            {
                LightSprite.RotationZVelocity = LightSpriteRotationZVelocityReset;
            }
            else
            {
                LightSprite.RelativeRotationZVelocity = LightSpriteRotationZVelocityReset;
            }
            LightSprite.Alpha = LightSpriteAlphaReset;
            LightSprite.AlphaRate = LightSpriteAlphaRateReset;
            if (ShadowSprite.Parent == null)
            {
                base.ShadowSprite.Y = -96f;
            }
            else
            {
                base.ShadowSprite.RelativeY = -96f;
            }
            if (ShadowSprite.Parent == null)
            {
                base.ShadowSprite.Z = -1f;
            }
            else
            {
                base.ShadowSprite.RelativeZ = -1f;
            }
            base.ShadowSprite.Texture = AllParticles;
            base.ShadowSprite.LeftTexturePixel = 1019f;
            base.ShadowSprite.RightTexturePixel = 1072f;
            base.ShadowSprite.TopTexturePixel = 1895f;
            base.ShadowSprite.BottomTexturePixel = 1948f;
            base.ShadowSprite.TextureScale = 1f;
            base.ShadowSprite.Width = 128f;
            base.ShadowSprite.Height = 64f;
            #if FRB_MDX
            ShadowSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.ShadowSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.ShadowSprite.Alpha = 0.3f;
            if (AxisAlignedRectangleInstance.Parent == null)
            {
                base.AxisAlignedRectangleInstance.X = 0f;
            }
            else
            {
                base.AxisAlignedRectangleInstance.RelativeX = 0f;
            }
            if (AxisAlignedRectangleInstance.Parent == null)
            {
                base.AxisAlignedRectangleInstance.Y = 0f;
            }
            else
            {
                base.AxisAlignedRectangleInstance.RelativeY = 0f;
            }
            base.AxisAlignedRectangleInstance.Width = 32f;
            base.AxisAlignedRectangleInstance.Height = 32f;
            DisplayName = "Mutant Pig";
            IsFlying = false;
            HasLightSource = false;
            IsJumper = false;
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(LightSprite);
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
            AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy.LoadStaticContent(contentManagerName);
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("Pig2EnemyStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                Pig2Animations = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/screens/gamescreen/monsters/pig2animations.achx", ContentManagerName);
                Stage2 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/gamescreen/monsters/stage2.png", ContentManagerName);
                Pig2Death1 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/enemies/pig2enemy/pig2death1", ContentManagerName);
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
                case  "Pig2Animations":
                    return Pig2Animations;
                case  "Stage2":
                    return Stage2;
                case  "Pig2Death1":
                    return Pig2Death1;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "Pig2Animations":
                    return Pig2Animations;
                case  "Stage2":
                    return Stage2;
                case  "Pig2Death1":
                    return Pig2Death1;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Pig2Animations":
                    return Pig2Animations;
                case  "Stage2":
                    return Stage2;
                case  "Pig2Death1":
                    return Pig2Death1;
            }
            return null;
        }
        public override bool HasCursorOver (FlatRedBall.Gui.Cursor cursor) 
        {
            if (base.HasCursorOver(cursor))
            {
                return true;
            }
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
        public override bool WasClickedThisFrame (FlatRedBall.Gui.Cursor cursor) 
        {
            return cursor.PrimaryClick && HasCursorOver(cursor);
        }
        public override void SetToIgnorePausing () 
        {
            base.SetToIgnorePausing();
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightSprite);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(ShadowSprite);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(AxisAlignedRectangleInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PoisonedParticles);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(FrozenParticles);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SmokeParticles);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(StunParticles);
        }
        public override void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer; // assign before calling base so removal is not impacted by base call
            base.MoveToLayer(layerToMoveTo);
        }
    }
    public static class Pig2EnemyExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<Pig2Enemy> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
