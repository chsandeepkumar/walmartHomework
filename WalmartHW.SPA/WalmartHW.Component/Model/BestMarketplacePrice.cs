namespace WalmartHW.Component.Model
{
    public class BestMarketplacePrice
    {
        public double Price { get; set; }
        public string SellerInfo { get; set; }
        public double StandardShipRate { get; set; }
        public double TwoThreeDayShippingRate { get; set; }
        public bool AvailableOnline { get; set; }
        public bool Clearance { get; set; }
        public string OfferType { get; set; }
    }
}
