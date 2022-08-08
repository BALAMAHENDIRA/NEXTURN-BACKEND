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
    }
}
