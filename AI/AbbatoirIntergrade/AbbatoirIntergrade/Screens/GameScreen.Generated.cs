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
        static FlatRedBall.TileGraphics.LayeredTileMap mChapter1;
        static string mLastContentManagerForChapter1;
        public static FlatRedBall.TileGraphics.LayeredTileMap Chapter1
        {
            get
            {
                if (mChapter1 == null || mLastContentManagerForChapter1 != "GameScreen")
                {
                    mLastContentManagerForChapter1 = "GameScreen";
                    mChapter1 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter1.tmx", "GameScreen");
                }
                return mChapter1;
            }
        }
        static FlatRedBall.TileGraphics.LayeredTileMap mChapter2;
        static string mLastContentManagerForChapter2;
        public static FlatRedBall.TileGraphics.LayeredTileMap Chapter2
        {
            get
            {
                if (mChapter2 == null || mLastContentManagerForChapter2 != "GameScreen")
                {
                    mLastContentManagerForChapter2 = "GameScreen";
                    mChapter2 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter2.tmx", "GameScreen");
                }
                return mChapter2;
            }
        }
        protected static Microsoft.Xna.Framework.Graphics.Texture2D CollisionShapes;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect IncomingMessage;
        static FlatRedBall.TileGraphics.LayeredTileMap mChapter3;
        static string mLastContentManagerForChapter3;
        public static FlatRedBall.TileGraphics.LayeredTileMap Chapter3
        {
            get
            {
                if (mChapter3 == null || mLastContentManagerForChapter3 != "GameScreen")
                {
                    mLastContentManagerForChapter3 = "GameScreen";
                    mChapter3 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter3.tmx", "GameScreen");
                }
                return mChapter3;
            }
        }
        static FlatRedBall.TileGraphics.LayeredTileMap mChapter4;
        static string mLastContentManagerForChapter4;
        public static FlatRedBall.TileGraphics.LayeredTileMap Chapter4
        {
            get
            {
                if (mChapter4 == null || mLastContentManagerForChapter4 != "GameScreen")
                {
                    mLastContentManagerForChapter4 = "GameScreen";
                    mChapter4 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter4.tmx", "GameScreen");
                }
                return mChapter4;
            }
        }
        static FlatRedBall.TileGraphics.LayeredTileMap mChapter5;
        static string mLastContentManagerForChapter5;
        public static FlatRedBall.TileGraphics.LayeredTileMap Chapter5
        {
            get
            {
                if (mChapter5 == null || mLastContentManagerForChapter5 != "GameScreen")
                {
                    mLastContentManagerForChapter5 = "GameScreen";
                    mChapter5 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter5.tmx", "GameScreen");
                }
                return mChapter5;
            }
        }
        static FlatRedBall.TileGraphics.LayeredTileMap mChapter6;
        static string mLastContentManagerForChapter6;
        public static FlatRedBall.TileGraphics.LayeredTileMap Chapter6
        {
            get
            {
                if (mChapter6 == null || mLastContentManagerForChapter6 != "GameScreen")
                {
                    mLastContentManagerForChapter6 = "GameScreen";
                    mChapter6 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter6.tmx", "GameScreen");
                }
                return mChapter6;
            }
        }
        static FlatRedBall.TileGraphics.LayeredTileMap mChapter7;
        static string mLastContentManagerForChapter7;
        public static FlatRedBall.TileGraphics.LayeredTileMap Chapter7
        {
            get
            {
                if (mChapter7 == null || mLastContentManagerForChapter7 != "GameScreen")
                {
                    mLastContentManagerForChapter7 = "GameScreen";
                    mChapter7 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter7.tmx", "GameScreen");
                }
                return mChapter7;
            }
        }
        static FlatRedBall.TileGraphics.LayeredTileMap mChapter8;
        static string mLastContentManagerForChapter8;
        public static FlatRedBall.TileGraphics.LayeredTileMap Chapter8
        {
            get
            {
                if (mChapter8 == null || mLastContentManagerForChapter8 != "GameScreen")
                {
                    mLastContentManagerForChapter8 = "GameScreen";
                    mChapter8 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter8.tmx", "GameScreen");
                }
                return mChapter8;
            }
        }
        static FlatRedBall.TileGraphics.LayeredTileMap mChapter9;
        static string mLastContentManagerForChapter9;
        public static FlatRedBall.TileGraphics.LayeredTileMap Chapter9
        {
            get
            {
                if (mChapter9 == null || mLastContentManagerForChapter9 != "GameScreen")
                {
                    mLastContentManagerForChapter9 = "GameScreen";
                    mChapter9 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter9.tmx", "GameScreen");
                }
                return mChapter9;
            }
        }
        static FlatRedBall.TileGraphics.LayeredTileMap mChapter10;
        static string mLastContentManagerForChapter10;
        public static FlatRedBall.TileGraphics.LayeredTileMap Chapter10
        {
            get
            {
                if (mChapter10 == null || mLastContentManagerForChapter10 != "GameScreen")
                {
                    mLastContentManagerForChapter10 = "GameScreen";
                    mChapter10 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/gamescreen/levels/chapter10.tmx", "GameScreen");
                }
                return mChapter10;
            }
        }
        protected static Microsoft.Xna.Framework.Audio.SoundEffect OutgoingMessage;
        
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
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TileCollisionRectangle> TileCollisionRectangleList;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TileCollisionCircle> TileCollisionCircleList;
        private AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime ChatHistoryInstance;
        private AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime GameScreenGumInstance;
        private AbbatoirIntergrade.GumRuntimes.TopStatusBarRuntime TopStatusBarInstance;
        private AbbatoirIntergrade.GumRuntimes.ScreenShadeRuntime ScreenShadeInstance;
        private AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime MenuWindowInstance;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TiledOverlay> TiledOverlayList;
        private AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime LocationTimeInstance;
        private AbbatoirIntergrade.GumRuntimes.ConfirmationWindowRuntime ConfirmationWindowInstance;
        private AbbatoirIntergrade.GumRuntimes.CurrentMusicDisplayRuntime CurrentMusicDisplayInstance;
        protected global::RenderingLibrary.Graphics.Layer BackgroundLayerGum;
        protected global::RenderingLibrary.Graphics.Layer WorldLayerGum;
        protected global::RenderingLibrary.Graphics.Layer LightLayerGum;
        protected global::RenderingLibrary.Graphics.Layer ShaderOutputLayerGum;
        protected global::RenderingLibrary.Graphics.Layer InfoLayerGum;
        protected global::RenderingLibrary.Graphics.Layer HUDLayerGum;
        public GameScreen () 
        	: base ("GameScreen")
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
            TileCollisionRectangleList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TileCollisionRectangle>();
            TileCollisionRectangleList.Name = "TileCollisionRectangleList";
            TileCollisionCircleList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TileCollisionCircle>();
            TileCollisionCircleList.Name = "TileCollisionCircleList";
            ChatHistoryInstance = GameScreenGum.GetGraphicalUiElementByName("ChatHistoryInstance") as AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime;
            GameScreenGumInstance = GameScreenGum.GetGraphicalUiElementByName("this") as AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime;
            TopStatusBarInstance = GameScreenGum.GetGraphicalUiElementByName("TopStatusBarInstance") as AbbatoirIntergrade.GumRuntimes.TopStatusBarRuntime;
            ScreenShadeInstance = GameScreenGum.GetGraphicalUiElementByName("ScreenShadeInstance") as AbbatoirIntergrade.GumRuntimes.ScreenShadeRuntime;
            MenuWindowInstance = GameScreenGum.GetGraphicalUiElementByName("MenuWindowInstance") as AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime;
            TiledOverlayList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TiledOverlay>();
            TiledOverlayList.Name = "TiledOverlayList";
            LocationTimeInstance = GameScreenGum.GetGraphicalUiElementByName("LocationTimeAnnouncementInstance") as AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime;
            ConfirmationWindowInstance = GameScreenGum.GetGraphicalUiElementByName("ConfirmationWindowInstance") as AbbatoirIntergrade.GumRuntimes.ConfirmationWindowRuntime;
            CurrentMusicDisplayInstance = GameScreenGum.GetGraphicalUiElementByName("CurrentMusicDisplayInstance") as AbbatoirIntergrade.GumRuntimes.CurrentMusicDisplayRuntime;
            
            
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
            Factories.StructurePlacementFactory.Initialize(ContentManagerName);
            Factories.TileCollisionRectangleFactory.Initialize(ContentManagerName);
            Factories.TileCollisionCircleFactory.Initialize(ContentManagerName);
            Factories.TiledOverlayFactory.Initialize(ContentManagerName);
            Factories.BombardingTowerFactory.AddList(AllStructuresList);
            Factories.ChemicalTowerFactory.AddList(AllStructuresList);
            Factories.ElectricTowerFactory.AddList(AllStructuresList);
            Factories.FireTowerFactory.AddList(AllStructuresList);
            Factories.FrostTowerFactory.AddList(AllStructuresList);
            Factories.PiercingTowerFactory.AddList(AllStructuresList);
            Factories.Chicken1EnemyFactory.AddList(AllEnemiesList);
            Factories.Chicken2EnemyFactory.AddList(AllEnemiesList);
            Factories.Chicken3EnemyFactory.AddList(AllEnemiesList);
            Factories.Cow1EnemyFactory.AddList(AllEnemiesList);
            Factories.Cow2EnemyFactory.AddList(AllEnemiesList);
            Factories.Cow3EnemyFactory.AddList(AllEnemiesList);
            Factories.Pig1EnemyFactory.AddList(AllEnemiesList);
            Factories.Pig2EnemyFactory.AddList(AllEnemiesList);
            Factories.Pig3EnemyFactory.AddList(AllEnemiesList);
            Factories.Rabbit1EnemyFactory.AddList(AllEnemiesList);
            Factories.Rabbit2EnemyFactory.AddList(AllEnemiesList);
            Factories.Rabbit3EnemyFactory.AddList(AllEnemiesList);
            Factories.Sheep1EnemyFactory.AddList(AllEnemiesList);
            Factories.Sheep2EnemyFactory.AddList(AllEnemiesList);
            Factories.Sheep3EnemyFactory.AddList(AllEnemiesList);
            Factories.CannonProjectileFactory.AddList(PlayerProjectileList);
            Factories.ChemicalProjectileFactory.AddList(PlayerProjectileList);
            Factories.ElectricProjectileFactory.AddList(PlayerProjectileList);
            Factories.FireProjectileFactory.AddList(PlayerProjectileList);
            Factories.FrostProjectileFactory.AddList(PlayerProjectileList);
            Factories.PiercingProjectileFactory.AddList(PlayerProjectileList);
            Factories.StructurePlacementFactory.AddList(StructurePlacementList);
            Factories.TileCollisionRectangleFactory.AddList(TileCollisionRectangleList);
            Factories.TileCollisionCircleFactory.AddList(TileCollisionCircleList);
            Factories.TiledOverlayFactory.AddList(TiledOverlayList);
            
            
            ShaderRendererInstance.AddToManagers(ShaderOutputLayer);
            HorizonBoxInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(BackgroundLayer)));
            
            EnemyInfoInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            StructureInfoInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            ChatBoxInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            BuildMenuInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            LivesPointsDisplayInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            ChatHistoryInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            TopStatusBarInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            ScreenShadeInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            MenuWindowInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            LocationTimeInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            ConfirmationWindowInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
            CurrentMusicDisplayInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));
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
            Factories.StructurePlacementFactory.Destroy();
            Factories.TileCollisionRectangleFactory.Destroy();
            Factories.TileCollisionCircleFactory.Destroy();
            Factories.TiledOverlayFactory.Destroy();
            Factories.BombardingTowerFactory.Destroy();
            Factories.ChemicalTowerFactory.Destroy();
            Factories.ElectricTowerFactory.Destroy();
            Factories.FireTowerFactory.Destroy();
            Factories.FrostTowerFactory.Destroy();
            Factories.PiercingTowerFactory.Destroy();
            Factories.Chicken1EnemyFactory.Destroy();
            Factories.Chicken2EnemyFactory.Destroy();
            Factories.Chicken3EnemyFactory.Destroy();
            Factories.Cow1EnemyFactory.Destroy();
            Factories.Cow2EnemyFactory.Destroy();
            Factories.Cow3EnemyFactory.Destroy();
            Factories.Pig1EnemyFactory.Destroy();
            Factories.Pig2EnemyFactory.Destroy();
            Factories.Pig3EnemyFactory.Destroy();
            Factories.Rabbit1EnemyFactory.Destroy();
            Factories.Rabbit2EnemyFactory.Destroy();
            Factories.Rabbit3EnemyFactory.Destroy();
            Factories.Sheep1EnemyFactory.Destroy();
            Factories.Sheep2EnemyFactory.Destroy();
            Factories.Sheep3EnemyFactory.Destroy();
            Factories.CannonProjectileFactory.Destroy();
            Factories.ChemicalProjectileFactory.Destroy();
            Factories.ElectricProjectileFactory.Destroy();
            Factories.FireProjectileFactory.Destroy();
            Factories.FrostProjectileFactory.Destroy();
            Factories.PiercingProjectileFactory.Destroy();
            FlatRedBall.SpriteManager.RemoveDrawableBatch(GameScreenGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= GameScreenGum.HandleResolutionChanged;
            GameScreenGum = null;
            darknessshader = null;
            CombinedAssets = null;
            if (mChapter1 != null)
            {
                mChapter1.Destroy();
                mChapter1 = null;
            }
            if (mChapter2 != null)
            {
                mChapter2.Destroy();
                mChapter2 = null;
            }
            CollisionShapes = null;
            IncomingMessage = null;
            if (mChapter3 != null)
            {
                mChapter3.Destroy();
                mChapter3 = null;
            }
            if (mChapter4 != null)
            {
                mChapter4.Destroy();
                mChapter4 = null;
            }
            if (mChapter5 != null)
            {
                mChapter5.Destroy();
                mChapter5 = null;
            }
            if (mChapter6 != null)
            {
                mChapter6.Destroy();
                mChapter6 = null;
            }
            if (mChapter7 != null)
            {
                mChapter7.Destroy();
                mChapter7 = null;
            }
            if (mChapter8 != null)
            {
                mChapter8.Destroy();
                mChapter8 = null;
            }
            if (mChapter9 != null)
            {
                mChapter9.Destroy();
                mChapter9 = null;
            }
            if (mChapter10 != null)
            {
                mChapter10.Destroy();
                mChapter10 = null;
            }
            OutgoingMessage = null;
            
            AllStructuresList.MakeOneWay();
            AllEnemiesList.MakeOneWay();
            PlayerProjectileList.MakeOneWay();
            StructurePlacementList.MakeOneWay();
            TileCollisionRectangleList.MakeOneWay();
            TileCollisionCircleList.MakeOneWay();
            TiledOverlayList.MakeOneWay();
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
            for (int i = TileCollisionRectangleList.Count - 1; i > -1; i--)
            {
                TileCollisionRectangleList[i].Destroy();
            }
            for (int i = TileCollisionCircleList.Count - 1; i > -1; i--)
            {
                TileCollisionCircleList[i].Destroy();
            }
            if (ChatHistoryInstance != null)
            {
                ChatHistoryInstance.RemoveFromManagers();
            }
            if (GameScreenGumInstance != null)
            {
                GameScreenGumInstance.RemoveFromManagers();
            }
            if (TopStatusBarInstance != null)
            {
                TopStatusBarInstance.RemoveFromManagers();
            }
            if (ScreenShadeInstance != null)
            {
                ScreenShadeInstance.RemoveFromManagers();
            }
            if (MenuWindowInstance != null)
            {
                MenuWindowInstance.RemoveFromManagers();
            }
            for (int i = TiledOverlayList.Count - 1; i > -1; i--)
            {
                TiledOverlayList[i].Destroy();
            }
            if (LocationTimeInstance != null)
            {
                LocationTimeInstance.RemoveFromManagers();
            }
            if (ConfirmationWindowInstance != null)
            {
                ConfirmationWindowInstance.RemoveFromManagers();
            }
            if (CurrentMusicDisplayInstance != null)
            {
                CurrentMusicDisplayInstance.RemoveFromManagers();
            }
            AllStructuresList.MakeTwoWay();
            AllEnemiesList.MakeTwoWay();
            PlayerProjectileList.MakeTwoWay();
            StructurePlacementList.MakeTwoWay();
            TileCollisionRectangleList.MakeTwoWay();
            TileCollisionCircleList.MakeTwoWay();
            TiledOverlayList.MakeTwoWay();
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
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
            EnemyInfoInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            StructureInfoInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            ChatBoxInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            BuildMenuInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            LivesPointsDisplayInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            ChatHistoryInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            TopStatusBarInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            ScreenShadeInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            MenuWindowInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            LocationTimeInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            ConfirmationWindowInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            CurrentMusicDisplayInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
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
            for (int i = TileCollisionRectangleList.Count - 1; i > -1; i--)
            {
                TileCollisionRectangleList[i].Destroy();
            }
            for (int i = TileCollisionCircleList.Count - 1; i > -1; i--)
            {
                TileCollisionCircleList[i].Destroy();
            }
            if (ChatHistoryInstance != null)
            {
                ChatHistoryInstance.RemoveFromManagers();
            }
            if (GameScreenGumInstance != null)
            {
                GameScreenGumInstance.RemoveFromManagers();
            }
            if (TopStatusBarInstance != null)
            {
                TopStatusBarInstance.RemoveFromManagers();
            }
            if (ScreenShadeInstance != null)
            {
                ScreenShadeInstance.RemoveFromManagers();
            }
            if (MenuWindowInstance != null)
            {
                MenuWindowInstance.RemoveFromManagers();
            }
            for (int i = TiledOverlayList.Count - 1; i > -1; i--)
            {
                TiledOverlayList[i].Destroy();
            }
            if (LocationTimeInstance != null)
            {
                LocationTimeInstance.RemoveFromManagers();
            }
            if (ConfirmationWindowInstance != null)
            {
                ConfirmationWindowInstance.RemoveFromManagers();
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
            for (int i = 0; i < TileCollisionRectangleList.Count; i++)
            {
                TileCollisionRectangleList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < TileCollisionCircleList.Count; i++)
            {
                TileCollisionCircleList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < TiledOverlayList.Count; i++)
            {
                TiledOverlayList[i].ConvertToManuallyUpdated();
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
            CollisionShapes = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/tilesets/collisionshapes.png", contentManagerName);
            IncomingMessage = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/incomingmessage", contentManagerName);
            OutgoingMessage = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/outgoingmessage", contentManagerName);
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
                case  "Chapter2":
                    return Chapter2;
                case  "CollisionShapes":
                    return CollisionShapes;
                case  "IncomingMessage":
                    return IncomingMessage;
                case  "Chapter3":
                    return Chapter3;
                case  "Chapter4":
                    return Chapter4;
                case  "Chapter5":
                    return Chapter5;
                case  "Chapter6":
                    return Chapter6;
                case  "Chapter7":
                    return Chapter7;
                case  "Chapter8":
                    return Chapter8;
                case  "Chapter9":
                    return Chapter9;
                case  "Chapter10":
                    return Chapter10;
                case  "OutgoingMessage":
                    return OutgoingMessage;
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
                case  "Chapter2":
                    return Chapter2;
                case  "CollisionShapes":
                    return CollisionShapes;
                case  "IncomingMessage":
                    return IncomingMessage;
                case  "Chapter3":
                    return Chapter3;
                case  "Chapter4":
                    return Chapter4;
                case  "Chapter5":
                    return Chapter5;
                case  "Chapter6":
                    return Chapter6;
                case  "Chapter7":
                    return Chapter7;
                case  "Chapter8":
                    return Chapter8;
                case  "Chapter9":
                    return Chapter9;
                case  "Chapter10":
                    return Chapter10;
                case  "OutgoingMessage":
                    return OutgoingMessage;
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
                case  "Chapter2":
                    return Chapter2;
                case  "CollisionShapes":
                    return CollisionShapes;
                case  "IncomingMessage":
                    return IncomingMessage;
                case  "Chapter3":
                    return Chapter3;
                case  "Chapter4":
                    return Chapter4;
                case  "Chapter5":
                    return Chapter5;
                case  "Chapter6":
                    return Chapter6;
                case  "Chapter7":
                    return Chapter7;
                case  "Chapter8":
                    return Chapter8;
                case  "Chapter9":
                    return Chapter9;
                case  "Chapter10":
                    return Chapter10;
                case  "OutgoingMessage":
                    return OutgoingMessage;
            }
            return null;
        }
    }
}
