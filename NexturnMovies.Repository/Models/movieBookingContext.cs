using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NexturnMovies.Repository.Models
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
        public virtual DbSet<CinemaSeat> CinemaSeats { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Screen> Screens { get; set; }
        public virtual DbSet<Show> Shows { get; set; }
        public virtual DbSet<ShowSeat> ShowSeats { get; set; }
        public virtual DbSet<Theatre> Theatres { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=movieBooking; Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("Booking");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.ShowId).HasColumnName("ShowID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.ShowId)
                    .HasConstraintName("FK__Booking__ShowID__36B12243");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Booking__UserID__35BCFE0A");
            });

            modelBuilder.Entity<CinemaSeat>(entity =>
            {
                entity.Property(e => e.CinemaSeatId).HasColumnName("CinemaSeatID");

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.CinemaSeats)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK__CinemaSea__Scree__30F848ED");
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
                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
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
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__Payment__Booking__3E52440B");
            });

            modelBuilder.Entity<Screen>(entity =>
            {
                entity.ToTable("Screen");

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TheatreId).HasColumnName("TheatreID");

                entity.HasOne(d => d.Theatre)
                    .WithMany(p => p.Screens)
                    .HasForeignKey(d => d.TheatreId)
                    .HasConstraintName("FK__Screen__TheatreI__2A4B4B5E");
            });

            modelBuilder.Entity<Show>(entity =>
            {
                entity.ToTable("Show");

                entity.Property(e => e.ShowId).HasColumnName("ShowID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Shows)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__Show__MovieID__2E1BDC42");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Shows)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK__Show__ScreenID__2D27B809");
            });

            modelBuilder.Entity<ShowSeat>(entity =>
            {
                entity.ToTable("ShowSeat");

                entity.Property(e => e.ShowSeatId).HasColumnName("ShowSeatID");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.CinemaSeatId).HasColumnName("CinemaSeatID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ShowId).HasColumnName("ShowID");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.ShowSeats)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__ShowSeat__Bookin__3B75D760");

                entity.HasOne(d => d.CinemaSeat)
                    .WithMany(p => p.ShowSeats)
                    .HasForeignKey(d => d.CinemaSeatId)
                    .HasConstraintName("FK__ShowSeat__Cinema__398D8EEE");

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.ShowSeats)
                    .HasForeignKey(d => d.ShowId)
                    .HasConstraintName("FK__ShowSeat__ShowID__3A81B327");
            });

            modelBuilder.Entity<Theatre>(entity =>
            {
                entity.ToTable("Theatre");

                entity.Property(e => e.TheatreId).HasColumnName("TheatreID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Image1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("image1");

                entity.Property(e => e.Image2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("image2");

                entity.Property(e => e.Image3)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("image3");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Theatres)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__Theatre__CityID__276EDEB3");
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
