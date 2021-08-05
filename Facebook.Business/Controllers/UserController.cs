using Facebook.Services.DAO;

namespace Facebook.Business.Controllers
{
    class UserController
    {
        private UserDAO userDAO = null;

        public UserController(UserDAO userDAO)
        {
            this.userDAO = userDAO;
        }


    }
}
