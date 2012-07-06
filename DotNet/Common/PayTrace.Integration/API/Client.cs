using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;

using PayTrace.Integration.Interfaces;
using System.Net;
namespace PayTrace.Integration.API
{
    class Client : IClient
    {

        #region IAPIClient Members

        public Response SendRequest(IRequest request)
        {
            string parameters = Formatter.BuildAPICall(request.ToAPI());

            Response response = new Response(SendRequest(parameters, request.Destination));

            return response;
        }

        private string SendRequest(string parameters, Uri destination)
        {
            string parameter_list = "PARMLIST=";

            parameter_list += parameters;
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(parameter_list);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destination);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytes.Length;

            // send request
            using (Stream str = request.GetRequestStream())
            { 
                str.Write(bytes, 0, bytes.Length);
                str.Flush();
                str.Close();
            }

            // get response and parse
            string response = string.Empty;
            WebResponse webResponse = request.GetResponse();
            using (Stream rsp_stream = webResponse.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(rsp_stream))
                {
                    // read the response string
                    response = reader.ReadToEnd();
                }

            }

            return response;
          
        }

        #endregion
    }
}
