using Facebook.Services;
using Facebook.Services.DAO;
using Facebook.Services.Models;
using System.Drawing;
using System.Windows.Forms;

namespace Facebook.Views
{
    public partial class EditProfile : Form
    {
        Users currentUser;
        Profiles currentProfile;
        private ProfileDAO profileDAO;
        public EditProfile(Users currentUser, Profiles currentProfile)
        {
            InitializeComponent();
            FacebookDBContext context = new FacebookDBContext();
            this.currentUser = currentUser;
            this.currentProfile = currentProfile;
            this.profileDAO = new ProfileDAO(context);
        }

        private void descriptionTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string newDescription = descriptionTextBox.Text;
            this.profileDAO.ChangeDescription(currentUser.UserId, newDescription);

        }

        private void schoolTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string newSchool = schoolTextBox.Text;
            this.profileDAO.ChangeSchool(currentUser.UserId, newSchool);
        }

        private void workplaceTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string newWorkplace = workplaceTextBox.Text;
            this.profileDAO.ChangeWorkplace(currentUser.UserId, newWorkplace);
        }

        private void cityCountryTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string newCityCountry = cityCountryTextBox.Text;
            this.profileDAO.ChangeCityCountry(currentUser.UserId, newCityCountry);
        }

        private void hobbiesTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string newHobbies = hobbiesTextBox.Text;
            this.profileDAO.ChangeHobbies(currentUser.UserId, newHobbies);
        }

        private void statusTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string newStatus = statusTextBox.Text;
            this.profileDAO.ChangeStatus(currentUser.UserId, newStatus);
        }

        private void doneButton_Click(object sender, System.EventArgs e)
        {
            EditProfile.ActiveForm.Close();

            Profile profile = new Profile(currentUser, currentProfile);
            profile.Activate();
            profile.Show();
        }

        private void EditProfile_Load(object sender, System.EventArgs e)
        {
            Location = new Point(600, 250);
        }
    }
}
