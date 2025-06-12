using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelBookingApi.Data;
using HotelBookingApi.Models;

namespace HotelBookingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookingsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetBookings()
        {
            var bookings = _context.Bookings.Include(b => b.Room).ToList();
            return Ok(bookings);
        }

        [HttpPost]
        public IActionResult CreateBooking([FromBody] BookingCreateDto dto)
        {
            var room = _context.Rooms.Find(dto.RoomId);
            if (room == null || !room.IsAvailable)
            {
                return BadRequest("Room is not available.");
            }

            var booking = new Booking
            {
                GuestName = dto.GuestName,
                RoomId = dto.RoomId,
                CheckInDate = dto.CheckInDate,
                CheckOutDate = dto.CheckOutDate,
                Room = room
            };

            room.IsAvailable = false;
            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return Ok(booking);
        }
    }
}
