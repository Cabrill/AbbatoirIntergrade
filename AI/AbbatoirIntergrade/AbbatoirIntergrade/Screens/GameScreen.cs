using System;
using System.Collections.Generic;
using System.Linq;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Gui;
using FlatRedBall.Math.Geometry;
using AbbatoirIntergrade.Entities;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Enemies;
using AbbatoirIntergrade.Entities.GraphicalElements;
using AbbatoirIntergrade.Entities.Projectiles;
using AbbatoirIntergrade.Entities.Structures;
using AbbatoirIntergrade.GameClasses;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GameClasses.Levels;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Camera = FlatRedBall.Camera;
using ShapeManager = FlatRedBall.Math.Geometry.ShapeManager;
using AbbatoirIntergrade.GumRuntimes.infodisplays;
using static AbbatoirIntergrade.StaticManagers.GameStateManager;

namespace AbbatoirIntergrade.Screens
{
    public partial class GameScreen
    {
        //OPEN A URL
        //private void OpenUrl(string url)
        //{
        //System.Diagnostics.Process.Start(url);
        //}

        #region Properties and Fields
        public enum PlayerActionMode
        {
            Normal,
            Building,
            Ending
        };
        public PlayerActionMode CurrentPlayerActionMode = PlayerActionMode.Normal;

        private TutorialScript _tutorialScript;

        public bool IsCurrentlyPaused => IsPaused;

        private double PauseAndBuildAjustedTime;
        private bool GameHasStarted;

        private BaseLevel CurrentLevel;
        private FlatRedBall.TileGraphics.LayeredTileMap currentMap;
        private DateTime currentLevelDateTime;

        private TileNodeNetwork PathingNodeNetwork;
        private Polygon Pathing;
        private Segment[] PathingSegments;
        private List<Polygon> WaterShapes;

        private PositionedObject selectedObject;

        private List<ResourceIncreaseNotificationRuntime> resourceIncreaseNotificationList;

        private SoundEffectInstance IncomingMessageSound;
        private SoundEffectInstance OutgoingMessageSound;
        private SoundEffectInstance HordeAlertSound;
        private SoundEffectInstance ScreamSoundLoop;
        private SoundEffectInstance StructureBuildSound;
        private SoundEffectInstance StructureUpgradeSound;

        private List<SoundEffectInstance> ScreamSounds;
        private int _LastScreamIndex;

        private int _CheapestTowerCost = int.MaxValue;

        #endregion

        #region Initialization

        void CustomInitialize()
        {
            LocalLogManager.AddLine("Game Screen - Initialize");
#if WINDOWS || DESKTOP_GL
            FlatRedBallServices.IsWindowsCursorVisible = true;
#endif
            FlatRedBallServices.GraphicsOptions.TextureFilter = TextureFilter.Point;

            LocalLogManager.AddLine("Game Screen - Load GameState Data");
            GameStateManager.LoadIfNecessary();
            LocalLogManager.AddLine("Game Screen - Load Player Data");
            PlayerDataManager.LoadData();

            resourceIncreaseNotificationList = new List<ResourceIncreaseNotificationRuntime>();
            LocalLogManager.AddLine("Game Screen - Load sounds");
            IncomingMessageSound = IncomingMessage.CreateInstance();
            OutgoingMessageSound = OutgoingMessage.CreateInstance();
            HordeAlertSound = HordeAlert.CreateInstance();
            StructureBuildSound = BuildStructure.CreateInstance();
            StructureUpgradeSound = UpgradeStructure.CreateInstance();
            ScreamSounds = new List<SoundEffectInstance>()
            {
                Scream1.CreateInstance(),
                Scream2.CreateInstance(),
                Scream3.CreateInstance(),
                Scream4.CreateInstance(),
                Scream5.CreateInstance(),
                Scream6.CreateInstance(),
                Scream7.CreateInstance(),
                Scream8.CreateInstance(),
                Scream9.CreateInstance(),
                Scream10.CreateInstance(),
                Scream11.CreateInstance(),
                Scream12.CreateInstance(),
                Scream13.CreateInstance(),
                Scream14.CreateInstance(),
                Scream15.CreateInstance(),
            };
            ScreamSounds.Shuffle();

            LocalLogManager.AddLine("Game Screen - Load Level");
            CurrentLevel = GameStateManager.CurrentLevel ?? new Chapter10Level();
            CurrentLevel.Reset();
            CurrentLevel.OnNewWaveStart += HandleWaveStarted;
            CurrentLevel.OnWaveEnd += HandleWaveEnded;
            CurrentLevel.SetEnemiesAndLayer(AllEnemiesList);
            CurrentSatoshis = CurrentLevel.StartingSatoshis;

            if (CurrentLevel.LevelNumber == 10)
            {
                ScreamSoundLoop = ScreamLoop.CreateInstance();
                SoundManager.PlaySoundEffect(ScreamSoundLoop, shouldLoop:true);
            }

            currentLevelDateTime = PlayerDataManager.CurrentGameDateTime == DateTime.MinValue ? CurrentLevel.StartTime : PlayerDataManager.CurrentGameDateTime;

            LocalLogManager.AddLine("Game Screen - Initialize factories");
            InitializeFactories();

            LocalLogManager.AddLine("Game Screen - Load Tile Map");
            LoadTiledMap();

            LocalLogManager.AddLine("Game Screen - Initialize base entities");
            InitializeBaseEntities();

            LocalLogManager.AddLine("Game Screen - Assign gum events");
            AssignGumButtonEvents();

            LocalLogManager.AddLine("Game Screen - Camera and shaders");
            CameraZoomManager.Initialize();
            AdjustLayerOrthoValues();
            InitializeShaders();

            HorizonBoxInstance.Initialize(currentLevelDateTime);

            LocalLogManager.AddLine("Game Screen - Initialize managers");
            InitializeManagers();

            LocalLogManager.AddLine("Game Screen - Set skybox");
            HorizonBoxInstance.Update(currentLevelDateTime);
            SunlightManager.UpdateConditions(currentLevelDateTime);

            //StartButtonInstance.Click += OnStartButtonInstanceClick;
            //GameHasStarted = false;
            
            CreateNotificationPool();
            ChangeGameModeToBuilding();
            GameHasStarted = true;
            PauseAndBuildAjustedTime = 0;

            LocalLogManager.AddLine("Game Screen - Start music");
            SoundManager.PlaySongList(CurrentLevel.SongNameList);

            LocalLogManager.AddLine("Game Screen - Update gametime");
            UpdateGameTime();

            StructurePlacementInstance.OnClick = OnStructurePlacementClick;

            GameScreenGumInstance.CurrentFadingState = GameScreenGumRuntime.Fading.Faded;
            LocalLogManager.AddLine("Game Screen - Display local time");
            LocationTimeInstance.Display(CurrentLevel.LocationName, currentLevelDateTime);

            if (CurrentLevel.LevelNumber == 1 && !PlayerDataManager.PlayerHasBeatGame)
            {
                _tutorialScript = new TutorialScript(this);
                _tutorialScript.Initialize();
                TutorialTextInstance.OnSkipTutorialClicked = () => _tutorialScript.Skip();
            }

            UpdateInfoBar();
            LivesPointsDisplayInstance.LivesRemaining = CurrentLevel.RemainingLives.ToString();

            this.Call(() =>CurrentMusicDisplayInstance.TimedDisplay(true)).After(5f);
        }


#if DEBUG
        private string DebugText = "\n\nNo Data Yet";
#endif

