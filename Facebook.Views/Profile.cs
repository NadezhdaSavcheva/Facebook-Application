using Facebook.Services;
using Facebook.Services.DAO;
using Facebook.Services.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Profile : Form
    {
        Users currentUser;
        Profiles currentProfile;
        private PictureBox profilePicture;
        private PictureBox coverPicture;
        private PostsDAO postsDAO;
        private ProfileDAO profileDAO;
        public Profile(Users currentUser, Profiles currentProfile)
        {
            InitializeComponent();
            FacebookDBContext context = new FacebookDBContext();
            this.currentUser = currentUser;
            this.currentProfile = currentProfile;
            this.postsDAO = new PostsDAO(context);
            this.profileDAO = new ProfileDAO(context);
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            Profile.ActiveForm.Close();

            HomePage homePage = new HomePage(currentUser, currentProfile);
            homePage.Activate();
            homePage.Show();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            Profile.ActiveForm.Close();

            Groups groups = new Groups();
            groups.Activate();
            groups.Show();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            Profile.ActiveForm.Close();

            Events events = new Events();
            events.Activate();
            events.Show();
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            Profile.ActiveForm.Close();

            Friends friends = new Friends();
            friends.Activate();
            friends.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Profile.ActiveForm.Close();

            EditProfile editProfile = new EditProfile(currentUser, currentProfile);
            editProfile.Activate();
            editProfile.Show();
        }

        private void newPostButton_Click(object sender, EventArgs e)
        {
            Profile.ActiveForm.Hide();
            CreatePost createPost = new CreatePost(currentUser, currentProfile);
            createPost.Activate();
            createPost.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            currentUser = null;
            Profile.ActiveForm.Close();
            Login loginForm = new Login();
            loginForm.Activate();
            loginForm.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);

            nameTextBox.Text = currentUser.FirstName + " " + currentUser.LastName;
            descriptionTextBox.Text = this.profileDAO.GetProfileInfo(currentUser.UserId).Description;
            profilePictureImage.Image = this.profileDAO.ByteToImage(this.profileDAO.GetProfileInfo(currentUser.UserId).ProfilePhoto);
            coverPhotoImage.Image = this.profileDAO.ByteToImage(this.profileDAO.GetProfileInfo(currentUser.UserId).CoverPhoto);
            schoolTextBox.Text = this.profileDAO.GetProfileInfo(currentUser.UserId).School.Name;
            workplaceTextBox.Text = this.profileDAO.GetProfileInfo(currentUser.UserId).Workplace.Name;
            cityCountryTextBox.Text = this.profileDAO.GetProfileInfo(currentUser.UserId).City.Name + ", "
                                    + this.profileDAO.GetProfileInfo(currentUser.UserId).City.Country.Name;
            hobbiesTextBox.Text = this.profileDAO.GetProfileInfo(currentUser.UserId).Hobbies;
            statusTextBox.Text = this.profileDAO.GetProfileInfo(currentUser.UserId).UserStatus.Type;
        }

        private void profilePictureImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    profilePictureImage.SizeMode = PictureBoxSizeMode.Zoom;
                    profilePictureImage.Image = new Bitmap(open.FileName);
                    profilePicture = profilePictureImage;
                }
            }
            catch (Exception)
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
        }

        private void coverPhotoImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    coverPhotoImage.SizeMode = PictureBoxSizeMode.Zoom;
                    coverPhotoImage.Image = new Bitmap(open.FileName);
                    coverPicture = coverPhotoImage;
                }
            }
            catch (Exception)
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
