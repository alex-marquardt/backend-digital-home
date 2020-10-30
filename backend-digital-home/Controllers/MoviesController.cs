using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backend_digital_home.Core.Models;
using backend_digital_home.Core.Managers;

namespace backend_digital_home.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieManager _movieManager;

        // constructor
        public MoviesController(IMovieManager movieManager)
        {
            _movieManager = movieManager;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public async Task<IEnumerable<IMovie>> GetAllMovies()
        {
            return await _movieManager.GetAllMovies();
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public Task<IMovie> GetMovieById(int id)
        {
            return _movieManager.GetMovieById(id);
        }
    }
}
