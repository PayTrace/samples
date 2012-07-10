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
            AddressInfo billing_address = cc.BillingAddress;

            APIAttributeValues.Add(Keys.CC, cc.Number);
            APIAttributeValues.Add(Keys.EXPMNTH, cc.ExperationDate.Value.Month.ToString());
            APIAttributeValues.Add(Keys.EXPYR, cc.ExperationDate.Value.Year.ToString());
            APIAttributeValues.Add(Keys.CSC, cc.CSC);
            APIAttributeValues.Add(Keys.SADDRESS, billing_address.Street);
            APIAttributeValues.Add(Keys.SADDRESS2, billing_address.Street2);
            APIAttributeValues.Add(Keys.SCITY, billing_address.City);
            APIAttributeValues.Add(Keys.SSTATE, billing_address.Region);
            APIAttributeValues.Add(Keys.SZIP, billing_address.PostalCode);
            APIAttributeValues.Add(Keys.SCOUNTY, billing_address.County);
            APIAttributeValues.Add(Keys.SCOUNTRY, billing_address.Country);
        }
    }
}
