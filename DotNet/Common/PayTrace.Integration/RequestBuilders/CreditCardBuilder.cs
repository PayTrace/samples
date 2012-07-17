using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;

namespace PayTrace.Integration.RequestBuilders
{
    public class CreditCardBuilder
    {
        private Request _request;
        
        public CreditCard CreditCard{get;set;}

        public CreditCardBuilder( Request request)
        {
            _request = request;
        }

        public Request Build()
        {
            _request[Keys.CC] = CreditCard.Number;
            _request[Keys.EXPMNTH] = CreditCard.ExpirationMonth.ToString();
            _request[Keys.EXPYR] = CreditCard.ExpirationYear.ToString();
            _request[Keys.CSC] =  CreditCard.CSC;

            return _request;
        }

    }
}
