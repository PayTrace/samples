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
    public partial class AdjustingTransactionAmount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnCreateAuthorization_Click(object sender, EventArgs e)
        {

            TransactionRequest request = new TransactionRequest("demo123", "demo123");

            // add credit card info
            request.CreditCard.Number = "4111111111111111";
            request.CreditCard.ExpirationMonth = 1;
            request.CreditCard.ExpirationYear = 2015;

            // authorize request
            TransactionResponse transactionresponse = request.Authorize(100.00m);

            // view response properties
            ResponseList1.Title = "Authorized  Response";
            ResponseList1.BindData(transactionresponse.UnderlyingResponse);

            this.Session[Keys.TRANXID] = transactionresponse.TransactionID;
            lblTransactionID.Text = transactionresponse.TransactionID;
            PanelShowAdjustment.Visible = true;


        }

        protected void OnAdjustTransactionAmount(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbSetAmount.Text))
            {
                return;
            }

            TransactionRequest request = new TransactionRequest("demo123", "demo123");
            decimal amount = Decimal.Parse(tbChangeAmount.Text);
            TransactionResponse response = request.AdjustTransactionAmount(this.Session[Keys.TRANXID].ToString(), amount);
            ResponseList1.Visible = true;
            ResponseList2.Visible = true;
            ResponseList2.Title = "Adjustment Response Values";
            ResponseList2.BindData(response.UnderlyingResponse);
        }

    }
}