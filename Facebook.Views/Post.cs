using Facebook.Services;
using Facebook.Services.DAO;
using Facebook.Services.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Post : Form
    {
        Users currentUser;
        Posts post;
        Profiles profile;
        private PostsDAO postsDAO;
        private ProfileDAO profileDAO;

        public Post(Users currentUser, int page, Posts post, Profiles profile)
        {
            InitializeComponent();
            FacebookDBContext context = new FacebookDBContext();
            this.currentUser = currentUser;
            this.postsDAO = new PostsDAO(context);
            this.profileDAO = new ProfileDAO(context);
            this.post = post;
            this.profile = profile;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Post.ActiveForm.Close();

            HomePage homePage = new HomePage();
            homePage.Activate();
            homePage.Show();
        }

        private void Post_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);

            postPictureBox.Image = this.postsDAO.ByteToImage(post.Photo);
            descriptionLabel.Size = new Size(634, 100);
            descriptionLabel.AutoSize = false;
            descriptionLabel.Text = post.Content;
            authorNameLabel.Text = currentUser.FirstName + " " + currentUser.LastName;
            authorPictureBox.Image = this.profileDAO.ByteToImage(profile.ProfilePhoto);
        }
    }
}
