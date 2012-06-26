using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.API
{
    internal class APIParser
    {
        public static Dictionary<string, string> ParseAPIMessage(string raw_response)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            string[] parameters = raw_response.Split('|');

            foreach (var name_value in parameters)
            {
                var pair = name_value.Split('~');
                pairs.Add(pair[0], pair[1]);
            }

            return pairs;
        }

    }
}
