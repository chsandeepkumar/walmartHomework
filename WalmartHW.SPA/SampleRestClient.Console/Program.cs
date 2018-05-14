using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Linq;

namespace SampleRestClient.Console
{
    class Program
    {
        //static HttpClient client = new HttpClient
        //{
        //    BaseAddress = new Uri("http://api.walmartlabs.com/v1/search?query=ipod&format=json&apiKey=588qtynkrn6pjyeehznu72bh")
        //};
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            var result = await GetProductAsync();

            IEnumerable<Product> productdetails = from item in result.items
                                                                                              select new Product
                                                                                              {
                                                                                                  Name = item.Name,
                                                                                                  Description = item.ShortDescription,
                                                                                                  Price = item.SalePrice,
                                                                                                  ThumbnailImageurl = item.ThumbnailImage
                                                                                              };
            foreach (var item in productdetails)
            {
                //System.Console.WriteLine($"Parent Item ID:{item.ParentItemId}");
                System.Console.WriteLine($"Name:{item.Name}");
                System.Console.WriteLine($"Short Description:{item.Description}");
                System.Console.WriteLine($"Price:{item.Price}");
                System.Console.WriteLine($"ThumnailImage:{item.ThumbnailImageurl}");
            }
            // System.Console.WriteLine(result.items.Count);
            System.Console.ReadLine();
        }
        static async Task<RootObject> GetProductAsync()
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("http://api.walmartlabs.com/v1/search?query=ipod&format=json&apiKey=588qtynkrn6pjyeehznu72bh")
            };
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            // new MediaTypeWithQualityHeaderValue("application/json"));
            string searchItem = "ipod";
            string responceFormat = "json";
            string apiKey = "588qtynkrn6pjyeehznu72bh";
            string pathuri = $"http://api.walmartlabs.com/v1/search?query={searchItem}&format={responceFormat}&apiKey={apiKey}";
            RootObject product = null;
            HttpResponseMessage response = await client.GetAsync(pathuri);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                product = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(result);
            }
            return product;


            //return product;
        }
    }
}
