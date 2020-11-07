using System.Collections.Generic;
using System.Threading.Tasks;
using backend_digital_home.Core.Models;

namespace backend_digital_home.Core.DataProviders
{
    public interface IGenreDataProvider
    {
        Task<IEnumerable<IGenre>> GetAllGenres();

    }
}
