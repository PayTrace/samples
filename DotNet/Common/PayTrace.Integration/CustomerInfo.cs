using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration
{
    public class CustomerInfo
    {
        private string _customerid;
        public string CustomerID { get { return _customerid; } }

        public CustomerInfo() { }

        public CustomerInfo(string customerID)
        {
            _customerid = customerID;
        }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string CheckingAccount { get; set; }
        public string RoutingNumber { get; set; }
    }
}
