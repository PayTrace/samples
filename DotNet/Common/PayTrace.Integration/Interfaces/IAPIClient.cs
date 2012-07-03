using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;

namespace PayTrace.Integration.Interfaces
{
    public interface IAPIClient
    {
        Response SendRequest(IAPIRequest request);
    }
}
