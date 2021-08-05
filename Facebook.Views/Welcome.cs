using Facebook.Views.Utils;
using System;
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

        }

        private void welcomeContinueButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var loginForm = FormFactory.GetFormInstance<Login>();
            loginForm.Show();
        }
    }
}
