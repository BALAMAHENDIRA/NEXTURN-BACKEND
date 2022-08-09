using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Models
{
    public class CityVM
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
    }
}
