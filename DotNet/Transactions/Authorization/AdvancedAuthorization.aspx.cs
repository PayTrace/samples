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
            
            TransactionRequest request = new TransactionRequest("demo123","demo123");

            // add credit card info
            request.CC.Number = "4111111111111111";
            request.CC.ExpirationMonth = 1;
            request.CC.ExpirationYear = 2015;


            // add billing info
            request.BillingAddress.Street = "2134 happy lane";
            request.BillingAddress.City = "Seattle";
            request.BillingAddress.Region = "WA";
            request.BillingAddress.PostalCode = "98136";
            request.BillingAddress.Country = "USA";
            
            
            //To DO build TransactionResponse 

            Response response = request.Authorize(1.00m);
            
            // change to properties 
            //MyResponseList.BindData(response);


        }
    }
}