using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.API
{
    internal class Formatter
    {
        public static string BuildAPICall(Dictionary<string,string> api_dictionary)
        {
            StringBuilder api_builder = new StringBuilder();
            string formatString = "{0}~{1}|";
            foreach (var item in api_dictionary)
            {
                api_builder.Append(string.Format(formatString, item.Key, item.Value));
            }
            return api_builder.ToString();
        }

        
    }
}
