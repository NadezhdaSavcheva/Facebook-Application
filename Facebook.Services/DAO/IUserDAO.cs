using Facebook.Services.Models;
using System.Collections.Generic;

namespace Facebook.Services.DAO
{
    public interface IUserDAO
    {
        int DeleteUserByID(int id);
        List<Users> GetAllUsers();
        Users GetUserByID(int id);
        string GetUserFirstName(int id);
    }
}