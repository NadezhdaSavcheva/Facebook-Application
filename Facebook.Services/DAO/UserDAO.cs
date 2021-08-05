using Facebook.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facebook.Services.DAO
{
    public class UserDAO : IUserDAO
    {
        private FacebookDBContext context;

        public UserDAO(FacebookDBContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
        }

        public Users GetUserByID(int id)
        {
            return this.context.Users.Where(u => u.UserId.Equals(id)).FirstOrDefault();
        }

        public string GetUserFirstName(int id)
        {
            return this.context.Users.Where(u => u.UserId.Equals(id)).Select(v => v.FirstName).FirstOrDefault();
        }

        public int DeleteUserByID(int id)
        {
            var user = this.context.Users.Where(u => u.UserId.Equals(id));
            this.context.Remove(user);

            return this.context.SaveChanges();
        }

        public List<Users> GetAllUsers()
        {
            return this.context.Users.ToList();
        }
    }
}
