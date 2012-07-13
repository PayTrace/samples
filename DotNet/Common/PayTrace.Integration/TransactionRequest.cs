using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;

namespace PayTrace.Integration
{
    public class TransactionRequest
    {
        public AddressInfo BillingAddress = new AddressInfo();
        public AddressInfo ShippingAddress = new AddressInfo();
        protected Authorization Auth = null;
        public Uri Destination { get; set; }
        public CreditCard CC = new CreditCard();

        public TransactionRequest(Uri destination) 
        {
            Destination = destination;
        }

        public TransactionRequest(string username, string password) 
        {
            Destination = Destinations.Default;
            AddAuthorizationInfo(username, password);
        }

        public void AddAuthorizationInfo(string username, string password)
        {
            Auth = new Authorization(username, password);
        }
        
        internal Request BuildAuthorizationRequest()
        {
            var request = new Request(Destination);
            CC.Validate();

            request.Add(Keys.CC, CC.Number);
            request.Add(Keys.EXPMNTH, CC.ExpirationMonth.ToString());
            request.Add(Keys.EXPYR, CC.ExpirationYear.ToString());
            request.Add(Keys.CSC, CC.CSC);
            
            if (BillingAddress != null)
            {
                request.Add(Keys.BADDRESS, BillingAddress.Street);
                request.Add(Keys.BADDRESS2, BillingAddress.Street2);
                request.Add(Keys.BCITY, BillingAddress.City);
                request.Add(Keys.BSTATE, BillingAddress.Region);
                request.Add(Keys.BZIP, BillingAddress.PostalCode);
                request.Add(Keys.BCOUNTRY, BillingAddress.Country);
            }

            request = AddAuthorization(request);

            return request;
        }

        private Request AddAuthorization(Request request)
        {
            request[Keys.UN] = Auth.UserName;
            request[Keys.PSWD] =  Auth.Password.ToString();
            request[Keys.TERMS] = "Y";

            return request;
        }


        /// <summary>
        /// Request to authorize a credit card transaction.
        /// </summary>
        /// <param name="amount">amount of the transaction</param>
        /// <returns></returns>
        public TransactionResponse Authorize(decimal amount)
        {
            Request request = BuildAuthorizationRequest();

            request[Keys.AMOUNT] = amount.ToString();
            request[Keys.TRANXTYPE] = TransactionTypes.Authorization;
            request[Keys.METHOD] = "ProcessTranx";
            return new TransactionResponse(request.Send());
        }

        /// <summary>
        /// Request to void a transaction authorization. 
        /// </summary>
        /// <param name="transactionID">The ID of the transaction to void</param>
        /// <returns></returns>
        public TransactionResponse Void(string transactionID)
        {
            var request = new Request(Destination);
            request = AddAuthorization(request);

            request[Keys.TRANXID] =  transactionID;
            request[Keys.TRANXTYPE] = TransactionTypes.Void;
            request[Keys.METHOD] = "ProcessTranx";
            return new TransactionResponse(request.Send());
        }

        /// <summary>
        /// Request to Process a sales by transaction ID.
        /// </summary>
        /// <param name="transactionID"></param>
        /// <returns></returns>
        public Response Process(string transactionID)
        {
            Request request = BuildAuthorizationRequest();

            request[Keys.TRANXID] = transactionID;
            request[Keys.TRANXTYPE] = TransactionTypes.Sale;
            request[Keys.METHOD] = "ProcessTranx";
            return request.Send();
        }
    }
}
