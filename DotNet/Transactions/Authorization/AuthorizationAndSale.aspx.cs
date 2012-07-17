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
    public partial class AuthorizationAndSale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void OnbtnSubmitClick(object sender, EventArgs e)
        {
            TransactionRequest request = new TransactionRequest("demo123", "demo123");

            // add credit card info
            request.CreditCard.Number = "4111111111111111";
            request.CreditCard.ExpirationMonth = 1;
            request.CreditCard.ExpirationYear = 2015;


            // add billing info
            request.BillingAddress.Street = "2134 happy lane";
            request.BillingAddress.City = "Seattle";
            request.BillingAddress.Region = "WA";
            request.BillingAddress.PostalCode = "98136";
            request.BillingAddress.Country = "USA";


            // authorize request
            TransactionResponse transactionresponse = request.Authorize(1.00m);

            // view response properties
            ResponseList1.Title = "Authorized  Response";
            ResponseList1.BindData(transactionresponse.UnderlyingResponse);

            // request to process the Authorized transaction
            Response response = request.Process(transactionresponse.TransactionID);
            
            //view sales response properties
            ResponseList2.Title = "Sales Response";
            ResponseList2.BindData(response);
        }

    }
}