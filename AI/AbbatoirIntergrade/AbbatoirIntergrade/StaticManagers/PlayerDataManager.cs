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
        private static string LastShownDialogueId;
        public static string LastChosenDialogueId;

        public static SerializableDictionary<string, string> DialogueHistory => Data.ShownDialogueIds;

        public static void LoadData()
        {
            Data = new PlayerData();
            Data.AvailableTowers.Add(typeof(PiercingTower).AssemblyQualifiedName);
            Data.AvailableTowers.Add(typeof(BombardingTower).AssemblyQualifiedName);
            Data.AvailableTowers.Add(typeof(FireTower).AssemblyQualifiedName);
            Data.AvailableTowers.Add(typeof(FrostTower).AssemblyQualifiedName);
            Data.AvailableTowers.Add(typeof(ElectricTower).AssemblyQualifiedName);
            Data.AvailableTowers.Add(typeof(ChemicalTower).AssemblyQualifiedName);

            Reset();
        }

        public static void Reset()
        {
            LastShownDialogueId = "";
            LastChosenDialogueId = "";
        }

        public static void SaveData()
        {
            
        }

        public static void AddChosenDialogueId(string id)
        {
            if (Data.ShownDialogueIds.ContainsKey(LastShownDialogueId))
            {
                Data.ShownDialogueIds[LastShownDialogueId] = id;
            }
#if DEBUG
            else
            {
                throw new NullReferenceException("Shown dialogue was missing!");
            }
#endif
            LastChosenDialogueId = id;
        }

        public static void AddShownDialogueId(string id)
        {
            Data.ShownDialogueIds[id] = "";
            //Data.ShownDialogueIds.Add(Tuple.Create(id, ""));
            LastShownDialogueId = id;
            LastChosenDialogueId = "";
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
