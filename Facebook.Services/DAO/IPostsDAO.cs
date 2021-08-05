using Facebook.Services.Models;

namespace Facebook.Services.DAO
{
    public interface IPostsDAO
    {
        void CreatePost(Posts newPost);
        int DeletePostById(int postId);
    }
}