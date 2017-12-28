using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Gui;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;



namespace AbbatoirIntergrade.Screens
{
	public partial class MapScreen
	{

		void CustomInitialize()
		{
#if WINDOWS || DESKTOP_GL
		    FlatRedBallServices.IsWindowsCursorVisible = true;
#endif
		    AssignLevelsToMapButtons();
		}

	    void CustomActivity(bool firstTimeCalled)
		{
		    FlatRedBall.Debugging.Debugger.Write(FlatRedBall.Gui.GuiManager.Cursor.WindowOver);

        }

		void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	    private void AssignLevelsToMapButtons()
	    {
	        foreach (var element in MapScreenGumInstance.Element.ContainedElements)
	        {
	            if (element is LevelButtonRuntime levelButton)
	            {
	                levelButton.Click += LoadLevel;
	            }
	        }
	    }

	    private void LoadLevel(IWindow window)
	    {
	        var windowAsLevelButton = window as LevelButtonRuntime;
	        var levelName = windowAsLevelButton.LevelName;
	        var assembly = Assembly.GetExecutingAssembly();

	        var type = assembly.GetTypes()
	            .First(t => t.Name == levelName);

	        var level =  (BaseLevel)Activator.CreateInstance(type);

	        GameStateManager.CurrentLevel = level;
            this.MoveToScreen(typeof(GameScreen));
	    }
	}
}
