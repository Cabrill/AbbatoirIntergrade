using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.Structures;
using AbbatoirIntergrade.GameClasses;
using AbbatoirIntergrade.GameClasses.BaseClasses;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class GameStateManager
    {
        public static BaseLevel CurrentLevel;

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
