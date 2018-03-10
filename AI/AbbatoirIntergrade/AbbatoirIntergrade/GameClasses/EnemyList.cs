using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.UtilityClasses;

namespace AbbatoirIntergrade.GameClasses
{
    [Serializable]
    public class EnemyList : IEquatable<EnemyList>
    {
        public List<EnemyTypes> EnemyTypesInList
        {
            get
            {
                var enemyTypeHash = new HashSet<EnemyTypes>();
                foreach (var t in EnemyCountTuples)
                {
                    enemyTypeHash.Add(t.Item2);
                }
                return enemyTypeHash.ToList();
            }
        }

        public int TotalEnemies => EnemyCountTuples.Sum(w => w.Item1);

        public double LowestPointValue => EnemyCountTuples.Min(et => et.Item2.PointValue());

        public readonly List<SerializableTuple<int, EnemyTypes>> EnemyCountTuples;

        public EnemyList()
        {
            EnemyCountTuples = new List<SerializableTuple<int, EnemyTypes>>();
        }

        public EnemyList(List<SerializableTuple<int, EnemyTypes>> enemyList)
        {
            EnemyCountTuples = enemyList;
        }

        public EnemyList(EnemyTypes enemyType, int numberOfEnemyType = 1)
        {
            EnemyCountTuples = new List<SerializableTuple<int, EnemyTypes>>();
            Add(enemyType, numberOfEnemyType);
        }

        public void Add(EnemyTypes enemyType, int numberToAdd = 1)
        {
            var existingEnemyIndex = EnemyCountTuples.FindIndex(e => e.Item2 == enemyType);
            if (existingEnemyIndex >= 0)
            {
                EnemyCountTuples[existingEnemyIndex] = new SerializableTuple<int, EnemyTypes>(EnemyCountTuples[existingEnemyIndex].Item1 + numberToAdd, enemyType);
            }
            else
            {
                EnemyCountTuples.Add(new SerializableTuple<int, EnemyTypes>(numberToAdd, enemyType));
            }
        }

        public bool Equals(EnemyList other)
        {
            if (TotalEnemies != other.TotalEnemies) return false;
            if (EnemyTypesInList.Count != other.EnemyTypesInList.Count) return false;

            foreach (var enemyType in EnemyTypesInList)
            {
                if (CountOf(enemyType) != other.CountOf(enemyType)) return false;
            }
            return true;
        }

        private int CountOf(EnemyTypes enemyType)
        {
            return EnemyCountTuples.Where(ect => ect.Item2 == enemyType).Sum(ect => ect.Item1);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EnemyList) obj);
        }

        public override int GetHashCode()
        {
            var hash = 0;
            var multiplier = 1;
            foreach (EnemyTypes enemyType in Enum.GetValues(typeof(EnemyTypes)))
            {
                hash += CountOf(enemyType) * multiplier;
                multiplier *= 10;
            }
            
            return hash;
        }
    }
}
