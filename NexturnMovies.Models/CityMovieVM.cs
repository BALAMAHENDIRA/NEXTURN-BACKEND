using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NexturnMovies.Models
{
    public class CityMovieVM
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public string TheatreName { get; set; }

        public int? TheatreId { get; set; }
        public int MovieId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Language { get; set; }
        public string ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Trailer { get; set; }

    }
}
