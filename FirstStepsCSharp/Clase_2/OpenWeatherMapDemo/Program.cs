
using OpenWeatherMapDemo.Services;

OpenWeatherMapDataService dataService = new();
/* Obtener ciudades/departamentos de Nicaragua */
var cities = await dataService.GetNICities();
if (cities is null)
{
    Console.WriteLine("Ocurrio un error al obtener las ciudades/departamentos de Nicaragua.");
    Environment.Exit(1);
}
/* Si se obtuvieron correctamente, mostrar para que el usuario seleccione */
int i = 0;
foreach (var city in cities)
{
    Console.WriteLine($"{i + 1}. {city.name}");
    i++;
}
/* Pedir al usuario que seleccione una ciudad/departamento */
Console.Write("Seleccione una opción: ");
int option = int.Parse(Console.ReadLine() ?? "1");
/* Obtener información actual del cliente de la API */
var response = await dataService.GetCurrentWeather(cities.ElementAt(option - 1));
if (response is null)
{
    Console.WriteLine($"Ocurrio un error al obtener clima de {cities.ElementAt(option - 1).name}");
    Environment.Exit(1);
}
/* Si todo salio correctamente */
Console.WriteLine($"\n---------- CLIMA ACTUAL - {cities.ElementAt(option - 1).name} ----------");
response.PrintAttributes();