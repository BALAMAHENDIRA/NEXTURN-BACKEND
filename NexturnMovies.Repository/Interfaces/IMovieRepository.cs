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

        List<Theatre> GetTheatres(int CityId);

        List<Theatre> GetTheatresById(int TheatreId);

        List<Show> GetStartTimeTheater(int MovieId);

        List<MovieCast> GetMovieCasts(int MovieId);

        List<CityMovie> GetAllMovies(int CityId);
        List<CityMovie> GetAllMoviesByTheatre(int theatreId);

        List<ShowBooking> GetAllBookedSeats(int TheaterId, string StartTime, string Date);

        List<detailsbymovie> GetshowDetails(int MovieID, int CityID);

        bool updateBooking(int price, int seatNum, int seatDetail, int theatreId, string date, string start);

        List<ShowTheater> GetStartTimeTheatreByDate(string date);

        List<detailsbymovie> GetshowDetailsByDate(int MovieID, int CityID, string date);

        List<det> GetdetbytheatreID(int TheatreId);
    }

}
