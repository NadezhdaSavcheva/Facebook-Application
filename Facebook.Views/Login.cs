using Facebook.Services;
using Facebook.Services.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Login : Form
    {
        private HomeDAO homeDAO;
        public Login()
        {
            InitializeComponent();
            FacebookDBContext context = new FacebookDBContext();
            this.homeDAO = new HomeDAO(context);
            emailLoginTextBox.Text = "";
            passwordLoginTextBox.Text = "";
        }

        public void CheckIfUserIsNull(string emailOrPhoneNumber, string password)
        {
            var result = this.homeDAO.Login(emailOrPhoneNumber, password);
            if (result != null)
            {
                Login.ActiveForm.Hide();
                HomePage homePage = new HomePage();
                homePage.Activate();
                homePage.Show();
            }
            else
            {
                errorLabel.Visible = true;
                emailLoginTextBox.Text = "";
                passwordLoginTextBox.Text = "";
            }
        }

        private void entranceButton_Click(object sender, EventArgs e)
        {
            string emailOrPhoneNumber = emailLoginTextBox.Text, password = passwordLoginTextBox.Text;

            CheckIfUserIsNull(emailOrPhoneNumber, password);
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.Close();

            Registration registration = new Registration();
            registration.Activate();
            registration.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
        }
    }
}
