namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class NullableDataTypes
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- NullableDataTypes --------------------");

            /*
             * Por defecto los tipos de datos primitivos no aceptan el valor de null
             * para hacer que puedan almacenar el valor de 'null' debemos utilizar el
             * operador ?. 
             * 
             * De esta forma pueden almacenar su tipo de dato correspondiente y el valor
             * de 'null'.
             */

            /* Los siguientes casos dan error de compilación */
            //int age = null; 
            //long distance = null;
            //float discount = null; 
            //double value = null;
            //decimal price = null;
            //bool flag = null;
            //char letter = null;

            // string no da error pero Visual lo marca como warning (subrayado)
            string name = null;

            /* Estos casos ya no dan error de compilación */
            int? age = null; 
            long? distance = null;
            float? discount = null; 
            double? value = null;
            decimal? price = null;
            bool? flag = null;
            char? letter = null;

            // para eliminar el warning en el caso de string debemos agregar el ? como buena práctica
            string? name1 = null;

            Console.WriteLine(age);
            Console.WriteLine(distance);
            Console.WriteLine(discount);
            Console.WriteLine(value);
            Console.WriteLine(price);
            Console.WriteLine(flag);
            Console.WriteLine(letter);
            Console.WriteLine(name);
            Console.WriteLine(name1);

            Console.WriteLine();
        }
    }
}