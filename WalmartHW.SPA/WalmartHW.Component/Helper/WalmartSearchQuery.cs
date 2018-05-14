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
    }
}
