using System.Configuration;

namespace EstudiantesDesktopApp.ApiConnection
{
    public class AppSettings
    {
        public string? UrlApi { get; set; }
        public string? EstudianteEndpointUrl { get; set; }

        public AppSettings()
        {
            UrlApi = ConfigurationManager.AppSettings["UrlApi"]?.ToString();
            EstudianteEndpointUrl = ConfigurationManager.AppSettings["EstudianteEndpointUrl"]?.ToString();
        }
    }
}