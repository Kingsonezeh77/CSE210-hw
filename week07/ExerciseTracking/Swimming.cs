﻿namespace FitnessApp
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, int duration, int laps) : base(date, duration)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * 50 / 1000.0; // Distance in kilometers
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Duration) * 60;
        }

        public override double GetPace()
        {
            return Duration / GetDistance();
        }
    }
}