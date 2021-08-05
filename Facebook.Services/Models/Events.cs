using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Events
    {
        public Events()
        {
            UsersEvents = new HashSet<UsersEvents>();
        }

        public int EventId { get; set; }
        public int CreatorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Type { get; set; }
        public int LocationId { get; set; }
        public byte[] Photo { get; set; }

        public virtual Users Creator { get; set; }
        public virtual Locations Location { get; set; }
        public virtual ICollection<UsersEvents> UsersEvents { get; set; }
    }
}
