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

        [XmlElement("ChosenDialogueIds")]
        public List<string> ChosenDialogueIds { get; set; } = new List<string>();

        [XmlElement("ShownDialogueIds")]
        public List<Tuple<string, string>> ShownDialogueIds { get; set; } = new List<Tuple<string, string>>();
    }
}
