using System;
using System.Collections.Generic;

#nullable disable

namespace NexturnMovies.Repository.Model
{
    public partial class Movie
    {
        public Movie()
        {
            Shows = new HashSet<Show>();
        }

        public int MovieId { get; set; }
        public int? CastId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Language { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Trailer { get; set; }

        public virtual Cast Cast { get; set; }
        public virtual ICollection<Show> Shows { get; set; }
    }
}
