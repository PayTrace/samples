using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text;
using System.IO;

namespace SecureCheckout
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStartOrder_OnClick(object sender, EventArgs e)
        {
            //format parameters for request 
            string parameters = "UN~demo123|PSWD~demo123|TERMS~Y|TRANXTYPE~Sale|";
            parameters += "ORDERID~1234|AMOUNT~1.00|";
            SendPayTraceSecureCheckoutRequest(parameters);
        }

        private void SendPayTraceSecureCheckoutRequest(string Parameters)
        {
            string parameter_list ="PARMLIST=";

            parameter_list = parameter_list +  Parameters; 
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(parameter_list);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://paytrace.com/api/validate.pay");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytes.Length;
            Stream str = request.GetRequestStream();
            str.Write(bytes, 0, bytes.Length);
            str.Flush();
            str.Close();

            WebResponse response = request.GetResponse();
            Stream rsp_stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(rsp_stream);

            string strResponse = reader.ReadToEnd();
            AddParametersToSession(strResponse);
            UpdateResponse(strResponse);
        }

        /// <summary>
        /// Show a Panel with parsed parameter data
        /// </summary>
        /// <param name="strResponse"></param>
        private void UpdateResponse(string strResponse)
        {
            lblResponce.Text = strResponse;
            lblOrderID.Text = Session["OrderID"].ToString();
            lblAUTHKEY.Text = Session["AuthKey"].ToString();

            pnl_response.Visible = true;
        }

        private void AddParametersToSession(string strResponse)
        {
            lblResponce.Text = strResponse;
            string[] parameters = strResponse.Split('|');
            string OrderID = parameters[0].Split('~')[1];
            string AUTHKEY = parameters[1].Split('~')[1];
            Session["OrderID"] = OrderID;
            Session["AuthKey"] = AUTHKEY;

            string url = "https://paytrace.com/api/checkout.pay?parmList=orderID~{0}|AuthKey~{1}|";

            lnkSendToBilling.NavigateUrl = string.Format(url,OrderID,AUTHKEY);

        }
    }

}
