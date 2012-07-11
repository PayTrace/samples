using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayTrace.Integration;
using PayTrace.Integration.API;

namespace Authorization
{
    public partial class AdvancedAuthorization : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnbtnSubmitClick(object sender, EventArgs e)
        {

            PayTrace.Integration.Authorization authorization = new PayTrace.Integration.Authorization("demo123","demo123");

            AddressInfo billing_address = new AddressInfo("2134 happy lane", city: "Seattle", region: "WA", postalcode: "98136", country: "USA");
            
            DateTime? experation_date = null;
            experation_date = new DateTime(2015, 1, 1);
            
            CreditCard cc = new CreditCard(cc: "4111111111111111", amount: "1.00", billing_address: billing_address, experation_date: experation_date, csc: "999");

            TransactionRequest request = new TransactionRequest(Destinations.Default);

            request.AddAuthorizationInfo(authorization);
            request.AddCreditCardInfo(cc);

            Response response = request.SendAuthorizationRequest();

            MyResponseList.BindData(response);


        }
    }
}