#if ANDROID || IOS
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
using FlatRedBall.Graphics;
using FlatRedBall.Math;
namespace AbbatoirIntergrade.Screens
{
    public partial class GameScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static FlatRedBall.Gum.GumIdb GameScreenGum;
        protected static Microsoft.Xna.Framework.Graphics.Effect darknessshader;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D CombinedAssets;
        protected static FlatRedBall.TileGraphics.LayeredTileMap Chapter1;
        
        private Microsoft.Xna.Framework.Graphics.RenderTarget2D WorldRenderTarget;
        private Microsoft.Xna.Framework.Graphics.RenderTarget2D DarknessRenderTarget;
        private AbbatoirIntergrade.Entities.ShaderRenderer ShaderRendererInstance;
        private FlatRedBall.Graphics.Layer BackgroundLayer;
        private AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime HorizonBoxInstance;
        private FlatRedBall.Graphics.Layer WorldLayer;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseStructure> AllStructuresList;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy> AllEnemiesList;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BasePlayerProjectile> PlayerProjectileList;
        private FlatRedBall.Graphics.Layer LightLayer;
        private FlatRedBall.Graphics.Layer ShaderOutputLayer;
        private FlatRedBall.Graphics.Layer InfoLayer;
        private FlatRedBall.Graphics.Layer HUDLayer;
        private Microsoft.Xna.Framework.Graphics.RenderTarget2D BackgroundRenderTarget;
        private AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime EnemyInfoInstance;
        private AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime StructureInfoInstance;
        private AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime ChatBoxInstance;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.StructurePlacement> StructurePlacementList;
        private AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime BuildMenuInstance;
        private AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime LivesPointsDisplayInstance;
        protected global::RenderingLibrary.Graphics.Layer BackgroundLayerGum;
        protected global::RenderingLibrary.Graphics.Layer WorldLayerGum;
        protected global::RenderingLibrary.Graphics.Layer LightLayerGum;
        protected global::RenderingLibrary.Graphics.Layer ShaderOutputLayerGum;
        protected global::RenderingLibrary.Graphics.Layer InfoLayerGum;
        protected global::RenderingLibrary.Graphics.Layer HUDLayerGum;
        public GameScreen () 
        	: base ("Global")
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            WorldRenderTarget = new Microsoft.Xna.Framework.Graphics.RenderTarget2D(FlatRedBall.FlatRedBallServices.GraphicsDevice, FlatRedBall.Camera.Main.DestinationRectangle.Width, FlatRedBall.Camera.Main.DestinationRectangle.Height);
            DarknessRenderTarget = new Microsoft.Xna.Framework.Graphics.RenderTarget2D(FlatRedBall.FlatRedBallServices.GraphicsDevice, FlatRedBall.Camera.Main.DestinationRectangle.Width, FlatRedBall.Camera.Main.DestinationRectangle.Height);
            ShaderRendererInstance = new AbbatoirIntergrade.Entities.ShaderRenderer(ContentManagerName, false);
            ShaderRendererInstance.Name = "ShaderRendererInstance";
            BackgroundLayer = new FlatRedBall.Graphics.Layer();
            BackgroundLayer.Name = "BackgroundLayer";
            HorizonBoxInstance = GameScreenGum.GetGraphicalUiElementByName("HorizonBoxInstance") as AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime;
            WorldLayer = new FlatRedBall.Graphics.Layer();
            WorldLayer.Name = "WorldLayer";
            AllStructuresList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseStructure>();
            AllStructuresList.Name = "AllStructuresList";
            AllEnemiesList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy>();
            AllEnemiesList.Name = "AllEnemiesList";
            PlayerProjectileList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BasePlayerProjectile>();
            PlayerProjectileList.Name = "PlayerProjectileList";
            LightLayer = new FlatRedBall.Graphics.Layer();
            LightLayer.Name = "LightLayer";
            ShaderOutputLayer = new FlatRedBall.Graphics.Layer();
            ShaderOutputLayer.Name = "ShaderOutputLayer";
            InfoLayer = new FlatRedBall.Graphics.Layer();
            InfoLayer.Name = "InfoLayer";
            HUDLayer = new FlatRedBall.Graphics.Layer();
            HUDLayer.Name = "HUDLayer";
            BackgroundRenderTarget = new Microsoft.Xna.Framework.Graphics.RenderTarget2D(FlatRedBall.FlatRedBallServices.GraphicsDevice, FlatRedBall.Camera.Main.DestinationRectangle.Width, FlatRedBall.Camera.Main.DestinationRectangle.Height);
            EnemyInfoInstance = GameScreenGum.GetGraphicalUiElementByName("EnemyInfoInstance") as AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime;
            StructureInfoInstance = GameScreenGum.GetGraphicalUiElementByName("StructureInfoInstance") as AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime;
            ChatBoxInstance = GameScreenGum.GetGraphicalUiElementByName("ChatBoxInstance") as AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime;
            StructurePlacementList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.StructurePlacement>();
            StructurePlacementList.Name = "StructurePlacementList";
            BuildMenuInstance = GameScreenGum.GetGraphicalUiElementByName("BuildMenuInstance") as AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime;
            LivesPointsDisplayInstance = GameScreenGum.GetGraphicalUiElementByName("LivesPointsDisplayInstance") as AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime;
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            GameScreenGum.InstanceInitialize(); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += GameScreenGum.HandleResolutionChanged;
            Chapter1.AddToManagers(mLayer);
            FlatRedBall.SpriteManager.AddLayer(BackgroundLayer);
            BackgroundLayer.UsePixelCoordinates();
            if (FlatRedBall.SpriteManager.Camera.Orthogonal)
            {
                BackgroundLayer.LayerCameraSettings.OrthogonalWidth = FlatRedBall.SpriteManager.Camera.OrthogonalWidth;
                BackgroundLayer.LayerCameraSettings.OrthogonalHeight = FlatRedBall.SpriteManager.Camera.OrthogonalHeight;
            }
            FlatRedBall.SpriteManager.AddLayer(WorldLayer);
            WorldLayer.UsePixelCoordinates();
            if (FlatRedBall.SpriteManager.Camera.Orthogonal)
            {
                WorldLayer.LayerCameraSettings.OrthogonalWidth = FlatRedBall.SpriteManager.Camera.OrthogonalWidth;
                WorldLayer.LayerCameraSettings.OrthogonalHeight = FlatRedBall.SpriteManager.Camera.OrthogonalHeight;
            }
            FlatRedBall.SpriteManager.AddLayer(LightLayer);
            LightLayer.UsePixelCoordinates();
            if (FlatRedBall.SpriteManager.Camera.Orthogonal)
            {
                LightLayer.LayerCameraSettings.OrthogonalWidth = FlatRedBall.SpriteManager.Camera.OrthogonalWidth;
                LightLayer.LayerCameraSettings.OrthogonalHeight = FlatRedBall.SpriteManager.Camera.OrthogonalHeight;
            }
            FlatRedBall.SpriteManager.AddLayer(ShaderOutputLayer);
            ShaderOutputLayer.UsePixelCoordinates();
            if (FlatRedBall.SpriteManager.Camera.Orthogonal)
            {
                ShaderOutputLayer.LayerCameraSettings.OrthogonalWidth = FlatRedBall.SpriteManager.Camera.OrthogonalWidth;
                ShaderOutputLayer.LayerCameraSettings.OrthogonalHeight = FlatRedBall.SpriteManager.Camera.OrthogonalHeight;
            }
            FlatRedBall.SpriteManager.AddLayer(InfoLayer);
            InfoLayer.UsePixelCoordinates();
            if (FlatRedBall.SpriteManager.Camera.Orthogonal)
            {
                InfoLayer.LayerCameraSettings.OrthogonalWidth = FlatRedBall.SpriteManager.Camera.OrthogonalWidth;
                InfoLayer.LayerCameraSettings.OrthogonalHeight = FlatRedBall.SpriteManager.Camera.OrthogonalHeight;
            }
            FlatRedBall.SpriteManager.AddLayer(HUDLayer);
            HUDLayer.UsePixelCoordinates();
            if (FlatRedBall.SpriteManager.Camera.Orthogonal)
            {
                HUDLayer.LayerCameraSettings.OrthogonalWidth = FlatRedBall.SpriteManager.Camera.OrthogonalWidth;
                HUDLayer.LayerCameraSettings.OrthogonalHeight = FlatRedBall.SpriteManager.Camera.OrthogonalHeight;
            }
            BackgroundLayerGum = RenderingLibrary.SystemManagers.Default.Renderer.AddLayer();
            BackgroundLayerGum.Name = "BackgroundLayerGum";
            GameScreenGum.AddGumLayerToFrbLayer(BackgroundLayerGum, BackgroundLayer);
            WorldLayerGum = RenderingLibrary.SystemManagers.Default.Renderer.AddLayer();
            WorldLayerGum.Name = "WorldLayerGum";
            GameScreenGum.AddGumLayerToFrbLayer(WorldLayerGum, WorldLayer);
            LightLayerGum = RenderingLibrary.SystemManagers.Default.Renderer.AddLayer();
            LightLayerGum.Name = "LightLayerGum";
            GameScreenGum.AddGumLayerToFrbLayer(LightLayerGum, LightLayer);
            ShaderOutputLayerGum = RenderingLibrary.SystemManagers.Default.Renderer.AddLayer();
            ShaderOutputLayerGum.Name = "ShaderOutputLayerGum";
            GameScreenGum.AddGumLayerToFrbLayer(ShaderOutputLayerGum, ShaderOutputLayer);
            InfoLayerGum = RenderingLibrary.SystemManagers.Default.Renderer.AddLayer();
            InfoLayerGum.Name = "InfoLayerGum";
            GameScreenGum.AddGumLayerToFrbLayer(InfoLayerGum, InfoLayer);
            HUDLayerGum = RenderingLibrary.SystemManagers.Default.Renderer.AddLayer();
            HUDLayerGum.Name = "HUDLayerGum";
            GameScreenGum.AddGumLayerToFrbLayer(HUDLayerGum, HUDLayer);
            StructurePlacementFactory.Initialize(ContentManagerName);
            StructurePlacementFactory.AddList(StructurePlacementList);
            
            
            ShaderRendererInstance.AddToManagers(ShaderOutputLayer);
            HorizonBoxInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(BackgroundLayer)));
            
            ChatBoxInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            BuildMenuInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            LivesPointsDisplayInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                ShaderRendererInstance.Activity();
                for (int i = AllStructuresList.Count - 1; i > -1; i--)
                {
                    if (i < AllStructuresList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        AllStructuresList[i].Activity();
                    }
                }
                for (int i = AllEnemiesList.Count - 1; i > -1; i--)
                {
                    if (i < AllEnemiesList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        AllEnemiesList[i].Activity();
                    }
                }
                for (int i = PlayerProjectileList.Count - 1; i > -1; i--)
                {
                    if (i < PlayerProjectileList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        PlayerProjectileList[i].Activity();
                    }
                }
                for (int i = StructurePlacementList.Count - 1; i > -1; i--)
                {
                    if (i < StructurePlacementList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        StructurePlacementList[i].Activity();
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
            BombardingTowerFactory.Destroy();
            ChemicalTowerFactory.Destroy();
            ElectricTowerFactory.Destroy();
            FireTowerFactory.Destroy();
            FrostTowerFactory.Destroy();
            PiercingTowerFactory.Destroy();
            Chicken1EnemyFactory.Destroy();
            Chicken2EnemyFactory.Destroy();
            Chicken3EnemyFactory.Destroy();
            Cow1EnemyFactory.Destroy();
            Cow2EnemyFactory.Destroy();
            Cow3EnemyFactory.Destroy();
            Pig1EnemyFactory.Destroy();
            Pig2EnemyFactory.Destroy();
            Pig3EnemyFactory.Destroy();
            Rabbit1EnemyFactory.Destroy();
            Rabbit2EnemyFactory.Destroy();
            Rabbit3EnemyFactory.Destroy();
            Sheep1EnemyFactory.Destroy();
            Sheep2EnemyFactory.Destroy();
            Sheep3EnemyFactory.Destroy();
            CannonProjectileFactory.Destroy();
            ChemicalProjectileFactory.Destroy();
            ElectricProjectileFactory.Destroy();
            FireProjectileFactory.Destroy();
            FrostProjectileFactory.Destroy();
            PiercingProjectileFactory.Destroy();
            StructurePlacementFactory.Destroy();
            FlatRedBall.SpriteManager.RemoveDrawableBatch(GameScreenGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= GameScreenGum.HandleResolutionChanged;
            GameScreenGum = null;
            darknessshader = null;
            CombinedAssets = null;
            Chapter1.Destroy();
            Chapter1 = null;
            
            AllStructuresList.MakeOneWay();
            AllEnemiesList.MakeOneWay();
            PlayerProjectileList.MakeOneWay();
            StructurePlacementList.MakeOneWay();
            if (WorldRenderTarget != null)
            {
                WorldRenderTarget.Dispose();
            }
            if (DarknessRenderTarget != null)
            {
                DarknessRenderTarget.Dispose();
            }
            if (ShaderRendererInstance != null)
            {
                ShaderRendererInstance.Destroy();
                ShaderRendererInstance.Detach();
            }
            if (BackgroundLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(BackgroundLayer);
            }
            if (HorizonBoxInstance != null)
            {
                HorizonBoxInstance.RemoveFromManagers();
            }
            if (WorldLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(WorldLayer);
            }
            for (int i = AllStructuresList.Count - 1; i > -1; i--)
            {
                AllStructuresList[i].Destroy();
            }
            for (int i = AllEnemiesList.Count - 1; i > -1; i--)
            {
                AllEnemiesList[i].Destroy();
            }
            for (int i = PlayerProjectileList.Count - 1; i > -1; i--)
            {
                PlayerProjectileList[i].Destroy();
            }
            if (LightLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(LightLayer);
            }
            if (ShaderOutputLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(ShaderOutputLayer);
            }
            if (InfoLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(InfoLayer);
            }
            if (HUDLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(HUDLayer);
            }
            if (BackgroundRenderTarget != null)
            {
                BackgroundRenderTarget.Dispose();
            }
            if (EnemyInfoInstance != null)
            {
                EnemyInfoInstance.RemoveFromManagers();
            }
            if (StructureInfoInstance != null)
            {
                StructureInfoInstance.RemoveFromManagers();
            }
            if (ChatBoxInstance != null)
            {
                ChatBoxInstance.RemoveFromManagers();
            }
            for (int i = StructurePlacementList.Count - 1; i > -1; i--)
            {
                StructurePlacementList[i].Destroy();
            }
            if (BuildMenuInstance != null)
            {
                BuildMenuInstance.RemoveFromManagers();
            }
            if (LivesPointsDisplayInstance != null)
            {
                LivesPointsDisplayInstance.RemoveFromManagers();
            }
            AllStructuresList.MakeTwoWay();
            AllEnemiesList.MakeTwoWay();
            PlayerProjectileList.MakeTwoWay();
            StructurePlacementList.MakeTwoWay();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            BackgroundLayer.SortType = FlatRedBall.Graphics.SortType.ZSecondaryParentY;
            BackgroundLayer.Visible = true;
            WorldLayer.SortType = FlatRedBall.Graphics.SortType.ZSecondaryParentY;
            WorldLayer.Visible = true;
            LightLayer.SortType = FlatRedBall.Graphics.SortType.ZSecondaryParentY;
            ShaderOutputLayer.SortType = FlatRedBall.Graphics.SortType.ZSecondaryParentY;
            InfoLayer.Visible = true;
            HUDLayer.Visible = true;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
            HorizonBoxInstance.MoveToFrbLayer(BackgroundLayer, BackgroundLayerGum);
            ChatBoxInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            BuildMenuInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            LivesPointsDisplayInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            FlatRedBall.Gui.GuiManager.SortZAndLayerBased();
        }
        public virtual void RemoveFromManagers () 
        {
            if (WorldRenderTarget != null)
            {
                WorldRenderTarget.Dispose();
            }
            if (DarknessRenderTarget != null)
            {
                DarknessRenderTarget.Dispose();
            }
            ShaderRendererInstance.RemoveFromManagers();
            if (BackgroundLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(BackgroundLayer);
            }
            if (HorizonBoxInstance != null)
            {
                HorizonBoxInstance.RemoveFromManagers();
            }
            if (WorldLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(WorldLayer);
            }
            for (int i = AllStructuresList.Count - 1; i > -1; i--)
            {
                AllStructuresList[i].Destroy();
            }
            for (int i = AllEnemiesList.Count - 1; i > -1; i--)
            {
                AllEnemiesList[i].Destroy();
            }
            for (int i = PlayerProjectileList.Count - 1; i > -1; i--)
            {
                PlayerProjectileList[i].Destroy();
            }
            if (LightLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(LightLayer);
            }
            if (ShaderOutputLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(ShaderOutputLayer);
            }
            if (InfoLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(InfoLayer);
            }
            if (HUDLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(HUDLayer);
            }
            if (BackgroundRenderTarget != null)
            {
                BackgroundRenderTarget.Dispose();
            }
            if (EnemyInfoInstance != null)
            {
                EnemyInfoInstance.RemoveFromManagers();
            }
            if (StructureInfoInstance != null)
            {
                StructureInfoInstance.RemoveFromManagers();
            }
            if (ChatBoxInstance != null)
            {
                ChatBoxInstance.RemoveFromManagers();
            }
            for (int i = StructurePlacementList.Count - 1; i > -1; i--)
            {
                StructurePlacementList[i].Destroy();
            }
            if (BuildMenuInstance != null)
            {
                BuildMenuInstance.RemoveFromManagers();
            }
            if (LivesPointsDisplayInstance != null)
            {
                LivesPointsDisplayInstance.RemoveFromManagers();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                ShaderRendererInstance.AssignCustomVariables(true);
            }
            BackgroundLayer.SortType = FlatRedBall.Graphics.SortType.ZSecondaryParentY;
            BackgroundLayer.Visible = true;
            WorldLayer.SortType = FlatRedBall.Graphics.SortType.ZSecondaryParentY;
            WorldLayer.Visible = true;
            LightLayer.SortType = FlatRedBall.Graphics.SortType.ZSecondaryParentY;
            ShaderOutputLayer.SortType = FlatRedBall.Graphics.SortType.ZSecondaryParentY;
            InfoLayer.Visible = true;
            HUDLayer.Visible = true;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            ShaderRendererInstance.ConvertToManuallyUpdated();
            for (int i = 0; i < AllStructuresList.Count; i++)
            {
                AllStructuresList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < AllEnemiesList.Count; i++)
            {
                AllEnemiesList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < PlayerProjectileList.Count; i++)
            {
                PlayerProjectileList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < StructurePlacementList.Count; i++)
            {
                StructurePlacementList[i].ConvertToManuallyUpdated();
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
            Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;  GameScreenGum = new FlatRedBall.Gum.GumIdb();  GameScreenGum.LoadFromFile("content/gumproject/screens/gamescreengum.gusx");  GameScreenGum.AssignReferences();Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = false; GameScreenGum.Element.UpdateLayout(); GameScreenGum.Element.UpdateLayout();
            darknessshader = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Effect>(@"content/screens/gamescreen/effects/darknessshader", contentManagerName);
            CombinedAssets = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/tilesets/combinedassets.png", contentManagerName);
            Chapter1 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter1.tmx", contentManagerName);
            AbbatoirIntergrade.Entities.ShaderRenderer.LoadStaticContent(contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
                case  "darknessshader":
                    return darknessshader;
                case  "CombinedAssets":
                    return CombinedAssets;
                case  "Chapter1":
                    return Chapter1;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
                case  "darknessshader":
                    return darknessshader;
                case  "CombinedAssets":
                    return CombinedAssets;
                case  "Chapter1":
                    return Chapter1;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
                case  "darknessshader":
                    return darknessshader;
                case  "CombinedAssets":
                    return CombinedAssets;
                case  "Chapter1":
                    return Chapter1;
            }
            return null;
        }
    }
}
