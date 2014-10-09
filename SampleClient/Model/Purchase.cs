using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClient.Model
{
    class Purchase
    {
        public string browserIpAddress { get; set; }
        public string orderId { get; set; }
        public string createdAt { get; set; }
        public string paymentGateway { get; set; }
        public string currency { get; set; }
        public string avsResponseCode { get; set; }
        public string cvvResponseCode { get; set; }
        public string orderChannel { get; set; }
        public string receivedBy { get; set; }
        public double totalPrice { get; set; }
        public List<Product> products { get; set; }
        public List<Shipment> shipments { get; set; }
    }
    
    class Product
    {
        public string itemId { get; set; }
        public string itemName { get; set; }
        public string itemUrl { get; set; }
        public string itemImage { get; set; }
        public int itemQuantity { get; set; }
        public double itemPrice { get; set; }
        public int itemWeight { get; set; }
    }
    
    class Shipment
    {
        public string shipper { get; set; }
        public string shippingMethod { get; set; }
        public double shippingPrice { get; set; }
        public string trackingNumber { get; set; }
    }
}
