using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Collections;
using System.Reflection;

namespace PayTrace.Integration.API
{
    public class DictionaryBuilder
    {
        public DictionaryBuilder()
        {
        }

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

       

       

        public Dictionary<string, string> ToDictionary()
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
