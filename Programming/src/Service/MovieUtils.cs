using System;
using Programming.Model;
using Programming.Model.Enum;

namespace Programming.Service
{
    public class MovieUtils
    {
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