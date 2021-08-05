using Facebook.Services.Models;

namespace Facebook.Services.DAO
{
    public interface IGroupsDAO
    {
        void CreateGroup(Groups newGroup);
        int DeleteGroupById(int groupId);
    }
}