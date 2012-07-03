using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;

namespace PayTrace.Integration.SecureCheckout
{
    class ValidationResponse
    {
        public readonly string Authkey;
        public readonly string OrderID;
        public readonly bool HasErrors;
        public readonly ResponseError ResponseError;

        public  ValidationResponse(Response response)
        {
            if (HasErrors)
            {
                this.HasErrors = response.HasError;
                ResponseError = response.Error;

                return;
            }

            Authkey = response.ResponseValues["AUTHKEY"];
            OrderID = response.ResponseValues["OrderID"];


        }

       
    }
}
