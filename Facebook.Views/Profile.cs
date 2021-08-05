using Facebook.Views.Utils;
using System;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
