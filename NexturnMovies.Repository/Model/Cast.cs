using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Model
{
    public partial class Cast
    {
        public Cast()
        {
            Movies = new HashSet<Movie>();
        }

        public int CastId { get; set; }
        public string Hero { get; set; }
        public string Heroine { get; set; }
        public string Comedian { get; set; }
        public string Villain { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string SupportRole { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
