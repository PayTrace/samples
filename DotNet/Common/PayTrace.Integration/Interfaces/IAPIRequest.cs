using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.Interfaces
{
    public interface IAPIRequest
    {
        Dictionary<string,string> to_PayTraceAPI();
    }
}
