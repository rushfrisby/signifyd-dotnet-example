using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClient.Model
{
    class UserAccount
    {
        public string emailAddress { get; set; }
        public string username { get; set; }
        public string phone { get; set; }
        public string createdDate { get; set; }
        public string accountNumber { get; set; }
        public string lastOrderId { get; set; }
        public int aggregateOrderCount { get; set; }
        public double aggregateOrderDollars { get; set; }
        public string lastUpdateDate { get; set; }  
    }
}
