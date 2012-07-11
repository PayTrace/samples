using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;

namespace PayTrace.Integration
{
    public class TransactionResponse
    {
        public string TransactionID { get; set; }
        public string AppCode { get; set; }
        public string Message {get;set;}
        
        public TransactionResponse(Response response)
        {
            Response
        }
    }
}
