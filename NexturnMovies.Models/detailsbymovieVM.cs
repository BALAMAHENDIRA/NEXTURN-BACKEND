using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Models
{
    public class detailsbymovieVM
    {
        [Key]
        public int TheatreId { get; set; }
        public string TheatreName { get; set; }





        public string StartTime { get; set; }
    }
}
