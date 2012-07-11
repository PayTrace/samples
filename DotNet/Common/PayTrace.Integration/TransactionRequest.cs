using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;

namespace PayTrace.Integration
{
    public class TransactionRequest : Request
    {
        public AddressInfo BillingAddress = new AddressInfo();
        public CreditCard CC = new CreditCard();

        public TransactionRequest(Uri destination) : base(destination) { }

        public TransactionRequest(string username, string password) :base (Destinations.Default) 
        {
            AddAuthorizationInfo(username, password);
        }

        public void AddAuthorizationInfo(string username, string password)
        {
            APIAttributeValues.Add(Keys.UN, username);
            APIAttributeValues.Add(Keys.PSWD, password);
            APIAttributeValues.Add(Keys.TERMS,"Y"); 
        }
        
        internal void BuildRequest()
        {
            CC.Validate();

            APIAttributeValues.Add(Keys.CC, CC.Number);
            APIAttributeValues.Add(Keys.EXPMNTH, CC.ExpirationMonth.ToString());
            APIAttributeValues.Add(Keys.EXPYR, CC.ExpirationYear.ToString());
            APIAttributeValues.Add(Keys.CSC, CC.CSC);
            
            if (BillingAddress != null)
            {
                APIAttributeValues.Add(Keys.BADDRESS, BillingAddress.Street);
                APIAttributeValues.Add(Keys.BADDRESS2, BillingAddress.Street2);
                APIAttributeValues.Add(Keys.BCITY, BillingAddress.City);
                APIAttributeValues.Add(Keys.BSTATE, BillingAddress.Region);
                APIAttributeValues.Add(Keys.BZIP, BillingAddress.PostalCode);
                APIAttributeValues.Add(Keys.BCOUNTRY, BillingAddress.Country);
            }
        }
    

        public Response Authorize(decimal amount)
        {
            BuildRequest();

            APIAttributeValues.Add(Keys.AMOUNT, amount.ToString());
            APIAttributeValues.Add(Keys.TRANXTYPE, TransactionTypes.Authorization);
            APIAttributeValues.Add(Keys.METHOD, "ProcessTranx");
            return this.Send();
        }
    }
}
