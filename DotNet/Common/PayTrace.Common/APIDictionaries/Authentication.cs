using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.APIDictionaries
{
    public class Authentication
    {
        public string UserName {get;set;}

        public string password { get; set; }

        public AgreeToTerms AgreeToTerms { get; set; }

    }
}
