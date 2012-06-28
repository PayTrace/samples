using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.Interfaces;

namespace PayTrace.Integration.SecureCheckout
{
    public class OrderValidation :IAPIRequest
    {
        public string ReturnURL { get; set; }
        public string ApprovalURL { get; set; }
        public string DeclineURL { get; set; }
        public bool ForceEmail { get; set; }
        public bool ForceAddress { get; set; }
        public bool ForceCSC { get; set; }
        public string OrderID { get; set; }

        protected  string TransactionType = "Sale";


        public Dictionary<string,string> to_PayTraceAPI()
        {
            throw new NotImplementedException();
        }
    }
}
