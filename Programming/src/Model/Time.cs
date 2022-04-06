using System;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public Time()
        {
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Hours
        {
            get => _hours;
            set => _hours = Validator.AssertOnPositiveValue(value, 0, 23, nameof(Hours));
        }

        public int Minutes
        {
            get => _minutes;
            set => _minutes = Validator.AssertOnPositiveValue(value, 0, 59, nameof(Minutes));
        }

        public int Seconds
        {
            get => _seconds;
            set => _seconds = Validator.AssertOnPositiveValue(value, 0, 59, nameof(Seconds));
        }
    }
}