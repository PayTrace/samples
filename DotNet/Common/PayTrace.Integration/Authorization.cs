using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration
{
    public class Authorization
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public Authorization(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
