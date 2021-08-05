using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Groups
    {
        public Groups()
        {
            UsersGroups = new HashSet<UsersGroups>();
        }

        public int GroupId { get; set; }
        public int CreatorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public string Type { get; set; }

        public virtual Users Creator { get; set; }
        public virtual ICollection<UsersGroups> UsersGroups { get; set; }
    }
}
