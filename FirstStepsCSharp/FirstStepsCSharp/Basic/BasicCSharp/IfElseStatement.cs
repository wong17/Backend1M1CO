namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class IfElseStatement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- IfElseStatement --------------------");

            int age = 18;

            if (age == 18)
            {
                Console.WriteLine("Tienes 18 años");
            } else if (age < 18)
            {
                Console.WriteLine("Tienes menos de 18 años");
            } else if (age > 18)
            {
                Console.WriteLine("Tienes mas de 18 años");
            }

            Console.WriteLine();
        }
    }
}