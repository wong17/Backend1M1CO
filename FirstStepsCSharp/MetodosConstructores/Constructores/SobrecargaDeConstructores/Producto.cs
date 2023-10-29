namespace MetodosConstructores.Constructores.SobrecargaDeConstructores
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

        /* Constructor por defecto (sin parámetros) */
        public Producto()
        {
        }

        /* Constructor que recibe el código y el nombre */
        public Producto(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        /* Constructor que recibe el código, nombre, precio y cantidad en stock */
        public Producto(int codigo, string nombre, double precio, int cantidadEnStock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidadEnStock = cantidadEnStock;
        }

        /* Constructor que recibe todos los atributos como parámetros */
        public Producto(int codigo, string nombre, double precio, int cantidadEnStock, string descripcion, string categoria)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidadEnStock = cantidadEnStock;
            this.descripcion = descripcion;
            this.categoria = categoria;
        }

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
