using Facebook.Services.Models;

namespace Facebook.Services.DAO
{
    public interface IHomeDAO
    {
        Users Login(string emailOrPhoneNumber, string password);
        void RegisterUser(Users newUser);
    }
}