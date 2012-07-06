using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PayTrace.Integration.API
{
    public class Response 
    {
        public bool HasError { get; set; } 
        public string Raw { get { return response; } }
        public Dictionary<string, string> ResponseValues = new Dictionary<string,string>();
        public ResponseError Error = null; 
        private string response;


        public Response(string response)
        {
            this.response = response;
            
            BuildResponse(response);
        }

        private void BuildResponse(string response)
        {
            if(response.Contains("ERROR~"))
            {
                HasError = true;

                BuildResponseError(response);

                return;
            }

            ResponseValues = Parser.ParseAPIMessage(response);
        }

        
        private void BuildResponseError(string response)
        {
           

            var regex = new Regex(@"~[1-9]*.");
            var match = regex.Match(response);

            string str_id = match.ToString();
            str_id = str_id.Replace("~",string.Empty);
            str_id = str_id.Replace(".",string.Empty);
            
            // get the Error ID from the string.
            int id = Convert.ToInt32(str_id);

            var message = response.Split('~')[1];

            // get the error message from the string.
            message = message.Replace(match.ToString().Replace("~",string.Empty), string.Empty);
            message = message.Replace("|", " ");
            Error = new ResponseError(id, message.Trim());
           
        }

        
    }
}
