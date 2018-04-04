using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.Screens;
using FlatRedBall;
using FlatRedBall.Math;
using Gum.Wireframe;
using RenderingLibrary;

namespace AbbatoirIntergrade.GameClasses
{
    interface IGameScriptIf : FlatRedBall.Scripting.IIfScriptEngine
    {
        void True();
        void StructureExists();
        void BuildMenuShown();
        void PiercingTowerHighlighted();
        void WaveHasStarted();
        void ChatBoxVisible();
        void ChatBoxClosed();
        void MessageOpened();
        void WaveEnded();
        void StructureSelected();
        void StructureUpgraded();
        void EnemySelected();
        void EnemyInfoHidden();
    }

    interface IGameScriptDo : FlatRedBall.Scripting.IDoScriptEngine
    {
        void PointAtGumObject(IPositionedSizedObject objectToPointAt, PointingArrowRuntime.PointDirection direction = PointingArrowRuntime.PointDirection.Right);
        void ShowText(string text, bool allowDismiss = false);
        void HideText();
        void PauseGame();
        void UnPauseGame();
        void HideReadyButton();
        void ShowReadyButton();
        void HidePointer();
    }

    class TutorialScript : FlatRedBall.Scripting.ScriptEngine, IGameScriptIf, IGameScriptDo
    {
        public bool IsFinished { get; private set; } = false;

        private readonly Screens.GameScreen _gameScreen;
        private readonly PositionedObjectList<BaseStructure> _allStructures;

        public TutorialScript(Screens.GameScreen screen, PositionedObjectList<BaseStructure> structures)
        {
            _gameScreen = screen;
            _allStructures = structures;
        }

        public void Initialize()
        {
            If.True();
            Do.HideReadyButton();
            AfterThat();

            Do.PointAtGumObject(_gameScreen.LivesPointsDisplayInstance.GetChildByName("LivesContainer"), PointingArrowRuntime.PointDirection.Up);
            Do.ShowText("This is how many lives are at stake in this outpost.  When an animal gets past your defense it will kill a person, and when no people are left the level ends.", true);
            AfterThat();

            Do.PointAtGumObject(_gameScreen.TopStatusBarInstance.GetChildByName("WaveTextInstance"), PointingArrowRuntime.PointDirection.Up);
            Do.ShowText("This is how many waves of animals you have survived, and how many you must hold off to successfully evacuate your people.", true);
            AfterThat();

            Do.HidePointer();
            Do.ShowText("The animals will be here soon, so you need to create a defensive structure.  Left click on the ground to show the build menu.");
            If.BuildMenuShown();
            AfterThat();

            Do.PointAtGumObject(_gameScreen.BuildMenuInstance.GetChildByName("BuildButtonInstance0"));
            Do.ShowText("This is your menu of available towers.  Right now you can only build an arrow tower.  Hover over it.");
            If.PiercingTowerHighlighted();
            AfterThat();

            Do.ShowText("You can now see the specifications of this tower.  The green circle represents firing range, and the red circle is minimum range.  Enemies in the red circle will be too close to hit.", true);
            AfterThat();
            Do.ShowText("Try building a structure now.");
            If.StructureExists();
            AfterThat();

            Do.PointAtGumObject(_gameScreen.LivesPointsDisplayInstance.GetChildByName("PointsContainer"), PointingArrowRuntime.PointDirection.Up);
            Do.ShowText("Building a tower spends your satoshis.  You earn more by stopping attacking animals.", true);
            AfterThat();
            Do.HidePointer();

            Do.ShowReadyButton();
            Do.PointAtGumObject(_gameScreen.ReadyButtonInstance);
            Do.ShowText("Click the Start button to begin.  You cannot build or upgrade towers while enemies are attacking.");

            If.WaveHasStarted();
            Do.PointAtGumObject(_gameScreen.ChatBoxInstance, PointingArrowRuntime.PointDirection.Left);
            Do.PauseGame();
            Do.ShowText("You have an incoming message.  Click here to read it.");
            If.MessageOpened();
            AfterThat();

            Do.HidePointer();
            Do.ShowText("Read the message, and choose one of the three responses to send a reply.");
            If.ChatBoxClosed();
            Do.HideText();
            AfterThat();

            Do.ShowText("Click on one of the enemies to inspect it.");
            If.EnemySelected();
            Do.PointAtGumObject(_gameScreen.EnemyInfoInstance, PointingArrowRuntime.PointDirection.Up);
            Do.ShowText("Here you can see what an animal is resistant to and weak to.  High resistance (green) mean it won't be affected as much by that type of damage.  Right-click anywhere to hide this information.");
            If.EnemyInfoHidden();
            AfterThat();

            Do.UnPauseGame();
            AfterThat();

            If.WaveEnded();
            Do.ShowText("Now that the wave has ended you can build more structures, or upgrade existing structures.  Let's upgrade your arrow tower. Left click it to select it.");
            If.StructureSelected();
            AfterThat();

            Do.PointAtGumObject(_gameScreen.StructureInfoInstance.GetChildByName("UpgradeInfoInstance"), PointingArrowRuntime.PointDirection.Down);
            Do.ShowText("Click the icon on the left or right to upgrade the attack speed or range of this tower.");
            AfterThat();

            If.StructureUpgraded();
            Do.PointAtGumObject(_allStructures.Last?.StructureUpgradeStatusInstance, PointingArrowRuntime.PointDirection.Up);
            Do.ShowText("You can now see the tower has been upgraded.  That's all you need to know to defend your people.  Click the check mark in this window to close it and continue playing.  Good luck!", true);
            AfterThat();

            IsFinished = true;
        }


