using NexturnMovies.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Repository.Interfaces
{
    public interface IMovieRepository
    {
       List<Movie> GetMovies();

        List<City> GetCities();

        List<Theatre> GetTheatres(string City);

        List<Show> GetStartTimeTheater(int MovieId);

        List<MovieCast> GetMovieCasts(int MovieId);

        List<CityMovie> GetAllMovies(int CityId);

        List<ShowBooking> GetAllBookedSeats(int TheaterId, string StartTime, DateTime Date);

        List<detailsbymovie> GetshowDetails(int MovieID, int CityID);
    }

}
