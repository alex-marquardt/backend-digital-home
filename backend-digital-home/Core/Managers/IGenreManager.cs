using System.Collections.Generic;
using System.Threading.Tasks;
using backend_digital_home.Core.Models;

namespace backend_digital_home.Core.Managers
{
    public interface IGenreManager
    {
        Task<IEnumerable<IGenre>> GetAllGenres();
    }
}
