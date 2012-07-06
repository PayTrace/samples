using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Collections;
using System.Reflection;
using PayTrace.Integration.Interfaces;

namespace PayTrace.Integration.API
{
    public class APIRequestBuilder : IAPIRequest
    {
        public Uri Destination{get;set;}
        
        public APIRequestBuilder(Uri destination)
        {
            Destination = destination;
        }

        public APIRequestBuilder() { }


        private Dictionary<string, string> APIAttributeValues = new Dictionary<string, string>();

        public void Add(string attribute, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                APIAttributeValues.Add(attribute, value);
            }
        }

        public void Add(string attribute, bool value)
        {
            if(value)
            {
                APIAttributeValues.Add(attribute, "Y");
            }
        }





        public Dictionary<string, string> ToAPI()
        {
            return APIAttributeValues;
        }

        public void AppendDictionary(Dictionary<string, string> dictionary)
        {
            foreach (var item in dictionary)
            {
                APIAttributeValues.Add(item.Key, item.Value);
            }
        }



       
    }
}
