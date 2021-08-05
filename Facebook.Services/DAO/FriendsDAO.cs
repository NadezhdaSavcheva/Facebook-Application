using Facebook.Services.Models;
using System;
using System.Linq;

namespace Facebook.Services.DAO
{
    public class FriendsDAO : IFriendsDAO
    {
        private FacebookDBContext context;

        public FriendsDAO(FacebookDBContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
        }

        public void AcceptFriendRequest(Friends newFriend)
        {
            this.context.Friends.Add(newFriend);
            this.context.SaveChanges();
        }

        public int RemoveFriendById(int friendshipId)
        {
            var friendship = this.context.Friends.Where(f => f.FriendshipId.Equals(friendshipId)).FirstOrDefault();
            this.context.Friends.Remove(friendship);

            return this.context.SaveChanges();
        }
    }
}
