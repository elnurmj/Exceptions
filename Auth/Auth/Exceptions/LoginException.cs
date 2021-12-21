using System;
using System.Collections.Generic;
using System.Text;

namespace Expections.Exceptions
{
    public class LoginException: Exception
    {
        public LoginException(string msg) : base(msg) { }
    }
}
