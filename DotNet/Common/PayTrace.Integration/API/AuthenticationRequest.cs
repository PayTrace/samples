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

        public bool AgreeToTerms { get; set; }




        public Dictionary<string, string> ToAPI()
        {
            APIRequestBuilder Builder = new APIRequestBuilder();
            Builder.Add(AuthenticationMappings.UserName, UserName);
            Builder.Add(AuthenticationMappings.Password, Password);
            Builder.Add(AuthenticationMappings.Terms, AgreeToTerms);

            return Builder.ToAPI();
        }


        #region IAPIRequest Members

        public Uri Destination
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
