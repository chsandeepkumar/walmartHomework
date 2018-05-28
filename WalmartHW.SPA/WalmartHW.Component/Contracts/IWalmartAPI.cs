using System.Collections.Generic;
using System.Threading.Tasks;
using WalmartHW.Component.Model;

namespace WalmartHW.Component.Contracts
{
   public interface IWalmartApi
    {
        Task<List<Product>> SearchProductAsync(string searchItem);
        Task<Product> GetProductDetailsAsync(int itemId);
    }
}