        private void HandleWaveStarted(object sender, EventArgs e)
        {
            LocalLogManager.AddLine("Game Screen - Start Wave");
            UpdateInfoBar();
            UpdateDialogue();
            MachineLearningManager.NotifyOfWaveStart(sender, e);
        }

        private void HandleWaveEnded(object sender, EventArgs e)
        {
            LocalLogManager.AddLine("Game Screen - Wave ended");

            var shouldLearnFromWave = AllStructuresList.Count <= MachineLearningManager.MaxTowers &&
                                      CurrentLevel.LastWave.EnemyCounts.TotalEnemies <= MachineLearningManager.MaxEnemies &&
                                      CurrentLevel.LastWave.EnemyCounts.TotalEnemies > 0;

            MachineLearningManager.NotifyOfWaveEnd(shouldLearnFromWave);

            if (CurrentLevel.HasReachedVictory())
            {
                LevelVictory();
            }
            else
            {
                ChangeGameModeToBuilding();
            }
        }

        private void InitializeShaders()
        {
            WorldLayer.RenderTarget = WorldRenderTarget;
            LightLayer.RenderTarget = DarknessRenderTarget;
            BackgroundLayer.RenderTarget = BackgroundRenderTarget;

            ShaderRendererInstance.WorldTexture = WorldRenderTarget;
            ShaderRendererInstance.DarknessTexture = DarknessRenderTarget;
            ShaderRendererInstance.BackgroundTexture = BackgroundRenderTarget;
            //ShaderRendererInstance.Effect = darknessshader;
            ShaderRendererInstance.Viewer = Camera.Main;

            ShaderRendererInstance.InitializeRenderVariables();
        }

        private void AdjustLayerOrthoValues()
        {
            WorldLayer.LayerCameraSettings.OrthogonalWidth = Camera.Main.OrthogonalWidth;
            WorldLayer.LayerCameraSettings.OrthogonalHeight = Camera.Main.OrthogonalHeight;

            LightLayer.LayerCameraSettings.OrthogonalWidth = Camera.Main.OrthogonalWidth;
            LightLayer.LayerCameraSettings.OrthogonalHeight = Camera.Main.OrthogonalHeight;

            ShaderOutputLayer.LayerCameraSettings.OrthogonalWidth = Camera.Main.OrthogonalWidth;
            ShaderOutputLayer.LayerCameraSettings.OrthogonalHeight = Camera.Main.OrthogonalHeight;

            InfoLayer.LayerCameraSettings.OrthogonalWidth = Camera.Main.OrthogonalWidth;
            InfoLayer.LayerCameraSettings.OrthogonalHeight = Camera.Main.OrthogonalHeight;
        }

        private void InitializeManagers()
        {
            SunlightManager.Initialize(HorizonBoxInstance, currentLevelDateTime);
            MachineLearningManager.SetTowerList(AllStructuresList);
        }

        private void InitializeBaseEntities()
        {
            BaseStructure.Initialize(AllEnemiesList);
            BaseEnemy.Initialize(Pathing, PathingNodeNetwork);
            EnemyFactories.OnCreateAction = CreateResourceNotification;
        }

