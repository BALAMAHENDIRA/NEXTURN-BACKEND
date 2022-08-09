using NexturnMovies.Models;
using NexturnMovies.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Business.Interfaces
{
    public interface IMovieBusiness
    {
        List<MovieVM> GetMovies();

        List<CityVM> GetCities();

        List<CityTheaterVM> GetTheatres(string City);

        List<ShowTheaterVM> GetStartTimeTheater(int MovieId);

        List<MovieCastVM> GetMovieCasts(int MovieId);

        List<CityMovieVM> GetAllMovies(int CityId);

        List<ShowBookingVM> GetAllBookedSeats(int TheaterId, string StartTime, DateTime Date);

        List<detailsbymovieVM> GetshowDetails(int MovieID, int CityID);
 

        }
}
