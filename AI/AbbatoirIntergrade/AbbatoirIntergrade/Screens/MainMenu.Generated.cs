#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
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
namespace AbbatoirIntergrade.Screens
{
    public partial class MainMenu : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static FlatRedBall.Gum.GumIdb MainMenuGum;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D empty_building;
        protected static FlatRedBall.Graphics.Animation.AnimationChainList AbbatoirIntergradeAnimation;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AbbatoirIntergradeText;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D blue_eye;
        
        private FlatRedBall.Sprite TheSpriteInstance;
        private FlatRedBall.Sprite ASpriteInstance;
        private FlatRedBall.Sprite BbatoirSpriteInstance;
        private FlatRedBall.Sprite ISpriteInstance;
        private FlatRedBall.Sprite NtergradeSpriteInstance;
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
            FlatRedBall.SpriteManager.AddSprite(TheSpriteInstance);
            FlatRedBall.SpriteManager.AddSprite(ASpriteInstance);
            FlatRedBall.SpriteManager.AddSprite(BbatoirSpriteInstance);
            FlatRedBall.SpriteManager.AddSprite(ISpriteInstance);
            FlatRedBall.SpriteManager.AddSprite(NtergradeSpriteInstance);
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
            FlatRedBall.SpriteManager.RemoveDrawableBatch(MainMenuGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= MainMenuGum.HandleResolutionChanged;
            MainMenuGum = null;
            empty_building = null;
            AbbatoirIntergradeAnimation = null;
            AbbatoirIntergradeText = null;
            blue_eye = null;
            
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
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (TheSpriteInstance.Parent == null)
            {
                TheSpriteInstance.X = -19.54167f;
            }
            else
            {
                TheSpriteInstance.RelativeX = -19.54167f;
            }
            if (TheSpriteInstance.Parent == null)
            {
                TheSpriteInstance.Y = 273.0906f;
            }
            else
            {
                TheSpriteInstance.RelativeY = 273.0906f;
            }
            TheSpriteInstance.Texture = AbbatoirIntergradeText;
            TheSpriteInstance.TextureScale = 0.4f;
            TheSpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            TheSpriteInstance.CurrentChainName = "The_Animate";
            if (ASpriteInstance.Parent == null)
            {
                ASpriteInstance.X = -357.7979f;
            }
            else
            {
                ASpriteInstance.RelativeX = -357.7979f;
            }
            if (ASpriteInstance.Parent == null)
            {
                ASpriteInstance.Y = -222.9199f;
            }
            else
            {
                ASpriteInstance.RelativeY = -222.9199f;
            }
            ASpriteInstance.Texture = AbbatoirIntergradeText;
            ASpriteInstance.TextureScale = 1f;
            ASpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            ASpriteInstance.CurrentChainName = "A_Animate";
            if (BbatoirSpriteInstance.Parent == null)
            {
                BbatoirSpriteInstance.X = -210.9192f;
            }
            else
            {
                BbatoirSpriteInstance.RelativeX = -210.9192f;
            }
            if (BbatoirSpriteInstance.Parent == null)
            {
                BbatoirSpriteInstance.Y = -252.1708f;
            }
            else
            {
                BbatoirSpriteInstance.RelativeY = -252.1708f;
            }
            BbatoirSpriteInstance.Texture = AbbatoirIntergradeText;
            BbatoirSpriteInstance.TextureScale = 0.5f;
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
                ISpriteInstance.X = 54.95257f;
            }
            else
            {
                ISpriteInstance.RelativeX = 54.95257f;
            }
            if (ISpriteInstance.Parent == null)
            {
                ISpriteInstance.Y = -224.0396f;
            }
            else
            {
                ISpriteInstance.RelativeY = -224.0396f;
            }
            ISpriteInstance.Texture = AbbatoirIntergradeText;
            ISpriteInstance.TextureScale = 1f;
            ISpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            ISpriteInstance.CurrentChainName = "I_Animate";
            if (NtergradeSpriteInstance.Parent == null)
            {
                NtergradeSpriteInstance.X = 228.9675f;
            }
            else
            {
                NtergradeSpriteInstance.RelativeX = 228.9675f;
            }
            if (NtergradeSpriteInstance.Parent == null)
            {
                NtergradeSpriteInstance.Y = -253.4857f;
            }
            else
            {
                NtergradeSpriteInstance.RelativeY = -253.4857f;
            }
            NtergradeSpriteInstance.Texture = AbbatoirIntergradeText;
            NtergradeSpriteInstance.TextureScale = 0.5f;
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
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            if (TheSpriteInstance.Parent == null)
            {
                TheSpriteInstance.X = -19.54167f;
            }
            else
            {
                TheSpriteInstance.RelativeX = -19.54167f;
            }
            if (TheSpriteInstance.Parent == null)
            {
                TheSpriteInstance.Y = 273.0906f;
            }
            else
            {
                TheSpriteInstance.RelativeY = 273.0906f;
            }
            TheSpriteInstance.Texture = AbbatoirIntergradeText;
            TheSpriteInstance.TextureScale = 0.4f;
            TheSpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            TheSpriteInstance.CurrentChainName = "The_Animate";
            if (ASpriteInstance.Parent == null)
            {
                ASpriteInstance.X = -357.7979f;
            }
            else
            {
                ASpriteInstance.RelativeX = -357.7979f;
            }
            if (ASpriteInstance.Parent == null)
            {
                ASpriteInstance.Y = -222.9199f;
            }
            else
            {
                ASpriteInstance.RelativeY = -222.9199f;
            }
            ASpriteInstance.Texture = AbbatoirIntergradeText;
            ASpriteInstance.TextureScale = 1f;
            ASpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            ASpriteInstance.CurrentChainName = "A_Animate";
            if (BbatoirSpriteInstance.Parent == null)
            {
                BbatoirSpriteInstance.X = -210.9192f;
            }
            else
            {
                BbatoirSpriteInstance.RelativeX = -210.9192f;
            }
            if (BbatoirSpriteInstance.Parent == null)
            {
                BbatoirSpriteInstance.Y = -252.1708f;
            }
            else
            {
                BbatoirSpriteInstance.RelativeY = -252.1708f;
            }
            BbatoirSpriteInstance.Texture = AbbatoirIntergradeText;
            BbatoirSpriteInstance.TextureScale = 0.5f;
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
                ISpriteInstance.X = 54.95257f;
            }
            else
            {
                ISpriteInstance.RelativeX = 54.95257f;
            }
            if (ISpriteInstance.Parent == null)
            {
                ISpriteInstance.Y = -224.0396f;
            }
            else
            {
                ISpriteInstance.RelativeY = -224.0396f;
            }
            ISpriteInstance.Texture = AbbatoirIntergradeText;
            ISpriteInstance.TextureScale = 1f;
            ISpriteInstance.AnimationChains = AbbatoirIntergradeAnimation;
            ISpriteInstance.CurrentChainName = "I_Animate";
            if (NtergradeSpriteInstance.Parent == null)
            {
                NtergradeSpriteInstance.X = 228.9675f;
            }
            else
            {
                NtergradeSpriteInstance.RelativeX = 228.9675f;
            }
            if (NtergradeSpriteInstance.Parent == null)
            {
                NtergradeSpriteInstance.Y = -253.4857f;
            }
            else
            {
                NtergradeSpriteInstance.RelativeY = -253.4857f;
            }
            NtergradeSpriteInstance.Texture = AbbatoirIntergradeText;
            NtergradeSpriteInstance.TextureScale = 0.5f;
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
            Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;  MainMenuGum = new FlatRedBall.Gum.GumIdb();  MainMenuGum.LoadFromFile("content/gumproject/screens/mainmenugum.gusx");  MainMenuGum.AssignReferences();Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = false; MainMenuGum.Element.UpdateLayout(); MainMenuGum.Element.UpdateLayout();
            empty_building = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/mainmenu/empty_building.png", contentManagerName);
            AbbatoirIntergradeAnimation = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/screens/mainmenu/abbatoirintergradeanimation.achx", contentManagerName);
            AbbatoirIntergradeText = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/mainmenu/abbatoirintergradetext.png", contentManagerName);
            blue_eye = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/mainmenu/blue_eye.png", contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "MainMenuGum":
                    return MainMenuGum;
                case  "empty_building":
                    return empty_building;
                case  "AbbatoirIntergradeAnimation":
                    return AbbatoirIntergradeAnimation;
                case  "AbbatoirIntergradeText":
                    return AbbatoirIntergradeText;
                case  "blue_eye":
                    return blue_eye;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "MainMenuGum":
                    return MainMenuGum;
                case  "empty_building":
                    return empty_building;
                case  "AbbatoirIntergradeAnimation":
                    return AbbatoirIntergradeAnimation;
                case  "AbbatoirIntergradeText":
                    return AbbatoirIntergradeText;
                case  "blue_eye":
                    return blue_eye;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "MainMenuGum":
                    return MainMenuGum;
                case  "empty_building":
                    return empty_building;
                case  "AbbatoirIntergradeAnimation":
                    return AbbatoirIntergradeAnimation;
                case  "AbbatoirIntergradeText":
                    return AbbatoirIntergradeText;
                case  "blue_eye":
                    return blue_eye;
            }
            return null;
        }
    }
}
