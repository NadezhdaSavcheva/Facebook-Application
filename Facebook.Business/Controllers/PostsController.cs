using Facebook.Services.DAO;

namespace Facebook.Business.Controllers
{
    class PostsController
    {
        private PostsDAO postsDAO = null;

        public PostsController(PostsDAO postsDAO)
        {
            this.postsDAO = postsDAO;
        }
    }
}
