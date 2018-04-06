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
using RenderingLibrary.Graphics;

namespace AbbatoirIntergrade.GameClasses
{
    interface IGameScriptIf : FlatRedBall.Scripting.IIfScriptEngine
    {
        void True(string ifName = null);
        void StructureExists(string ifName = null);
        void BuildMenuShown(string ifName = null);
        void PiercingTowerHighlighted(string ifName = null);
        void WaveHasStarted(string ifName = null);
        void ChatBoxVisible(string ifName = null);
        void ChatBoxClosed(string ifName = null);
        void MessageOpened(string ifName = null);
        void WaveEnded(string ifName = null);
        void StructureSelected(string ifName = null);
        void StructureUpgraded(string ifName = null);
        void EnemySelected(string ifName = null);
        void EnemyInfoHidden(string ifName = null);
        void OneEnemyRemaining(string ifName = null);
    }

    interface IGameScriptDo : FlatRedBall.Scripting.IDoScriptEngine
    {
        void PointAtGumObject(GraphicalUiElement objectToPointAt, PointingArrowRuntime.PointDirection direction = PointingArrowRuntime.PointDirection.Right, string doName = null);
        void PointAtUpgradeStatus(PointingArrowRuntime.PointDirection direction, string doName = null);
        void ShowText(string text, bool requiresConfirmation = false, bool allowSkip = false, string doName = null, bool onLeft = false);
        void HideText(string doName = null);
        void PauseGame(string doName = null);
        void UnPauseGame(string doName = null);
        void HideReadyButton(string doName = null);
        void ShowReadyButton(string doName = null);
        void HidePointer(string doName = null);
        void FinishTutorial(string doName = null);
    }

    class TutorialScript : FlatRedBall.Scripting.ScriptEngine, IGameScriptIf, IGameScriptDo
    {
        public bool IsFinished { get; private set; }

        private IGameScriptIf If => this;
        private IGameScriptDo Do => this;

        private readonly Screens.GameScreen _gameScreen;

        public TutorialScript(Screens.GameScreen screen)
        {
            _gameScreen = screen;
            ExecutionMode = ExecutionModes.Linear;
        }

