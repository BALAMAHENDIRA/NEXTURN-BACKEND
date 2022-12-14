using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Model
{
    public partial class Show
    {
        public Show()
        {
            Bookings = new HashSet<Booking>();
            Foods = new HashSet<Food>();
        }

        public int ShowId { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? TheatreId { get; set; }
        public int? MovieId { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Theatre Theatre { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
