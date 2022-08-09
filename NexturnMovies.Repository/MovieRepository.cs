using NexturnMovies.Repository.Interfaces;
using NexturnMovies.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly myContext _context;


        public MovieRepository(myContext context)
        {
            _context = context;
        }

        //READ
        public List<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        public List<City> GetCities()
        {
            return _context.Cities.ToList();

        }

        public List<Theatre> GetTheatres(string City)
        {
            var B = (from t in _context.Theatres
                     join c in _context.Cities on t.CityId equals c.CityId
                     select new CityTheater
                     {
                         TheatreName = t.TheatreName,
                     }).ToList();
            B = B.Where(x => x.Name == City).ToList();
            return _context.Theatres.ToList();

        }

        public List<Show> GetStartTimeTheater(int MovieId)
         {
             var A = (from s in _context.Shows
                      join t in _context.Theatres on s.TheatreId equals t.TheatreId
                      select new ShowTheater
                      {
                          StartTime = s.StartTime,
                          TheatreName = t.TheatreName,

                      }).ToList();
             A = A.Where(x => x.MovieId == MovieId).ToList();
             return _context.Shows.ToList();
         }
        public List<detailsbymovie> GetshowDetails(int MovieID, int CityID)
        {
            var e = (from t in _context.Theatres
                     join s in _context.Shows on t.TheatreId equals s.TheatreId
                     join c in _context.Cities on t.CityId equals c.CityId
                     where s.MovieId == MovieID && c.CityId == CityID
                     select new detailsbymovie

                     {
                         TheatreName = t.TheatreName,
                         StartTime = s.StartTime


                     }).ToList();

            return e;
        }

        public List<MovieCast> GetMovieCasts(int MovieId)
        {
            var A = (from m in _context.Movies
                     join c in _context.Casts on m.CastId equals c.CastId
                     where m.MovieId == MovieId
                     select new MovieCast
                     {
                         Title = m.Title,
                         Description = m.Description,
                         Duration = m.Duration,
                         Language = m.Language,
                         ReleaseDate = m.ReleaseDate,
                         Genre = m.Genre,
                         Image1 = m.Image1,
                         Image2 = m.Image2,
                         Trailer = m.Trailer,
                         Hero = c.Hero,
                         Heroine = c.Heroine,
                         Comedian = c.Comedian,
                         Villain = c.Villain,
                         Director = c.Director,
                         Producer = c.Producer,
                         SupportRole = c.SupportRole
                     }).ToList();
            return (A);
        }

        public List<CityMovie> GetAllMovies(int CityId)
        {
            var A = (from t in _context.Theatres
                     join s in _context.Shows on t.TheatreId equals s.TheatreId
                     join c in _context.Cities on t.CityId equals c.CityId
                     join m in _context.Movies on s.MovieId equals m.MovieId
                     where c.CityId == CityId
                     select new CityMovie
                     {
                         Title = m.Title,
                         Description = m.Description,
                         Duration = m.Duration,
                         Language = m.Language,
                         ReleaseDate = m.ReleaseDate,
                         Genre = m.Genre,
                         Image1 = m.Image1,
                         Image2 = m.Image2,
                         Trailer = m.Trailer,

                     }).ToList();
            return (A);
        }

        public List<ShowBooking> GetAllBookedSeats(int TheaterId,string StartTime,DateTime Date )
        {
            var A = (from s in _context.Shows
                     join b in _context.Bookings on s.ShowId equals b.ShowId
                     where s.TheatreId == TheaterId && s.StartTime == StartTime && s.Date == Date
                     select new ShowBooking
                     {
                         ShowId = s.ShowId,
                         TheatreId = s.TheatreId,
                         StartTime = s.StartTime,
                         Date = s.Date,
                         SeatNumber = b.SeatNumber,
                     }).ToList();
            return (A);

        }

         

    }
}
