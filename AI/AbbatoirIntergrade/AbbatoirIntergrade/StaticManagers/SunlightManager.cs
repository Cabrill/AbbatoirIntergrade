using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.GumRuntimes;

namespace AbbatoirIntergrade.StaticManagers
{
    /// <summary>
    /// This class tracks how effective sunlight is in the current conditions
    /// </summary>
    public static class SunlightManager
    {
        public static float SunlightEffectiveness { get; private set; } = 1f;
        public static bool SunIsUp { get; private set; }
        public static bool MoonIsUp { get; private set; }

        private static HorizonBoxRuntime _horizon;
        private static DateTime _lastUpdate;

        public static void Initialize(HorizonBoxRuntime horizonBox, DateTime gameDateTime)
        {
            _horizon = horizonBox;
            SunlightEffectiveness = 1f;
            SunIsUp = true;
            MoonIsUp = false;

            _lastUpdate = gameDateTime;
        }

        public static void UpdateConditions(DateTime gameDateTime)
        {
            SunIsUp = _horizon.SunAboveHorizon;
            MoonIsUp = _horizon.MoonAboveHorizon;

            if (SunIsUp)
            {
                SunlightEffectiveness = GetSunEffectiveness();
            }
            else if (MoonIsUp)
            {
                SunlightEffectiveness = GetMoonEffectiveness();
            }
            else
            {
                SunlightEffectiveness = _horizon.SunAboveHorizon
                    ? GetSunEffectiveness()
                    : GetMoonEffectiveness();
            }
        }

        private static float GetSunEffectiveness()
        {
            return  _horizon.SunPercentageAboveHorizon;
        }

        private static float GetMoonEffectiveness()
        {
            //Moonlight is 1/345th as effective as sunlight for powering solar panels
            //https://www.quora.com/Can-moon-light-produce-electricity-from-solar-panels-at-night-Can-moon-light-generate-the-electron-hole-pair-in-a-solar-cell
            return _horizon.MoonPercentageAboveHorizon/345;
        }
    }
}
