using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AbbatoirIntergrade.Entities.BaseEntities;

namespace AbbatoirIntergrade.GameClasses
{
    [XmlRoot("PlayerData")]
    public class PlayerData
    {
        [XmlElement("AvailableTowers")]
        public List<string> AvailableTowers { get; set; } = new List<string>();

        [XmlElement("LastChapter")]
        public int LastChapter { get; set; }

        [XmlIgnore]
        public List<string> ChosenDialogueIds => DialogueShownChosen.Values.ToList();

        [XmlElement("DialogueShownChosen")]
        public SerializableDictionary<string, string> DialogueShownChosen { get; set; } = new SerializableDictionary<string, string>();

        [XmlElement("ChapterResults")]
        public SerializableDictionary<string, int> ChapterResults { get; set; } = new SerializableDictionary<string, int>();
    }
}
