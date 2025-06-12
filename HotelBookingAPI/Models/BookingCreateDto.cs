namespace HotelBookingApi.Models
{
    public class BookingCreateDto
    {
        public string GuestName { get; set; } = string.Empty;
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
