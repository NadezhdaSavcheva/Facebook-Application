using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Posts
    {
        public Posts()
        {
            PostLikes = new HashSet<PostLikes>();
            Profiles = new HashSet<Profiles>();
        }

        public int PostId { get; set; }
        public int? ParentPostId { get; set; }
        public int AuthorId { get; set; }
        public string Content { get; set; }
        public byte[] Photo { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public virtual Users Author { get; set; }
        public virtual ICollection<PostLikes> PostLikes { get; set; }
        public virtual ICollection<Profiles> Profiles { get; set; }
    }
}
