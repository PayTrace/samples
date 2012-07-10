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
    }
}
