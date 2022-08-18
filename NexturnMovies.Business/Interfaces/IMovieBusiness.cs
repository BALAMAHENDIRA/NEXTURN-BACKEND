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

        List<TheatreVM> GetTheatres(int CityId);

        List<TheatreVM> GetTheatersById(int TheatreId);

        List<ShowTheaterVM> GetStartTimeTheater(int MovieId);

        List<MovieCastVM> GetMovieCasts(int MovieId);

        List<CityMovieVM> GetAllMovies(int CityId);

        List<CityMovieVM> GetAllMoviesByTheatre(int theatreId);

        List<ShowBookingVM> GetAllBookedSeats(int TheaterId, string StartTime, string Date);

        List<detailsbymovieVM> GetshowDetails(int MovieID, int CityID);

        bool updateBooking(int price, int seatNum, int seatDetail, int theatreId, string date, string start);

        List<ShowTheaterVM> GetStartTimeTheatreByDate(string date);

        List<detailsbymovieVM> GetshowDetailsByDate(int MovieID, int CityID, string date);

        List<detVM> GetdetbytheatreID(int TheatreId);

        bool updatesnacks(int theatreId, string date, string start, int amount);


    }
}
