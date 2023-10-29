using System.Text.Json.Serialization;
using System.Text.Json;

namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo3
{
    public class Universidad
    {
        /* Atributos */
        private string? nombre;
        private Facultad[] facultades;
        /* Constructor */
        public Universidad(string? nombre, Facultad[] facultades)
        {
            this.nombre = nombre;
            this.facultades = facultades;
        }
        /* Getters y setters */
        public string? Nombre { get => nombre; set => nombre = value; }
        public Facultad[] Facultades { get => facultades; set => facultades = value; }

        /* Mostrar todas las facultades con sus carreras */
        public void MostrarFacultadesCarreras()
        {
            /* Por legibilidad convertimos el objeto a formato JSON y lo mostramos por consola */
            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            string json = JsonSerializer.Serialize(this, options);
            Console.WriteLine("\n" + json);
        }
    }
}
