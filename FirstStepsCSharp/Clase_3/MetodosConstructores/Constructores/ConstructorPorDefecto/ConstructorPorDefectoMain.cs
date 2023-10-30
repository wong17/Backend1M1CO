namespace MetodosConstructores.Constructores.ConstructorPorDefecto
{
    public class ConstructorPorDefectoMain
    {
        public static void Main()
        {
            /* Creación de objetos utilizando el constructor por defecto (sin parámetros) */

            #region Estudiante

            /* Primera forma de crear un objeto */
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Id = 1;
            estudiante1.Nombre = "Juan";
            estudiante1.Edad = 20;
            estudiante1.NumeroDeCarnet = "A12345";
            estudiante1.Carrera = "Ingeniería Informática";
            estudiante1.Grupo = "Grupo A";

            /* Segunda forma de crear un objeto */
            Estudiante estudiante2 = new();
            estudiante2.Id = 2;
            estudiante2.Nombre = "María";
            estudiante2.Edad = 22;
            estudiante2.NumeroDeCarnet = "B67890";
            estudiante2.Carrera = "Psicología";
            estudiante2.Grupo = "Grupo B";

            /* Tercera forma de crear un objeto */
            Estudiante estudiante3 = new()
            {
                Id = 3,
                Nombre = "Carlos",
                Edad = 21,
                NumeroDeCarnet = "C54321",
                Carrera = "Derecho",
                Grupo = "Grupo C"
            };

            /* Mostrar la información de los estudiantes */
            Console.WriteLine("\n------------------------------------ Estudiante -------------------------------------");
            Console.WriteLine("Información de Estudiante 1:");
            Console.WriteLine($"ID: {estudiante1.Id}");
            Console.WriteLine($"Nombre: {estudiante1.Nombre}");
            Console.WriteLine($"Edad: {estudiante1.Edad}");
            Console.WriteLine($"Número de Carnet: {estudiante1.NumeroDeCarnet}");
            Console.WriteLine($"Carrera: {estudiante1.Carrera}");
            Console.WriteLine($"Grupo: {estudiante1.Grupo}");

            Console.WriteLine("\nInformación de Estudiante 2:");
            Console.WriteLine($"ID: {estudiante2.Id}");
            Console.WriteLine($"Nombre: {estudiante2.Nombre}");
            Console.WriteLine($"Edad: {estudiante2.Edad}");
            Console.WriteLine($"Número de Carnet: {estudiante2.NumeroDeCarnet}");
            Console.WriteLine($"Carrera: {estudiante2.Carrera}");
            Console.WriteLine($"Grupo: {estudiante2.Grupo}");

            Console.WriteLine("\nInformación de Estudiante 3:");
            Console.WriteLine($"ID: {estudiante3.Id}");
            Console.WriteLine($"Nombre: {estudiante3.Nombre}");
            Console.WriteLine($"Edad: {estudiante3.Edad}");
            Console.WriteLine($"Número de Carnet: {estudiante3.NumeroDeCarnet}");
            Console.WriteLine($"Carrera: {estudiante3.Carrera}");
            Console.WriteLine($"Grupo: {estudiante3.Grupo}\n");

            #endregion

            #region Producto

            Producto producto1 = new Producto();
            producto1.Codigo = 101;
            producto1.Nombre = "Producto A";
            producto1.Precio = 19.99;
            producto1.CantidadEnStock = 50;
            producto1.Descripcion = "Este es el producto A";
            producto1.Categoria = "Electrónica";

            Producto producto2 = new();
            producto2.Codigo = 202;
            producto2.Nombre = "Producto B";
            producto2.Precio = 9.99;
            producto2.CantidadEnStock = 100;
            producto2.Descripcion = "Producto B en oferta";
            producto2.Categoria = "Ropa";

            Producto producto3 = new()
            {
                Codigo = 303,
                Nombre = "Producto C",
                Precio = 29.99,
                CantidadEnStock = 30,
                Descripcion = "Producto C de alta calidad",
                Categoria = "Hogar"
            };

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

            /* Este objeto tiene los valores por defecto asignados en el constructor */
            Cliente cliente1 = new();

            Cliente cliente2 = new()
            {
                Id = 2,
                Nombre = "María",
                Apellido = "López",
                Email = "maria@example.com",
                Telefono = "555-987-6543",
                Direccion = "Avenida XYZ, Ciudad B"
            };

            Cliente cliente3 = new()
            {
                Id = 3,
                Nombre = "Carlos",
                Apellido = "García",
                Email = "carlos@example.com",
                Telefono = "555-555-5555",
                Direccion = "Calle Principal, Ciudad C"
            };

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

            /* Este objeto tiene los valores por defecto asignados en el constructor */
            Empleado empleado1 = new();

            Empleado empleado2 = new()
            {
                Id = 2,
                Nombre = "David",
                Apellido = "López",
                Puesto = "Diseñador Gráfico",
                Salario = 45000.0,
                Departamento = "Diseño"
            };

            Empleado empleado3 = new()
            {
                Id = 3,
                Nombre = "Laura",
                Apellido = "Martínez",
                Puesto = "Gerente de Ventas",
                Salario = 60000.0,
                Departamento = "Ventas"
            };

            // Mostrar la información de los empleados
            Console.WriteLine("------------------------------------ Empleado -------------------------------------");
            Console.WriteLine("Información del Empleado 1:");
            Console.WriteLine($"ID: {empleado1.Id}");
            Console.WriteLine($"Nombre: {empleado1.Nombre}");
            Console.WriteLine($"Apellido: {empleado1.Apellido}");
            Console.WriteLine($"Puesto: {empleado1.Puesto}");
            Console.WriteLine($"Salario: {empleado1.Salario:C}");
            Console.WriteLine($"Departamento: {empleado1.Departamento}");

            Console.WriteLine("\nInformación del Empleado 2:");
            Console.WriteLine($"ID: {empleado2.Id}");
            Console.WriteLine($"Nombre: {empleado2.Nombre}");
            Console.WriteLine($"Apellido: {empleado2.Apellido}");
            Console.WriteLine($"Puesto: {empleado2.Puesto}");
            Console.WriteLine($"Salario: {empleado2.Salario:C}");
            Console.WriteLine($"Departamento: {empleado2.Departamento}");

            Console.WriteLine("\nInformación del Empleado 3:");
            Console.WriteLine($"ID: {empleado3.Id}");
            Console.WriteLine($"Nombre: {empleado3.Nombre}");
            Console.WriteLine($"Apellido: {empleado3.Apellido}");
            Console.WriteLine($"Puesto: {empleado3.Puesto}");
            Console.WriteLine($"Salario: {empleado3.Salario:C}");
            Console.WriteLine($"Departamento: {empleado3.Departamento}\n");


            #endregion

        }
    }
}
