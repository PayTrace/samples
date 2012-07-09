using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayTrace.Integration.API;
using PayTrace.Integration;
namespace Authorization
{
    public partial class BasicAuthorization : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnbtnSubmitClick(object sender, EventArgs e)
        {
            Request request = new Request(Destinations.Default);
            request.Add(Keys.UN, "demo123");
            request.Add(Keys.PSWD, "demo123");
            request.Add(Keys.TERMS, "Y");
            request.Add(Keys.TRANXTYPE, TransactionTypes.Authorization);
            request.Add(Keys.METHOD, Methods.ProcessTransaction);
            request.Add(Keys.AMOUNT, "0.43");
            request.Add(Keys.CC, "4111111111111111");
            request.Add(Keys.CSC, "999");
            request.Add(Keys.EXPMNTH, "01");
            request.Add(Keys.EXPYR, "2012");

            Response response = request.Send();

            ResponseList.BindData(response);

            
        }
    }
}