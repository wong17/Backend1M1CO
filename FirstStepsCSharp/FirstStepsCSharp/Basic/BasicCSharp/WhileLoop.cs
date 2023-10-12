namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class WhileLoop
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- WhileLoop --------------------");

            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("Contador: " + ++counter);
            }

            Console.WriteLine();
        }
    }
}