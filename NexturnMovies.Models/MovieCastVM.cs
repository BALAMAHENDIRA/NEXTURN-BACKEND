using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Models
{
    public class MovieCastVM
    {
        [Key]
        public int MovieId { get; set; }
        public int? CastId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Language { get; set; }
        public string ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Trailer { get; set; }


        public string Hero { get; set; }
        public string Heroine { get; set; }
        public string Comedian { get; set; }
        public string Villain { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string SupportRole { get; set; }

    }
}
