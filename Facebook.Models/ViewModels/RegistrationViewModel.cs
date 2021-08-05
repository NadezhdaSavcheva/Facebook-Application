using System;

namespace Facebook.Models.ViewModels
{
    public class RegistrationViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
    }
}
