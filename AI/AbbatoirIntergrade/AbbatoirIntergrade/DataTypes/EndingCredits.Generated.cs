
namespace AbbatoirIntergrade.DataTypes
{
    public partial class EndingCredits
    {
        public string Title;
        public System.Collections.Generic.List<string> Credit = new System.Collections.Generic.List<string>();
        public const string Game_Designer = "Game Designer";
        public const string Character_Design = "Character Design";
        public const string Music = "Music";
        public const string Game_Engine = "Game Engine";
        public const string Development_Support = "Development Support";
        public const string Game_Framework = "Game Framework";
        public const string Level_Design_Software = "Level Design Software";
        public const string Story_Editing_Software = "Story Editing Software";
        public const string Supervisors = "Supervisors";
        public const string Special_Thanks = "Special Thanks";
        public static System.Collections.Generic.List<System.String> OrderedList = new System.Collections.Generic.List<System.String>
        {
        Game_Designer
        ,Character_Design
        ,Music
        ,Game_Engine
        ,Development_Support
        ,Game_Framework
        ,Level_Design_Software
        ,Story_Editing_Software
        ,Supervisors
        ,Special_Thanks
        };
        
        
    }
}
