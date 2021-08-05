using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Users
    {
        public Users()
        {
            Events = new HashSet<Events>();
            FriendsFriendOne = new HashSet<Friends>();
            FriendsFriendTwo = new HashSet<Friends>();
            Groups = new HashSet<Groups>();
            PostLikes = new HashSet<PostLikes>();
            Posts = new HashSet<Posts>();
            UsersEvents = new HashSet<UsersEvents>();
            UsersGroups = new HashSet<UsersGroups>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }

        public virtual Profiles Profiles { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<Friends> FriendsFriendOne { get; set; }
        public virtual ICollection<Friends> FriendsFriendTwo { get; set; }
        public virtual ICollection<Groups> Groups { get; set; }
        public virtual ICollection<PostLikes> PostLikes { get; set; }
        public virtual ICollection<Posts> Posts { get; set; }
        public virtual ICollection<UsersEvents> UsersEvents { get; set; }
        public virtual ICollection<UsersGroups> UsersGroups { get; set; }
    }
}
