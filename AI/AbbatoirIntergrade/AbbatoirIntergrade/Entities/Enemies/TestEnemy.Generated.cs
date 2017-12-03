#if ANDROID || IOS
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif

using Color = Microsoft.Xna.Framework.Color;

namespace GBC2017.Entities.Enemies
{
	public partial class TestEnemy : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable
	{
        // This is made static so that static lazy-loaded content can access it.
        public static string ContentManagerName
        {
            get;
            set;
        }

		// Generated Fields
		#if DEBUG
		static bool HasBeenLoadedWithGlobalContentManager = false;
		#endif
		static object mLockObject = new object();
		static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
		static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
		protected static Microsoft.Xna.Framework.Graphics.Texture2D AllAssetsSheet;
		
		private FlatRedBall.Sprite mSpriteInstance;
		public FlatRedBall.Sprite SpriteInstance
		{
			get
			{
				return mSpriteInstance;
			}
			private set
			{
				mSpriteInstance = value;
			}
		}
		protected FlatRedBall.Graphics.Layer LayerProvidedByContainer = null;

        public TestEnemy()
            : this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {

        }

        public TestEnemy(string contentManagerName) :
            this(contentManagerName, true)
        {
        }


        public TestEnemy(string contentManagerName, bool addToManagers) :
			base()
		{
			// Don't delete this:
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);

		}

		protected virtual void InitializeEntity(bool addToManagers)
		{
			// Generated Initialize
			LoadStaticContent(ContentManagerName);
			mSpriteInstance = new FlatRedBall.Sprite();
			mSpriteInstance.Name = "mSpriteInstance";
			
			PostInitialize();
			if (addToManagers)
			{
				AddToManagers(null);
			}


		}

// Generated AddToManagers
		public virtual void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo)
		{
			LayerProvidedByContainer = layerToAddTo;
			FlatRedBall.SpriteManager.AddPositionedObject(this);
			FlatRedBall.SpriteManager.AddToLayer(mSpriteInstance, LayerProvidedByContainer);
		}
		public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo)
		{
			LayerProvidedByContainer = layerToAddTo;
			FlatRedBall.SpriteManager.AddPositionedObject(this);
			FlatRedBall.SpriteManager.AddToLayer(mSpriteInstance, LayerProvidedByContainer);
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
			
			if (SpriteInstance != null)
			{
				FlatRedBall.SpriteManager.RemoveSprite(SpriteInstance);
			}
			CustomDestroy();
		}
		public virtual void PostInitialize ()
		{
			bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
			if (mSpriteInstance.Parent == null)
			{
				mSpriteInstance.CopyAbsoluteToRelative();
				mSpriteInstance.AttachTo(this, false);
			}
			SpriteInstance.Texture = AllAssetsSheet;
			SpriteInstance.LeftTexturePixel = 1825f;
			SpriteInstance.RightTexturePixel = 2043f;
			SpriteInstance.TopTexturePixel = -10f;
			SpriteInstance.BottomTexturePixel = 268f;
			SpriteInstance.TextureScale = 1f;
			SpriteInstance.IgnoreAnimationChainTextureFlip = true;
			#if FRB_MDX
			SpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
			#else
			SpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
			#endif
			SpriteInstance.Red = 0f;
			SpriteInstance.Green = 255f;
			SpriteInstance.Blue = 0f;
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
		}
		public virtual void AssignCustomVariables (bool callOnContainedElements)
		{
			if (callOnContainedElements)
			{
			}
			SpriteInstance.Texture = AllAssetsSheet;
			SpriteInstance.LeftTexturePixel = 1825f;
			SpriteInstance.RightTexturePixel = 2043f;
			SpriteInstance.TopTexturePixel = -10f;
			SpriteInstance.BottomTexturePixel = 268f;
			SpriteInstance.TextureScale = 1f;
			SpriteInstance.IgnoreAnimationChainTextureFlip = true;
			#if FRB_MDX
			SpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
			#else
			SpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
			#endif
			SpriteInstance.Red = 0f;
			SpriteInstance.Green = 255f;
			SpriteInstance.Blue = 0f;
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
						FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("TestEnemyStaticUnload", UnloadStaticContent);
						mRegisteredUnloads.Add(ContentManagerName);
					}
				}
				if (!FlatRedBall.FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/globalcontent/allassetssheet.png", ContentManagerName))
				{
					registerUnload = true;
				}
				AllAssetsSheet = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/globalcontent/allassetssheet.png", ContentManagerName);
			}
			if (registerUnload && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
			{
				lock (mLockObject)
				{
					if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
					{
						FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("TestEnemyStaticUnload", UnloadStaticContent);
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
			}
		}
		[System.Obsolete("Use GetFile instead")]
		public static object GetStaticMember (string memberName)
		{
			switch(memberName)
			{
				case  "AllAssetsSheet":
					return AllAssetsSheet;
			}
			return null;
		}
		public static object GetFile (string memberName)
		{
			switch(memberName)
			{
				case  "AllAssetsSheet":
					return AllAssetsSheet;
			}
			return null;
		}
		object GetMember (string memberName)
		{
			switch(memberName)
			{
				case  "AllAssetsSheet":
					return AllAssetsSheet;
			}
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
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
		}
		public virtual void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo)
		{
			var layerToRemoveFrom = LayerProvidedByContainer;
			if (layerToRemoveFrom != null)
			{
				layerToRemoveFrom.Remove(SpriteInstance);
			}
			FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, layerToMoveTo);
			LayerProvidedByContainer = layerToMoveTo;
		}


    }
	
	
	// Extra classes
	
}
