using Facebook.Services.DAO;

namespace Facebook.Business.Controllers
{
    class GroupsController
    {
        private GroupsDAO groupsDAO = null;

        public GroupsController(GroupsDAO groupsDAO)
        {
            this.groupsDAO = groupsDAO;
        }
    }
}
