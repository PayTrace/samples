using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.Interfaces
{
    public interface IRequest
    {
        Uri Destination { get; set; }
        void Add(string attribute, string value);
        void Add(string attribute, bool value);
        Dictionary<string,string> ToAPI();
        
   } 
}
