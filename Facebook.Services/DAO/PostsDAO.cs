using Facebook.Services.Models;
using System;
using System.Linq;

namespace Facebook.Services.DAO
{
    public class PostsDAO : IPostsDAO
    {
        private FacebookDBContext context;

        public PostsDAO(FacebookDBContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
        }

        public void CreatePost(Posts newPost)
        {
            this.context.Posts.Add(newPost);
            this.context.SaveChanges();
        }

        public int DeletePostById(int postId)
        {
            var post = this.context.Posts.Where(p => p.PostId.Equals(postId)).FirstOrDefault();
            this.context.Posts.Remove(post);

            return this.context.SaveChanges();
        }
    }
}
