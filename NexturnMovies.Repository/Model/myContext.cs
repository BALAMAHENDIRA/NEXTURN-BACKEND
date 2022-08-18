using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Repository.Model
{
  public  class myContext : movieBooking2Context
    {
        public myContext()
        {

        }
        public myContext(DbContextOptions<movieBooking2Context> options)
             : base(options)
        {

        }
    }
}
