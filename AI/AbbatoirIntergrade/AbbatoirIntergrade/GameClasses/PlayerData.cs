using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.StaticManagers;

namespace AbbatoirIntergrade.GameClasses
{
    [XmlRoot("PlayerData")]
    public class PlayerData
    {
        [XmlElement("PlayerId")]
        public string PlayerId { get; set; } = Guid.NewGuid().ToString("N");

        [XmlElement("CurrentPlayDateTime")]
        public DateTime CurrentPlayDateTime { get; set; } = DateTime.MinValue;

        [XmlElement("PlayTimeInSeconds")]
        public double PlayTimeInSeconds { get; set; }

        [XmlElement("GameLaunchCount")]
        public int GameLaunchCount { get; set; }

        [XmlElement("HasSeenIntro")]
        public bool HasSeenIntro { get; set; }

        [XmlElement("UseFullScreen")]
        public bool UseFullScreen { get; set; } = true;

        [XmlElement("EndingType")]
        public EndingTypes EndingType { get; set; }

        [XmlIgnore]
        public bool HasBeatenGame => EndingType != EndingTypes.None;

        [XmlElement("HasTowerChoiceAvailable")]
        public bool HasTowerChoiceAvailable { get; set; }

        [XmlElement("AvailableTowers")]
        public List<string> AvailableTowers { get; set; } = new List<string>();

        [XmlElement("DialogueShownChosen")]
        public SerializableDictionary<string, string> DialogueShownChosen { get; set; } =
            new SerializableDictionary<string, string>();

        [XmlElement("ChapterResults")]
        public List<LevelResult> ChapterResults { get; set; } =
            new List<LevelResult>();

        [XmlIgnore]
        public List<string> ChosenDialogueIds => DialogueShownChosen.Values.ToList();

        [XmlIgnore]
        public float PercentPositive
        {
            get
            {
                var allChosen = ChosenDialogueIds;
                var allChosenCount = allChosen.Count;
                if (allChosenCount < 1) return 0;

                var positiveChosen =
                    GameStateManager.GameDialogue.DialogueList.Where(
                        d => d.DisplayName.Contains("Positive") && allChosen.Contains(d.Id));
                var positiveChosenCount = positiveChosen.Count();

                return positiveChosenCount / (float)allChosenCount;
             }
        }

        [XmlIgnore]
        public float PercentNeutral
        {
            get
            {
                var allChosen = ChosenDialogueIds;
                var allChosenCount = allChosen.Count;
                if (allChosenCount < 1) return 0;

                var neutralChosen =
                    GameStateManager.GameDialogue.DialogueList.Where(
                        d => d.DisplayName.Contains("Neutral") && allChosen.Contains(d.Id));
                var neutralChosenCount = neutralChosen.Count();

                return neutralChosenCount / (float)allChosenCount;
            }
        }

        [XmlIgnore]
        public float PercentNegative
        {
            get
            {
                var allChosen = ChosenDialogueIds;
                var allChosenCount = allChosen.Count;
                if (allChosenCount < 1) return 0;

                var negativeChosen =
                    GameStateManager.GameDialogue.DialogueList.Where(
                        d => d.DisplayName.Contains("Negative") && allChosen.Contains(d.Id));
                var negativeChosenCount = negativeChosen.Count();

                return negativeChosenCount / (float)allChosenCount;
            }
        }

        [XmlIgnore]
        public float PercentSilent
        {
            get
            {
                var allChosen = ChosenDialogueIds;
                var allChosenCount = allChosen.Count;
                if (allChosenCount < 1) return 0;
                var silentChosen =
                    GameStateManager.GameDialogue.DialogueList.Where(
                        d => d.DisplayName.Contains("Silence") && allChosen.Contains(d.Id));
                var silentChosenCount = silentChosen.Count();

                return silentChosenCount / (float)allChosenCount;
            }
        }

        [XmlElement("PreferredSoundVolume")]
        public float PreferredSoundVolume { get; set; } = 80f;

        [XmlElement("PreferredMusicVolume")]
        public float PreferredMusicVolume { get; set; } = 80f;
    }
}
