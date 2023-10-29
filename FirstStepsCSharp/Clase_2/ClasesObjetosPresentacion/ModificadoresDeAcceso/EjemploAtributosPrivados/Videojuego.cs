namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAtributosPrivados
{
    /* 
     * Clase Videojuego 
     * 
     * Tiene el modificar de acceso "public" significa que desde cualquier otra carpeta/paquete sera
     * posible crear objetos de esta clase, aunque no sea posible acceder a sus atributos y método por
     * ser "private" por defecto. El modificador de acceso de la clase es uno, el de los atributos y 
     * métodos puede ser el mismo u otro.
     */
    public class Videojuego
    {
        /* 
         * Atributos de la clase Videojuego 
         * 
         * Al no especificar modificador de acceso son "private" 
         * es decir, solo son accesibles desde la misma clase, por eso podemos crear objetos
         * y acceder a sus atributos desde el método main que esta más abajo, ya que este tambien
         * se encuentra en la misma clase. 
         * 
         * (Esto es para demostrar el alcance o scope del modificador de acceso private por defecto, 
         * no poner el main en la misma clase)
         */
        string nombre;
        string desarrollador;
        int año;

        /* Método que devuelve la información de los atributos del objeto */
        public string ObtenerInformacion()
        {
            return "Videojuego{" + "nombre=" + nombre + " desarrollador=" + desarrollador + ", año=" + año + '}';
        }

        /* Método main en la misma clase para poder acceder a los atributos */
        public static void Main(string[] args)
        {
            // CREACIÓN DE OBJETOS DE TIPO COCHE

            // Creación de tres objetos de tipo Videojuego
            Videojuego videojuego1 = new Videojuego
            {
                nombre = "The Legend of Zelda: Breath of the Wild",
                desarrollador = "Nintendo",
                año = 2017
            };

            Videojuego videojuego2 = new Videojuego
            {
                nombre = "The Witcher 3: Wild Hunt",
                desarrollador = "CD Projekt Red",
                año = 2015
            };

            Videojuego videojuego3 = new Videojuego
            {
                nombre = "Red Dead Redemption 2",
                desarrollador = "Rockstar Games",
                año = 2018
            };

            // Mostrar la información de los videojuegos
            Console.WriteLine("Datos del Videojuego 1: " + videojuego1.ObtenerInformacion());
            Console.WriteLine("Datos del Videojuego 2: " + videojuego2.ObtenerInformacion());
            Console.WriteLine("Datos del Videojuego 3: " + videojuego3.ObtenerInformacion());
            Console.WriteLine();
        }
    }

}
