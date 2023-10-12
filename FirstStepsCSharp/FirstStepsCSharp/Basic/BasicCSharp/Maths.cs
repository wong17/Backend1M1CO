namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class Maths
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- Maths --------------------");
            // Clase Math de la api de C#

            // Algunas constantes
            Console.WriteLine(Math.Tau);
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);
            // Algunos métodos de la clase math
            Console.WriteLine(Math.Min(1, 10));
            Console.WriteLine(Math.Max(1, 10));
            Console.WriteLine(Math.Abs(-6));

            Console.WriteLine(Math.Cos(0));
            Console.WriteLine(Math.Sin(1));
            Console.WriteLine(Math.Tan(0));

            Console.WriteLine(Math.Exp(2));
            Console.WriteLine(Math.Log(10));
            Console.WriteLine(Math.Round(2.556));
            // etc...

            Console.WriteLine();
        }
    }
}