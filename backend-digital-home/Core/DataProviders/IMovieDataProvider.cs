using System.Collections.Generic;
using System.Threading.Tasks;
using backend_digital_home.Core.Models;

namespace backend_digital_home.Core.DataProviders
{
    public interface IMovieDataProvider
    {
        Task<IEnumerable<IMovie>> GetAllMovies();

        Task<IMovie> GetMovieById(int id);
    }
}
