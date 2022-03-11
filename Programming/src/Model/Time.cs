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
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Hours < 0: {value}");
                }

                if (value > 24)
                {
                    throw new ArgumentException($"Hours > 24: {value}");
                }

                _hours = value;
            }
        }

        public int Minutes
        {
            get => _minutes;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Minutes < 0: {value}");
                }

                if (value > 60)
                {
                    throw new ArgumentException($"Minutes > 60: {value}");
                }

                _minutes = value;
            }
        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Seconds < 0: ${value}");
                }

                if (value > 60)
                {
                    throw new ArgumentException($"Seconds > 60: ${value}");
                }

                _seconds = value;
            }
        }
    }
}