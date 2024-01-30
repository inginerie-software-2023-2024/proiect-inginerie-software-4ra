using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Traveling_Platform.Models;

namespace Traveling_Platform.Data
{
    public interface IApplicationDbContext
    {
        DbSet<ApplicationUser> Users { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Hotel> Hotels { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Review> Reviews { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<Picture> Pictures { get; set; }

        int SaveChanges();
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Booking> Bookings { get; set;}

        public DbSet<Message> Messages { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HotelRoom>().HasKey(hr => new {hr.Id, hr.IdRoom, hr.IdHotel});

            modelBuilder.Entity<HotelRoom>()
                .HasOne(hr => hr.Hotel)
                .WithMany(hr => hr.HotelRooms)
                .HasForeignKey(hr => hr.IdHotel);

            modelBuilder.Entity<HotelRoom>()
                .HasOne(hr => hr.Room)
                .WithMany(hr => hr.HotelRooms)
                .HasForeignKey(hr => hr.IdRoom);
            
        }*/
    }
}