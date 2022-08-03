using AutoMapper;
using NexturnMovies.Business.Interfaces;
using NexturnMovies.Models;
using NexturnMovies.Repository.Interfaces;
using NexturnMovies.Repository.Models;
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

    }
}
