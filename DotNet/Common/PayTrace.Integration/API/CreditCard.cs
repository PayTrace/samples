using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.API
{
    public class CreditCard
    {
        public readonly string CC;
        public readonly decimal Amount;

        public AddressInfo BillingAddress { get; set; }
        public DateTime? Experation { get; set; }
        

        public CreditCard(string cc,decimal amount, AddressInfo billingAddress = null, DateTime? experation = null)
        {
            BillingAddress = billingAddress;
            CC = cc;
            Experation = experation;
            Amount = amount;
        }

        
    }

}
