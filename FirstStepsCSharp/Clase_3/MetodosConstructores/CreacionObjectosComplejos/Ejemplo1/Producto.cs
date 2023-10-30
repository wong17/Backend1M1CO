namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo1
{
    public class Producto
    {
        /* Atributos de la clase */
        private string? descripcion;
        private int cantidadEnStock;
        private double precio;
        private string? nombre;
        /* Propiedades para asignar y obtener valor de los atributos privados */
        public string? Nombre 
        { 
            get => nombre; 
            set => nombre = value; 
        }
        public double Precio 
        { 
            get => precio; 
            set => precio = value; 
        }
        public int CantidadEnStock 
        { 
            get => cantidadEnStock; 
            set => cantidadEnStock = value; 
        }
        public string? Descripcion 
        { 
            get => descripcion; 
            set => descripcion = value; 
        }
    }
}
