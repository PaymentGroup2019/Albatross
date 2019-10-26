using System;

namespace Albatross.Shared
{
    public class RoomType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Type { get; set; }
        public int Capacity { get; set; }
        public string Dormitory { get; set; }
        public Guid DormitoryId { get; set; }
        public int Beds { get; set; }
        public int Price { get; set; } = 889898;
    }
}
