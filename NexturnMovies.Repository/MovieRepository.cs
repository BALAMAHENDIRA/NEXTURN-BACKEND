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

        public List<Theatre> GetTheatres(int CityID)
        {
            List<Theatre> a =  _context.Theatres.Where(x => x.CityId == CityID).ToList();

            List<Theatre> B = a.GroupBy(x => x.TheatreName).Select(y => y.First()).ToList();
            return B;

            //return _context.Theatres.Where(x => x.CityId == CityID).ToList();

        }

        public List<Theatre> GetTheatresById(int TheatreId)
        {


            return _context.Theatres.Where(x => x.TheatreId == TheatreId).ToList();

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
                         TheatreId = t.TheatreId,
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
                         MovieId = m.MovieId,
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
                         MovieId = m.MovieId,
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

            List<CityMovie> B = A.GroupBy(x => x.MovieId).Select(y => y.First()).ToList();
            return (B);
        }

        public List<CityMovie> GetAllMoviesByTheatre(int theatreId)
        {
            var A = (from t in _context.Theatres
                     join s in _context.Shows on t.TheatreId equals s.TheatreId
                     
                     join m in _context.Movies on s.MovieId equals m.MovieId
                     where t.TheatreId == theatreId
                     select new CityMovie
                     {
                         TheatreName = t.TheatreName,
                         MovieId = m.MovieId,
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

            List<CityMovie> B = A.GroupBy(x => x.MovieId).Select(y => y.First()).ToList();
            return (B);
        }



        public List<ShowBooking> GetAllBookedSeats(int TheaterId,string StartTime,string Date )
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

        public bool updateBooking (int price, int seatNum, int seatDetail, int theatreId, string date, string start)
        {
            List<Show> A = _context.Shows.Where(x => x.TheatreId == theatreId && x.StartTime == start && x.Date == date).ToList();
            var showid = 0;
          var currentDate =   DateTime.Now.ToString("yyyy/M/d");
            foreach (var item in A)
            {
                  showid = item.ShowId;
            };

            Booking obj = new Booking();
            obj.ShowId = showid;
            obj.Amount = price;
            obj.BookedDate = currentDate;
            obj.SeatNumber = seatNum;
            obj.UserId = 1;
            obj.SeatDetailsId = seatDetail;

            _context.Bookings.Add(obj);
            _context.SaveChanges();

            return true;


        }


        public List<ShowTheater> GetStartTimeTheatreByDate(string date)
        {
            var A = (from s in _context.Shows
                     join t in _context.Theatres on s.TheatreId equals t.TheatreId
                     select new ShowTheater
                     {
                         Date = s.Date,
                         StartTime = s.StartTime,
                         TheatreName = t.TheatreName,

                     }).ToList();
            List<ShowTheater> B = A.Where(x => x.Date == date).ToList();
            return B;
        }

        public List<detailsbymovie> GetshowDetailsByDate(int MovieID, int CityID, string date)
        {
            var e = (from t in _context.Theatres
                     join s in _context.Shows on t.TheatreId equals s.TheatreId
                     join c in _context.Cities on t.CityId equals c.CityId
                     where s.MovieId == MovieID && c.CityId == CityID && s.Date == date
                     select new detailsbymovie

                     {
                         TheatreId = t.TheatreId,
                         TheatreName = t.TheatreName,
                         StartTime = s.StartTime


                     }).ToList();

            return e;
        }



        public List<det> GetdetbytheatreID(int TheatreId)
        {
            List<det> g = (from t in _context.Theatres
                     join c in _context.Cities on t.CityId equals c.CityId
                     where t.TheatreId == TheatreId
                     select new det

                     {
                         TheatreId = t.TheatreId,
                         TheatreName = t.TheatreName,
                         ScreenName = t.ScreenName,
                         TotalSeats = t.TotalSeats,
                         CityId = t.CityId,
                         TImage1 = t.TImage1,
                         TImage2 = t.TImage2,
                         Name = c.Name,
                         State = c.State,
                         PinCode = c.PinCode


                     }).ToList();

            return g;
        }


        public bool updatesnacks(int theatreId, string date, string start, int amount)
        {


            Show A = _context.Shows.Where(x => x.TheatreId == theatreId && x.StartTime == start && x.Date == date).FirstOrDefault();


            Food food = new Food();
            food.Amount = amount;
            food.ShowId = A.ShowId;
            food.UserId = 1;
            _context.Foods.Add(food);
            _context.SaveChanges();


            return true;


        }

    }


}
