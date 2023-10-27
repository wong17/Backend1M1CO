namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAmbosModificadores
{
    public class PersonMain
    {
        /* Método main de la clase PersonMain */
        public static void Main(string[] args)
        {
            /* Al estar en otra clase no es posible dar valores a los atributos privados y obtener su valor */

            Person person1 = new Person
            {
                nombre = "Juan",
                apellido = "Gomez",
                //direccion = "Una dirección aquí...",            // private (ERROR DE COMPILACIÓN)
                //numeroCuentaBancaria = "4545-122344567-12323"   // private (ERROR DE COMPILACIÓN)
            };

            Person person2 = new();
            person2.nombre = "Ana";
            person2.apellido = "Martinez";
            //person2.direccion = "Segunda dirección aquí...";        // private (ERROR DE COMPILACIÓN)
            //person2.numeroCuentaBancaria = "7890-456789012-56789";  // private (ERROR DE COMPILACIÓN)

            // Acceso, atributos públicos y privados de los objetos
            Console.WriteLine("Datos de la Persona 1:");
            Console.WriteLine("Nombre: " + person1.nombre);
            Console.WriteLine("Apellido: " + person1.apellido);
            //Console.WriteLine("Nombre: " + person1.direccion);
            //Console.WriteLine("Apellido: " + person1.numeroCuentaBancaria);

            Console.WriteLine("\nDatos de la Persona 2:");
            Console.WriteLine("Nombre: " + person2.nombre);
            Console.WriteLine("Apellido: " + person2.apellido + "\n");
            //Console.WriteLine("Nombre: " + person2.direccion);                // private (ERROR DE COMPILACIÓN)
            //Console.WriteLine("Apellido: " + person2.numeroCuentaBancaria);   // private (ERROR DE COMPILACIÓN)
        }
    }
}
