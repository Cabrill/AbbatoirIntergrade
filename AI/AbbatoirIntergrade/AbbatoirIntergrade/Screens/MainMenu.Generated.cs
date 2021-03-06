#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace AbbatoirIntergrade.Screens
{
    public partial class MainMenu : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static Microsoft.Xna.Framework.Graphics.Texture2D empty_building;
        protected static FlatRedBall.Graphics.Animation.AnimationChainList AbbatoirIntergradeAnimation;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AbbatoirIntergradeText;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D blue_eye;
        protected static FlatRedBall.Gum.GumIdb MainMenuGum;
        
        private FlatRedBall.Sprite TheSpriteInstance;
        private FlatRedBall.Sprite ASpriteInstance;
        private FlatRedBall.Sprite BbatoirSpriteInstance;
        private FlatRedBall.Sprite ISpriteInstance;
        private FlatRedBall.Sprite NtergradeSpriteInstance;
        private AbbatoirIntergrade.GumRuntimes.MainMenuGumRuntime MainMenuGumRuntime;
        private AbbatoirIntergrade.GumRuntimes.unique.MainMenuEyeRuntime LeftEye;
        protected global::RenderingLibrary.Graphics.Layer AboveEverythingLayerGum;
        public MainMenu () 
        	: base ("MainMenu")
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            TheSpriteInstance = new FlatRedBall.Sprite();
            TheSpriteInstance.Name = "TheSpriteInstance";
            ASpriteInstance = new FlatRedBall.Sprite();
            ASpriteInstance.Name = "ASpriteInstance";
            BbatoirSpriteInstance = new FlatRedBall.Sprite();
            BbatoirSpriteInstance.Name = "BbatoirSpriteInstance";
            ISpriteInstance = new FlatRedBall.Sprite();
            ISpriteInstance.Name = "ISpriteInstance";
            NtergradeSpriteInstance = new FlatRedBall.Sprite();
            NtergradeSpriteInstance.Name = "NtergradeSpriteInstance";
            MainMenuGumRuntime = MainMenuGum.GetGraphicalUiElementByName("this") as AbbatoirIntergrade.GumRuntimes.MainMenuGumRuntime;
            LeftEye = MainMenuGum.GetGraphicalUiElementByName("LeftEye") as AbbatoirIntergrade.GumRuntimes.unique.MainMenuEyeRuntime;
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            MainMenuGum.InstanceInitialize(); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += MainMenuGum.HandleResolutionChanged;
            FlatRedBall.SpriteManager.AddToLayer(TheSpriteInstance, FlatRedBall.SpriteManager.TopLayer);
            FlatRedBall.SpriteManager.AddToLayer(ASpriteInstance, FlatRedBall.SpriteManager.TopLayer);
            FlatRedBall.SpriteManager.AddToLayer(BbatoirSpriteInstance, FlatRedBall.SpriteManager.TopLayer);
            FlatRedBall.SpriteManager.AddToLayer(ISpriteInstance, FlatRedBall.SpriteManager.TopLayer);
            FlatRedBall.SpriteManager.AddToLayer(NtergradeSpriteInstance, FlatRedBall.SpriteManager.TopLayer);
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            empty_building = null;
            AbbatoirIntergradeAnimation = null;
            AbbatoirIntergradeText = null;
            blue_eye = null;
            FlatRedBall.SpriteManager.RemoveDrawableBatch(MainMenuGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= MainMenuGum.HandleResolutionChanged;
            MainMenuGum = null;
            
            if (TheSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(TheSpriteInstance);
            }
            if (ASpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(ASpriteInstance);
            }
            if (BbatoirSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(BbatoirSpriteInstance);
            }
            if (ISpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(ISpriteInstance);
            }
            if (NtergradeSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(NtergradeSpriteInstance);
            }
            if (MainMenuGumRuntime != null)
            {
                MainMenuGumRuntime.RemoveFromManagers();
            }
            if (LeftEye != null)
            {
                LeftEye.RemoveFromManagers();
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (TheSpriteInstance.Parent == null)
            {
                TheSpriteInstance.X = -15.93791f;
            }
            else
            {
                TheSpriteInstance.RelativeX = -15.93791f;
            }
            if (TheSpriteInstance.Parent == null)
            {
                TheSpriteInstance.Y = 407.5375f;
            }
            else
            {
                TheSpriteInstance.RelativeY = 407.5375f;
            }
            TheSpriteInstance.Texture = AbbatoirIntergradeText;
            TheSpriteInstance.TextureScale = 1f;
            TheSpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            TheSpriteInstance.CurrentChainName = "The_Animate";
            if (ASpriteInstance.Parent == null)
            {
                ASpriteInstance.X = -934.4056f;
            }
            else
            {
                ASpriteInstance.RelativeX = -934.4056f;
            }
            if (ASpriteInstance.Parent == null)
            {
                ASpriteInstance.Y = -176.3048f;
            }
            else
            {
                ASpriteInstance.RelativeY = -176.3048f;
            }
            ASpriteInstance.Texture = AbbatoirIntergradeText;
            ASpriteInstance.TextureScale = 2f;
            ASpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            ASpriteInstance.CurrentChainName = "A_Animate";
            if (BbatoirSpriteInstance.Parent == null)
            {
                BbatoirSpriteInstance.X = -643.5237f;
            }
            else
            {
                BbatoirSpriteInstance.RelativeX = -643.5237f;
            }
            if (BbatoirSpriteInstance.Parent == null)
            {
                BbatoirSpriteInstance.Y = -235.8232f;
            }
            else
            {
                BbatoirSpriteInstance.RelativeY = -235.8232f;
            }
            BbatoirSpriteInstance.Texture = AbbatoirIntergradeText;
            BbatoirSpriteInstance.TextureScale = 1f;
            BbatoirSpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            BbatoirSpriteInstance.CurrentChainName = "bbatoir_Animate";
            #if FRB_MDX
            BbatoirSpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            BbatoirSpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            BbatoirSpriteInstance.Red = 0.1f;
            BbatoirSpriteInstance.Green = 0.6f;
            BbatoirSpriteInstance.Blue = 1f;
            BbatoirSpriteInstance.BlendOperation = FlatRedBall.Graphics.BlendOperation.Regular;
            if (ISpriteInstance.Parent == null)
            {
                ISpriteInstance.X = 361.6613f;
            }
            else
            {
                ISpriteInstance.RelativeX = 361.6613f;
            }
            if (ISpriteInstance.Parent == null)
            {
                ISpriteInstance.Y = -178.3042f;
            }
            else
            {
                ISpriteInstance.RelativeY = -178.3042f;
            }
            ISpriteInstance.Texture = AbbatoirIntergradeText;
            ISpriteInstance.TextureScale = 2f;
            ISpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            ISpriteInstance.CurrentChainName = "I_Animate";
            if (NtergradeSpriteInstance.Parent == null)
            {
                NtergradeSpriteInstance.X = 716.1099f;
            }
            else
            {
                NtergradeSpriteInstance.RelativeX = 716.1099f;
            }
            if (NtergradeSpriteInstance.Parent == null)
            {
                NtergradeSpriteInstance.Y = -236.1381f;
            }
            else
            {
                NtergradeSpriteInstance.RelativeY = -236.1381f;
            }
            NtergradeSpriteInstance.Texture = AbbatoirIntergradeText;
            NtergradeSpriteInstance.TextureScale = 1f;
            NtergradeSpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            NtergradeSpriteInstance.CurrentChainName = "ntergrade_Animate";
            #if FRB_MDX
            NtergradeSpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            NtergradeSpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            NtergradeSpriteInstance.Red = 0.1f;
            NtergradeSpriteInstance.Green = 0.6f;
            NtergradeSpriteInstance.Blue = 1f;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            if (TheSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(TheSpriteInstance);
            }
            if (ASpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(ASpriteInstance);
            }
            if (BbatoirSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(BbatoirSpriteInstance);
            }
            if (ISpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(ISpriteInstance);
            }
            if (NtergradeSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(NtergradeSpriteInstance);
            }
            if (MainMenuGumRuntime != null)
            {
                MainMenuGumRuntime.RemoveFromManagers();
            }
            if (LeftEye != null)
            {
                LeftEye.RemoveFromManagers();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            if (TheSpriteInstance.Parent == null)
            {
                TheSpriteInstance.X = -15.93791f;
            }
            else
            {
                TheSpriteInstance.RelativeX = -15.93791f;
            }
            if (TheSpriteInstance.Parent == null)
            {
                TheSpriteInstance.Y = 407.5375f;
            }
            else
            {
                TheSpriteInstance.RelativeY = 407.5375f;
            }
            TheSpriteInstance.Texture = AbbatoirIntergradeText;
            TheSpriteInstance.TextureScale = 1f;
            TheSpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            TheSpriteInstance.CurrentChainName = "The_Animate";
            if (ASpriteInstance.Parent == null)
            {
                ASpriteInstance.X = -934.4056f;
            }
            else
            {
                ASpriteInstance.RelativeX = -934.4056f;
            }
            if (ASpriteInstance.Parent == null)
            {
                ASpriteInstance.Y = -176.3048f;
            }
            else
            {
                ASpriteInstance.RelativeY = -176.3048f;
            }
            ASpriteInstance.Texture = AbbatoirIntergradeText;
            ASpriteInstance.TextureScale = 2f;
            ASpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            ASpriteInstance.CurrentChainName = "A_Animate";
            if (BbatoirSpriteInstance.Parent == null)
            {
                BbatoirSpriteInstance.X = -643.5237f;
            }
            else
            {
                BbatoirSpriteInstance.RelativeX = -643.5237f;
            }
            if (BbatoirSpriteInstance.Parent == null)
            {
                BbatoirSpriteInstance.Y = -235.8232f;
            }
            else
            {
                BbatoirSpriteInstance.RelativeY = -235.8232f;
            }
            BbatoirSpriteInstance.Texture = AbbatoirIntergradeText;
            BbatoirSpriteInstance.TextureScale = 1f;
            BbatoirSpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            BbatoirSpriteInstance.CurrentChainName = "bbatoir_Animate";
            #if FRB_MDX
            BbatoirSpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            BbatoirSpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            BbatoirSpriteInstance.Red = 0.1f;
            BbatoirSpriteInstance.Green = 0.6f;
            BbatoirSpriteInstance.Blue = 1f;
            BbatoirSpriteInstance.BlendOperation = FlatRedBall.Graphics.BlendOperation.Regular;
            if (ISpriteInstance.Parent == null)
            {
                ISpriteInstance.X = 361.6613f;
            }
            else
            {
                ISpriteInstance.RelativeX = 361.6613f;
            }
            if (ISpriteInstance.Parent == null)
            {
                ISpriteInstance.Y = -178.3042f;
            }
            else
            {
                ISpriteInstance.RelativeY = -178.3042f;
            }
            ISpriteInstance.Texture = AbbatoirIntergradeText;
            ISpriteInstance.TextureScale = 2f;
            ISpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            ISpriteInstance.CurrentChainName = "I_Animate";
            if (NtergradeSpriteInstance.Parent == null)
            {
                NtergradeSpriteInstance.X = 716.1099f;
            }
            else
            {
                NtergradeSpriteInstance.RelativeX = 716.1099f;
            }
            if (NtergradeSpriteInstance.Parent == null)
            {
                NtergradeSpriteInstance.Y = -236.1381f;
            }
            else
            {
                NtergradeSpriteInstance.RelativeY = -236.1381f;
            }
            NtergradeSpriteInstance.Texture = AbbatoirIntergradeText;
            NtergradeSpriteInstance.TextureScale = 1f;
            NtergradeSpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            NtergradeSpriteInstance.CurrentChainName = "ntergrade_Animate";
            #if FRB_MDX
            NtergradeSpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            NtergradeSpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            NtergradeSpriteInstance.Red = 0.1f;
            NtergradeSpriteInstance.Green = 0.6f;
            NtergradeSpriteInstance.Blue = 1f;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(TheSpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(ASpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(BbatoirSpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(ISpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(NtergradeSpriteInstance);
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
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
            empty_building = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/mainmenu/empty_building.png", contentManagerName);
            AbbatoirIntergradeAnimation = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/screens/mainmenu/abbatoirintergradeanimation.achx", contentManagerName);
            AbbatoirIntergradeText = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/mainmenu/abbatoirintergradetext.png", contentManagerName);
            blue_eye = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/mainmenu/blue_eye.png", contentManagerName);
            Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;  MainMenuGum = new FlatRedBall.Gum.GumIdb();  MainMenuGum.LoadFromFile("content/gumproject/screens/mainmenugum.gusx");  MainMenuGum.AssignReferences();Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = false; MainMenuGum.Element.UpdateLayout(); MainMenuGum.Element.UpdateLayout();
            CustomLoadStaticContent(contentManagerName);
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "empty_building":
                    return empty_building;
                case  "AbbatoirIntergradeAnimation":
                    return AbbatoirIntergradeAnimation;
                case  "AbbatoirIntergradeText":
                    return AbbatoirIntergradeText;
                case  "blue_eye":
                    return blue_eye;
                case  "MainMenuGum":
                    return MainMenuGum;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "empty_building":
                    return empty_building;
                case  "AbbatoirIntergradeAnimation":
                    return AbbatoirIntergradeAnimation;
                case  "AbbatoirIntergradeText":
                    return AbbatoirIntergradeText;
                case  "blue_eye":
                    return blue_eye;
                case  "MainMenuGum":
                    return MainMenuGum;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "empty_building":
                    return empty_building;
                case  "AbbatoirIntergradeAnimation":
                    return AbbatoirIntergradeAnimation;
                case  "AbbatoirIntergradeText":
                    return AbbatoirIntergradeText;
                case  "blue_eye":
                    return blue_eye;
                case  "MainMenuGum":
                    return MainMenuGum;
            }
            return null;
        }
    }
}
