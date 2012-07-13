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
    public class Request :  IRequest 
    {
        public Uri Destination{get;set;}
        
        public Request(Uri destination)
        {
            Destination = destination;
        }

        public Request() { }

        public string this[string key]
        {
            get 
            {
                if (APIAttributeValues.ContainsKey(key))
                {
                    return APIAttributeValues[key];
                }

                return null;

            }

            set
            {
                if (value == null)
                {
                    APIAttributeValues.Remove(key);
                }
                else
                {
                    APIAttributeValues[key] = value;
                }
            }
        }

        protected Dictionary<string, string> APIAttributeValues = new Dictionary<string, string>();

        public Dictionary<string, string> GetAPIDictionary()
        {
            return APIAttributeValues.Select(x => new { x.Key, x.Value }).ToDictionary(x => x.Key, x => x.Value);
        }
        
        public void Add(string attribute, string value)
        {
            APIAttributeValues[attribute] = value;
        }

        public void Add(string attribute, bool value)
        {
            if (value)
            {
                APIAttributeValues[attribute] = "Y";
            }
            else
            {
                APIAttributeValues.Remove(attribute);
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
                APIAttributeValues[item.Key] = item.Value;
            }
        }

        public Response Send()
        {
            Client client = new Client();
            return client.SendRequest(this);
        }


       

        public void AddShippingAddress(AddressInfo address)
        {
            APIAttributeValues.Add(Keys.SADDRESS, address.Street);
            APIAttributeValues.Add(Keys.SADDRESS2, address.Street2);
            APIAttributeValues.Add(Keys.SCITY, address.City);
            APIAttributeValues.Add(Keys.SSTATE, address.Region);
            APIAttributeValues.Add(Keys.SZIP, address.PostalCode);
            APIAttributeValues.Add(Keys.SCOUNTY, address.County);
            APIAttributeValues.Add(Keys.SCOUNTRY, address.Country);
        }
    }
}
