using System;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Facebook.Views.Events.ActiveForm.Close();

            Profile profile = new Profile(currentUser, currentProfile);
            profile.Activate();
            profile.Show();
        }

        private void profileIconImage_Click(object sender, EventArgs e)
        {

        }

        private void homePageIconImage_Click(object sender, EventArgs e)
        {

        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            Facebook.Views.Events.ActiveForm.Close();

            HomePage homePage = new HomePage(currentUser, currentProfile);
            homePage.Activate();
            homePage.Show();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            Facebook.Views.Events.ActiveForm.Close();

            Groups groups = new Groups();
            groups.Activate();
            groups.Show();
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            Facebook.Views.Events.ActiveForm.Close();

            Friends friends = new Friends();
            friends.Activate();
            friends.Show();
        }
    }
}
