using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration
{
    public class Response
    {
        public string Raw { get; set; }
        public Dictionary<string, string> ResponseValues = new Dictionary<string,string>();
        private string response;


        public Response(string response)
        {
            this.response = response;
            ResponseValues = APIParser.ParseAPIMessage(response);
        }
    }
}
