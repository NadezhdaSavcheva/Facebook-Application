using Facebook.Services.Models;
using System;
using System.Linq;

namespace Facebook.Services.DAO
{
    public class HomeDAO : IHomeDAO
    {
        private FacebookDBContext context;

        public HomeDAO(FacebookDBContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
        }

        public Users Login(string emailOrPhoneNumber, string password)
        {
            object user = null;

            if (emailOrPhoneNumber.Contains('@'))
            {
                user = this.context.Users.Where(u => u.Email.Equals(emailOrPhoneNumber) && u.PasswordHash.Equals(password)).FirstOrDefault();
            }
            else
            {
                user = this.context.Users.Where(u => u.PhoneNumber.Equals(emailOrPhoneNumber) && u.PasswordHash.Equals(password)).FirstOrDefault();
            }

            return (Users)user;
        }

        public void RegisterUser(Users newUser)
        {
            context.Users.Add(newUser);
            context.SaveChanges();
        }
    }
}
