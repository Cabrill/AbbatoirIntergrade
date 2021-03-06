#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using AbbatoirIntergrade.Entities.GraphicalElements;
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
        protected static Microsoft.Xna.Framework.Audio.SoundEffect HordeAlert;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream1;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream2;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream3;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream4;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream5;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream6;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream7;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream8;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream9;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream10;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream11;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream12;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream13;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream14;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Scream15;
        static Microsoft.Xna.Framework.Audio.SoundEffect mScreamLoop;
        static string mLastContentManagerForScreamLoop;
        public static Microsoft.Xna.Framework.Audio.SoundEffect ScreamLoop
        {
            get
            {
                if (mScreamLoop == null || mLastContentManagerForScreamLoop != "GameScreen")
                {
                    mLastContentManagerForScreamLoop = "GameScreen";
                    mScreamLoop = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/screamloop", "GameScreen");
                }
                return mScreamLoop;
            }
        }
        protected static Microsoft.Xna.Framework.Audio.SoundEffect UpgradeStructure;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect BuildStructure;
        
        private Microsoft.Xna.Framework.Graphics.RenderTarget2D WorldRenderTarget;
        private Microsoft.Xna.Framework.Graphics.RenderTarget2D DarknessRenderTarget;
        private AbbatoirIntergrade.Entities.ShaderRenderer ShaderRendererInstance;
        private FlatRedBall.Graphics.Layer BackgroundLayer;
        private AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime HorizonBoxInstance;
        private FlatRedBall.Graphics.Layer WorldLayer;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseStructure> mAllStructuresList;
        public FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseStructure> AllStructuresList
        {
            get
            {
                return mAllStructuresList;
            }
            private set
            {
                mAllStructuresList = value;
            }
        }
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy> mAllEnemiesList;
        public FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy> AllEnemiesList
        {
            get
            {
                return mAllEnemiesList;
            }
            private set
            {
                mAllEnemiesList = value;
            }
        }
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BasePlayerProjectile> PlayerProjectileList;
        private FlatRedBall.Graphics.Layer LightLayer;
        private FlatRedBall.Graphics.Layer ShaderOutputLayer;
        private FlatRedBall.Graphics.Layer InfoLayer;
        private FlatRedBall.Graphics.Layer HUDLayer;
        private Microsoft.Xna.Framework.Graphics.RenderTarget2D BackgroundRenderTarget;
        private AbbatoirIntergrade.GumRuntimes.infodisplays.EnemyInfoRuntime mEnemyInfoInstance;
        public AbbatoirIntergrade.GumRuntimes.infodisplays.EnemyInfoRuntime EnemyInfoInstance
        {
            get
            {
                return mEnemyInfoInstance;
            }
            private set
            {
                mEnemyInfoInstance = value;
            }
        }
        private AbbatoirIntergrade.Entities.GraphicalElements.StructurePlacement StructurePlacementInstance;
        private AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime mStructureInfoInstance;
        public AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime StructureInfoInstance
        {
            get
            {
                return mStructureInfoInstance;
            }
            private set
            {
                mStructureInfoInstance = value;
            }
        }
        private AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime mChatBoxInstance;
        public AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime ChatBoxInstance
        {
            get
            {
                return mChatBoxInstance;
            }
            private set
            {
                mChatBoxInstance = value;
            }
        }
        private AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime mBuildMenuInstance;
        public AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime BuildMenuInstance
        {
            get
            {
                return mBuildMenuInstance;
            }
            private set
            {
                mBuildMenuInstance = value;
            }
        }
        private AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime mLivesPointsDisplayInstance;
        public AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime LivesPointsDisplayInstance
        {
            get
            {
                return mLivesPointsDisplayInstance;
            }
            private set
            {
                mLivesPointsDisplayInstance = value;
            }
        }
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TileCollisionRectangle> TileCollisionRectangleList;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TileCollisionCircle> TileCollisionCircleList;
        private AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime ChatHistoryInstance;
        private AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime GameScreenGumInstance;
        private AbbatoirIntergrade.GumRuntimes.InfoDisplays.TopStatusBarRuntime mTopStatusBarInstance;
        public AbbatoirIntergrade.GumRuntimes.InfoDisplays.TopStatusBarRuntime TopStatusBarInstance
        {
            get
            {
                return mTopStatusBarInstance;
            }
            private set
            {
                mTopStatusBarInstance = value;
            }
        }
        private AbbatoirIntergrade.GumRuntimes.ScreenShadeRuntime ScreenShadeInstance;
        private AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime MenuWindowInstance;
        private FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TiledOverlay> TiledOverlayList;
        private AbbatoirIntergrade.GumRuntimes.infodisplays.LocationTimeAnnouncementRuntime LocationTimeInstance;
        private AbbatoirIntergrade.GumRuntimes.ConfirmationWindowRuntime ConfirmationWindowInstance;
        private AbbatoirIntergrade.GumRuntimes.infodisplays.CurrentMusicDisplayRuntime CurrentMusicDisplayInstance;
        private AbbatoirIntergrade.GumRuntimes.TextRuntime HordeText;
        private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime DimmingRectangleInstance;
        private AbbatoirIntergrade.GumRuntimes.specificbuttons.ReadyButtonRuntime mReadyButtonInstance;
        public AbbatoirIntergrade.GumRuntimes.specificbuttons.ReadyButtonRuntime ReadyButtonInstance
        {
            get
            {
                return mReadyButtonInstance;
            }
            private set
            {
                mReadyButtonInstance = value;
            }
        }
        private AbbatoirIntergrade.GumRuntimes.unique.PointingArrowRuntime mPointingArrowInstance;
        public AbbatoirIntergrade.GumRuntimes.unique.PointingArrowRuntime PointingArrowInstance
        {
            get
            {
                return mPointingArrowInstance;
            }
            private set
            {
                mPointingArrowInstance = value;
            }
        }
        private AbbatoirIntergrade.GumRuntimes.infodisplays.TutorialTextRuntime mTutorialTextInstance;
        public AbbatoirIntergrade.GumRuntimes.infodisplays.TutorialTextRuntime TutorialTextInstance
        {
            get
            {
                return mTutorialTextInstance;
            }
            private set
            {
                mTutorialTextInstance = value;
            }
        }
        public event System.EventHandler BeforeCurrentSatoshisSet;
        public event System.EventHandler AfterCurrentSatoshisSet;
        int mCurrentSatoshis;
        public int CurrentSatoshis
        {
            set
            {
                if (BeforeCurrentSatoshisSet != null)
                {
                    BeforeCurrentSatoshisSet(this, null);
                }
                mCurrentSatoshis = value;
                if (AfterCurrentSatoshisSet != null)
                {
                    AfterCurrentSatoshisSet(this, null);
                }
            }
            get
            {
                return mCurrentSatoshis;
            }
        }
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
            mAllStructuresList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseStructure>();
            mAllStructuresList.Name = "mAllStructuresList";
            mAllEnemiesList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.BaseEntities.BaseEnemy>();
            mAllEnemiesList.Name = "mAllEnemiesList";
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
            mEnemyInfoInstance = GameScreenGum.GetGraphicalUiElementByName("EnemyInfoInstance") as AbbatoirIntergrade.GumRuntimes.infodisplays.EnemyInfoRuntime;
            StructurePlacementInstance = new AbbatoirIntergrade.Entities.GraphicalElements.StructurePlacement(ContentManagerName, false);
            StructurePlacementInstance.Name = "StructurePlacementInstance";
            mStructureInfoInstance = GameScreenGum.GetGraphicalUiElementByName("StructureInfoInstance") as AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime;
            mChatBoxInstance = GameScreenGum.GetGraphicalUiElementByName("ChatBoxInstance") as AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime;
            mBuildMenuInstance = GameScreenGum.GetGraphicalUiElementByName("BuildMenuInstance") as AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime;
            mLivesPointsDisplayInstance = GameScreenGum.GetGraphicalUiElementByName("LivesPointsDisplayInstance") as AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime;
            TileCollisionRectangleList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TileCollisionRectangle>();
            TileCollisionRectangleList.Name = "TileCollisionRectangleList";
            TileCollisionCircleList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TileCollisionCircle>();
            TileCollisionCircleList.Name = "TileCollisionCircleList";
            ChatHistoryInstance = GameScreenGum.GetGraphicalUiElementByName("ChatHistoryInstance") as AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime;
            GameScreenGumInstance = GameScreenGum.GetGraphicalUiElementByName("this") as AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime;
            mTopStatusBarInstance = GameScreenGum.GetGraphicalUiElementByName("TopStatusBarInstance") as AbbatoirIntergrade.GumRuntimes.InfoDisplays.TopStatusBarRuntime;
            ScreenShadeInstance = GameScreenGum.GetGraphicalUiElementByName("ScreenShadeInstance") as AbbatoirIntergrade.GumRuntimes.ScreenShadeRuntime;
            MenuWindowInstance = GameScreenGum.GetGraphicalUiElementByName("MenuWindowInstance") as AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime;
            TiledOverlayList = new FlatRedBall.Math.PositionedObjectList<AbbatoirIntergrade.Entities.GraphicalElements.TiledOverlay>();
            TiledOverlayList.Name = "TiledOverlayList";
            LocationTimeInstance = GameScreenGum.GetGraphicalUiElementByName("LocationTimeAnnouncementInstance") as AbbatoirIntergrade.GumRuntimes.infodisplays.LocationTimeAnnouncementRuntime;
            ConfirmationWindowInstance = GameScreenGum.GetGraphicalUiElementByName("ConfirmationWindowInstance") as AbbatoirIntergrade.GumRuntimes.ConfirmationWindowRuntime;
            CurrentMusicDisplayInstance = GameScreenGum.GetGraphicalUiElementByName("CurrentMusicDisplayInstance") as AbbatoirIntergrade.GumRuntimes.infodisplays.CurrentMusicDisplayRuntime;
            HordeText = GameScreenGum.GetGraphicalUiElementByName("HordeText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
            DimmingRectangleInstance = GameScreenGum.GetGraphicalUiElementByName("DimmingRectangle") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
            mReadyButtonInstance = GameScreenGum.GetGraphicalUiElementByName("ReadyButtonInstance") as AbbatoirIntergrade.GumRuntimes.specificbuttons.ReadyButtonRuntime;
            mPointingArrowInstance = GameScreenGum.GetGraphicalUiElementByName("PointingArrowInstance") as AbbatoirIntergrade.GumRuntimes.unique.PointingArrowRuntime;
            mTutorialTextInstance = GameScreenGum.GetGraphicalUiElementByName("TutorialTextInstance") as AbbatoirIntergrade.GumRuntimes.infodisplays.TutorialTextRuntime;
            
            
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
            Factories.TileCollisionRectangleFactory.Initialize(ContentManagerName);
            Factories.TileCollisionCircleFactory.Initialize(ContentManagerName);
            Factories.TiledOverlayFactory.Initialize(ContentManagerName);
            Factories.BombardingTowerFactory.AddList(mAllStructuresList);
            Factories.ChemicalTowerFactory.AddList(mAllStructuresList);
            Factories.ElectricTowerFactory.AddList(mAllStructuresList);
            Factories.FireTowerFactory.AddList(mAllStructuresList);
            Factories.FrostTowerFactory.AddList(mAllStructuresList);
            Factories.PiercingTowerFactory.AddList(mAllStructuresList);
            Factories.Chicken1EnemyFactory.AddList(mAllEnemiesList);
            Factories.Chicken2EnemyFactory.AddList(mAllEnemiesList);
            Factories.Chicken3EnemyFactory.AddList(mAllEnemiesList);
            Factories.Cow1EnemyFactory.AddList(mAllEnemiesList);
            Factories.Cow2EnemyFactory.AddList(mAllEnemiesList);
            Factories.Cow3EnemyFactory.AddList(mAllEnemiesList);
            Factories.Pig1EnemyFactory.AddList(mAllEnemiesList);
            Factories.Pig2EnemyFactory.AddList(mAllEnemiesList);
            Factories.Pig3EnemyFactory.AddList(mAllEnemiesList);
            Factories.Rabbit1EnemyFactory.AddList(mAllEnemiesList);
            Factories.Rabbit2EnemyFactory.AddList(mAllEnemiesList);
            Factories.Rabbit3EnemyFactory.AddList(mAllEnemiesList);
            Factories.Sheep1EnemyFactory.AddList(mAllEnemiesList);
            Factories.Sheep2EnemyFactory.AddList(mAllEnemiesList);
            Factories.Sheep3EnemyFactory.AddList(mAllEnemiesList);
            Factories.CannonProjectileFactory.AddList(PlayerProjectileList);
            Factories.ChemicalProjectileFactory.AddList(PlayerProjectileList);
            Factories.ElectricProjectileFactory.AddList(PlayerProjectileList);
            Factories.FireProjectileFactory.AddList(PlayerProjectileList);
            Factories.FrostProjectileFactory.AddList(PlayerProjectileList);
            Factories.PiercingProjectileFactory.AddList(PlayerProjectileList);
            Factories.TileCollisionRectangleFactory.AddList(TileCollisionRectangleList);
            Factories.TileCollisionCircleFactory.AddList(TileCollisionCircleList);
            Factories.TiledOverlayFactory.AddList(TiledOverlayList);
            
            
            ShaderRendererInstance.AddToManagers(ShaderOutputLayer);
            HorizonBoxInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(BackgroundLayer)));

            
            mEnemyInfoInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            StructurePlacementInstance.AddToManagers(HUDLayer);
            StructurePlacementInstance.SetToIgnorePausing();
            mStructureInfoInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            mChatBoxInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            mBuildMenuInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            mLivesPointsDisplayInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            ChatHistoryInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            mTopStatusBarInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            ScreenShadeInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            MenuWindowInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            LocationTimeInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            ConfirmationWindowInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            CurrentMusicDisplayInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            HordeText.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            DimmingRectangleInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(InfoLayer)));

            mReadyButtonInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            mPointingArrowInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

            mTutorialTextInstance.AddToManagers(RenderingLibrary.SystemManagers.Default, System.Linq.Enumerable.FirstOrDefault(FlatRedBall.Gum.GumIdb.AllGumLayersOnFrbLayer(HUDLayer)));

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
                StructurePlacementInstance.Activity();
            }
            else
            {
                StructurePlacementInstance.Activity();
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
            HordeAlert = null;
            Scream1 = null;
            Scream2 = null;
            Scream3 = null;
            Scream4 = null;
            Scream5 = null;
            Scream6 = null;
            Scream7 = null;
            Scream8 = null;
            Scream9 = null;
            Scream10 = null;
            Scream11 = null;
            Scream12 = null;
            Scream13 = null;
            Scream14 = null;
            Scream15 = null;
            if (mScreamLoop != null)
            {
                mScreamLoop = null;
            }
            UpgradeStructure = null;
            BuildStructure = null;
            
            AllStructuresList.MakeOneWay();
            AllEnemiesList.MakeOneWay();
            PlayerProjectileList.MakeOneWay();
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
            if (StructurePlacementInstance != null)
            {
                StructurePlacementInstance.Destroy();
                StructurePlacementInstance.Detach();
            }
            if (StructureInfoInstance != null)
            {
                StructureInfoInstance.RemoveFromManagers();
            }
            if (ChatBoxInstance != null)
            {
                ChatBoxInstance.RemoveFromManagers();
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
            if (HordeText != null)
            {
                HordeText.RemoveFromManagers();
            }
            if (DimmingRectangleInstance != null)
            {
                DimmingRectangleInstance.RemoveFromManagers();
            }
            if (ReadyButtonInstance != null)
            {
                ReadyButtonInstance.RemoveFromManagers();
            }
            if (PointingArrowInstance != null)
            {
                PointingArrowInstance.RemoveFromManagers();
            }
            if (TutorialTextInstance != null)
            {
                TutorialTextInstance.RemoveFromManagers();
            }
            AllStructuresList.MakeTwoWay();
            AllEnemiesList.MakeTwoWay();
            PlayerProjectileList.MakeTwoWay();
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
            this.AfterCurrentSatoshisSet += OnAfterCurrentSatoshisSet;
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
            mEnemyInfoInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            mStructureInfoInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            mChatBoxInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            mBuildMenuInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            mLivesPointsDisplayInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            ChatHistoryInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            mTopStatusBarInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            ScreenShadeInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            MenuWindowInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            LocationTimeInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            ConfirmationWindowInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            CurrentMusicDisplayInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            HordeText.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            DimmingRectangleInstance.MoveToFrbLayer(InfoLayer, InfoLayerGum);
            mReadyButtonInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            mPointingArrowInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
            mTutorialTextInstance.MoveToFrbLayer(HUDLayer, HUDLayerGum);
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
            StructurePlacementInstance.RemoveFromManagers();
            if (StructureInfoInstance != null)
            {
                StructureInfoInstance.RemoveFromManagers();
            }
            if (ChatBoxInstance != null)
            {
                ChatBoxInstance.RemoveFromManagers();
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
            if (HordeText != null)
            {
                HordeText.RemoveFromManagers();
            }
            if (DimmingRectangleInstance != null)
            {
                DimmingRectangleInstance.RemoveFromManagers();
            }
            if (ReadyButtonInstance != null)
            {
                ReadyButtonInstance.RemoveFromManagers();
            }
            if (PointingArrowInstance != null)
            {
                PointingArrowInstance.RemoveFromManagers();
            }
            if (TutorialTextInstance != null)
            {
                TutorialTextInstance.RemoveFromManagers();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                ShaderRendererInstance.AssignCustomVariables(true);
                StructurePlacementInstance.AssignCustomVariables(true);
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
            StructurePlacementInstance.ConvertToManuallyUpdated();
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
            HordeAlert = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/hordealert", contentManagerName);
            Scream1 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream1", contentManagerName);
            Scream2 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream2", contentManagerName);
            Scream3 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream3", contentManagerName);
            Scream4 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream4", contentManagerName);
            Scream5 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream5", contentManagerName);
            Scream6 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream6", contentManagerName);
            Scream7 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream7", contentManagerName);
            Scream8 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream8", contentManagerName);
            Scream9 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream9", contentManagerName);
            Scream10 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream10", contentManagerName);
            Scream11 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream11", contentManagerName);
            Scream12 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream12", contentManagerName);
            Scream13 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream13", contentManagerName);
            Scream14 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream14", contentManagerName);
            Scream15 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/screams/scream15", contentManagerName);
            UpgradeStructure = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/upgradestructure", contentManagerName);
            BuildStructure = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/sounds/buildstructure", contentManagerName);
            AbbatoirIntergrade.Entities.ShaderRenderer.LoadStaticContent(contentManagerName);
            AbbatoirIntergrade.Entities.GraphicalElements.StructurePlacement.LoadStaticContent(contentManagerName);
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
                case  "HordeAlert":
                    return HordeAlert;
                case  "Scream1":
                    return Scream1;
                case  "Scream2":
                    return Scream2;
                case  "Scream3":
                    return Scream3;
                case  "Scream4":
                    return Scream4;
                case  "Scream5":
                    return Scream5;
                case  "Scream6":
                    return Scream6;
                case  "Scream7":
                    return Scream7;
                case  "Scream8":
                    return Scream8;
                case  "Scream9":
                    return Scream9;
                case  "Scream10":
                    return Scream10;
                case  "Scream11":
                    return Scream11;
                case  "Scream12":
                    return Scream12;
                case  "Scream13":
                    return Scream13;
                case  "Scream14":
                    return Scream14;
                case  "Scream15":
                    return Scream15;
                case  "ScreamLoop":
                    return ScreamLoop;
                case  "UpgradeStructure":
                    return UpgradeStructure;
                case  "BuildStructure":
                    return BuildStructure;
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
                case  "HordeAlert":
                    return HordeAlert;
                case  "Scream1":
                    return Scream1;
                case  "Scream2":
                    return Scream2;
                case  "Scream3":
                    return Scream3;
                case  "Scream4":
                    return Scream4;
                case  "Scream5":
                    return Scream5;
                case  "Scream6":
                    return Scream6;
                case  "Scream7":
                    return Scream7;
                case  "Scream8":
                    return Scream8;
                case  "Scream9":
                    return Scream9;
                case  "Scream10":
                    return Scream10;
                case  "Scream11":
                    return Scream11;
                case  "Scream12":
                    return Scream12;
                case  "Scream13":
                    return Scream13;
                case  "Scream14":
                    return Scream14;
                case  "Scream15":
                    return Scream15;
                case  "ScreamLoop":
                    return ScreamLoop;
                case  "UpgradeStructure":
                    return UpgradeStructure;
                case  "BuildStructure":
                    return BuildStructure;
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
                case  "HordeAlert":
                    return HordeAlert;
                case  "Scream1":
                    return Scream1;
                case  "Scream2":
                    return Scream2;
                case  "Scream3":
                    return Scream3;
                case  "Scream4":
                    return Scream4;
                case  "Scream5":
                    return Scream5;
                case  "Scream6":
                    return Scream6;
                case  "Scream7":
                    return Scream7;
                case  "Scream8":
                    return Scream8;
                case  "Scream9":
                    return Scream9;
                case  "Scream10":
                    return Scream10;
                case  "Scream11":
                    return Scream11;
                case  "Scream12":
                    return Scream12;
                case  "Scream13":
                    return Scream13;
                case  "Scream14":
                    return Scream14;
                case  "Scream15":
                    return Scream15;
                case  "ScreamLoop":
                    return ScreamLoop;
                case  "UpgradeStructure":
                    return UpgradeStructure;
                case  "BuildStructure":
                    return BuildStructure;
            }
            return null;
        }
    }
}
