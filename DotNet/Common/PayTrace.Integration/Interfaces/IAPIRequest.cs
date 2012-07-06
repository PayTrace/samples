using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.Interfaces
{
    public interface IAPIRequest
    {
        Uri Destination { get; set; }
        Dictionary<string,string> ToAPI();
        
    }
}
