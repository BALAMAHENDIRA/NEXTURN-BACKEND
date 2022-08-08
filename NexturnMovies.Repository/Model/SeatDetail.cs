using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Model
{
    public partial class SeatDetail
    {
        public SeatDetail()
        {
            Bookings = new HashSet<Booking>();
        }

        public int SeatDetailsId { get; set; }
        public string SeatType { get; set; }
        public int? TheatreId { get; set; }

        public virtual Theatre Theatre { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
