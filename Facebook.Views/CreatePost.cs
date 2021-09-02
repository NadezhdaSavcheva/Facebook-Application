using Facebook.Services;
using Facebook.Services.DAO;
using Facebook.Services.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class CreatePost : Form
    {
        Users currentUser;
        Profiles currentProfile;
        private PostsDAO postsDAO;
        private PictureBox picture;

        public CreatePost(Users currentUser, Profiles currentProfile)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.currentProfile = currentProfile;
            FacebookDBContext context = new FacebookDBContext();
            this.postsDAO = new PostsDAO(context);
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            CreatePost.ActiveForm.Close();

            HomePage homePage = new HomePage(currentUser, currentProfile);
            homePage.Activate();
            homePage.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            CreatePost.ActiveForm.Close();

            Profile profile = new Profile(currentUser, currentProfile);
            profile.Activate();
            profile.Show();
        }

        private void uploadPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                uploadPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                uploadPictureBox.Image = new Bitmap(open.FileName);
                picture = uploadPictureBox;
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            Posts newPost = new Posts();

            newPost.ParentPostId = null;
            newPost.AuthorId = currentUser.UserId;
            newPost.Content = descriptionTextBox.Text;
            newPost.Photo = this.postsDAO.ImageToByte(picture.Image);
            newPost.Type = "post";
            newPost.Status = "published";

            postsDAO.CreatePost(newPost);

            CreatePost.ActiveForm.Close();
            HomePage homePage = new HomePage(currentUser, currentProfile);
            homePage.Activate();
            homePage.Show();
        }

        private void CreatePost_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
        }
    }
}
