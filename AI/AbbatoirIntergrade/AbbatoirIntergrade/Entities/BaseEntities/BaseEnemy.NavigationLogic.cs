using System;
using System.Linq;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
    public partial class BaseEnemy
    {
        #region Properties and fields

        protected Vector3 _targetPointForNavigation;
        private float _lastDistanceToNavigationTarget;
        protected float _currentDistanceToNavigationTarget;
        public int PathingPointIndex;
        private Polygon PathingLine;

        #endregion

        #region Placement methods

        public void FollowLine(Polygon line)
        {
            PathingLine = line;
            PathingPointIndex = 0;
            var firstPoint = PathingLine.AbsolutePointPosition(PathingPointIndex);
            X = (float)firstPoint.X;
            Y = (float)firstPoint.Y;

            var secondPoint = PathingLine.AbsolutePointPosition(++PathingPointIndex);
            _targetPointForNavigation = secondPoint;
            CurrentActionState = Action.Running;
            CurrentDirectionState = Direction.MovingRight;
        }
        #endregion

        #region Navigation methods

        private void NavigationActivity()
        {
            _currentDistanceToNavigationTarget = Vector3.Distance(Position, _targetPointForNavigation);

            if (_currentDistanceToNavigationTarget < 30)
            {
                ChoosePointForNavigation();
                _currentDistanceToNavigationTarget = Vector3.Distance(Position, _targetPointForNavigation);
            }

            NavigateToTarget();

            _lastDistanceToNavigationTarget = _currentDistanceToNavigationTarget;
        }

        private void ChoosePointForNavigation()
        {
            if (PathingPointIndex < PathingLine.Points.Count-1)
            {
                _targetPointForNavigation = PathingLine.AbsolutePointPosition(++PathingPointIndex);
            }
            else
            {
                HasReachedGoal = true;
            }
        }

        protected virtual void NavigateToTarget()
        {
            if (_targetPointForNavigation != Vector3.Zero)
            {
                var angle = (float)Math.Atan2(Y - _targetPointForNavigation.Y,
                    X - _targetPointForNavigation.X);
                var direction = new Vector3(
                    (float)-Math.Cos(angle),
                    (float)-Math.Sin(angle), 0);
                direction.Normalize();
                Velocity = direction * EffectiveSpeed;

                CurrentActionState = Action.Running;
                CurrentDirectionState =
                    (Velocity.X > 0 ? Direction.MovingRight : Direction.MovingLeft);
                SpriteInstance.IgnoreAnimationChainTextureFlip = true;
            }
            else
            {
                CurrentActionState = Action.Standing;
            }
        }

        protected float CalculateJumpAltitudeVelocity()
        {
            if (_targetPointForNavigation == null) return 0f;

            var targetPosition = _targetPointForNavigation;
            var targetDistance = Vector3.Distance(CircleInstance.Position, targetPosition);
            var timeToTravel = targetDistance / EffectiveSpeed;

            var altitudeVelocity = - ((GravityDrag * timeToTravel) / 2);

            return altitudeVelocity;
        }
        #endregion
    }
}
