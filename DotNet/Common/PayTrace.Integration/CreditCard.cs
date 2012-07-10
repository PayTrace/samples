using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration
{
    public class CreditCard
    {
        public readonly string Number;
        public readonly string Amount;


        public AddressInfo BillingAddress { get; set; }
        public DateTime? ExperationDate { get; set; }
        public string CSC { get; set; }


        public CreditCard(string cc, string amount, AddressInfo billing_address = null,string csc = null, DateTime? experation_date = null)
        {
            Number = cc;
            Amount = amount;
            BillingAddress = billing_address;
            ExperationDate = experation_date;
            CSC = csc;
        }

        public void Validate()
        {
            CreditCardValidator Validator = new CreditCardValidator();
            
            Validator.ValidateCard(this);

        }



        
    }

}
