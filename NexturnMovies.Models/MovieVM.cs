using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Models
{
   public class MovieVM
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Language { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
    }
}
