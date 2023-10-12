namespace FirstStepsCSharp.Basic.DataTypes
{
    public class UserInput
    {
        public static void Main(string[] args)
        {
            /*
             * Leer entrada por consola del usuario utilizando Console.Readline();
             */

            Console.WriteLine("-------------------- UserInput --------------------");

            // Leemos cadena de texto
            Console.WriteLine("Ingrese nombre de usuario:");
            string? userName = Console.ReadLine();
            Console.WriteLine("Nombre de usuario: " + userName);

            // Convertimos entrada a un tipo de dato
            Console.WriteLine("Ingrese su edad:");
            int stringToInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Edad: " + stringToInt);

            Console.WriteLine("Ingrese un valor float:");
            float stringToFloat = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Float: " + stringToFloat);

            Console.WriteLine("Ingrese un valor double:");
            double stringToDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Double: " + stringToDouble);

            Console.WriteLine("Ingrese un valor decimal:");
            decimal stringToDecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Decimal: " + stringToDecimal);
            //etc...

            /* Mas ejemplos, otra forma de convertir una cadena */
            Console.WriteLine("\n Convertir string a un tipo de dato");
            Console.WriteLine(int.Parse("13"));
            Console.WriteLine(float.Parse("3.14"));
            Console.WriteLine(double.Parse("3.1416"));
            Console.WriteLine(decimal.Parse("3.1416"));
            Console.WriteLine(bool.Parse("false"));
            Console.WriteLine(char.Parse("a"));

            /* Mas ejemplos, convertir un tipo de dato a string utilizando el método ToString() */
            Console.WriteLine("\nConvertir un tipo de dato a string");
            Console.WriteLine(stringToInt.ToString());
            Console.WriteLine(stringToFloat.ToString());
            Console.WriteLine(stringToDouble.ToString());
            Console.WriteLine(stringToDecimal.ToString());

            Console.WriteLine();
        }
    }
}