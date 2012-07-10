using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;

namespace PayTrace.Integration
{
    public class TranasctionRequest : Request
    {
        public void AddCreditCardInfo(CreditCard cc)
        {
            APIAttributeValues.Add(Keys.CC, cc.Number);
            APIAttributeValues.Add(Keys.AMOUNT, cc.Amount);
            APIAttributeValues.Add(Keys.EXPMNTH, cc.ExperationDate.Value.Month.ToString());
            APIAttributeValues.Add(Keys.EXPYR, cc.ExperationDate.Value.Year.ToString());
            APIAttributeValues.Add(Keys.CSC, cc.CSC);
            
            if (cc.BillingAddress != null)
            {
                AddressInfo billing_address = cc.BillingAddress;
                APIAttributeValues.Add(Keys.BADDRESS, billing_address.Street);
                APIAttributeValues.Add(Keys.BADDRESS2, billing_address.Street2);
                APIAttributeValues.Add(Keys.BCITY, billing_address.City);
                APIAttributeValues.Add(Keys.BSTATE, billing_address.Region);
                APIAttributeValues.Add(Keys.BZIP, billing_address.PostalCode);
                APIAttributeValues.Add(Keys.BCOUNTRY, billing_address.Country);
            }
   
        }
    }
}
