using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.StaticManagers;
using Microsoft.Xna.Framework;

namespace AbbatoirIntergrade.GumRuntimes.infodisplays
{
    public partial class EnemyInfoRuntime
    {
        public void Show(BaseEnemy enemy)
        {

            var isEnemyOnScreen =  enemy.X >= Camera.Main.X - Camera.Main.OrthogonalWidth / 2 &&
                                   enemy.X <= Camera.Main.X + Camera.Main.OrthogonalWidth / 2 &&
                                   enemy.Y >= Camera.Main.Y - Camera.Main.OrthogonalHeight / 2 &&
                                   enemy.Y <= Camera.Main.Y + Camera.Main.OrthogonalHeight / 2;

            Visible = isEnemyOnScreen;

            if (Visible)
            {
                var minMaxX = (CameraZoomManager.OriginalOrthogonalWidth - GetAbsoluteWidth()) / 2;
                var minMaxY = (CameraZoomManager.OriginalOrthogonalHeight - GetAbsoluteHeight()) / 2;

                var newX = (enemy.X - Camera.Main.X) * CameraZoomManager.GumCoordOffset;
                var newY = (enemy.Y - Camera.Main.Y + enemy.SpriteInstance.Height / 2) * CameraZoomManager.GumCoordOffset + GetAbsoluteHeight() / 2;

                X = MathHelper.Clamp(newX, -minMaxX, minMaxX);
                Y = MathHelper.Clamp(newY, -minMaxY, minMaxY);

                EnemyName = enemy.DisplayName;
                HealthDisplay.AttributeText = $"{enemy.HealthRemaining:##0} / {enemy.MaximumHealth:##0}";
                SpeedDisplay.AttributeText = $"{enemy.EffectiveSpeed:##0}";

                PiercingResist.SetResistanceText(enemy.EffectivePiercingResist);
                BombardResist.SetResistanceText(enemy.EffectiveBombardResist);
                ChemicalResist.SetResistanceText(enemy.EffectiveChemicalResist);
                FireResist.SetResistanceText(enemy.EffectiveFireResist);
                FrostResist.SetResistanceText(enemy.EffectiveFrostResist);
                ElectricResist.SetResistanceText(enemy.EffectiveElectricResist);
            }
        }

        public void Hide()
        {
            Visible = false;
        }
    }
}
