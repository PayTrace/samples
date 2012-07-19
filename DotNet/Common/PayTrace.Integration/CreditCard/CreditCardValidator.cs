using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PayTrace.Integration
{
    class CreditCardValidator
    {
        public void ValidateCard(CreditCardInfo cc)
        {
            CheckRequiredFields(cc);

            if (! ValidateCreditCardNumber(cc.Number))
            {
                throw new CreditCardValidationException("Please use valid credit card number.");
            }
        }

        private bool ValidateCreditCardNumber(string creditCardNumber)
        {
            //Replace any character other than 0-9 with ""
            creditCardNumber = Regex.Replace(creditCardNumber, @"[^0-9]", "");

            int cardSize = creditCardNumber.Length;

            //Creditcard number length must be between 13 and 16
            if (cardSize >= 13 && cardSize <= 16)
            {
                int odd = 0;
                int even = 0;
                char[] cardNumberArray = new char[cardSize];

                //Read the creditcard number into an array
                cardNumberArray = creditCardNumber.ToCharArray();

                //Reverse the array
                Array.Reverse(cardNumberArray, 0, cardSize);

                //Multiply every second number by two and get the sum. 
                //Get the sum of the rest of the numbers.
                for (int i = 0; i < cardSize; i++)
                {
                    if (i % 2 == 0)
                    {
                        odd += (Convert.ToInt32(cardNumberArray.GetValue(i)) - 48);
                    }
                    else
                    {
                        int temp = (Convert.ToInt32(cardNumberArray[i]) - 48) * 2;
                        //if the value is greater than 9, substract 9 from the value
                        if (temp > 9)
                        {
                            temp = temp - 9;
                        }
                        even += temp;
                    }
                }
                if ((odd + even) % 10 == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private void CheckRequiredFields(CreditCardInfo cc)
        {
            if (string.IsNullOrWhiteSpace(cc.Number))
            {
                throw new CreditCardValidationException("Credit Card Number cannont be null or empty.");
            }

           
            if (cc.ExpirationMonth < 1 && cc.ExpirationMonth > 12  )
            {
                throw new CreditCardValidationException("Experation Month was not set to a valid month.");
            }

            if (cc.ExpirationYear  < DateTime.Now.Year)
            {
                throw new CreditCardValidationException("Experation Year must be greater then or equal to the current year.");
            }
        }

    }
}
