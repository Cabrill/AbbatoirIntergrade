using System;
using System.Collections.Generic;
using System.IO;
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
using AbbatoirIntergrade.Entities.Projectiles;
using AbbatoirIntergrade.Entities.Structures;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using RenderingLibrary.Graphics;
using StateInterpolationPlugin;
using Layer = FlatRedBall.Graphics.Layer;
using Sprite = FlatRedBall.Sprite;
using SpriteManager = FlatRedBall.SpriteManager;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
    public partial class BaseStructure
    {
        private static readonly Dictionary<Tuple<int, int>, Texture2D> RangeTextures = new Dictionary<Tuple<int, int>, Texture2D>();
        private List<UpgradeTypes> _upgradesApplied = new List<UpgradeTypes>();
        protected DamageTypes DamageType;

        private float? SoundPanning;

        private static PositionedObjectList<BaseEnemy> _potentialTargetList;
        protected BaseEnemy targetEnemy;
        protected float _aimRotation;
        protected float _timeToTravel;
        private double LastFiredTime;

        public Action OnBuild;
        public Action OnDestroy;
        protected Action OnFire;

        public bool IsDestroyed => HealthRemaining <= 0;

        public float HealthRemaining { get; private set; }

        private Layer _hudLayer;
        private Layer _lightLayer;

        protected SoundEffectInstance FiringSound;

        protected float _spriteRelativeY;

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
                RangeCircleInstance.Visible = true;
                MinimumRangeCircleInstance.Visible = true;
            }
            else
