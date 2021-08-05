using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Status
    {
        public Status()
        {
            Profiles = new HashSet<Profiles>();
        }

        public int StatusId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Profiles> Profiles { get; set; }
    }
}
