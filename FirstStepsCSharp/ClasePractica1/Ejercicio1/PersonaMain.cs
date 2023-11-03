namespace ClasePractica1.Ejercicio1
{
    public class PersonaMain
    {
        public static void Main()
        {
            Console.WriteLine("-------------------------------- Ejercicio 1 - Persona --------------------------------\n");

            /* Creación de objetos de tipo Persona */
            Persona persona1 = new("Jose", "Perez", "001-230489-1236U", 89);
            Persona persona2 = new("Ivan", "Lopez", "001-130899-1226U", 99);
            /* Mostrar información de las personas */
            persona1.ImprimirDatos();
            persona2.ImprimirDatos();
        }
    }
}
