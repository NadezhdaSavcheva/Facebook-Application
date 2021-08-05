using System;
using System.Collections.Generic;

namespace Facebook.Services.Models
{
    public partial class Profiles
    {
        public int ProfileId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public int? SchoolId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? CityId { get; set; }
        public string Hobbies { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public byte[] CoverPhoto { get; set; }
        public int? PostsId { get; set; }
        public int? UserStatusId { get; set; }

        public virtual Cities City { get; set; }
        public virtual Posts Posts { get; set; }
        public virtual Schools School { get; set; }
        public virtual Users User { get; set; }
        public virtual Status UserStatus { get; set; }
        public virtual Workplaces Workplace { get; set; }
    }
}
