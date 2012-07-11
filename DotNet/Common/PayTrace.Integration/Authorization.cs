using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration
{
    public class Authorization
    {
        public readonly string UserName;
        public readonly string Password;
 
        public Authorization(string username, string password )
        {
            UserName = username;
            Password = password;
        }

    }
}
