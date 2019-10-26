using System.ComponentModel.DataAnnotations;

namespace Albatross.Shared
{
    public class DormitoryRegistrationViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string University { get; set; }
    }
}
