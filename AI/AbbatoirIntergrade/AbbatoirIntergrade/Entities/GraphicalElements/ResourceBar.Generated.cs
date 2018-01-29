#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using AbbatoirIntergrade.Screens;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
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
namespace AbbatoirIntergrade.Entities.GraphicalElements
{
    public partial class ResourceBar : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Graphics.IVisible
    {
        // This is made static so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        
        private FlatRedBall.Sprite BarSprite;
        private FlatRedBall.Sprite FrameSprite;
        private FlatRedBall.Sprite BackgroundSprite;
        public float BarSpriteRed
        {
            get
            {
                return BarSprite.Red;
            }
            set
            {
                BarSprite.Red = value;
            }
        }
        public float BarSpriteGreen
        {
            get
            {
                return BarSprite.Green;
            }
            set
            {
                BarSprite.Green = value;
            }
        }
        public float BarSpriteBlue
        {
            get
            {
                return BarSprite.Blue;
            }
            set
            {
                BarSprite.Blue = value;
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
        protected FlatRedBall.Graphics.Layer LayerProvidedByContainer = null;
        public ResourceBar () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public ResourceBar (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public ResourceBar (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            BarSprite = new FlatRedBall.Sprite();
            BarSprite.Name = "BarSprite";
            FrameSprite = new FlatRedBall.Sprite();
            FrameSprite.Name = "FrameSprite";
            BackgroundSprite = new FlatRedBall.Sprite();
            BackgroundSprite.Name = "BackgroundSprite";
            
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
            FlatRedBall.SpriteManager.AddToLayer(BarSprite, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(FrameSprite, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(BackgroundSprite, LayerProvidedByContainer);
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            FlatRedBall.SpriteManager.AddToLayer(BarSprite, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(FrameSprite, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(BackgroundSprite, LayerProvidedByContainer);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            
            CustomActivity();
        }
        public virtual void Destroy () 
        {
            FlatRedBall.SpriteManager.RemovePositionedObject(this);
            
            if (BarSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(BarSprite);
            }
            if (FrameSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(FrameSprite);
            }
            if (BackgroundSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSprite(BackgroundSprite);
            }
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (BarSprite.Parent == null)
            {
                BarSprite.CopyAbsoluteToRelative();
                BarSprite.AttachTo(this, false);
            }
            BarSprite.TextureScale = 1f;
            BarSprite.Width = 100f;
            BarSprite.Height = 25f;
            #if FRB_MDX
            BarSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Color;
            #else
            BarSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Color;
            #endif
            BarSprite.Green = 1f;
            if (FrameSprite.Parent == null)
            {
                FrameSprite.CopyAbsoluteToRelative();
                FrameSprite.AttachTo(this, false);
            }
            if (FrameSprite.Parent == null)
            {
                FrameSprite.Z = -2f;
            }
            else
            {
                FrameSprite.RelativeZ = -2f;
            }
            FrameSprite.TextureScale = 1f;
            FrameSprite.Width = 101f;
            FrameSprite.Height = 26f;
            #if FRB_MDX
            FrameSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Color;
            #else
            FrameSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Color;
            #endif
            FrameSprite.Red = 1f;
            FrameSprite.Green = 1f;
            FrameSprite.Blue = 1f;
            if (BackgroundSprite.Parent == null)
            {
                BackgroundSprite.CopyAbsoluteToRelative();
                BackgroundSprite.AttachTo(this, false);
            }
            if (BackgroundSprite.Parent == null)
            {
                BackgroundSprite.Z = -1f;
            }
            else
            {
                BackgroundSprite.RelativeZ = -1f;
            }
            BackgroundSprite.TextureScale = 1f;
            BackgroundSprite.Width = 99f;
            BackgroundSprite.Height = 24f;
            #if FRB_MDX
            BackgroundSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Color;
            #else
            BackgroundSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Color;
            #endif
            BackgroundSprite.Alpha = 0.8f;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (BarSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(BarSprite);
            }
            if (FrameSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(FrameSprite);
            }
            if (BackgroundSprite != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(BackgroundSprite);
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            BarSprite.TextureScale = 1f;
            BarSprite.Width = 100f;
            BarSprite.Height = 25f;
            #if FRB_MDX
            BarSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Color;
            #else
            BarSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Color;
            #endif
            BarSprite.Green = 1f;
            if (FrameSprite.Parent == null)
            {
                FrameSprite.Z = -2f;
            }
            else
            {
                FrameSprite.RelativeZ = -2f;
            }
            FrameSprite.TextureScale = 1f;
            FrameSprite.Width = 101f;
            FrameSprite.Height = 26f;
            #if FRB_MDX
            FrameSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Color;
            #else
            FrameSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Color;
            #endif
            FrameSprite.Red = 1f;
            FrameSprite.Green = 1f;
            FrameSprite.Blue = 1f;
            if (BackgroundSprite.Parent == null)
            {
                BackgroundSprite.Z = -1f;
            }
            else
            {
                BackgroundSprite.RelativeZ = -1f;
            }
            BackgroundSprite.TextureScale = 1f;
            BackgroundSprite.Width = 99f;
            BackgroundSprite.Height = 24f;
            #if FRB_MDX
            BackgroundSprite.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Color;
            #else
            BackgroundSprite.ColorOperation = FlatRedBall.Graphics.ColorOperation.Color;
            #endif
            BackgroundSprite.Alpha = 0.8f;
            BarSpriteRed = 0f;
            BarSpriteGreen = 1f;
            BarSpriteBlue = 0f;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(BarSprite);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(FrameSprite);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(BackgroundSprite);
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("ResourceBarStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
            }
            if (registerUnload && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("ResourceBarStaticUnload", UnloadStaticContent);
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
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            return null;
        }
        public static object GetFile (string memberName) 
        {
            return null;
        }
        object GetMember (string memberName) 
        {
            return null;
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
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(BarSprite);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(FrameSprite);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(BackgroundSprite);
        }
        public virtual void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer;
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(BarSprite);
            }
            FlatRedBall.SpriteManager.AddToLayer(BarSprite, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(FrameSprite);
            }
            FlatRedBall.SpriteManager.AddToLayer(FrameSprite, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(BackgroundSprite);
            }
            FlatRedBall.SpriteManager.AddToLayer(BackgroundSprite, layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
    }
    public static class ResourceBarExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<ResourceBar> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
