using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration
{
    public class SecureCheckout
    {
        public readonly Authentication _authentication;

        public SecureCheckout(Authentication authentication)
        {
            _authentication = authentication;
        }

        public Authorization GetAuthorization()
        {
            throw new NotImplementedException();         
        }
    }
}