        private void LoadTiledMap()
        {
            currentMap = GetFile(CurrentLevel.MapName) as FlatRedBall.TileGraphics.LayeredTileMap;
            LocalLogManager.AddLine("Game Screen - Instantiate tiles");
            FlatRedBall.TileEntities.TileEntityInstantiator.CreateEntitiesFrom(currentMap);

            LocalLogManager.AddLine("Game Screen - Set tiled overlays");
            foreach (var overlay in TiledOverlayList)
            {
                overlay.MoveToLayer(WorldLayer);
                overlay.AttachTo(currentMap, true);
                overlay.RelativeZ = 3;
            }

            LocalLogManager.AddLine("Game Screen - Set circle collisions");
            foreach (var circle in TileCollisionCircleList)
            {
                if (circle.CircleInstanceRadius > 64)
                {
                    circle.X += circle.CircleInstanceRadius / 2;
                    circle.Y += circle.CircleInstanceRadius / 2;
                } else if (circle.CircleInstanceRadius < 64)
                {
                    circle.X -= circle.CircleInstanceRadius / 2;
                    circle.Y -= circle.CircleInstanceRadius / 2;
                }
                circle.AttachTo(currentMap, true);
            }
            LocalLogManager.AddLine("Game Screen - Set rectangle collisions");
            foreach (var rect in TileCollisionRectangleList)
            {
                if (rect.AxisAlignedRectangleInstanceWidth > 128)
                {
                    rect.X += rect.AxisAlignedRectangleInstanceWidth / 2-64;
                }
                if (rect.AxisAlignedRectangleInstanceHeight > 128)
                {
                    rect.Y += rect.AxisAlignedRectangleInstanceHeight / 2-64;
                }
                rect.AttachTo(currentMap, true);
            }

            LocalLogManager.AddLine("Game Screen - Set water shapes");
            WaterShapes = currentMap.ShapeCollections.FirstOrDefault(sc => sc.Name == "Water")?.Polygons.ToList();
            if (WaterShapes != null)
            {
                foreach (var shape in WaterShapes)
                {
                    shape.AttachTo(currentMap, true);
                }
            }

            LocalLogManager.AddLine("Game Screen - Set pathing");
            Pathing = currentMap.ShapeCollections.FirstOrDefault(sc => sc.Name == "Pathing")?.Polygons.FirstOrDefault();
            Pathing?.AttachTo(currentMap, true);
            currentMap.AddToManagers(WorldLayer);

            //This centers the map in the middle of the screen
            var shiftVector = new Vector3(-currentMap.Width / 2, -(Camera.Main.OrthogonalHeight / 2 - currentMap.Height), 0);

            currentMap.Position.X = shiftVector.X;
            currentMap.Position.Y = shiftVector.Y;
            currentMap.Z = -2f;

            Pathing?.UpdateDependencies(TimeManager.CurrentTime);
            if (WaterShapes != null)
            {
                foreach (var shape in WaterShapes)
                {
                    shape.UpdateDependencies(TimeManager.CurrentTime);
                }
            }
            ShapeManager.AddToLayer(Pathing, WorldLayer);

            foreach (var overlay in TiledOverlayList)
            {
                overlay.ForceUpdateDependenciesDeep();
                overlay.Detach();
            }

            LocalLogManager.AddLine("Game Screen - Create pathing node network");

            PathingNodeNetwork = NodeNetworkGenerator.CreateFromTiledMap(currentMap);
            shiftVector.X += currentMap.WidthPerTile.Value/2;
            shiftVector.Y += currentMap.HeightPerTile.Value/2;
            PathingNodeNetwork.Shift(shiftVector);
            LocalLogManager.AddLine("Game Screen - Remove collisions from node network");
            NodeNetworkGenerator.RemoveNodesWithCollisions(ref PathingNodeNetwork, TileCollisionRectangleList, TileCollisionCircleList);
            
            MachineLearningManager.SetPathingAndWater(Pathing, WaterShapes);

            PathingSegments = new Segment[Pathing.Points.Count - 1];
            for (var i = 0; i <= Pathing.Points.Count - 2; i++)
            {
                PathingSegments[i] = new Segment(Pathing.AbsolutePointPosition(i), Pathing.AbsolutePointPosition(i + 1));
            }

            HorizonBoxInstance.CurrentSceneryState = CurrentLevel.Scenery;

#if DEBUG
            if (DebugVariables.ShowDebugShapes)
            {
                ShapeManager.AddPolygon(Pathing);
                if (WaterShapes != null)
                {
                    foreach (var shape in WaterShapes)
                    {
                        ShapeManager.AddPolygon(shape);
                        shape.Visible = true;
                    }
                }
            }
            if (DebugVariables.ShowNodeNetwork)
            {
                PathingNodeNetwork.LayerToDrawOn = HUDLayer;
                PathingNodeNetwork.Visible = true;
            }
#else
            Pathing.Visible = false;
            PathingNodeNetwork.Visible = true;
#endif
        }

        #endregion

        #region Activity
        void CustomActivity(bool firstTimeCalled)
        {
            if (firstTimeCalled) GameScreenGumInstance.FadeInAnimation.Play();
            if (_tutorialScript != null && !_tutorialScript.IsFinished) _tutorialScript.Activity();
#if DEBUG
            HandleDebugInput();
            ShowDebugInfo();
#endif

            if (SoundManager.Update()) CurrentMusicDisplayInstance.TimedDisplay();
            HandleKeyboardInput();
            HandleTouchActivity();
            SelectedItemActivity();

            if (CurrentPlayerActionMode == PlayerActionMode.Building)
            {
                if (!BuildMenuInstance.Visible) GuiManager.Cursor.GetCursorPosition(StructurePlacementInstance, 1);
                StructurePlacementInstance.CurrentCurrentlyActiveState = IsStructureBlocked() ? StructurePlacement.CurrentlyActive.Inactive : StructurePlacement.CurrentlyActive.Active;
            }

            TopStatusBarInstance.UpdateTime(PauseAndBuildAjustedTime, IsPaused);

            var gameplayOccuring = !IsPaused && GameHasStarted && CurrentPlayerActionMode != PlayerActionMode.Building;
            if (gameplayOccuring)
            {
                PauseAndBuildAjustedTime += TimeManager.SecondDifference;

                UpdateGameTime();

                if (CurrentPlayerActionMode != PlayerActionMode.Ending)
                {
                    CurrentLevel.Update();
                }

                HorizonBoxInstance.Update(currentLevelDateTime);

                SunlightManager.UpdateConditions(currentLevelDateTime);

                EnemyStatusActivity();
                PlayerProjectileActivity();

                if (CurrentPlayerActionMode == PlayerActionMode.Ending && !GameScreenGumInstance.HordeIncomingAnimation.IsPlaying())
                {
                    SendTheHorde();
                }
                else if (CurrentPlayerActionMode != PlayerActionMode.Ending && CurrentLevel.HasReachedDefeat())
                {
                    LevelFailed();
                }
            }
            else
            {
                foreach (var enemy in AllEnemiesList)
                {
                    enemy.UpdateSpritesRelativeY();
                }
            }
        }

        private bool IsStructureBlocked()
        {
            var isBlocked = StructurePlacementInstance.Y > 600f;

            isBlocked = isBlocked || PathingSegments.Any(s => s.DistanceTo(StructurePlacementInstance.Position) <
                                                     StructurePlacementInstance.CircleInstance.Radius);
            isBlocked = isBlocked || TileCollisionRectangleList.Any(
                    r => r.CollideAgainst(StructurePlacementInstance.CircleInstance));

            isBlocked = isBlocked || AllStructuresList.Any(s => s.AxisAlignedRectangleInstance.CollideAgainst(StructurePlacementInstance.CircleInstance));

            isBlocked = isBlocked || TileCollisionCircleList.Any(
                            c => c.Altitude < 1 && c.CollideAgainst(StructurePlacementInstance.CircleInstance));

            if (WaterShapes != null)
            {
                isBlocked = isBlocked ||
                            WaterShapes.Any(ws => ws.CollideAgainst(StructurePlacementInstance.CircleInstance));
            }

            return isBlocked;

        }