        public void Initialize()
        {
            If.True("StartTutorial");
            Do.HideReadyButton();
            Do.PointAtGumObject(_gameScreen.LivesPointsDisplayInstance.GetGraphicalUiElementByName("LivesContainer"), 
                PointingArrowRuntime.PointDirection.Up,"PointAtLives");
            Do.ShowText("This is how many lives are at stake in this outpost.  " +
                        "When an animal gets past your defense it will kill a person, and when no people are left the level ends.", 
                requiresConfirmation:true, allowSkip: true,doName: "ConfirmLives");

            AfterThat();
            Do.PointAtGumObject(_gameScreen.TopStatusBarInstance.GetGraphicalUiElementByName("WaveTextInstance"), 
                PointingArrowRuntime.PointDirection.Up, "PointAtWaves");
            Do.ShowText("This is how many waves of animals you have survived, " +
                        "and how many you must hold off to successfully evacuate your people.", 
                requiresConfirmation:true, doName: "ConfirmWaves");

            AfterThat();
            Do.HidePointer();
            Do.ShowText("The animals will be here soon, so you need to create a defensive structure.  Move your mouse over the ground, " +
                        "find a spot on the ground where the cursor isn't red, and then left click to open the build menu.", doName: "CreateTowerInfo", onLeft:true);

            If.BuildMenuShown();
            Do.PointAtGumObject(_gameScreen.BuildMenuInstance.GetGraphicalUiElementByName("BuildButtonInstance0"), doName: "PointAtBuildButton");
            Do.ShowText("This is your menu of available towers.  Right now you can only build an arrow tower, but later you will unlock more." +
                        "\n\nHover over the arrow tower now.", doName: "HoverButton", onLeft: true);

            If.PiercingTowerHighlighted();
            Do.ShowText("You can now see the damage type (30 piercing), build cost (10 satoshis), min/max range, seconds between attacks, and target type (single/group).  \n\nThe large green circle originating where you " +
                        "clicked represents the firing range, and the red circle is minimum range.  \n\nEnemies in the red circle will be too close for the tower to hit.  " +
                        "\n\nTry building this tower now.", 
                doName: "ConfirmRange", onLeft: true);

            If.StructureExists();
            Do.PointAtGumObject(_gameScreen.LivesPointsDisplayInstance.GetGraphicalUiElementByName("PointsContainer"), 
                PointingArrowRuntime.PointDirection.Up, doName: "PointMoney");
            Do.ShowText("Building a tower spends your satoshis.  You earn more by stopping attacking animals.", 
                requiresConfirmation:true, doName: "ExplainMoney");

            AfterThat();
            Do.ShowReadyButton();
            Do.PointAtGumObject(_gameScreen.ReadyButtonInstance, PointingArrowRuntime.PointDirection.Up, doName: "PointAtReadyButton");
            Do.ShowText("Click the Ready button to begin.  You cannot build or upgrade towers while enemies are attacking.", doName: "InstructToStart");

            If.WaveHasStarted();
            Do.HideText();
            Do.HidePointer();

            If.ChatBoxVisible();
            Do.PauseGame();
            Do.PointAtGumObject(_gameScreen.ChatBoxInstance.GetGraphicalUiElementByName("MessageBox"), 
                PointingArrowRuntime.PointDirection.Left, doName: "PointAtChatBox");
            Do.ShowText("You have an incoming message.  Click on the new message indicator to read it.");

            If.MessageOpened();
            Do.HidePointer();
            Do.ShowText("Read the message, and choose one of the three responses to send a reply.", doName: "InstructToRead");

            If.ChatBoxClosed();
            Do.ShowText("Click on one of the enemies to inspect it.", doName: "InstructToInspectEnemy");

            If.EnemySelected();
            Do.PointAtGumObject(_gameScreen.EnemyInfoInstance, 
                PointingArrowRuntime.PointDirection.Left, doName: "PointAtEnemyInfo");
            Do.ShowText("Here you can see the animals health, run speed, and damage resistances.  Higher resistance (green) means it won't " +
                        "be affected as much by that type of damage, while red means it is very susceptible to that damage type." +
                        "\n\nRight-click anywhere to hide this information.", doName: "ExplainResistances");

            If.EnemyInfoHidden();
            Do.HidePointer();
            Do.HideText();
            Do.UnPauseGame();

            If.WaveEnded();
            Do.HideReadyButton();
            Do.ShowText("Now that the wave has ended you can build more structures, or upgrade existing structures.  " +
                        "Let's upgrade your arrow tower. Left click it to select it.", doName: "InstructToClickTower");

            If.StructureSelected();
            Do.PointAtGumObject(_gameScreen.StructureInfoInstance.GetGraphicalUiElementByName("UpgradeInfoInstance"), 
                PointingArrowRuntime.PointDirection.Down, doName: "PointAtUpgradeButtons");
            Do.ShowText("Click the icon on the left to upgrade its range or the one on the right to upgrade the attack speed.", doName: "InstructToClickUpgrade");

            If.StructureUpgraded();
            Do.PointAtUpgradeStatus(PointingArrowRuntime.PointDirection.Up, doName: "PointAtUpgradedStatus");
            Do.ShowText("You can now see the tower has been upgraded.  That's all you need to know to defend your people.  " +
                        "\n\nPS:  Even if you aren't successful in evacuating all your people on a level the game will continue, " +
                        "so don't fixate on singular success on any particular level.  "+
                        "\n\nYour main objective should be to find a permanent solution to the conflict, not to succeed in defending any " +
                        "particular outpost as the animals are generated faster than you could hope to kill them."+
                        "\n\nGood luck!", 
                requiresConfirmation:true, doName: "EndTutorialMessage");

            AfterThat();
            Do.HidePointer();
            Do.ShowReadyButton();
            Do.FinishTutorial();
        }

        public void StructureExists(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.AllStructuresList.Count > 0, cmdName);
        }

