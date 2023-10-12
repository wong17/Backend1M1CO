namespace FirstStepsCSharp.Basic.DataTypes
{
    public class TypeCasting
    {
        public static void Main(string[] args)
        {
            /*
             * Consiste en convertir un tipo de dato en otro
             *
             * El casting implicito(automatico) se da entre estos tipos de datos:
             *      char -> int -> long -> float -> double
             * De menor tipo de dato a mayor tipo de dato
             *
             * El casting explicito(manual) se da entre estos tipos de datos:
             *      double -> float -> long -> int -> char
             * De mayor tipo de dato a menor tipo de dato
             *
             * Utilizando métodos de conversión
             */

            Console.WriteLine("-------------------- TypeCasting --------------------");

            // Casting implicito (automatico)
            char implicitCharValue = 'a';
            Console.WriteLine(implicitCharValue);
            // Convertir char -> int
            int implicitIntValue = implicitCharValue;
            Console.WriteLine(implicitIntValue);
            // Convertir int -> long
            long implicitLongValue = implicitIntValue;
            Console.WriteLine(implicitLongValue);
            // Convertir long -> float
            float implicitFloatValue = implicitLongValue;
            Console.Write(implicitFloatValue);
            // Convertir float -> double
            double implicitDoubleValue = implicitFloatValue;
            Console.WriteLine(implicitDoubleValue);

            Console.WriteLine();

            // Casting explicito (manual)
            double explicitDoubleValue = 1230.356777;
            Console.WriteLine(explicitDoubleValue);
            // Convertir double -> float
            float explicitFloatValue = (float)explicitDoubleValue;
            Console.WriteLine(explicitFloatValue);
            // Convertir float -> long
            long explicitLongValue = (long)explicitFloatValue;
            Console.WriteLine(explicitLongValue);
            // Convertir long -> int
            int explicitIntValue = (int)explicitLongValue;
            Console.WriteLine(explicitIntValue);
            // Convertir int -> char
            char explicitCharValue = (char)explicitIntValue;
            Console.WriteLine(explicitCharValue);

            Console.WriteLine();

            // Métodos de conversión

            Console.WriteLine(Convert.ToString(10)); // convert int to string
            Console.WriteLine(Convert.ToDouble(3.1416)); // convert int to double
            Console.WriteLine(Convert.ToInt32(170)); // convert double to int
            Console.WriteLine(Convert.ToString(true)); // convert bool to string
            Console.WriteLine(Convert.ToDecimal(2.7178)); // convert double to decimal
            // etc...

            Console.WriteLine();
        }
    }
}