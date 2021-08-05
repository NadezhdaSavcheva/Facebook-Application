using Facebook.Views.Utils;
using System;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (!PasswordHelper.IsSame(this.passwordTextBox.Text, this.repeatPasswordTextBox.Text))
                {
                    throw new Exception("Password mismatch.");
                }

                /*RegistrationViewModel registrationViewModel = new RegistrationViewModel();

				registrationViewModel.FirstName = this.firstNameTextBox.Text;
				registrationViewModel.LastName = this.lastNameTextBox.Text;
				registrationViewModel.CountryName = this.countryNameTextBox.Text;
				registrationViewModel.TownName = this.townNameTextBox.Text;
				registrationViewModel.RoleName = GetSelectedRole();

				registrationViewModel.Username = this.usernameTextBox.Text;
				registrationViewModel.Password = PasswordHelper.HashPassword(this.passwordTextBox.Text);

				if (this.villainRoleCheckBox.Checked)
				{
					registrationViewModel.EvilnessFactor = this.evilnessFactorTextBox.Text;
				}

				this.homeController.Register(registrationViewModel);*/

                this.Close();
                var homePage = FormFactory.GetFormInstance<HomePage>();
                homePage.Show();
            }
            catch (Exception error)
            {

                this.errorLabel.Visible = true;
                this.errorLabel.Text = error.Message;
            }
        }
    }
}
