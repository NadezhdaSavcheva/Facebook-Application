using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class UsersGroups
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }

        public virtual Groups Group { get; set; }
        public virtual Users User { get; set; }
    }
}
