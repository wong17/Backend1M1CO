namespace ClasesObjetosPresentacion.MetodosGettersSetters
{
    public class EmployeeMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------------------------- EJEMPLO EmployeeMain -----------------------------\n");

            Employee employee = new();
            // Asignamos valor a través de la propiedad
            employee.Id = 1;
            employee.Nombre = "Jose";
            employee.NumeroCedula = "001-121289-2222U";
            employee.Salario = 12300.00f;
            // Obtenemos valor por la misma propiedad
            Console.WriteLine("Id: " + employee.Id);
            Console.WriteLine("Nombre: " + employee.Nombre);
            Console.WriteLine("NumeroCedula: " + employee.NumeroCedula);
            Console.WriteLine("Salario: " + employee.Salario);

            Employee employee2 = new()
            {
                // Asignamos valor a través de la propiedad
                Id = 2,
                Nombre = "Felipe",
                NumeroCedula = "001-122489-2452U",
                Salario = 22300.00f
            };
            // Obtenemos valor por la misma propiedad
            Console.WriteLine("Id: " + employee2.Id);
            Console.WriteLine("Nombre: " + employee2.Nombre);
            Console.WriteLine("NumeroCedula: " + employee2.NumeroCedula);
            Console.WriteLine("Salario: " + employee2.Salario);
        }
    }
}
