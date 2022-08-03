using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Repository.Models
{
   public class myContext : movieBookingContext
    {

        public myContext(DbContextOptions<movieBookingContext> options)
              : base(options)
        {

        }
    }
}
