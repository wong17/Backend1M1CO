namespace MetodosConstructores.Constructores.ConstructorPorDefecto
{
    public class Empleado
    {
        // Atributos de la clase Empleado
        private int id;
        private string nombre;
        private string apellido;
        private string puesto;
        private double salario;
        private string departamento;

        // Constructor por defecto
        public Empleado()
        {
            /* 
            * Se puedes inicializar los atributos en el constructor por defecto, de esta
            * forma todos los objetos que creemos tendran estos datos desde su creación. 
            */
            id = 1;
            nombre = "Nombre del Empleado";
            apellido = "Apellido del Empleado";
            puesto = "Puesto del Empleado";
            salario = 10000.0;
            departamento = "Departamento del Empleado";
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

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
    }
}
