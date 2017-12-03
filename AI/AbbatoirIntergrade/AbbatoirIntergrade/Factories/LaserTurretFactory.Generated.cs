using AbbatoirIntergrade.Entities.Structures.Combat;
using System;
using AbbatoirIntergrade.Entities.BaseEntities;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Performance;

namespace AbbatoirIntergrade.Factories
{
    public class LaserTurretFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static LaserTurret CreateNew (float x = 0, float y = 0)
        {
            return CreateNew(null, x, y);
        }
        public static LaserTurret CreateNew (Layer layer, float x = 0, float y = 0)
        {
            if (string.IsNullOrEmpty(mContentManagerName))
            {
                throw new System.Exception("You must first initialize the factory to use it. You can either add PositionedObjectList of type LaserTurret (the most common solution) or call Initialize in custom code");
            }
            LaserTurret instance = null;
            instance = new LaserTurret(mContentManagerName, false);
            instance.AddToManagers(layer);
            instance.X = x;
            instance.Y = y;
            if (mScreenListReference != null)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X)
                {
                    var index = mScreenListReference.GetFirstAfter(x, Axis.X, 0, mScreenListReference.Count);
                    mScreenListReference.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y)
                {
                    var index = mScreenListReference.GetFirstAfter(y, Axis.Y, 0, mScreenListReference.Count);
                    mScreenListReference.Insert(index, instance);
                }
                else
                {
                    // Sort Z not supported
                    mScreenListReference.Add(instance);
                }
            }
            if (mBaseScreenListReference != null)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X)
                {
                    var index = mScreenListReference.GetFirstAfter(x, Axis.X, 0, mScreenListReference.Count);
                    mScreenListReference.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y)
                {
                    var index = mScreenListReference.GetFirstAfter(y, Axis.Y, 0, mScreenListReference.Count);
                    mScreenListReference.Insert(index, instance);
                }
                else
                {
                    // Sort Z not supported
                    mBaseScreenListReference.Add(instance);
                }
            }
            if (EntitySpawned != null)
            {
                EntitySpawned(instance);
            }
            return instance;
        }
        
        public static void Initialize (FlatRedBall.Math.PositionedObjectList<LaserTurret> listFromScreen, string contentManager)
        {
            mContentManagerName = contentManager;
            mScreenListReference = listFromScreen;
        }
        
        public static void Initialize (FlatRedBall.Math.PositionedObjectList<BaseStructure> listFromScreen, string contentManager)
        {
            mContentManagerName = contentManager;
            mBaseScreenListReference = listFromScreen;
        }
        
        public static void Destroy ()
        {
            mContentManagerName = null;
            mScreenListReference = null;
            SortAxis = null;
            mPool.Clear();
            EntitySpawned = null;
        }
        
        private static void FactoryInitialize ()
        {
            const int numberToPreAllocate = 20;
            for (int i = 0; i < numberToPreAllocate; i++)
            {
                LaserTurret instance = new LaserTurret(mContentManagerName, false);
                mPool.AddToPool(instance);
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (LaserTurret objectToMakeUnused)
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (LaserTurret objectToMakeUnused, bool callDestroy)
        {
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        
            static string mContentManagerName;
            static PositionedObjectList<LaserTurret> mScreenListReference;
            static PositionedObjectList<BaseStructure> mBaseScreenListReference;
            static PoolList<LaserTurret> mPool = new PoolList<LaserTurret>();
            public static Action<LaserTurret> EntitySpawned;
            object IEntityFactory.CreateNew ()
            {
                return LaserTurretFactory.CreateNew();
            }
            object IEntityFactory.CreateNew (Layer layer)
            {
                return LaserTurretFactory.CreateNew(layer);
            }
            public static FlatRedBall.Math.PositionedObjectList<LaserTurret> ScreenListReference
            {
                get
                {
                    return mScreenListReference;
                }
                set
                {
                    mScreenListReference = value;
                }
            }
            static LaserTurretFactory mSelf;
            public static LaserTurretFactory Self
            {
                get
                {
                    if (mSelf == null)
                    {
                        mSelf = new LaserTurretFactory();
                    }
                    return mSelf;
                }
            }
    }
}
