using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.Interfaces;
using PayTrace.Integration.API;


namespace PayTrace.Integration.SecureCheckout
{
    public class OrderValidation :IAPIRequest
    {
        public string ReturnURL { get; set; }
        public string ApprovalURL { get; set; }
        public string DeclineURL { get; set; }
        public bool ForceEmail { get; set; }
        public bool ForceAddress { get; set; }
        public bool ForceCSC { get; set; }
        public string OrderID { get; set; }

        protected  string TransactionType = "Sale";


        public Dictionary<string,string> ToAPI()
        {
            DictionaryBuilder Builder = new DictionaryBuilder(SecureCheckoutMappings.ResourceManager);

            var propertiesList = this.GetType().GetProperties();
          
            foreach (var propertyinfo in propertiesList)
            {
                var value = propertyinfo.GetValue(this, null);
                
                if(value == null)
                {
                    continue;
                }
                
                if (value is bool)
                {
                    Builder.Add(propertyinfo.Name,(bool)value);
                }
                else
                {
                    Builder.Add(propertyinfo.Name, value.ToString());
                }
            }
            
            return Builder.ToDictionary();
        }

        private object get_type(System.Reflection.PropertyInfo property)
        {
            if (property.PropertyType == typeof(string))
            {
                return string.Empty;
            }
            else
            {

                return Activator.CreateInstance(property.PropertyType);
            }

            

        }

       
    }
}
