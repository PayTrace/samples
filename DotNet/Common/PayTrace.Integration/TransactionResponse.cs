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
            ResponseMessage = GetAPIValue(Keys.RESPONSE);
            TransactionID = GetAPIValue(Keys.TRANSACTIONID);
            ApprovalCode = GetAPIValue(Keys.APPCODE);
            ApprovalMessage =  GetAPIValue(Keys.APPMSG);
            AVSResponce =  GetAPIValue(Keys.AVSRESPONSE);
            CSCResponse =  GetAPIValue(Keys.CSCRESPONSE);
        }

        private string GetAPIValue(string key)
        {
          
            if(_response  == null) 
                return null;

            var responseValues = _response.ResponseValues;
        
            if (responseValues.ContainsKey(key))
                return responseValues[key];

            return "";
        }

        public bool HasError { get; set; }
        public ResponseError Error { get; set; }
        public string CSCResponse { get; set; }
        public string ResponseMessage { get; set; }
        public string TransactionID { get; set; }
        public string ApprovalCode { get; set; }
        public string ApprovalMessage { get; set; }
        public string AVSResponce { get; set; }
        public  Response UnderlyingResponse { get { return _response; } }

    }
    
}
