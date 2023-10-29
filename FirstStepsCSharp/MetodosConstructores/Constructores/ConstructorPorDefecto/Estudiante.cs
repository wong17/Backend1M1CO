namespace MetodosConstructores.Constructores.ConstructorPorDefecto
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

        /* 
         * Toda clase tiene un "constructor por defecto" al no declarar uno de forma
         * explicita. El constructor por defecto no recibe parámetros y nos permite
         * crear objetos de esta forma:
         * 
         * Estudiante e = new Estudiante();
         */

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
