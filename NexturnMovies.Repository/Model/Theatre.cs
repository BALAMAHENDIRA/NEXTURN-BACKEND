using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Model
{
    public partial class Theatre
    {
        public Theatre()
        {
            Shows = new HashSet<Show>();
        }

        public int TheatreId { get; set; }
        public string TheatreName { get; set; }
        public string ScreenName { get; set; }
        public string TotalSeats { get; set; }
        public int? CityId { get; set; }
        public string TImage1 { get; set; }
        public string TImage2 { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Show> Shows { get; set; }
    }
}
