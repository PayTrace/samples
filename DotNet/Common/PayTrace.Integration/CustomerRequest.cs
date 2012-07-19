using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.API;
using PayTrace.Integration.RequestBuilders;

namespace PayTrace.Integration
{
    public class CustomerRequest
    {
        public AuthorizationInfo Athorization { get; set; }
        public CustomerInfo Customer { get; set; }
        public AddressInfo BillingAddress { get; set; }
        public AddressInfo ShippingAddress { get; set; }
        public CreditCardInfo CreditCard { get; set; }
        public Uri Destination { get; set; }


        public CustomerRequest(string username, string password)
        {
            this.Destination = Destinations.Default;
            this.Athorization = new AuthorizationInfo(username, password);
            
        }

        private Request AddCustomer(Request request)
        {
            CustomerBuilder customerBuilder = new CustomerBuilder(request);
            customerBuilder.Customer = Customer;
            return customerBuilder.Build();
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
            auth_builder.Authorization = this.Athorization;
            return auth_builder.Build();
        }

        private Request AddCreditCard(Request request)
        {
            CreditCard.Validate();
            CreditCardBuilder creditcard_builder = new CreditCardBuilder(request);
            creditcard_builder.CreditCard = CreditCard;
            return creditcard_builder.Build();
        }

        private Request BuildCustomerRequest()
        {
            var request = new Request();
            request = AddAuthorization(request);
            request = AddCustomer(request);
            request = AddAddressInfo(request);
            request = AddCreditCard(request);
            return request;
        }

        /// <summary>
        /// Create a New Customer
        /// </summary>
        /// <param name="customerID">The ID that will identify the customer</param>
        /// <returns></returns>
        public Response CreateCustomer(string customerID, string customer_password)
        {
            var request = BuildCustomerRequest();
            request[Keys.CUSTID] = customerID;
            request[Keys.CUSTPSWD] = customer_password;
            request[Keys.METHOD] = Methods.CreateCustomer;
            return request.Send();
        }

    }
}
