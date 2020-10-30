using System;
using System.Collections.Generic;
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
            return await _movieDataProvider.GetAllMovies();
        }

        public async Task<IMovie> GetMovieById(int id)
        {
            return await _movieDataProvider.GetMovieById(id);
        }
    }
}
