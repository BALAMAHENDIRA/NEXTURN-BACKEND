using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Repository.Model
{
  public  class myContext : movieBookingContext
    {
        public myContext()
        {

        }
        public myContext(DbContextOptions<movieBookingContext> options)
             : base(options)
        {

        }
    }
}
