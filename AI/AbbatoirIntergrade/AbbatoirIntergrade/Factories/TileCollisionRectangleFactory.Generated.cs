using AbbatoirIntergrade.Entities.GraphicalElements;
using System;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Performance;

namespace AbbatoirIntergrade.Factories
{
    public class TileCollisionRectangleFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static TileCollisionRectangle CreateNew (float x = 0, float y = 0) 
        {
            return CreateNew(null, x, y);
        }
        public static TileCollisionRectangle CreateNew (Layer layer, float x = 0, float y = 0) 
        {
            TileCollisionRectangle instance = null;
            instance = new TileCollisionRectangle(mContentManagerName ?? FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, false);
            instance.AddToManagers(layer);
            instance.X = x;
            instance.Y = y;
            foreach (var list in ListsToAddTo)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X && list is PositionedObjectList<TileCollisionRectangle>)
                {
                    var index = (list as PositionedObjectList<TileCollisionRectangle>).GetFirstAfter(x, Axis.X, 0, list.Count);
                    list.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y && list is PositionedObjectList<TileCollisionRectangle>)
                {
                    var index = (list as PositionedObjectList<TileCollisionRectangle>).GetFirstAfter(y, Axis.Y, 0, list.Count);
                    list.Insert(index, instance);
                }
                else
                {
                    // Sort Z not supported
                    list.Add(instance);
                }
            }
            if (EntitySpawned != null)
            {
                EntitySpawned(instance);
            }
            return instance;
        }
        
        public static void Initialize (string contentManager) 
        {
            mContentManagerName = contentManager;
        }
        
        public static void Destroy () 
        {
            mContentManagerName = null;
            ListsToAddTo.Clear();
            SortAxis = null;
            mPool.Clear();
            EntitySpawned = null;
        }
        
        private static void FactoryInitialize () 
        {
            const int numberToPreAllocate = 20;
            for (int i = 0; i < numberToPreAllocate; i++)
            {
                TileCollisionRectangle instance = new TileCollisionRectangle(mContentManagerName, false);
                mPool.AddToPool(instance);
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (TileCollisionRectangle objectToMakeUnused) 
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (TileCollisionRectangle objectToMakeUnused, bool callDestroy) 
        {
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        public static void AddList<T> (System.Collections.Generic.IList<T> newList) where T : TileCollisionRectangle
        {
            ListsToAddTo.Add(newList as System.Collections.IList);
        }
        public static void RemoveList<T> (System.Collections.Generic.IList<T> newList) where T : TileCollisionRectangle
        {
            ListsToAddTo.Remove(newList as System.Collections.IList);
        }
        public static void ClearListsToAddTo () 
        {
            ListsToAddTo.Clear();
        }
        
        
            static string mContentManagerName;
            static System.Collections.Generic.List<System.Collections.IList> ListsToAddTo = new System.Collections.Generic.List<System.Collections.IList>();
            static PoolList<TileCollisionRectangle> mPool = new PoolList<TileCollisionRectangle>();
            public static Action<TileCollisionRectangle> EntitySpawned;
            object IEntityFactory.CreateNew () 
            {
                return TileCollisionRectangleFactory.CreateNew();
            }
            object IEntityFactory.CreateNew (Layer layer) 
            {
                return TileCollisionRectangleFactory.CreateNew(layer);
            }
            void IEntityFactory.Initialize (string contentManagerName) 
            {
                TileCollisionRectangleFactory.Initialize(contentManagerName);
            }
            void IEntityFactory.ClearListsToAddTo () 
            {
                TileCollisionRectangleFactory.ClearListsToAddTo();
            }
            static TileCollisionRectangleFactory mSelf;
            public static TileCollisionRectangleFactory Self
            {
                get
                {
                    if (mSelf == null)
                    {
                        mSelf = new TileCollisionRectangleFactory();
                    }
                    return mSelf;
                }
            }
    }
}
