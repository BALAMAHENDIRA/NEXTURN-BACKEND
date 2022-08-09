using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NexturnMovies.Repository.Model
{
    public partial class movieBookingContext : DbContext
    {
        public movieBookingContext()
        {
        }

        public movieBookingContext(DbContextOptions<movieBookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Cast> Casts { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<SeatDetail> SeatDetails { get; set; }
        public virtual DbSet<Show> Shows { get; set; }
        public virtual DbSet<Theatre> Theatres { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=movieBooking;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("Booking");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BookedDate).HasColumnType("datetime");

                entity.Property(e => e.SeatDetailsId).HasColumnName("SeatDetailsID");

                entity.Property(e => e.ShowId).HasColumnName("ShowID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.SeatDetails)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.SeatDetailsId)
                    .HasConstraintName("FK__Booking__SeatDet__36B12243");

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.ShowId)
                    .HasConstraintName("FK__Booking__ShowID__35BCFE0A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Booking__UserID__34C8D9D1");
            });

            modelBuilder.Entity<Cast>(entity =>
            {
                entity.ToTable("Cast");

                entity.Property(e => e.CastId)
                    .ValueGeneratedNever()
                    .HasColumnName("CastID");

                entity.Property(e => e.Comedian)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Director)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hero)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Heroine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Producer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupportRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Villain)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movie");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.CastId).HasColumnName("CastID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Image1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("image1");

                entity.Property(e => e.Image2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("image2");

                entity.Property(e => e.Language)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Trailer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cast)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.CastId)
                    .HasConstraintName("FK__Movie__CastID__25869641");
            });

            modelBuilder.Entity<SeatDetail>(entity =>
            {
                entity.HasKey(e => e.SeatDetailsId)
                    .HasName("PK__SeatDeta__C18AD9E9AADBA28D");

                entity.Property(e => e.SeatDetailsId).HasColumnName("SeatDetailsID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SeatType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Show>(entity =>
            {
                entity.ToTable("Show");

                entity.Property(e => e.ShowId).HasColumnName("ShowID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TheatreId).HasColumnName("TheatreID");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Shows)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__Show__MovieID__300424B4");

                entity.HasOne(d => d.Theatre)
                    .WithMany(p => p.Shows)
                    .HasForeignKey(d => d.TheatreId)
                    .HasConstraintName("FK__Show__TheatreID__2F10007B");
            });

            modelBuilder.Entity<Theatre>(entity =>
            {
                entity.ToTable("Theatre");

                entity.Property(e => e.TheatreId).HasColumnName("TheatreID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ScreenName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TImage1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("T_image1");

                entity.Property(e => e.TImage2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("T_image2");

                entity.Property(e => e.TheatreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalSeats)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Theatres)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__Theatre__CityID__2A4B4B5E");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
