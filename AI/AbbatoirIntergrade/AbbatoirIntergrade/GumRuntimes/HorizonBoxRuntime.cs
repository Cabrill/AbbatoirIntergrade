﻿using System;
using FlatRedBall;
using AbbatoirIntergrade.GameClasses.Interfaces;
using AbbatoirIntergrade.StaticManagers;
using AbbatoirIntergrade.SunMoonCalculations;
using Microsoft.Xna.Framework;
using static System.Math;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class HorizonBoxRuntime
    {
        private Color NightTimeColor;
        private Color DayTimeColor;

        public bool SunAboveHorizon => SunSprite.Y >= SkyRectangle.Y;
        public bool MoonAboveHorizon => MoonSprite.Y >= SkyRectangle.Y;

        public float SunPercentageAboveHorizon =>
            MathHelper.Clamp(SunSprite.Y / SunSprite.GetAbsoluteHeight(), 0f, 1f);
        public float MoonPercentageAboveHorizon =>
            MathHelper.Clamp(MoonSprite.Y / MoonSprite.GetAbsoluteHeight(), 0f, 1f);
        private float SunPercentageBelowHorizon =>
            MathHelper.Clamp(SunSprite.Y / -SunSprite.GetAbsoluteHeight(), 0f, 1f);
        
        public void Initialize(DateTime timeOfDay)
        {
            Update(timeOfDay);
        }

        partial void CustomInitialize()
        {
            var xOffset = FlatRedBallServices.Random.Between(-3, 3);
            var yOffset = Math.Sign(xOffset) == -1
                ? FlatRedBallServices.Random.Between(0, 3)
                : FlatRedBallServices.Random.Between(-3, 0);
            
            StarrySkySprite.X = 50 + xOffset;
            StarrySkySprite.Y = 50 + yOffset;
            DayTimeColor = new Color(SkyRectangle.Red, SkyRectangle.Green, SkyRectangle.Blue);
            NightTimeColor = new Color(0, 50, 125);

            if (CloudCoverSprite.Visible) MoveStaticCloudsAnimation.Play();
        }

        public void ReactToCameraChange()
        {
            Width = 100 * CameraZoomManager.GumCoordOffset;
            Height = 100 * CameraZoomManager.GumCoordOffset;
            X = -Camera.Main.X * CameraZoomManager.GumCoordOffset;
            Y = -Camera.Main.Y * CameraZoomManager.GumCoordOffset;
        }

        public void Update(DateTime timeOfDay)
        {
            UpdateSunAndMoon(timeOfDay);
            UpdateStarrySky(timeOfDay);
            UpdateForeground(timeOfDay);
        }

        private void UpdateForeground(DateTime timeOfDay)
        {
            var visibility = (int)(30f + (225f * SunPercentageAboveHorizon));
            ForegroundSprite.Red = visibility;
            ForegroundSprite.Green = visibility;
            ForegroundSprite.Blue = visibility;
        }

        private void UpdateStarrySky(DateTime timeOfDay)
        {
            StarrySkySprite.Rotation = (float)(timeOfDay.TimeOfDay.TotalSeconds % 86400) * -0.020835f;

            var skyOpacity = 1 - Max(0,SunPercentageBelowHorizon - 0.5f)*2;

            SkyRectangle.Alpha = (int) (255 * skyOpacity);
            SkyHazeSprite.Alpha = (int)(200 * SunPercentageAboveHorizon);

            var inverseSun = 1 - SunPercentageAboveHorizon;

            SkyRectangle.Red = (int)   ((SunPercentageAboveHorizon * DayTimeColor.R) + (inverseSun * NightTimeColor.R));
            SkyRectangle.Green = (int) ((SunPercentageAboveHorizon * DayTimeColor.G) + (inverseSun * NightTimeColor.G));
            SkyRectangle.Blue = (int)  ((SunPercentageAboveHorizon * DayTimeColor.B) + (inverseSun * NightTimeColor.B));

            DawnDuskSprite.Alpha = MathHelper.Clamp((int) (255 * (1 - SunPercentageAboveHorizon-SunPercentageBelowHorizon*2)),0,255);
            DawnDuskSprite.Height = 75f + (25f * SunPercentageAboveHorizon);

            StarrySkySprite.Visible = SkyRectangle.Alpha < 255;
        }

        private void UpdateSunAndMoon(DateTime timeOfDay)
        {
            var _radius = SunMoonContainer.GetAbsoluteHeight() / 2;
            var aspectAdjustment = SunMoonContainer.GetAbsoluteHeight() / SunMoonContainer.GetAbsoluteWidth();

            var sunPosition =
                SunAndMoonCalculation.GetSunPosition(timeOfDay, 49.2827, 123.1207);

            SphericalToCartesian(_radius, sunPosition.Azimuth, sunPosition.Altitude, out Vector3 newSunPosition);
            SunSprite.X = newSunPosition.X / aspectAdjustment;
            SunSprite.Y = newSunPosition.Y;

            var moonPosition =
                SunAndMoonCalculation.GetMoonPosition(timeOfDay, 49.2827, 123.1207);

            SphericalToCartesian(_radius, moonPosition.Azimuth, moonPosition.Altitude, out Vector3 newMoonPosition);

            MoonSprite.X = newMoonPosition.X /aspectAdjustment;
            MoonSprite.Y = newMoonPosition.Y;

            MoonSprite.Red = (int)(0.25f + (1f - SunPercentageAboveHorizon) * 0.75f) * 255;
            MoonSprite.Green = (int)(0.25f + (1f - SunPercentageAboveHorizon) * 0.75f) * 255;
            MoonSprite.Blue = (int)(0.25f + (1f - SunPercentageAboveHorizon) * 0.75f) * 255;
            MoonSprite.Alpha = (int)(0.5f + (1f - SunPercentageAboveHorizon) * 0.5f) * 255;
        }

        private static void SphericalToCartesian(float radius, double azimuth, double altitude, out Vector3 outCart)
        {
            var a = radius * (float)Math.Cos(altitude);
            outCart.X = -a * (float)Math.Sin(azimuth); 
            outCart.Y = radius * (float)Math.Sin(altitude);
            outCart.Z = a * (float)Math.Cos(azimuth);
        }
    }
}
