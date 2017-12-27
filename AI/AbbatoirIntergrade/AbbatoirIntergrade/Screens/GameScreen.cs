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
using AbbatoirIntergrade.Factories;
using AbbatoirIntergrade.GameClasses;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GameClasses.Levels;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.Performance;
using AbbatoirIntergrade.StaticManagers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Camera = FlatRedBall.Camera;

namespace AbbatoirIntergrade.Screens
{
    public partial class GameScreen
    {
        #region Properties and Fields

        private enum GameMode
        {
            Normal,
            Building,
            Inspecting
        };

        private BaseLevel CurrentLevel;
        private Polygon Pathing;
        private List<Polygon> WaterShapes;
        private DateTime currentLevelDateTime;

        private GameMode CurrentGameMode = GameMode.Normal;
        private bool GameHasStarted;
        private PositionedObject selectedObject;

        private List<ResourceIncreaseNotificationRuntime> resourceIncreaseNotificationList;

        private GameDialogue gameDialogue;

        #endregion

        #region Initialization

        void CustomInitialize()
        {
#if WINDOWS || DESKTOP_GL
            FlatRedBallServices.IsWindowsCursorVisible = true;
#endif

            FlatRedBallServices.GraphicsOptions.TextureFilter = TextureFilter.Point;

            resourceIncreaseNotificationList = new List<ResourceIncreaseNotificationRuntime>();

            //TODO:  Set these values by loading a level
            CurrentLevel = new Chapter1Level(AllEnemiesList, WorldLayer);
            currentLevelDateTime = CurrentLevel.StartTime;

            InitializeFactories();

            LoadTiledMap();

            InitializeBaseEntities();

            PlayerDataManager.LoadData();

            AssignBuildButtons();

            CameraZoomManager.Initialize();
            AdjustLayerOrthoValues();
            InitializeShaders();

            HorizonBoxInstance.Initialize(currentLevelDateTime);

            InitializeManagers();

            //StartButtonInstance.Click += OnStartButtonInstanceClick;
            //GameHasStarted = false;
            
            CreateNotificationPool();

            LoadDialogue();

            ChatBoxInstance.AppearAnimation.Play();

            GameHasStarted = true;
        }

        private void LoadDialogue()
        {
            string fileName = "content\\dialogue.xml";

            var doesFileExist = FlatRedBall.IO.FileManager.FileExists(fileName);

            if (doesFileExist)
            {
                gameDialogue = FlatRedBall.IO.FileManager.XmlDeserialize<GameDialogue>(fileName);
            }

            var firstDialogue = gameDialogue.DialogueList.FirstOrDefault(d => d.DisplayName == "Chapter1Start");

            if (firstDialogue != null)
            {
                var dialogueOptions = gameDialogue.GetDialogueOptionsFor(firstDialogue);

                ChatBoxInstance.UpdateDialogue(firstDialogue, dialogueOptions);
                ChatBoxInstance.DialogueChosen += DialogueChosen;
            }
            
        }

