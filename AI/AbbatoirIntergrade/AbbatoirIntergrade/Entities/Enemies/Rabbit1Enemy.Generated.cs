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
using FlatRedBall.Graphics.Particle;
namespace AbbatoirIntergrade.Entities.Enemies
{
    public partial class Rabbit1Enemy : AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Performance.IPoolable
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
        public class Jump
        {
            public float X;
            public float Y;
            public float Z;
            public string DisplayName;
            public bool IsFlying;
            public bool HasLightSource;
            public string SpriteInstanceCurrentChainName;
            public bool IsJumper;
            public float Mass;
            public static Jump InAir = new Jump()
            {
                SpriteInstanceCurrentChainName = "InAir",
            }
            ;
            public static Jump Landing = new Jump()
            {
                SpriteInstanceCurrentChainName = "Landing",
            }
            ;
            public static Jump PreparingJump = new Jump()
            {
                SpriteInstanceCurrentChainName = "PreparingJump",
            }
            ;
            public static Jump NotJumping = new Jump()
            {
            }
            ;
        }
        private Jump mCurrentJumpState = null;
        public Entities.Enemies.Rabbit1Enemy.Jump CurrentJumpState
        {
            get
            {
                return mCurrentJumpState;
            }
            set
            {
                mCurrentJumpState = value;
                if (CurrentJumpState == Jump.InAir)
                {
                    SpriteInstanceCurrentChainName = "InAir";
                }
                else if (CurrentJumpState == Jump.Landing)
                {
                    SpriteInstanceCurrentChainName = "Landing";
                }
                else if (CurrentJumpState == Jump.PreparingJump)
                {
                    SpriteInstanceCurrentChainName = "PreparingJump";
                }
                else if (CurrentJumpState == Jump.NotJumping)
                {
                }
            }
        }
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static FlatRedBall.Graphics.Animation.AnimationChainList Rabbit1Animations;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D Stage1;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Rabbit1Death1;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Rabbit1Death2;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Rabbit1Death3;
        
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
        public Rabbit1Enemy () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public Rabbit1Enemy (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public Rabbit1Enemy (string contentManagerName, bool addToManagers) 
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
            LightSprite = new FlatRedBall.Sprite();
            LightSprite.Name = "LightSprite";
            // Not instantiating for AxisAlignedRectangle AxisAlignedRectangleInstance in Entities\Enemies\Rabbit1Enemy because properties on the object prevent it
            
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
            FlatRedBall.SpriteManager.AddToLayer(LightSprite, LayerProvidedByContainer);
        }
        public override void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddToLayer(mSpriteInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mCircleInstance, LayerProvidedByContainer);
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
                Factories.Rabbit1EnemyFactory.MakeUnused(this, false);
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
            if (LightSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightSprite);
            }
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
            base.SpriteInstance.Texture = Stage1;
            base.SpriteInstance.TextureScale = 0.5f;
            base.SpriteInstance.AnimationChains = Rabbit1Animations;
            base.SpriteInstance.CurrentChainName = "Running";
            base.SpriteInstance.IgnoreAnimationChainTextureFlip = true;
            if (mCircleInstance.Parent == null)
            {
                mCircleInstance.CopyAbsoluteToRelative();
                mCircleInstance.AttachTo(this, false);
            }
            if (CircleInstance.Parent == null)
            {
                base.CircleInstance.Y = 6f;
            }
            else
            {
                base.CircleInstance.RelativeY = 6f;
            }
            base.CircleInstance.Radius = 18f;
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
            base.LightSprite.TextureScale = 0.225f;
            #if FRB_MDX
            LightSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightSprite.Green = 1f;
            base.LightSprite.BlendOperation = FlatRedBall.Graphics.BlendOperation.Add;
            base.LightSprite.Alpha = 0.5f;
            if (ShadowSprite.Parent == null)
            {
                ShadowSprite.CopyAbsoluteToRelative();
                ShadowSprite.AttachTo(this, false);
            }
            if (ShadowSprite.Parent == null)
            {
                base.ShadowSprite.Y = -24f;
            }
            else
            {
                base.ShadowSprite.RelativeY = -24f;
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
            base.ShadowSprite.Width = 43f;
            base.ShadowSprite.Height = 16f;
            #if FRB_MDX
            ShadowSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.ShadowSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.ShadowSprite.Alpha = 0.3f;
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
            if (LightSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightSprite);
            }
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
            }
            base.SpriteInstance.Texture = Stage1;
            base.SpriteInstance.TextureScale = 0.5f;
            base.SpriteInstance.AnimationChains = Rabbit1Animations;
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
            if (CircleInstance.Parent == null)
            {
                base.CircleInstance.Y = 6f;
            }
            else
            {
                base.CircleInstance.RelativeY = 6f;
            }
            base.CircleInstance.Radius = 18f;
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
            base.LightSprite.TextureScale = 0.225f;
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
            if (ShadowSprite.Parent == null)
            {
                base.ShadowSprite.Y = -24f;
            }
            else
            {
                base.ShadowSprite.RelativeY = -24f;
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
            base.ShadowSprite.Width = 43f;
            base.ShadowSprite.Height = 16f;
            #if FRB_MDX
            ShadowSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.ShadowSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.ShadowSprite.Alpha = 0.3f;
            DisplayName = "Rabbit";
            IsFlying = false;
            HasLightSource = false;
            IsJumper = true;
            Mass = 0.1f;
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("Rabbit1EnemyStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                Rabbit1Animations = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/screens/gamescreen/monsters/rabbit1animations.achx", ContentManagerName);
                Stage1 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/gamescreen/monsters/stage1.png", ContentManagerName);
                Rabbit1Death1 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/enemies/rabbit1enemy/rabbit1death1", ContentManagerName);
                Rabbit1Death2 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/enemies/rabbit1enemy/rabbit1death2", ContentManagerName);
                Rabbit1Death3 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/enemies/rabbit1enemy/rabbit1death3", ContentManagerName);
            }
            CustomLoadStaticContent(contentManagerName);
        }
        public static new void UnloadStaticContent () 
        {
            // Intentionally left blank because this element uses global content, so it should never be unloaded
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (Jump stateToInterpolateTo, double secondsToTake) 
        {
            if (stateToInterpolateTo == Jump.InAir)
            {
            }
            else if (stateToInterpolateTo == Jump.Landing)
            {
            }
            else if (stateToInterpolateTo == Jump.PreparingJump)
            {
            }
            else if (stateToInterpolateTo == Jump.NotJumping)
            {
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<Jump>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (Jump stateToStop) 
        {
            if (stateToStop == Jump.InAir)
            {
            }
            else if (stateToStop == Jump.Landing)
            {
            }
            else if (stateToStop == Jump.PreparingJump)
            {
            }
            else if (stateToStop == Jump.NotJumping)
            {
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
            if (firstState == Jump.InAir)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceCurrentChainName = "InAir";
                }
            }
            else if (firstState == Jump.Landing)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceCurrentChainName = "Landing";
                }
            }
            else if (firstState == Jump.PreparingJump)
            {
                if (interpolationValue < 1)
                {
                    this.SpriteInstanceCurrentChainName = "PreparingJump";
                }
            }
            else if (firstState == Jump.NotJumping)
            {
            }
            if (secondState == Jump.InAir)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceCurrentChainName = "InAir";
                }
            }
            else if (secondState == Jump.Landing)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceCurrentChainName = "Landing";
                }
            }
            else if (secondState == Jump.PreparingJump)
            {
                if (interpolationValue >= 1)
                {
                    this.SpriteInstanceCurrentChainName = "PreparingJump";
                }
            }
            else if (secondState == Jump.NotJumping)
            {
            }
            if (interpolationValue < 1)
            {
                mCurrentJumpState = firstState;
            }
            else
            {
                mCurrentJumpState = secondState;
            }
        }
        public static void PreloadStateContent (Jump state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            if (state == Jump.InAir)
            {
                {
                    object throwaway = "InAir";
                }
            }
            else if (state == Jump.Landing)
            {
                {
                    object throwaway = "Landing";
                }
            }
            else if (state == Jump.PreparingJump)
            {
                {
                    object throwaway = "PreparingJump";
                }
            }
            else if (state == Jump.NotJumping)
            {
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Rabbit1Animations":
                    return Rabbit1Animations;
                case  "Stage1":
                    return Stage1;
                case  "Rabbit1Death1":
                    return Rabbit1Death1;
                case  "Rabbit1Death2":
                    return Rabbit1Death2;
                case  "Rabbit1Death3":
                    return Rabbit1Death3;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "Rabbit1Animations":
                    return Rabbit1Animations;
                case  "Stage1":
                    return Stage1;
                case  "Rabbit1Death1":
                    return Rabbit1Death1;
                case  "Rabbit1Death2":
                    return Rabbit1Death2;
                case  "Rabbit1Death3":
                    return Rabbit1Death3;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Rabbit1Animations":
                    return Rabbit1Animations;
                case  "Stage1":
                    return Stage1;
                case  "Rabbit1Death1":
                    return Rabbit1Death1;
                case  "Rabbit1Death2":
                    return Rabbit1Death2;
                case  "Rabbit1Death3":
                    return Rabbit1Death3;
            }
            return null;
        }
        public override void SetToIgnorePausing () 
        {
            base.SetToIgnorePausing();
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(CircleInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightSprite);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(ShadowSprite);
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
}
