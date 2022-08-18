using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Model
{
    public partial class Food
    {
        public int SnackId { get; set; }
        public int? UserId { get; set; }
        public int? ShowId { get; set; }
        public decimal? Amount { get; set; }

        public virtual Show Show { get; set; }
        public virtual User User { get; set; }
    }
}
