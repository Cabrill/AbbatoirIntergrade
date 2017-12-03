#if ANDROID || IOS
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
namespace AbbatoirIntergrade.Entities.Enemies
{
    public partial class SmallSlime : AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Performance.IPoolable, FlatRedBall.Gui.IClickable, FlatRedBall.Math.Geometry.ICollidable
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
        public enum Jump
        {
            Uninitialized = 0, //This exists so that the first set call actually does something
            Unknown = 1, //This exists so that if the entity is actually a child entity and has set a child state, you will get this
            InAir = 2, 
            Landing = 3, 
            PreparingJump = 4, 
            NotJumping = 5
        }
        protected int mCurrentJumpState = 0;
        public Entities.Enemies.SmallSlime.Jump CurrentJumpState
        {
            get
            {
                if (System.Enum.IsDefined(typeof(Jump), mCurrentJumpState))
                {
                    return (Jump)mCurrentJumpState;
                }
                else
                {
                    return Jump.Unknown;
                }
            }
            set
            {
                mCurrentJumpState = (int)value;
                switch(CurrentJumpState)
                {
                    case  Jump.Uninitialized:
                        break;
                    case  Jump.Unknown:
                        break;
                    case  Jump.InAir:
                        SpriteInstanceCurrentChainName = "InAir";
                        break;
                    case  Jump.Landing:
                        SpriteInstanceCurrentChainName = "Landing";
                        break;
                    case  Jump.PreparingJump:
                        SpriteInstanceCurrentChainName = "PreparingJump";
                        break;
                    case  Jump.NotJumping:
                        break;
                }
            }
        }
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static FlatRedBall.Graphics.Animation.AnimationChainList SlimeAlienAnimationChainListFile;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Slime_Hit;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Slime_Jump;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Slime_Land;
        
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
        static float CircleInstanceXReset;
        static float CircleInstanceYReset;
        static float CircleInstanceZReset;
        static float CircleInstanceXVelocityReset;
        static float CircleInstanceYVelocityReset;
        static float CircleInstanceZVelocityReset;
        static float CircleInstanceRotationXReset;
        static float CircleInstanceRotationYReset;
        static float CircleInstanceRotationZReset;
        static float CircleInstanceRotationXVelocityReset;
        static float CircleInstanceRotationYVelocityReset;
        static float CircleInstanceRotationZVelocityReset;
        static float ShadowSpriteXReset;
        static float ShadowSpriteYReset;
        static float ShadowSpriteZReset;
        static float ShadowSpriteXVelocityReset;
        static float ShadowSpriteYVelocityReset;
        static float ShadowSpriteZVelocityReset;
        static float ShadowSpriteRotationXReset;
        static float ShadowSpriteRotationYReset;
        static float ShadowSpriteRotationZReset;
        static float ShadowSpriteRotationXVelocityReset;
        static float ShadowSpriteRotationYVelocityReset;
        static float ShadowSpriteRotationZVelocityReset;
        static float ShadowSpriteAlphaReset;
        static float ShadowSpriteAlphaRateReset;
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
        private FlatRedBall.Math.Geometry.ShapeCollection mGeneratedCollision;
        public FlatRedBall.Math.Geometry.ShapeCollection Collision
        {
            get
            {
                return mGeneratedCollision;
            }
        }
        public SmallSlime () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public SmallSlime (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public SmallSlime (string contentManagerName, bool addToManagers) 
        	: base(contentManagerName, addToManagers)
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
           
        }
        protected override void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            mSpriteInstance = new FlatRedBall.Sprite();
            mSpriteInstance.Name = "mSpriteInstance";
            mCircleInstance = new FlatRedBall.Math.Geometry.Circle();
            mCircleInstance.Name = "mCircleInstance";
            ShadowSprite = new FlatRedBall.Sprite();
            ShadowSprite.Name = "ShadowSprite";
            LightSprite = new FlatRedBall.Sprite();
            LightSprite.Name = "LightSprite";
            
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
            if (CircleInstance.Parent == null)
            {
                CircleInstanceXReset = CircleInstance.X;
            }
            else
            {
                CircleInstanceXReset = CircleInstance.RelativeX;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceYReset = CircleInstance.Y;
            }
            else
            {
                CircleInstanceYReset = CircleInstance.RelativeY;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceZReset = CircleInstance.Z;
            }
            else
            {
                CircleInstanceZReset = CircleInstance.RelativeZ;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceXVelocityReset = CircleInstance.XVelocity;
            }
            else
            {
                CircleInstanceXVelocityReset = CircleInstance.RelativeXVelocity;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceYVelocityReset = CircleInstance.YVelocity;
            }
            else
            {
                CircleInstanceYVelocityReset = CircleInstance.RelativeYVelocity;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceZVelocityReset = CircleInstance.ZVelocity;
            }
            else
            {
                CircleInstanceZVelocityReset = CircleInstance.RelativeZVelocity;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceRotationXReset = CircleInstance.RotationX;
            }
            else
            {
                CircleInstanceRotationXReset = CircleInstance.RelativeRotationX;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceRotationYReset = CircleInstance.RotationY;
            }
            else
            {
                CircleInstanceRotationYReset = CircleInstance.RelativeRotationY;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceRotationZReset = CircleInstance.RotationZ;
            }
            else
            {
                CircleInstanceRotationZReset = CircleInstance.RelativeRotationZ;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceRotationXVelocityReset = CircleInstance.RotationXVelocity;
            }
            else
            {
                CircleInstanceRotationXVelocityReset = CircleInstance.RelativeRotationXVelocity;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceRotationYVelocityReset = CircleInstance.RotationYVelocity;
            }
            else
            {
                CircleInstanceRotationYVelocityReset = CircleInstance.RelativeRotationYVelocity;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstanceRotationZVelocityReset = CircleInstance.RotationZVelocity;
            }
            else
            {
                CircleInstanceRotationZVelocityReset = CircleInstance.RelativeRotationZVelocity;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteXReset = ShadowSprite.X;
            }
            else
            {
                ShadowSpriteXReset = ShadowSprite.RelativeX;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteYReset = ShadowSprite.Y;
            }
            else
            {
                ShadowSpriteYReset = ShadowSprite.RelativeY;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteZReset = ShadowSprite.Z;
            }
            else
            {
                ShadowSpriteZReset = ShadowSprite.RelativeZ;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteXVelocityReset = ShadowSprite.XVelocity;
            }
            else
            {
                ShadowSpriteXVelocityReset = ShadowSprite.RelativeXVelocity;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteYVelocityReset = ShadowSprite.YVelocity;
            }
            else
            {
                ShadowSpriteYVelocityReset = ShadowSprite.RelativeYVelocity;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteZVelocityReset = ShadowSprite.ZVelocity;
            }
            else
            {
                ShadowSpriteZVelocityReset = ShadowSprite.RelativeZVelocity;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteRotationXReset = ShadowSprite.RotationX;
            }
            else
            {
                ShadowSpriteRotationXReset = ShadowSprite.RelativeRotationX;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteRotationYReset = ShadowSprite.RotationY;
            }
            else
            {
                ShadowSpriteRotationYReset = ShadowSprite.RelativeRotationY;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteRotationZReset = ShadowSprite.RotationZ;
            }
            else
            {
                ShadowSpriteRotationZReset = ShadowSprite.RelativeRotationZ;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteRotationXVelocityReset = ShadowSprite.RotationXVelocity;
            }
            else
            {
                ShadowSpriteRotationXVelocityReset = ShadowSprite.RelativeRotationXVelocity;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteRotationYVelocityReset = ShadowSprite.RotationYVelocity;
            }
            else
            {
                ShadowSpriteRotationYVelocityReset = ShadowSprite.RelativeRotationYVelocity;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSpriteRotationZVelocityReset = ShadowSprite.RotationZVelocity;
            }
            else
            {
                ShadowSpriteRotationZVelocityReset = ShadowSprite.RelativeRotationZVelocity;
            }
            ShadowSpriteAlphaReset = ShadowSprite.Alpha;
            ShadowSpriteAlphaRateReset = ShadowSprite.AlphaRate;
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
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mCircleInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(ShadowSprite, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(LightSprite, LayerProvidedByContainer);
        }
        public override void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddToLayer(mSpriteInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mCircleInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(ShadowSprite, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(LightSprite, LayerProvidedByContainer);
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
                Factories.SmallSlimeFactory.MakeUnused(this, false);
            }
            base.Destroy();
            
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (CircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(CircleInstance);
            }
            if (ShadowSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(ShadowSprite);
            }
            if (LightSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightSprite);
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
            base.SpriteInstance.TextureScale = 0.9f;
            base.SpriteInstance.AnimationChains = SlimeAlienAnimationChainListFile;
            base.SpriteInstance.CurrentChainName = "Standing";
            base.SpriteInstance.IgnoreAnimationChainTextureFlip = true;
            #if FRB_MDX
            SpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.SpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            if (mCircleInstance.Parent == null)
            {
                mCircleInstance.CopyAbsoluteToRelative();
                mCircleInstance.AttachTo(this, false);
            }
            base.CircleInstance.Radius = 43f;
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.CopyAbsoluteToRelative();
                ShadowSprite.AttachTo(this, false);
            }
            if (ShadowSprite.Parent == null)
            {
                base.ShadowSprite.Z = -1f;
            }
            else
            {
                base.ShadowSprite.RelativeZ = -1f;
            }
            base.ShadowSprite.Texture = AllAssetsSheet;
            base.ShadowSprite.LeftTexturePixel = 334f;
            base.ShadowSprite.RightTexturePixel = 396f;
            base.ShadowSprite.TopTexturePixel = 158f;
            base.ShadowSprite.BottomTexturePixel = 220f;
            base.ShadowSprite.TextureScale = 1f;
            base.ShadowSprite.Width = 40f;
            base.ShadowSprite.Height = 15f;
            base.ShadowSprite.Alpha = 0.35f;
            if (LightSprite.Parent == null)
            {
                LightSprite.CopyAbsoluteToRelative();
                LightSprite.AttachTo(this, false);
            }
            if (LightSprite.Parent == null)
            {
                base.LightSprite.Z = 1f;
            }
            else
            {
                base.LightSprite.RelativeZ = 1f;
            }
            base.LightSprite.Texture = AllAssetsSheet;
            base.LightSprite.LeftTexturePixel = 1792f;
            base.LightSprite.RightTexturePixel = 2048f;
            base.LightSprite.TopTexturePixel = 1792f;
            base.LightSprite.BottomTexturePixel = 2048f;
            base.LightSprite.TextureScale = 0.135f;
            #if FRB_MDX
            LightSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightSprite.Green = 1f;
            base.LightSprite.BlendOperation = FlatRedBall.Graphics.BlendOperation.Add;
            base.LightSprite.Alpha = 0.5f;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
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
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (CircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(CircleInstance);
            }
            if (ShadowSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(ShadowSprite);
            }
            if (LightSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightSprite);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
            }
            base.SpriteInstance.TextureScale = 0.9f;
            base.SpriteInstance.AnimationChains = SlimeAlienAnimationChainListFile;
            base.SpriteInstance.CurrentChainName = "Standing";
            base.SpriteInstance.IgnoreAnimationChainTextureFlip = true;
            #if FRB_MDX
            SpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.SpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
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
            base.CircleInstance.Radius = 43f;
            if (CircleInstance.Parent == null)
            {
                CircleInstance.X = CircleInstanceXReset;
            }
            else
            {
                CircleInstance.RelativeX = CircleInstanceXReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.Y = CircleInstanceYReset;
            }
            else
            {
                CircleInstance.RelativeY = CircleInstanceYReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.Z = CircleInstanceZReset;
            }
            else
            {
                CircleInstance.RelativeZ = CircleInstanceZReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.XVelocity = CircleInstanceXVelocityReset;
            }
            else
            {
                CircleInstance.RelativeXVelocity = CircleInstanceXVelocityReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.YVelocity = CircleInstanceYVelocityReset;
            }
            else
            {
                CircleInstance.RelativeYVelocity = CircleInstanceYVelocityReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.ZVelocity = CircleInstanceZVelocityReset;
            }
            else
            {
                CircleInstance.RelativeZVelocity = CircleInstanceZVelocityReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.RotationX = CircleInstanceRotationXReset;
            }
            else
            {
                CircleInstance.RelativeRotationX = CircleInstanceRotationXReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.RotationY = CircleInstanceRotationYReset;
            }
            else
            {
                CircleInstance.RelativeRotationY = CircleInstanceRotationYReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.RotationZ = CircleInstanceRotationZReset;
            }
            else
            {
                CircleInstance.RelativeRotationZ = CircleInstanceRotationZReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.RotationXVelocity = CircleInstanceRotationXVelocityReset;
            }
            else
            {
                CircleInstance.RelativeRotationXVelocity = CircleInstanceRotationXVelocityReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.RotationYVelocity = CircleInstanceRotationYVelocityReset;
            }
            else
            {
                CircleInstance.RelativeRotationYVelocity = CircleInstanceRotationYVelocityReset;
            }
            if (CircleInstance.Parent == null)
            {
                CircleInstance.RotationZVelocity = CircleInstanceRotationZVelocityReset;
            }
            else
            {
                CircleInstance.RelativeRotationZVelocity = CircleInstanceRotationZVelocityReset;
            }
            if (ShadowSprite.Parent == null)
            {
                base.ShadowSprite.Z = -1f;
            }
            else
            {
                base.ShadowSprite.RelativeZ = -1f;
            }
            base.ShadowSprite.Texture = AllAssetsSheet;
            base.ShadowSprite.LeftTexturePixel = 334f;
            base.ShadowSprite.RightTexturePixel = 396f;
            base.ShadowSprite.TopTexturePixel = 158f;
            base.ShadowSprite.BottomTexturePixel = 220f;
            base.ShadowSprite.TextureScale = 1f;
            base.ShadowSprite.Width = 40f;
            base.ShadowSprite.Height = 15f;
            base.ShadowSprite.Alpha = 0.35f;
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.X = ShadowSpriteXReset;
            }
            else
            {
                ShadowSprite.RelativeX = ShadowSpriteXReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.Y = ShadowSpriteYReset;
            }
            else
            {
                ShadowSprite.RelativeY = ShadowSpriteYReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.Z = ShadowSpriteZReset;
            }
            else
            {
                ShadowSprite.RelativeZ = ShadowSpriteZReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.XVelocity = ShadowSpriteXVelocityReset;
            }
            else
            {
                ShadowSprite.RelativeXVelocity = ShadowSpriteXVelocityReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.YVelocity = ShadowSpriteYVelocityReset;
            }
            else
            {
                ShadowSprite.RelativeYVelocity = ShadowSpriteYVelocityReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.ZVelocity = ShadowSpriteZVelocityReset;
            }
            else
            {
                ShadowSprite.RelativeZVelocity = ShadowSpriteZVelocityReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.RotationX = ShadowSpriteRotationXReset;
            }
            else
            {
                ShadowSprite.RelativeRotationX = ShadowSpriteRotationXReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.RotationY = ShadowSpriteRotationYReset;
            }
            else
            {
                ShadowSprite.RelativeRotationY = ShadowSpriteRotationYReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.RotationZ = ShadowSpriteRotationZReset;
            }
            else
            {
                ShadowSprite.RelativeRotationZ = ShadowSpriteRotationZReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.RotationXVelocity = ShadowSpriteRotationXVelocityReset;
            }
            else
            {
                ShadowSprite.RelativeRotationXVelocity = ShadowSpriteRotationXVelocityReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.RotationYVelocity = ShadowSpriteRotationYVelocityReset;
            }
            else
            {
                ShadowSprite.RelativeRotationYVelocity = ShadowSpriteRotationYVelocityReset;
            }
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.RotationZVelocity = ShadowSpriteRotationZVelocityReset;
            }
            else
            {
                ShadowSprite.RelativeRotationZVelocity = ShadowSpriteRotationZVelocityReset;
            }
            ShadowSprite.Alpha = ShadowSpriteAlphaReset;
            ShadowSprite.AlphaRate = ShadowSpriteAlphaRateReset;
            if (LightSprite.Parent == null)
            {
                base.LightSprite.Z = 1f;
            }
            else
            {
                base.LightSprite.RelativeZ = 1f;
            }
            base.LightSprite.Texture = AllAssetsSheet;
            base.LightSprite.LeftTexturePixel = 1792f;
            base.LightSprite.RightTexturePixel = 2048f;
            base.LightSprite.TopTexturePixel = 1792f;
            base.LightSprite.BottomTexturePixel = 2048f;
            base.LightSprite.TextureScale = 0.135f;
            #if FRB_MDX
            LightSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightSprite.Green = 1f;
            base.LightSprite.BlendOperation = FlatRedBall.Graphics.BlendOperation.Add;
            base.LightSprite.Alpha = 0.5f;
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
            MaximumHealth = 16f;
            Speed = 225f;
            IsRangedAttacker = false;
            MeleeAttackDamage = 2f;
            RangedAttackDamage = 0f;
            ProjectileSpeed = 0f;
            SecondsBetweenRangedAttack = 0f;
            SecondsBetweenMeleeAttack = 0.5f;
            MineralsRewardedWhenKilled = 10;
            DisplayName = "Small Slime";
            IsMeleeAttacker = true;
            MeleeAttackRadius = 72f;
            RangedAttackRadius = 0f;
            IsFlying = false;
            HasLightSource = true;
            IsJumper = true;
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(ShadowSprite);
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("SmallSlimeStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                SlimeAlienAnimationChainListFile = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/enemies/slimealien/slimealienanimationchainlistfile.achx", ContentManagerName);
                Slime_Hit = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/enemies/slimealien/slime_hit", ContentManagerName);
                Slime_Jump = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/enemies/slimealien/slime_jump", ContentManagerName);
                Slime_Land = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/enemies/slimealien/slime_land", ContentManagerName);
            }
            CustomLoadStaticContent(contentManagerName);
        }
        public static new void UnloadStaticContent () 
        {
            // Intentionally left blank because this element uses global content, so it should never be unloaded
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (Jump stateToInterpolateTo, double secondsToTake) 
        {
            switch(stateToInterpolateTo)
            {
                case  Jump.InAir:
                    break;
                case  Jump.Landing:
                    break;
                case  Jump.PreparingJump:
                    break;
                case  Jump.NotJumping:
                    break;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<Jump>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (Jump stateToStop) 
        {
            switch(stateToStop)
            {
                case  Jump.InAir:
                    break;
                case  Jump.Landing:
                    break;
                case  Jump.PreparingJump:
                    break;
                case  Jump.NotJumping:
                    break;
            }
            CurrentJumpState = stateToStop;
        }
        public void InterpolateBetween (Jump firstState, Jump secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            switch(firstState)
            {
                case  Jump.InAir:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "InAir";
                    }
                    break;
                case  Jump.Landing:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Landing";
                    }
                    break;
                case  Jump.PreparingJump:
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceCurrentChainName = "PreparingJump";
                    }
                    break;
                case  Jump.NotJumping:
                    break;
            }
            switch(secondState)
            {
                case  Jump.InAir:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "InAir";
                    }
                    break;
                case  Jump.Landing:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "Landing";
                    }
                    break;
                case  Jump.PreparingJump:
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceCurrentChainName = "PreparingJump";
                    }
                    break;
                case  Jump.NotJumping:
                    break;
            }
            if (interpolationValue < 1)
            {
                mCurrentJumpState = (int)firstState;
            }
            else
            {
                mCurrentJumpState = (int)secondState;
            }
        }
        public static void PreloadStateContent (Jump state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            switch(state)
            {
                case  Jump.InAir:
                    {
                        object throwaway = "InAir";
                    }
                    break;
                case  Jump.Landing:
                    {
                        object throwaway = "Landing";
                    }
                    break;
                case  Jump.PreparingJump:
                    {
                        object throwaway = "PreparingJump";
                    }
                    break;
                case  Jump.NotJumping:
                    break;
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "SlimeAlienAnimationChainListFile":
                    return SlimeAlienAnimationChainListFile;
                case  "Slime_Hit":
                    return Slime_Hit;
                case  "Slime_Jump":
                    return Slime_Jump;
                case  "Slime_Land":
                    return Slime_Land;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "SlimeAlienAnimationChainListFile":
                    return SlimeAlienAnimationChainListFile;
                case  "Slime_Hit":
                    return Slime_Hit;
                case  "Slime_Jump":
                    return Slime_Jump;
                case  "Slime_Land":
                    return Slime_Land;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "SlimeAlienAnimationChainListFile":
                    return SlimeAlienAnimationChainListFile;
                case  "Slime_Hit":
                    return Slime_Hit;
                case  "Slime_Jump":
                    return Slime_Jump;
                case  "Slime_Land":
                    return Slime_Land;
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
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(CircleInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(ShadowSprite);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightSprite);
        }
        public override void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer; // assign before calling base so removal is not impacted by base call
            base.MoveToLayer(layerToMoveTo);
        }
    }
}
