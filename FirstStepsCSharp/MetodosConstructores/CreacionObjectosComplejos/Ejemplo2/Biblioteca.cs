using System.Text.Json.Serialization;
using System.Text.Json;

namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo2
{
    public class Biblioteca
    {
        /* Atributo de la clase Biblioteca */
        private Libro[]? libros;
        /* Propiedad para obtener y dar valor al atributo Libros */
        public Libro[]? Libros { get => libros; set => libros = value; }
        /* Constructor de la clase Biblioteca para crear el objeto con los libros de una vez */
        public Biblioteca(Libro[]? libros)
        {
            this.libros = libros;            
        }
        /* Método para mostrar todos los libros con la información de cada uno */
        public void MostrarLibros()
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
