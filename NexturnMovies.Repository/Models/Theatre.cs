using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Models
{
    public partial class Theatre
    {
        public Theatre()
        {
            Screens = new HashSet<Screen>();
        }

        public int TheatreId { get; set; }
        public string Name { get; set; }
        public int? TotalTheatres { get; set; }
        public int? CityId { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Screen> Screens { get; set; }
    }
}
