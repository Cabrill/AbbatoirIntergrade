using System;
using System.Collections.Generic;
using System.Reflection;

using FlatRedBall;
using FlatRedBall.Graphics;
using FlatRedBall.Screens;
using Microsoft.Xna.Framework;

using System.Linq;
using FlatRedBall.Debugging;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using AbbatoirIntergrade.GameClasses;
using AbbatoirIntergrade.StaticManagers;
using TMXGlueLib.DataTypes;

namespace AbbatoirIntergrade
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;

        public Game1() : base ()
        {
            graphics = new GraphicsDeviceManager(this);

#if WINDOWS_PHONE || ANDROID || IOS

			// Frame rate is 30 fps by default for Windows Phone,
            // so let's keep that for other phones too
            TargetElapsedTime = TimeSpan.FromTicks(333333);
            graphics.IsFullScreen = true;
            graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft;
#elif WINDOWS || DESKTOP_GL
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
#endif
            ReducedTileMapInfo.FastCreateFromTmx = true;

#if WINDOWS_8
            FlatRedBall.Instructions.Reflection.PropertyValuePair.TopLevelAssembly = 
                this.GetType().GetTypeInfo().Assembly;
#endif

            PlayerDataManager.LoadData(firstLoad:true);
            AnalyticsManager.Initialize();

            var currentStatus = new
            {
                CurrentDateTime = DateTime.UtcNow.ToString(),
                FirstLaunch = (!PlayerDataManager.PlayerHasSeenIntro).ToString(),
                LaunchCount = PlayerDataManager.GameLaunchCount,
                HasBeatenGame = PlayerDataManager.PlayerHasBeatGame.ToString(),
            };

            AnalyticsManager.SendEventImmediately("GameLaunch", currentStatus);
        }

        protected override void Initialize()
        {
#if IOS
			var bounds = UIKit.UIScreen.MainScreen.Bounds;
			var nativeScale = UIKit.UIScreen.MainScreen.Scale;
			var screenWidth = (int)(bounds.Width * nativeScale);
			var screenHeight = (int)(bounds.Height * nativeScale);
			graphics.PreferredBackBufferWidth = screenWidth;
			graphics.PreferredBackBufferHeight = screenHeight;
#endif
            //FlatRedBall.TimeManager.TimeFactor = 0.5f;
            ReducedTileMapInfo.FastCreateFromTmx = true;
            FlatRedBallServices.InitializeFlatRedBall(this, graphics);

			CameraSetup.SetupCamera(SpriteManager.Camera, graphics);
			GlobalContent.Initialize();
			FlatRedBall.Screens.ScreenManager.Start(typeof(AbbatoirIntergrade.Screens.EndingScreen));
            base.Initialize();
        }


        protected override void Update(GameTime gameTime)
        {
            FlatRedBallServices.Update(gameTime);

            FlatRedBall.Screens.ScreenManager.Activity();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            FlatRedBallServices.Draw();

            base.Draw(gameTime);
        }
    }
}
