using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayTrace.Integration.Interfaces;
namespace PayTrace.Integration
{
    
    public class AddressInfo
    {
        public string FullName { get; set; }
        public string Street { get; set; }
        public string Street2 {get;set;}
        public string Region {get;set;}
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string County { get; set; }

        public AddressInfo(string fullname = null, string street=null,string street2 = null, string city =null, string region= null,string postalcode = null, string country = null, string county = null  )
        {
            FullName = fullname;
            Street = street;
            Street2 = street2;
            City = city;
            Region = region;
            PostalCode = postalcode;
            Country = country;
            County = county;
        }

        public AddressInfo() { }




     
    }

    
}
