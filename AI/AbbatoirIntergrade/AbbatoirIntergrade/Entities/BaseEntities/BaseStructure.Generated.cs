#if ANDROID || IOS
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using AbbatoirIntergrade.Screens;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
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
namespace AbbatoirIntergrade.Entities.BaseEntities
{
    public partial class BaseStructure : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Graphics.IVisible, FlatRedBall.Gui.IClickable, FlatRedBall.Math.Geometry.ICollidable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        public enum VariableState
        {
            Uninitialized = 0, //This exists so that the first set call actually does something
            Unknown = 1, //This exists so that if the entity is actually a child entity and has set a child state, you will get this
            ValidLocation = 2, 
            InvalidLocation = 3, 
            Built = 4, 
            CantAfford = 5, 
            Selected = 6
        }
        protected int mCurrentState = 0;
        public Entities.BaseEntities.BaseStructure.VariableState CurrentState
        {
            get
            {
                if (System.Enum.IsDefined(typeof(VariableState), mCurrentState))
                {
                    return (VariableState)mCurrentState;
                }
                else
                {
                    return VariableState.Unknown;
                }
            }
            set
            {
                mCurrentState = (int)value;
                switch(CurrentState)
                {
                    case  VariableState.Uninitialized:
                        break;
                    case  VariableState.Unknown:
                        break;
                    case  VariableState.ValidLocation:
                        SpriteInstanceRed = 0f;
                        SpriteInstanceGreen = 255f;
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                        break;
                    case  VariableState.InvalidLocation:
                        SpriteInstanceRed = 255f;
                        SpriteInstanceGreen = 0f;
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                        break;
                    case  VariableState.Built:
                        SpriteInstanceRed = 0f;
                        SpriteInstanceGreen = 0f;
                        SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                        break;
                    case  VariableState.CantAfford:
                        SpriteInstanceRed = 255f;
                        SpriteInstanceGreen = 255f;
                        break;
                    case  VariableState.Selected:
                        SpriteInstanceRed = 0f;
                        SpriteInstanceGreen = 255f;
                        break;
                }
            }
        }
        public enum OnOff
        {
            Uninitialized = 0, //This exists so that the first set call actually does something
            Unknown = 1, //This exists so that if the entity is actually a child entity and has set a child state, you will get this
            On = 2, 
            Off = 3
        }
        protected int mCurrentOnOffState = 0;
        public Entities.BaseEntities.BaseStructure.OnOff CurrentOnOffState
        {
            get
            {
                if (System.Enum.IsDefined(typeof(OnOff), mCurrentOnOffState))
                {
                    return (OnOff)mCurrentOnOffState;
                }
                else
                {
                    return OnOff.Unknown;
                }
            }
            set
            {
                mCurrentOnOffState = (int)value;
                switch(CurrentOnOffState)
                {
                    case  OnOff.Uninitialized:
                        break;
                    case  OnOff.Unknown:
                        break;
                    case  OnOff.On:
                        LightSpriteInstanceRed = 1f;
                        LightSpriteInstanceGreen = 1f;
                        LightSpriteInstanceBlue = 1f;
                        break;
                    case  OnOff.Off:
                        LightSpriteInstanceRed = 1f;
                        LightSpriteInstanceGreen = 0.1f;
                        LightSpriteInstanceBlue = 0.1f;
                        break;
                }
            }
        }
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Structure_Placed;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect Building_Destroyed;
        
