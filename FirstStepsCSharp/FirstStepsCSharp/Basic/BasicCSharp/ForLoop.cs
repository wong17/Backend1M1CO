namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class ForLoop
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- ForLoop --------------------");

            // for simple
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Contador: " + (i + 1));
            }
            Console.WriteLine();

            // for con varias variables dentro
            for (int i = 0, j = 10; i <= 10; i++, j--)
            {
                Console.WriteLine("Valor de i: " +  i + " valor de j: " + j);
            }
            Console.WriteLine();
        }
    }
}