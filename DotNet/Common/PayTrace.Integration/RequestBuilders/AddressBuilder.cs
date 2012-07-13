using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration;
using PayTrace.Integration.API;

namespace PayTrace.Integration.RequestBuilders
{
    internal class AddressBuilder
    {
        private API.Request Request;

        public AddressBuilder(API.Request request)
        {
            // TODO: Complete member initialization
            this.Request = request;
        }



        public AddressInfo BillingAddress { get; set; }

        public Request Build()
        {
            if (BillingAddress != null)
            {
                Request[Keys.BNAME] = BillingAddress.FullName;
                Request[Keys.BADDRESS] = BillingAddress.Street;
                Request[Keys.BADDRESS2] = BillingAddress.Street2;
                Request[Keys.BCITY] = BillingAddress.City;
                Request[Keys.BSTATE] = BillingAddress.Region;
                Request[Keys.BZIP] = BillingAddress.PostalCode;
                Request[Keys.BCOUNTRY] = BillingAddress.Country;
            }

            if (ShippingAddress != null)
            {
                Request[Keys.SNAME] = ShippingAddress.FullName;
                Request[Keys.SADDRESS] = ShippingAddress.Street;
                Request[Keys.SADDRESS2] = ShippingAddress.Street2;
                Request[Keys.SCITY] = ShippingAddress.City;
                Request[Keys.SSTATE] = ShippingAddress.Region;
                Request[Keys.SZIP] = ShippingAddress.PostalCode;
                Request[Keys.SCOUNTRY] = ShippingAddress.Country;
            }

            return Request;
        }

        public AddressInfo ShippingAddress { get; set; }
    }
}
