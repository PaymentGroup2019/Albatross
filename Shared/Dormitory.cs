using System;
using System.ComponentModel.DataAnnotations;

namespace Albatross.Shared
{
    public class Dormitory
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; }
        public string University { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
    }
}
