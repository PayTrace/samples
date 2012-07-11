using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration
{
    public class CreditCard
    {
        public string Number { get; set; }
        public string CSC { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        
        public CreditCard() { }

        public CreditCard(
            string number,  
            int experationMonth,
            int experationYear,
            string csc = null 
            )
        {
            Number = number;
            ExpirationYear = experationMonth;
            ExpirationYear = experationYear;
            CSC = csc;
        }

        public void Validate()
        {
            CreditCardValidator Validator = new CreditCardValidator();
            
            Validator.ValidateCard(this);

        }



        
    }

}
