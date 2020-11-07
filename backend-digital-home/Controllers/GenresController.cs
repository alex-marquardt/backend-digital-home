using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backend_digital_home.Core.Models;
using backend_digital_home.Core.Managers;

namespace backend_digital_home.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreManager _genreManager;
        
        // constructor
        public GenresController(IGenreManager genreManager)
        {
            _genreManager = genreManager;
        }

        // GET: api/<GenresController>
        [HttpGet]
        public Task<IEnumerable<IGenre>> GetAllGenres()
        {
            return _genreManager.GetAllGenres();           
        }
    }
}
