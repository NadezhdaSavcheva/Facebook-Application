using Facebook.Services.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public int CreatePost(Posts newPost)
        {
            this.context.Posts.Add(newPost);
            return this.context.SaveChanges();
        }

        public List<Posts> GetAllPosts()
        {
            return this.context.Posts.ToList();
        }

        public Posts GetPostById(int postId)
        {
            return this.context.Posts.Where(p => p.PostId.Equals(postId)).FirstOrDefault();
        }

        public List<Posts> SearchByContent(string content)
        {
            List<Posts> postsList = new List<Posts>();

            postsList.AddRange(this.context.Posts.Where(p => p.Content.Contains(content)));

            return postsList;
        }

        public int DeletePostById(int postId)
        {
            var post = this.context.Posts.Where(p => p.PostId.Equals(postId)).FirstOrDefault();
            this.context.Posts.Remove(post);

            return this.context.SaveChanges();
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        /*public byte[] ImageToByte(PictureBox img)
        {
            ImageConverter converter = new ImageConverter();
            Bitmap bmp = default;
            try
            {
                bmp = (Bitmap)img.Image;

            }
            catch
            {
                MessageBox.Show("Can't load image!");
            }
            return (byte[])converter.ConvertTo(bmp, typeof(byte[]));
        }*/

        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();

            return bm;
        }

        void IPostsDAO.CreatePost(Posts newPost)
        {
            throw new NotImplementedException();
        }

        int IPostsDAO.DeletePostById(int postId)
        {
            throw new NotImplementedException();
        }

        public List<Posts> SearchByName(string name)
        {
            List<Posts> posts = new List<Posts>();

            posts.AddRange(this.context.Posts.Where(p => (p.Author.FirstName + " " + p.Author.LastName).Contains(name)));
            return posts;
        }
    }
}
