#if ANDROID || IOS
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using AbbatoirIntergrade.Screens;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using AbbatoirIntergrade.Performance;
using FlatRedBall.Gui;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities;
using AbbatoirIntergrade.Entities.Enemies;
using AbbatoirIntergrade.Entities.GraphicalElements;
using AbbatoirIntergrade.Entities.Projectiles;
using AbbatoirIntergrade.Entities.Structures;
using AbbatoirIntergrade.Factories;
using FlatRedBall;
using FlatRedBall.Screens;
using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall.Math.Geometry;
namespace AbbatoirIntergrade.Entities.GraphicalElements
{
    public partial class StructurePlacement : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Performance.IPoolable, FlatRedBall.Graphics.IVisible, FlatRedBall.Gui.IClickable, FlatRedBall.Math.Geometry.ICollidable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        public enum RollOver
        {
            Uninitialized = 0, //This exists so that the first set call actually does something
            Unknown = 1, //This exists so that if the entity is actually a child entity and has set a child state, you will get this
            CursorOver = 2, 
            CursorOff = 3
        }
        protected int mCurrentRollOverState = 0;
        public Entities.GraphicalElements.StructurePlacement.RollOver CurrentRollOverState
        {
            get
            {
                if (System.Enum.IsDefined(typeof(RollOver), mCurrentRollOverState))
                {
                    return (RollOver)mCurrentRollOverState;
                }
                else
                {
                    return RollOver.Unknown;
                }
            }
            set
            {
                mCurrentRollOverState = (int)value;
                switch(CurrentRollOverState)
                {
                    case  RollOver.Uninitialized:
                        break;
                    case  RollOver.Unknown:
                        break;
                    case  RollOver.CursorOver:
                        SpriteInstanceRed = 0f;
                        SpriteInstanceGreen = 1f;
                        SpriteInstanceBlue = 0f;
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.ColorTextureAlpha;
                        SpriteInstanceTextureScale = 1.5f;
                        break;
                    case  RollOver.CursorOff:
                        SpriteInstanceRed = 0f;
                        SpriteInstanceGreen = 0f;
                        SpriteInstanceBlue = 0f;
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                        SpriteInstanceTextureScale = 1f;
                        break;
                }
            }
        }
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static Microsoft.Xna.Framework.Graphics.Texture2D AllAssetsSheet;
        protected static FlatRedBall.Graphics.Animation.AnimationChainList AnimationChainListFile;
        
