using OpenWeatherMapDemo.ApiConnection;
using OpenWeatherMapDemo.Models;
using OpenWeatherMapDemo.Util;
using System.Net.Http.Json;

namespace OpenWeatherMapDemo.Services
{
    public class OpenWeatherMapDataService
    {
        private readonly IOJsonFile _file;
        private readonly AppSetting _settings;

        public OpenWeatherMapDataService()
        {
            _file = new IOJsonFile();
            _settings = new AppSetting();
        }

        /* Lee y devuelve todas las ciudades del archivo city.list.json */
        private async Task<List<City>?> GetCityList()
        {
            if (_settings is null || _settings.CityList is null)
                return null;
            /* Lee archivo city.list.json */
            var cities = await _file.Load<List<City>?>(_settings.CityList);
            return cities;
        }

        /* Filtra solo las ciudades de Nicaragua */
        public async Task<List<City>?> GetNICities()
        {
            var cities = await GetCityList();
            if (cities is null)
                return null;

            var niCities = cities.FindAll(c => c.country != null && c.country.Equals("NI"));
            return niCities;
        }

        /* Devuelve el clima actual de la ciudad especificada */
        public async Task<Root?> GetCurrentWeather(City city)
        {
            HttpClient client = new();
            /* Endpoint para realizar petición GET, formado por el nombre de la ciudad y el API key */
            var url = $"{_settings.CurrentWeatherEndpoint}{city.name}&appid={_settings.ApiKey}";
            /* Envia petición GET y convierte el archivo json recibido en un objeto de tipo Root que contiene todos los datos del clima */
            var response = await client.GetFromJsonAsync<Root>(url);
            
            if (response is null)
                return null;

            return response;
        }
    }
}