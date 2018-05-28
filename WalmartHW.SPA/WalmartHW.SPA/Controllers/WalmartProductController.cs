using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using WalmartHW.Component.Contracts;
using WalmartHW.Component.Model;
using WalmartHW.Component.Service;

namespace WalmartHW.SPA.Controllers
{
    public class WalmartProductController : ApiController
    {
        private readonly IWalmartApi _api;
        private readonly IWalmartApi _walmartApiComponent;
        public WalmartProductController(IWalmartApi api)
        {
            _api = api;
            _walmartApiComponent=new WalmartApiService();
        }
        [HttpGet]
        public async Task<List<Product>> SearchProduct(string searchItem)
        {
            return await _walmartApiComponent.SearchProductAsync(searchItem);
        }

        public async Task<Product> GetProductDetails(int itemId)
        {
            return await _walmartApiComponent.GetProductDetailsAsync(itemId);
        }
    }
}
