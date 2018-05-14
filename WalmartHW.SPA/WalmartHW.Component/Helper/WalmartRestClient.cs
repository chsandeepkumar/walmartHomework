using System.Net.Http;

namespace WalmartHW.Component.Helper
{
    public class WalmartAPI
    {
        static readonly string responceFormat = "json";
        static readonly string apiKey = "588qtynkrn6pjyeehznu72bh";
        public static string SerachAPIRequest(string seacrchItem)
        {
            return $"http://api.walmartlabs.com/v1/search?query={seacrchItem}&format={responceFormat}&apiKey={apiKey}";
        }
    }
}
