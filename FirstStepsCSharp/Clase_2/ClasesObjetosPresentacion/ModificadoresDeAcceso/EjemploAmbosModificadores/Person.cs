namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAmbosModificadores
{
    /*
     * Clase Person
     */
    public class Person
    {
        /*
         * Atributos de la clase Person
         * 
         * El modificador de acceso "public" nos permitira acceder a los campos desde cualquier parte del programa
         * El modificador de acceso "private" nos permitira solo acceder a los campos desde la misma clase
         */
        public string nombre;
        public string apellido;
        private string direccion;
        private string numeroCuentaBancaria;

        /* Método main esta en la misma clase Person */
        public static void Main(string[] args)
        {
            /* Desde aqui no hay problema en acceder a los atributos privados, porque estamos en la misma clase. */

            Person person1 = new Person
            {
                nombre = "Juan",
                apellido = "Gomez",
                direccion = "uan dirección aquí...",            // private
                numeroCuentaBancaria = "4545-122344567-12323"   // private
            };

            Person person2 = new();
            person2.nombre = "Ana";
            person2.apellido = "Martinez";
            person2.direccion = "Segunda dirección aquí...";        // private
            person2.numeroCuentaBancaria = "7890-456789012-56789";  // private

            // Acceso, atributos públicos y privados de los objetos
            Console.WriteLine("Datos de la Persona 1:");
            Console.WriteLine("Nombre: " + person1.nombre);
            Console.WriteLine("Apellido: " + person1.apellido);
            Console.WriteLine("Direccion: " + person1.direccion);
            Console.WriteLine("Numero de cuenta bancaria: " + person1.numeroCuentaBancaria + "\n");

            Console.WriteLine("\nDatos de la Persona 2:");
            Console.WriteLine("Nombre: " + person2.nombre);
            Console.WriteLine("Apellido: " + person2.apellido);
            Console.WriteLine("Direccion: " + person2.direccion);
            Console.WriteLine("Numero de cuenta bancaria: " + person2.numeroCuentaBancaria + "\n");
        }
    }
}
