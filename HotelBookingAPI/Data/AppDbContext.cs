using Microsoft.EntityFrameworkCore;
using HotelBookingApi.Models;

namespace HotelBookingApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<Booking> Bookings => Set<Booking>();
    }
}
