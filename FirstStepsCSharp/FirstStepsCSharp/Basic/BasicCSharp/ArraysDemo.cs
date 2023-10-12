namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class ArraysDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- ArraysDemo --------------------");

            // declaración de arreglos de los tipos de datos más utilizados
            int[] IntArray = new int[3] { 10, 20, 30 };
            long[] LongArray = new long[3] { 11, 22, 33 };
            float[] FloatArray = new float[3] { 110.1f, 220.2f, 330.3f };
            double[] DoubleArray = new double[3] { 1.1234, 2.1234, 3.1234 };
            decimal[] DecimalArray = new decimal[3] { 1.12345m, 2.12345m, 3.12345m };
            char[] CharArray = new char[3] { 'a', 'b', 'c' };
            bool[] BooleanArray = new bool[3] { true, false, true };
            string[] StringArray2 = new string[3] { "Hola", "Mundo", "Nuevamente desde C#"};

            //tambien podemos asignar valor igual que en C, a cada indice
            // ej: IntArray[0] = 10;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(IntArray[i] + " " + LongArray[i] + " " + FloatArray[i] + " " + DoubleArray[i] 
                    + " " + DecimalArray[i] + " " + CharArray[i] + " " + BooleanArray[i] + " " + StringArray2[i]);
            }
            Console.WriteLine();

            /* Otras formas de declarar un arreglo (lo mismo para los otros tipos de dato) */
            string[] cars = new string[4];
            string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };

            for(var i = 0;i < 4; i++) // (revisar DataTypes.cs para ver uso de 'var') 
            {
                Console.WriteLine(cars1[i] + " " + cars2[i] + " " + cars3[3]);
            }

            /*Ordenar un arreglo*/
            Array.Sort(StringArray2);
            // imprimir arreglo de cadenas ordenado (se imprime igual porque ya esta ordenado en esta caso)
            for(var i = 0; i < 3 ; i++)
            {
                Console.WriteLine(StringArray2[i]);
            }

            Console.WriteLine();
        }
    }
}