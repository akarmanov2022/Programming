using System;
using Programming.Service;

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
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 23, nameof(Hours));
                _hours = value;
            }
        }

        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 59, nameof(Minutes));
                _minutes = value;
            }
        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 59, nameof(Seconds));
                _seconds = value;
            }
        }
    }
}