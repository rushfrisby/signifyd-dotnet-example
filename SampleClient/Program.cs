using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using SampleClient.Model;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.Configuration;

namespace SampleClient
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Comment which ever Method you need to run if it is Get or Post
            GetAsync().Wait();
           //PostAsync().Wait();

        }

        /// <summary>
        /// Creates a Client Instance for the given URI and APIKey
        /// </summary>
        public static HttpClient createInstance(string uri, string apiKey)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(apiKey)));
            client.BaseAddress = new Uri(uri);
            return client;

        }

        /// <summary>
        /// This gets theCase Info depends on the uri being constructed
        /// </summary>
        static async Task GetAsync()
        {
            string uri = ConfigurationManager.AppSettings["URI"] ;
            string apiKey = ConfigurationManager.AppSettings["APIKEY"];
            using (var client = createInstance(uri, apiKey))
            {
                var response = await client.GetAsync("cases/2953786");
                if (response.IsSuccessStatusCode)
                {
                    var responseText = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseText);

                }
                else
                {
                    Console.WriteLine("Request failed" + response.StatusCode);
                }
            }
            Console.ReadLine();
        }

        /// <summary>
        /// This posts depends on the uri being constructed and the body sent to the REST
        /// </summary>
        static async Task PostAsync()
        {
            //Building a POST BODY to pass it to the request 
            var postBody = new PostBody();
            var purchase = new Purchase();
            purchase.browserIpAddress = "192.168.1.1";
            purchase.orderId = "4fj58as";
            purchase.createdAt = "2013-01-18T17:54:31-05:00";
            purchase.paymentGateway = "stripe";
            purchase.currency = "USD";
            purchase.avsResponseCode = "Y";
            purchase.cvvResponseCode = "M";
            purchase.orderChannel = "PHONE";
            purchase.receivedBy = "John Doe";
            purchase.totalPrice = 74.99;
            var products = new List<Product>();
            products.Add(new Product
            {
                itemId = "1",
                itemName = "Sparkly sandals",
                itemUrl = "http://mydomain.com/sparkly-sandals",
                itemImage = "http://mydomain.com/images/sparkly-sandals.jpeg",
                itemQuantity = 1,
                itemPrice = 49.99,
                itemWeight = 5
            });
            products.Add(new Product
            {
                itemId = "2",
                itemName = "Summer tank top",
                itemUrl = "http://mydomain.com/summer-tank",
                itemImage = "http://mydomain.com/images/summer-tank.jpeg",
                itemQuantity = 1,
                itemPrice = 19.99,
                itemWeight = 2
            });
            purchase.products = products;
            var shipments = new List<Shipment>();
            shipments.Add(new Shipment { 
                shipper= "UPS",        		
                shippingMethod= "ground",
                shippingPrice= 10.0,
                trackingNumber= "3A4U569H1572924642"
            });
            shipments.Add(new Shipment
            {
                shipper = "USPS",
                shippingMethod = "international",
                shippingPrice = 20.0,
                trackingNumber = "9201120200855113889012"
            });

            purchase.shipments = shipments;
            postBody.purchase = purchase;

            var body = new JavaScriptSerializer().Serialize(postBody);
            string uri = ConfigurationManager.AppSettings["URI"];
            string apiKey = ConfigurationManager.AppSettings["APIKEY"];
            using (var client = createInstance(uri, apiKey))
            {
                var response = await client.PostAsync("cases", new StringContent(body, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    var responseText = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseText);

                }
                else
                {
                    Console.WriteLine("Request failed" + response.StatusCode);
                }
            }
            Console.ReadLine();
        }

    }
}
