using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Models
{
    public partial class City
    {
        public City()
        {
            Theatres = new HashSet<Theatre>();
        }

        public int CityId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }

        public virtual ICollection<Theatre> Theatres { get; set; }
    }
}
