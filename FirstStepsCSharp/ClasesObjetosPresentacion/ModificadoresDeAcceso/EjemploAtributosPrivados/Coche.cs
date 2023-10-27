namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAtributosPrivados
{
    /* 
     * Clase Coche 
     * 
     * Tiene el modifiCoche de acceso "public" significa que desde cualquier otra carpeta/paquete sera
     * posible crear objetos de esta clase, aunque no sea posible acceder a sus atributos y método por
     * ser "private" por defecto. El modificador de acceso de la clase es uno, el de los atributos y 
     * métodos puede ser el mismo u otro.
     */
    public class Coche
    {
        /* 
         * Atributos de la clase Coche 
         * 
         * Al no especificar modificador de acceso son "private" 
         * es decir, solo son accesibles desde la misma clase, por eso podemos crear objetos
         * y acceder a sus atributos desde el método main que esta más abajo, ya que este tambien
         * se encuentra en la misma clase. 
         * 
         * (Esto es para demostrar el alcance o scope del modificador de acceso private por defecto, 
         * no poner el main en la misma clase)
         */
        string Marca { get; set; }
        string Modelo { get; set; }
        int AñoFabricacion { get; set; }
        string Color { get; set; }

        /* Método que devuelve la información de los atributos del objeto */
        string MostrarInformacion()
        {
            return "Marca: " + Marca + ", Modelo: " + Modelo +
                   ", Año de Fabricación: " + AñoFabricacion + ", Color: " + Color;
        }

        /* Método main en la misma clase para poder acceder a los atributos */
        public static void Main(string[] args)
        {
            // CREACIÓN DE OBJETOS DE TIPO COCHE

            // 1. Primera forma de crear un objeto "new Coche"
            Coche coche1 = new Coche
            {
                Marca = "Toyota",
                Modelo = "Camry",
                AñoFabricacion = 2022,
                Color = "Rojo"
            };

            // 2. Segunda forma de crear un objeto "new()"
            Coche coche2 = new()
            {
                Marca = "Ford",
                Modelo = "Mustang",
                AñoFabricacion = 2023,
                Color = "Negro"
            };

            // 3. Tercera forma de crear un objeto
            Coche coche3 = new Coche();
            coche3.Marca = "Ford";
            coche3.Modelo = "Mustang";
            coche3.AñoFabricacion = 2023;
            coche3.Color = "Negro";

            // 4. Cuarta forma de crear un objeto
            Coche coche4;   // Declarar la variable de tipo Coche
            coche4 = new()  // Instanciar/crear objeto con la palabra "new"
            {
                Marca = "Chevrolet",
                Modelo = "Cruze",
                AñoFabricacion = 2022,
                Color = "Plateado"
            };

            // Mostrar información de sus atributos
            Console.WriteLine(coche1.MostrarInformacion());
            Console.WriteLine(coche2.MostrarInformacion());
            Console.WriteLine(coche3.MostrarInformacion());
            Console.WriteLine(coche4.MostrarInformacion());
            Console.WriteLine();
        }
    }
}
