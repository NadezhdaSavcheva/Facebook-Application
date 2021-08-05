using Facebook.Services.Models;
using System;
using System.Linq;

namespace Facebook.Services.DAO
{
    public class ProfileDAO : IProfileDAO
    {
        private FacebookDBContext context;

        public ProfileDAO(FacebookDBContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
        }

        public void CustomizeProfile(Profiles userProfile)
        {
            this.context.Profiles.Add(userProfile);
            this.context.SaveChanges();
        }

        public int DeleteProfileByID(int profileId)
        {
            var profile = this.context.Profiles.Where(p => p.ProfileId.Equals(profileId)).FirstOrDefault();
            this.context.Profiles.Remove(profile);

            var user = this.context.Users.Where(u => u.UserId.Equals(this.context.Profiles.Where(usr => usr.UserId.Equals(u.UserId)))).FirstOrDefault();
            this.context.Users.Remove(user);

            return this.context.SaveChanges();
        }

        public Profiles GetProfileInfo(int userId)
        {
            var profile = this.context.Profiles.Where(p => p.ProfileId.Equals(userId));

            return (Profiles)profile;
        }
    }
}
