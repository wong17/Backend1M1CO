using System.Configuration;

namespace OpenWeatherMapDemo.ApiConnection
{
    public class AppSetting
    {
        public string? ApiKey { get; set; }
        public string? CityList { get; set; }
        public string? CurrentWeatherEndpoint { get; set; }

        public AppSetting()
        {
            ApiKey = ConfigurationManager.AppSettings["DEMO_API_KEY"]?.ToString();
            CityList = ConfigurationManager.AppSettings["CITY_LIST"]?.ToString();
            CurrentWeatherEndpoint = ConfigurationManager.AppSettings["CURRENT_WEATHER_ENDPOINT"]?.ToString();
        }
    }
}
