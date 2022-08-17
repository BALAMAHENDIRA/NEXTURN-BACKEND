using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Model
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public decimal? Amount { get; set; }
        public string BookedDate { get; set; }
        public int? SeatNumber { get; set; }
        public int? UserId { get; set; }
        public int? SeatDetailsId { get; set; }
        public int? ShowId { get; set; }

        public virtual SeatDetail SeatDetails { get; set; }
        public virtual Show Show { get; set; }
        public virtual User User { get; set; }
    }
}
