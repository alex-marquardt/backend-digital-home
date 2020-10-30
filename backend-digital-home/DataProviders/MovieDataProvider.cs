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
    public class MovieDataProvider : IMovieDataProvider
    {
        private readonly IConnectionHelper _connectionHelper;

        // constructor
        public MovieDataProvider(IConnectionHelper connectionHelper)
        {
            _connectionHelper = connectionHelper;
        }

        // Get all movies
        public async Task<IEnumerable<IMovie>> GetAllMovies()
        {
            using (var conn = new SqlConnection(_connectionHelper.GetConnectionString()))
            {
                conn.Open();

                return conn.Query<Movie>("SelectAllMovies", commandType: CommandType.StoredProcedure).ToList();
            }          
        }

        // Get a movie by id
        public async Task<IMovie> GetMovieById(int id)
        {
            using (var conn = new SqlConnection(_connectionHelper.GetConnectionString()))
            {
                conn.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);

                return await conn.QueryFirstOrDefaultAsync<Movie>("SelectMovieById", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
