namespace ClasesObjetosPresentacion.MetodosGettersSetters
{
    public class CustomerMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------------------------- EJEMPLO CustomerMain -----------------------------\n");
            // Creación de tres objetos de tipo Customer
            Customer customer1 = new Customer
            {
                //Id = 1, NO podemos asignar un valor al Id
                Nombre = "Juan Pérez",
                Telefono = "555-12345"
            };

            Customer customer2 = new Customer
            {
                //Id = 2, NO podemos asignar un valor al Id
                Nombre = "Ana Rodríguez",
                Telefono = "555-67890"
            };

            Customer customer3 = new Customer
            {
                //Id = 3, NO podemos asignar un valor al Id
                Nombre = "Carlos González",
                Telefono = "555-98765"
            };

            // Mostrar la información de los clientes
            Console.WriteLine("Datos del Cliente 1:");
            Console.WriteLine("Id: " + customer1.Id);
            Console.WriteLine("Nombre: " + customer1.Nombre);
            Console.WriteLine("Teléfono: " + customer1.Telefono);

            Console.WriteLine("\nDatos del Cliente 2:");
            Console.WriteLine("Id: " + customer2.Id);
            Console.WriteLine("Nombre: " + customer2.Nombre);
            Console.WriteLine("Teléfono: " + customer2.Telefono);

            Console.WriteLine("\nDatos del Cliente 3:");
            Console.WriteLine("Id: " + customer3.Id);
            Console.WriteLine("Nombre: " + customer3.Nombre);
            Console.WriteLine("Teléfono: " + customer3.Telefono);
        }
    }
}
