using System.Text.Json.Serialization;
using System.Text.Json;

namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo1
{
    public class Pedido
    {
        /* Propiedades de la clase */
        public Cliente Cliente { get; private set; }
        // Lista de todos los Productos
        public Producto[] Productos { get; private set; }
        public string DireccionDeEntrega { get; private set; }
        public DateTime FechaPedido { get; private set; }
        /* Constructor para crear el Pedido */
        public Pedido(Cliente cliente, Producto[] productos, string direccion, DateTime fecha)
        {
            Cliente = cliente;
            Productos = productos;
            DireccionDeEntrega = direccion;
            FechaPedido = fecha;
        }
        /* Muestra la información del Pedido */
        public void MostrarPedido()
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
