using Facebook.Services.Models;
using System;
using System.Linq;

namespace Facebook.Services.DAO
{
    public class GroupsDAO : IGroupsDAO
    {
        private FacebookDBContext context;

        public GroupsDAO(FacebookDBContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
        }

        public void CreateGroup(Groups newGroup)
        {
            this.context.Groups.Add(newGroup);
            this.context.SaveChanges();
        }

        public int DeleteGroupById(int groupId)
        {
            var group = this.context.Groups.Where(g => g.GroupId.Equals(groupId)).FirstOrDefault();
            this.context.Groups.Remove(group);

            return this.context.SaveChanges();
        }
    }
}
