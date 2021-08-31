using Facebook.Services.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public List<Profiles> GetAllProfiles()
        {
            return this.context.Profiles.ToList();
        }

        public Image ByteToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public void ChangeDescription(int userId, string newDsc)
        {
            var profile = this.context.Profiles.Where(p => p.ProfileId.Equals(userId)).FirstOrDefault();
            string description = profile.Description;
            string newDescription = description.Replace(description, newDsc);
            this.context.SaveChanges();
        }

        public void ChangeSchool(int userId, string newName)
        {
            var profile = this.context.Profiles.Where(p => p.ProfileId.Equals(userId)).FirstOrDefault();
            string schoolName = profile.School.Name;
            string newSchoolName = schoolName.Replace(schoolName, newName);
            this.context.SaveChanges();
        }

        public void ChangeWorkplace(int userId, string newPlace)
        {
            var profile = this.context.Profiles.Where(p => p.ProfileId.Equals(userId)).FirstOrDefault();
            string workplace = profile.Workplace.Name;
            string newWorkplace = workplace.Replace(workplace, newPlace);
            this.context.SaveChanges();
        }

        public void ChangeCityCountry(int userId, string newCC)
        {
            var profile = this.context.Profiles.Where(p => p.ProfileId.Equals(userId)).FirstOrDefault();
            string cityCountry = profile.City.Name + ", " + profile.City.Country.Name;
            string newCityCountry = cityCountry.Replace(cityCountry, newCC);
            this.context.SaveChanges();
        }

        public void ChangeHobbies(int userId, string newH)
        {
            var profile = this.context.Profiles.Where(p => p.ProfileId.Equals(userId)).FirstOrDefault();
            string hobbies = profile.Hobbies;
            string newHobbies = hobbies.Replace(hobbies, newH);
            this.context.SaveChanges();
        }

        public void ChangeStatus(int userId, string newS)
        {
            var profile = this.context.Profiles.Where(p => p.ProfileId.Equals(userId)).FirstOrDefault();
            string status = profile.UserStatus.Type;
            string newStatus = status.Replace(status, newS);
            this.context.SaveChanges();
        }
    }
}