        private void HandleKeyboardInput()
        {
            if (InputManager.Keyboard.KeyPushed(Keys.Escape))
            {
                if (MenuWindowInstance.Visible)
                {
                    MenuWindowInstance.SimulateCloseButtonClick();
                }
                else
                {
                    TopStatusBarInstance.SimulateMenuButtonClick();
                }
            }
            else if (InputManager.Keyboard.KeyPushed(Keys.Space))
            {
                if (!MenuWindowInstance.Visible) OnPauseButtonClick(null);
            }
#if DEBUG
            else if (DebugVariables.EnableDebugHotkeys)
            {
                if (InputManager.Keyboard.KeyPushed(Keys.Q))
                    EnemyFactories.CreateNew(EnemyTypes.Chicken1);
                if (InputManager.Keyboard.KeyPushed(Keys.A))
                    EnemyFactories.CreateNew(EnemyTypes.Chicken2);
                if (InputManager.Keyboard.KeyPushed(Keys.Z))
                    EnemyFactories.CreateNew(EnemyTypes.Chicken3);

                if (InputManager.Keyboard.KeyPushed(Keys.W))
                    EnemyFactories.CreateNew(EnemyTypes.Rabbit1);
                if (InputManager.Keyboard.KeyPushed(Keys.S))
                    EnemyFactories.CreateNew(EnemyTypes.Rabbit2);
                if (InputManager.Keyboard.KeyPushed(Keys.X))
                    EnemyFactories.CreateNew(EnemyTypes.Rabbit3);

                if (InputManager.Keyboard.KeyPushed(Keys.E))
                    EnemyFactories.CreateNew(EnemyTypes.Sheep1);
                if (InputManager.Keyboard.KeyPushed(Keys.D))
                    EnemyFactories.CreateNew(EnemyTypes.Sheep2);
                if (InputManager.Keyboard.KeyPushed(Keys.C))
                    EnemyFactories.CreateNew(EnemyTypes.Sheep3);

                if (InputManager.Keyboard.KeyPushed(Keys.R))
                    EnemyFactories.CreateNew(EnemyTypes.Pig1);
                if (InputManager.Keyboard.KeyPushed(Keys.F))
                    EnemyFactories.CreateNew(EnemyTypes.Pig2);
                if (InputManager.Keyboard.KeyPushed(Keys.V))
                    EnemyFactories.CreateNew(EnemyTypes.Pig3);

                if (InputManager.Keyboard.KeyPushed(Keys.T))
                    EnemyFactories.CreateNew(EnemyTypes.Cow1);
                if (InputManager.Keyboard.KeyPushed(Keys.G))
                    EnemyFactories.CreateNew(EnemyTypes.Cow2);
                if (InputManager.Keyboard.KeyPushed(Keys.B))
                    EnemyFactories.CreateNew(EnemyTypes.Cow3);
            }
#endif
        }

        private void UpdateGameTime()
        {
            var addSeconds = TimeManager.SecondDifference * 48;
            currentLevelDateTime = currentLevelDateTime.AddSeconds(addSeconds);
        }

        private void LevelFailed()
        {
            LocalLogManager.AddLine("Game Screen - Level End");

            EndLevel();
            ReturnToMapScreen();
        }

        private void EndLevel()
        {
            CurrentPlayerActionMode = PlayerActionMode.Ending;

            var chosenDialogue = PlayerDataManager.LastChosenDialogueId;
            if (!string.IsNullOrEmpty(chosenDialogue))
            {
                PlayerDataManager.AddChosenDialogueId(chosenDialogue);
            }

            var levelResults = CurrentLevel.GetFinalResults(currentLevelDateTime);
            levelResults.TimePlayed = PauseAndBuildAjustedTime;
            PlayerDataManager.AllowPlayerNewTowerChoice();
            PlayerDataManager.RecordChapterResults(levelResults);
            PlayerDataManager.SaveData();

            AnalyticsManager.SendLevelCompleteEvent(levelResults);

            AnalyticsManager.SendDeferredEvents();
        }

        private void ReturnToMapScreen()
        {
            GameScreenGumInstance.FadeOutAnimation.Play();

            this.Call(() =>
            {
                TimeManager.TimeFactor = 1;
                LoadingScreen.TransitionToScreen(typeof(MapScreen));
            }).After(GameScreenGumInstance.FadeOutAnimation.Length);
        }

        private void LevelVictory()
        {
            EndLevel();
            SoundManager.PlaySoundEffect(HordeAlertSound);
            GameScreenGumInstance.HordeIncomingAnimation.Play();
            this.Call(ReturnToMapScreen).After(GameScreenGumInstance.HordeIncomingAnimation.Length+1f);
        }

        private void SendTheHorde()
        {
            if (AllEnemiesList.Count < 50)
            {
                EnemyFactories.CreateNew(FlatRedBallServices.Random.In(CurrentLevel.AvailableEnemyTypes), isHorde:true);
            }
        }

        private void RestartLevel(IWindow window)
        {
            LocalLogManager.AddLine("Game Screen - Restarting level");
            TimeManager.TimeFactor = 1;
            AnalyticsManager.FlushDeferredEvents();
            CameraZoomManager.Reset();
            RestartScreen(false);
        }
    
        private void EnemyStatusActivity()
        {
            var borderCollisions = TileCollisionRectangleList.Where(r => r.IsBarrier).ToList();

	        for (var i = AllEnemiesList.Count; i > 0; i--)
	        {
	            var enemy = AllEnemiesList[i-1];

                //For horde mode we are only going to update drowning
	            if (CurrentPlayerActionMode == PlayerActionMode.Ending)
	            {
	                //Collide enemies against water
	                if (WaterShapes != null && enemy.Altitude <= 0)
	                {
	                    foreach (var shape in WaterShapes)
	                    {
	                        if (shape.IsPointInside(ref enemy.Position))
	                        {
	                            enemy.HandleDrowning();
	                        }
	                    }
	                }
	                continue;
	            }

                //Colide enemies against others
	            for (var j = i - 1; j > 0; j--)
	            {
	                var otherEnemy = AllEnemiesList[j - 1];

	                if (enemy.IsFlying == otherEnemy.IsFlying ||
	                    (enemy.IsJumper && otherEnemy.IsJumper && enemy.Altitude > 0 && otherEnemy.IsJumper &&
	                        otherEnemy.Altitude > 0))
	                {
	                    enemy.SelfCollisionCircle.CollideAgainstMove(otherEnemy.SelfCollisionCircle, enemy.Mass,
	                        otherEnemy.Mass);
	                }
	            }

	            //Collide enemies against buildings
	            if (enemy.IsFlying)
	            {
	                for (var j = borderCollisions.Count(); j > 0; j--)
	                {
	                    var rect = borderCollisions[j - 1];

	                    enemy.SelfCollisionCircle.CollideAgainstBounce(rect.AxisAlignedRectangleInstance, thisMass: 0f, otherMass: 1f,
	                        elasticity: 0.1f);
	                }
                }
	            else
	            {
	                for (var j = AllStructuresList.Count(); j > 0; j--)
	                {
	                    var structure = AllStructuresList[j - 1];
	                    if (structure.IsBeingPlaced || structure.IsDestroyed) continue;

	                    enemy.CollideAgainstBounce(structure.AxisAlignedRectangleInstance, thisMass: 0f, otherMass: 1f,
	                        elasticity: 0.1f);
	                }

	                //Collide enemies against rectangle collisions
	                for (var j = TileCollisionRectangleList.Count(); j > 0; j--)
	                {
	                    var rect = TileCollisionRectangleList[j - 1];

	                    enemy.SelfCollisionCircle.CollideAgainstBounce(rect.AxisAlignedRectangleInstance, thisMass: 0f, otherMass: 1f,
	                        elasticity: 0.1f);
	                }

	                //Collide enemies against circle collisions
	                for (var j = TileCollisionCircleList.Count(); j > 0; j--)
	                {
	                    var circle = TileCollisionCircleList[j - 1];

	                    if (circle.Altitude > enemy.Altitude) continue;
	                    if (circle.Altitude + circle.ZHeight > enemy.Altitude) continue;

	                    enemy.SelfCollisionCircle.CollideAgainstBounce(circle.CircleInstance, thisMass: 0f, otherMass: 1f,
	                        elasticity: 0.5f);
	                }

	                //Collide enemies against water
	                if (WaterShapes != null && enemy.Altitude <= 0)
	                {
	                    foreach (var shape in WaterShapes)
	                    {
	                        if (shape.IsPointInside(ref enemy.Position))
	                        {
	                            enemy.HandleDrowning();
	                        }
	                    }
	                }
                }

	            if (enemy.IsDead) continue;

	            if (enemy.HasReachedGoal)
	            {
	                HandleEnemyReachingGoal();
                    MachineLearningManager.UpdateWaveScore(enemy);
                    enemy.Destroy();
	            }
            }
	    }

