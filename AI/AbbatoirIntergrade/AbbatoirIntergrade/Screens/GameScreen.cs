using System;
using System.Collections.Generic;
using System.Linq;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Audio;
using FlatRedBall.Gui;
using FlatRedBall.Math.Geometry;
using AbbatoirIntergrade.Entities;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.GraphicalElements;
using AbbatoirIntergrade.Entities.Projectiles;
using AbbatoirIntergrade.Entities.Structures;
using AbbatoirIntergrade.Factories;
using AbbatoirIntergrade.GameClasses;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GameClasses.Levels;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.Performance;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using RenderingLibrary;
using RenderingLibrary.Math.Geometry;
using Camera = FlatRedBall.Camera;
using ShapeManager = FlatRedBall.Math.Geometry.ShapeManager;

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

    private enum GameMode
        {
            Normal,
            Building,
        };

        private double PauseAndBuildAjustedTime;
        private BaseLevel CurrentLevel;
        private FlatRedBall.TileGraphics.LayeredTileMap currentMap;
        private Polygon Pathing;
        private List<Polygon> WaterShapes;
        private DateTime currentLevelDateTime;

        private GameMode CurrentGameMode = GameMode.Normal;
        private bool GameHasStarted;
        private PositionedObject selectedObject;

        private List<ResourceIncreaseNotificationRuntime> resourceIncreaseNotificationList;

        private SoundEffectInstance IncomingMessageSound;
        private SoundEffectInstance OutgoingMessageSound;

        #endregion

        #region Initialization

        void CustomInitialize()
        {
#if WINDOWS || DESKTOP_GL
            FlatRedBallServices.IsWindowsCursorVisible = true;
#endif
            FlatRedBallServices.GraphicsOptions.TextureFilter = TextureFilter.Point;

            GameStateManager.LoadIfNecessary();
            PlayerDataManager.LoadData();

            resourceIncreaseNotificationList = new List<ResourceIncreaseNotificationRuntime>();

            IncomingMessageSound = IncomingMessage.CreateInstance();
            OutgoingMessageSound = OutgoingMessage.CreateInstance();

            //TODO:  Set these values by loading a level
            CurrentLevel = GameStateManager.CurrentLevel ?? new Chapter1Level();
            CurrentLevel.OnNewWaveStart += HandleWaveStarted;
            CurrentLevel.OnWaveEnd += HandleWaveEnded;
            CurrentLevel.SetEnemiesAndLayer(AllEnemiesList);
            HorizonBoxInstance.CurrentSceneryState = CurrentLevel.Scenery;
            currentLevelDateTime = CurrentLevel.StartTime;

            InitializeFactories();

            LoadTiledMap();

            InitializeBaseEntities();

            AssignGumButtonEvents();

            CameraZoomManager.Initialize();
            AdjustLayerOrthoValues();
            InitializeShaders();

            HorizonBoxInstance.Initialize(currentLevelDateTime);

            InitializeManagers();

            //StartButtonInstance.Click += OnStartButtonInstanceClick;
            //GameHasStarted = false;
            
            CreateNotificationPool();
            ChangeGameModeToBuilding();
            GameHasStarted = true;
            PauseAndBuildAjustedTime = 0;

            SoundManager.PlaySongList(CurrentLevel.SongNameList);

            GameScreenGumInstance.CurrentFadingState = GameScreenGumRuntime.Fading.Faded;
        }

        private void HandleWaveStarted(object sender, EventArgs e)
        {
            UpdateInfoBar();
            UpdateDialogue();
            MachineLearningManager.NotifyOfWaveStart(sender, e);
        }

        private void HandleWaveEnded(object sender, EventArgs e)
        {
            if (StructurePlacementList.Any(sp => sp.Visible))
            {
                ChangeGameModeToBuilding();
            }
            else
            {
                ChangeGameModeToNormal();
            }
            MachineLearningManager.NotifyOfWaveEnd();
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
            EnemyFactories.SetGroundPathing(Pathing);
        }
        
        void LoadTiledMap()
        {
            currentMap = GetFile(CurrentLevel.MapName) as FlatRedBall.TileGraphics.LayeredTileMap;
            FlatRedBall.TileEntities.TileEntityInstantiator.CreateEntitiesFrom(currentMap);

            foreach (var overlay in TiledOverlayList)
            {
                overlay.MoveToLayer(WorldLayer);
                overlay.AttachTo(currentMap, true);
                overlay.RelativeZ = 3;
            }

            foreach (var place in StructurePlacementList)
            {
                place.OnClick += OnStructurePlacementClick;
                place.AttachTo(currentMap, true);
                place.RelativeZ = 3;
            }
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

            WaterShapes = currentMap.ShapeCollections.FirstOrDefault(sc => sc.Name == "Water")?.Polygons.ToList();
            if (WaterShapes != null)
            {
                foreach (var shape in WaterShapes)
                {
                    shape.AttachTo(currentMap, true);
                }
            }

            Pathing = currentMap.ShapeCollections.FirstOrDefault(sc => sc.Name == "Pathing")?.Polygons.FirstOrDefault();
            Pathing?.AttachTo(currentMap, true);
            currentMap.AddToManagers(WorldLayer);

            //This centers the map in the middle of the screen

            currentMap.Position.X = -currentMap.Width / 2;

            currentMap.Position.Y = -(Camera.Main.OrthogonalHeight / 2 - currentMap.Height);
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
            foreach (var place in StructurePlacementList)
            {
                place.ForceUpdateDependenciesDeep();
                place.Detach();
            }

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
#else
            Pathing.Visible = false;
#endif
            MachineLearningManager.SetPathing(Pathing);
        }

        #endregion

        #region Activity
        void CustomActivity(bool firstTimeCalled)
        {
            if (firstTimeCalled) GameScreenGumInstance.FadeInAnimation.Play();

#if DEBUG
            FlatRedBall.Debugging.Debugger.Write(GuiManager.Cursor.WindowOver);
            HandleDebugInput();
            ShowDebugInfo();
#endif
            SoundManager.Update();
            HandleKeyboardInput();
            HandleTouchActivity();
            SelectedItemActivity();

            var gameplayOccuring = !IsPaused && GameHasStarted && CurrentGameMode != GameMode.Building;
            if (gameplayOccuring)
            {
                PauseAndBuildAjustedTime += TimeManager.SecondDifference;

                UpdateGameTime();

                CurrentLevel.Update();
                TopStatusBarInstance.UpdateTime(PauseAndBuildAjustedTime);

                HorizonBoxInstance.Update(currentLevelDateTime);

                SunlightManager.UpdateConditions(currentLevelDateTime);

                EnemyStatusActivity();
                PlayerProjectileActivity();

                if (CurrentLevel.HasReachedDefeat())
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
        }

        private void UpdateGameTime()
        {
            var addSeconds = TimeManager.SecondDifference * 60;
            currentLevelDateTime = currentLevelDateTime.AddSeconds(addSeconds);
        }

        private void LevelFailed()
        {
            AudioManager.StopSong();
            try
            {
                //defeat_sound.Play();
            }
            catch (Exception){};
            ShowGameEndDisplay(playerWon: false);

            var levelResults = CurrentLevel.GetFinalResults();
            levelResults.TimePlayed = PauseAndBuildAjustedTime;
            PlayerDataManager.AllowPlayerNewTowerChoice();
            PlayerDataManager.RecordChapterResults(levelResults);
            PlayerDataManager.SaveData();

            AnalyticsManager.SendLevelCompleteEvent(levelResults);

            AnalyticsManager.SendDeferredEvents();

            LoadingScreen.TransitionToScreen(typeof(MapScreen));
        }

        private void LevelVictory()
        {
            AudioManager.StopSong();
            try
            {
                //victory_sound.Play();
            }
            catch (Exception) { };
            ShowGameEndDisplay(playerWon: true);
        }

        private void ShowGameEndDisplay(bool playerWon)
        {
            GameHasStarted = false;
        }

        private void RestartLevel(IWindow window)
        {
            AnalyticsManager.FlushDeferredEvents();
            CameraZoomManager.Reset();
            RestartScreen(false);
        }
    
        private void EnemyStatusActivity()
	    {
	        for (var i = AllEnemiesList.Count; i > 0; i--)
	        {
	            var enemy = AllEnemiesList[i-1];

                //Colide enemies against others
                for (var j = i- 1; j > 0; j--)
	            {
	                var otherEnemy = AllEnemiesList[j - 1];

	                if (enemy.IsFlying == otherEnemy.IsFlying || (enemy.IsJumper && otherEnemy.IsJumper && enemy.Altitude > 0 && otherEnemy.IsJumper && otherEnemy.Altitude > 0))
	                {
	                    enemy.SelfCollisionCircle.CollideAgainstMove(otherEnemy.SelfCollisionCircle, enemy.Mass, otherEnemy.Mass);
	                }
	            }

                //Collide enemies against buildings
	            if (!enemy.IsFlying)
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
	                enemy.Destroy();
	            }
            }
	    }

        private void HandleEnemyReachingGoal()
        {
            CurrentLevel.RemainingLives--;
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
	                    else if (cannonProjectile.CollideAgainst(enemy))
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
                StructureInfoInstance.Show(objectAsStructure);
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
                StructureInfoInstance.Hide();
            }
        }

        private void OnStructurePlacementClick(object sender, EventArgs eventArgs)
        {
            if (CurrentGameMode != GameMode.Building) return;

            if (sender is StructurePlacement placement)
            {
                BuildMenuInstance.DisplayForPlacement(placement);
                selectedObject = placement;
            }
        }

        private void HandleTouchActivity()
	    {
	        //User clicked a building button
	        if (GuiManager.Cursor.PrimaryDown && GuiManager.Cursor.WindowPushed != null)
	        {
	            HandleBuildingButton();
	        }

            //User just clicked/touched somewhere, and nothing is currently selected
            else if ((GuiManager.Cursor.PrimaryClick || GuiManager.Cursor.PrimaryDown) &&
	            GuiManager.Cursor.ObjectGrabbed == null && GuiManager.Cursor.WindowOver == null)
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
	                    StructureInfoInstance.Show(structure);
	                    break;
	                }
	            }

                if (CurrentGameMode != GameMode.Building)
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
	        else if (!GuiManager.Cursor.PrimaryDown)
	        {
	            GuiManager.Cursor.ObjectGrabbed = null;
	        }
	    }

