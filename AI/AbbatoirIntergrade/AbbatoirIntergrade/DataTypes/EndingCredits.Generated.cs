
namespace AbbatoirIntergrade.DataTypes
{
    public partial class EndingCredits
    {
        public string Title;
        public System.Collections.Generic.List<string> Credit = new System.Collections.Generic.List<string>();
        public const string Game_Designer = "Game Designer";
        public const string Character_and_Landscape_Art = "Character and Landscape Art";
        public const string Animation = "Animation";
        public const string Development_Support = "Development Support";
        public const string Music = "Music";
        public const string Game_Engine = "Game Engine";
        public const string Machine_Learning_Framework = "Machine Learning Framework";
        public const string Data_Analytics_Framework = "Data Analytics Framework";
        public const string Game_Framework = "Game Framework";
        public const string Level_Design_Software = "Level Design Software";
        public const string Story_Editing_Software = "Story Editing Software";
        public const string Development_Tools = "Development Tools";
        public const string Supervisors = "Supervisors";
        public const string Special_Thanks = "Special Thanks";
        public static System.Collections.Generic.List<System.String> OrderedList = new System.Collections.Generic.List<System.String>
        {
        Game_Designer
        ,Character_and_Landscape_Art
        ,Animation
        ,Development_Support
        ,Music
        ,Game_Engine
        ,Machine_Learning_Framework
        ,Data_Analytics_Framework
        ,Game_Framework
        ,Level_Design_Software
        ,Story_Editing_Software
        ,Development_Tools
        ,Supervisors
        ,Special_Thanks
        };
        
        
    }
}
