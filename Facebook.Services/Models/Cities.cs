using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Cities
    {
        public Cities()
        {
            Locations = new HashSet<Locations>();
            Profiles = new HashSet<Profiles>();
            Schools = new HashSet<Schools>();
            Workplaces = new HashSet<Workplaces>();
        }

        public int CityId { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public int CountryId { get; set; }

        public virtual Countries Country { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
        public virtual ICollection<Profiles> Profiles { get; set; }
        public virtual ICollection<Schools> Schools { get; set; }
        public virtual ICollection<Workplaces> Workplaces { get; set; }
    }
}
