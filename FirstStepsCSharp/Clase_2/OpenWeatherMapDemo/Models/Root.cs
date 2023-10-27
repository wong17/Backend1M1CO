using System.Text.Json.Serialization;
using System.Text.Json;

namespace OpenWeatherMapDemo.Model
{
    public class Root
    {
        public Coord? Coord { get; set; }
        public List<Weather>? Weather { get; set; }
        public string? Base { get; set; }
        public Main? Main { get; set; }
        public int Visibility { get; set; }
        public Wind? Wind { get; set; }
        public Clouds? Clouds { get; set; }
        public long Dt { get; set; }
        public Sys? Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Cod { get; set; }
        /* Imprime en consola toda la información obtenida de la API */
        public void PrintAttributes()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            string json = JsonSerializer.Serialize(this, options);
            Console.WriteLine("\n" + json);
        }
    }
}