        private void DialogueChosen(object sender, EventArgs eventArgs)
        {
            if (sender is ChatOptionRuntime chatoption)
            {
                var chosenDialogue = chatoption.CurrentDialogue;
                var newDialogue = gameDialogue.GetResponseFor(chosenDialogue);
                var dialogueOptions = gameDialogue.GetDialogueOptionsFor(newDialogue);
                ChatBoxInstance.UpdateDialogue(newDialogue, dialogueOptions);
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
            WindManager.Initialize(currentLevelDateTime);
        }

        private void InitializeBaseEntities()
        {
            var maxY = Camera.Main.OrthogonalHeight * 0.95f;
            BaseStructure.Initialize(maxY);
            BasePlayerProjectile.Initialize(maxY);
            BaseStructure.Initialize(AllEnemiesList);
            BaseEnemy.Initialize(maxY);
        }
        
        void LoadTiledMap()
        {
            FlatRedBall.TileEntities.TileEntityInstantiator.CreateEntitiesFrom(Chapter1);

            foreach (var place in StructurePlacementList)
            {
                place.OnClick += OnClick;
                place.AttachTo(Chapter1);
                place.Z = 2;
                place.SetRelativeFromAbsolute();
            }
            foreach (var circle in TileCollisionCircleList)
            {
                if (circle.CircleInstanceRadius > 64)
                {
                    circle.X += circle.CircleInstanceRadius / 2;
                    circle.Y += circle.CircleInstanceRadius / 2;
                }
                circle.AttachTo(Chapter1);
                circle.SetRelativeFromAbsolute();
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
                rect.AttachTo(Chapter1);
                rect.SetRelativeFromAbsolute();
            }

            WaterShapes = Chapter1.ShapeCollections.FirstOrDefault(sc => sc.Name == "Water")?.Polygons.ToList();
            if (WaterShapes != null)
            {
                foreach (var shape in WaterShapes)
                {
                    shape.AttachTo(Chapter1);
                    shape.SetRelativeFromAbsolute();
                }
            }

            Pathing = Chapter1.ShapeCollections.FirstOrDefault(sc => sc.Name == "Pathing")?.Polygons.FirstOrDefault();
            Pathing?.AttachTo(Chapter1);
            Pathing?.SetRelativeFromAbsolute();
            Chapter1.AddToManagers(WorldLayer);

            //This centers the map in the middle of the screen
            
            Chapter1.Position.X = -Chapter1.Width / 2;

            Chapter1.Position.Y = -(Camera.Main.OrthogonalHeight / 2 - Chapter1.Height);
            Chapter1.Z = -1f;

            //ShapeManager.AddPolygon(pathing);
            ShapeManager.AddToLayer(Pathing, WorldLayer);
            Pathing.Visible = false;
        }

        private void OnClick(object sender, EventArgs eventArgs)
        {
            if (sender is StructurePlacement placement)
            {
                BuildMenuInstance.DisplayForPlacement(placement);
            }
        }

        #endregion

        #region Activity
        void CustomActivity(bool firstTimeCalled)
        {
            FlatRedBall.Debugging.Debugger.Write(FlatRedBall.Gui.GuiManager.Cursor.WindowOver);
#if DEBUG
            HandleDebugInput();
            ShowDebugInfo();
#endif
            //UpdateMusic();
            UpdateGameModeActivity();


            HandleTouchActivity();
            SelectedItemActivity();
            BuildingStatusActivity();

            var gameplayOccuring = !IsPaused && GameHasStarted;
            if (gameplayOccuring)
            {
                UpdateGameTime();

                CurrentLevel.Update(currentLevelDateTime);

                InsolationFormulas.Instance.UpdateDateTime(currentLevelDateTime);

                HorizonBoxInstance.Update(currentLevelDateTime);

                WindManager.Update(currentLevelDateTime);
                SunlightManager.UpdateConditions(currentLevelDateTime);

                EnemyStatusActivity();
                PlayerProjectileActivity();
            }
        }

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

        private void UpdateGameTime()
        {
            var addSeconds = TimeManager.SecondDifference * 60;
            currentLevelDateTime = currentLevelDateTime.AddSeconds(addSeconds);
        }

        private void SelectedItemActivity()
        {
            if (selectedObject == null)
            {
                EnemyInfoInstance.Hide();
                StructureInfoInstance.Hide();
                return;
            }

            var objectAsStructure = selectedObject as BaseStructure;
            var objectAsEnemy = selectedObject as BaseEnemy;

            if (objectAsStructure != null)
            {
                EnemyInfoInstance.Hide();
                if (!objectAsStructure.IsDestroyed)
                {
                    StructureInfoInstance.Show((BaseStructure) selectedObject);
                }
                else
                {
                    StructureInfoInstance.Hide();
                }

            }
            else if (objectAsEnemy != null)
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
        }

        private void UpdateGameModeActivity()
        {
            if (AllStructuresList.Any(s => s.IsBeingPlaced))
            {
                CurrentGameMode = GameMode.Building;
            }
            else if (selectedObject != null)
            {
                CurrentGameMode = GameMode.Inspecting;
            }
            else
            {
                CurrentGameMode = GameMode.Normal;
            }

            if (GameHasStarted)
            {
                if (CurrentLevel.HasReachedDefeat())
                {
                    LevelFailed();
                }
            }
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
            CameraZoomManager.Reset();
            RestartScreen(false);
        }
    

        private void EnemyStatusActivity()
	    {
	        for (var i = AllEnemiesList.Count; i > 0; i--)
	        {
	            var enemy = AllEnemiesList[i-1];
	            if (enemy.HasReachedGoal)
	            {
	                HandleEnemyReachingGoal();
                    enemy.Destroy();
	                continue;
	            }
	            if (enemy.IsDead) continue;

                //Colide enemies against others
	            for (var j = i- 1; j > 0; j--)
	            {
	                var otherEnemy = AllEnemiesList[j - 1];

	                if (otherEnemy.IsDead) continue;

	                if (enemy.IsFlying == otherEnemy.IsFlying || (enemy.IsJumper && otherEnemy.IsJumper && enemy.Altitude > 0 && otherEnemy.IsJumper && otherEnemy.Altitude > 0))
	                {
	                    enemy.CircleInstance.CollideAgainstBounce(otherEnemy.CircleInstance, enemy.SpriteInstance.Width, otherEnemy.SpriteInstance.Width,
	                        elasticity: 0.1f);
	                }
	            }

                //Collide enemies against buildings
	            if (enemy.IsFlying) continue;

	            for (var j = AllStructuresList.Count(); j > 0; j--)
	            {
	                var structure = AllStructuresList[j - 1];
	                if (structure.IsBeingPlaced || structure.IsDestroyed) continue;

	                enemy.CircleInstance.CollideAgainstBounce(structure.AxisAlignedRectangleInstance, thisMass: 0f, otherMass: 1f,
	                    elasticity: 0.1f);
	            }

                //Collide enemies against rectangle collisions
	            for (var j = TileCollisionRectangleList.Count(); j > 0; j--)
	            {
	                var rect = TileCollisionRectangleList[j - 1];

	                enemy.CircleInstance.CollideAgainstBounce(rect.AxisAlignedRectangleInstance, thisMass: 0f, otherMass: 1f,
	                    elasticity: 0.1f);
	            }

	            //Collide enemies against circle collisions
	            for (var j = TileCollisionCircleList.Count(); j > 0; j--)
	            {
	                var circle = TileCollisionCircleList[j - 1];

	                if (circle.Altitude > enemy.Altitude) continue;
	                if (circle.Altitude + circle.ZHeight > enemy.Altitude) continue;

	                enemy.CircleInstance.CollideAgainstBounce(circle.CircleInstance, thisMass: 0f, otherMass: 1f,
	                    elasticity: 0.5f);
	            }
                
                //Collide enemies against water
	            if (WaterShapes == null) continue;
	            if (enemy.Altitude > 0) continue;
	            foreach (var shape in WaterShapes)
	            {
	                if (enemy.CircleInstance.CollideAgainst(shape))
	                {
	                    enemy.HandleDrowning();
	                }
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
	            if (projectile.ShouldBeDestroyed) continue;

	            if (projectile.CurrentState != BasePlayerProjectile.VariableState.Flying &&
	                !(projectile is CannonProjectile)) continue;

	            if (projectile is CannonProjectile cannonProjectile)
	            {
	                if (cannonProjectile.IsOnlySmoke) continue;

	                var enemiesImpacted = new List<BaseEnemy>();
	                for (var e = AllEnemiesList.Count; e > 0; e--)
	                {
	                    var enemy = AllEnemiesList[e - 1];

	                    if (enemy.IsDead) continue;

                        //Only hit flying enemies if cannonbal is in flight, and is at the same altitude as the enemy
                        if (enemy.IsFlying && (cannonProjectile.CurrentState != BasePlayerProjectile.VariableState.Flying || Math.Abs(enemy.Altitude - cannonProjectile.Altitude) > 32f)) continue;

	                    if (cannonProjectile.CurrentState == BasePlayerProjectile.VariableState.Flying)
	                    {
	                        if (cannonProjectile.CircleInstance.CollideAgainstBounce(enemy.CircleInstance,
	                            cannonProjectile.Mass, enemy.Mass, 0.5f))
	                        {
	                            enemy.GetHitBy(projectile);
	                        }
	                    }
	                    else if (cannonProjectile.CircleInstance.CollideAgainst(enemy.CircleInstance))
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

	                    if (enemy.IsDead || !projectile.CircleInstance.CollideAgainstBounce(enemy.CircleInstance, projectile.Mass, enemy.Mass, 0.3f)) continue;

	                    enemy.GetHitBy(projectile);
	                    projectile.HandleImpact(enemy);
                    }
	            }
	        }
	    }

	    private void BuildingStatusActivity()
	    {
	        if (CurrentGameMode != GameMode.Building) return;

	        var newStructure = AllStructuresList.FirstOrDefault(s => s.IsBeingPlaced);

	        if (newStructure == null)
	        {
	            CurrentGameMode = GameMode.Normal;
            }
	    }

        #if DEBUG
        private void HandleDebugInput()
	    {
            //FlatRedBall.Debugging.Debugger.Write(FlatRedBall.Gui.GuiManager.Cursor.WindowOver);

	        if (InputManager.Keyboard.KeyPushed(Keys.Z))
	        {
	            var newAlien = Cow1EnemyFactory.CreateNew(WorldLayer);
	            newAlien.FollowLine(Pathing);
	        }

            if (InputManager.Keyboard.KeyPushed(Keys.X))
	        {
	            var newAlien = Chicken1EnemyFactory.CreateNew(WorldLayer);
                newAlien.FollowLine(Pathing);
	        }

	        if (InputManager.Keyboard.KeyPushed(Keys.C))
	        {
	            var newAlien = Sheep1EnemyFactory.CreateNew(WorldLayer);
	            newAlien.FollowLine(Pathing);
            }

	        if (InputManager.Keyboard.KeyPushed(Keys.V))
	        {
	            var newAlien = Pig1EnemyFactory.CreateNew(WorldLayer);
	            newAlien.FollowLine(Pathing);
            }


            if (InputManager.Keyboard.KeyDown(Keys.Y))
	        {
	            CameraZoomManager.PerformZoom(0, 0, 0.1f);
	        }
	        else if (InputManager.Keyboard.KeyDown(Keys.T))
	        {
	            CameraZoomManager.PerformZoom(0, 0, -0.1f);
	        }

        }
        #endif

        private void HandleTouchActivity()
	    {
	        foreach (var gesture in InputManager.TouchScreen.LastFrameGestures)
	        {
	            if (gesture.GestureType == GestureType.Pinch)
	            {
	                CameraZoomManager.PerformZoom(gesture, InputManager.TouchScreen.PinchStarted);
	                Camera.Main.ForceUpdateDependencies();
                    //Update the HorizonBox since the CameraZoomManager doesn't have a reference to it.
                    HorizonBoxInstance.ReactToCameraChange();
	                AdjustLayerOrthoValues();
	            }
                else if (GuiManager.Cursor.ObjectGrabbed == null && !InputManager.TouchScreen.IsPinching && (gesture.GestureType & (GestureType.FreeDrag | GestureType.HorizontalDrag |
                                                 GestureType.VerticalDrag)) > 0)
	            {
	                const int cameraMoveSpeed = 1;
	                var a = gesture.Position;

	                // prior positions
	                var aOld = gesture.Position - gesture.Delta;

	                var newX = Camera.Main.X - ((a.X - aOld.X) * cameraMoveSpeed / CameraZoomManager.GumCoordOffset);
	                var newY = Camera.Main.Y + ((a.Y - aOld.Y) * cameraMoveSpeed /  CameraZoomManager.GumCoordOffset);

	                var effectiveScreenLimitX = (CameraZoomManager.OriginalOrthogonalWidth  - Camera.Main.OrthogonalWidth) / 2;
	                var effectiveScreenLimitY = (CameraZoomManager.OriginalOrthogonalHeight - Camera.Main.OrthogonalHeight) / 2;

                    newX = MathHelper.Clamp(newX, -effectiveScreenLimitX, effectiveScreenLimitX);
	                newY = MathHelper.Clamp(newY, -effectiveScreenLimitY, effectiveScreenLimitY);

	                Camera.Main.X = newX;
	                Camera.Main.Y = newY;

                    //Update the HorizonBox since the CameraZoomManager doesn't have a reference to it.
	                Camera.Main.ForceUpdateDependencies();
                    HorizonBoxInstance.ReactToCameraChange();
                }
            }

	        //User clicked a building button
	        if (GuiManager.Cursor.PrimaryDown && GuiManager.Cursor.WindowPushed != null)
	        {
	            HandleBuildingButton();
	        }


            //User just clicked/touched somewhere, and nothing is currently selected
            if ((GuiManager.Cursor.PrimaryClick || GuiManager.Cursor.PrimaryDown) &&
	            GuiManager.Cursor.ObjectGrabbed == null && GuiManager.Cursor.WindowOver == null)
	        {
	            if (CurrentGameMode == GameMode.Building)
	            {
	                var structureBeingBuilt = AllStructuresList.FirstOrDefault(s => s.IsBeingPlaced);
                    if(structureBeingBuilt != null && GuiManager.Cursor.IsOn3D(structureBeingBuilt.SpriteInstance))
	                {
	                    GuiManager.Cursor.ObjectGrabbed = structureBeingBuilt;
	                }
	            }
	            else //Not building, user is possibly selecting an object
	            {
                    //Remove the current selection if the user clicks off of it
	                if (selectedObject != null && !(selectedObject as IClickable).HasCursorOver(GuiManager.Cursor))
	                {
                        selectedObject = null;
	                }

	                foreach (var structure in AllStructuresList)
	                {
	                    if (GuiManager.Cursor.IsOn3D(structure.SpriteInstance))
	                    {
	                        GuiManager.Cursor.ObjectGrabbed = structure;
	                        selectedObject = structure;
	                        CurrentGameMode = GameMode.Inspecting;
	                        StructureInfoInstance.Show(structure);
	                        break;
	                    }
	                }

                    //Didn't select a structure, check for enemies
	                if (selectedObject == null)
	                {
	                    foreach (var enemy in AllEnemiesList)
	                    {
	                        if (GuiManager.Cursor.IsOn3D(enemy.SpriteInstance))
	                        {
	                            GuiManager.Cursor.ObjectGrabbed = enemy;
	                            selectedObject = enemy;
	                            CurrentGameMode = GameMode.Inspecting;
	                            EnemyInfoInstance.Show(enemy);
	                            break;
	                        }
	                    }
                    }
	            }
	        }
	        else if (GuiManager.Cursor.PrimaryDown && GuiManager.Cursor.ObjectGrabbed != null)
	        {
                var objectAsStructure = GuiManager.Cursor.ObjectGrabbed as BaseStructure;
                var shouldAllowDrag = objectAsStructure != null && objectAsStructure.IsBeingPlaced;

                if (shouldAllowDrag)
                {
                    GuiManager.Cursor.UpdateObjectGrabbedPosition();
                }
            }
	        else if (!GuiManager.Cursor.PrimaryDown)
	        {
	            GuiManager.Cursor.ObjectGrabbed = null;
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
	            notification.AmountOfIncrease = $"+{enemy.MineralsRewardedWhenKilled}";
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
		        foreach (var notification in resourceIncreaseNotificationList)
		        {
		            notification.Destroy();
		        }
		    }
		}
#endregion

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        
    }
}
