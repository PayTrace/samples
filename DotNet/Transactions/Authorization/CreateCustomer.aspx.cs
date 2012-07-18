using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayTrace.Integration;

namespace Authorization
{
    public partial class CreateCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnbtnSubmit(object sender, EventArgs e)
        {
            CustomerRequest customerRequest = new CustomerRequest("demo123", "demo123");
            customerRequest.BillingAddress = GetBillingAddressInfo();
            customerRequest.ShippingAddress = GetShippingAddressInf();

        }

        private AddressInfo GetBillingAddressInfo()
        {
            throw new NotImplementedException();
        }

        private AddressInfo GetShippingAddressInf()
        {
            throw new NotImplementedException();
        }
    }
}