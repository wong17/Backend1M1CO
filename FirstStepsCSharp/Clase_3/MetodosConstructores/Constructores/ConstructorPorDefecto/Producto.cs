namespace MetodosConstructores.Constructores.ConstructorPorDefecto
{
    public class Producto
    {
        // Atributos de la clase Producto
        private int codigo;
        private string? nombre;
        private double precio;
        private int cantidadEnStock;
        private string? descripcion;
        private string? categoria;

        /* 
         * Toda clase tiene un "constructor por defecto" al no declarar uno de forma
         * explicita. El constructor por defecto no recibe parámetros y nos permite
         * crear objetos de esta forma:
         * 
         * Producto p = new Producto();
         */

        // Propiedades públicas para acceder a los atributos
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string? Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int CantidadEnStock
        {
            get { return cantidadEnStock; }
            set { cantidadEnStock = value; }
        }

        public string? Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string? Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    }

}