#endif
            {
                AxisAlignedRectangleInstance.Visible = false;
                RangeCircleInstance.Visible = false;
                MinimumRangeCircleInstance.Visible = false;
            }

            CurrentOnOffState = OnOff.On;

            _spriteRelativeY = SpriteInstance.Height / 3;

            ProjectileAltitude = PivotPoint.RelativeY;

            SpriteInstance.RelativeY = _spriteRelativeY;
            AimSpriteInstance.RelativeY += _spriteRelativeY;
            PivotPoint.RelativeY += _spriteRelativeY;

            var yOffset = AimSpriteInstance.RelativeY-PivotPoint.RelativeY;
            var xOffset = AimSpriteInstance.RelativeX - PivotPoint.RelativeX;

            AimSpriteInstance.AttachTo(PivotPoint, true);
            AimSpriteInstance.RelativeRotationZ = MathHelper.ToRadians(90);
            AimSpriteInstance.RelativeY = yOffset;
            AimSpriteInstance.RelativeX = xOffset;
            PivotPoint.RelativeY -= yOffset;
            PivotPoint.RelativeX -= xOffset;
            AimSpriteInstance.ParentRotationChangesPosition = false;
            LightAimSpriteInstance.AttachTo(AimSpriteInstance);

            RangePreviewSprite.RelativeX = PivotPoint.RelativeX;
            RangePreviewSprite.RelativeY = SpriteInstance.RelativeY;
            RefreshRangePreviewTexture();

            RangeCircleInstance.Visible = true;
            LastFiredTime = TimeManager.CurrentTime;

            AfterIsBeingPlacedSet += (not, used) => { RangeCircleInstance.Visible = false; };

            SetUpgradeStatus();
        }

        private void CustomActivity()
        {
            if (IsBeingPlaced)
            {
                CurrentState = VariableState.InvalidLocation;
            }
            else
            {
#if DEBUG
                if (DebugVariables.TurretsAimAtMouse) RotateToAimMouse();
#endif

                if (targetEnemy != null && (targetEnemy.IsDead || targetEnemy.HasReachedGoal || !RangeCircleInstance.CollideAgainst(targetEnemy.Collision) || MinimumRangeCircleInstance.CollideAgainst(targetEnemy.Collision)))
                {
                    targetEnemy = null;
                }

                if (targetEnemy == null && _potentialTargetList != null && _potentialTargetList.Count > 0)
                {
                    ChooseTarget();
                }

                if (targetEnemy != null)
                {
                    RotateToAim();
                    PerformFiringActivity();
                }
            }
        }

        private void RefreshRangePreviewTexture()
        {
            RangePreviewSprite.Texture =
                GetRangeTexture(new Tuple<int, int>((int)RangedRadius, (int)MinimumRangeRadius));
        }
        

        protected void UpdateAnimation()
        {
            if (SpriteInstance.CurrentChain == null || SpriteInstance.CurrentChain.Count == 1)
            {
                SpriteInstance.RelativeY = _spriteRelativeY;
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
                SpriteInstance.RelativeY += _spriteRelativeY;
            }
        }

        private bool hasLightSource;
        public void StartWarpIn()
        {
            IsBeingPlaced = false;
            hasLightSource = HasLightSource;

            SpriteInstance.Visible = false;
            AimSpriteInstance.Visible = false;
            LightAimSpriteInstance.Visible = false;
            LightSpriteInstance.Visible = false;

            WarpSpriteInstance.Visible = true;

            this.Call(MidWarpIn).After(0.5f);
        }

        private void MidWarpIn()
        {
            WarpSpriteInstance.CurrentChainName = "BuildFinished";
            this.Call(FinishWarpIn).After(0.5f);
        }

        private void FinishWarpIn()
        {
            WarpSpriteInstance.Animate = false;
            WarpSpriteInstance.Visible = false;
            AimSpriteInstance.Visible = true;
            SpriteInstance.Visible = true;

            HasLightSource = hasLightSource;

            LightAimSpriteInstance.Visible = HasLightSource;
            LightSpriteInstance.Visible = HasLightSource;
        }

        private void PerformDestruction()
        {
            OnDestroy?.Invoke();

            Destroy();
        }

        private void CustomDestroy()
        {
            if (FiringSound != null && !FiringSound.IsDisposed)
            {
                FiringSound.Stop(true);
                FiringSound.Dispose();
            }

            AfterIsBeingPlacedSet = null;
            targetEnemy = null;
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        protected void AddSpritesToLayers(Layer darknessLayer, Layer hudLayer)
        {
            _hudLayer = hudLayer;
            _lightLayer = darknessLayer;

#if DEBUG
            if (DebugVariables.ShowDebugShapes)
            {
                LayerProvidedByContainer.Remove(AxisAlignedRectangleInstance);
                ShapeManager.AddToLayer(AxisAlignedRectangleInstance, hudLayer);

            }
#endif


            LayerProvidedByContainer.Remove(RangePreviewSprite);
            SpriteManager.AddToLayer(RangePreviewSprite, hudLayer);
            
            LayerProvidedByContainer.Remove(LightSpriteInstance);
            SpriteManager.AddToLayer(LightSpriteInstance, darknessLayer);

            LayerProvidedByContainer.Remove(WarpSpriteInstance);
            SpriteManager.AddToLayer(WarpSpriteInstance, darknessLayer);

            LayerProvidedByContainer.Remove(LightAimSpriteInstance);
            SpriteManager.AddToLayer(LightAimSpriteInstance, darknessLayer);

            var gumLayer = RenderingLibrary.SystemManagers.Default.Renderer.Layers.FirstOrDefault(l => l.Name == "InfoLayerGum");
            StructureUpgradeStatusInstance.MoveToFrbLayer(hudLayer, gumLayer);

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

        public static void Reset()
        {
            _potentialTargetList = null;
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
            PivotPoint.RelativeRotationZ = _aimRotation;
            PerformFiringActivity();
        }
#endif

        /// <summary>
        /// Determines where the enemy will be, so it can shoot at it
        /// </summary>
        protected virtual void RotateToAim()
        {
            _aimRotation =  GetAimAngle(PivotPoint.Position);
            PivotPoint.RelativeRotationZ = _aimRotation;
        }

        private float GetAimAngle(Vector3 startPosition)
        {
            //Gather information about the target
            var targetPosition = targetEnemy.Position;

            var targetVector = targetEnemy.Velocity;
            var targetDistance = Vector3.Distance(startPosition, targetPosition);

            //Calculate how long the bullet would take to reach them
            _timeToTravel = targetDistance / ProjectileSpeed;

            var aimLocation = targetPosition;

            //If they're moving, we'll aim ahead
            if (targetVector != Vector3.Zero)
            {
                //Calculate how far they would travel in the time 
                var aimAheadDistance = targetVector * _timeToTravel;

                //Aim where they'll be in the time the bullet takes to travel
                aimLocation = aimAheadDistance + targetPosition;

                //Recalculate time with the new aiming location
                targetDistance = Vector3.Distance(startPosition, aimLocation);
                _timeToTravel = targetDistance / ProjectileSpeed;
                aimAheadDistance = targetVector * _timeToTravel;
                aimLocation = targetPosition + aimAheadDistance;
            }

            return (float)Math.Atan2(startPosition.Y - aimLocation.Y, startPosition.X - aimLocation.X);
        }

        protected virtual Vector3 GetProjectilePositioning(float? angle = null)
        {
            if (!angle.HasValue) angle = _aimRotation;

            var direction = new Vector3(
                (float)-Math.Cos(angle.Value),
                (float)-Math.Sin(angle.Value), 0);
            direction.Normalize();

            var effectiveX = Position.X + PivotPoint.RelativeX +
                             (AimSpriteInstance.Height/2 + AimSpriteInstance.RelativeY) * direction.X;
            var effectiveY = Position.Y + SpriteInstance.RelativeY + 
                             (AimSpriteInstance.Height/2 + AimSpriteInstance.RelativeY) * direction.Y;

            return new Vector3(effectiveX, effectiveY, Position.Z);
        }

        private void ChooseTarget()
        {
            var offScreenX = -Camera.Main.OrthogonalWidth / 2;
            var bestTargetProgress = 0.0;
            BaseEnemy newTarget = null;

            foreach (var pt in _potentialTargetList)
            {
                if (pt.IsDead) continue;
                if (pt.HasReachedGoal) continue;
                if (pt.X < offScreenX) continue;
                if (pt.IsFlying && this is BombardingTower) continue;
                if (!pt.CollideAgainst(RangeCircleInstance)) continue;
                if (pt.CollideAgainst(MinimumRangeCircleInstance)) continue;

                var ptProgress = pt.GetProgress();
                if (ptProgress < bestTargetProgress) continue;

                bestTargetProgress = ptProgress;
                newTarget = pt;
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
                newProjectile.StatusEffectSeconds = StatusEffectSeconds;
                newProjectile.StatusDamageMultiplier = StatusDamageMultiplier;
                newProjectile.Speed = ProjectileSpeed;
                newProjectile.Position = GetProjectilePositioning();
                newProjectile.Altitude = ProjectileAltitude;
                newProjectile.AltitudeVelocity = CalculateAltitudeVelocity(newProjectile);

                var projectileAngle = GetAimAngle(newProjectile.Position);

                var direction = new Vector3(
                    (float) -Math.Cos(projectileAngle),
                    (float) -Math.Sin(projectileAngle), 0);
                direction.Normalize();

                newProjectile.Velocity = direction * newProjectile.Speed;

                newProjectile.RotationZ = (float) Math.Atan2(-newProjectile.XVelocity,
                    newProjectile.YVelocity + newProjectile.AltitudeVelocity);

                PlayFireSound();

                LastFiredTime = TimeManager.CurrentTime;
                OnFire?.Invoke();
#if DEBUG
                if (DebugVariables.SlowTimeForShots)FlatRedBall.TimeManager.TimeFactor = 0.01;
#endif
                targetEnemy = null;
            }
        }

        private float CalculateAltitudeVelocity(BasePlayerProjectile projectile)
        {
            if (targetEnemy == null) return 0f;;

            float altitudeDifference = -projectile.Altitude;
            if (!(projectile is CannonProjectile))
            {
                altitudeDifference += targetEnemy.Altitude + (targetEnemy.SpriteInstance.Height / 4);
            }

            var altitudeVelocity = (altitudeDifference / _timeToTravel) - ((projectile.GravityDrag * _timeToTravel) / 2);

            return altitudeVelocity;
        }

        private void PlayFireSound()
        {
            if (!SoundPanning.HasValue)
            {
                SoundPanning = Position.X / Camera.Main.OrthogonalWidth;
                FiringSound.Pan = SoundPanning.Value;
            }

            SoundManager.PlaySoundEffect(FiringSound);
        }

        public static Texture2D GetRangeTexture(Tuple<int, int> rangeTuple)
        {
            if (RangeTextures.ContainsKey(rangeTuple)) return RangeTextures[rangeTuple];

            var newTexture = GenerateRadiusTexture(rangeTuple.Item1, rangeTuple.Item2);
            RangeTextures.Add(rangeTuple, newTexture);

            return newTexture;
        }

        private static Texture2D GenerateRadiusTexture(int maxRange, int minRange)
        {
            // Determine the new layer size
            var newTextureHeight = maxRange*2;
            var newTextureWidth = maxRange*2;

            // This layer holds whatever we want drawn
            var temporaryLayer = new Layer();

            // Define the layer. 
            var renderTarget = new RenderTarget2D(
                FlatRedBallServices.GraphicsDevice,
                newTextureWidth,
                newTextureHeight);
            temporaryLayer.RenderTarget = renderTarget;

            var maxRangeSprite = new Sprite
            {
                Texture = RangeCircleTexture,
                TextureScale = newTextureHeight / (float)RangeCircleTexture.Height,
                ColorOperation =  ColorOperation.ColorTextureAlpha,
                Z = 0,
                Red = 0,
                Green = 255,
                Blue = 0,
            };
            SpriteManager.AddToLayer(maxRangeSprite, temporaryLayer);

            var minRangeSprite = new Sprite
            {
                Texture = MinRangeCircleTexture,
                TextureScale = minRange*2 / (float)MinRangeCircleTexture.Height,
                //ColorOperation = ColorOperation.Subtract,
                ColorOperation = ColorOperation.ColorTextureAlpha,
                Z = 1,
                Red = 255,
                Green = 0,
                Blue = 0,
            };
            SpriteManager.AddToLayer(minRangeSprite, temporaryLayer);
            
            // Rendering requires a camera. We'll create a temporary one (don't add it to the SpriteManager)
            var temporaryCamera = new Camera(null, newTextureWidth, newTextureHeight) { DrawsWorld = false, Z = 40 };
            // We only want the camera to draw the layer
            temporaryCamera.UsePixelCoordinates();
            temporaryCamera.AddLayer(temporaryLayer);

            FlatRedBall.Graphics.Renderer.DrawCamera(temporaryCamera, null);

            //using (var fileStream = File.Create("range.png"))
            //{
            //    renderTarget.SaveAsPng(fileStream, newTextureWidth, newTextureHeight);
            //}

            SpriteManager.RemoveSprite(maxRangeSprite);
            SpriteManager.RemoveSprite(minRangeSprite);

            FlatRedBallServices.AddDisposable(
                "Max" + maxRange.ToString() + "Min" + minRange.ToString() + ".png",
                renderTarget,
                "ContentManagerName");

            return renderTarget;
        }

        /// <summary>
        /// Allows the child combat structure to generate a projectile of its own type
        /// </summary>
        /// <returns>The projectile to be fired by the </returns>
        protected virtual BasePlayerProjectile CreateNewProjectile()
        {
            return new BasePlayerProjectile();
        }

        public List<UpgradeTypes> GetCurrentlyAppliedUpgrades()
        {
            return _upgradesApplied;
        }

        public void ApplyUpgrade(UpgradeTypes upgradeType)
        {
            switch (upgradeType)
            {
                case UpgradeTypes.Range:
                    RangedRadius *= 1.25f;
                    MinimumRangeRadius *= 0.75f;
                    RefreshRangePreviewTexture();
                    break;
                case UpgradeTypes.Speed:
                    ProjectileSpeed *= 1.5f;
                    SecondsBetweenFiring *= 0.5f;
                    break;
                case UpgradeTypes.Damage:
                    AttackDamage *= 1.5f;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(upgradeType), upgradeType, null);
            }

            _upgradesApplied.Add(upgradeType);
            SetUpgradeStatus();
        }

        private void SetUpgradeStatus()
        {
            if (_upgradesApplied.Count == 0)
            {
                StructureUpgradeStatusInstance.CurrentUpgradesState = StructureUpgradeStatusRuntime.Upgrades.None;
                StructureUpgradeStatusInstance.Visible = false;
                return;
            }
            StructureUpgradeStatusInstance.Parent = null;
            

            StructureUpgradeStatusInstance.Visible = true;

            StructureUpgradeStatusInstance.X = X;
            StructureUpgradeStatusInstance.Y = Y;
            

            if (_upgradesApplied.Count == 3)
            {
                StructureUpgradeStatusInstance.CurrentUpgradesState = StructureUpgradeStatusRuntime.Upgrades.DamageRangeSpeed;
                return;
            }

            var hasSpeed = _upgradesApplied.Contains(UpgradeTypes.Speed);
            var hasRange = _upgradesApplied.Contains(UpgradeTypes.Range);
            var hasDamage = _upgradesApplied.Contains(UpgradeTypes.Damage);

            if (_upgradesApplied.Count == 1)
            {
                if (hasSpeed) StructureUpgradeStatusInstance.CurrentUpgradesState = StructureUpgradeStatusRuntime.Upgrades.Speed;
                if (hasRange) StructureUpgradeStatusInstance.CurrentUpgradesState = StructureUpgradeStatusRuntime.Upgrades.Range;
                return;
            }

            if (hasRange && hasSpeed)
            {
                StructureUpgradeStatusInstance.CurrentUpgradesState = StructureUpgradeStatusRuntime.Upgrades.RangeSpeed;
            }
            else if (hasSpeed && hasDamage)
            {
                StructureUpgradeStatusInstance.CurrentUpgradesState = StructureUpgradeStatusRuntime.Upgrades.SpeedDamage;
            }
            else if (hasRange && hasDamage)
            {
                StructureUpgradeStatusInstance.CurrentUpgradesState = StructureUpgradeStatusRuntime.Upgrades.RangeDamage;
            }
        }
    }
}
