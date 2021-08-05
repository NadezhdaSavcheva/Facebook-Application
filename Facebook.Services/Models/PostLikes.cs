using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class PostLikes
    {
        public int PostLikeId { get; set; }
        public string LikeType { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }

        public virtual Posts Post { get; set; }
        public virtual Users User { get; set; }
    }
}
