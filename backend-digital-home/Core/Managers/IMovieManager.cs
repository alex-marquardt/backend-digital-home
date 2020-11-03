using System.Collections.Generic;
using System.Threading.Tasks;
using backend_digital_home.Core.Models;

namespace backend_digital_home.Core.Managers
{
    public interface IMovieManager
    {
        Task<IEnumerable<IMovie>> GetAllMovies();

        Task<IMovie> GetMovieById(int id);

        Task<IEnumerable<IMovie>> GetMoviesByGenre(string genreName);
    }
}
