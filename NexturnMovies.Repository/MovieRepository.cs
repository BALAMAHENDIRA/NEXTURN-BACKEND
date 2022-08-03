using NexturnMovies.Repository.Interfaces;
using NexturnMovies.Repository.Models;
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
    }
}