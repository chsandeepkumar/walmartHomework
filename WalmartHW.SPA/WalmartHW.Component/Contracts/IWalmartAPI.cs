using System.Collections.Generic;
using System.Threading.Tasks;
using WalmartHW.Component.Model;

namespace WalmartHW.Component.Contracts
{
    interface IWalmartAPI
    {
        Task<List<Product>> SearchProductAsync(string SearchItem);
        Task<Product> GetProductDetailsAsync(string ItemId);
    }
}
