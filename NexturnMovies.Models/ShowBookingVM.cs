using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Models
{
    public class ShowBookingVM
    {
        [Key]
        public int ShowId { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }

        public int? TheatreId { get; set; }

        public int? SeatNumber { get; set; }
    }
}
