using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClient.Model
{
    class PostBody 
    {
        public Purchase purchase { get;set ; }
        public Recipient recipient { get;set ; }
        public Card card { get;set; }
        public UserAccount userAccount { get;set; }
        public Seller seller { get;set; }
    }
}