        protected FlatRedBall.Sprite mSpriteInstance;
        public FlatRedBall.Sprite SpriteInstance
        {
            get
            {
                return mSpriteInstance;
            }
            protected set
            {
                mSpriteInstance = value;
            }
        }
        protected FlatRedBall.Math.Geometry.AxisAlignedRectangle mAxisAlignedRectangleInstance;
        public FlatRedBall.Math.Geometry.AxisAlignedRectangle AxisAlignedRectangleInstance
        {
            get
            {
                return mAxisAlignedRectangleInstance;
            }
            protected set
            {
                mAxisAlignedRectangleInstance = value;
            }
        }
        private AbbatoirIntergrade.Entities.GraphicalElements.Checkmark CheckmarkInstance;
        private AbbatoirIntergrade.Entities.GraphicalElements.XCancel XCancelInstance;
        protected FlatRedBall.Sprite LightSpriteInstance;
        private FlatRedBall.Math.Geometry.Circle mRangeCircleInstance;
        public FlatRedBall.Math.Geometry.Circle RangeCircleInstance
        {
            get
            {
                return mRangeCircleInstance;
            }
            private set
            {
                mRangeCircleInstance = value;
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
        public event System.EventHandler BeforeIsBeingPlacedSet;
        public event System.EventHandler AfterIsBeingPlacedSet;
        bool mIsBeingPlaced = true;
        public bool IsBeingPlaced
        {
            set
            {
                if (BeforeIsBeingPlacedSet != null)
                {
                    BeforeIsBeingPlacedSet(this, null);
                }
                mIsBeingPlaced = value;
                if (AfterIsBeingPlacedSet != null)
                {
                    AfterIsBeingPlacedSet(this, null);
                }
            }
            get
            {
                return mIsBeingPlaced;
            }
        }
        int mInternalBatteryMaxStorage = 0;
        public virtual int InternalBatteryMaxStorage
        {
            set
            {
                mInternalBatteryMaxStorage = value;
            }
            get
            {
                return mInternalBatteryMaxStorage;
            }
        }
        string mDisplayName = "Not Set";
        public virtual string DisplayName
        {
            set
            {
                mDisplayName = value;
            }
            get
            {
                return mDisplayName;
            }
        }
        public virtual bool HasLightSource
        {
            get
            {
                return LightSpriteInstance.Visible;
            }
            set
            {
                LightSpriteInstance.Visible = value;
            }
        }
        public float LightSpriteInstanceRed
        {
            get
            {
                return LightSpriteInstance.Red;
            }
            set
            {
                LightSpriteInstance.Red = value;
            }
        }
        public float LightSpriteInstanceGreen
        {
            get
            {
                return LightSpriteInstance.Green;
            }
            set
            {
                LightSpriteInstance.Green = value;
            }
        }
        public float LightSpriteInstanceBlue
        {
            get
            {
                return LightSpriteInstance.Blue;
            }
            set
            {
                LightSpriteInstance.Blue = value;
            }
        }
        public virtual string StructureDescription { get; set; }
        public System.Double SecondsBetweenFiring;
        public float AttackDamage;
        public float ProjectileSpeed;
        public float RangedRadius
        {
            get
            {
                return RangeCircleInstance.Radius;
            }
            set
            {
                RangeCircleInstance.Radius = value;
            }
        }
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
        public BaseStructure () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public BaseStructure (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public BaseStructure (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            CheckmarkInstance = new AbbatoirIntergrade.Entities.GraphicalElements.Checkmark(ContentManagerName, false);
            CheckmarkInstance.Name = "CheckmarkInstance";
            XCancelInstance = new AbbatoirIntergrade.Entities.GraphicalElements.XCancel(ContentManagerName, false);
            XCancelInstance.Name = "XCancelInstance";
            mRangeCircleInstance = new FlatRedBall.Math.Geometry.Circle();
            mRangeCircleInstance.Name = "mRangeCircleInstance";
            
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
            CheckmarkInstance.ReAddToManagers(LayerProvidedByContainer);
            XCancelInstance.ReAddToManagers(LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mRangeCircleInstance, LayerProvidedByContainer);
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            CheckmarkInstance.AddToManagers(LayerProvidedByContainer);
            XCancelInstance.AddToManagers(LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mRangeCircleInstance, LayerProvidedByContainer);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            mIsPaused = false;
            
            CheckmarkInstance.Activity();
            XCancelInstance.Activity();
            CustomActivity();
        }
        public virtual void Destroy () 
        {
            FlatRedBall.SpriteManager.RemovePositionedObject(this);
            
            if (CheckmarkInstance != null)
            {
                CheckmarkInstance.Destroy();
                CheckmarkInstance.Detach();
            }
            if (XCancelInstance != null)
            {
                XCancelInstance.Destroy();
                XCancelInstance.Detach();
            }
            if (RangeCircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.Remove(RangeCircleInstance);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            this.AfterIsBeingPlacedSet += OnAfterIsBeingPlacedSet;
            if (SpriteInstance!= null)
            {
                if (mSpriteInstance.Parent == null)
                {
                    mSpriteInstance.CopyAbsoluteToRelative();
                    mSpriteInstance.AttachTo(this, false);
                }
                SpriteInstance.TextureScale = 1f;
            }
            if (AxisAlignedRectangleInstance!= null)
            {
                if (mAxisAlignedRectangleInstance.Parent == null)
                {
                    mAxisAlignedRectangleInstance.CopyAbsoluteToRelative();
                    mAxisAlignedRectangleInstance.AttachTo(this, false);
                }
                AxisAlignedRectangleInstance.Width = 64f;
                AxisAlignedRectangleInstance.Height = 64f;
            }
            if (CheckmarkInstance.Parent == null)
            {
                CheckmarkInstance.CopyAbsoluteToRelative();
                CheckmarkInstance.AttachTo(this, false);
            }
            if (CheckmarkInstance.Parent == null)
            {
                CheckmarkInstance.X = -110f;
            }
            else
            {
                CheckmarkInstance.RelativeX = -110f;
            }
            if (CheckmarkInstance.Parent == null)
            {
                CheckmarkInstance.Y = 100f;
            }
            else
            {
                CheckmarkInstance.RelativeY = 100f;
            }
            if (CheckmarkInstance.Parent == null)
            {
                CheckmarkInstance.Z = 5f;
            }
            else
            {
                CheckmarkInstance.RelativeZ = 5f;
            }
            if (XCancelInstance.Parent == null)
            {
                XCancelInstance.CopyAbsoluteToRelative();
                XCancelInstance.AttachTo(this, false);
            }
            if (XCancelInstance.Parent == null)
            {
                XCancelInstance.X = 110f;
            }
            else
            {
                XCancelInstance.RelativeX = 110f;
            }
            if (XCancelInstance.Parent == null)
            {
                XCancelInstance.Y = 100f;
            }
            else
            {
                XCancelInstance.RelativeY = 100f;
            }
            if (XCancelInstance.Parent == null)
            {
                XCancelInstance.Z = 5f;
            }
            else
            {
                XCancelInstance.RelativeZ = 5f;
            }
            if (LightSpriteInstance!= null)
            {
                if (LightSpriteInstance.Parent == null)
                {
                    LightSpriteInstance.CopyAbsoluteToRelative();
                    LightSpriteInstance.AttachTo(this, false);
                }
                if (LightSpriteInstance.Parent == null)
                {
                    LightSpriteInstance.Z = -1f;
                }
                else
                {
                    LightSpriteInstance.RelativeZ = -1f;
                }
                LightSpriteInstance.LeftTexturePixel = 1792f;
                LightSpriteInstance.RightTexturePixel = 2048f;
                LightSpriteInstance.TopTexturePixel = 1792f;
                LightSpriteInstance.BottomTexturePixel = 2048f;
                LightSpriteInstance.TextureScale = 1f;
                #if FRB_MDX
                LightSpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
                #else
                LightSpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                #endif
                LightSpriteInstance.Blue = 0.5f;
                LightSpriteInstance.Alpha = 0.25f;
            }
            if (mRangeCircleInstance.Parent == null)
            {
                mRangeCircleInstance.CopyAbsoluteToRelative();
                mRangeCircleInstance.AttachTo(this, false);
            }
            RangeCircleInstance.Radius = 16f;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            mGeneratedCollision.AxisAlignedRectangles.AddOneWay(mAxisAlignedRectangleInstance);
            mGeneratedCollision.Circles.AddOneWay(mRangeCircleInstance);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            CheckmarkInstance.RemoveFromManagers();
            XCancelInstance.RemoveFromManagers();
            if (RangeCircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(RangeCircleInstance);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                CheckmarkInstance.AssignCustomVariables(true);
                XCancelInstance.AssignCustomVariables(true);
            }
            if (CheckmarkInstance.Parent == null)
            {
                CheckmarkInstance.X = -110f;
            }
            else
            {
                CheckmarkInstance.RelativeX = -110f;
            }
            if (CheckmarkInstance.Parent == null)
            {
                CheckmarkInstance.Y = 100f;
            }
            else
            {
                CheckmarkInstance.RelativeY = 100f;
            }
            if (CheckmarkInstance.Parent == null)
            {
                CheckmarkInstance.Z = 5f;
            }
            else
            {
                CheckmarkInstance.RelativeZ = 5f;
            }
            if (XCancelInstance.Parent == null)
            {
                XCancelInstance.X = 110f;
            }
            else
            {
                XCancelInstance.RelativeX = 110f;
            }
            if (XCancelInstance.Parent == null)
            {
                XCancelInstance.Y = 100f;
            }
            else
            {
                XCancelInstance.RelativeY = 100f;
            }
            if (XCancelInstance.Parent == null)
            {
                XCancelInstance.Z = 5f;
            }
            else
            {
                XCancelInstance.RelativeZ = 5f;
            }
            RangeCircleInstance.Radius = 16f;
            SpriteInstanceRed = 0f;
            SpriteInstanceGreen = 0f;
            SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
            IsBeingPlaced = true;
            InternalBatteryMaxStorage = 0;
            DisplayName = "Not Set";
            HasLightSource = true;
            LightSpriteInstanceRed = 0f;
            LightSpriteInstanceGreen = 0f;
            LightSpriteInstanceBlue = 0.5f;
            RangedRadius = 16f;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            }
            if (AxisAlignedRectangleInstance != null)
            {
            }
            CheckmarkInstance.ConvertToManuallyUpdated();
            XCancelInstance.ConvertToManuallyUpdated();
            if (LightSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(LightSpriteInstance);
            }
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            // Set to use global content
            contentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
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
            if (LoadedContentManagers.Contains(contentManagerName) == false)
            {
                LoadedContentManagers.Add(contentManagerName);
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BaseStructureStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                Structure_Placed = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/structures/structure_placed", ContentManagerName);
                Building_Destroyed = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/structures/building_destroyed", ContentManagerName);
            }
            AbbatoirIntergrade.Entities.GraphicalElements.Checkmark.LoadStaticContent(contentManagerName);
            AbbatoirIntergrade.Entities.GraphicalElements.XCancel.LoadStaticContent(contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }
        public static void UnloadStaticContent () 
        {
            // Intentionally left blank because this element uses global content, so it should never be unloaded
        }
        static VariableState mLoadingState = VariableState.Uninitialized;
        public static VariableState LoadingState
        {
            get
            {
                return mLoadingState;
            }
            set
            {
                mLoadingState = value;
            }
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (VariableState stateToInterpolateTo, double secondsToTake) 
        {
            switch(stateToInterpolateTo)
            {
                case  VariableState.ValidLocation:
                    SpriteInstance.RedRate = (0f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (255f - SpriteInstance.Green) / (float)secondsToTake;
                    break;
                case  VariableState.InvalidLocation:
                    SpriteInstance.RedRate = (255f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (0f - SpriteInstance.Green) / (float)secondsToTake;
                    break;
                case  VariableState.Built:
                    SpriteInstance.RedRate = (0f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (0f - SpriteInstance.Green) / (float)secondsToTake;
                    break;
                case  VariableState.CantAfford:
                    SpriteInstance.RedRate = (255f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (255f - SpriteInstance.Green) / (float)secondsToTake;
                    break;
                case  VariableState.Selected:
                    SpriteInstance.RedRate = (0f - SpriteInstance.Red) / (float)secondsToTake;
                    SpriteInstance.GreenRate = (255f - SpriteInstance.Green) / (float)secondsToTake;
                    break;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<VariableState>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (VariableState stateToStop) 
        {
            switch(stateToStop)
            {
                case  VariableState.ValidLocation:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    break;
                case  VariableState.InvalidLocation:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    break;
                case  VariableState.Built:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    break;
                case  VariableState.CantAfford:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    break;
                case  VariableState.Selected:
                    SpriteInstance.RedRate =  0;
                    SpriteInstance.GreenRate =  0;
                    break;
            }
            CurrentState = stateToStop;
        }
        public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
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
            switch(firstState)
            {
                case  VariableState.ValidLocation:
                    SpriteInstanceRedFirstValue = 0f;
                    SpriteInstanceGreenFirstValue = 255f;
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    break;
                case  VariableState.InvalidLocation:
                    SpriteInstanceRedFirstValue = 255f;
                    SpriteInstanceGreenFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    break;
                case  VariableState.Built:
                    SpriteInstanceRedFirstValue = 0f;
                    SpriteInstanceGreenFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                    }
                    break;
                case  VariableState.CantAfford:
                    SpriteInstanceRedFirstValue = 255f;
                    SpriteInstanceGreenFirstValue = 255f;
                    break;
                case  VariableState.Selected:
                    SpriteInstanceRedFirstValue = 0f;
                    SpriteInstanceGreenFirstValue = 255f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.ValidLocation:
                    SpriteInstanceRedSecondValue = 0f;
                    SpriteInstanceGreenSecondValue = 255f;
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    break;
                case  VariableState.InvalidLocation:
                    SpriteInstanceRedSecondValue = 255f;
                    SpriteInstanceGreenSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
                    }
                    break;
                case  VariableState.Built:
                    SpriteInstanceRedSecondValue = 0f;
                    SpriteInstanceGreenSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.SpriteInstanceColorOperation = FlatRedBall.Graphics.ColorOperation.Texture;
                    }
                    break;
                case  VariableState.CantAfford:
                    SpriteInstanceRedSecondValue = 255f;
                    SpriteInstanceGreenSecondValue = 255f;
                    break;
                case  VariableState.Selected:
                    SpriteInstanceRedSecondValue = 0f;
                    SpriteInstanceGreenSecondValue = 255f;
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
            if (interpolationValue < 1)
            {
                mCurrentState = (int)firstState;
            }
            else
            {
                mCurrentState = (int)secondState;
            }
        }
        public FlatRedBall.Instructions.Instruction InterpolateToState (OnOff stateToInterpolateTo, double secondsToTake) 
        {
            switch(stateToInterpolateTo)
            {
                case  OnOff.On:
                    LightSpriteInstance.RedRate = (1f - LightSpriteInstance.Red) / (float)secondsToTake;
                    LightSpriteInstance.GreenRate = (1f - LightSpriteInstance.Green) / (float)secondsToTake;
                    LightSpriteInstance.BlueRate = (1f - LightSpriteInstance.Blue) / (float)secondsToTake;
                    break;
                case  OnOff.Off:
                    LightSpriteInstance.RedRate = (1f - LightSpriteInstance.Red) / (float)secondsToTake;
                    LightSpriteInstance.GreenRate = (0.1f - LightSpriteInstance.Green) / (float)secondsToTake;
                    LightSpriteInstance.BlueRate = (0.1f - LightSpriteInstance.Blue) / (float)secondsToTake;
                    break;
            }
            var instruction = new FlatRedBall.Instructions.DelegateInstruction<OnOff>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }
        public void StopStateInterpolation (OnOff stateToStop) 
        {
            switch(stateToStop)
            {
                case  OnOff.On:
                    LightSpriteInstance.RedRate =  0;
                    LightSpriteInstance.GreenRate =  0;
                    LightSpriteInstance.BlueRate =  0;
                    break;
                case  OnOff.Off:
                    LightSpriteInstance.RedRate =  0;
                    LightSpriteInstance.GreenRate =  0;
                    LightSpriteInstance.BlueRate =  0;
                    break;
            }
            CurrentOnOffState = stateToStop;
        }
        public void InterpolateBetween (OnOff firstState, OnOff secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setLightSpriteInstanceRed = true;
            float LightSpriteInstanceRedFirstValue= 0;
            float LightSpriteInstanceRedSecondValue= 0;
            bool setLightSpriteInstanceGreen = true;
            float LightSpriteInstanceGreenFirstValue= 0;
            float LightSpriteInstanceGreenSecondValue= 0;
            bool setLightSpriteInstanceBlue = true;
            float LightSpriteInstanceBlueFirstValue= 0;
            float LightSpriteInstanceBlueSecondValue= 0;
            switch(firstState)
            {
                case  OnOff.On:
                    LightSpriteInstanceRedFirstValue = 1f;
                    LightSpriteInstanceGreenFirstValue = 1f;
                    LightSpriteInstanceBlueFirstValue = 1f;
                    break;
                case  OnOff.Off:
                    LightSpriteInstanceRedFirstValue = 1f;
                    LightSpriteInstanceGreenFirstValue = 0.1f;
                    LightSpriteInstanceBlueFirstValue = 0.1f;
                    break;
            }
            switch(secondState)
            {
                case  OnOff.On:
                    LightSpriteInstanceRedSecondValue = 1f;
                    LightSpriteInstanceGreenSecondValue = 1f;
                    LightSpriteInstanceBlueSecondValue = 1f;
                    break;
                case  OnOff.Off:
                    LightSpriteInstanceRedSecondValue = 1f;
                    LightSpriteInstanceGreenSecondValue = 0.1f;
                    LightSpriteInstanceBlueSecondValue = 0.1f;
                    break;
            }
            if (setLightSpriteInstanceRed)
            {
                LightSpriteInstanceRed = LightSpriteInstanceRedFirstValue * (1 - interpolationValue) + LightSpriteInstanceRedSecondValue * interpolationValue;
            }
            if (setLightSpriteInstanceGreen)
            {
                LightSpriteInstanceGreen = LightSpriteInstanceGreenFirstValue * (1 - interpolationValue) + LightSpriteInstanceGreenSecondValue * interpolationValue;
            }
            if (setLightSpriteInstanceBlue)
            {
                LightSpriteInstanceBlue = LightSpriteInstanceBlueFirstValue * (1 - interpolationValue) + LightSpriteInstanceBlueSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentOnOffState = (int)firstState;
            }
            else
            {
                mCurrentOnOffState = (int)secondState;
            }
        }
        public static void PreloadStateContent (VariableState state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            switch(state)
            {
                case  VariableState.ValidLocation:
                    break;
                case  VariableState.InvalidLocation:
                    break;
                case  VariableState.Built:
                    break;
                case  VariableState.CantAfford:
                    break;
                case  VariableState.Selected:
                    break;
            }
        }
        public static void PreloadStateContent (OnOff state, string contentManagerName) 
        {
            ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            switch(state)
            {
                case  OnOff.On:
                    break;
                case  OnOff.Off:
                    break;
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Structure_Placed":
                    return Structure_Placed;
                case  "Building_Destroyed":
                    return Building_Destroyed;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "Structure_Placed":
                    return Structure_Placed;
                case  "Building_Destroyed":
                    return Building_Destroyed;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Structure_Placed":
                    return Structure_Placed;
                case  "Building_Destroyed":
                    return Building_Destroyed;
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
            if (CheckmarkInstance.HasCursorOver(cursor))
            {
                return true;
            }
            if (XCancelInstance.HasCursorOver(cursor))
            {
                return true;
            }
            if (LightSpriteInstance.Alpha != 0 && LightSpriteInstance.AbsoluteVisible && cursor.IsOn3D(LightSpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (cursor.IsOn3D(RangeCircleInstance, LayerProvidedByContainer))
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
            if (SpriteInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            }
            if (AxisAlignedRectangleInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(AxisAlignedRectangleInstance);
            }
            CheckmarkInstance.SetToIgnorePausing();
            XCancelInstance.SetToIgnorePausing();
            if (LightSpriteInstance != null)
            {
                FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightSpriteInstance);
            }
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(RangeCircleInstance);
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
                layerToRemoveFrom.Remove(AxisAlignedRectangleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(AxisAlignedRectangleInstance, layerToMoveTo);
            CheckmarkInstance.MoveToLayer(layerToMoveTo);
            XCancelInstance.MoveToLayer(layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(LightSpriteInstance);
            }
            FlatRedBall.SpriteManager.AddToLayer(LightSpriteInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(RangeCircleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(RangeCircleInstance, layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
    }
    public static class BaseStructureExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<BaseStructure> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
