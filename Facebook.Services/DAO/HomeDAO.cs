using Facebook.Services.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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
                user = this.context.Users.Where(u => u.Email.Equals(emailOrPhoneNumber) && u.PasswordHash.Equals(HashPassword(password)))
                                         .FirstOrDefault();
            }
            else
            {
                user = this.context.Users.Where(u => u.PhoneNumber.Equals(emailOrPhoneNumber) && u.PasswordHash.Equals(HashPassword(password)))
                                         .FirstOrDefault();
            }

            return (Users)user;
        }

        public string HashPassword(string password)
        {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));
        }

        public void RegisterUser(Users newUser)
        {
            this.context.Users.Add(newUser);
            this.context.SaveChanges();
        }
    }
}