        private void HandleEnemyReachingGoal()
        {
            PlayAScreamSound();
            CurrentLevel.RemainingLives--;
            LivesPointsDisplayInstance.LivesReducedAnimation.Play();
            LivesPointsDisplayInstance.LivesRemaining = CurrentLevel.RemainingLives.ToString();
        }

        private void PlayerProjectileActivity()
	    {
	        for (var i = PlayerProjectileList.Count; i > 0; i--)
	        {
	            var projectile = PlayerProjectileList[i-1];
	            if (projectile.ShouldBeDestroyed || !projectile.CanStillDoDamage) continue;

	            if (projectile.CurrentState != BasePlayerProjectile.VariableState.Flying &&
	                !(projectile is CannonProjectile)) continue;

	            if (projectile is CannonProjectile cannonProjectile)
	            {
	                var enemiesImpacted = new List<BaseEnemy>();
	                for (var e = AllEnemiesList.Count; e > 0; e--)
	                {
	                    var enemy = AllEnemiesList[e - 1];

	                    if (enemy.IsDead) continue;

                        //Only hit flying enemies if cannonbal is in flight, and is at the same altitude as the enemy
                        if (enemy.IsFlying && (cannonProjectile.CurrentState != BasePlayerProjectile.VariableState.Flying || Math.Abs(enemy.Altitude - cannonProjectile.Altitude) > 32f)) continue;

	                    if (cannonProjectile.CurrentState == BasePlayerProjectile.VariableState.Flying)
	                    {
	                        if (cannonProjectile.CollideAgainstBounce(enemy,
	                            cannonProjectile.Mass, enemy.Mass, 0.5f))
	                        {
	                            enemy.GetHitBy(projectile);
	                        }
	                    }
	                    else if (enemy.Altitude < 100 && cannonProjectile.CollideAgainst(enemy))
	                    {
	                        enemiesImpacted.Add(enemy);
	                    }
	                }

	                if (cannonProjectile.CurrentState == BasePlayerProjectile.VariableState.Impact)
	                {
	                    cannonProjectile.HandleEnemiesInImpactZone(enemiesImpacted);
	                }
	            }
	            else
	            {
	                for (var e = AllEnemiesList.Count; e > 0; e--)
	                {
	                    var enemy = AllEnemiesList[e - 1];

	                    if (enemy.IsDead || !projectile.CollideAgainstBounce(enemy, projectile.Mass, enemy.Mass, 0.3f)) continue;

	                    enemy.GetHitBy(projectile);
	                    projectile.HandleImpact(enemy);
	                    break;
                    }
	            }
	        }
	    }

        public void SetPause(bool shouldPause)
        {
            if ( shouldPause && !IsPaused) PauseThisScreen();
            else if (!shouldPause && IsPaused) UnpauseThisScreen();
        }

        private void SelectedItemActivity()
        {
            if (selectedObject == null)
            {
                EnemyInfoInstance.Hide();
                StructureInfoInstance.Hide();
                return;
            }

            if (selectedObject is BaseStructure objectAsStructure)
            {
                EnemyInfoInstance.Hide();
                var canBeUpgraded = CurrentPlayerActionMode == PlayerActionMode.Building;
                StructureInfoInstance.Show(objectAsStructure, CurrentSatoshis, canBeUpgraded);
            }
            else if (selectedObject is BaseEnemy objectAsEnemy)
            {
                StructureInfoInstance.Hide();
                if (!objectAsEnemy.IsDead)
                {
                    EnemyInfoInstance.Show(objectAsEnemy);
                }
                else
                {
                    EnemyInfoInstance.Hide();
                }
            }
            else
            {
                EnemyInfoInstance.Hide();
            }
        }

        private void OnStructurePlacementClick(object sender, EventArgs eventArgs)
        {
            if (CurrentPlayerActionMode != PlayerActionMode.Building) return;

            if (sender is StructurePlacement placement)
            {
                EnemyInfoInstance.Hide();
                StructureInfoInstance.Hide();
                BuildMenuInstance.DisplayForPlacement(placement);
                selectedObject = placement;
            }
        }

