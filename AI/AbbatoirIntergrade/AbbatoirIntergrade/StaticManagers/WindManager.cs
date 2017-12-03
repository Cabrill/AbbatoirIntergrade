using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall;
using FlatRedBall.Glue.StateInterpolation;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GameClasses.Interfaces;
using Microsoft.Xna.Framework;
using StateInterpolationPlugin;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class WindManager
    {
        private static List<float> _nineHourForecast;

        public static List<float> NineHourForecast => _nineHourForecast;

        private static Random random;
        private static ICity city;

        public static float windSpeed{ get; private set; } = 1f; //in m/s

        private const int _secondsBetweenUpdates = 8;
        private static DateTime _lastUpdate;

        public static void Initialize(DateTime gameDateTime)
        {
            random = new Random((int)gameDateTime.Ticks);

            windSpeed = 5;

            _nineHourForecast = new List<float>(8);

            var prevWindSpeed = windSpeed;
            _nineHourForecast.Add(windSpeed);

            for (var i = 1; i < 9; i++)
            {
                prevWindSpeed = GenerateWindConditions(prevWindSpeed, gameDateTime.AddHours(i));
                _nineHourForecast.Add(prevWindSpeed);
            }
            _lastUpdate = gameDateTime;
        }

        public static void Update(DateTime gameDateTime)
        {
            if ((gameDateTime - _lastUpdate).Hours >= 1)
            {
                _lastUpdate = gameDateTime;

                var speedToPredictFrom = _nineHourForecast[_nineHourForecast.Count-1];
                var oldWindSpeed = _nineHourForecast[0];

                _nineHourForecast.RemoveAt(0);

                _nineHourForecast.Add(GenerateWindConditions(speedToPredictFrom, gameDateTime.AddHours(8)));

                var newWindSpeed = _nineHourForecast[0];

                var shiftTime = FlatRedBallServices.Random.Between(1, _secondsBetweenUpdates);

                var windSpeedTweener = new Tweener();
                windSpeedTweener = new Tweener(0, 1, shiftTime, InterpolationType.Bounce, Easing.InOut);
                windSpeedTweener.PositionChanged += (a) =>
                {
                    windSpeed = ((1-a) * oldWindSpeed) + (a * newWindSpeed);
                };
                windSpeedTweener.Start();
                TweenerManager.Self.Add(windSpeedTweener);
            }
        }

        private static float GenerateWindConditions(float oldWindSpeed, DateTime gameDateTime)
        {
            var averageWindSpeedForCityAndDate = 5;//DailyWindSpeedForCityAndDate(city, gameDateTime);

            var probOfIncrease = 0.5f;
            var probOfDecrease = probOfIncrease * 1.1f;

            if (oldWindSpeed > averageWindSpeedForCityAndDate)
            {
                probOfIncrease /= 2;
                probOfDecrease = (1 - probOfIncrease) / 2;
            }
            else if (oldWindSpeed < averageWindSpeedForCityAndDate)
            {
                probOfIncrease *= 2;
                probOfDecrease = (1 - probOfIncrease) / 2;
            }

            var randomChanceOfWindChange = random.NextDouble();

            var incOrDecMod = 0;

            if (probOfIncrease >= randomChanceOfWindChange)
            {
                incOrDecMod = 1;
            }
            else if (probOfDecrease >= randomChanceOfWindChange)
            {
                incOrDecMod = -1;
            }
            else
            {
                return oldWindSpeed;
            }

            var msPerScale = 3.5f * random.NextDouble();
            float newWindSpeed = (float)Math.Max(0f, oldWindSpeed + (msPerScale * incOrDecMod));

            return newWindSpeed;
        }
    }
}
