
namespace AbbatoirIntergrade.DataTypes
{
    public partial class EndingCredits
    {
        public string Title;
        public System.Collections.Generic.List<string> Credit = new System.Collections.Generic.List<string>();
        public const string Game_Designer = "Game Designer";
        public const string Character_Design = "Character Design";
        public const string Music = "Music";
        public const string Engine = "Engine";
        public static System.Collections.Generic.List<System.String> OrderedList = new System.Collections.Generic.List<System.String>
        {
        Game_Designer
        ,Character_Design
        ,Music
        ,Engine
        };
        
        
    }
}
