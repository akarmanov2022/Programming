using System;
using Programming.Service;

namespace Programming.Model
{
    public class Film
    {
        public const int MinYear = 1900;

        private static int _counter = 1;

        private int _duration;
        private int _year;
        private int _rating;
        private readonly int _id;

        public string Name { get; set; }

        public string Genre { get; set; }

        public Film()
        {
            _id = _counter++;
        }

        public Film(int duration, int year, int rating, string name, string genre)
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
            set => _duration = Validator.AssertOnPositiveValue(value, nameof(Duration));
        }

        public int Year
        {
            get => _year;
            set => _year = Validator.AssertOnPositiveValue(value, MinYear, DateTime.Now.Year, nameof(Year));
        }

        public int Rating
        {
            get => _rating;
            set => _rating = Validator.AssertOnPositiveValue(value, 0, 10, nameof(Rating));
        }

        public override string ToString()
        {
            return GetType().Name + " " + _id;
        }
    }
}