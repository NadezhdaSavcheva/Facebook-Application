using Facebook.Business.CustomExceptions;
using Facebook.Models.ViewModels;
using Facebook.Services.DAO;
using Facebook.Services.Models;

namespace Facebook.Business.Controllers
{
    class HomeController
    {
        private IHomeDAO homeDAO = null;

        public HomeController(IHomeDAO homeDAO)
        {
            this.homeDAO = homeDAO;
        }

        public void Register(RegistrationViewModel registrationViewModel)
        {
            Users user = new Users();
            user.FirstName = registrationViewModel.FirstName;
            user.LastName = registrationViewModel.LastName;
            user.PhoneNumber = registrationViewModel.PhoneNumber;
            user.Email = registrationViewModel.Email;
            user.PasswordHash = registrationViewModel.PasswordHash;
            user.Birthdate = registrationViewModel.Birthdate;
            user.Gender = registrationViewModel.Gender;

            this.homeDAO.RegisterUser(user);
        }

        public int Login(string emailOrPhoneNumber, string password)
        {
            Users user = this.homeDAO.Login(emailOrPhoneNumber, password);

            if (user == null)
            {
                throw new IncorrectCredentialsException("Incorrect credentials");
            }

            return user.UserId;
        }
    }
}
