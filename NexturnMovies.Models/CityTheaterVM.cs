using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Models
{
    public class CityTheaterVM
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public string TheatreName { get; set; }
    }
}
