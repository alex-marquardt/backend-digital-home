using System.Collections.Generic;
using System.Threading.Tasks;
using backend_digital_home.Core.DataProviders;
using backend_digital_home.Core.Managers;
using backend_digital_home.Core.Models;

namespace backend_digital_home.Managers
{
    public class GenreManager : IGenreManager
    {
        private readonly IGenreDataProvider _genreDataProvider;

        // constructor
        public GenreManager(IGenreDataProvider genreDataProvider)
        {
            _genreDataProvider = genreDataProvider;
        }

        // Get all genres
        public Task<IEnumerable<IGenre>> GetAllGenres()
        {
            return _genreDataProvider.GetAllGenres();
        }
    }
}
