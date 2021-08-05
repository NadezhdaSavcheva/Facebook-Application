using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.Views.CustomExceptions
{
    class IncorrectCredentialsException : Exception
    {
        public IncorrectCredentialsException(string message)
            : base(message)
        {

        }
    }
}
