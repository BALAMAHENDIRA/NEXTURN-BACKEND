﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Models
{
    public partial class ShowSeat
    {
        public int ShowSeatId { get; set; }
        public int? Status { get; set; }
        public decimal? Price { get; set; }
        public int? CinemaSeatId { get; set; }
        public int? ShowId { get; set; }
        public int? BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual CinemaSeat CinemaSeat { get; set; }
        public virtual Show Show { get; set; }
    }
}
