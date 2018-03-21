using System;
using System.Linq;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
    public partial class BaseEnemy
    {
        #region Properties and fields

        private Vector3 _targetPointForNavigation;
        private float _currentDistanceToNavigationTarget;
        public int PathingPointIndex;
        private static Polygon PathingLine;
        private static TileNodeNetwork NodeNetwork;

        #endregion

        #region Placement methods

        public void FollowLine()
        {
            Vector3 firstPoint, secondPoint;

            if (IsFlying)
            {
                PathingPointIndex = PathingLine.Points.Count - 1;
                firstPoint = PathingLine.AbsolutePointPosition(0);
                secondPoint = PathingLine.AbsolutePointPosition(PathingLine.Points.Count-1);
            }
            else
            {
                PathingPointIndex = 0;
                firstPoint = PathingLine.AbsolutePointPosition(PathingPointIndex);
                secondPoint = PathingLine.AbsolutePointPosition(++PathingPointIndex);
            }

            X = (float)firstPoint.X;
            Y = (float)firstPoint.Y;
            _targetPointForNavigation = secondPoint;

            CurrentActionState = Action.Running;
            CurrentDirectionState = Direction.MovingRight;
        }
        #endregion

        #region Navigation methods

        private void UpdateNavigationTargetProgress()
        {
            _currentDistanceToNavigationTarget = Vector3.Distance(Position, _targetPointForNavigation);

            if (_currentDistanceToNavigationTarget < 30)
            {
                ChoosePointForNavigation();
                _currentDistanceToNavigationTarget = Vector3.Distance(Position, _targetPointForNavigation);
            }
        }

        private void NavigationActivity()
        {
            UpdateNavigationTargetProgress();
            NavigateToTarget();
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
            if (!PathingLine.CollideAgainst(SelfCollisionCircle))
            {
                var nextNodes = NodeNetwork.GetPathOrClosest(ref Position, ref _targetPointForNavigation);
                var nextNode = nextNodes.Count > 1 ? nextNodes[1] : nextNodes[0];

                var angle = (float)Math.Atan2(Y - nextNode.Y,
                    X - nextNode.X);
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
            else if (_targetPointForNavigation != Vector3.Zero)
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
