using AbbatoirIntergrade.Entities.Enemies;
using System;
using AbbatoirIntergrade.Entities.BaseEntities;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Performance;

namespace AbbatoirIntergrade.Factories
{
    public class Pig2EnemyFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static Pig2Enemy CreateNew (float x = 0, float y = 0) 
        {
            return CreateNew(null, x, y);
        }
        public static Pig2Enemy CreateNew (Layer layer, float x = 0, float y = 0) 
        {
            Pig2Enemy instance = null;
            if (string.IsNullOrEmpty(mContentManagerName))
            {
                throw new System.Exception("You must first initialize the factory for this type because it is pooled. You can either add PositionedObjectList of type Pig2Enemy (the most common solution) or call Initialize in custom code");
            }
            instance = mPool.GetNextAvailable();
            if (instance == null)
            {
                mPool.AddToPool(new Pig2Enemy(mContentManagerName, false));
                instance =  mPool.GetNextAvailable();
            }
            instance.AddToManagers(layer);
            instance.X = x;
            instance.Y = y;
            foreach (var list in ListsToAddTo)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X && list is PositionedObjectList<Pig2Enemy>)
                {
                    var index = (list as PositionedObjectList<Pig2Enemy>).GetFirstAfter(x, Axis.X, 0, list.Count);
                    list.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y && list is PositionedObjectList<Pig2Enemy>)
                {
                    var index = (list as PositionedObjectList<Pig2Enemy>).GetFirstAfter(y, Axis.Y, 0, list.Count);
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
                Pig2Enemy instance = new Pig2Enemy(mContentManagerName, false);
                mPool.AddToPool(instance);
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (Pig2Enemy objectToMakeUnused) 
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (Pig2Enemy objectToMakeUnused, bool callDestroy) 
        {
            mPool.MakeUnused(objectToMakeUnused);
            
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        public static void AddList<T> (System.Collections.Generic.IList<T> newList) where T : Entities.BaseEntities.BaseEnemy
        {
            ListsToAddTo.Add(newList as System.Collections.IList);
        }
        public static void RemoveList<T> (System.Collections.Generic.IList<T> newList) where T : Entities.BaseEntities.BaseEnemy
        {
            ListsToAddTo.Remove(newList as System.Collections.IList);
        }
        public static void ClearListsToAddTo () 
        {
            ListsToAddTo.Clear();
        }
        
        
            static string mContentManagerName;
            static System.Collections.Generic.List<System.Collections.IList> ListsToAddTo = new System.Collections.Generic.List<System.Collections.IList>();
            static PoolList<Pig2Enemy> mPool = new PoolList<Pig2Enemy>();
            public static Action<Pig2Enemy> EntitySpawned;
            object IEntityFactory.CreateNew () 
            {
                return Pig2EnemyFactory.CreateNew();
            }
            object IEntityFactory.CreateNew (Layer layer) 
            {
                return Pig2EnemyFactory.CreateNew(layer);
            }
            void IEntityFactory.Initialize (string contentManagerName) 
            {
                Pig2EnemyFactory.Initialize(contentManagerName);
            }
            void IEntityFactory.ClearListsToAddTo () 
            {
                Pig2EnemyFactory.ClearListsToAddTo();
            }
            static Pig2EnemyFactory mSelf;
            public static Pig2EnemyFactory Self
            {
                get
                {
                    if (mSelf == null)
                    {
                        mSelf = new Pig2EnemyFactory();
                    }
                    return mSelf;
                }
            }
    }
}
