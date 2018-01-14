using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Factories;
using AbbatoirIntergrade.StaticManagers;

namespace AbbatoirIntergrade.Screens
{
    public partial class GameScreen
    {

        private void InitializeFactories()
        {
            StructurePlacementFactory.EntitySpawned +=
                placement => placement.AddSpritesToLayers(LightLayer, InfoLayer);

            //Projectiles
            PiercingProjectileFactory.Initialize(ContentManagerName);
            PiercingProjectileFactory.EntitySpawned +=
                projectile => projectile.AddSpritesToLayers(LightLayer, InfoLayer);

            CannonProjectileFactory.Initialize(ContentManagerName);
            CannonProjectileFactory.EntitySpawned +=
                projectile => projectile.AddSpritesToLayers(LightLayer, InfoLayer);

            ElectricProjectileFactory.Initialize(ContentManagerName);
            ElectricProjectileFactory.EntitySpawned +=
                projectile => projectile.AddSpritesToLayers(LightLayer, InfoLayer);

            FireProjectileFactory.Initialize(ContentManagerName);
            FireProjectileFactory.EntitySpawned +=
                projectile => projectile.AddSpritesToLayers(LightLayer, InfoLayer);

            FrostProjectileFactory.Initialize(ContentManagerName);
            FrostProjectileFactory.EntitySpawned +=
                projectile => projectile.AddSpritesToLayers(LightLayer, InfoLayer);

            ChemicalProjectileFactory.Initialize(ContentManagerName);
            ChemicalProjectileFactory.EntitySpawned +=
                projectile => projectile.AddSpritesToLayers(LightLayer, InfoLayer);

            //Towers
            BombardingTowerFactory.Initialize(ContentManagerName);
            BombardingTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            ChemicalTowerFactory.Initialize(ContentManagerName);
            ChemicalTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            ElectricTowerFactory.Initialize(ContentManagerName);
            ElectricTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            FireTowerFactory.Initialize(ContentManagerName);
            FireTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            FrostTowerFactory.Initialize(ContentManagerName);
            FrostTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            PiercingTowerFactory.Initialize(ContentManagerName);
            PiercingTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            //Enemies
            Chicken1EnemyFactory.Initialize(ContentManagerName);
            Chicken1EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Chicken2EnemyFactory.Initialize(ContentManagerName);
            Chicken2EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Chicken3EnemyFactory.Initialize(ContentManagerName);
            Chicken3EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Cow1EnemyFactory.Initialize(ContentManagerName);
            Cow1EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Cow2EnemyFactory.Initialize(ContentManagerName);
            Cow2EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Cow3EnemyFactory.Initialize(ContentManagerName);
            Cow3EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Pig1EnemyFactory.Initialize(ContentManagerName);
            Pig1EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Pig2EnemyFactory.Initialize(ContentManagerName);
            Pig2EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Pig3EnemyFactory.Initialize(ContentManagerName);
            Pig3EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Sheep1EnemyFactory.Initialize(ContentManagerName);
            Sheep1EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Sheep2EnemyFactory.Initialize(ContentManagerName);
            Sheep2EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Sheep3EnemyFactory.Initialize(ContentManagerName);
            Sheep3EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Rabbit1EnemyFactory.Initialize(ContentManagerName);
            Rabbit1EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Rabbit2EnemyFactory.Initialize(ContentManagerName);
            Rabbit2EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };

            Rabbit3EnemyFactory.Initialize(ContentManagerName);
            Rabbit3EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(WorldLayer, LightLayer, InfoLayer);
                    enemy.OnDeath += MachineLearningManager.UpdateWaveScore;
                };
        }
    }
}
