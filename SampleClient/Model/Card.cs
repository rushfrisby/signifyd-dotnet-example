using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClient.Model
{
    class Card
    {
        public string cardHolderName { get; set; }
        public string bin { get; set; }
        public string last4 { get; set; }
        public int expiryMonth { get; set; }
        public int expiryYear { get; set; }
        public string hash { get; set; }
        public BillingAddress billingAddress { get; set;}
    }
    
    class BillingAddress
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
