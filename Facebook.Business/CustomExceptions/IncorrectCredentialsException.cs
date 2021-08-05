using System;

namespace Facebook.Business.CustomExceptions
{
    class IncorrectCredentialsException : Exception
    {
        public IncorrectCredentialsException(string message)
            : base(message)
        {

        }
    }
}
