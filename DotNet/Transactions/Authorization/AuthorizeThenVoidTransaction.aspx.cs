using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayTrace.Integration;

namespace Authorization
{
    public partial class AuthorizeThenVoidTransaction : System.Web.UI.Page
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


            //// add billing info
            //request.BillingAddress.Street = "2134 happy lane";
            //request.BillingAddress.City = "Seattle";
            //request.BillingAddress.Region = "WA";
            //request.BillingAddress.PostalCode = "98136";
            //request.BillingAddress.Country = "USA";
            

            // Display Response Data
            TransactionResponse response = request.Authorize(1.00m);

            BuildResponseView(response);

        }

        private void BuildResponseView(TransactionResponse response)
        {
            pnlResponse.Visible = true;
            btnVoid.Visible = true;

            if (response.HasError)
            {
                lblResponse.Text = response.Error.Message;
                btnVoid.Visible = false;
            }

            lblResponse.Text = response.ResponseMessage;
            lblTransactionID.Text = response.TransactionID;
            lblAppCode.Text = response.AppCode;
            lblAppMessage.Text = response.AppMessage;
            lblAVSResponse.Text = response.AVSResponce;
            lblCSCResponse.Text = response.CSCResponse;
        }

        protected void OnbtnVoidClick(object source, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTransactionID.Text))
            {
                return;
            }

            TransactionRequest request = new TransactionRequest("demo123","demo123");
            BuildVoidResponseView( request.Void(lblTransactionID.Text));
        }

        private void BuildVoidResponseView(TransactionResponse response)
        {
            VoidResponseList.BindData(response.UnderlyingResponse);
        }
    }
}