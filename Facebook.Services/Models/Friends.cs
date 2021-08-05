using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Friends
    {
        public int FriendshipId { get; set; }
        public int FriendOneId { get; set; }
        public int FriendTwoId { get; set; }
        public string RelationshipType { get; set; }
        public int InvitedBy { get; set; }

        public virtual Users FriendOne { get; set; }
        public virtual Users FriendTwo { get; set; }
    }
}
