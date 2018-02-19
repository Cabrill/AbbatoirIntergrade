#if ANDROID || IOS || DESKTOP_GL
// Android doesn't allow background loading. iOS doesn't allow background rendering (which is used by converting textures to use premult alpha)
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using System.Collections.Generic;
using System.Threading;
using FlatRedBall;
using FlatRedBall.Math.Geometry;
using FlatRedBall.ManagedSpriteGroups;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Utilities;
using BitmapFont = FlatRedBall.Graphics.BitmapFont;
using FlatRedBall.Localization;
using AbbatoirIntergrade.DataTypes;
using FlatRedBall.IO.Csv;

namespace AbbatoirIntergrade
{
    public static partial class GlobalContent
    {
        
        public static FlatRedBall.Gum.GumIdb GumProject { get; set; }
        public static Microsoft.Xna.Framework.Graphics.Texture2D AllUIAssets { get; set; }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_alieninhochiminh;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_alieninhochiminh
        {
            get
            {
                if (manttisinstrumentals_alieninhochiminh == null)
                {
                    manttisinstrumentals_alieninhochiminh = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_alieninhochiminh", ContentManagerName);
                }
                return manttisinstrumentals_alieninhochiminh;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_alittlebell;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_alittlebell
        {
            get
            {
                if (manttisinstrumentals_alittlebell == null)
                {
                    manttisinstrumentals_alittlebell = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_alittlebell", ContentManagerName);
                }
                return manttisinstrumentals_alittlebell;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_aluodetunefish;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_aluodetunefish
        {
            get
            {
                if (manttisinstrumentals_aluodetunefish == null)
                {
                    manttisinstrumentals_aluodetunefish = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_aluodetunefish", ContentManagerName);
                }
                return manttisinstrumentals_aluodetunefish;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_badmorning;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_badmorning
        {
            get
            {
                if (manttisinstrumentals_badmorning == null)
                {
                    manttisinstrumentals_badmorning = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_badmorning", ContentManagerName);
                }
                return manttisinstrumentals_badmorning;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_brokentimesiqnatureinaminor;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_brokentimesiqnatureinaminor
        {
            get
            {
                if (manttisinstrumentals_brokentimesiqnatureinaminor == null)
                {
                    manttisinstrumentals_brokentimesiqnatureinaminor = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_brokentimesiqnatureinaminor", ContentManagerName);
                }
                return manttisinstrumentals_brokentimesiqnatureinaminor;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_crocketttubbs;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_crocketttubbs
        {
            get
            {
                if (manttisinstrumentals_crocketttubbs == null)
                {
                    manttisinstrumentals_crocketttubbs = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_crocketttubbs", ContentManagerName);
                }
                return manttisinstrumentals_crocketttubbs;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_digitalconcertoremake;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_digitalconcertoremake
        {
            get
            {
                if (manttisinstrumentals_digitalconcertoremake == null)
                {
                    manttisinstrumentals_digitalconcertoremake = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_digitalconcertoremake", ContentManagerName);
                }
                return manttisinstrumentals_digitalconcertoremake;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_enoughexcitementforalifetime;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_enoughexcitementforalifetime
        {
            get
            {
                if (manttisinstrumentals_enoughexcitementforalifetime == null)
                {
                    manttisinstrumentals_enoughexcitementforalifetime = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_enoughexcitementforalifetime", ContentManagerName);
                }
                return manttisinstrumentals_enoughexcitementforalifetime;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_fiveminutesofwhy;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_fiveminutesofwhy
        {
            get
            {
                if (manttisinstrumentals_fiveminutesofwhy == null)
                {
                    manttisinstrumentals_fiveminutesofwhy = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_fiveminutesofwhy", ContentManagerName);
                }
                return manttisinstrumentals_fiveminutesofwhy;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_glitchthis;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_glitchthis
        {
            get
            {
                if (manttisinstrumentals_glitchthis == null)
                {
                    manttisinstrumentals_glitchthis = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_glitchthis", ContentManagerName);
                }
                return manttisinstrumentals_glitchthis;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_inmymindiamabigstar;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_inmymindiamabigstar
        {
            get
            {
                if (manttisinstrumentals_inmymindiamabigstar == null)
                {
                    manttisinstrumentals_inmymindiamabigstar = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_inmymindiamabigstar", ContentManagerName);
                }
                return manttisinstrumentals_inmymindiamabigstar;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_irememberyou;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_irememberyou
        {
            get
            {
                if (manttisinstrumentals_irememberyou == null)
                {
                    manttisinstrumentals_irememberyou = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_irememberyou", ContentManagerName);
                }
                return manttisinstrumentals_irememberyou;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_justafaceinthedarkinstrumental;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_justafaceinthedarkinstrumental
        {
            get
            {
                if (manttisinstrumentals_justafaceinthedarkinstrumental == null)
                {
                    manttisinstrumentals_justafaceinthedarkinstrumental = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_justafaceinthedarkinstrumental", ContentManagerName);
                }
                return manttisinstrumentals_justafaceinthedarkinstrumental;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_marchoftheages;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_marchoftheages
        {
            get
            {
                if (manttisinstrumentals_marchoftheages == null)
                {
                    manttisinstrumentals_marchoftheages = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_marchoftheages", ContentManagerName);
                }
                return manttisinstrumentals_marchoftheages;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_melancholysound;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_melancholysound
        {
            get
            {
                if (manttisinstrumentals_melancholysound == null)
                {
                    manttisinstrumentals_melancholysound = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_melancholysound", ContentManagerName);
                }
                return manttisinstrumentals_melancholysound;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_quietlyintothenight;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_quietlyintothenight
        {
            get
            {
                if (manttisinstrumentals_quietlyintothenight == null)
                {
                    manttisinstrumentals_quietlyintothenight = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_quietlyintothenight", ContentManagerName);
                }
                return manttisinstrumentals_quietlyintothenight;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_scrambledeggs;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_scrambledeggs
        {
            get
            {
                if (manttisinstrumentals_scrambledeggs == null)
                {
                    manttisinstrumentals_scrambledeggs = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_scrambledeggs", ContentManagerName);
                }
                return manttisinstrumentals_scrambledeggs;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_sidish;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_sidish
        {
            get
            {
                if (manttisinstrumentals_sidish == null)
                {
                    manttisinstrumentals_sidish = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_sidish", ContentManagerName);
                }
                return manttisinstrumentals_sidish;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_superiorblandcrap;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_superiorblandcrap
        {
            get
            {
                if (manttisinstrumentals_superiorblandcrap == null)
                {
                    manttisinstrumentals_superiorblandcrap = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_superiorblandcrap", ContentManagerName);
                }
                return manttisinstrumentals_superiorblandcrap;
            }
        }
        static Microsoft.Xna.Framework.Media.Song manttisinstrumentals_woman;
        public static Microsoft.Xna.Framework.Media.Song anttisinstrumentals_woman
        {
            get
            {
                if (manttisinstrumentals_woman == null)
                {
                    manttisinstrumentals_woman = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/music/anttisinstrumentals_woman", ContentManagerName);
                }
                return manttisinstrumentals_woman;
            }
        }
        public static System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.Enemy_Attributes> Enemy_Attributes { get; set; }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GumProject":
                    return GumProject;
                case  "AllUIAssets":
                    return AllUIAssets;
                case  "anttisinstrumentals_alieninhochiminh":
                    return anttisinstrumentals_alieninhochiminh;
                case  "anttisinstrumentals_alittlebell":
                    return anttisinstrumentals_alittlebell;
                case  "anttisinstrumentals_aluodetunefish":
                    return anttisinstrumentals_aluodetunefish;
                case  "anttisinstrumentals_badmorning":
                    return anttisinstrumentals_badmorning;
                case  "anttisinstrumentals_brokentimesiqnatureinaminor":
                    return anttisinstrumentals_brokentimesiqnatureinaminor;
                case  "anttisinstrumentals_crocketttubbs":
                    return anttisinstrumentals_crocketttubbs;
                case  "anttisinstrumentals_digitalconcertoremake":
                    return anttisinstrumentals_digitalconcertoremake;
                case  "anttisinstrumentals_enoughexcitementforalifetime":
                    return anttisinstrumentals_enoughexcitementforalifetime;
                case  "anttisinstrumentals_fiveminutesofwhy":
                    return anttisinstrumentals_fiveminutesofwhy;
                case  "anttisinstrumentals_glitchthis":
                    return anttisinstrumentals_glitchthis;
                case  "anttisinstrumentals_inmymindiamabigstar":
                    return anttisinstrumentals_inmymindiamabigstar;
                case  "anttisinstrumentals_irememberyou":
                    return anttisinstrumentals_irememberyou;
                case  "anttisinstrumentals_justafaceinthedarkinstrumental":
                    return anttisinstrumentals_justafaceinthedarkinstrumental;
                case  "anttisinstrumentals_marchoftheages":
                    return anttisinstrumentals_marchoftheages;
                case  "anttisinstrumentals_melancholysound":
                    return anttisinstrumentals_melancholysound;
                case  "anttisinstrumentals_quietlyintothenight":
                    return anttisinstrumentals_quietlyintothenight;
                case  "anttisinstrumentals_scrambledeggs":
                    return anttisinstrumentals_scrambledeggs;
                case  "anttisinstrumentals_sidish":
                    return anttisinstrumentals_sidish;
                case  "anttisinstrumentals_superiorblandcrap":
                    return anttisinstrumentals_superiorblandcrap;
                case  "anttisinstrumentals_woman":
                    return anttisinstrumentals_woman;
                case  "Enemy_Attributes":
                    return Enemy_Attributes;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "GumProject":
                    return GumProject;
                case  "AllUIAssets":
                    return AllUIAssets;
                case  "anttisinstrumentals_alieninhochiminh":
                    return anttisinstrumentals_alieninhochiminh;
                case  "anttisinstrumentals_alittlebell":
                    return anttisinstrumentals_alittlebell;
                case  "anttisinstrumentals_aluodetunefish":
                    return anttisinstrumentals_aluodetunefish;
                case  "anttisinstrumentals_badmorning":
                    return anttisinstrumentals_badmorning;
                case  "anttisinstrumentals_brokentimesiqnatureinaminor":
                    return anttisinstrumentals_brokentimesiqnatureinaminor;
                case  "anttisinstrumentals_crocketttubbs":
                    return anttisinstrumentals_crocketttubbs;
                case  "anttisinstrumentals_digitalconcertoremake":
                    return anttisinstrumentals_digitalconcertoremake;
                case  "anttisinstrumentals_enoughexcitementforalifetime":
                    return anttisinstrumentals_enoughexcitementforalifetime;
                case  "anttisinstrumentals_fiveminutesofwhy":
                    return anttisinstrumentals_fiveminutesofwhy;
                case  "anttisinstrumentals_glitchthis":
                    return anttisinstrumentals_glitchthis;
                case  "anttisinstrumentals_inmymindiamabigstar":
                    return anttisinstrumentals_inmymindiamabigstar;
                case  "anttisinstrumentals_irememberyou":
                    return anttisinstrumentals_irememberyou;
                case  "anttisinstrumentals_justafaceinthedarkinstrumental":
                    return anttisinstrumentals_justafaceinthedarkinstrumental;
                case  "anttisinstrumentals_marchoftheages":
                    return anttisinstrumentals_marchoftheages;
                case  "anttisinstrumentals_melancholysound":
                    return anttisinstrumentals_melancholysound;
                case  "anttisinstrumentals_quietlyintothenight":
                    return anttisinstrumentals_quietlyintothenight;
                case  "anttisinstrumentals_scrambledeggs":
                    return anttisinstrumentals_scrambledeggs;
                case  "anttisinstrumentals_sidish":
                    return anttisinstrumentals_sidish;
                case  "anttisinstrumentals_superiorblandcrap":
                    return anttisinstrumentals_superiorblandcrap;
                case  "anttisinstrumentals_woman":
                    return anttisinstrumentals_woman;
                case  "Enemy_Attributes":
                    return Enemy_Attributes;
            }
            return null;
        }
        public static bool IsInitialized { get; private set; }
        public static bool ShouldStopLoading { get; set; }
        const string ContentManagerName = "Global";
        public static void Initialize () 
        {
            
            FlatRedBall.Gum.GumIdb.StaticInitialize("content/gumproject/gumproject.gumx"); FlatRedBall.Gum.GumIdbExtensions.RegisterTypes();  FlatRedBall.Gui.GuiManager.BringsClickedWindowsToFront = false;FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += (not, used) => { FlatRedBall.Gum.GumIdb.UpdateDisplayToMainFrbCamera(); };Gum.Wireframe.GraphicalUiElement.ShowLineRectangles = false;
            AllUIAssets = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/gumproject/alluiassets.png", ContentManagerName);
            if (Enemy_Attributes == null)
            {
                {
                    // We put the { and } to limit the scope of oldDelimiter
                    char oldDelimiter = FlatRedBall.IO.Csv.CsvFileManager.Delimiter;
                    FlatRedBall.IO.Csv.CsvFileManager.Delimiter = ',';
                    System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.Enemy_Attributes> temporaryCsvObject = new System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.Enemy_Attributes>();
                    FlatRedBall.IO.Csv.CsvFileManager.CsvDeserializeDictionary<string, AbbatoirIntergrade.DataTypes.Enemy_Attributes>("content/entities/enemies/enemy_attributes.csv", temporaryCsvObject);
                    FlatRedBall.IO.Csv.CsvFileManager.Delimiter = oldDelimiter;
                    Enemy_Attributes = temporaryCsvObject;
                }
            }
            			IsInitialized = true;
            #if DEBUG && WINDOWS
            InitializeFileWatch();
            #endif
        }
        public static void Reload (object whatToReload) 
        {
            if (whatToReload == Enemy_Attributes)
            {
                FlatRedBall.IO.Csv.CsvFileManager.UpdateDictionaryValuesFromCsv(Enemy_Attributes, "content/entities/enemies/enemy_attributes.csv");
            }
        }
        #if DEBUG && WINDOWS
        static System.IO.FileSystemWatcher watcher;
        private static void InitializeFileWatch () 
        {
            string globalContent = FlatRedBall.IO.FileManager.RelativeDirectory + "content/globalcontent/";
            if (System.IO.Directory.Exists(globalContent))
            {
                watcher = new System.IO.FileSystemWatcher();
                watcher.Path = globalContent;
                watcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
                watcher.Filter = "*.*";
                watcher.Changed += HandleFileChanged;
                watcher.EnableRaisingEvents = true;
            }
        }
        private static void HandleFileChanged (object sender, System.IO.FileSystemEventArgs e) 
        {
            try
            {
                System.Threading.Thread.Sleep(500);
                var fullFileName = e.FullPath;
                var relativeFileName = FlatRedBall.IO.FileManager.MakeRelative(FlatRedBall.IO.FileManager.Standardize(fullFileName));
                if (relativeFileName == "content/gumproject/gumproject.gumx")
                {
                    Reload(GumProject);
                }
                if (relativeFileName == "content/gumproject/alluiassets.png")
                {
                    Reload(AllUIAssets);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_alieninhochiminh.mp3")
                {
                    Reload(anttisinstrumentals_alieninhochiminh);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_alittlebell.mp3")
                {
                    Reload(anttisinstrumentals_alittlebell);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_aluodetunefish.mp3")
                {
                    Reload(anttisinstrumentals_aluodetunefish);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_badmorning.mp3")
                {
                    Reload(anttisinstrumentals_badmorning);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_brokentimesiqnatureinaminor.mp3")
                {
                    Reload(anttisinstrumentals_brokentimesiqnatureinaminor);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_crocketttubbs.mp3")
                {
                    Reload(anttisinstrumentals_crocketttubbs);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_digitalconcertoremake.mp3")
                {
                    Reload(anttisinstrumentals_digitalconcertoremake);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_enoughexcitementforalifetime.mp3")
                {
                    Reload(anttisinstrumentals_enoughexcitementforalifetime);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_fiveminutesofwhy.mp3")
                {
                    Reload(anttisinstrumentals_fiveminutesofwhy);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_glitchthis.mp3")
                {
                    Reload(anttisinstrumentals_glitchthis);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_inmymindiamabigstar.mp3")
                {
                    Reload(anttisinstrumentals_inmymindiamabigstar);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_irememberyou.mp3")
                {
                    Reload(anttisinstrumentals_irememberyou);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_justafaceinthedarkinstrumental.mp3")
                {
                    Reload(anttisinstrumentals_justafaceinthedarkinstrumental);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_marchoftheages.mp3")
                {
                    Reload(anttisinstrumentals_marchoftheages);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_melancholysound.mp3")
                {
                    Reload(anttisinstrumentals_melancholysound);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_quietlyintothenight.mp3")
                {
                    Reload(anttisinstrumentals_quietlyintothenight);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_scrambledeggs.mp3")
                {
                    Reload(anttisinstrumentals_scrambledeggs);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_sidish.mp3")
                {
                    Reload(anttisinstrumentals_sidish);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_superiorblandcrap.mp3")
                {
                    Reload(anttisinstrumentals_superiorblandcrap);
                }
                if (relativeFileName == "content/globalcontent/music/anttisinstrumentals_woman.mp3")
                {
                    Reload(anttisinstrumentals_woman);
                }
            }
            catch{}
        }
        #endif
        
        
    }
}
