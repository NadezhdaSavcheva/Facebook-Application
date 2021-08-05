using Facebook.Views.Utils;
using System;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void facebookLoginPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void entranceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string emailOrPhoneNumber = this.emailLoginTextBox.Text;
                string password = this.passwordLoginTextBox.Text;

                //int userId = this.homeController.Login(username, HashPassword(password));

                var homePage = FormFactory.GetFormInstance<HomePage>();
                homePage.Show();

                this.Hide();
            }
            catch (Exception error)
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = error.Message;
            }
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var registration = FormFactory.GetFormInstance<Registration>();
            registration.Show();
        }
    }
}
