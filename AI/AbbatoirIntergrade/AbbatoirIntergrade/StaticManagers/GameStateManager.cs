using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities;
using AbbatoirIntergrade.Entities.Structures;
using AbbatoirIntergrade.GameClasses;
using AbbatoirIntergrade.GameClasses.BaseClasses;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class GameStateManager
    {
        public static bool HasLoadedData = false;
        private const string TempModelFileName = "DBNModel.obj";
        private const string TempWaveDataFileName = "WaveData.obj";

        public static BaseLevel CurrentLevel;

        public static string CurrentTrackName { get; set; }

        private static GameDialogue _gameDialogue;
        public static GameDialogue GameDialogue
        {
            get
            {
                if (_gameDialogue == null)
                {
                    LoadDialogue();
                }

                return _gameDialogue;
            }
        }

        public static void LoadIfNecessary()
        {
            if (!HasLoadedData) LoadAllGameData();
        }

        private static void LoadAllGameData()
        {
            GeneticsManager.Initialize();
            MachineLearningManager.LoadData(TempModelFileName, TempWaveDataFileName);
            LoadDialogue();
            HasLoadedData = true;
#if DEBUG
            if (DebugVariables.ShouldTestDialogue) TestDialogue();
            if (DebugVariables.ShouldExportDialogue) ExportDialogue();
        }

        private static void TestDialogue()
        {
            var dialogue = GameDialogue.DialogueList;

            for (var i = 0; i < dialogue.Count; i++)
            {
                var current = dialogue[i];

                var ouputs = current.OutputIds;
                var currentOutputCount = current.OutputIds.Count;

                for (var j = 0; j < ouputs.Count; j++)
                {
                    var nextConnection = GameDialogue.ConnectionList.FirstOrDefault(c => c.Source.PinRef == ouputs[j]);
                    if (nextConnection == null) continue;

                    var nextDialogue = dialogue.FirstOrDefault(d => d.Id == nextConnection.Target.IdRef);
                    var nextOutputCount = nextDialogue.OutputIds.Count;

                    if (nextOutputCount == currentOutputCount)
                    {
                        var problemDialogue = current.DisplayText;
                        var problemRetort = nextDialogue.DisplayText;
                    }
                }
            }
        }

        private static void ExportDialogue()
        {
            const string fileName = "dialogue-output.xml";
            FlatRedBall.IO.FileManager.XmlSerialize(GameDialogue, fileName);
        }
#else
        }
#endif


        private static void LoadDialogue()
        {
            const string fileName = "content\\dialogue.xml";

            var doesFileExist = FlatRedBall.IO.FileManager.FileExists(fileName);

            if (doesFileExist)
            {
                _gameDialogue = FlatRedBall.IO.FileManager.XmlDeserialize<GameDialogue>(fileName);
            }
        }

        public static IEnumerable<Type> GetAllTowers()
        {
            var towerList = new List<Type>
            {
                typeof(PiercingTower),
                typeof(BombardingTower),
                typeof(FireTower),
                typeof(FrostTower),
                typeof(ElectricTower),
                typeof(ChemicalTower)
            };

            return towerList;
        }
    }
}
