using Facebook.Services;
using Facebook.Services.DAO;
using Facebook.Services.Models;
using Facebook.Views.Utils;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class Registration : Form
    {
        private HomeDAO homeDAO;
        private Regex regexPass;
        private Regex regexNames;

        public Registration()
        {
            InitializeComponent();
            FacebookDBContext context = new FacebookDBContext();
            this.homeDAO = new HomeDAO(context);
            this.errorLabel.Visible = false;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            regexPass = new Regex("^([a-zA-Z0-9])*$");
            regexNames = new Regex("^([a-zA-Z])*$");

            if (regexPass.IsMatch(passwordTextBox.Text))
            {
                if (regexNames.IsMatch(firstNameTextBox.Text) && regexNames.IsMatch(lastNameTextBox.Text))
                {
                    try
                    {
                        if (!PasswordHelper.IsSame(this.passwordTextBox.Text, this.repeatPasswordTextBox.Text))
                        {
                            throw new Exception("Password mismatch.");
                        }

                        Users newUser = new Users();
                        newUser.FirstName = firstNameTextBox.Text;
                        newUser.LastName = lastNameTextBox.Text;
                        if (numberOrEmailTextBox.Text.Contains('@'))
                        {
                            newUser.Email = numberOrEmailTextBox.Text;
                        }
                        else
                        {
                            newUser.PhoneNumber = numberOrEmailTextBox.Text;
                        }
                        newUser.PasswordHash = this.homeDAO.HashPassword(passwordTextBox.Text);
                        newUser.Birthdate = dateOfBirth.Value;
                        if (maleRadioButton.Checked == true)
                        {
                            newUser.Gender = maleRadioButton.Name;
                        }
                        else if (femaleRadioButton.Checked == true)
                        {
                            newUser.Gender = femaleRadioButton.Name;
                        }
                        else if (otherGenderRadioButton.Checked == true)
                        {
                            newUser.Gender = otherGenderRadioButton.Name;
                        }

                        homeDAO.RegisterUser(newUser);

                        this.Close();
                        Login loginPage = new Login();
                        loginPage.Activate();
                        loginPage.Show();
                    }
                    catch (Exception error)
                    {
                        Exception ex = new Exception();
                        MessageBox.Show(ex.ToString());
                        this.errorLabel.Visible = true;
                        this.errorLabel.Text = error.Message;
                    }
                }
                else MessageBox.Show("Names only contain symbols from A to Z!");
            }
            else MessageBox.Show("Password cannot contains special symbols!");
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
        }
    }
}
