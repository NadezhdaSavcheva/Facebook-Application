using System;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Groups : Form
    {
        public Groups()
        {
            InitializeComponent();
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            Groups.ActiveForm.Close();

            HomePage homePage = new HomePage(currentUser, currentProfile);
            homePage.Activate();
            homePage.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Groups.ActiveForm.Close();

            Profile profile = new Profile(currentUser, currentProfile);
            profile.Activate();
            profile.Show();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            Groups.ActiveForm.Close();

            Events events = new Events();
            events.Activate();
            events.Show();
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            Groups.ActiveForm.Close();

            Friends friends = new Friends();
            friends.Activate();
            friends.Show();
        }
    }
}
