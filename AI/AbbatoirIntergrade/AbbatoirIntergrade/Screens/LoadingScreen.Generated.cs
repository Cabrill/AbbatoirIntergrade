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
    public partial class LoadingScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static FlatRedBall.Gum.GumIdb LoadingScreenGum;
        
        private AbbatoirIntergrade.GumRuntimes.LoadingScreenGumRuntime LoadingScreenGumRuntime;
        double mSavedTargetElapedTime;
        private static System.Action<FlatRedBall.Screens.Screen> nextCallback;
        public LoadingScreen () 
        	: base ("LoadingScreen")
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            LoadingScreenGumRuntime = LoadingScreenGum.GetGraphicalUiElementByName("this") as AbbatoirIntergrade.GumRuntimes.LoadingScreenGumRuntime;
            mSavedTargetElapedTime = FlatRedBallServices.Game.TargetElapsedTime.TotalSeconds;
            FlatRedBall.FlatRedBallServices.Game.TargetElapsedTime = TimeSpan.FromSeconds(.1);
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            this.NextScreen = typeof(AbbatoirIntergrade.Screens.GameScreen).FullName;
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            LoadingScreenGum.InstanceInitialize(); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += LoadingScreenGum.HandleResolutionChanged;
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                AsyncActivity();
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
            FlatRedBall.SpriteManager.RemoveDrawableBatch(LoadingScreenGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= LoadingScreenGum.HandleResolutionChanged;
            LoadingScreenGum = null;
            
            if (LoadingScreenGumRuntime != null)
            {
                LoadingScreenGumRuntime.RemoveFromManagers();
            }
            FlatRedBall.FlatRedBallServices.Game.TargetElapsedTime = TimeSpan.FromSeconds(mSavedTargetElapedTime);
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            if (LoadingScreenGumRuntime != null)
            {
                LoadingScreenGumRuntime.RemoveFromManagers();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
        }
        public virtual void ConvertToManuallyUpdated () 
        {
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
            Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;  LoadingScreenGum = new FlatRedBall.Gum.GumIdb();  LoadingScreenGum.LoadFromFile("content/gumproject/screens/loadingscreengum.gusx");  LoadingScreenGum.AssignReferences();Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = false; LoadingScreenGum.Element.UpdateLayout(); LoadingScreenGum.Element.UpdateLayout();
            CustomLoadStaticContent(contentManagerName);
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "LoadingScreenGum":
                    return LoadingScreenGum;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "LoadingScreenGum":
                    return LoadingScreenGum;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "LoadingScreenGum":
                    return LoadingScreenGum;
            }
            return null;
        }
        static string mNextScreenToLoad;
        public static string NextScreenToLoad
        {
            get
            {
                return mNextScreenToLoad;
            }
            set
            {
                mNextScreenToLoad = value;
            }
        }
        public static void TransitionToScreen (System.Type screenType, System.Action<FlatRedBall.Screens.Screen> screenCreatedCallback = null) 
        {
            TransitionToScreen(screenType.FullName, screenCreatedCallback);
        }
        public static void TransitionToScreen (string screenName, System.Action<FlatRedBall.Screens.Screen> screenCreatedCallback = null) 
        {
            Screen currentScreen = ScreenManager.CurrentScreen;
            currentScreen.IsActivityFinished = true;
            currentScreen.NextScreen = typeof(LoadingScreen).FullName;
            mNextScreenToLoad = screenName;
            nextCallback = screenCreatedCallback;
        }
        void AsyncActivity () 
        {
            switch(AsyncLoadingState)
            {
                case  FlatRedBall.Screens.AsyncLoadingState.NotStarted:
                    if (!string.IsNullOrEmpty(mNextScreenToLoad))
                    {
                        #if REQUIRES_PRIMARY_THREAD_LOADING
                        if (HasDrawBeenCalled)
                        {
                            MoveToScreen(mNextScreenToLoad);
                        }
                        #else
                        StartAsyncLoad(mNextScreenToLoad);
                        #endif
                    }
                    break;
                case  FlatRedBall.Screens.AsyncLoadingState.LoadingScreen:
                    break;
                case  FlatRedBall.Screens.AsyncLoadingState.Done:
                    FlatRedBall.Screens.ScreenManager.ShouldActivateScreen = false;
                    FlatRedBall.Screens.ScreenManager.MoveToScreen(mNextScreenToLoad, nextCallback);
                    break;
            }
        }
    }
}
