namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class FunctionsWithOptionalParameters
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- FunctionsWithOptionalParameters --------------------");

            Sum(1, 1);
            Sum(1, 1, 1);

            Substract(10, 5);
            Substract(10, 5, 2);

            Multiply(10, 5);
            Multiply(10, 5, 2);

            SayHello("Juan");
            SayHello("Juan", "Hello");

            Console.WriteLine();
        }

        /* 
         * Función que suma 3 números, donde los 2 primeros números son obligatorios 
         * y el tercero es opcional, el tercer parámetro se puede pasar o no, sino se pasa
         * c = 0
         * 
         * Ej: Sum(1,1);    // 1 + 1 + 0
         *     Sum(1,1,1);  // 1 + 1 + 1
         *     
         * Podemos asignar valores por defecto a los demás parámetros de igua forma. Los campos
         * con parámetros opcionales deben de ir al final, es decir primero los parámetros obligatorios
         * y después los opcionales.
         */
        public static void Sum(int a, int b, int c = 0)
        {
            Console.WriteLine("Suma: " + (a + b + c));
        }

        public static void Substract(int a, int b, int c = 0)
        {
            Console.WriteLine("Resta: " + (a - b - c));
        }

        public static void Multiply(int a, int b, int c = 1)
        {
            Console.WriteLine("Multiplicar: " + (a * b * c));
        }

        /*
         * Ej: SayHello("Juan");            // Saludar: Hola Juan
         *     SayHello("Juan","Hello");    // Saludar: Hello Juan
         */
        public static void SayHello(string name, string salute = "Hola")
        {
            Console.WriteLine("Saludar: " + salute + " " + name);
        }
    }
}