namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAtributosPrivados
{
    /* 
     * Clase Estudiante 
     * 
     * Tiene el modificar de acceso "public" significa que desde cualquier otra carpeta/paquete sera
     * posible crear objetos de esta clase, aunque no sea posible acceder a sus atributos y método por
     * ser "private" por defecto. El modificador de acceso de la clase es uno, el de los atributos y 
     * métodos puede ser el mismo u otro.
     */
    public class Estudiante
    {
        /* 
         * Atributos de la clase Estudiante 
         * 
         * Al no especificar modificador de acceso son "private" 
         * es decir, solo son accesibles desde la misma clase, por eso podemos crear objetos
         * y acceder a sus atributos desde el método main que esta más abajo, ya que este tambien
         * se encuentra en la misma clase. 
         * 
         * (Esto es para demostrar el alcance o scope del modificador de acceso private por defecto, 
         * no poner el main en la misma clase)
         */
        string carnet;
        string nombre;
        string carrera;

        /* Método que devuelve la información de los atributos del objeto */
        public string ObtenerInformacion()
        {
            return "Estudiante{" + "carnet=" + carnet + ", nombre=" + nombre + ", carrera=" + carrera + '}';
        }

        /* Método main en la misma clase para poder acceder a los atributos */
        public static void Main(string[] args)
        {
            // CREACIÓN DE OBJETOS DE TIPO ESTUDIANTE

            Estudiante estudiante1 = new Estudiante
            {
                carnet = "2021001",
                nombre = "Juan Perez",
                carrera = "Ingeniería Informática"
            };

            Estudiante estudiante2 = new()
            {
                carnet = "2021002",
                nombre = "Ana Rodriguez",
                carrera = "Ciencias de la Computación"
            };

            Estudiante estudiante3 = new Estudiante();
            estudiante3.carnet = "2021003";
            estudiante3.nombre = "Carlos González";
            estudiante3.carrera = "Ingeniería Eléctrica";

            // Mostrar información de sus atributos
            Console.WriteLine("Datos del Estudiante 1: " + estudiante1.ObtenerInformacion());
            Console.WriteLine("Datos del Estudiante 2: " + estudiante2.ObtenerInformacion());
            Console.WriteLine("Datos del Estudiante 3: " + estudiante3.ObtenerInformacion());
            Console.WriteLine();
        }
    }
}
