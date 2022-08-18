using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Models
{
   public class FoodVM
    {
        public int SnackId { get; set; }
        public int? UserId { get; set; }
        public int? ShowId { get; set; }
        public decimal? Amount { get; set; }
    }
}
