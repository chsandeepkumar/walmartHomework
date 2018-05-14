using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WalmartHW.Component.Contracts;
using WalmartHW.Component.Helper;
using WalmartHW.Component.Model;
using System.Linq;
namespace WalmartHW.Component.Service
{
    public class WalmartAPIService : IWalmartAPI
    {

        async Task<List<Product>> IWalmartAPI.SearchProductAsync(string SearchItem)
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
        async Task<Product> IWalmartAPI.GetProductDetailsAsync(string ItemId)
        {
            throw new NotImplementedException();
        }
    }
}