#if DEBUG
        private void ShowDebugInfo()
        {
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
            var gameDialogue = GameStateManager.GameDialogue;
            var firstDialogue = gameDialogue.DialogueList.FirstOrDefault(d => d.DisplayName == CurrentLevel.StartingDialogueDisplayName);

            if (firstDialogue != null)
            {
                PlayerDataManager.AddShownDialogueId(firstDialogue.Id);

                var dialogueOptions = gameDialogue.GetDialogueOptionsFor(firstDialogue);

                ChatBoxInstance.UpdateDialogue(firstDialogue, dialogueOptions);
                ChatBoxInstance.DialogueChosen += DialogueChosen;
                ChatBoxInstance.Visible = true;
                SoundManager.PlaySoundEffect(IncomingMessageSound);
            }

        }

        private void UpdateDialogue()
        {
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

                if (CurrentLevel.MapName == "Chapter10" &&
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
                        SoundManager.PlaySoundEffect(IncomingMessageSound);
                    }
                }
            }).After(randomDelay);
        }

        private void HandleGameEnd()
        {
            var levelResults = CurrentLevel.GetFinalResults();
            levelResults.TimePlayed = PauseAndBuildAjustedTime;
            PlayerDataManager.RecordChapterResults(levelResults);
            AnalyticsManager.SendLevelCompleteEvent(levelResults);

            var currentDisplayMessageName = ChatBoxInstance.CurrentIncomingMessage.DisplayName;

            var endingResult = 0;

            if (currentDisplayMessageName.Contains("Positive"))
            {
                endingResult = 1;
            }
            else if (currentDisplayMessageName.Contains("Negative"))
            {
                endingResult = -1;    
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
        private void CreateResourceNotification(BaseEnemy enemy)
	    {

	        var notification = resourceIncreaseNotificationList.FirstOrDefault(n => n.Visible == false);

	        if (notification != null)
	        {
	            notification.X = (enemy.X - Camera.Main.X) * CameraZoomManager.GumCoordOffset;
	            notification.Y = (enemy.Y - Camera.Main.Y) * CameraZoomManager.GumCoordOffset;
	            //notification.AmountOfIncrease = $"+{enemy.MineralsRewardedWhenKilled}";
                notification.Play();
	        }
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
		}
        #endregion

        static void CustomLoadStaticContent(string contentManagerName)
        {
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

        }

        
    }
}