        private void HandleTouchActivity()
	    {
	        //User clicked a building button
	        if (GuiManager.Cursor.PrimaryClick && GuiManager.Cursor.WindowPushed != null)
	        {
	            HandleBuildingButton();
	        }

            //User just clicked/touched somewhere, and nothing is currently selected
            else if ((GuiManager.Cursor.PrimaryClick) &&
	             GuiManager.Cursor.WindowOver == null)
	        {
	            //Remove the current selection if the user clicks off of it
	            if (selectedObject != null && !(selectedObject as IClickable).HasCursorOver(GuiManager.Cursor))
	            {
	                selectedObject = null;
	                BuildMenuInstance.Hide(false);
	            }

	            foreach (var structure in AllStructuresList)
	            {
	                if (GuiManager.Cursor.IsOn3D(structure.SpriteInstance))
	                {
	                    GuiManager.Cursor.ObjectGrabbed = structure;
	                    selectedObject = structure;
	                    var canBeUpgraded = CurrentPlayerActionMode == PlayerActionMode.Building;
                        StructureInfoInstance.Show(structure, CurrentSatoshis, canBeUpgraded);
	                    break;
	                }
	            }

                if (CurrentPlayerActionMode != PlayerActionMode.Building)
	            {
	                //Didn't select a structure, check for enemies
	                if (selectedObject == null)
	                {
	                    foreach (var enemy in AllEnemiesList)
	                    {
	                        if (GuiManager.Cursor.IsOn3D(enemy.SpriteInstance))
	                        {
	                            GuiManager.Cursor.ObjectGrabbed = enemy;
	                            selectedObject = enemy;
	                            EnemyInfoInstance.Show(enemy);
	                            break;
	                        }
	                    }
	                }
	            }
	        }
	        else if (GuiManager.Cursor.SecondaryClick)
	        {
	            selectedObject = null;
	            GuiManager.Cursor.ObjectGrabbed = null;

                BuildMenuInstance.Hide();
                EnemyInfoInstance.Hide();
                StructureInfoInstance.Hide();
	        }
	    }

#if DEBUG
        private void ShowDebugInfo()
        {
            var lastMSE = MachineLearningManager.CurrentMeanSquaredError;
            var avmMSE = MachineLearningManager.AverageValueMSE;
            var currentPrediction = CurrentPlayerActionMode == PlayerActionMode.Normal
                ? MachineLearningManager.CurrentPrediction.ToString()
                : "N\\A";
            var sampleSize = MachineLearningManager.SampleSize == 0 ? "N/A" : MachineLearningManager.SampleSize.ToString();
            var lastScore = MachineLearningManager.LastWaveScore;
            var learning = MachineLearningManager.CurrentlyLearning ? "True" : "False";
            var lastLearn = MachineLearningManager.LastLearnTime;
            var currentLearn = MachineLearningManager.CurrentLearnTime;
            var currentScore =
                CurrentPlayerActionMode == PlayerActionMode.Normal
                    ? MachineLearningManager.CurrentScore.ToString()
                    : "N\\A"; 

            DebugText = $"\n\n\nMSE: {lastMSE}\nAVM: {avmMSE}\nSamples: {sampleSize}\n\nLast Score: {lastScore}\n\nCurrentScore: {currentScore}\nCurrent Prediction: {currentPrediction}\n\nLast Learn Time: {lastLearn}\nLearning: {learning}\nLearn Time: {currentLearn}";

            FlatRedBall.Debugging.Debugger.TextRed = 1f;
            FlatRedBall.Debugging.Debugger.TextBlue = 1f;
            FlatRedBall.Debugging.Debugger.TextGreen = 1f;
            
            FlatRedBall.Debugging.Debugger.Write(DebugText);

            if (DebugVariables.ShowPerformanceStats)
            {
                string allUpdatedInfo = FlatRedBall.Debugging.Debugger.GetAutomaticallyUpdatedObjectInformation();
                string entityBreakdown = FlatRedBall.Debugging.Debugger.GetAutomaticallyUpdatedEntityInformation();
                string shapeBreakdown =
                    FlatRedBall.Debugging.Debugger.GetAutomaticallyUpdatedBreakdownFromList(FlatRedBall.Math.Geometry
                        .ShapeManager.AutomaticallyUpdatedShapes);
                string combinedInfo = $"{allUpdatedInfo}\n{shapeBreakdown}\n{entityBreakdown}";

                FlatRedBall.Debugging.Debugger.TextCorner = FlatRedBall.Debugging.Debugger.Corner.TopLeft;
                FlatRedBall.Debugging.Debugger.Write(combinedInfo);

                FlatRedBall.Debugging.Debugger.TextCorner = FlatRedBall.Debugging.Debugger.Corner.BottomLeft;
                FlatRedBall.Debugging.Debugger.TextRed = 0f;
                FlatRedBall.Debugging.Debugger.TextGreen = 0f;
                FlatRedBall.Debugging.Debugger.TextBlue = 0f;

                FlatRedBall.Graphics.Renderer.RecordRenderBreaks = true;
                var renderBreaks = FlatRedBall.Graphics.Renderer.LastFrameRenderBreakList != null
                    ? FlatRedBall.Graphics.Renderer.LastFrameRenderBreakList.Count
                    : 0;
                FlatRedBall.Debugging.Debugger.Write(renderBreaks);
            }
            //FlatRedBall.Debugging.Debugger.Write(GuiManager.Cursor.WindowOver);
        }

        private void HandleDebugInput()
        {
            //FlatRedBall.Debugging.Debugger.Write(FlatRedBall.Gui.GuiManager.Cursor.WindowOver);

            if (InputManager.Keyboard.KeyPushed(Keys.F5))
            {
                RestartScreen(true, false);
            }

            //Stage 1
            if (InputManager.Keyboard.KeyPushed(Keys.Z))
            {
                EnemyFactories.CreateNew(EnemyTypes.Cow1);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.X))
            {
                EnemyFactories.CreateNew(EnemyTypes.Rabbit1);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.C))
            {
                EnemyFactories.CreateNew(EnemyTypes.Sheep1);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.V))
            {
                EnemyFactories.CreateNew(EnemyTypes.Pig1);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.B))
            {
                EnemyFactories.CreateNew(EnemyTypes.Chicken1);
            }


            //Stage 2
            if (InputManager.Keyboard.KeyPushed(Keys.A))
            {
                EnemyFactories.CreateNew(EnemyTypes.Cow2);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.S))
            {
                EnemyFactories.CreateNew(EnemyTypes.Rabbit2);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.D))
            {
                EnemyFactories.CreateNew(EnemyTypes.Sheep2);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.F))
            {
                EnemyFactories.CreateNew(EnemyTypes.Pig2);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.G))
            {
                EnemyFactories.CreateNew(EnemyTypes.Chicken2);
            }


            //Stage 3
            if (InputManager.Keyboard.KeyPushed(Keys.Q))
            {
                EnemyFactories.CreateNew(EnemyTypes.Cow3);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.W))
            {
                EnemyFactories.CreateNew(EnemyTypes.Rabbit3);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.E))
            {
                EnemyFactories.CreateNew(EnemyTypes.Sheep3);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.R))
            {
                EnemyFactories.CreateNew(EnemyTypes.Pig3);
            }

            if (InputManager.Keyboard.KeyPushed(Keys.T))
            {
                EnemyFactories.CreateNew(EnemyTypes.Chicken3);
            }


        }
