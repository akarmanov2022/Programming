using System;
using static Programming.Service.Validator;

namespace Programming.Model
{
    public class Movie
    {
        public const int MinYear = 1900;

        private const int MinRating = 0;

        private const int MaxRating = 10;

        private static int _counter = 1;

        private int _duration;

        private int _year;

        private int _rating;

        private readonly int _id;

        public string Name { get; set; }

        public string Genre { get; set; }

        public Movie()
        {
            _id = _counter++;
        }

        public Movie(int duration, int year, int rating, string name, string genre)
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
            set
            {
                AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                AssertOnPositiveValue(value, MinYear, DateTime.Now.Year, nameof(Year));
                _year = value;
            }
        }

        public int Rating
        {
            get => _rating;
            set
            {
                AssertOnPositiveValue(value, MinRating, MaxRating, nameof(Rating));
                _rating = value;
            }
        }

        public override string ToString()
        {
            return GetType().Name + " " + _id;
        }
    }
}