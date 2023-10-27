namespace ClasesObjetosPresentacion.MetodosGettersSetters
{
    public class EmpleadoMain
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("----------------------------- EJEMPLO EmpleadoMain -----------------------------\n");

            Empleado empleado1 = new();
            /* Damos valor a los atributos privados gracias a un método público, los Setters. */
            empleado1.SetId(1);
            empleado1.SetNombre("Jose");
            empleado1.SetNumeroCedula("001-232323-88888U");
            empleado1.SetSalario(10000.00f);

            /* Obtenemos valor de los atributos privados gracias a los Getters. */
            Console.WriteLine("Id: " + empleado1.GetId());
            Console.WriteLine("Nombre: " + empleado1.GetNombre());
            Console.WriteLine("Cedula: " + empleado1.GetNumeroCedula());
            Console.WriteLine("Salario: " + empleado1.GetSalario() + "\n");


            Empleado empleado2 = new Empleado();
            /* Setters para asignar valor */
            empleado2.SetId(2);
            empleado2.SetNombre("Ana");
            empleado2.SetNumeroCedula("002-545454-99999V");
            empleado2.SetSalario(12000.00f);
            /* Getters para obtener valor */
            Console.WriteLine("Datos del Empleado 2:");
            Console.WriteLine("Id: " + empleado2.GetId());
            Console.WriteLine("Nombre: " + empleado2.GetNombre());
            Console.WriteLine("Cédula: " + empleado2.GetNumeroCedula());
            Console.WriteLine("Salario: " + empleado2.GetSalario() + "\n");
        }
    }
}
