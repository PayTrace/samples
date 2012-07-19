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
            CreditCardInfo cc = new CreditCardInfo("4111111111111111",1,2015,"999");
            cc.Validate();
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardValidationException))]
        public void CeditCard_should_throw_exception_when_validation_is_called_and_the_date_is_not_set()
        {
            CreditCardInfo cc = new CreditCardInfo();
            cc.Number = "4111111111111111";
            cc.ExpirationMonth = 1;
            cc.Validate();

        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardValidationException))]
        public void CreditCard_should_throw_exception_when_validation_is_called_with_bogus_credit_card_number()
        {
            CreditCardInfo cc = new CreditCardInfo();
            cc.Number = "4311111111111111";
            cc.ExpirationMonth = 1;
            cc.ExpirationYear = 2015;
            
            cc.Validate();

        }

        [TestMethod]
        public void Transaction_Request_should_have_credit_card_properties_as_key_value_pairs()
        {
            TransactionRequest transaction_request = new TransactionRequest("demo123","demo123");

            transaction_request.CreditCard.Number = "4111111111111111";
            transaction_request.CreditCard.ExpirationMonth = 1;
            transaction_request.CreditCard.ExpirationYear = 2015;
            transaction_request.CreditCard.CSC = "999";
            transaction_request.BillingAddress.Street = "2134 happy lane";
            transaction_request.BillingAddress.City = "Seattle"; 
            transaction_request.BillingAddress.Region = "WA";
            transaction_request.BillingAddress.PostalCode = "98136";
            transaction_request.BillingAddress.Country =  "USA";
            
            // need to build the request so we can see it.

            var request = transaction_request.BuildBaseSalesRequest();

            Assert.AreEqual(request[Keys.CC], "4111111111111111");
            Assert.AreEqual(request[Keys.CSC], "999");
            Assert.AreEqual(request[Keys.BADDRESS], "2134 happy lane");
            Assert.AreEqual(request[Keys.BCITY], "Seattle");
            Assert.AreEqual(request[Keys.BSTATE], "WA");
            Assert.AreEqual(request[Keys.BZIP], "98136");
            Assert.AreEqual(request[Keys.BCOUNTRY], "USA");
            

        }

        [TestMethod]
        public void Transaction_Response_should_handle_error_response()
        {
            Response response = new Response("ERROR~48. Please provide an Amount that is less than your Sale Ceiling Amount.|");
            TransactionResponse transaction_response = new TransactionResponse(response);

            Assert.IsTrue(transaction_response.HasError);
        }

        [TestMethod]
        public void Transaction_Request_should_contain_data_for_the_request()
        {
            TransactionRequest Request = new TransactionRequest("demo123", "demo123");
            
        }



    }
}
