using System;

namespace Albatross.Shared
{
    public class RoomSearch
    {
        public string City { get; set; }
        public string Type { get; set; }
        public string ReservationType { get; set; }
        public int Beds { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
    }
}
