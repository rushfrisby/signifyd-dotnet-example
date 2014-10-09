using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClient.Model
{
    class Seller
    {
        public string name { get; set; }
        public string domain { get; set; }
        public ShipFromAddress shipFromAddress { get; set; }
        public CorporateAddress corporateAddress { get; set; }
    }
    
    class ShipFromAddress
    {
        public string streetAddress { get; set; }
        public string unit { get; set; }
        public string city { get; set; }
        public string provinceCode { get; set; }
        public string postalCode { get; set; }
        public string countryCode { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
    
    class CorporateAddress
    {
        public string streetAddress { get; set; }
        public string unit { get; set; }
        public string city { get; set; }
        public string provinceCode { get; set; }
        public string postalCode { get; set; }
        public string countryCode { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }  
}
