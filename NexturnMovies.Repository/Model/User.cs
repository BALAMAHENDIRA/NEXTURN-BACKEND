using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Model
{
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
            Foods = new HashSet<Food>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
