using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.API
{
    public static class TransactionTypes
    {
        public static string Authorization { get { return "Authorization"; } }
        public static string Void { get { return "Void"; } }
        public static string Sale { get { return "Sale"; } }
    }
}
