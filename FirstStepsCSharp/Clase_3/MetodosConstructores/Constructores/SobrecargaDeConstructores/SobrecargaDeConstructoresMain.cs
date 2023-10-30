namespace MetodosConstructores.Constructores.SobrecargaDeConstructores
{
    public class SobrecargaDeConstructoresMain
    {
        public static void Main()
        {
            /* 
             * Creación de objetos utilizando sobrecarga de constructores 
             * 
             * Al momento de hacer sobrecarga de constructores, es decir crear varios constructores 
             * no pueden haber 2 o mas que sean iguales en el mismo tipo de datos y cantidad de parámetros
             * que reciben. El constructor es una función especial de las clases, pero funciona igual que las
             * demás funciones en el sentido de que no pueden haber 2 constructores iguales. 
             */

            #region Estudiante

            // Creación de objetos de la clase Estudiante utilizando diferentes constructores
            Estudiante estudiante1 = new(); // Constructor por defecto
            // Constructor con 2 atributos
            Estudiante estudiante2 = new(1, "Juan");
            // Constructor con 3 atributos
            Estudiante estudiante3 = new(2, "María", 20);
            // Constructor con todos los atributos
            Estudiante estudiante4 = new(3, "Carlos", 22, "12345", "Informática", "Grupo A");

            // Mostrar la información de los estudiantes
            Console.WriteLine("------------------------------------ Estudiante -------------------------------------");
            Console.WriteLine("Información del Estudiante 1: Constructor por defecto");
            Console.WriteLine($"ID: {estudiante1.Id}");
            Console.WriteLine($"Nombre: {estudiante1.Nombre}");
            Console.WriteLine($"Edad: {estudiante1.Edad}");
            Console.WriteLine($"Número de Carnet: {estudiante1.NumeroDeCarnet}");
            Console.WriteLine($"Carrera: {estudiante1.Carrera}");
            Console.WriteLine($"Grupo: {estudiante1.Grupo}");

            Console.WriteLine("\nInformación del Estudiante 2: Constructor con 2 atributos");
            Console.WriteLine($"ID: {estudiante2.Id}");
            Console.WriteLine($"Nombre: {estudiante2.Nombre}");
            Console.WriteLine($"Edad: {estudiante2.Edad}");
            Console.WriteLine($"Número de Carnet: {estudiante2.NumeroDeCarnet}");
            Console.WriteLine($"Carrera: {estudiante2.Carrera}");
            Console.WriteLine($"Grupo: {estudiante2.Grupo}");

            Console.WriteLine("\nInformación del Estudiante 3: Constructor con 3 atributos");
            Console.WriteLine($"ID: {estudiante3.Id}");
            Console.WriteLine($"Nombre: {estudiante3.Nombre}");
            Console.WriteLine($"Edad: {estudiante3.Edad}");
            Console.WriteLine($"Número de Carnet: {estudiante3.NumeroDeCarnet}");
            Console.WriteLine($"Carrera: {estudiante3.Carrera}");
            Console.WriteLine($"Grupo: {estudiante3.Grupo}");

            Console.WriteLine("\nInformación del Estudiante 4: Constructor con todos los atributos");
            Console.WriteLine($"ID: {estudiante4.Id}");
            Console.WriteLine($"Nombre: {estudiante4.Nombre}");
            Console.WriteLine($"Edad: {estudiante4.Edad}");
            Console.WriteLine($"Número de Carnet: {estudiante4.NumeroDeCarnet}");
            Console.WriteLine($"Carrera: {estudiante4.Carrera}");
            Console.WriteLine($"Grupo: {estudiante4.Grupo}\n");

            #endregion

            #region Producto

            // Creación de objetos de la clase Producto utilizando diferentes constructores
            Producto producto1 = new(); // Constructor por defecto
            // Constructor con 2 atributos
            Producto producto2 = new(1, "Laptop");
            // Constructor con 4 atributos
            Producto producto3 = new(2, "Teléfono", 399.99, 50);
            // Constructor con todos los atributos
            Producto producto4 = new(3, "Libro", 19.99, 100, "Novela bestseller", "Libros");

            // Mostrar la información de los productos
            Console.WriteLine("------------------------------------ Producto -------------------------------------");
            Console.WriteLine("Información del Producto 1: Constructor por defecto");
            Console.WriteLine($"Código: {producto1.Codigo}");
            Console.WriteLine($"Nombre: {producto1.Nombre}");
            Console.WriteLine($"Precio: {producto1.Precio:C}");
            Console.WriteLine($"Cantidad en Stock: {producto1.CantidadEnStock}");
            Console.WriteLine($"Descripción: {producto1.Descripcion}");
            Console.WriteLine($"Categoría: {producto1.Categoria}");

            Console.WriteLine("\nInformación del Producto 2: Constructor con 2 atributos");
            Console.WriteLine($"Código: {producto2.Codigo}");
            Console.WriteLine($"Nombre: {producto2.Nombre}");
            Console.WriteLine($"Precio: {producto2.Precio:C}");
            Console.WriteLine($"Cantidad en Stock: {producto2.CantidadEnStock}");
            Console.WriteLine($"Descripción: {producto2.Descripcion}");
            Console.WriteLine($"Categoría: {producto2.Categoria}");

            Console.WriteLine("\nInformación del Producto 3: Constructor con 4 atributos");
            Console.WriteLine($"Código: {producto3.Codigo}");
            Console.WriteLine($"Nombre: {producto3.Nombre}");
            Console.WriteLine($"Precio: {producto3.Precio:C}");
            Console.WriteLine($"Cantidad en Stock: {producto3.CantidadEnStock}");
            Console.WriteLine($"Descripción: {producto3.Descripcion}");
            Console.WriteLine($"Categoría: {producto3.Categoria}");

            Console.WriteLine("\nInformación del Producto 4: Constructor con todos los atributos");
            Console.WriteLine($"Código: {producto4.Codigo}");
            Console.WriteLine($"Nombre: {producto4.Nombre}");
            Console.WriteLine($"Precio: {producto4.Precio:C}");
            Console.WriteLine($"Cantidad en Stock: {producto4.CantidadEnStock}");
            Console.WriteLine($"Descripción: {producto4.Descripcion}");
            Console.WriteLine($"Categoría: {producto4.Categoria}\n");

            #endregion Producto

            #region Cliente

            // Creación de un objeto de la clase Cliente utilizando diferentes constructores
            Cliente cliente1 = new(); // Constructor por defecto

            // Constructor con 2 atributos
            Cliente cliente2 = new(1, "Juan");
            // Constructor con 3 atributos
            Cliente cliente3 = new(2, "María", "López");
            // Constructor con 4 atributos
            Cliente cliente4 = new(3, "Carlos", "García", "carlos@example.com");
            // Constructor con 5 atributos
            Cliente cliente5 = new(4, "Laura", "Martínez", "laura@example.com", "555-555-5555");
            // Constructor con todos los atributos
            Cliente cliente6 = new(5, "Pedro", "Ramírez", "pedro@example.com", "555-123-4567", "Calle 123, Ciudad A");

            // Mostrar la información de los clientes
            Console.WriteLine("------------------------------------ Cliente -------------------------------------");
            Console.WriteLine("Información del Cliente 1: Constructor por defecto");
            Console.WriteLine($"ID: {cliente1.Id}");
            Console.WriteLine($"Nombre: {cliente1.Nombre}");
            Console.WriteLine($"Apellido: {cliente1.Apellido}");
            Console.WriteLine($"Email: {cliente1.Email}");
            Console.WriteLine($"Teléfono: {cliente1.Telefono}");
            Console.WriteLine($"Dirección: {cliente1.Direccion}");

            Console.WriteLine("\nInformación del Cliente 2: Constructor con 2 atributos");
            Console.WriteLine($"ID: {cliente2.Id}");
            Console.WriteLine($"Nombre: {cliente2.Nombre}");
            Console.WriteLine($"Apellido: {cliente2.Apellido}");
            Console.WriteLine($"Email: {cliente2.Email}");
            Console.WriteLine($"Teléfono: {cliente2.Telefono}");
            Console.WriteLine($"Dirección: {cliente2.Direccion}");

            Console.WriteLine("\nInformación del Cliente 3: Constructor con 3 atributos");
            Console.WriteLine($"ID: {cliente3.Id}");
            Console.WriteLine($"Nombre: {cliente3.Nombre}");
            Console.WriteLine($"Apellido: {cliente3.Apellido}");
            Console.WriteLine($"Email: {cliente3.Email}");
            Console.WriteLine($"Teléfono: {cliente3.Telefono}");
            Console.WriteLine($"Dirección: {cliente3.Direccion}");

            Console.WriteLine("\nInformación del Cliente 4: Constructor con 4 atributos");
            Console.WriteLine($"ID: {cliente4.Id}");
            Console.WriteLine($"Nombre: {cliente4.Nombre}");
            Console.WriteLine($"Apellido: {cliente4.Apellido}");
            Console.WriteLine($"Email: {cliente4.Email}");
            Console.WriteLine($"Teléfono: {cliente4.Telefono}");
            Console.WriteLine($"Dirección: {cliente4.Direccion}");

            Console.WriteLine("\nInformación del Cliente 5: Constructor con 5 atributos");
            Console.WriteLine($"ID: {cliente5.Id}");
            Console.WriteLine($"Nombre: {cliente5.Nombre}");
            Console.WriteLine($"Apellido: {cliente5.Apellido}");
            Console.WriteLine($"Email: {cliente5.Email}");
            Console.WriteLine($"Teléfono: {cliente5.Telefono}");
            Console.WriteLine($"Dirección: {cliente5.Direccion}");

            Console.WriteLine("\nInformación del Cliente 6: Constructor con todos los atributos");
            Console.WriteLine($"ID: {cliente6.Id}");
            Console.WriteLine($"Nombre: {cliente6.Nombre}");
            Console.WriteLine($"Apellido: {cliente6.Apellido}");
            Console.WriteLine($"Email: {cliente6.Email}");
            Console.WriteLine($"Teléfono: {cliente6.Telefono}");
            Console.WriteLine($"Dirección: {cliente6.Direccion}\n");

            #endregion Cliente

            #region Empleado

            // Creación de objetos de la clase Empleado utilizando diferentes constructores
            Empleado empleado1 = new(); // Constructor por defecto

            // Constructor con 3 atributos
            Empleado empleado2 = new(1, "Juan", "Programador");
            // Constructor con 4 atributos
            Empleado empleado3 = new(2, "María", "López", "Diseñador");
            // Constructor con 5 atributos
            Empleado empleado4 = new(3, "Carlos", "García", "Gerente de Proyectos", 75000.0);
            // Constructor con todos los atributos
            Empleado empleado5 = new(4, "Laura", "Martínez", "Analista de Datos", 60000.0, "Tecnología");

            // Mostrar la información de los empleados
            Console.WriteLine("------------------------------------ Empleado -------------------------------------");
            Console.WriteLine("Información del Empleado 1: Constructor por defecto ");
            Console.WriteLine($"ID: {empleado1.Id}");
            Console.WriteLine($"Nombre: {empleado1.Nombre}");
            Console.WriteLine($"Apellido: {empleado1.Apellido}");
            Console.WriteLine($"Puesto: {empleado1.Puesto}");
            Console.WriteLine($"Salario: {empleado1.Salario:C}");
            Console.WriteLine($"Departamento: {empleado1.Departamento}");

            Console.WriteLine("\nInformación del Empleado 2: Constructor con 3 atributos");
            Console.WriteLine($"ID: {empleado2.Id}");
            Console.WriteLine($"Nombre: {empleado2.Nombre}");
            Console.WriteLine($"Apellido: {empleado2.Apellido}");
            Console.WriteLine($"Puesto: {empleado2.Puesto}");
            Console.WriteLine($"Salario: {empleado2.Salario:C}");
            Console.WriteLine($"Departamento: {empleado2.Departamento}");

            Console.WriteLine("\nInformación del Empleado 3: Constructor con 4 atributos");
            Console.WriteLine($"ID: {empleado3.Id}");
            Console.WriteLine($"Nombre: {empleado3.Nombre}");
            Console.WriteLine($"Apellido: {empleado3.Apellido}");
            Console.WriteLine($"Puesto: {empleado3.Puesto}");
            Console.WriteLine($"Salario: {empleado3.Salario:C}");
            Console.WriteLine($"Departamento: {empleado3.Departamento}");

            Console.WriteLine("\nInformación del Empleado 4: Constructor con 5 atributos");
            Console.WriteLine($"ID: {empleado4.Id}");
            Console.WriteLine($"Nombre: {empleado4.Nombre}");
            Console.WriteLine($"Apellido: {empleado4.Apellido}");
            Console.WriteLine($"Puesto: {empleado4.Puesto}");
            Console.WriteLine($"Salario: {empleado4.Salario:C}");
            Console.WriteLine($"Departamento: {empleado4.Departamento}");

            Console.WriteLine("\nInformación del Empleado 5: Constructor con todos los atributos");
            Console.WriteLine($"ID: {empleado5.Id}");
            Console.WriteLine($"Nombre: {empleado5.Nombre}");
            Console.WriteLine($"Apellido: {empleado5.Apellido}");
            Console.WriteLine($"Puesto: {empleado5.Puesto}");
            Console.WriteLine($"Salario: {empleado5.Salario:C}");
            Console.WriteLine($"Departamento: {empleado5.Departamento}\n");

            #endregion Empleado
        }
    }
}