using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.Interfaces;
using PayTrace.Integration.API;


namespace PayTrace.Integration.SecureCheckout
{
    public class OrderValidation :IAPIRequest
    {
        public string ReturnURL { get; set; }
        public decimal Amount { get; set; }
        public string ApprovalURL { get; set; }
        public string DeclineURL { get; set; }
        public bool ForceEmail { get; set; }
        public bool ForceAddress { get; set; }
        public bool ForceCSC { get; set; }
        public string OrderID { get; set; }

        private AuthenticationRequest _authorization = null;
        public AuthenticationRequest Authentication
        {   get 
            {
                return _authorization;
            }
        }

        
        protected  string TransactionType = "Sale";


        public OrderValidation(AuthenticationRequest authorization)
        {
            _authorization = authorization;
        }

        public Dictionary<string,string> ToAPI()
        {
            APIRequestBuilder Builder = new APIRequestBuilder();

            Builder.Add(SecureCheckoutMappings.OrderID, OrderID);
            Builder.Add(SecureCheckoutMappings.Amount, Amount.ToString());
            Builder.Add(SecureCheckoutMappings.ReturnURL, ReturnURL);
            Builder.Add(SecureCheckoutMappings.ApprovalURL, ApprovalURL);
            Builder.Add(SecureCheckoutMappings.DeclineURL, DeclineURL);
            Builder.Add(SecureCheckoutMappings.ForceAddress, ForceAddress);
            Builder.Add(SecureCheckoutMappings.ForceEmail, ForceEmail);
            Builder.Add(SecureCheckoutMappings.ForceCSC, ForceCSC);
            Builder.Add(SecureCheckoutMappings.TransactionType, TransactionType);
            Builder.AppendDictionary(Authentication.ToAPI());

            return Builder.ToAPI();
        }

        private object get_type(System.Reflection.PropertyInfo property)
        {
            if (property.PropertyType == typeof(string))
            {
                return string.Empty;
            }
            else
            {
                return Activator.CreateInstance(property.PropertyType);
            }

            

        }




       
    }
}
