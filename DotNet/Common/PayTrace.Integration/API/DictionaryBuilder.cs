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

        private ResourceManager Manager;
        public DictionaryBuilder(ResourceManager resourceManager)
        {
            Manager = resourceManager;
        }

        private Dictionary<string, string> APIAttributeValues = new Dictionary<string, string>();

        public void Add(string property, string value)
        {
            APIAttributeValues.Add(Manager.GetString(property), value);
        }

       

        public Dictionary<string, string> ToDictionary()
        {
            return APIAttributeValues;
        }
    }
}
