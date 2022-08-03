using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NexturnMovies.Business.Interfaces;
using NexturnMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NexturnMoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly ILogger<MovieController> _logger;
        private readonly IMovieBusiness _movieBusiness;

        public MovieController(IMovieBusiness movieBusiness)
        {
            _movieBusiness = movieBusiness;

        }
        [HttpGet]
        public IActionResult Display()
        {
            List<MovieVM> cust = _movieBusiness.GetMovies();
            return Ok(cust);

        }
    }
}
