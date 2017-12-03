using AbbatoirIntergrade.Entities.GraphicalElements;
using System;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Performance;

namespace AbbatoirIntergrade.Factories
{
    public class StructurePlacementFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static StructurePlacement CreateNew (float x = 0, float y = 0) 
        {
            return CreateNew(null, x, y);
        }
        public static StructurePlacement CreateNew (Layer layer, float x = 0, float y = 0) 
        {
            if (string.IsNullOrEmpty(mContentManagerName))
            {
                throw new System.Exception("You must first initialize the factory to use it. You can either add PositionedObjectList of type StructurePlacement (the most common solution) or call Initialize in custom code");
            }
            StructurePlacement instance = null;
            instance = new StructurePlacement(mContentManagerName, false);
            instance.AddToManagers(layer);
            instance.X = x;
            instance.Y = y;
            foreach (var list in listsToAddTo)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X && list is PositionedObjectList<StructurePlacement>)
                {
                    var index = (list as PositionedObjectList<StructurePlacement>).GetFirstAfter(x, Axis.X, 0, list.Count);
                    list.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y && list is PositionedObjectList<StructurePlacement>)
                {
                    var index = (list as PositionedObjectList<StructurePlacement>).GetFirstAfter(y, Axis.Y, 0, list.Count);
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
                StructurePlacement instance = new StructurePlacement(mContentManagerName, false);
                mPool.AddToPool(instance);
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (StructurePlacement objectToMakeUnused) 
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (StructurePlacement objectToMakeUnused, bool callDestroy) 
        {
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        public static void AddList<T> (System.Collections.Generic.IList<T> newList) where T : StructurePlacement
        {
            listsToAddTo.Add(newList as System.Collections.IList);
        }
        
        
            static string mContentManagerName;
            static System.Collections.Generic.List<System.Collections.IList> listsToAddTo = new System.Collections.Generic.List<System.Collections.IList>();
            static PoolList<StructurePlacement> mPool = new PoolList<StructurePlacement>();
            public static Action<StructurePlacement> EntitySpawned;
            object IEntityFactory.CreateNew () 
            {
                return StructurePlacementFactory.CreateNew();
            }
            object IEntityFactory.CreateNew (Layer layer) 
            {
                return StructurePlacementFactory.CreateNew(layer);
            }
            static StructurePlacementFactory mSelf;
            public static StructurePlacementFactory Self
            {
                get
                {
                    if (mSelf == null)
                    {
                        mSelf = new StructurePlacementFactory();
                    }
                    return mSelf;
                }
            }
    }
}
