using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GameClasses
{
    [Serializable]
    public class LevelResult
    {
        public string LevelName;
        public int LevelNumber;

        public DateTime DateTimeStarted;
        public DateTime DateTimeFinished;

        public DateTime InGameDateTime;

        public double TimePlayed;

        public int WavesCompleted;

        public bool WasVictorious;

        public readonly EnemyList EnemiesDefeated= new EnemyList();
    }
}
