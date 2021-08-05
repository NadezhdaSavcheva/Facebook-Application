using Facebook.Services.DAO;

namespace Facebook.Business.Controllers
{
    class FriendsController
    {
        private FriendsDAO friendsDAO = null;

        public FriendsController(FriendsDAO friendsDAO)
        {
            this.friendsDAO = friendsDAO;
        }
    }
}
