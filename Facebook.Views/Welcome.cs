using System;
using System.Drawing;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
        }

        private void welcomeContinueButton_Click(object sender, EventArgs e)
        {
            Welcome.ActiveForm.Hide();

            Login loginForm = new Login();
            loginForm.Activate();
            loginForm.Show();
        }

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
