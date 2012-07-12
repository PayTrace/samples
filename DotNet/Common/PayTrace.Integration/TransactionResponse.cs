using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;

namespace PayTrace.Integration
{
    public class TransactionResponse
    {

       
        protected Response _response = null;
 
        public TransactionResponse(Response response)
        {
            _response = response;

            if (response.HasError)
            {
                BuildBindErrorInfo(response);
                return; 
            }

            BuildTransactionResponse(response.ResponseValues);
        }

        private void BuildBindErrorInfo(Response response)
        {
            this.HasError = response.HasError;
            this.Error = response.Error;
        }

        private void BuildTransactionResponse(Dictionary<string, string> dictionary)
        {
            ResponseMessage = dictionary[Keys.RESPONSE];
            TransactionID = dictionary[Keys.TRANSACTIONID];
            AppCode = dictionary[Keys.APPCODE];
            AppMessage = dictionary[Keys.APPMSG];
            AVSResponce = dictionary[Keys.AVSRESPONSE];
            CSCResponse = dictionary[Keys.CSCRESPONSE];
        }

        public bool HasError { get; set; }

        public ResponseError Error { get; set; }

        public string CSCResponse { get; set; }

        public string ResponseMessage { get; set; }
        public string TransactionID { get; set; }
        public string AppCode { get; set; }
        public string AppMessage { get; set; }
        public string AVSResponce { get; set; }

    }
}
