using System;
using System.Collections.Generic;
using System.Text;

namespace Albatross.Shared
{
    public class RoomReservationDto
    {
        public RoomData RoomData { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Code { get; set; }
        public int People { get; set; }
    }
}
