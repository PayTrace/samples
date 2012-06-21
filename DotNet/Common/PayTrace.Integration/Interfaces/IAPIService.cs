using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.Interfaces
{
    interface IAPIService
    {
        Response SendRequest(string paramters);
    }
}
