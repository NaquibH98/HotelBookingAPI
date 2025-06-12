using Microsoft.AspNetCore.Mvc;
using HotelBookingApi.Data;

namespace HotelBookingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RoomsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetRooms()
        {
            var rooms = _context.Rooms.ToList();
            return Ok(rooms);
        }
    }
}
