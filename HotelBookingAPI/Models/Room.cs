namespace HotelBookingApi.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "101"
        public string Type { get; set; } = string.Empty; // "Single", "Double", etc.
        public bool IsAvailable { get; set; } = true;
    }
}
