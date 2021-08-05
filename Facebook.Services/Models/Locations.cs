using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Locations
    {
        public Locations()
        {
            Events = new HashSet<Events>();
        }

        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }

        public virtual Cities City { get; set; }
        public virtual ICollection<Events> Events { get; set; }
    }
}
