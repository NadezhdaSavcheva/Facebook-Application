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
            this.Hide();

            Profile profile = new Profile();
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
            this.Hide();

            var homePage = FormFactory.GetFormInstance<HomePage>();
            homePage.Show();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var groups = FormFactory.GetFormInstance<Groups>();
            groups.Show();
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var friends = FormFactory.GetFormInstance<Friends>();
            friends.Show();
        }
    }
}
