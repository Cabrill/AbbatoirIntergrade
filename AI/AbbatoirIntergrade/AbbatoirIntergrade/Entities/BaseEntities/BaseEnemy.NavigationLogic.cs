using System;
using System.Linq;
using FlatRedBall;
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
        private static Segment[] PathingSegments;
        private static TileNodeNetwork NodeNetwork;
        private const int DistanceToAchievePoint = 30;

        private static Vector3 firstNavigationPoint;
        private static Vector3 secondNavigationPoint;
        private static Vector3 secondNavigationPointFlying;

        private static Vector3 _firstPathingPoint;
        private static Vector3 _lastPathingPoint;
        private static double _totalPathLength;
        private static double[] _segmentLengths;

        #endregion

        #region Placement methods

        public void FollowLine()
        {
            Vector3 firstPoint, secondPoint;

            PathingPointIndex = IsFlying ? PathingLine.Points.Count-1 : 1;
            firstPoint = firstNavigationPoint;
            secondPoint = (IsFlying ? secondNavigationPointFlying : secondNavigationPoint);

            X = (float)firstPoint.X + FlatRedBallServices.Random.Next(-1, 1) * FlatRedBallServices.Random.Next(5, 40);
            Y = (float)firstPoint.Y + FlatRedBallServices.Random.Next(-1, 1) * FlatRedBallServices.Random.Next(5, 40);

            _targetPointForNavigation = secondPoint;

            CurrentActionState = Action.Running;
            CurrentDirectionState = Direction.MovingRight;

            var randomStartingFrame =
                FlatRedBallServices.Random.Next(0, spriteAnimationChainList[SpriteInstance.CurrentChainIndex].Count - 1);
            SpriteInstance.CurrentFrameIndex = randomStartingFrame;
        }

        public void RushEndPoint()
        {
            isHorde = true;

            X = (float)firstNavigationPoint.X + FlatRedBallServices.Random.Next(-1, 1) * FlatRedBallServices.Random.Next(5, 40);
            Y = (float)firstNavigationPoint.Y + FlatRedBallServices.Random.Next(-1, 1) * FlatRedBallServices.Random.Next(5, 40);

            PathingPointIndex = PathingLine.Points.Count - 1;
            _targetPointForNavigation = secondNavigationPointFlying;
            CurrentActionState = Action.Running;
            CurrentDirectionState = Direction.MovingRight;

            var randomStartingFrame =
                FlatRedBallServices.Random.Next(0, spriteAnimationChainList[SpriteInstance.CurrentChainIndex].Count - 1);
            SpriteInstance.CurrentFrameIndex = randomStartingFrame;
        }
        #endregion

        #region Navigation methods

        private void UpdateNavigationTargetProgress()
        {
            _currentDistanceToNavigationTarget = Vector3.Distance(Position, _targetPointForNavigation);

            if (_currentDistanceToNavigationTarget < DistanceToAchievePoint)
            {
                ChoosePointForNavigation();
                _currentDistanceToNavigationTarget = Vector3.Distance(Position, _targetPointForNavigation);
            }
            else if (!IsFlying && PathingPointIndex < PathingLine.Points.Count - 1)
            {
                var currentSegment = PathingSegments[PathingPointIndex - 1];
                var nextSegment = PathingSegments[PathingPointIndex];

                if (currentSegment.DistanceTo(Position) > nextSegment.DistanceTo(Position))
                {
                    _targetPointForNavigation = PathingLine.AbsolutePointPosition(++PathingPointIndex);
                }
            }
            else if (X+ DistanceToAchievePoint > Camera.Main.OrthogonalWidth / 2)
            {
                HasReachedGoal = true;
            }
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
            if (!isHorde && !IsFlying && !PathingSegments.Any(s => s.DistanceTo(Position) < SelfCollisionCircle.Radius/2))
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

        private static void UpdatePathingValues()
        {
            _totalPathLength = 0;
            _segmentLengths = new double[PathingLine.Points.Count - 1];
            _firstPathingPoint = PathingLine.AbsolutePointPosition(0);
            _lastPathingPoint = PathingLine.AbsolutePointPosition(PathingLine.Points.Count - 1);

            for (var i = 0; i < PathingLine.Points.Count - 2; i++)
            {
                var point1 = PathingLine.AbsolutePointPosition(i);
                var point2 = PathingLine.AbsolutePointPosition(i + 1);
                var segmentValue = (point1 - point2).Length();
                _totalPathLength += segmentValue;

                _segmentLengths[i] = segmentValue;
            }

            PathingSegments = new Segment[PathingLine.Points.Count - 1];
            for (var i = 0; i <= PathingLine.Points.Count - 2; i++)
            {
                PathingSegments[i] = new Segment(PathingLine.AbsolutePointPosition(i), PathingLine.AbsolutePointPosition(i + 1));
            }

            firstNavigationPoint = PathingLine.AbsolutePointPosition(0);
            secondNavigationPoint = PathingLine.AbsolutePointPosition(1);
            secondNavigationPointFlying = PathingLine.AbsolutePointPosition(PathingLine.Points.Count - 1);
        }

        public double GetProgress()
        {
            if (HasReachedGoal) return 0;

            var score = 0.0;
            Vector3 firstPoint, secondPoint;


            if (IsFlying)
            {
                firstPoint = _firstPathingPoint;
                secondPoint = _lastPathingPoint;
            }
            else
            {
                var pathingPointIndex = PathingPointIndex;

                for (var i = 0; i < pathingPointIndex - 1; i++)
                {
                    score += _segmentLengths[i] / _totalPathLength;
                }

                firstPoint = PathingLine.AbsolutePointPosition(pathingPointIndex - 1);
                secondPoint = PathingLine.AbsolutePointPosition(pathingPointIndex);
            }

            var distanceBetweenPoints = (firstPoint - secondPoint).Length();
            var enemyDistanceToSecondPoint = (Position - secondPoint).Length();

            if (enemyDistanceToSecondPoint < distanceBetweenPoints)
            {
                var pointProgress = distanceBetweenPoints - enemyDistanceToSecondPoint;

                score += pointProgress / _totalPathLength;
            }

            score *= 0.01f;

            return score;
        }
        #endregion
    }
}
