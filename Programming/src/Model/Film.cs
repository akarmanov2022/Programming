using System;

namespace Programming.Model
{
    public class Film
    {
        public const int MinYear = 1900;

        private static int _counter = 1;

        private int _duration;
        private int _year;
        private double _rating;
        private readonly int _id;

        public string Name { get; set; }

        public string Genre { get; set; }

        public Film()
        {
            _id = _counter++;
        }

        public Film(int duration, int year, double rating, string name, string genre)
        {
            Duration = duration;
            Year = year;
            Rating = rating;
            Name = name;
            Genre = genre;
            _id = _counter++;
        }

        public int Duration
        {
            get => _duration;
            set => _duration =
                value >= 0 ? value : throw new ArgumentException($"Duration < 0: {value}");
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value < MinYear)
                {
                    throw new ArgumentException($"Year < ${MinYear}: {value}");
                }

                if (value > DateTime.Now.Year)
                {
                    throw new ArgumentException($"Year > ${DateTime.Now.Year}: {value}");
                }

                _year = value;
            }
        }

        public double Rating
        {
            get => _rating;
            set
            {
                if (value < 0d || value > 1d)
                {
                    throw new ArgumentException($"Rating > 1 or Rating < 0: {value}");
                }

                _rating = value;
            }
        }

        public override string ToString()
        {
            return GetType().Name + " " + _id;
        }
    }
}