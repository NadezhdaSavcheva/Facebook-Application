using Facebook.Views.Utils;
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
            this.Hide();

            var homePage = FormFactory.GetFormInstance<HomePage>();
            homePage.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var profile = FormFactory.GetFormInstance<Profile>();
            profile.Show();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var events = FormFactory.GetFormInstance<Events>();
            events.Show();
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var friends = FormFactory.GetFormInstance<Friends>();
            friends.Show();
        }
    }
}
