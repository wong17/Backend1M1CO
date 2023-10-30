namespace MetodosConstructores.Constructores.ConstructorPorDefecto
{
    public class Cliente
    {
        // Atributos de la clase Cliente
        private int id;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private string direccion;

        // Constructor por defecto
        public Cliente()
        {
            /* 
             * Se puedes inicializar los atributos en el constructor por defecto, de esta
             * forma todos los objetos que creemos tendran estos datos desde su creación. 
             */
            id = 1;
            nombre = "Nombre del Cliente";
            apellido = "Apellido del Cliente";
            email = "cliente@example.com";
            telefono = "123-456-7890";
            direccion = "Dirección del Cliente";
        }

        // Propiedades públicas para acceder a los atributos
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}
