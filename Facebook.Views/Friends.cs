using System;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Friends : Form
    {
        public Friends()
        {
            InitializeComponent();
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            Friends.ActiveForm.Close();

            HomePage homePage = new HomePage(currentUser, currentProfile);
            homePage.Activate();
            homePage.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Friends.ActiveForm.Close();

            Profile profile = new Profile(currentUser, currentProfile);
            profile.Activate();
            profile.Show();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            Friends.ActiveForm.Close();

            Groups groups = new Groups();
            groups.Activate();
            groups.Show();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            Friends.ActiveForm.Close();

            Events events = new Events();
            events.Activate();
            events.Show();
        }
    }
}
