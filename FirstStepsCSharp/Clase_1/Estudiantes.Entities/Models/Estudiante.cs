using System.Text.Json.Serialization;

namespace EstudiantesDesktopApp.Entities.Models
{
    public class Estudiante
    {
        /* Atributos de la clase Estudiante */
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Nombre")]
        public string? Nombre { get; set; }

        [JsonPropertyName("Carnet")]
        public string? Carnet { get; set; }

        [JsonPropertyName("Carrera")]
        public string? Carrera { get; set; }
    }
}