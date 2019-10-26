using System;
using System.Collections.Generic;
using System.Text;

namespace Albatross.Shared
{
    public class ReservationType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Type { get; set; }
    }
}
