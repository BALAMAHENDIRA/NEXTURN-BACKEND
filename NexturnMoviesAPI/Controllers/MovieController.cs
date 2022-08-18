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
        [Route("GetMovies")]
        public IActionResult Display()
        {
            List<MovieVM> cust = _movieBusiness.GetMovies();
            return Ok(cust);

        }

        [HttpGet]
        [Route("GetCities")]
        public IActionResult Display1()
        {
            List<CityVM> A = _movieBusiness.GetCities();
            return Ok(A);
        }

        [HttpGet]
        [Route("GetTheaters")]
        public IActionResult GetTheaters(int CityId)
        {
            List<TheatreVM> B = _movieBusiness.GetTheatres(CityId);
            return Ok(B);
        }


        [HttpGet]
        [Route("GetTheatersById")]
        public IActionResult GetTheatersById(int TheatreId)
        {
            List<TheatreVM> B = _movieBusiness.GetTheatersById(TheatreId);
            return Ok(B);
        }


        [HttpGet]
        [Route("GetStartTimeTheater")]
        public IActionResult GetStartTimeTheater(int MovieId)
        {
            List<ShowTheaterVM> B = _movieBusiness.GetStartTimeTheater(MovieId);
            return Ok(B);
        }

        [HttpGet]
        [Route("GetMovieCasts")]
        public IActionResult GetMovieCasts(int MovieId)
        {
            List<MovieCastVM> B = _movieBusiness.GetMovieCasts(MovieId);
            return Ok(B);
        }

        [HttpGet]
        [Route("GetAllMovies")]
        public IActionResult GetAllMovies(int CityId)
        {
            List<CityMovieVM> B = _movieBusiness.GetAllMovies(CityId);
            return Ok(B);
        }


        [HttpGet]
        [Route("GetAllMoviesByTheatre")]
        public IActionResult GetAllMoviesByTheatre(int theatreId)
        {
            List<CityMovieVM> B = _movieBusiness.GetAllMoviesByTheatre(theatreId);
            return Ok(B);
        }

        [HttpGet]
        [Route("GetAllBookedSeats")]
        public IActionResult GetAllBookedSeats(int TheaterId, string StartTime, string Date)
        {
            List<ShowBookingVM> B = _movieBusiness.GetAllBookedSeats(TheaterId,StartTime,Date);
            return Ok(B);
        }

        [HttpGet]
        [Route("GetshowDetais")]
        public IActionResult GetshowDetails(int MovieID, int CityID)
        {
            List<detailsbymovieVM> tune = _movieBusiness.GetshowDetails(MovieID, CityID);
            return Ok(tune);
        }

        [HttpGet]
        [Route("PostDetails")]

        public IActionResult updateBooking(int price, int seatNum, int seatDetail, int theatreId, string date, string start)
        {
            var list = _movieBusiness.updateBooking(price, seatNum, seatDetail, theatreId, date, start);
            return Ok(list);
        }


        [HttpGet]
        [Route("GetStartTimeTheatreByDate")]
        public IActionResult GetStartTimeTheatreByDate(string date)
        {

            List<ShowTheaterVM> B = _movieBusiness.GetStartTimeTheatreByDate(date);
            return Ok(B);
        }

        [HttpGet]
        [Route("GetshowDetailsByDate")]
        public IActionResult GetshowDetailsByDate(int MovieID, int CityID, string date)
        {
            List<detailsbymovieVM> tune = _movieBusiness.GetshowDetailsByDate(MovieID, CityID, date);
            return Ok(tune);
        }

        [HttpGet]
        [Route("GetdetbytheatreID")]
        public IActionResult GetdetbytheatreID(int TheatreId)
        {
            List<detVM> rod = _movieBusiness.GetdetbytheatreID(TheatreId);
            return Ok(rod);
        }

        [HttpGet]
        [Route("PostSnacks")]

        public IActionResult updatesnacks(int theatreId, string date, string start, int amount)
        {
            bool list = _movieBusiness.updatesnacks(theatreId, date, start, amount);
            return Ok(list);
        }
    }
}
