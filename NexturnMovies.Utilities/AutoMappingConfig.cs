using AutoMapper;
using NexturnMovies.Models;
using NexturnMovies.Repository.Model;
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
           // CreateMap<Department, DepartmentVM>().ReverseMap();

            CreateMap<City, CityVM>().ReverseMap();

            CreateMap<Theatre, CityTheaterVM>().ReverseMap();

            CreateMap<Show, ShowTheaterVM>().ReverseMap();

            CreateMap<MovieCast, MovieCastVM>().ReverseMap();

            CreateMap<CityMovie, CityMovieVM>().ReverseMap();

            CreateMap<ShowBooking, ShowBookingVM>().ReverseMap();

            CreateMap<detailsbymovie, detailsbymovieVM>().ReverseMap();

        }


    }
}
