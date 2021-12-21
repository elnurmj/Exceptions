using Expections.Constants;
using Expections.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Expections.Auth
{
    public class Account
    {
        public void Login(string userName, string password)
        {
            try
            {
                if ( password.Length < 6)
                {
                    throw new LoginException(Messages.LoginMessage);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login was success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}