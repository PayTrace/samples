using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;

namespace PayTrace.Integration.RequestBuilders
{
    public class AuthorizationBuilder : RequestBuilderBase
    {

        public AuthorizationInfo Authorization { get; set; } 
        
        public AuthorizationBuilder(Request request):base(request){}
      
        public override Request Build()
        {
            _request[Keys.UN] = Authorization.UserName;
            _request[Keys.PSWD] = Authorization.Password.ToString();
            _request[Keys.TERMS] = "Y";

            return _request;
        }
    }
}
