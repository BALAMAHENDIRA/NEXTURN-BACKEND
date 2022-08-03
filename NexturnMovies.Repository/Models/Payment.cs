using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? BookingId { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
