namespace WalmartHW.Component.Helper
{
    public class WalmartRestClient
    {
        private const string ResponseFormat = "json";
        private static readonly string ApiKey = "588qtynkrn6pjyeehznu72bh";
        public static string SearchApiRequest(string searchItem)
        {
            return $"http://api.walmartlabs.com/v1/search?query={searchItem}&format={ResponseFormat}&apiKey={ApiKey}";
        }
        public static string ProductLookupApi(int itemId)
        {
            return $"http://api.walmartlabs.com/v1/items/{itemId}&format={ResponseFormat}&apiKey={ApiKey}";
        }
    }
}
