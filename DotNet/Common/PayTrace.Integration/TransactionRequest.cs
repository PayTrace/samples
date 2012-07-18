using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;
using PayTrace.Integration.RequestBuilders;

namespace PayTrace.Integration
{
    public class TransactionRequest
    {
        public AddressInfo BillingAddress = new AddressInfo();
        public AddressInfo ShippingAddress = new AddressInfo();
        protected AuthorizationInfo Auth = null;
        public Uri Destination { get; set; }
        public CreditCard CreditCard = new CreditCard();

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
            Auth = new AuthorizationInfo(username, password);
        }

         
        
        internal Request BuildBaseSalesRequest()
        {
            var request = new Request(Destination);
            
            request = AddAuthorization(request);
            request = AddCreditCard(request);
            request = AddAddressInfo(request);
            
            return request;
        }

        private Request AddAddressInfo(Request request)
        {
            AddressBuilder address_builder = new AddressBuilder(request);
            address_builder.ShippingAddress = ShippingAddress;
            address_builder.BillingAddress = BillingAddress;
            return address_builder.Build();
        }

        private Request AddAuthorization(Request request)
        {
            AuthorizationBuilder auth_builder = new AuthorizationBuilder(request);
            auth_builder.Authorization = this.Auth;
            return auth_builder.Build();
        }

        private Request AddCreditCard(Request request)
        {
            CreditCard.Validate();
            CreditCardBuilder creditcard_builder = new CreditCardBuilder(request);
            creditcard_builder.CreditCard = CreditCard;
            return creditcard_builder.Build();
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
            request[Keys.METHOD] = Methods.ProcessTransaction;
            return new TransactionResponse(request.Send());
        }

        /// <summary>
        /// Request to Process a sales by transaction ID.
        /// </summary>
        /// <param name="transactionID"></param>
        /// <returns></returns>
        public Response Process(string transactionID)
        {
            Request request = BuildBaseSalesRequest();

            request[Keys.TRANXID] = transactionID;
            request[Keys.TRANXTYPE] = TransactionTypes.Sale;
            request[Keys.METHOD] = Methods.ProcessTransaction;
            return request.Send();
        }

        /// <summary>
        /// Request to authorize a credit card transaction.
        /// </summary>
        /// <param name="amount">amount of the transaction</param>
        /// <returns></returns>
        public TransactionResponse Authorize(decimal amount)
        {
            Request request = BuildBaseSalesRequest();

            request[Keys.AMOUNT] = amount.ToString();
            request[Keys.TRANXTYPE] = TransactionTypes.Authorization;
            request[Keys.METHOD] = Methods.ProcessTransaction;
            return new TransactionResponse(request.Send());
        }
    }
}
