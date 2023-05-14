using Microsoft.EntityFrameworkCore;

namespace Hotelmanagement.Models
{
    public class HotelManagementDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> options) : base(options)
        {
        }
    }
}
