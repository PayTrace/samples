using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.Interfaces;  
namespace PayTrace.Integration.SecureCheckout
{
    public class SecureCheckoutRequest : IAPIRequest
    {
        public string SendValidationRequest()
        {
            throw new NotImplementedException(); 
        }

        public Dictionary<string,string> ToAPI()
        {
            
            throw new NotImplementedException();
        }

        #region IAPIRequest Members


        public bool IsValid
        {
            get { throw new NotImplementedException(); }
        }

        public List<string> GetValidationErrors()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
