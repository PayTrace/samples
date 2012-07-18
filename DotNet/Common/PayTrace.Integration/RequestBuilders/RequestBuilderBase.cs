using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;

namespace PayTrace.Integration.RequestBuilders
{
    public abstract class RequestBuilderBase
    {
        protected Request  _request;

        protected RequestBuilderBase(Request request)
        {
            _request = request;
        }

        public abstract Request Build();

    }
}
