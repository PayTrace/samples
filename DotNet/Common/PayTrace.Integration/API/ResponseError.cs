using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.API
{
    public class ResponseError
    {
        public readonly int ID;
        public readonly string Message;

        public ResponseError(int id, string message)
        {
            ID = id;
            Message = message;
        }
    }
}
