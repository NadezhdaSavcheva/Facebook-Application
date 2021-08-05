using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Cities = new HashSet<Cities>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cities> Cities { get; set; }
    }
}
