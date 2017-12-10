using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Structures;
using AbbatoirIntergrade.GameClasses;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class PlayerDataManager
    {
        private static PlayerData Data { get; set; }

        public static void LoadData()
        {
            Data = new PlayerData();
            Data.AvailableTowers.Add(typeof(PiercingTower).AssemblyQualifiedName);
            Data.AvailableTowers.Add(typeof(FrostTower).AssemblyQualifiedName);
        }

        public static void SaveData()
        {
            
        }

        public static void AddChosenDialogueId(string id)
        {
            Data.ChosenDialogueIds.Add(id);
        }

        public static void AddShownDialogueId(string id)
        {
            Data.ShownDialogueIds.Add(id);
        }

        public static List<Type> GetAvailableTowers()
        {
            var towerList = new List<Type>();

            foreach (var stringTower in Data.AvailableTowers)
            {
                var towerType = Type.GetType(stringTower);
                if (towerType != null)
                {
                    towerList.Add(towerType);
                }
            }

            return towerList;
        }
    }
}
