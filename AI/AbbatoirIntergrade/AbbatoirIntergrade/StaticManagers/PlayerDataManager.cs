using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Structures;
using AbbatoirIntergrade.GameClasses;
using AbbatoirIntergrade.MachineLearning.Models;
using Accord.Neuro.Networks;
using MoreLinq;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class PlayerDataManager
    {
        private static PlayerData Data { get; set; }
        private static string LastShownDialogueId;
        public static string LastChosenDialogueId;

        public static List<LevelResult> LevelResults => Data.ChapterResults;
        public static int LastLevelNumberCompleted => Data.ChapterResults.Count == 0 ? 0 : Data.ChapterResults.Max(lr => lr.LevelNumber);
        public static string LastLevelNameCompleted => Data.ChapterResults.Count == 0 ? "" : Data.ChapterResults.MaxBy(lr => lr.LevelNumber).LevelName;

        public static SerializableDictionary<string, string> DialogueHistory => Data.DialogueShownChosen;
        public static float PositiveDialoguePercent => Data.PercentPositive;
        public static float NeutralDialoguePercent => Data.PercentNeutral;
        public static float NegativeDialoguePercent => Data.PercentNegative;
        public static float SilentDialoguePercent => Data.PercentSilent;

        private const string SaveFileName = "PlayerSave.xml";

        public static int PlayerEndingReached => Data.GotPositiveEnding ? 1 : Data.GotNegativeEnding ? -1 : 0;
        public static bool PlayerHasSeenIntro => Data.HasSeenIntro;

        private static readonly List<string> AllPossibleTowers = new List<string>()
        {
            typeof(PiercingTower).AssemblyQualifiedName,
            typeof(ElectricTower).AssemblyQualifiedName,
            typeof(FireTower).AssemblyQualifiedName,
            typeof(ChemicalTower).AssemblyQualifiedName,
            typeof(FrostTower).AssemblyQualifiedName,
            typeof(BombardingTower).AssemblyQualifiedName,
        };

        public static void SaveData()
        {
            FlatRedBall.IO.FileManager.XmlSerialize(Data, SaveFileName);

            FlatRedBall.Debugging.Debugger.CommandLineWrite("Saved " + SaveFileName);
        }

        public static void LoadData()
        {
            var doesFileExist = FlatRedBall.IO.FileManager.FileExists(SaveFileName);

            if (doesFileExist)
            {
                Data = FlatRedBall.IO.FileManager.XmlDeserialize<PlayerData>(SaveFileName);
            }
            else
            {
                InitializeNewData();
            }

            SoundManager.MusicVolumeLevel = Data.PreferredMusicVolume;
            SoundManager.SoundVolumeLevel = Data.PreferredSoundVolume;
        }

        private static void InitializeNewData()
        {
            Data = new PlayerData();
            Data.AvailableTowers.Add(typeof(PiercingTower).AssemblyQualifiedName);

            Reset();
        }

        public static void Reset()
        {
            LastShownDialogueId = "";
            LastChosenDialogueId = "";
        }

        public static void AddChosenDialogueId(string id)
        {
            if (Data.DialogueShownChosen.ContainsKey(LastShownDialogueId))
            {
                Data.DialogueShownChosen[LastShownDialogueId] = id;
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
            Data.DialogueShownChosen[id] = "";
            LastShownDialogueId = id;
            LastChosenDialogueId = "";
        }

        public static void AllowPlayerNewTowerChoice()
        {
            Data.HasTowerChoiceAvailable = Data.AvailableTowers.Count < AllPossibleTowers.Count;
        }

        public static List<Type> GetPossibleNewTowers()
        {
            if (!Data.HasTowerChoiceAvailable) return new List<Type>();

            var currentTowers = Data.AvailableTowers;
            var possibleTowers = AllPossibleTowers.ToList();
            possibleTowers.RemoveAll(t => currentTowers.Contains(t));

            return possibleTowers.Select(Type.GetType).Where(towerType => towerType != null).ToList();
        }

        public static void AddTowerAvailability(Type towerType)
        {
            if (Data.HasTowerChoiceAvailable)
            {
                Data.AvailableTowers.Add(towerType.AssemblyQualifiedName);
                Data.HasTowerChoiceAvailable = false;
            }
        }

        public static List<Type> GetAvailableTowers()
        {
            if (Data == null) LoadData();
            return Data.AvailableTowers.Select(Type.GetType).Where(towerType => towerType != null).ToList();
        }

        public static void RecordChapterResults(LevelResult result)
        {
            var existingResultIndex = Data.ChapterResults.FindIndex(l => l.LevelNumber == result.LevelNumber);
            if (existingResultIndex > -1)
            {
                Data.ChapterResults.RemoveAt(existingResultIndex);
            }
            Data.ChapterResults.Add(result);
        }

        public static void MarkPlayerReachedEnding(int endingValue)
        {

            Data.GotPositiveEnding = endingValue > 0;

            Data.GotNeutralEnding = endingValue == 0;
            Data.GotNegativeEnding = endingValue < 0;
        }

        public static void MarkSeenIntro()
        {
            Data.HasSeenIntro = true;
        }
    }
}
