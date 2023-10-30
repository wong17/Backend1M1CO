namespace MetodosConstructores.Constructores.CreacionDeConstructor
{
    public class Cliente
    {
        // Atributos de la clase Cliente
        private int id;
        private string? nombre;
        private string? apellido;
        private string? email;
        private string? telefono;
        private string? direccion;

        /* Creación de un constructor que recibe todos los atributos como parámetros */
        public Cliente(int id, string? nombre, string? apellido, string? email, string? telefono, string? direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        // Propiedades públicas para acceder a los atributos
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string? Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string? Email
        {
            get { return email; }
            set { email = value; }
        }

        public string? Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string? Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}
