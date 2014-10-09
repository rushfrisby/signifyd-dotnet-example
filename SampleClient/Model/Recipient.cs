using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClient.Model
{
    class Recipient
    {
        public string fullName { get; set; }
        public string confirmationEmail { get; set; }
        public string confirmationPhone { get; set; }
        public string organization { get; set; }
        public DeliveryAddress deliveryAddress { get; set; }
        
    }
    
    class DeliveryAddress
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
