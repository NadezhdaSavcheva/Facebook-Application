using Facebook.Services.Models;

namespace Facebook.Services.DAO
{
    public interface IFriendsDAO
    {
        void AcceptFriendRequest(Friends newFriend);
        int RemoveFriendById(int friendshipId);
    }
}