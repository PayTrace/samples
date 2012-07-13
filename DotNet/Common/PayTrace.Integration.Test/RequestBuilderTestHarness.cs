﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayTrace.Integration;
using PayTrace.Integration.API;
using PayTrace.Integration.RequestBuilders;


namespace PayTrace.Integration.Test
{
    [TestClass]
    public class RequestBuilderTestHarness
    {
        [TestMethod]
        public void AddressBuiler_should_set_the_billing_address_in_a_request()
        {
            Request request = new Request();

            AddressBuilder address_builder = new AddressBuilder(request);
            AddressInfo BillingAddress = new AddressInfo();

            BillingAddress.FullName = "Bob Smith";
            BillingAddress.Street = "2134 happy lane";
            BillingAddress.Street2 = "some more address stuff";
            BillingAddress.City = "Seattle";
            BillingAddress.Region = "WA";
            BillingAddress.PostalCode = "98136";
            BillingAddress.Country = "USA";

            address_builder.BillingAddress = BillingAddress;
            request = address_builder.Build();

            Assert.AreEqual(request[Keys.BNAME],  BillingAddress.FullName); 
            Assert.AreEqual(request[Keys.BADDRESS],BillingAddress.Street);
            Assert.AreEqual(request[Keys.BADDRESS2], BillingAddress.Street2);
            Assert.AreEqual(request[Keys.BCITY],BillingAddress.City);
            Assert.AreEqual(request[Keys.BSTATE],BillingAddress.Region);
            Assert.AreEqual(request[Keys.BZIP], BillingAddress.PostalCode); 
            Assert.AreEqual(request[Keys.BCOUNTRY],BillingAddress.Country);
        }

        [TestMethod]
        public void AddressBuilder_should_set_shipping_address_in_a_request()
        {

            Request request = new Request();

            AddressBuilder address_builder = new AddressBuilder(request);
            AddressInfo ShippingAddress = new AddressInfo();

            ShippingAddress.FullName = "Bob Smith";
            ShippingAddress.Street = "2134 happy lane";
            ShippingAddress.Street2 = "some more address stuff";
            ShippingAddress.City = "Seattle";
            ShippingAddress.Region = "WA";
            ShippingAddress.PostalCode = "98136";
            ShippingAddress.Country = "USA";

            address_builder.ShippingAddress = ShippingAddress;
            request = address_builder.Build();

            Assert.AreEqual(request[Keys.SNAME], ShippingAddress.FullName);
            Assert.AreEqual(request[Keys.SADDRESS], ShippingAddress.Street);
            Assert.AreEqual(request[Keys.SADDRESS2], ShippingAddress.Street2);
            Assert.AreEqual(request[Keys.SCITY], ShippingAddress.City);
            Assert.AreEqual(request[Keys.SSTATE], ShippingAddress.Region);
            Assert.AreEqual(request[Keys.SZIP], ShippingAddress.PostalCode);
            Assert.AreEqual(request[Keys.SCOUNTRY], ShippingAddress.Country);
        }
    }
}
