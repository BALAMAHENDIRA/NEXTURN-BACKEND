using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Models
{
    public partial class Screen
    {
        public Screen()
        {
            CinemaSeats = new HashSet<CinemaSeat>();
            Shows = new HashSet<Show>();
        }

        public int ScreenId { get; set; }
        public string Name { get; set; }
        public int? TotalSeats { get; set; }
        public int? TheatreId { get; set; }

        public virtual Theatre Theatre { get; set; }
        public virtual ICollection<CinemaSeat> CinemaSeats { get; set; }
        public virtual ICollection<Show> Shows { get; set; }
    }
}
