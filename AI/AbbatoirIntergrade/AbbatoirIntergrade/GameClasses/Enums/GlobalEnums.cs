using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;

namespace AbbatoirIntergrade
{
    public enum DamageTypes
    {
        Piercing,
        Bombarding,
        Fire,
        Frost,
        Electrical,
        Chemical
    };

    public enum EnemyTypes
    {
        Rabbit1,
        Rabbit2,
        Rabbit3,
        Sheep1,
        Sheep2,
        Sheep3,
        Cow1,
        Cow2,
        Cow3,
        Chicken1,
        Chicken2,
        Chicken3,
        Pig1,
        Pig2,
        Pig3
    };

    public static class EnumExtensions
    {
        private static readonly Dictionary<EnemyTypes, int> PointValues = new Dictionary<EnemyTypes, int>();
        private static readonly Dictionary<EnemyTypes, BaseEnemy.BaseAttributes> EnemyAttributes = new Dictionary<EnemyTypes, BaseEnemy.BaseAttributes>();

        public static int PointValue(this EnemyTypes enemyType)
        {
            if (PointValues.ContainsKey(enemyType)) return PointValues[enemyType];

            var pointValue = 0;
            var pointString = Regex.Replace(enemyType.ToString(), "[^0-9.]", "");
            int.TryParse(pointString, out pointValue);

            PointValues.Add(enemyType, pointValue);

            return pointValue;
        }

        public static BaseEnemy.BaseAttributes Attributes(this EnemyTypes enemyType)
        {
            if (EnemyAttributes.ContainsKey(enemyType)) return EnemyAttributes[enemyType];

            var enemyName = enemyType.ToString();
            var csvEntry = GlobalContent.Enemy_Attributes[enemyName];

            var enemyAttributes = new BaseEnemy.BaseAttributes()
            {
                Health = csvEntry.Health,
                Speed = csvEntry.Speed,

                BombardResist = csvEntry.BombardResist,
                PiercingResist = csvEntry.PiercingResist,
                ChemicalResist = csvEntry.ChemicalResist,
                FrostResist = csvEntry.FrostResist,
                FireResist = csvEntry.FireResist,
                ElectricResist = csvEntry.ElectricResist,
            };

            EnemyAttributes[enemyType] = enemyAttributes;

            return enemyAttributes;
        }
    }
}
