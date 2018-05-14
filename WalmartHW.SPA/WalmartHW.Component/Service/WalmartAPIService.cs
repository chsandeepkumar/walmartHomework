using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WalmartHW.Component.Contracts;
using WalmartHW.Component.Helper;
using WalmartHW.Component.Model;
using System.Linq;
namespace WalmartHW.Component.Service
{
    public class WalmartAPIService : IWalmartAPI
    {
       public async Task<List<Product>> SearchProductAsync(string SearchItem)
        {
            RootObject searchDetails = null;
            HttpResponseMessage response = await new HttpClient().GetAsync(WalmartAPI.SerachAPIRequest(SearchItem));

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                searchDetails = JsonConvert.DeserializeObject<RootObject>(result);
            }
            return WalmartSearchQuery.ExtractRequiredProductDetails(searchDetails).ToList();

        }
        public async Task<Product> GetProductDetailsAsync(int ItemId)
        {
            RootObject searchDetails = null;
            HttpResponseMessage response = await new HttpClient().GetAsync(WalmartAPI.ProductLookupAPI(ItemId));

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                searchDetails = JsonConvert.DeserializeObject<RootObject>(result);
            }
            return WalmartSearchQuery.ExtractRequiredProductDetails(searchDetails, ItemId);
        }
    }
}
