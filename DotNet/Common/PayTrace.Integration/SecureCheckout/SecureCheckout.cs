using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.Interfaces;
using PayTrace.Integration.API;

namespace PayTrace.Integration.SecureCheckout
{
    public class SecureCheckout
    {
        public readonly AuthenticationRequest Authorization;
        public readonly IAPIClient Client;
        bool _hasErrors = false;

        public bool HasErrors { get { return _hasErrors;  } }
        public SecureCheckout(AuthenticationRequest authorization, IAPIClient client)
        {
            Authorization = authorization;
            Client = client;
        }

        public List<ResponseError> Errors { get; set; }

        private OrderValidation _orderValidation = null;

        public void CreateOrder(
            decimal amount,
            string orderId,
            Uri returnUrl = null,
            Uri approvalUrl = null,
            Uri declineUrl = null,
            bool forceEmail = false,
            bool forceAddress = false,
            bool forceCSC = false)
        {
            _orderValidation = new OrderValidation(Authorization);
            _orderValidation.ApprovalURL = approvalUrl.ToString();
            _orderValidation.DeclineURL = declineUrl.ToString();
            _orderValidation.ReturnURL = returnUrl.ToString();
            _orderValidation.OrderID = orderId;
            _orderValidation.ForceAddress = forceAddress;
            _orderValidation.ForceCSC = forceCSC;
            _orderValidation.ForceEmail = forceEmail;

            ValidationResponse response = ValidateOrder(_orderValidation);

          

            if (response.HasErrors)
            {
                _hasErrors = response.HasErrors;
                Errors = new List<ResponseError>();
                Errors.Add(response.ResponseError);
            }
            else
            {
                
            }
        }

        private ValidationResponse ValidateOrder(OrderValidation orderValidation)
        {
            var Response = new ValidationResponse(Client.SendRequest(orderValidation));
           
            return Response;
        }

       

        
    }
}
