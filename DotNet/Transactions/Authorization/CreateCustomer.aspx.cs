using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayTrace.Integration;

namespace Authorization
{
    public partial class CreateCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnbtnSubmit(object sender, EventArgs e)
        {
            CustomerRequest customerRequest = new CustomerRequest("demo123", "demo123");
            customerRequest.Customer = GetCustomerInfo();
            customerRequest.BillingAddress = GetBillingAddressInfo();
            customerRequest.ShippingAddress = GetShippingAddressInf();
            customerRequest.CreditCard = GetCreditCardInfo();

            var response = customerRequest.CreateCustomer(tbCustomerUserName.Text, tbPassword.Text);

        }

        private CreditCardInfo GetCreditCardInfo()
        {
            CreditCardInfo CreditCard = new CreditCardInfo();
            CreditCard.Number = CreditCard.Number;

            if (!string.IsNullOrWhiteSpace(tbExpirMonth.Text))
            {
                int expirmonth;
                if (Int32.TryParse(tbExpirMonth.Text, out expirmonth))
                {
                    CreditCard.ExpirationMonth = expirmonth;
                }
            }
            
            if (!string.IsNullOrWhiteSpace(tbExpirMonth.Text))
            {
                int expiryear;
                if (Int32.TryParse(tbExpirYear.Text, out expiryear))
                {
                    CreditCard.ExpirationYear = expiryear;
                }
            }

            return CreditCard;
        }

        private CustomerInfo GetCustomerInfo()
        {
            CustomerInfo Customer = new CustomerInfo();
            Customer.Email = tbEmail.Text;
            Customer.Fax = tbFax.Text;
            Customer.Phone = tbPhone.Text;

            return Customer;
        }



        private AddressInfo GetBillingAddressInfo()
        {
            AddressInfo BillingAddress = new AddressInfo();
            BillingAddress.FullName = tbBillingFullName.Text;
            BillingAddress.Street = tbBillingStreet.Text;
            BillingAddress.Street2 = tbBillingStreet2.Text;
            BillingAddress.City = tbBillingCity.Text;
            BillingAddress.Region = tbBillingRegion.Text;
            BillingAddress.County = TbBillingCountry.Text;

            return BillingAddress;
           
        }

        private AddressInfo GetShippingAddressInf()
        {
            AddressInfo ShippingAddress = new AddressInfo();
            ShippingAddress.FullName = tbShippingFullName.Text;
            ShippingAddress.Street = tbShippingStreet.Text;
            ShippingAddress.Street2 = tbShippingStreet2.Text;
            ShippingAddress.City = tbShippingCity.Text;
            ShippingAddress.Region = tbShippingRegion.Text;
            ShippingAddress.County = tbShippingCountry.Text;

            return ShippingAddress;
        }
    }
}