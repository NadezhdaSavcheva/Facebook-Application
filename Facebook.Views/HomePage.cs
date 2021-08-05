using Facebook.Views.Utils;
using System;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var profile = FormFactory.GetFormInstance<Profile>();
            profile.Show();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var groups = FormFactory.GetFormInstance<Groups>();
            groups.Show();
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
