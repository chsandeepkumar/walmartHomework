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
    public class WalmartApiService : IWalmartApi
    {
       public async Task<List<Product>> SearchProductAsync(string searchItem)
        {
            RootObject searchDetails = null;
            HttpResponseMessage response = await new HttpClient().GetAsync(WalmartRestClient.SearchApiRequest(searchItem));

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                searchDetails = JsonConvert.DeserializeObject<RootObject>(result);
            }
            return WalmartSearchQuery.ExtractRequiredProductDetails(searchDetails).ToList();

        }
        public async Task<Product> GetProductDetailsAsync(int itemId)
        {
            RootObject searchDetails = null;
            HttpResponseMessage response = await new HttpClient().GetAsync(WalmartRestClient.ProductLookupApi(itemId));

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                searchDetails = JsonConvert.DeserializeObject<RootObject>(result);
            }
            return WalmartSearchQuery.ExtractRequiredProductDetails(searchDetails, itemId);
        }
    }
}