#endif
        #endregion

        #region Chat Methods

        private void LoadInitialDialogue()
        {
            LocalLogManager.AddLine("Game Screen - Loading intial dialogue");
            var gameDialogue = GameStateManager.GameDialogue;
            var firstDialogue = gameDialogue.DialogueList.FirstOrDefault(d => d.DisplayName == CurrentLevel.StartingDialogueDisplayName);

            if (firstDialogue != null)
            {
                var randomDelay = FlatRedBallServices.Random.Between(2.5f, 4f);
                this.Call(() =>
                {
                    PlayerDataManager.AddShownDialogueId(firstDialogue.Id);

                    var dialogueOptions = gameDialogue.GetDialogueOptionsFor(firstDialogue);

                    ChatBoxInstance.UpdateDialogue(firstDialogue, dialogueOptions);
                    ChatBoxInstance.DialogueChosen += DialogueChosen;
                    ChatBoxInstance.Visible = true;
                    ChatBoxInstance.NewMessageAnimation.Play();
                    SoundManager.PlaySoundEffect(IncomingMessageSound);
                }).After(randomDelay);
            }

        }

        private void UpdateDialogue()
        {
            LocalLogManager.AddLine("Game Screen - Updating dialogue");
            if (!ChatBoxInstance.Visible)
            {
                LoadInitialDialogue();
                return;
            }

            var randomDelay = FlatRedBallServices.Random.Between(1.5f, (1.5f + CurrentLevel.CurrentWaveNumber * 0.5f));
            this.Call(() =>
            {
                var gameDialogue = GameStateManager.GameDialogue;
                var chosenDialogue = PlayerDataManager.LastChosenDialogueId;

                if (chosenDialogue == "")
                {
                    chosenDialogue = ChatBoxInstance.SilentDialogue?.Id;
                    if (!string.IsNullOrEmpty(chosenDialogue))
                    {
                        PlayerDataManager.AddChosenDialogueId(chosenDialogue);
                    }
                }

                if (CurrentLevel.LevelNumber == 10 &&
                    ChatBoxInstance.CurrentIncomingMessage.DisplayName.Contains("Ending"))
                {
                    HandleGameEnd();
                }
                else if (!string.IsNullOrEmpty(chosenDialogue))
                {
                    var newDialogue = gameDialogue.GetResponseFor(chosenDialogue);

                    if (newDialogue != null)
                    {
                        var dialogueOptions = gameDialogue.GetDialogueOptionsFor(newDialogue);
                        dialogueOptions.Shuffle();

                        PlayerDataManager.AddShownDialogueId(newDialogue.Id);
                        ChatBoxInstance.UpdateDialogue(newDialogue, dialogueOptions);
                        ChatBoxInstance.NewMessageAnimation.Play();
                        SoundManager.PlaySoundEffect(IncomingMessageSound);
                    }
                }
            }).After(randomDelay);
        }

        private void HandleGameEnd()
        {
            TimeManager.TimeFactor = 1;

            var chosenDialogue = PlayerDataManager.LastChosenDialogueId;
            if (!string.IsNullOrEmpty(chosenDialogue))
            {
                PlayerDataManager.AddChosenDialogueId(chosenDialogue);
            }

            var levelResults = CurrentLevel.GetFinalResults(currentLevelDateTime);
            levelResults.TimePlayed = PauseAndBuildAjustedTime;
            PlayerDataManager.RecordChapterResults(levelResults);
            AnalyticsManager.SendLevelCompleteEvent(levelResults);

            var currentDisplayMessageName = ChatBoxInstance.CurrentIncomingMessage.DisplayName;

            var endingResult = EndingTypes.Silent;

            if (currentDisplayMessageName.Contains("Positive"))
            {
                endingResult = EndingTypes.Positive;
            }
            else if (currentDisplayMessageName.Contains("Negative"))
            {
                endingResult = EndingTypes.Negative;    
            }
            else if (currentDisplayMessageName.Contains("Silence"))
            {
                endingResult = EndingTypes.Silent;
            }

            PlayerDataManager.MarkPlayerReachedEnding(endingResult);
            AnalyticsManager.SendGameCompleteEvent(endingResult);

            PlayerDataManager.SaveData();
            
            AnalyticsManager.SendDeferredEvents();

            GameScreenGumInstance.FadeOutAnimation.Play(this);
            this.Call(() => LoadingScreen.TransitionToScreen(typeof(EndingScreen))
            ).After(GameScreenGumInstance.FadeOutAnimation.Length);
        }

        private void DialogueChosen(object sender, EventArgs eventArgs)
        {
            if (sender is ChatOptionRuntime chatoption)
            {
                var chosenDialogue = chatoption.CurrentDialogue;
                PlayerDataManager.AddChosenDialogueId(chosenDialogue.Id);

                ChatBoxInstance.CurrentMessageIndicatorState = ChatBoxRuntime.MessageIndicator.NoMessage;
                ChatBoxInstance.DisappearAnimation.Play(this);
                SoundManager.PlaySoundEffect(OutgoingMessageSound);
            }
        }
        #endregion


        #region Other Methods
        private void HandleUpgradeTower(BaseStructure baseStructure, UpgradeTypes upgradeType, int satoshiCost)
        {
            if (CurrentSatoshis >= satoshiCost)
            {
                baseStructure.ApplyUpgrade(upgradeType);
                SpendSatoshis(satoshiCost);
                StructureInfoInstance.Hide();

                StructureUpgradeSound.Pan = baseStructure.X / (Camera.Main.OrthogonalWidth / 2);

                SoundManager.PlaySoundEffect(StructureUpgradeSound);
            }
        }

        private void SpendSatoshis(int spendAmount)
        {
#if DEBUG
            if (DebugVariables.IgnoreStructureBuildCost) return;
#endif
            CurrentSatoshis -= spendAmount;
            LivesPointsDisplayInstance.SatoshiChange = $"-{spendAmount}";
            LivesPointsDisplayInstance.SubtractPointsAnimation.Play();
        }

        private void CreateResourceNotification(BaseEnemy enemy)
        {
            var pointValue = (int) Math.Max(1,enemy.PointValue()/2.25);
            CurrentSatoshis += pointValue;

            LivesPointsDisplayInstance.SatoshiChange = $"+{pointValue}";
            if (!LivesPointsDisplayInstance.AddPointsAnimation.IsPlaying()) LivesPointsDisplayInstance.AddPointsAnimation.Play();

            var notification = resourceIncreaseNotificationList.FirstOrDefault(n => n.Visible == false);

	        if (notification != null)
	        {
	            notification.X = (enemy.X - Camera.Main.X) * CameraZoomManager.GumCoordOffset;
	            notification.Y = (enemy.Y - Camera.Main.Y) * CameraZoomManager.GumCoordOffset;
	            notification.AmountOfIncrease = $"+{pointValue}";
                notification.Play();
	        }
        }

        private void PlayAScreamSound()
        {
            if (_LastScreamIndex > ScreamSounds.Count - 1)
            {
                ScreamSounds.Shuffle();
                _LastScreamIndex = 0;
            }

            ScreamSounds[_LastScreamIndex].Pan = 1;
            SoundManager.PlaySoundEffect(ScreamSounds[_LastScreamIndex++]);
        }

        private void CreateNotificationPool()
        {
            for (int i = 0; i < 10; i++)
            {
                var notification = new ResourceIncreaseNotificationRuntime();
                notification.AddToManagers();
                notification.MoveToFrbLayer(HUDLayer,GameScreenGum);
                notification.Visible = false;
                resourceIncreaseNotificationList.Add(notification);
            }
        }
        #endregion

        #region Destroy
        void CustomDestroy()
		{
		    if (resourceIncreaseNotificationList != null)
		    {
		        for (var i = resourceIncreaseNotificationList.Count - 1; i >= 0; i--)
		        {
		            resourceIncreaseNotificationList[i]?.Destroy();
		        }
		    }
		    if (WaterShapes != null)
		    {
		        for (var i = WaterShapes.Count - 1; i >= 0; i--)
		        {
		            WaterShapes[i]?.RemoveSelfFromListsBelongingTo();
		        }
            }

		    Pathing?.RemoveSelfFromListsBelongingTo();
		    BaseStructure.Reset();
            if (IncomingMessageSound != null && !IncomingMessageSound.IsDisposed) IncomingMessageSound.Dispose();
		    if (OutgoingMessageSound != null && !OutgoingMessageSound.IsDisposed) OutgoingMessageSound.Dispose();
		    if (HordeAlertSound != null && !HordeAlertSound.IsDisposed) HordeAlertSound.Dispose();
		    if (ScreamSoundLoop != null && !ScreamSoundLoop.IsDisposed) ScreamSoundLoop.Dispose();
		    if (StructureBuildSound != null && !StructureBuildSound.IsDisposed) StructureBuildSound.Dispose();
		    if (StructureUpgradeSound != null && !StructureUpgradeSound.IsDisposed) StructureUpgradeSound.Dispose();

            for (var i = ScreamSounds.Count - 1; i >= 0; i--)
		    {
		        var screamSound = ScreamSounds[i];
                if (screamSound != null && !screamSound.IsDisposed) screamSound.Dispose();
		    }

            PathingNodeNetwork.LayerToDrawOn = null;
            PathingNodeNetwork.Visible = false;
            PathingNodeNetwork = null;

		    for (var i = PlayerProjectileList.Count - 1; i >= 0; i--)
		    {
		        PlayerProjectileList[i].Destroy();
		    }

		    for (var i = AllEnemiesList.Count - 1; i >= 0; i--)
		    {
		        AllEnemiesList[i].Destroy();
		    }

		    for (var i = AllStructuresList.Count - 1; i >= 0; i--)
		    {
		        AllStructuresList[i].Destroy();
		    }

		    ChatBoxInstance.DialogueChosen = null;
		    CurrentLevel.OnNewWaveStart = null;
		    CurrentLevel.OnWaveEnd = null;
            currentMap?.Destroy();
		    currentMap = null;
		    selectedObject = null;

            BaseStructure.Initialize(null);
            BaseEnemy.Initialize(null, null);
        }
        #endregion

        static void CustomLoadStaticContent(string contentManagerName)
        {
            LocalLogManager.AddLine("Game Screen - Load static content");
            foreach (var tower in PlayerDataManager.GetAvailableTowers())
            {
                if (tower == typeof(PiercingTower))
                {
                    PiercingTower.LoadStaticContent(contentManagerName);
                    PiercingProjectile.LoadStaticContent(contentManagerName);
                }
                else if (tower == typeof(BombardingTower))
                {
                    BombardingTower.LoadStaticContent(contentManagerName);
                    CannonProjectile.LoadStaticContent(contentManagerName);
                }
                else if (tower == typeof(ChemicalTower))
                {
                    ChemicalTower.LoadStaticContent(contentManagerName);
                    ChemicalProjectile.LoadStaticContent(contentManagerName);
                }
                else if (tower == typeof(FireTower))
                {
                    FireTower.LoadStaticContent(contentManagerName);
                    FireProjectile.LoadStaticContent(contentManagerName);
                }
                else if (tower == typeof(FrostTower))
                {
                    FrostTower.LoadStaticContent(contentManagerName);
                    FrostProjectile.LoadStaticContent(contentManagerName);
                }
                else if (tower == typeof(ElectricTower))
                {
                    ElectricTower.LoadStaticContent(contentManagerName);
                    ElectricProjectile.LoadStaticContent(contentManagerName);
                }
            }

            if (GameStateManager.CurrentLevel == null) return;

            foreach (var enemy in GameStateManager.CurrentLevel.AvailableEnemyTypes)
            {
                switch (enemy)
                {
                    case EnemyTypes.Chicken1:
                        Chicken1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Chicken2:
                        Chicken1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Chicken3:
                        Chicken1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Pig1:
                        Pig1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Pig2:
                        Pig1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Pig3:
                        Pig1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Cow1:
                        Cow1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Cow2:
                        Cow1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Cow3:
                        Cow1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Sheep1:
                        Sheep1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Sheep2:
                        Sheep1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Sheep3:
                        Sheep1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Rabbit1:
                        Rabbit1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Rabbit2:
                        Rabbit1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                    case EnemyTypes.Rabbit3:
                        Rabbit1Enemy.LoadStaticContent(contentManagerName);
                        continue;
                }
            }
        }
    }
}
