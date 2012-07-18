using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration
{
    public class AuthorizationInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public AuthorizationInfo(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
