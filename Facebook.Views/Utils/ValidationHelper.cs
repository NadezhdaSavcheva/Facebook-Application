using System.Text.RegularExpressions;

namespace Facebook.Views.Utils
{
    static class ValidationHelper
    {
        public static bool IsStrigValid(string input)
        {
            bool isValid = false;
            string validCharecterPattern = @"^[a-z A-Z]+$";

            isValid = Regex.IsMatch(input, validCharecterPattern);
            return isValid;
        }
    }
}
