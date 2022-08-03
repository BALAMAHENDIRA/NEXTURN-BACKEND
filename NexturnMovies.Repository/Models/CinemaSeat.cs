using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Models
{
    public partial class CinemaSeat
    {
        public CinemaSeat()
        {
            ShowSeats = new HashSet<ShowSeat>();
        }

        public int CinemaSeatId { get; set; }
        public int? SeatNumber { get; set; }
        public int? Type { get; set; }
        public int? ScreenId { get; set; }

        public virtual Screen Screen { get; set; }
        public virtual ICollection<ShowSeat> ShowSeats { get; set; }
    }
}
