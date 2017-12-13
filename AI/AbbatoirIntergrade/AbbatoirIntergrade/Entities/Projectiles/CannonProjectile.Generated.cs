#if ANDROID || IOS
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using AbbatoirIntergrade.Screens;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using AbbatoirIntergrade.Performance;
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
using FlatRedBall.Graphics.Animation;
namespace AbbatoirIntergrade.Entities.Projectiles
{
    public partial class CannonProjectile : AbbatoirIntergrade.Entities.BaseEntities.BasePlayerProjectile, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Performance.IPoolable, FlatRedBall.Graphics.IVisible, FlatRedBall.Math.Geometry.ICollidable
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
        protected static FlatRedBall.Graphics.Animation.AnimationChainList CannonProjectileAnimationChainListFile;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Cannon_Hit;
        
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
        public CannonProjectile () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public CannonProjectile (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public CannonProjectile (string contentManagerName, bool addToManagers) 
        	: base(contentManagerName, addToManagers)
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
           
        }
        protected override void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            SpriteInstance = new FlatRedBall.Sprite();
            SpriteInstance.Name = "SpriteInstance";
            LightOrShadowSprite = new FlatRedBall.Sprite();
            LightOrShadowSprite.Name = "LightOrShadowSprite";
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
        }
        public override void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            base.ReAddToManagers(layerToAddTo);
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(LightOrShadowSprite, LayerProvidedByContainer);
        }
        public override void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(LightOrShadowSprite, LayerProvidedByContainer);
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
                Factories.CannonProjectileFactory.MakeUnused(this, false);
            }
            base.Destroy();
            
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (LightOrShadowSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightOrShadowSprite);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.CopyAbsoluteToRelative();
                SpriteInstance.AttachTo(this, false);
            }
            if (SpriteInstance.Parent == null)
            {
                base.SpriteInstance.X = 3.68968f;
            }
            else
            {
                base.SpriteInstance.RelativeX = 3.68968f;
            }
            if (SpriteInstance.Parent == null)
            {
                base.SpriteInstance.Y = -9.224199f;
            }
            else
            {
                base.SpriteInstance.RelativeY = -9.224199f;
            }
            base.SpriteInstance.Texture = AllParticles;
            base.SpriteInstance.TextureScale = 1.25f;
            base.SpriteInstance.AnimationChains = CannonProjectileAnimationChainListFile;
            base.SpriteInstance.CurrentChainName = "Shot";
            if (LightOrShadowSprite.Parent == null)
            {
                LightOrShadowSprite.CopyAbsoluteToRelative();
                LightOrShadowSprite.AttachTo(this, false);
            }
            if (LightOrShadowSprite.Parent == null)
            {
                base.LightOrShadowSprite.X = 0f;
            }
            else
            {
                base.LightOrShadowSprite.RelativeX = 0f;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                base.LightOrShadowSprite.Y = 0f;
            }
            else
            {
                base.LightOrShadowSprite.RelativeY = 0f;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                base.LightOrShadowSprite.Z = 0f;
            }
            else
            {
                base.LightOrShadowSprite.RelativeZ = 0f;
            }
            base.LightOrShadowSprite.Texture = AllParticles;
            base.LightOrShadowSprite.LeftTexturePixel = 1792f;
            base.LightOrShadowSprite.RightTexturePixel = 2048f;
            base.LightOrShadowSprite.TopTexturePixel = 1792f;
            base.LightOrShadowSprite.BottomTexturePixel = 2048f;
            base.LightOrShadowSprite.TextureScale = 0.4f;
            base.LightOrShadowSprite.AnimationChains = BaseProjectileLightAnimationChainListFile;
            base.LightOrShadowSprite.CurrentChainName = "Light_Shot";
            #if FRB_MDX
            LightOrShadowSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightOrShadowSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightOrShadowSprite.Red = 0f;
            base.LightOrShadowSprite.Green = 0.3f;
            base.LightOrShadowSprite.Blue = 1f;
            base.LightOrShadowSprite.BlendOperation = FlatRedBall.Graphics.BlendOperation.Add;
            base.LightOrShadowSprite.Alpha = 1f;
            base.LightOrShadowSprite.ParentRotationChangesPosition = false;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
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
            if (LightOrShadowSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightOrShadowSprite);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
            }
            if (SpriteInstance.Parent == null)
            {
                base.SpriteInstance.X = 3.68968f;
            }
            else
            {
                base.SpriteInstance.RelativeX = 3.68968f;
            }
            if (SpriteInstance.Parent == null)
            {
                base.SpriteInstance.Y = -9.224199f;
            }
            else
            {
                base.SpriteInstance.RelativeY = -9.224199f;
            }
            base.SpriteInstance.Texture = AllParticles;
            base.SpriteInstance.TextureScale = 1.25f;
            base.SpriteInstance.AnimationChains = CannonProjectileAnimationChainListFile;
            base.SpriteInstance.CurrentChainName = "Shot";
            if (LightOrShadowSprite.Parent == null)
            {
                base.LightOrShadowSprite.X = 0f;
            }
            else
            {
                base.LightOrShadowSprite.RelativeX = 0f;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                base.LightOrShadowSprite.Y = 0f;
            }
            else
            {
                base.LightOrShadowSprite.RelativeY = 0f;
            }
            if (LightOrShadowSprite.Parent == null)
            {
                base.LightOrShadowSprite.Z = 0f;
            }
            else
            {
                base.LightOrShadowSprite.RelativeZ = 0f;
            }
            base.LightOrShadowSprite.Texture = AllParticles;
            base.LightOrShadowSprite.LeftTexturePixel = 1792f;
            base.LightOrShadowSprite.RightTexturePixel = 2048f;
            base.LightOrShadowSprite.TopTexturePixel = 1792f;
            base.LightOrShadowSprite.BottomTexturePixel = 2048f;
            base.LightOrShadowSprite.TextureScale = 0.4f;
            base.LightOrShadowSprite.AnimationChains = BaseProjectileLightAnimationChainListFile;
            base.LightOrShadowSprite.CurrentChainName = "Light_Shot";
            #if FRB_MDX
            LightOrShadowSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightOrShadowSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightOrShadowSprite.Red = 0f;
            base.LightOrShadowSprite.Green = 0.3f;
            base.LightOrShadowSprite.Blue = 1f;
            base.LightOrShadowSprite.BlendOperation = FlatRedBall.Graphics.BlendOperation.Add;
            base.LightOrShadowSprite.Alpha = 1f;
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
            HasLightSource = true;
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(LightOrShadowSprite);
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("CannonProjectileStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                CannonProjectileAnimationChainListFile = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/projectiles/cannonprojectile/cannonprojectileanimationchainlistfile.achx", ContentManagerName);
                Cannon_Hit = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/projectiles/cannonprojectile/cannon_hit", ContentManagerName);
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
                case  "CannonProjectileAnimationChainListFile":
                    return CannonProjectileAnimationChainListFile;
                case  "Cannon_Hit":
                    return Cannon_Hit;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "CannonProjectileAnimationChainListFile":
                    return CannonProjectileAnimationChainListFile;
                case  "Cannon_Hit":
                    return Cannon_Hit;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "CannonProjectileAnimationChainListFile":
                    return CannonProjectileAnimationChainListFile;
                case  "Cannon_Hit":
                    return Cannon_Hit;
            }
            return null;
        }
        public override void SetToIgnorePausing () 
        {
            base.SetToIgnorePausing();
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightOrShadowSprite);
        }
        public override void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer; // assign before calling base so removal is not impacted by base call
            base.MoveToLayer(layerToMoveTo);
        }
    }
    public static class CannonProjectileExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<CannonProjectile> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
