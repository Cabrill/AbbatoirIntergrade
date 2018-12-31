#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
using AbbatoirIntergrade.DataTypes;
using FlatRedBall.IO.Csv;
namespace AbbatoirIntergrade.Screens
{
    public partial class EndingScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static FlatRedBall.Gum.GumIdb EndingScreenGum;
        protected static System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.EndingText> EndingText;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D negative;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D neutral;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D positive;
        protected static System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.EndingCredits> EndingCredits;
        
        private AbbatoirIntergrade.GumRuntimes.EndingScreenGumRuntime EndingScreenGumInstance;
        private AbbatoirIntergrade.GumRuntimes.TextRuntime EndingTextRuntimeInstance;
        private AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime ButtonInstance;
        private AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime EndingTextContainer;
        private AbbatoirIntergrade.GumRuntimes.infodisplays.CurrentMusicDisplayRuntime CurrentMusicDisplayInstance;
        private AbbatoirIntergrade.GumRuntimes.ContainerRuntime CreditsContainer;
        public EndingScreen () 
        	: base ("EndingScreen")
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            EndingScreenGumInstance = EndingScreenGum.GetGraphicalUiElementByName("this") as AbbatoirIntergrade.GumRuntimes.EndingScreenGumRuntime;
            EndingTextRuntimeInstance = EndingScreenGum.GetGraphicalUiElementByName("EndingText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
            ButtonInstance = EndingScreenGum.GetGraphicalUiElementByName("ButtonFrameInstance") as AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime;
            EndingTextContainer = EndingScreenGum.GetGraphicalUiElementByName("EndingTextContainer") as AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime;
            CurrentMusicDisplayInstance = EndingScreenGum.GetGraphicalUiElementByName("CurrentMusicDisplayInstance") as AbbatoirIntergrade.GumRuntimes.infodisplays.CurrentMusicDisplayRuntime;
            CreditsContainer = EndingScreenGum.GetGraphicalUiElementByName("CreditsContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            EndingScreenGum.InstanceInitialize(); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += EndingScreenGum.HandleResolutionChanged;
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            FlatRedBall.SpriteManager.RemoveDrawableBatch(EndingScreenGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= EndingScreenGum.HandleResolutionChanged;
            EndingScreenGum = null;
            EndingText = null;
            negative = null;
            neutral = null;
            positive = null;
            EndingCredits = null;
            
            if (EndingScreenGumInstance != null)
            {
                EndingScreenGumInstance.RemoveFromManagers();
            }
            if (EndingTextRuntimeInstance != null)
            {
                EndingTextRuntimeInstance.RemoveFromManagers();
            }
            if (ButtonInstance != null)
            {
                ButtonInstance.RemoveFromManagers();
            }
            if (EndingTextContainer != null)
            {
                EndingTextContainer.RemoveFromManagers();
            }
            if (CurrentMusicDisplayInstance != null)
            {
                CurrentMusicDisplayInstance.RemoveFromManagers();
            }
            if (CreditsContainer != null)
            {
                CreditsContainer.RemoveFromManagers();
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            if (EndingScreenGumInstance != null)
            {
                EndingScreenGumInstance.RemoveFromManagers();
            }
            if (EndingTextRuntimeInstance != null)
            {
                EndingTextRuntimeInstance.RemoveFromManagers();
            }
            if (ButtonInstance != null)
            {
                ButtonInstance.RemoveFromManagers();
            }
            if (EndingTextContainer != null)
            {
                EndingTextContainer.RemoveFromManagers();
            }
            if (CurrentMusicDisplayInstance != null)
            {
                CurrentMusicDisplayInstance.RemoveFromManagers();
            }
            if (CreditsContainer != null)
            {
                CreditsContainer.RemoveFromManagers();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
        }
        public virtual void ConvertToManuallyUpdated () 
        {
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.GumProject;
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;  EndingScreenGum = new FlatRedBall.Gum.GumIdb();  EndingScreenGum.LoadFromFile("content/gumproject/screens/endingscreengum.gusx");  EndingScreenGum.AssignReferences();Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = false; EndingScreenGum.Element.UpdateLayout(); EndingScreenGum.Element.UpdateLayout();
            if (EndingText == null)
            {
                {
                    // We put the { and } to limit the scope of oldDelimiter
                    char oldDelimiter = FlatRedBall.IO.Csv.CsvFileManager.Delimiter;
                    FlatRedBall.IO.Csv.CsvFileManager.Delimiter = ',';
                    System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.EndingText> temporaryCsvObject = new System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.EndingText>();
                    FlatRedBall.IO.Csv.CsvFileManager.CsvDeserializeDictionary<string, AbbatoirIntergrade.DataTypes.EndingText>("content/screens/endingscreen/endingtext.csv", temporaryCsvObject);
                    FlatRedBall.IO.Csv.CsvFileManager.Delimiter = oldDelimiter;
                    EndingText = temporaryCsvObject;
                }
            }
            negative = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/endingscreen/negative.png", contentManagerName);
            neutral = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/endingscreen/neutral.png", contentManagerName);
            positive = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/endingscreen/positive.png", contentManagerName);
            if (EndingCredits == null)
            {
                {
                    // We put the { and } to limit the scope of oldDelimiter
                    char oldDelimiter = FlatRedBall.IO.Csv.CsvFileManager.Delimiter;
                    FlatRedBall.IO.Csv.CsvFileManager.Delimiter = ',';
                    System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.EndingCredits> temporaryCsvObject = new System.Collections.Generic.Dictionary<string, AbbatoirIntergrade.DataTypes.EndingCredits>();
                    FlatRedBall.IO.Csv.CsvFileManager.CsvDeserializeDictionary<string, AbbatoirIntergrade.DataTypes.EndingCredits>("content/screens/endingscreen/endingcredits.csv", temporaryCsvObject);
                    FlatRedBall.IO.Csv.CsvFileManager.Delimiter = oldDelimiter;
                    EndingCredits = temporaryCsvObject;
                }
            }
            CustomLoadStaticContent(contentManagerName);
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "EndingScreenGum":
                    return EndingScreenGum;
                case  "EndingText":
                    return EndingText;
                case  "negative":
                    return negative;
                case  "neutral":
                    return neutral;
                case  "positive":
                    return positive;
                case  "EndingCredits":
                    return EndingCredits;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "EndingScreenGum":
                    return EndingScreenGum;
                case  "EndingText":
                    return EndingText;
                case  "negative":
                    return negative;
                case  "neutral":
                    return neutral;
                case  "positive":
                    return positive;
                case  "EndingCredits":
                    return EndingCredits;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "EndingScreenGum":
                    return EndingScreenGum;
                case  "negative":
                    return negative;
                case  "neutral":
                    return neutral;
                case  "positive":
                    return positive;
            }
            return null;
        }
    }
}
