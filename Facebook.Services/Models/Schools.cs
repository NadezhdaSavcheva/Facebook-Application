using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Schools
    {
        public Schools()
        {
            Profiles = new HashSet<Profiles>();
        }

        public int SchoolId { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        public virtual Cities City { get; set; }
        public virtual ICollection<Profiles> Profiles { get; set; }
    }
}