        public IGameScriptIf If
        {
            get
            {
                return this;
            }
        }

        public IGameScriptDo Do
        {
            get
            {
                return this;
            }
        }

        public void StructureExists()
        {
            CreateGeneralDecision(() => _allStructures.Count > 0);
        }

        public void BuildMenuShown()
        {
            CreateGeneralDecision(() => _gameScreen.BuildMenuInstance.Visible);
        }

        public void PiercingTowerHighlighted()
        {
            CreateGeneralDecision(() => (_gameScreen.BuildMenuInstance.GetChildByName("BuildButtonInstance0") as BuildButtonRuntime).CurrentHighlightState == BuildButtonRuntime.Highlight.Highlighted);
        }

        public void WaveHasStarted()
        {
            CreateGeneralDecision(() => _gameScreen.CurrentGameMode == GameScreen.GameMode.Normal);
        }

        public void ChatBoxVisible()
        {
            CreateGeneralDecision(() => _gameScreen.ChatBoxInstance.Visible);
        }

        public void ChatBoxClosed()
        {
            CreateGeneralDecision(() => _gameScreen.ChatBoxInstance.CurrentAppearanceState == ChatBoxRuntime.Appearance.ChatClosed);
        }

        public void MessageOpened()
        {
            CreateGeneralDecision(() => _gameScreen.ChatBoxInstance.CurrentAppearanceState == ChatBoxRuntime.Appearance.ChatOpen);
        }

        public void WaveEnded()
        {
            CreateGeneralDecision(() => _gameScreen.CurrentGameMode == GameScreen.GameMode.Building);
        }

        public void HideText()
        {
            Action action = () => _gameScreen.TutorialTextInstance.Visible = false;
            var generalAction = CreateGeneralAction(action);
            generalAction.IsCompleteFunction = () => !_gameScreen.TutorialTextInstance.Visible;
        }

        public void PauseGame()
        {
            Action action = () => _gameScreen.SetPause(true);
            var generalAction = CreateGeneralAction(action);
            generalAction.IsCompleteFunction = () => _gameScreen.IsCurrentlyPaused;
        }

        public void UnPauseGame()
        {
            Action action = () => _gameScreen.SetPause(false);
            var generalAction = CreateGeneralAction(action);
            generalAction.IsCompleteFunction = () => !_gameScreen.IsCurrentlyPaused;
        }

        public void HideReadyButton()
        {
            Action action = () => _gameScreen.ReadyButtonInstance.Visible = false;
            var generalAction = CreateGeneralAction(action);
            generalAction.IsCompleteFunction = () => !_gameScreen.ReadyButtonInstance.Visible;
        }

        public void ShowReadyButton()
        {
            Action action = () => _gameScreen.ReadyButtonInstance.Visible = true;
            var generalAction = CreateGeneralAction(action);
            generalAction.IsCompleteFunction = () => _gameScreen.ReadyButtonInstance.Visible;
        }

        public void HidePointer()
        {
            Action action = () => _gameScreen.PointingArrowInstance.Visible = false;
            var generalAction = CreateGeneralAction(action);
            generalAction.IsCompleteFunction = () => !_gameScreen.PointingArrowInstance.Visible;
        }

        public void StructureSelected()
        {
            CreateGeneralDecision(() => _gameScreen.StructureInfoInstance.Visible);
        }

        public void StructureUpgraded()
        {
            CreateGeneralAction(() => _allStructures.Any(s => s.GetCurrentlyAppliedUpgrades().Count > 0));
        }

        public void EnemySelected()
        {
            CreateGeneralDecision(() => _gameScreen.EnemyInfoInstance.Visible);
        }

        public void EnemyInfoHidden()
        {
            CreateGeneralDecision(() => !_gameScreen.EnemyInfoInstance.Visible);
        }

        public void True()
        {
            CreateGeneralDecision(() => true);
        }

        public void PointAtGumObject(IPositionedSizedObject objectToPointAt, PointingArrowRuntime.PointDirection direction = PointingArrowRuntime.PointDirection.Right)
        {
            if (objectToPointAt == null)
            {
                return;
            }
            Action action = () =>
            {
                _gameScreen.PointingArrowInstance.CurrentPointDirectionState = direction;
                _gameScreen.PointingArrowInstance.X = objectToPointAt.X;
                _gameScreen.PointingArrowInstance.Y = objectToPointAt.Y;
                _gameScreen.PointingArrowInstance.Visible = true;
            };
            var generalAction = CreateGeneralAction(action);
            generalAction.IsCompleteFunction = () => _gameScreen.PointingArrowInstance.Visible;
        }

        public void ShowText(string text, bool allowDismiss = false)
        {
            Action action = () => _gameScreen.TutorialTextInstance.ShowText(text, allowDismiss);
            var generalAction = CreateGeneralAction(action);
            generalAction.IsCompleteFunction = () => !allowDismiss || _gameScreen.TutorialTextInstance.HasBeenConfirmed;
        }
    }
    
}

