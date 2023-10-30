namespace MetodosConstructores.Constructores.CreacionDeConstructor
{
    public class CreacionDeConstructorMain
    {
        public static void Main()
        {
            /* Creación de objetos utilizando el constructor con parámetros */

            #region Estudiante

            /* Creación de objetos utilizando el constructor que recibe todos los atributos como parámetros */
            Estudiante estudiante1 = new Estudiante(1, "Juan Pérez", 20, "12345", "Ingeniería Informática", "Grupo A");
            /* Otra forma de hacerlo omitiendo el nombre de la clase */
            Estudiante estudiante2 = new(2, "María López", 21, "67890", "Medicina", "Grupo B");
            Estudiante estudiante3 = new(3, "Carlos García", 22, "54321", "Derecho", "Grupo C");

            // Mostrar la información de los estudiantes
            Console.WriteLine("------------------------------------ Estudiante -------------------------------------");
            Console.WriteLine("Información del Estudiante 1:");
            Console.WriteLine($"ID: {estudiante1.Id}");
            Console.WriteLine($"Nombre: {estudiante1.Nombre}");
            Console.WriteLine($"Edad: {estudiante1.Edad} años");
            Console.WriteLine($"Número de Carnet: {estudiante1.NumeroDeCarnet}");
            Console.WriteLine($"Carrera: {estudiante1.Carrera}");
            Console.WriteLine($"Grupo: {estudiante1.Grupo}");

            Console.WriteLine("\nInformación del Estudiante 2:");
            Console.WriteLine($"ID: {estudiante2.Id}");
            Console.WriteLine($"Nombre: {estudiante2.Nombre}");
            Console.WriteLine($"Edad: {estudiante2.Edad} años");
            Console.WriteLine($"Número de Carnet: {estudiante2.NumeroDeCarnet}");
            Console.WriteLine($"Carrera: {estudiante2.Carrera}");
            Console.WriteLine($"Grupo: {estudiante2.Grupo}");

            Console.WriteLine("\nInformación del Estudiante 3:");
            Console.WriteLine($"ID: {estudiante3.Id}");
            Console.WriteLine($"Nombre: {estudiante3.Nombre}");
            Console.WriteLine($"Edad: {estudiante3.Edad} años");
            Console.WriteLine($"Número de Carnet: {estudiante3.NumeroDeCarnet}");
            Console.WriteLine($"Carrera: {estudiante3.Carrera}");
            Console.WriteLine($"Grupo: {estudiante3.Grupo}\n");

            #endregion

            #region Producto

            /* Creación de objetos utilizando el constructor que recibe todos los atributos como parámetros */
            Producto producto1 = new Producto(101, "Producto A", 19.99, 50, "Este es el producto A", "Electrónica");
            /* Otra forma de hacerlo omitiendo el nombre de la clase */
            Producto producto2 = new(202, "Producto B", 9.99, 100, "Producto B en oferta", "Ropa");
            Producto producto3 = new(303, "Producto C", 29.99, 30, "Producto C de alta calidad", "Hogar");

            // Mostrar la información de los productos
            Console.WriteLine("------------------------------------ Producto -------------------------------------");
            Console.WriteLine("Información del Producto 1:");
            Console.WriteLine($"Código: {producto1.Codigo}");
            Console.WriteLine($"Nombre: {producto1.Nombre}");
            Console.WriteLine($"Precio: {producto1.Precio:C}");
            Console.WriteLine($"Cantidad en Stock: {producto1.CantidadEnStock}");
            Console.WriteLine($"Descripción: {producto1.Descripcion}");
            Console.WriteLine($"Categoría: {producto1.Categoria}");

            Console.WriteLine("\nInformación del Producto 2:");
            Console.WriteLine($"Código: {producto2.Codigo}");
            Console.WriteLine($"Nombre: {producto2.Nombre}");
            Console.WriteLine($"Precio: {producto2.Precio:C}");
            Console.WriteLine($"Cantidad en Stock: {producto2.CantidadEnStock}");
            Console.WriteLine($"Descripción: {producto2.Descripcion}");
            Console.WriteLine($"Categoría: {producto2.Categoria}");

            Console.WriteLine("\nInformación del Producto 3:");
            Console.WriteLine($"Código: {producto3.Codigo}");
            Console.WriteLine($"Nombre: {producto3.Nombre}");
            Console.WriteLine($"Precio: {producto3.Precio:C}");
            Console.WriteLine($"Cantidad en Stock: {producto3.CantidadEnStock}");
            Console.WriteLine($"Descripción: {producto3.Descripcion}");
            Console.WriteLine($"Categoría: {producto3.Categoria}\n");

            #endregion

            #region Cliente

            /* Creación de objetos utilizando el constructor que recibe todos los atributos como parámetros */
            Cliente cliente1 = new Cliente(1, "Juan", "Pérez", "juan@example.com", "555-123-4567", "Calle 123, Ciudad A");
            /* Otra forma de hacerlo omitiendo el nombre de la clase */
            Cliente cliente2 = new(2, "María", "López", "maria@example.com", "555-987-6543", "Avenida XYZ, Ciudad B");
            Cliente cliente3 = new(3, "Carlos", "García", "carlos@example.com", "555-555-5555", "Calle Principal, Ciudad C");

            // Mostrar la información de los clientes
            Console.WriteLine("------------------------------------ Cliente -------------------------------------");
            Console.WriteLine("Información del Cliente 1:");
            Console.WriteLine($"ID: {cliente1.Id}");
            Console.WriteLine($"Nombre: {cliente1.Nombre}");
            Console.WriteLine($"Apellido: {cliente1.Apellido}");
            Console.WriteLine($"Email: {cliente1.Email}");
            Console.WriteLine($"Teléfono: {cliente1.Telefono}");
            Console.WriteLine($"Dirección: {cliente1.Direccion}");

            Console.WriteLine("\nInformación del Cliente 2:");
            Console.WriteLine($"ID: {cliente2.Id}");
            Console.WriteLine($"Nombre: {cliente2.Nombre}");
            Console.WriteLine($"Apellido: {cliente2.Apellido}");
            Console.WriteLine($"Email: {cliente2.Email}");
            Console.WriteLine($"Teléfono: {cliente2.Telefono}");
            Console.WriteLine($"Dirección: {cliente2.Direccion}");

            Console.WriteLine("\nInformación del Cliente 3:");
            Console.WriteLine($"ID: {cliente3.Id}");
            Console.WriteLine($"Nombre: {cliente3.Nombre}");
            Console.WriteLine($"Apellido: {cliente3.Apellido}");
            Console.WriteLine($"Email: {cliente3.Email}");
            Console.WriteLine($"Teléfono: {cliente3.Telefono}");
            Console.WriteLine($"Dirección: {cliente3.Direccion}\n");

            #endregion

            #region Empleado

            /* Creación de objetos utilizando el constructor que recibe todos los atributos como parámetros */
            Empleado empleado1 = new Empleado(1, "Ana", "Gómez", "Analista de Datos", 50000.0, "Tecnología");
            /* Otra forma de hacerlo omitiendo el nombre de la clase */
            Empleado empleado2 = new(2, "David", "López", "Diseñador Gráfico", 45000.0, "Diseño");
            Empleado empleado3 = new(3, "Laura", "Martínez", "Gerente de Ventas", 60000.0, "Ventas");

            // Mostrar la información de los empleados
            Console.WriteLine("------------------------------------ Empleado -------------------------------------");
            Console.WriteLine("Información del Empleado 1:");
            Console.WriteLine($"ID: {empleado1.Id}");
            Console.WriteLine($"Nombre: {empleado1.Nombre} {empleado1.Apellido}");
            Console.WriteLine($"Puesto: {empleado1.Puesto}");
            Console.WriteLine($"Salario: {empleado1.Salario:C}");
            Console.WriteLine($"Departamento: {empleado1.Departamento}");

            Console.WriteLine("\nInformación del Empleado 2:");
            Console.WriteLine($"ID: {empleado2.Id}");
            Console.WriteLine($"Nombre: {empleado2.Nombre} {empleado2.Apellido}");
            Console.WriteLine($"Puesto: {empleado2.Puesto}");
            Console.WriteLine($"Salario: {empleado2.Salario:C}");
            Console.WriteLine($"Departamento: {empleado2.Departamento}");

            Console.WriteLine("\nInformación del Empleado 3:");
            Console.WriteLine($"ID: {empleado3.Id}");
            Console.WriteLine($"Nombre: {empleado3.Nombre} {empleado3.Apellido}");
            Console.WriteLine($"Puesto: {empleado3.Puesto}");
            Console.WriteLine($"Salario: {empleado3.Salario:C}");
            Console.WriteLine($"Departamento: {empleado3.Departamento}\n");

            #endregion

        }
    }
}
