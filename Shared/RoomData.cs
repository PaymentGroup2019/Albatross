using System;

namespace Albatross.Shared
{
    public class RoomData
    {
        public Guid Id { get; set; }
        public string DormitoryName { get; set; }
        public int Beds { get; set; }
        public int Price { get; set; }
        public string City { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
