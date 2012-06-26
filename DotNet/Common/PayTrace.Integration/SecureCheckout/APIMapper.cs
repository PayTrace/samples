using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PayTrace.Integration.SecureCheckout
{
    
    internal class APIMapper
    {
        public readonly Dictionary<string, string> PropertyToAPIMapings;

        public APIMapper()
        {
            PropertyToAPIMapings = GetMappings();
        }

        private Dictionary<string, string> GetMappings()
        {
            throw new NotImplementedException();
            //PropertyToAPIMapings = new Dictionary<string, string>();
            //PropertyToAPIMapings.Add()
        }
        

    }

    

      
}
