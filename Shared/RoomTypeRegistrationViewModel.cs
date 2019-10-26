using System;
using System.ComponentModel.DataAnnotations;

namespace Albatross.Shared
{
    public class RoomTypeRegistrationViewModel
    {
        [Required]
        public Guid DormitoryId { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Beds { get; set; }
    }
}