        public void BuildMenuShown(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.BuildMenuInstance.Visible, cmdName);
        }

        public void PiercingTowerHighlighted(string cmdName = null)
        {
            CreateGeneralDecision(() => (_gameScreen.BuildMenuInstance.GetGraphicalUiElementByName("BuildButtonInstance0") as BuildButtonRuntime).CurrentHighlightState == BuildButtonRuntime.Highlight.Highlighted, cmdName);
        }

        public void WaveHasStarted(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.CurrentGameMode == GameScreen.GameMode.Normal, cmdName);
        }

        public void ChatBoxVisible(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.ChatBoxInstance.Visible, cmdName);
        }

        public void ChatBoxClosed(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.ChatBoxInstance.CurrentAppearanceState == ChatBoxRuntime.Appearance.ChatClosed, cmdName);
        }

        public void MessageOpened(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.ChatBoxInstance.CurrentAppearanceState == ChatBoxRuntime.Appearance.ChatOpen, cmdName);
        }

        public void WaveEnded(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.CurrentGameMode == GameScreen.GameMode.Building, cmdName);
        }

        public void HideText(string cmdName = null)
        {
            Action action = () => _gameScreen.TutorialTextInstance.Visible = false;
            var generalAction = CreateGeneralAction(action, cmdName);
            generalAction.IsCompleteFunction = () => !_gameScreen.TutorialTextInstance.Visible;
        }

        public void PauseGame(string cmdName = null)
        {
            Action action = () => _gameScreen.SetPause(true);
            var generalAction = CreateGeneralAction(action, cmdName);
            generalAction.IsCompleteFunction = () => _gameScreen.IsCurrentlyPaused;
        }

        public void UnPauseGame(string cmdName = null)
        {
            Action action = () => _gameScreen.SetPause(false);
            var generalAction = CreateGeneralAction(action, cmdName);
            generalAction.IsCompleteFunction = () => !_gameScreen.IsCurrentlyPaused;
        }

        public void HideReadyButton(string cmdName = null)
        {
            Action action = () => _gameScreen.ReadyButtonInstance.Visible = false;
            var generalAction = CreateGeneralAction(action, cmdName);
            generalAction.IsCompleteFunction = () => !_gameScreen.ReadyButtonInstance.Visible;
        }

        public void ShowReadyButton(string cmdName = null)
        {
            Action action = () => _gameScreen.ReadyButtonInstance.Visible = true;
            var generalAction = CreateGeneralAction(action, cmdName);
            generalAction.IsCompleteFunction = () => _gameScreen.ReadyButtonInstance.Visible;
        }

        public void HidePointer(string cmdName = null)
        {
            Action action = () =>
            {
                _gameScreen.PointingArrowInstance.StopAnimations();
                _gameScreen.PointingArrowInstance.Visible = false;
            };
            var generalAction = CreateGeneralAction(action, cmdName);
            generalAction.IsCompleteFunction = () => !_gameScreen.PointingArrowInstance.Visible;
        }

        public void FinishTutorial(string cmdName = null)
        {
            Action action = () => IsFinished = true;
            CreateGeneralAction(action, cmdName);
        }

        public void StructureSelected(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.StructureInfoInstance.Visible, cmdName);
        }

        public void StructureUpgraded(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.AllStructuresList.Any(s => s.GetCurrentlyAppliedUpgrades().Count > 0), cmdName);
        }

        public void EnemySelected(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.EnemyInfoInstance.Visible, cmdName);
        }

        public void EnemyInfoHidden(string cmdName = null)
        {
            CreateGeneralDecision(() => !_gameScreen.EnemyInfoInstance.Visible, cmdName);
        }

        public void OneEnemyRemaining(string cmdName = null)
        {
            CreateGeneralDecision(() => _gameScreen.AllEnemiesList.Count == 1, cmdName);
        }

        public void True(string cmdName = null)
        {
            CreateGeneralDecision(() => true, cmdName);
        }

        public void PointAtGumObject(GraphicalUiElement objectToPointAt, PointingArrowRuntime.PointDirection direction = PointingArrowRuntime.PointDirection.Right, string cmdName = null)
        {
            var action = GetPointingAction(objectToPointAt, direction);
            var generalAction = CreateGeneralAction(action, cmdName);
            generalAction.IsCompleteFunction = () => _gameScreen.PointingArrowInstance.Visible;
        }

        public void PointAtUpgradeStatus(PointingArrowRuntime.PointDirection direction, string cmdName = null)
        {
            Action action = () =>
            {
                GetPointingAction(_gameScreen.AllStructuresList.Last.StructureUpgradeStatusInstance, direction).Invoke();
            };
            var generalAction = CreateGeneralAction(action, cmdName);
            generalAction.IsCompleteFunction = () => _gameScreen.PointingArrowInstance.Visible;
        }

        public void ShowText(string text, bool requiresConfirmation = false, bool allowSkip = false, string cmdName = null, bool onLeft = false)
        {
            Action action = () => _gameScreen.TutorialTextInstance.ShowText(text, requiresConfirmation, allowSkip, onLeft);
            var generalAction = CreateGeneralAction(action, cmdName);
            generalAction.IsCompleteFunction = () => !requiresConfirmation || _gameScreen.TutorialTextInstance.HasBeenConfirmed;
        }

        private Action GetPointingAction(GraphicalUiElement objectToPointAt,
            PointingArrowRuntime.PointDirection direction)
        {
            return () =>
            {
                var xMod = 0f;
                var yMod = 0f;
                var arrow = _gameScreen.PointingArrowInstance;

                if (objectToPointAt.YOrigin == VerticalAlignment.Top)
                {
                    switch (direction)
                    {
                        case PointingArrowRuntime.PointDirection.Left:
                        case PointingArrowRuntime.PointDirection.Right:
                            yMod = objectToPointAt.GetAbsoluteHeight() / 2;
                            break;
                        case PointingArrowRuntime.PointDirection.Up:
                            yMod = objectToPointAt.GetAbsoluteHeight();
                            break;
                    }
                }
                else if (objectToPointAt.YOrigin == VerticalAlignment.Center)
                {
                    switch (direction)
                    {
                        case PointingArrowRuntime.PointDirection.Up:
                            yMod += objectToPointAt.GetAbsoluteHeight() / 2;
                            break;
                        case PointingArrowRuntime.PointDirection.Down:
                            yMod -= objectToPointAt.GetAbsoluteHeight() / 2;
                            break;
                    }
                }
                else if (objectToPointAt.YOrigin == VerticalAlignment.Bottom)
                {
                    switch (direction)
                    {
                        case PointingArrowRuntime.PointDirection.Left:
                        case PointingArrowRuntime.PointDirection.Right:
                            yMod -= objectToPointAt.GetAbsoluteHeight() / 2;
                            break;
                        case PointingArrowRuntime.PointDirection.Down:
                            yMod -= objectToPointAt.GetAbsoluteHeight();
                            break;
                    }
                }

                if (objectToPointAt.XOrigin == HorizontalAlignment.Left)
                {
                    switch (direction)
                    {
                        case PointingArrowRuntime.PointDirection.Left:
                            xMod = objectToPointAt.GetAbsoluteWidth();
                            break;
                        case PointingArrowRuntime.PointDirection.Up:
                            xMod = objectToPointAt.GetAbsoluteWidth() / 2;
                            break;
                        case PointingArrowRuntime.PointDirection.Down:
                            xMod = objectToPointAt.GetAbsoluteWidth() / 2;
                            break;
                    }
                }
                else if (objectToPointAt.XOrigin == HorizontalAlignment.Center)
                {
                    switch (direction)
                    {
                        case PointingArrowRuntime.PointDirection.Left:
                            xMod = objectToPointAt.GetAbsoluteWidth() / 2;
                            break;
                        case PointingArrowRuntime.PointDirection.Right:
                            xMod = objectToPointAt.GetAbsoluteWidth() / 2;
                            break;
                    }

                }
                else if (objectToPointAt.XOrigin == HorizontalAlignment.Right)
                {
                    switch (direction)
                    {
                        case PointingArrowRuntime.PointDirection.Right:
                            xMod = objectToPointAt.GetAbsoluteWidth();
                            break;
                        case PointingArrowRuntime.PointDirection.Up:
                            xMod = -objectToPointAt.GetAbsoluteWidth() / 2;
                            break;
                        case PointingArrowRuntime.PointDirection.Down:
                            xMod = -objectToPointAt.GetAbsoluteWidth() / 2;
                            break;
                    }
                }
                
                arrow.CurrentPointDirectionState = direction;
                arrow.X = objectToPointAt.AbsoluteX + xMod;
                arrow.Y = objectToPointAt.AbsoluteY + yMod;
                arrow.Visible = true;
                arrow.FlashAnimation.Play();
            };
        }

        public void Skip()
        {
            _gameScreen.ReadyButtonInstance.Visible = true;

            _gameScreen.PointingArrowInstance.StopAnimations();
            _gameScreen.PointingArrowInstance.Visible = false;

            IsFinished = true;
        }
    }
    
}

