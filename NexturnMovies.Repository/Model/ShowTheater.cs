using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Repository.Model
{
    public class ShowTheater
    {
        public string Date { get; set; }
     
        public string StartTime { get; set; }
        public int? TheatreId { get; set; }
        public int? MovieId { get; set; }
     
        public string TheatreName { get; set; }
    }
}
