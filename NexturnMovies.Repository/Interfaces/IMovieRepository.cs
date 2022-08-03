using NexturnMovies.Repository.Models;
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