        private FlatRedBall.Sprite SpriteInstance;
        private FlatRedBall.Math.Geometry.Circle mCircleInstance;
        public FlatRedBall.Math.Geometry.Circle CircleInstance
        {
            get
            {
                return mCircleInstance;
            }
            private set
            {
                mCircleInstance = value;
            }
        }
        public float SpriteInstanceRed
        {
            get
            {
                return SpriteInstance.Red;
            }
            set
            {
                SpriteInstance.Red = value;
            }
        }
        public float SpriteInstanceGreen
        {
            get
            {
                return SpriteInstance.Green;
            }
            set
            {
                SpriteInstance.Green = value;
            }
        }
        public float SpriteInstanceBlue
        {
            get
            {
                return SpriteInstance.Blue;
            }
            set
            {
                SpriteInstance.Blue = value;
            }
        }
        public FlatRedBall.Graphics.ColorOperation SpriteInstanceColorOperation
        {
            get
            {
                return SpriteInstance.ColorOperation;
            }
            set
            {
                SpriteInstance.ColorOperation = value;
            }
        }
        public float SpriteInstanceTextureScale
        {
            get
            {
                return SpriteInstance.TextureScale;
            }
            set
            {
                SpriteInstance.TextureScale = value;
            }
        }
        public int Index { get; set; }
        public bool Used { get; set; }
        public event System.EventHandler BeforeVisibleSet;
        public event System.EventHandler AfterVisibleSet;
        protected bool mVisible = true;
        public virtual bool Visible
        {
            get
            {
                return mVisible;
            }
            set
            {
                if (BeforeVisibleSet != null)
                {
                    BeforeVisibleSet(this, null);
                }
                mVisible = value;
                if (AfterVisibleSet != null)
                {
                    AfterVisibleSet(this, null);
                }
            }
        }
        public bool IgnoresParentVisibility { get; set; }
        public bool AbsoluteVisible
        {
            get
            {
                return Visible && (Parent == null || IgnoresParentVisibility || Parent is FlatRedBall.Graphics.IVisible == false || (Parent as FlatRedBall.Graphics.IVisible).AbsoluteVisible);
            }
        }
        FlatRedBall.Graphics.IVisible FlatRedBall.Graphics.IVisible.Parent
        {
            get
            {
                if (this.Parent != null && this.Parent is FlatRedBall.Graphics.IVisible)
                {
                    return this.Parent as FlatRedBall.Graphics.IVisible;
                }
                else
                {
                    return null;
                }
            }
        }
        private FlatRedBall.Math.Geometry.ShapeCollection mGeneratedCollision;
        public FlatRedBall.Math.Geometry.ShapeCollection Collision
        {
            get
            {
                return mGeneratedCollision;
            }
        }
        protected FlatRedBall.Graphics.Layer LayerProvidedByContainer = null;
        public StructurePlacement () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public StructurePlacement (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public StructurePlacement (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            SpriteInstance = new FlatRedBall.Sprite();
            SpriteInstance.Name = "SpriteInstance";
            mCircleInstance = new FlatRedBall.Math.Geometry.Circle();
            mCircleInstance.Name = "mCircleInstance";
            
            PostInitialize();
            if (addToManagers)
            {
                AddToManagers(null);
            }
        }
        public virtual void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mCircleInstance, LayerProvidedByContainer);
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mCircleInstance, LayerProvidedByContainer);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            mIsPaused = false;
            
            CustomActivity();
        }
        public virtual void Destroy () 
        {
            if (Used)
            {
                Factories.StructurePlacementFactory.MakeUnused(this, false);
            }
            FlatRedBall.SpriteManager.RemovePositionedObject(this);
            
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (CircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(CircleInstance);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.CopyAbsoluteToRelative();
                SpriteInstance.AttachTo(this, false);
            }
            SpriteInstance.Texture = AllAssetsSheet;
            SpriteInstance.LeftTexturePixel = 2816f;
            SpriteInstance.RightTexturePixel = 2944f;
            SpriteInstance.TopTexturePixel = 3968f;
            SpriteInstance.BottomTexturePixel = 4096f;
            SpriteInstance.TextureScale = 1f;
            SpriteInstance.AnimationChains = AnimationChainListFile;
            SpriteInstance.CurrentChainName = "Spin";
            if (mCircleInstance.Parent == null)
            {
                mCircleInstance.CopyAbsoluteToRelative();
                mCircleInstance.AttachTo(this, false);
            }
            CircleInstance.Radius = 60f;
            CircleInstance.Visible = false;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            mGeneratedCollision.Circles.AddOneWay(mCircleInstance);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (CircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(CircleInstance);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            SpriteInstance.Texture = AllAssetsSheet;
            SpriteInstance.LeftTexturePixel = 2816f;
            SpriteInstance.RightTexturePixel = 2944f;
            SpriteInstance.TopTexturePixel = 3968f;
            SpriteInstance.BottomTexturePixel = 4096f;
            SpriteInstance.TextureScale = 1f;
            SpriteInstance.AnimationChains = AnimationChainListFile;
            SpriteInstance.CurrentChainName = "Spin";
            CircleInstance.Radius = 60f;
            CircleInstance.Visible = false;
            SpriteInstanceRed = 0f;
            SpriteInstanceGreen = 1f;
            SpriteInstanceBlue = 0f;
            SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.ColorTextureAlpha;
            SpriteInstanceTextureScale = 1f;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            ContentManagerName = contentManagerName;
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
            bool registerUnload = false;
            if (LoadedContentManagers.Contains(contentManagerName) == false)
            {
                LoadedContentManagers.Add(contentManagerName);
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("StructurePlacementStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/gamescreen/allassetssheet.png", ContentManagerName))
                {
                    registerUnload = true;
                }
                AllAssetsSheet = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/gamescreen/allassetssheet.png", ContentManagerName);
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/graphicalelements/structureplacement/animationchainlistfile.achx", ContentManagerName))
                {
                    registerUnload = true;
                }
                AnimationChainListFile = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"content/entities/graphicalelements/structureplacement/animationchainlistfile.achx", ContentManagerName);
            }
            if (registerUnload && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("StructurePlacementStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
            }
            CustomLoadStaticContent(contentManagerName);
        }
        public static void UnloadStaticContent () 
        {
            if (LoadedContentManagers.Count != 0)
            {
                LoadedContentManagers.RemoveAt(0);
                mRegisteredUnloads.RemoveAt(0);
            }
            if (LoadedContentManagers.Count == 0)
            {
                if (AllAssetsSheet != null)
                {
                    AllAssetsSheet= null;
                }
                if (AnimationChainListFile != null)
                {
                    AnimationChainListFile= null;
                }
            }
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (RollOver stateToInterpolateTo, double secondsToTake) 
        {
            switch(stateToInterpolateTo)
            {
                case  RollOver.CursorOver:
                    SpriteInstance.RedRate = (0f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (1f - SpriteInstance.Green) / (float)secondsToTake;
                    SpriteInstance.BlueRate = (0f - SpriteInstance.Blue) / (float)secondsToTake;
                    break;
                case  RollOver.CursorOff:
                    SpriteInstance.RedRate = (0f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (0f - SpriteInstance.Green) / (float)secondsToTake;
                    SpriteInstance.BlueRate = (0f - SpriteInstance.Blue) / (float)secondsToTake;
                    break;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<RollOver>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (RollOver stateToStop) 
        {
            switch(stateToStop)
            {
                case  RollOver.CursorOver:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    SpriteInstance.BlueRate =  0;
                    break;
                case  RollOver.CursorOff:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    SpriteInstance.BlueRate =  0;
                    break;
            }
            CurrentRollOverState = stateToStop;
        }
        public void InterpolateBetween (RollOver firstState, RollOver secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setSpriteInstanceRed = true;
            float SpriteInstanceRedFirstValue= 0;
            float SpriteInstanceRedSecondValue= 0;
            bool setSpriteInstanceGreen = true;
            float SpriteInstanceGreenFirstValue= 0;
            float SpriteInstanceGreenSecondValue= 0;
            bool setSpriteInstanceBlue = true;
            float SpriteInstanceBlueFirstValue= 0;
            float SpriteInstanceBlueSecondValue= 0;
            bool setSpriteInstanceTextureScale = true;
            float SpriteInstanceTextureScaleFirstValue= 0;
            float SpriteInstanceTextureScaleSecondValue= 0;
            switch(firstState)
            {
                case  RollOver.CursorOver:
                    SpriteInstanceRedFirstValue = 0f;
                    SpriteInstanceGreenFirstValue = 1f;
                    SpriteInstanceBlueFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.ColorTextureAlpha;
                    }
                    SpriteInstanceTextureScaleFirstValue = 1.5f;
                    break;
                case  RollOver.CursorOff:
                    SpriteInstanceRedFirstValue = 0f;
                    SpriteInstanceGreenFirstValue = 0f;
                    SpriteInstanceBlueFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                    }
                    SpriteInstanceTextureScaleFirstValue = 1f;
                    break;
            }
            switch(secondState)
            {
                case  RollOver.CursorOver:
                    SpriteInstanceRedSecondValue = 0f;
                    SpriteInstanceGreenSecondValue = 1f;
                    SpriteInstanceBlueSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.ColorTextureAlpha;
                    }
                    SpriteInstanceTextureScaleSecondValue = 1.5f;
                    break;
                case  RollOver.CursorOff:
                    SpriteInstanceRedSecondValue = 0f;
                    SpriteInstanceGreenSecondValue = 0f;
                    SpriteInstanceBlueSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                    }
                    SpriteInstanceTextureScaleSecondValue = 1f;
                    break;
            }
            if (setSpriteInstanceRed)
            {
                SpriteInstanceRed = SpriteInstanceRedFirstValue * (1 - interpolationValue) + SpriteInstanceRedSecondValue * interpolationValue;
            }
            if (setSpriteInstanceGreen)
            {
                SpriteInstanceGreen = SpriteInstanceGreenFirstValue * (1 - interpolationValue) + SpriteInstanceGreenSecondValue * interpolationValue;
            }
            if (setSpriteInstanceBlue)
            {
                SpriteInstanceBlue = SpriteInstanceBlueFirstValue * (1 - interpolationValue) + SpriteInstanceBlueSecondValue * interpolationValue;
            }
            if (setSpriteInstanceTextureScale)
            {
                SpriteInstanceTextureScale = SpriteInstanceTextureScaleFirstValue * (1 - interpolationValue) + SpriteInstanceTextureScaleSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentRollOverState = (int)firstState;
            }
            else
            {
                mCurrentRollOverState = (int)secondState;
            }
        }
        public static void PreloadStateContent (RollOver state, string contentManagerName) 
        {
            ContentManagerName = contentManagerName;
            switch(state)
            {
                case  RollOver.CursorOver:
                    break;
                case  RollOver.CursorOff:
                    break;
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
                case  "AnimationChainListFile":
                    return AnimationChainListFile;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
                case  "AnimationChainListFile":
                    return AnimationChainListFile;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "AllAssetsSheet":
                    return AllAssetsSheet;
                case  "AnimationChainListFile":
                    return AnimationChainListFile;
            }
            return null;
        }
        public virtual bool HasCursorOver (FlatRedBall.Gui.Cursor cursor) 
        {
            if (mIsPaused)
            {
                return false;
            }
            if (!AbsoluteVisible)
            {
                return false;
            }
            if (LayerProvidedByContainer != null && LayerProvidedByContainer.Visible == false)
            {
                return false;
            }
            if (!cursor.IsOn(LayerProvidedByContainer))
            {
                return false;
            }
            if (SpriteInstance.Alpha != 0 && SpriteInstance.AbsoluteVisible && cursor.IsOn3D(SpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (cursor.IsOn3D(CircleInstance, LayerProvidedByContainer))
            {
                return true;
            }
            return false;
        }
        public virtual bool WasClickedThisFrame (FlatRedBall.Gui.Cursor cursor) 
        {
            return cursor.PrimaryClick && HasCursorOver(cursor);
        }
        protected bool mIsPaused;
        public override void Pause (FlatRedBall.Instructions.InstructionList instructions) 
        {
            base.Pause(instructions);
            mIsPaused = true;
        }
        public virtual void SetToIgnorePausing () 
        {
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(this);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(CircleInstance);
        }
        public virtual void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer;
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(SpriteInstance);
            }
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(CircleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(CircleInstance, layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
    }
    public static class StructurePlacementExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<StructurePlacement> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
