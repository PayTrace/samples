using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration;
using PayTrace.Integration.API;

namespace PayTrace.Integration.RequestBuilders
{
    internal class AddressBuilder:RequestBuilderBase
    {
        
        public AddressBuilder(API.Request request) : base(request) { }
      
        public AddressInfo BillingAddress { get; set; }

        public override Request Build()
        {
            if (BillingAddress != null)
            {
                _request[Keys.BNAME] = BillingAddress.FullName;
                _request[Keys.BADDRESS] = BillingAddress.Street;
                _request[Keys.BADDRESS2] = BillingAddress.Street2;
                _request[Keys.BCITY] = BillingAddress.City;
                _request[Keys.BSTATE] = BillingAddress.Region;
                _request[Keys.BZIP] = BillingAddress.PostalCode;
                _request[Keys.BCOUNTRY] = BillingAddress.Country;
            }

            if (ShippingAddress != null)
            {
                _request[Keys.SNAME] = ShippingAddress.FullName;
                _request[Keys.SADDRESS] = ShippingAddress.Street;
                _request[Keys.SADDRESS2] = ShippingAddress.Street2;
                _request[Keys.SCITY] = ShippingAddress.City;
                _request[Keys.SSTATE] = ShippingAddress.Region;
                _request[Keys.SZIP] = ShippingAddress.PostalCode;
                _request[Keys.SCOUNTRY] = ShippingAddress.Country;
            }

            return _request;
        }

        public AddressInfo ShippingAddress { get; set; }
    }
}
