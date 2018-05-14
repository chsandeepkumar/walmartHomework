using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalmartHW.Component.Model;

namespace WalmartHW.Component.Helper
{
    class WalmartSearchQuery
    {
        internal static IEnumerable<Product> ExtractRequiredProductDetails(RootObject searchDetails)
        {
            return from item in searchDetails.Items
                   select new Product
                   {
                       Name = item.Name,
                       Description = item.ShortDescription,
                       Price = item.SalePrice,
                       ThumbnailImageurl = item.ThumbnailImage
                   };
        }
        internal static Product ExtractRequiredProductDetails(RootObject searchDetails, int ProductId)
        {
            Item result = searchDetails.Items.Single(item => item.ParentItemId == ProductId);
            Product requiredproduct = new Product
            {
                Name = result.Name,
                Description = result.ShortDescription,
                Price = result.SalePrice,
                ThumbnailImageurl = result.ThumbnailImage
            };
            return requiredproduct;
        }
    }
}
