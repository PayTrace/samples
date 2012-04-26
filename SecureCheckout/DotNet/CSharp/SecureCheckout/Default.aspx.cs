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
            // to get an approval amount set: AMOUNT~1.00
            // to get a declined amount set: AMOUNT~1.12
            string parameters = "UN~demo123|PSWD~demo123|TERMS~Y|TRANXTYPE~Sale|";
            parameters += "ORDERID~1234|AMOUNT~1.00|";

            string return_url = @"http://" + Request.Url.Authority;
            
            parameters += "ApproveURL~" + return_url + "/Approved.aspx|";

            parameters += "DeclineURL~" + return_url + "/Declined.aspx|";

            SendValidationRequest(parameters);
        }

        private void SendValidationRequest(string Parameters)
        {
            string parameter_list ="PARMLIST=";

            parameter_list = parameter_list +  Parameters; 
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(parameter_list);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://paytrace.com/api/validate.pay");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytes.Length;
            
            // send validation request
            Stream str = request.GetRequestStream();
            str.Write(bytes, 0, bytes.Length);
            str.Flush();
            str.Close();

            // get response and parse
            WebResponse response = request.GetResponse();
            Stream rsp_stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(rsp_stream);

            // read the response string
            string strResponse = reader.ReadToEnd();
            ParseResponse(strResponse);
            UpdateResponse(strResponse);
        }

  
        private void UpdateResponse(string strResponse)
        {
            lblResponce.Text = strResponse;
            lblOrderID.Text =   (string)Session["OrderID"];
            lblAUTHKEY.Text = (string)Session["AuthKey"];
            string url = "https://paytrace.com/api/checkout.pay?parmList=orderID~{0}|AuthKey~{1}";
            
            lnkSendToBilling.NavigateUrl = string.Format(url, lblOrderID.Text, lblAUTHKEY.Text);
            pnl_response.Visible = true;
        }

        private void ParseResponse(string strResponse)
        {
            // if we have errors if so output to ui
            if (!strResponse.Contains("ERROR"))
            {
                lblResponce.Text = strResponse;
                string[] parameters = strResponse.Split('|');
                string OrderID = parameters[0].Split('~')[1];
                string AUTHKEY = parameters[1].Split('~')[1];
                Session["OrderID"] = OrderID;
                Session["AuthKey"] = AUTHKEY;
            }
            else
            {
                lblResponce.Text = strResponse;
            }
        }
    }

}
