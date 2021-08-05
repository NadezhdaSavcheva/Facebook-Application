using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class UsersEvents
    {
        public int UserId { get; set; }
        public int EventId { get; set; }

        public virtual Events Event { get; set; }
        public virtual Users User { get; set; }
    }
}
