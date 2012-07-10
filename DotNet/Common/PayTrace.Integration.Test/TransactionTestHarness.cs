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
            AddressInfo billing_address = new AddressInfo("2134 happy lane", city: "Seattle", region: "WA", postalcode: "98136", country: "United States");
            DateTime? experation_date = null;
            experation_date = new DateTime(2015, 1, 1);
            CreditCard cc = new CreditCard(cc: "4111111111111111", amount: "1.00", billing_address: billing_address, experation_date: experation_date);
            cc.Validate();

        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardValidationException))]
        public void CeditCard_should_throw_exception_when_validation_is_called_and_the_date_is_not_set()
        {
            AddressInfo billing_address = new AddressInfo("1234 happy lane", city: "Seattle", region: "WA", postalcode: "98136", country: "United States");
            CreditCard cc = new CreditCard(cc: "4111111111111111", amount: "1.00", billing_address: billing_address);

            cc.Validate();

        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardValidationException))]
        public void CreditCard_should_throw_exception_when_validation_is_called_with_bogus_credit_card_number()
        {
            AddressInfo billing_address = new AddressInfo("1234 happy lane", city: "Seattle", region: "WA", postalcode: "98136", country: "United States");
            DateTime? experation_date = null;
            experation_date = new DateTime(2015, 1, 1);
            CreditCard cc = new CreditCard(cc: "4311111111111111", amount: "1.00", billing_address: billing_address, experation_date: experation_date);

            cc.Validate();
        }

        [TestMethod]
        public void Transaction_Request_should_have_credit_card_properties_as_key_value_pairs()
        {
            AddressInfo billing_address = new AddressInfo("2134 happy lane", city: "Seattle", region: "WA", postalcode: "98136", country: "United States");
            DateTime? experation_date = null;
            experation_date = new DateTime(2015, 1, 1);
            CreditCard cc = new CreditCard(cc: "4111111111111111", amount: "1.00", billing_address: billing_address, experation_date: experation_date, csc: "999");
            TranasctionRequest Request = new TranasctionRequest();
            
            Request.AddCreditCardInfo(cc);
            var APIList = Request.GetAPIDictionary();

            Assert.AreEqual(APIList[Keys.CC], "4111111111111111");
            Assert.AreEqual(APIList[Keys.AMOUNT], "1.00");
            Assert.AreEqual(APIList[Keys.CSC], "999");
            Assert.AreEqual(APIList[Keys.BADDRESS], "2134 happy lane");
            Assert.AreEqual(APIList[Keys.BCITY], "Seattle");
            Assert.AreEqual(APIList[Keys.BSTATE], "WA");
            Assert.AreEqual(APIList[Keys.BZIP], "98136");
            

        }



    }
}
