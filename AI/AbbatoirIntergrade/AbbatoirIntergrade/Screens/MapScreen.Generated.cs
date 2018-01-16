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
    public partial class MapScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static Microsoft.Xna.Framework.Graphics.Texture2D worldmap;
        protected static FlatRedBall.Gum.GumIdb MapScreenGum;
        
        private AbbatoirIntergrade.GumRuntimes.MapScreenGumRuntime MapScreenGumInstance;
        private AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime MenuWindowInstance;
        private AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime ChatHistoryInstance;
        public MapScreen () 
        	: base ("MapScreen")
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            MapScreenGumInstance = MapScreenGum.GetGraphicalUiElementByName("this") as AbbatoirIntergrade.GumRuntimes.MapScreenGumRuntime;
            MenuWindowInstance = MapScreenGum.GetGraphicalUiElementByName("MenuWindowInstance") as AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime;
            ChatHistoryInstance = MapScreenGum.GetGraphicalUiElementByName("ChatHistoryInstance") as AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime;
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            MapScreenGum.InstanceInitialize(); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += MapScreenGum.HandleResolutionChanged;
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
            worldmap = null;
            FlatRedBall.SpriteManager.RemoveDrawableBatch(MapScreenGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= MapScreenGum.HandleResolutionChanged;
            MapScreenGum = null;
            
            if (MapScreenGumInstance != null)
            {
                MapScreenGumInstance.RemoveFromManagers();
            }
            if (MenuWindowInstance != null)
            {
                MenuWindowInstance.RemoveFromManagers();
            }
            if (ChatHistoryInstance != null)
            {
                ChatHistoryInstance.RemoveFromManagers();
            }
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
            if (MapScreenGumInstance != null)
            {
                MapScreenGumInstance.RemoveFromManagers();
            }
            if (MenuWindowInstance != null)
            {
                MenuWindowInstance.RemoveFromManagers();
            }
            if (ChatHistoryInstance != null)
            {
                ChatHistoryInstance.RemoveFromManagers();
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
            worldmap = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/mapscreen/worldmap.png", contentManagerName);
            Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;  MapScreenGum = new FlatRedBall.Gum.GumIdb();  MapScreenGum.LoadFromFile("content/gumproject/screens/mapscreengum.gusx");  MapScreenGum.AssignReferences();Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = false; MapScreenGum.Element.UpdateLayout(); MapScreenGum.Element.UpdateLayout();
            CustomLoadStaticContent(contentManagerName);
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "worldmap":
                    return worldmap;
                case  "MapScreenGum":
                    return MapScreenGum;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "worldmap":
                    return worldmap;
                case  "MapScreenGum":
                    return MapScreenGum;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "worldmap":
                    return worldmap;
                case  "MapScreenGum":
                    return MapScreenGum;
            }
            return null;
        }
    }
}
