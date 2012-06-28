using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.Interfaces;
namespace PayTrace.Integration.API
{
    public class AuthenticationRequest : IAPIRequest
    {
        public string UserName {get;set;}

        public string Password { get; set; }

        public AgreeToTerms AgreeToTerms { get; set; }




        public Dictionary<string, string> ToAPI()
        {
            throw new NotImplementedException();
        }
    }
}
