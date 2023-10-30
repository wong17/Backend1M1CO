namespace MetodosConstructores.Constructores.CreacionDeConstructor
{
    public class Estudiante
    {
        /* Atributos de la clase */
        private int id;
        private string? nombre;
        private int edad;
        private string? numeroDeCarnet;
        private string? carrera;
        private string? grupo;

        /* Creación de un constructor que recibe todos los atributos como parámetros */
        public Estudiante(int id, string? nombre, int edad, string? numeroDeCarnet, string? carrera, string? grupo)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.numeroDeCarnet = numeroDeCarnet;
            this.carrera = carrera;
            this.grupo = grupo;
        }

        /* Getters y setters para asignar/obtener valor de campos privados */
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

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string? NumeroDeCarnet
        {
            get { return numeroDeCarnet; }
            set { numeroDeCarnet = value; }
        }

        public string? Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public string? Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
    }
}
