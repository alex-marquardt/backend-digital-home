using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using backend_digital_home.Core;
using backend_digital_home.Core.DataProviders;
using backend_digital_home.Core.Models;
using backend_digital_home.Data.Models;
using Dapper;

namespace backend_digital_home.DataProviders
{
    public class GenreDataProvider : IGenreDataProvider
    {
        private readonly IConnectionHelper _connectionHelper;

        // constructor
        public GenreDataProvider(IConnectionHelper connectionHelper)
        {
            _connectionHelper = connectionHelper;
        }

        // Get all genres
        public async Task<IEnumerable<IGenre>> GetAllGenres()
        {
            using (var conn = new SqlConnection(_connectionHelper.GetConnectionString()))
            {
                conn.Open();

                return conn.Query<Genre>("SelectAllGenres", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
