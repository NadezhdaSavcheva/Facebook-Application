using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Workplaces
    {
        public Workplaces()
        {
            Profiles = new HashSet<Profiles>();
        }

        public int WorkplaceId { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        public virtual Cities City { get; set; }
        public virtual ICollection<Profiles> Profiles { get; set; }
    }
}
