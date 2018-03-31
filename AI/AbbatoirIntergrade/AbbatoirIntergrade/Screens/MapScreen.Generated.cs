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
using AbbatoirIntergrade.DataTypes;
using FlatRedBall.IO.Csv;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
namespace AbbatoirIntergrade.Screens
{
    public partial class MapScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static Microsoft.Xna.Framework.Graphics.Texture2D worldmap;
        protected static FlatRedBall.Gum.GumIdb MapScreenGum;
        protected static System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.Messages> Messages;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect StructureSelection;
        
        private AbbatoirIntergrade.GumRuntimes.MapScreenGumRuntime MapScreenGumInstance;
        private AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime MenuWindowInstance;
        private AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime ChatHistoryInstance;
        private AbbatoirIntergrade.GumRuntimes.TowerSelectionBoxRuntime TowerSelectionBoxInstance;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseStructure> StructureList;
        private FlatRedBall.Graphics.Layer StructureLayer;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BasePlayerProjectile> ProjectileList;
        private AbbatoirIntergrade.GumRuntimes.OkMessageRuntime OkMessageInstance;
        private AbbatoirIntergrade.GumRuntimes.ConfirmationWindowRuntime ConfirmationWindowInstance;
        private FlatRedBall.Graphics.Layer HUDLayer;
        private AbbatoirIntergrade.GumRuntimes.CurrentMusicDisplayRuntime CurrentMusicDisplayInstance;
        protected global::RenderingLibrary.Graphics.Layer StructureLayerGum;
        protected global::RenderingLibrary.Graphics.Layer HUDLayerGum;
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
            TowerSelectionBoxInstance = MapScreenGum.GetGraphicalUiElementByName("TowerSelectionBoxInstance") as AbbatoirIntergrade.GumRuntimes.TowerSelectionBoxRuntime;
            StructureList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseStructure>();
            StructureList.Name = "StructureList";
            StructureLayer = new FlatRedBall.Graphics.Layer();
            StructureLayer.Name = "StructureLayer";
            ProjectileList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BasePlayerProjectile>();
            ProjectileList.Name = "ProjectileList";
            OkMessageInstance = MapScreenGum.GetGraphicalUiElementByName("OkMessageInstance") as AbbatoirIntergrade.GumRuntimes.OkMessageRuntime;
            ConfirmationWindowInstance = MapScreenGum.GetGraphicalUiElementByName("ConfirmationWindowInstance") as AbbatoirIntergrade.GumRuntimes.ConfirmationWindowRuntime;
            HUDLayer = new FlatRedBall.Graphics.Layer();
            HUDLayer.Name = "HUDLayer";
            CurrentMusicDisplayInstance = MapScreenGum.GetGraphicalUiElementByName("CurrentMusicDisplayInstance") as AbbatoirIntergrade.GumRuntimes.CurrentMusicDisplayRuntime;
            
            
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
            FlatRedBall.SpriteManager.AddLayer(StructureLayer);
            StructureLayer.UsePixelCoordinates();
            if (FlatRedBall.SpriteManager.Camera.Orthogonal)
            {
                StructureLayer.LayerCameraSettings.OrthogonalWidth = FlatRedBall.SpriteManager.Camera.OrthogonalWidth;
                StructureLayer.LayerCameraSettings.OrthogonalHeight = FlatRedBall.SpriteManager.Camera.OrthogonalHeight;
            }
            FlatRedBall.SpriteManager.AddLayer(HUDLayer);
            HUDLayer.UsePixelCoordinates();
            if (FlatRedBall.SpriteManager.Camera.Orthogonal)
            {
                HUDLayer.LayerCameraSettings.OrthogonalWidth = FlatRedBall.SpriteManager.Camera.OrthogonalWidth;
                HUDLayer.LayerCameraSettings.OrthogonalHeight = FlatRedBall.SpriteManager.Camera.OrthogonalHeight;
            }
            StructureLayerGum = RenderingLibrary.SystemManagers.Default.Renderer.AddLayer();
            StructureLayerGum.Name = "StructureLayerGum";
            MapScreenGum.AddGumLayerToFrbLayer(StructureLayerGum, StructureLayer);
            HUDLayerGum = RenderingLibrary.SystemManagers.Default.Renderer.AddLayer();
            HUDLayerGum.Name = "HUDLayerGum";
            MapScreenGum.AddGumLayerToFrbLayer(HUDLayerGum, HUDLayer);
            Factories.BombardingTowerFactory.AddList(StructureList);
            Factories.ChemicalTowerFactory.AddList(StructureList);
            Factories.ElectricTowerFactory.AddList(StructureList);
            Factories.FireTowerFactory.AddList(StructureList);
            Factories.FrostTowerFactory.AddList(StructureList);
            Factories.PiercingTowerFactory.AddList(StructureList);
            Factories.CannonProjectileFactory.AddList(ProjectileList);
            Factories.ChemicalProjectileFactory.AddList(ProjectileList);
            Factories.ElectricProjectileFactory.AddList(ProjectileList);
            Factories.FireProjectileFactory.AddList(ProjectileList);
            Factories.FrostProjectileFactory.AddList(ProjectileList);
            Factories.PiercingProjectileFactory.AddList(ProjectileList);
            MenuWindowInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            ChatHistoryInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            OkMessageInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            ConfirmationWindowInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                for (int i = StructureList.Count - 1; i > -1; i--)
                {
                    if (i < StructureList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        StructureList[i].Activity();
                    }
                }
                for (int i = ProjectileList.Count - 1; i > -1; i--)
                {
                    if (i < ProjectileList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        ProjectileList[i].Activity();
                    }
                }
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
            Factories.BombardingTowerFactory.Destroy();
            Factories.ChemicalTowerFactory.Destroy();
            Factories.ElectricTowerFactory.Destroy();
            Factories.FireTowerFactory.Destroy();
            Factories.FrostTowerFactory.Destroy();
            Factories.PiercingTowerFactory.Destroy();
            Factories.CannonProjectileFactory.Destroy();
            Factories.ChemicalProjectileFactory.Destroy();
            Factories.ElectricProjectileFactory.Destroy();
            Factories.FireProjectileFactory.Destroy();
            Factories.FrostProjectileFactory.Destroy();
            Factories.PiercingProjectileFactory.Destroy();
            worldmap = null;
            FlatRedBall.SpriteManager.RemoveDrawableBatch(MapScreenGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= MapScreenGum.HandleResolutionChanged;
            MapScreenGum = null;
            Messages = null;
            StructureSelection = null;
            
            StructureList.MakeOneWay();
            ProjectileList.MakeOneWay();
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
            if (TowerSelectionBoxInstance != null)
            {
                TowerSelectionBoxInstance.RemoveFromManagers();
            }
            for (int i = StructureList.Count - 1; i > -1; i--)
            {
                StructureList[i].Destroy();
            }
            if (StructureLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(StructureLayer);
            }
            for (int i = ProjectileList.Count - 1; i > -1; i--)
            {
                ProjectileList[i].Destroy();
            }
            if (OkMessageInstance != null)
            {
                OkMessageInstance.RemoveFromManagers();
            }
            if (ConfirmationWindowInstance != null)
            {
                ConfirmationWindowInstance.RemoveFromManagers();
            }
            if (HUDLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(HUDLayer);
            }
            if (CurrentMusicDisplayInstance != null)
            {
                CurrentMusicDisplayInstance.RemoveFromManagers();
            }
            StructureList.MakeTwoWay();
            ProjectileList.MakeTwoWay();
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
            MenuWindowInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            ChatHistoryInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            OkMessageInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            ConfirmationWindowInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            FlatRedBall.Gui.GuiManager.SortZAndLayerBased();
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
            if (TowerSelectionBoxInstance != null)
            {
                TowerSelectionBoxInstance.RemoveFromManagers();
            }
            for (int i = StructureList.Count - 1; i > -1; i--)
            {
                StructureList[i].Destroy();
            }
            if (StructureLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(StructureLayer);
            }
            for (int i = ProjectileList.Count - 1; i > -1; i--)
            {
                ProjectileList[i].Destroy();
            }
            if (OkMessageInstance != null)
            {
                OkMessageInstance.RemoveFromManagers();
            }
            if (ConfirmationWindowInstance != null)
            {
                ConfirmationWindowInstance.RemoveFromManagers();
            }
            if (HUDLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(HUDLayer);
            }
            if (CurrentMusicDisplayInstance != null)
            {
                CurrentMusicDisplayInstance.RemoveFromManagers();
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
            for (int i = 0; i < StructureList.Count; i++)
            {
                StructureList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < ProjectileList.Count; i++)
            {
                ProjectileList[i].ConvertToManuallyUpdated();
            }
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
            if (Messages == null)
            {
                {
                    // We put the { and } to limit the scope of oldDelimiter
                    char oldDelimiter = FlatRedBall.IO.Csv.CsvFileManager.Delimiter;
                    FlatRedBall.IO.Csv.CsvFileManager.Delimiter = ',';
                    System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.Messages> temporaryCsvObject = new System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.Messages>();
                    FlatRedBall.IO.Csv.CsvFileManager.CsvDeserializeDictionary<string, AbbatoirIntergrade.DataTypes.Messages>("content/screens/mapscreen/messages.csv", temporaryCsvObject);
                    FlatRedBall.IO.Csv.CsvFileManager.Delimiter = oldDelimiter;
                    Messages = temporaryCsvObject;
                }
            }
            StructureSelection = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/mapscreen/structureselection", contentManagerName);
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
                case  "Messages":
                    return Messages;
                case  "StructureSelection":
                    return StructureSelection;
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
                case  "Messages":
                    return Messages;
                case  "StructureSelection":
                    return StructureSelection;
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
                case  "StructureSelection":
                    return StructureSelection;
            }
            return null;
        }
    }
}
