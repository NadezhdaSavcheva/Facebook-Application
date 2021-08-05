using Facebook.Services.DAO;

namespace Facebook.Business.Controllers
{
    class ProfileController
    {
        private ProfileDAO profileDAO = null;

        public ProfileController(ProfileDAO profileDAO)
        {
            this.profileDAO = profileDAO;
        }
    }


}
