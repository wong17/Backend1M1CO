namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class ConsoleOutput
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- ConsoleOutput --------------------");

            // Mostrar mensaje por consola sin salto de linea
            Console.Write("Hola Mundo desde c#");
            Console.Write(" Suma: " + (10 + 5));
            Console.Write(" Resta: " + (10 - 5));
            Console.Write(" Multiplicación: " + (10 * 5));
            Console.Write(" División: " + (10 / 5));

            // Mostrar mensaje por consola con salto de linea
            Console.WriteLine("Hola Mundo desde c#");
            Console.WriteLine("Suma: " + (10 + 5));
            Console.WriteLine("Resta: " + (10 - 5));
            Console.WriteLine("Multiplicación: " + (10 * 5));
            Console.WriteLine("División: " + (10 / 5));
            Console.WriteLine("Comparación: " + (10 > 5));

            Console.WriteLine();
        }
    }
}