using System.Collections.Generic;

namespace WalmartHW.Component.Model
{
    public class Item
    {
        public int ItemId { get; set; }
        public int ParentItemId { get; set; }
        public string Name { get; set; }
        public double Msrp { get; set; }
        public double SalePrice { get; set; }
        public string Upc { get; set; }
        public string CategoryPath { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ThumbnailImage { get; set; }
        public string MediumImage { get; set; }
        public string LargeImage { get; set; }
        public string ProductTrackingUrl { get; set; }
        public double StandardShipRate { get; set; }
        public bool Marketplace { get; set; }
        public string ModelNumber { get; set; }
        public string ProductUrl { get; set; }
        public string CustomerRating { get; set; }
        public int NumReviews { get; set; }
        public string CustomerRatingImage { get; set; }
        public string CategoryNode { get; set; }
        public bool Bundle { get; set; }
        public string Stock { get; set; }
        public string AddToCartUrl { get; set; }
        public string AffiliateAddToCartUrl { get; set; }
        public GiftOptions GiftOptions { get; set; }
        public List<ImageEntity> ImageEntities { get; set; }
        public string OfferType { get; set; }
        public bool IsTwoDayShippingEligible { get; set; }
        public bool AvailableOnline { get; set; }
        public string SellerInfo { get; set; }
        public bool? FreeShippingOver50Dollars { get; set; }
    }
}
