using System;
using Programming.Model;
using Programming.Model.Enum;

namespace Programming.Service
{
    /// <summary>
    /// Статический класс - фабрика объектов типа <see cref="Movie"/>.
    /// </summary>
    public class MovieFactory
    {
        /// <summary>
        /// Создает экземпляры класса <see cref="Movie"/> в обределенном кол-ве со случайными значениями полей.
        /// </summary>
        /// <param name="count">Кол-во объектов.</param>
        /// <returns>Массив объектов типа <see cref="Movie"/>.</returns>
        public static Movie[] GenerateRandomMovies(int count)
        {
            var random = new Random();
            var movies = new Movie[count];
            var genres = Enum.GetValues(typeof(Genre));
            for (var i = 0; i < movies.Length; i++)
            {
                var genreRandomIndex = random.Next(0, genres.Length);
                var genre = genres.GetValue(genreRandomIndex);
                movies[i] = new Movie
                {
                    Genre = genre.ToString(),
                    Duration = random.Next(200),
                    Year = random.Next(Movie.MinYear, DateTime.Now.Year),
                    Rating = random.Next(10),
                    Name = $"{genre}Movie{random.Next(100)}"
                };
            }

            return movies;
        }
        
        /// <summary>
        /// Найдет идентификатор объекта типа <see cref="Movie"/>
        /// с минимальным значением рейтинга из входного массива объектов типа <see cref="Movie"/>.
        /// </summary>
        /// <param name="movies">Входной массив объектов типа <see cref="Movie"/>.</param>
        /// <returns>Идентификатор объекта типа <see cref="Movie"/>.</returns>
        public static int FindMovieWithMaxRating(Movie[] movies)
        {
            var maxRating = movies[0].Rating;
            var filmId = 0;
            for (var i = 1; i < movies.Length; i++)
            {
                if (!(maxRating < movies[i].Rating)) continue;
                maxRating = movies[i].Rating;
                filmId = i;
            }

            return filmId;
        }
    }
}