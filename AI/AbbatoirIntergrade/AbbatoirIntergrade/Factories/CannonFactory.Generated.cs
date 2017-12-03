using AbbatoirIntergrade.Entities.Structures.Combat;
using System;
using AbbatoirIntergrade.Entities.BaseEntities;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Performance;

namespace AbbatoirIntergrade.Factories
{
    public class CannonFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static Cannon CreateNew (float x = 0, float y = 0)
        {
            return CreateNew(null, x, y);
        }
        public static Cannon CreateNew (Layer layer, float x = 0, float y = 0)
        {
            if (string.IsNullOrEmpty(mContentManagerName))
            {
                throw new System.Exception("You must first initialize the factory to use it. You can either add PositionedObjectList of type Cannon (the most common solution) or call Initialize in custom code");
            }
            Cannon instance = null;
            instance = new Cannon(mContentManagerName, false);
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
        
        public static void Initialize (FlatRedBall.Math.PositionedObjectList<Cannon> listFromScreen, string contentManager)
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
                Cannon instance = new Cannon(mContentManagerName, false);
                mPool.AddToPool(instance);
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (Cannon objectToMakeUnused)
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (Cannon objectToMakeUnused, bool callDestroy)
        {
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        
            static string mContentManagerName;
            static PositionedObjectList<Cannon> mScreenListReference;
            static PositionedObjectList<BaseStructure> mBaseScreenListReference;
            static PoolList<Cannon> mPool = new PoolList<Cannon>();
            public static Action<Cannon> EntitySpawned;
            object IEntityFactory.CreateNew ()
            {
                return CannonFactory.CreateNew();
            }
            object IEntityFactory.CreateNew (Layer layer)
            {
                return CannonFactory.CreateNew(layer);
            }
            public static FlatRedBall.Math.PositionedObjectList<Cannon> ScreenListReference
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
            static CannonFactory mSelf;
            public static CannonFactory Self
            {
                get
                {
                    if (mSelf == null)
                    {
                        mSelf = new CannonFactory();
                    }
                    return mSelf;
                }
            }
    }
}
