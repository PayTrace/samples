using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayTrace.Integration;
using PayTrace.Integration.API;

namespace PayTrace.Integration.Test
{
    [TestClass]
    public class TransactionTestHarness
    {
        [TestMethod]
        public void CreditCard_should_pass_validation_tests()
        {
            CreditCard cc = new CreditCard("4111111111111111",1,2015,"999");
            cc.Validate();
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardValidationException))]
        public void CeditCard_should_throw_exception_when_validation_is_called_and_the_date_is_not_set()
        {
            CreditCard cc = new CreditCard();
            cc.Number = "4111111111111111";
            cc.ExpirationMonth = 1;
            cc.Validate();

        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardValidationException))]
        public void CreditCard_should_throw_exception_when_validation_is_called_with_bogus_credit_card_number()
        {
            CreditCard cc = new CreditCard();
            cc.Number = "4311111111111111";
            cc.ExpirationMonth = 1;
            cc.ExpirationYear = 2015;
            
            cc.Validate();

        }

        [TestMethod]
        public void Transaction_Request_should_have_credit_card_properties_as_key_value_pairs()
        {
            TransactionRequest request = new TransactionRequest("demo123","demo123");

            request.CC.Number = "4111111111111111";
            request.CC.ExpirationMonth = 1;
            request.CC.ExpirationYear = 2015;
            request.CC.CSC = "999";
            request.BillingAddress.Street = "2134 happy lane";
            request.BillingAddress.City = "Seattle"; 
            request.BillingAddress.Region = "WA";
            request.BillingAddress.PostalCode = "98136";
            request.BillingAddress.Country =  "USA";
            
            // need to build the request so we can see it.
            request.BuildRequest();

            var APIList = request.GetAPIDictionary();

            Assert.AreEqual(APIList[Keys.CC], "4111111111111111");
            Assert.AreEqual(APIList[Keys.CSC], "999");
            Assert.AreEqual(APIList[Keys.BADDRESS], "2134 happy lane");
            Assert.AreEqual(APIList[Keys.BCITY], "Seattle");
            Assert.AreEqual(APIList[Keys.BSTATE], "WA");
            Assert.AreEqual(APIList[Keys.BZIP], "98136");
            Assert.AreEqual(APIList[Keys.BCOUNTRY],"USA");
            

        }

        [TestMethod]
        public void Transaction_Response_should_handle_error_response()
        {
            Response response = new Response("ERROR~48. Please provide an Amount that is less than your Sale Ceiling Amount.|");
            TransactionResponse transaction_response = new TransactionResponse(response);

            Assert.IsTrue(transaction_response.HasError);
        }



    }
}
