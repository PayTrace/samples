using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;
namespace PayTrace.Integration.RequestBuilders
{
    public class CustomerBuilder :RequestBuilderBase
    {
        public CustomerInfo Customer { get; set; }
 
        public CustomerBuilder(Request request):base(request){}

        public override Request Build()
        {
            throw new NotImplementedException();
        }
    }
}
