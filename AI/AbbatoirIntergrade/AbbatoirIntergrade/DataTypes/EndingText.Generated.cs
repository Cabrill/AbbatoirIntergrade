
namespace AbbatoirIntergrade.DataTypes
{
    public partial class EndingText
    {
        public string EndingName;
        public string EndingWords;
        public const string Positive = "Positive";
        public const string Neutral = "Neutral";
        public const string Negative = "Negative";
        public static System.Collections.Generic.List<System.String> OrderedList = new System.Collections.Generic.List<System.String>
        {
        Positive
        ,Neutral
        ,Negative
        };
        
        
    }
}
