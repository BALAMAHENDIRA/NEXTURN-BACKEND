using AutoMapper;
using NexturnMovies.Models;
using NexturnMovies.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Utilities
{
     public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
          CreateMap<Movie, MovieVM>().ReverseMap();
            /*  CreateMap<Department, DepartmentVM>().ReverseMap();*/
        }

    }
}
