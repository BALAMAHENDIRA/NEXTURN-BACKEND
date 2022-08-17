using AutoMapper;
using NexturnMovies.Business.Interfaces;
using NexturnMovies.Models;
using NexturnMovies.Repository.Interfaces;
using NexturnMovies.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Business
{
   public class MovieBusiness : IMovieBusiness
    {
        private readonly IMovieRepository _movieRepository;

        private readonly IMapper _mapper;
        public MovieBusiness(IMovieRepository repository, IMapper mapper)
        {
            _movieRepository = repository;
            _mapper = mapper;
        }

        public List<MovieVM> GetMovies()
        {
            List<Movie> list = _movieRepository.GetMovies();
            return _mapper.Map<List<MovieVM>>(list);

        }

        public List<CityVM> GetCities()
        {
            List<City> list = _movieRepository.GetCities();
            return _mapper.Map<List<CityVM>>(list);
        }

        public List<TheatreVM> GetTheatres(int CityId)
        {
            List<Theatre> list = _movieRepository.GetTheatres(CityId);
            return _mapper.Map<List<TheatreVM>>(list);
        }

         

        public List<TheatreVM> GetTheatersById(int TheatreId)
        {
            List<Theatre> list = _movieRepository.GetTheatresById(TheatreId);
            return _mapper.Map<List<TheatreVM>>(list);
        }

        public List<ShowTheaterVM> GetStartTimeTheater(int MovieId)
        {
            List<Show> list = _movieRepository.GetStartTimeTheater(MovieId);
            return _mapper.Map<List<ShowTheaterVM>>(list);
        }

        public List<MovieCastVM> GetMovieCasts(int MovieId)
        {
            List<MovieCast> list = _movieRepository.GetMovieCasts(MovieId);
            return _mapper.Map<List<MovieCastVM>>(list);
        }

        public List<CityMovieVM> GetAllMovies(int CityId)
        {
            List<CityMovie> list = _movieRepository.GetAllMovies(CityId);
            return _mapper.Map<List<CityMovieVM>>(list);
        }

        public List<CityMovieVM> GetAllMoviesByTheatre(int theatreId)
        {
            List<CityMovie> list = _movieRepository.GetAllMoviesByTheatre(theatreId);
            return _mapper.Map<List<CityMovieVM>>(list);
        }

        public List<ShowBookingVM> GetAllBookedSeats(int TheaterId, string StartTime, string Date)
        {
            List<ShowBooking> list = _movieRepository.GetAllBookedSeats(TheaterId,StartTime,Date);
            return _mapper.Map<List<ShowBookingVM>>(list);
        }

        public List<detailsbymovieVM> GetshowDetails(int MovieID, int CityID)
        {
            List<detailsbymovie> list = _movieRepository.GetshowDetails(MovieID, CityID);
            return _mapper.Map<List<detailsbymovieVM>>(list);

        }


        public bool updateBooking(int price, int seatNum, int seatDetail, int theatreId, string date, string start)
        {
            var list = _movieRepository.updateBooking(price, seatNum, seatDetail, theatreId, date, start);
            return list;
        }

        public List<ShowTheaterVM> GetStartTimeTheatreByDate(string date)
        {
            List<ShowTheater> list = _movieRepository.GetStartTimeTheatreByDate(date);
            return _mapper.Map<List<ShowTheaterVM>>(list);
        }

        public List<detailsbymovieVM> GetshowDetailsByDate(int MovieID, int CityID, string date)
        {
            List<detailsbymovie> list = _movieRepository.GetshowDetailsByDate(MovieID, CityID, date);
            return _mapper.Map<List<detailsbymovieVM>>(list);

        }

        public List<detVM> GetdetbytheatreID(int TheatreId)
        {
            List<det> list = _movieRepository.GetdetbytheatreID(TheatreId);
            return _mapper.Map<List<detVM>>(list);

        }

    }

}
