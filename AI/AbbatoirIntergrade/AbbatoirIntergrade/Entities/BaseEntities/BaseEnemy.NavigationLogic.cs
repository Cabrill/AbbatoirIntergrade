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
        private int pointIndex;
        private Polygon PathingLine;

        #endregion

        #region Placement methods

        public void FollowLine(Polygon line)
        {
            PathingLine = line;
            pointIndex = 0;
            var firstPoint = PathingLine.AbsolutePointPosition(pointIndex);
            X = (float)firstPoint.X;
            Y = (float)firstPoint.Y;

            var secondPoint = PathingLine.AbsolutePointPosition(++pointIndex);
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
            if (pointIndex < PathingLine.Points.Count-1)
            {
                _targetPointForNavigation = PathingLine.AbsolutePointPosition(++pointIndex);
            }
            else
            {
                HasReachedGoal = true;
            }
        }

        protected virtual void NavigateToTarget()
        {
            if (_targetPointForNavigation != null)
            {
                var angle = (float)Math.Atan2(Y - _targetPointForNavigation.Y,
                    X - _targetPointForNavigation.X);
                var direction = new Vector3(
                    (float)-Math.Cos(angle),
                    (float)-Math.Sin(angle), 0);
                direction.Normalize();
                Acceleration = direction * Speed * _currentScale;
                Velocity = Acceleration * 0.2f;
                
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
            var timeToTravel = targetDistance / Speed;

            var altitudeVelocity = - ((GravityDrag * timeToTravel) / 2);

            return altitudeVelocity;
        }
        #endregion
    }
}
