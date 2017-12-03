using AbbatoirIntergrade.Entities.Enemies;
using System;
using AbbatoirIntergrade.Entities.BaseEntities;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Performance;

namespace AbbatoirIntergrade.Factories
{
    public class SmallSlimeFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static SmallSlime CreateNew (float x = 0, float y = 0) 
        {
            return CreateNew(null, x, y);
        }
        public static SmallSlime CreateNew (Layer layer, float x = 0, float y = 0) 
        {
            if (string.IsNullOrEmpty(mContentManagerName))
            {
                throw new System.Exception("You must first initialize the factory to use it. You can either add PositionedObjectList of type SmallSlime (the most common solution) or call Initialize in custom code");
            }
            SmallSlime instance = null;
            instance = mPool.GetNextAvailable();
            if (instance == null)
            {
                mPool.AddToPool(new SmallSlime(mContentManagerName, false));
                instance =  mPool.GetNextAvailable();
            }
            instance.AddToManagers(layer);
            instance.X = x;
            instance.Y = y;
            foreach (var list in listsToAddTo)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X && list is PositionedObjectList<SmallSlime>)
                {
                    var index = (list as PositionedObjectList<SmallSlime>).GetFirstAfter(x, Axis.X, 0, list.Count);
                    list.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y && list is PositionedObjectList<SmallSlime>)
                {
                    var index = (list as PositionedObjectList<SmallSlime>).GetFirstAfter(y, Axis.Y, 0, list.Count);
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
            FactoryInitialize();
        }
        
        public static void Destroy () 
        {
            mContentManagerName = null;
            listsToAddTo.Clear();
            SortAxis = null;
            mPool.Clear();
            EntitySpawned = null;
        }
        
        private static void FactoryInitialize () 
        {
            const int numberToPreAllocate = 20;
            for (int i = 0; i < numberToPreAllocate; i++)
            {
                SmallSlime instance = new SmallSlime(mContentManagerName, false);
                mPool.AddToPool(instance);
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (SmallSlime objectToMakeUnused) 
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (SmallSlime objectToMakeUnused, bool callDestroy) 
        {
            mPool.MakeUnused(objectToMakeUnused);
            
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        public static void AddList<T> (System.Collections.Generic.IList<T> newList) where T : Entities.BaseEntities.BaseEnemy
        {
            listsToAddTo.Add(newList as System.Collections.IList);
        }
        
        
            static string mContentManagerName;
            static System.Collections.Generic.List<System.Collections.IList> listsToAddTo = new System.Collections.Generic.List<System.Collections.IList>();
            static PoolList<SmallSlime> mPool = new PoolList<SmallSlime>();
            public static Action<SmallSlime> EntitySpawned;
            object IEntityFactory.CreateNew () 
            {
                return SmallSlimeFactory.CreateNew();
            }
            object IEntityFactory.CreateNew (Layer layer) 
            {
                return SmallSlimeFactory.CreateNew(layer);
            }
            static SmallSlimeFactory mSelf;
            public static SmallSlimeFactory Self
            {
                get
                {
                    if (mSelf == null)
                    {
                        mSelf = new SmallSlimeFactory();
                    }
                    return mSelf;
                }
            }
    }
}
