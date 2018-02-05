using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        [XmlElement("DialogueShownChosen")]
        public SerializableDictionary<string, string> DialogueShownChosen { get; set; } =
            new SerializableDictionary<string, string>();

        [XmlElement("ChapterResults")]
        public List<LevelResult> ChapterResults { get; set; } =
            new List<LevelResult>();

        [XmlIgnore]
        public List<string> ChosenDialogueIds => DialogueShownChosen.Values.ToList();
    }
}
