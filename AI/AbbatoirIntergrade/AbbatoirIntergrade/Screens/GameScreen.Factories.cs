using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Factories;

namespace AbbatoirIntergrade.Screens
{
    public partial class GameScreen
    {

        private void InitializeFactories()
        {
            StructurePlacementFactory.EntitySpawned +=
                placement => placement.AddSpritesToLayers(LightLayer, InfoLayer);

            //Projectiles
            LaserTurretProjectileFactory.Initialize(ContentManagerName);
            LaserTurretProjectileFactory.AddList(PlayerProjectileList);
            LaserTurretProjectileFactory.EntitySpawned +=
                projectile => projectile.AddSpritesToLayers(LightLayer, InfoLayer);

            CannonProjectileFactory.Initialize(ContentManagerName);
            CannonProjectileFactory.AddList(PlayerProjectileList);
            CannonProjectileFactory.EntitySpawned +=
                projectile => projectile.AddSpritesToLayers(LightLayer, InfoLayer);

            TallLaserProjectileFactory.Initialize(ContentManagerName);
            TallLaserProjectileFactory.AddList(PlayerProjectileList);
            TallLaserProjectileFactory.EntitySpawned +=
                projectile => projectile.AddSpritesToLayers(LightLayer, InfoLayer);

            //Towers
            BombardingTowerFactory.Initialize(ContentManagerName);
            BombardingTowerFactory.AddList(AllStructuresList);
            BombardingTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            ChemicalTowerFactory.Initialize(ContentManagerName);
            ChemicalTowerFactory.AddList(AllStructuresList);
            ChemicalTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            ElectricTowerFactory.Initialize(ContentManagerName);
            ElectricTowerFactory.AddList(AllStructuresList);
            ElectricTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            FireTowerFactory.Initialize(ContentManagerName);
            FireTowerFactory.AddList(AllStructuresList);
            FireTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            FrostTowerFactory.Initialize(ContentManagerName);
            FrostTowerFactory.AddList(AllStructuresList);
            FrostTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            PiercingTowerFactory.Initialize(ContentManagerName);
            PiercingTowerFactory.AddList(AllStructuresList);
            PiercingTowerFactory.EntitySpawned +=
                turrent => turrent.AddSpritesToLayers(LightLayer, InfoLayer);

            //Enemies
            Chicken1EnemyFactory.Initialize(ContentManagerName);
            Chicken1EnemyFactory.AddList(AllEnemiesList);
            Chicken1EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Chicken2EnemyFactory.Initialize(ContentManagerName);
            Chicken2EnemyFactory.AddList(AllEnemiesList);
            Chicken2EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Chicken3EnemyFactory.Initialize(ContentManagerName);
            Chicken3EnemyFactory.AddList(AllEnemiesList);
            Chicken3EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Cow1EnemyFactory.Initialize(ContentManagerName);
            Cow1EnemyFactory.AddList(AllEnemiesList);
            Cow1EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Cow2EnemyFactory.Initialize(ContentManagerName);
            Cow2EnemyFactory.AddList(AllEnemiesList);
            Cow2EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Cow3EnemyFactory.Initialize(ContentManagerName);
            Cow3EnemyFactory.AddList(AllEnemiesList);
            Cow3EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Pig1EnemyFactory.Initialize(ContentManagerName);
            Pig1EnemyFactory.AddList(AllEnemiesList);
            Pig1EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Pig2EnemyFactory.Initialize(ContentManagerName);
            Pig2EnemyFactory.AddList(AllEnemiesList);
            Pig2EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Pig3EnemyFactory.Initialize(ContentManagerName);
            Pig3EnemyFactory.AddList(AllEnemiesList);
            Pig3EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Sheep1EnemyFactory.Initialize(ContentManagerName);
            Sheep1EnemyFactory.AddList(AllEnemiesList);
            Sheep1EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Sheep2EnemyFactory.Initialize(ContentManagerName);
            Sheep2EnemyFactory.AddList(AllEnemiesList);
            Sheep2EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };

            Sheep3EnemyFactory.Initialize(ContentManagerName);
            Sheep3EnemyFactory.AddList(AllEnemiesList);
            Sheep3EnemyFactory.EntitySpawned +=
                enemy =>
                {
                    enemy.AddSpritesToLayers(LightLayer, InfoLayer);
                    enemy.OnDeath += CreateResourceNotification;
                };
        }
    }
}
