namespace MetodosConstructores.Constructores.SobrecargaDeConstructores
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

        /* Creación de constructor por defecto (sin parámetros) */
        public Cliente()
        {

        }

        /* Creación de un constructor que recibe 2 de los atributos como parámetros */
        public Cliente(int id, string? nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        /* Creación de un constructor que recibe 3 de los atributos como parámetros */
        public Cliente(int id, string? nombre, string? apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /* Creación de un constructor que recibe 4 de los atributos como parámetros */
        public Cliente(int id, string? nombre, string? apellido, string? email)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
        }

        /* Creación de un constructor que recibe 5 de los atributos como parámetros */
        public Cliente(int id, string? nombre, string? apellido, string? email, string? telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
        }

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
