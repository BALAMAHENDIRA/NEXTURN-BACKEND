using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Models
{
   public class TheatreVM
    {
        public int TheatreId { get; set; }
        public string TheatreName { get; set; }
        public string ScreenName { get; set; }
        public string TotalSeats { get; set; }
        public int? CityId { get; set; }
        public string TImage1 { get; set; }
        public string TImage2 { get; set; }

       
    }
}
