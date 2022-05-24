using System;
using Programming.Service;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильмах.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Минимальное значение года.
        /// </summary>
        public const int MinYear = 1900;

        /// <summary>
        /// Минимальное значение рейтинга.
        /// </summary>
        private const int MinRating = 0;

        /// <summary>
        /// Максимальное значение рейтинга.
        /// </summary>
        private const int MaxRating = 10;

        /// <summary>
        /// Уникальный идентификатор для всех экзепляров этого класса.
        /// </summary>
        private static int _counter = 1;

        /// <summary>
        /// Продолжительность.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год релиза.
        /// </summary>
        private int _year;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private int _rating;

        /// <summary>
        /// Идентификатор. Доступен только для чтения.
        /// </summary>
        private readonly int _id;
        
        /// <summary>
        /// Возвращает или задает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает или задает название жанра.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Создает екземпляр <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
            _id = _counter++;
        }

        /// <summary>
        /// Создает екземпляр <see cref="Movie"/>.
        /// </summary>
        /// <param name="duration">Продолжительность фильма.</param>
        /// <param name="year">Год релиза.</param>
        /// <param name="rating">Рейтинг.</param>
        /// <param name="name">Название.</param>
        /// <param name="genre">Жанр.</param>
        public Movie(int duration, int year, int rating, string name, string genre)
        {
            Duration = duration;
            Year = year;
            Rating = rating;
            Name = name;
            Genre = genre;
            _id = _counter++;
        }

        /// <summary>
        /// Возвращает или задает название жанра. Значение должно быть положительным.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает или задает год релиза.
        /// Значение должно быть между <see cref="MinYear"/> и текущим годом.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                Validator.AssertOnPositiveValue(value, MinYear, DateTime.Now.Year, nameof(Year));
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает или задает рейтинг.
        /// Значение должно быть между <see cref="MinRating"/> и <see cref="MaxRating"/>.
        /// </summary>
        public int Rating
        {
            get => _rating;
            set
            {
                Validator.AssertOnPositiveValue(value, MinRating, MaxRating, nameof(Rating));
                _rating = value;
            }
        }

        public override string ToString()
        {
            return GetType().Name + " " + _id;
        }
    }
}