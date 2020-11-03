using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_digital_home.Core.DataProviders;
using backend_digital_home.Core.Managers;
using backend_digital_home.Core.Models;

namespace backend_digital_home.Managers
{
    public class MovieManager : IMovieManager
    {
        private readonly IMovieDataProvider _movieDataProvider;

        // constructor
        public MovieManager(IMovieDataProvider movieDataProvider)
        {
            _movieDataProvider = movieDataProvider;
        }

        public async Task<IEnumerable<IMovie>> GetAllMovies()
        {
            List<IMovie> movies = new List<IMovie>();

            foreach (var movie in await _movieDataProvider.GetAllMovies())
            {
                movies.Add(await AddGenresToMovie(movie));
            }

            return movies;
        }

        public async Task<IMovie> GetMovieById(int id)
        {
            IMovie movie = await _movieDataProvider.GetMovieById(id);
            movie = await AddGenresToMovie(movie);

            return movie;
        }

        public async Task<IEnumerable<IMovie>> GetMoviesByGenre(string genreName)
        {
            List<IMovie> movies = new List<IMovie>();

            foreach (var movie in await _movieDataProvider.GetMoviesByGenre(genreName))
            {
                movies.Add(await AddGenresToMovie(movie));
            }

            return movies;
        }

        private async Task<IMovie> AddGenresToMovie(IMovie movie)
        {
            IEnumerable<IGenre> genres = await _movieDataProvider.GetGenresForMovie(movie.Id);
            movie.genres = new List<string>();

            foreach (var genre in genres)
            {
                movie.genres.Add(genre.Name);                
            }

            return movie;
        }
    }
}
