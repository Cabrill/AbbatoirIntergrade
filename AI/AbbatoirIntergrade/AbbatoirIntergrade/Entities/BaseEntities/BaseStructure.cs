using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Gui;
using FlatRedBall.Gum;
using FlatRedBall.ManagedSpriteGroups;
using FlatRedBall.Math.Geometry;
using AbbatoirIntergrade.Entities.GraphicalElements;
using FlatRedBall.Math;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using RenderingLibrary.Graphics;
using Layer = FlatRedBall.Graphics.Layer;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
    public partial class BaseStructure
    {
        private static float _maximumY;
        protected float _currentScale;
        protected float _startingScale;
        private float _startingLightSpriteScale;
        private float _startingRectangleScaleX;
        private float _startingRectangleScaleY;

        private static PositionedObjectList<BaseEnemy> _potentialTargetList;
        protected BaseEnemy targetEnemy;
        protected SoundEffectInstance attackSound;
        protected float _aimRotation;
        protected float _shotAltitude = 1f;
        private float? _startingRangeRadius;
        private double LastFiredTime;

        public Action OnBuild;
        public Action OnDestroy;

        public bool IsDestroyed => HealthRemaining <= 0;

        public float HealthRemaining { get; private set; }

        private Layer _hudLayer;

        protected SoundEffectInstance PlacementSound;
        protected SoundEffectInstance DestroyedSound;

        protected float _spriteRelativeY;

        public static void Initialize(float maximumY)
        {
            _maximumY = maximumY;
        }

        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        private void CustomInitialize()
        {
#if DEBUG
            if (DebugVariables.ShowDebugShapes)
            {
                AxisAlignedRectangleInstance.Visible = true;
            }
            else
#endif
            {
                AxisAlignedRectangleInstance.Visible = false;
            }

            CurrentOnOffState = OnOff.On;

            LightSpriteInstance.Width = SpriteInstance.Width;
            LightSpriteInstance.Height = LightSpriteInstance.Width / 4;

            _startingScale = SpriteInstance.TextureScale;
            _startingLightSpriteScale = LightSpriteInstance.TextureScale;
            _startingRectangleScaleX = AxisAlignedRectangleInstance.ScaleX;
            _startingRectangleScaleY = AxisAlignedRectangleInstance.ScaleY;


            PlacementSound = Structure_Placed.CreateInstance();
            DestroyedSound = Building_Destroyed.CreateInstance();

            _spriteRelativeY = GetSpriteRelativeY();
            
            CalculateScale();
            UpdateScale();
            UpdateAnimation();

            RangeCircleInstance.Visible = true;
            LastFiredTime = TimeManager.CurrentTime;

            AfterIsBeingPlacedSet += (not, used) => { RangeCircleInstance.Visible = false; };
            _startingRangeRadius = RangedRadius;
        }

        private void CustomActivity()
        {
            UpdateAnimation();

            if (IsBeingPlaced)
            {
                CalculateScale();
                UpdateScale();

                CurrentState = VariableState.InvalidLocation;
            }
            else
            {
#if DEBUG
                if (DebugVariables.TurretsAimAtMouse) RotateToAimMouse();
#endif

                if (targetEnemy != null && (targetEnemy.IsDead || !RangeCircleInstance.CollideAgainst(targetEnemy.CircleInstance)))
                {
                    targetEnemy = null;
                }

                if (targetEnemy == null && _potentialTargetList.Count > 0)
                {
                    ChooseTarget();
                }

                if (targetEnemy != null)
                {
                    RotateToAim();
                    SetAnimationFromAimRotation();
                    PerformFiringActivity();
                }
            }
        }

        private void CalculateScale()
        {
            _currentScale = 0.3f + (0.4f * (1 - Y / _maximumY));
        }

        protected virtual void UpdateScale()
        {
            SpriteInstance.TextureScale = _startingScale * _currentScale;

            AxisAlignedRectangleInstance.ScaleX = Math.Max(0, _startingRectangleScaleX * _currentScale);
            AxisAlignedRectangleInstance.ScaleY = Math.Max(0, _startingRectangleScaleY * _currentScale);

            AxisAlignedRectangleInstance.RelativeY = AxisAlignedRectangleInstance.Height / 2;

            if (HasLightSource)
            {
                //LightSpriteInstance.TextureScale = _startingLightSpriteScale * _currentScale;
                LightSpriteInstance.Width = SpriteInstance.Width * 1.5f;
                LightSpriteInstance.Height = AxisAlignedRectangleInstance.Height;
            }

            if (IsBeingPlaced)
            {
                float buttonDistance = SpriteInstance.Width;
                float buttonHeight = SpriteInstance.Height;
                if (SpriteInstance.Animate&& SpriteInstance.CurrentChain != null)
                {
                    var baseFrame = SpriteInstance.CurrentChain[0];
                    buttonDistance = (baseFrame.RightCoordinate - baseFrame.LeftCoordinate) * baseFrame.Texture.Width * _currentScale;
                    buttonHeight = (baseFrame.BottomCoordinate - baseFrame.TopCoordinate) * baseFrame.Texture.Height *
                                   _currentScale;
                }
            }

            if (_startingRangeRadius.HasValue)
            {
                RangeCircleInstance.Radius = _startingRangeRadius.Value * _currentScale;
            }
        }

        protected void UpdateAnimation()
        {
            if (SpriteInstance.CurrentChain == null || SpriteInstance.CurrentChain.Count == 1)
            {
                SpriteInstance.RelativeY = _spriteRelativeY * _currentScale;
            }
            else
            {
                SpriteInstance.UpdateToCurrentAnimationFrame();

                if (SpriteInstance.UseAnimationRelativePosition)
                {
                    SpriteInstance.RelativeX *= (SpriteInstance.FlipHorizontal
                        ? -SpriteInstance.TextureScale
                        : SpriteInstance.TextureScale);
                    SpriteInstance.RelativeY *= (SpriteInstance.FlipVertical
                        ? -SpriteInstance.TextureScale
                        : SpriteInstance.TextureScale);
                }
                SpriteInstance.RelativeY += _spriteRelativeY * _currentScale;
            }
        }

        private void BuildStructure()
        {
            //var shouldBuild = EnergyManager.CanAfford(EnergyBuildCost) && MineralsManager.CanAfford(MineralsBuildCost);

            //if (shouldBuild)
            //{
            //    EnergyManager.DebitEnergyForBuildRequest(EnergyBuildCost);
            //    MineralsManager.DebitMinerals(MineralsBuildCost);

            //    IsBeingPlaced = false;
            //    CurrentState = VariableState.Built;
            //    PlayPlacementSound();
            //    OnBuild?.Invoke();
            //}
        }

        private void PlayPlacementSound()
        {
            try
            {
                PlacementSound.Play();
            }
            catch (Exception)
            {
            }
        }

        protected float GetSpriteRelativeY()
        {
            if (SpriteInstance.CurrentChain == null || SpriteInstance.CurrentChain.Count == 1)
            {
                return SpriteInstance.Height / 2;
            }
            else
            {
                var maxHeight = 0f;
                foreach (var frame in SpriteInstance.CurrentChain)
                {
                    maxHeight = Math.Max(maxHeight,
                        (frame.BottomCoordinate - frame.TopCoordinate) * frame.Texture.Height *
                        SpriteInstance.TextureScale);
                }
                return maxHeight / 2;
            }
        }

        private void PerformDestruction()
        {
            ;
            OnDestroy?.Invoke();

            Destroy();
        }

        private void CustomDestroy()
        {
            if (PlacementSound != null && !PlacementSound.IsDisposed)
            {
                PlacementSound.Stop(true);
                PlacementSound.Dispose();
            }
            if (DestroyedSound != null && !DestroyedSound.IsDisposed)
            {
                DestroyedSound.Stop(true);
                DestroyedSound.Dispose();
            }

            if (attackSound != null && !attackSound.IsDisposed)
            {
                attackSound.Stop(true);
                attackSound.Dispose();
            }
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        protected void AddSpritesToLayers(Layer darknessLayer, Layer hudLayer)
        {
            _hudLayer = hudLayer;

            LayerProvidedByContainer.Remove(AxisAlignedRectangleInstance);
            ShapeManager.AddToLayer(AxisAlignedRectangleInstance, hudLayer);

            LayerProvidedByContainer.Remove(SpriteInstance);
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, hudLayer);

            LayerProvidedByContainer.Remove(LightSpriteInstance);
            FlatRedBall.SpriteManager.AddToLayer(LightSpriteInstance, darknessLayer);


            LayerProvidedByContainer.Remove(RangeCircleInstance);
            ShapeManager.AddToLayer(RangeCircleInstance, hudLayer);
        }

        public void DestroyByRequest()
        {
            HealthRemaining = 0;
            PerformDestruction();
        }

        public static void Initialize(PositionedObjectList<BaseEnemy> potentialTargets)
        {
            _potentialTargetList = potentialTargets;
        }

#if DEBUG
        /// <summary>
        /// Determines where the enemy will be, so it can shoot at it
        /// </summary>
        private void RotateToAimMouse()
        {
            //Gather information about the target
            var targetPositionX = FlatRedBall.Gui.GuiManager.Cursor.WorldXAt(1);
            var targetPositionY = FlatRedBall.Gui.GuiManager.Cursor.WorldYAt(1);

            var targetPosition = new Vector3(targetPositionX, targetPositionY, 1);

            var aimLocation = targetPosition;

            var angle = (float)Math.Atan2(Position.Y - aimLocation.Y, Position.X - aimLocation.X);

            _aimRotation = angle;

            SetAnimationFromAimRotation();
            PerformFiringActivity();
        }
#endif

        /// <summary>
        /// Determines where the enemy will be, so it can shoot at it
        /// </summary>
        protected virtual void RotateToAim()
        {
            var startPosition = GetProjectilePositioning();

            //Gather information about the target
            var targetPosition = targetEnemy.CircleInstance.Position;

            var targetVector = targetEnemy.Velocity;
            var targetDistance = Vector3.Distance(startPosition, targetPosition);

            //Calculate how long the bullet would take to reach them
            var timeToTravel = targetDistance / ProjectileSpeed;

            var aimLocation = targetPosition;

            //If they're moving, we'll aim ahead
            if (targetVector != Vector3.Zero)
            {
                //Calculate how far they would travel in the time 
                var aimAheadDistance = targetVector * timeToTravel;

                //Aim where they'll be in the time the bullet takes to travel
                aimLocation = aimAheadDistance + targetPosition;

                //Recalculate time with the new aiming location
                targetDistance = Vector3.Distance(startPosition, aimLocation);
                timeToTravel = targetDistance / ProjectileSpeed;
                aimAheadDistance = targetVector * timeToTravel;
                aimLocation = targetPosition + aimAheadDistance;
            }

            var angle = (float)Math.Atan2(startPosition.Y - aimLocation.Y, startPosition.X - aimLocation.X);

            _aimRotation = angle;
        }

        protected virtual void SetAnimationFromAimRotation()
        {
            var isolatedAim = _aimRotation % (2 * Math.PI);//A full circle is is 2*Pi

            if (isolatedAim < 0) isolatedAim = (2 * Math.PI) - Math.Abs(isolatedAim);

            var quadSize = (2 * Math.PI) / 4;//Four quads in a circle
            var aimQuad = (int)(isolatedAim / quadSize);
            var quadRemainder = isolatedAim % quadSize;

            //var quadProgress = (int)Math.Floor(quadRemainder / (quadrantSegments/5));

            var quadPercent = quadRemainder / quadSize;
            int quadProgress = 0;

            if (aimQuad == 0 || aimQuad == 2)//bottom-left and top-right
            {
                if (quadPercent > 0.7f) quadProgress = 4;
                else if (quadPercent > .4f) quadProgress = 3;
                else if (quadPercent > .25f) quadProgress = 2;
                else if (quadPercent > .12f) quadProgress = 1;
            }
            else//bottom-right and top-left
            {
                if (quadPercent > 0.97f) quadProgress = 4;
                else if (quadPercent > .9f) quadProgress = 3;
                else if (quadPercent > .7f) quadProgress = 2;
                else if (quadPercent > .35f) quadProgress = 1;
            }

            if (targetEnemy == null || !targetEnemy.IsFlying)
            {
                SpriteInstance.CurrentChainName = "Turn";
            }
            else
            {
                SpriteInstance.CurrentChainName = "UpTurn";
            }

            SpriteInstance.CurrentFrameIndex = (aimQuad * 5) + quadProgress;


            UpdateAnimation();
        }

        protected virtual Vector3 GetProjectilePositioning(float? angle = null)
        {
            if (!angle.HasValue) angle = _aimRotation;

            var direction = new Vector3(
                (float)-Math.Cos(angle.Value),
                (float)-Math.Sin(angle.Value), 0);
            direction.Normalize();
            return new Vector3(Position.X + AxisAlignedRectangleInstance.Width / 2 * direction.X, Position.Y + AxisAlignedRectangleInstance.Height * direction.Y, 0);
        }

        private void ChooseTarget()
        {
            BaseEnemy newTarget = null;

            foreach (BaseEnemy pt in _potentialTargetList)
            {
                if (pt.IsDead) continue;
                if (!pt.CircleInstance.CollideAgainst(RangeCircleInstance)) continue;
                newTarget = pt;
                break;
            }

            if (newTarget != null)
            {
                targetEnemy = newTarget;
            }
        }

        private void PerformFiringActivity()
        {
            if (TimeManager.SecondsSince(LastFiredTime) > SecondsBetweenFiring)
            {
                var newProjectile = CreateNewProjectile();
                newProjectile.DamageInflicted = AttackDamage;
                newProjectile.Speed = ProjectileSpeed;
                newProjectile.Position = Position;

                var direction = new Vector3(
                    (float)-Math.Cos(_aimRotation),
                    (float)-Math.Sin(_aimRotation), 0);
                direction.Normalize();
                newProjectile.Position = GetProjectilePositioning();

                newProjectile.AltitudeVelocity = CalculateAltitudeVelocity(newProjectile);

                newProjectile.Velocity = direction * newProjectile.Speed;

                newProjectile.RotationZ = (float)Math.Atan2(-newProjectile.XVelocity, newProjectile.YVelocity);

                PlayFireSound();

                LastFiredTime = TimeManager.CurrentTime;
            }
        }

        private float CalculateAltitudeVelocity(BasePlayerProjectile projectile)
        {
            if (targetEnemy == null) return 0f;

            var targetPosition = targetEnemy.Position;
            var targetDistance = Vector3.Distance(projectile.Position, targetPosition);

            var timeToTravel = targetDistance / ProjectileSpeed;

            var altitudeDifference = targetEnemy.Altitude + (targetEnemy.SpriteInstance.Height / 2) - projectile.Altitude;
            var altitudeVelocity = (altitudeDifference / timeToTravel) - ((projectile.GravityDrag * timeToTravel) / 2);

            return altitudeVelocity;
        }

        private void PlayFireSound()
        {
            try
            {
                attackSound.Play();
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Allows the child combat structure to generate a projectile of its own type
        /// </summary>
        /// <returns>The projectile to be fired by the </returns>
        protected virtual BasePlayerProjectile CreateNewProjectile()
        {
            return new BasePlayerProjectile();
        }
    }
}
