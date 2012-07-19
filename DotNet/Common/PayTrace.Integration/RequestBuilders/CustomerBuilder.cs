using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;
namespace PayTrace.Integration.RequestBuilders
{
    public class CustomerBuilder :RequestBuilderBase
    {
        public CustomerInfo Customer { get; set; }
 
        public CustomerBuilder(Request request):base(request){}

        public override Request Build()
        {
            _request[Keys.FAX] = Customer.Fax;
            _request[Keys.PHONE] = Customer.Phone;
            _request[Keys.EMAIL] = Customer.Email;
            _request[Keys.DDA] = Customer.CheckingAccount;
            _request[Keys.TR] = Customer.RoutingNumber;

            return _request;
        }
    }
}
