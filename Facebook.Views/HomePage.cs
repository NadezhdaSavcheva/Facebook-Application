using Facebook.Services;
using Facebook.Services.DAO;
using Facebook.Services.Models;
using Facebook.Views.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class HomePage : Form
    {
        Users currentUser;
        Profiles currentProfile;

        private Posts post;
        private PostsDAO postsDAO;
        private ProfileDAO profileDAO;

        int page = 1;

        public HomePage(Users currentUser, Profiles currentProfile)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.currentProfile = currentProfile;
            FacebookDBContext context = new FacebookDBContext();
            this.postsDAO = new PostsDAO(context);
            this.profileDAO = new ProfileDAO(context);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage.ActiveForm.Close();

            Profile profile = new Profile(currentUser, currentProfile);
            profile.Activate();
            profile.Show();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            HomePage.ActiveForm.Close();

            Groups groups = new Groups();
            groups.Activate();
            groups.Show();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            HomePage.ActiveForm.Close();

            Events events = new Events();
            events.Activate();
            events.Show();
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            HomePage.ActiveForm.Close();

            Friends friends = new Friends();
            friends.Activate();
            friends.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);

            postPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            postPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            postPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            postPictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            LoadPosts(this.postsDAO.GetAllPosts(), this.profileDAO.GetAllProfiles());
        }

        public void LoadPosts(List<Posts> posts, List<Profiles> profiles)
        {

            Posts post1, post2, post3, post4;
            Profiles profile1, profile2, profile3, profile4;
            try
            {
                post1 = posts.ElementAt(page * 4 - 4);
                profile1 = profiles.ElementAt(page * 4 - 4);
                authorPictureBox1.Image = this.profileDAO.ByteToImage(profile1.ProfilePhoto);
                authorNameLabel1.Text = profile1.User.FirstName + " " + profile1.User.LastName;
                postPictureBox1.Image = this.postsDAO.ByteToImage(post1.Photo);

            }
            catch (Exception)
            {
                authorPictureBox1.Image = profileDAO.ByteToImage(Resources.no_photo);
                authorNameLabel1.Text = "";
                postPictureBox1.Image = postsDAO.ByteToImage(Resources.no_photo);
            }
            try
            {
                post2 = posts.ElementAt(page * 4 - 3);
                profile2 = profiles.ElementAt(page * 4 - 3);
                authorPictureBox2.Image = this.profileDAO.ByteToImage(profile2.ProfilePhoto);
                authorNameLabel2.Text = profile2.User.FirstName + " " + profile2.User.LastName;
                postPictureBox2.Image = this.postsDAO.ByteToImage(post2.Photo);

            }
            catch (Exception)
            {
                authorPictureBox2.Image = profileDAO.ByteToImage(Resources.no_photo);
                authorNameLabel2.Text = "";
                postPictureBox2.Image = postsDAO.ByteToImage(Resources.no_photo);
            }
            try
            {
                post3 = posts.ElementAt(page * 4 - 2);
                profile3 = profiles.ElementAt(page * 4 - 2);
                authorPictureBox3.Image = this.profileDAO.ByteToImage(profile3.ProfilePhoto);
                authorNameLabel3.Text = profile3.User.FirstName + " " + profile3.User.LastName;
                postPictureBox3.Image = this.postsDAO.ByteToImage(post3.Photo);

            }
            catch (Exception)
            {
                authorPictureBox3.Image = profileDAO.ByteToImage(Resources.no_photo);
                authorNameLabel3.Text = "";
                postPictureBox3.Image = postsDAO.ByteToImage(Resources.no_photo);
            }
            try
            {
                post4 = posts.ElementAt(page * 4 - 1);
                profile4 = profiles.ElementAt(page * 4 - 1);
                authorPictureBox4.Image = this.profileDAO.ByteToImage(profile4.ProfilePhoto);
                authorNameLabel4.Text = profile4.User.FirstName + " " + profile4.User.LastName;
                postPictureBox4.Image = this.postsDAO.ByteToImage(post4.Photo);
            }
            catch (Exception)
            {
                authorPictureBox4.Image = profileDAO.ByteToImage(Resources.no_photo);
                authorNameLabel4.Text = "";
                postPictureBox4.Image = postsDAO.ByteToImage(Resources.no_photo);
            }
        }
    }
}
