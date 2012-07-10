using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration
{
    public class CreditCardValidationException : System.Exception
    {
        public CreditCardValidationException(string message) : base(message) { }
        public CreditCardValidationException(string message, Exception innerexcpetion) : base(message, innerexcpetion) { }
        public CreditCardValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
