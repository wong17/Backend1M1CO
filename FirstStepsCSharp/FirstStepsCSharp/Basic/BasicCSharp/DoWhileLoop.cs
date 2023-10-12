namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class DoWhileLoop
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- DoWhileLoop --------------------");

            int counter = 0;

            do
            {
                Console.WriteLine("Contador: " + ++counter);
            } while (counter < 10);

            Console.WriteLine();
        }
    }
}