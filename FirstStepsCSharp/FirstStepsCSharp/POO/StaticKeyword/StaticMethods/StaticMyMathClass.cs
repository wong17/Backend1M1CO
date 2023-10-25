namespace FirstStepsCSharp.POO.StaticKeyword.StaticMethods
{
    public class StaticMyMathClass
    {
        public static void main(string[] args)
        {
            /* 
             * Para utilizar un método estatico lo hacemos con el nombre de la clase
             * seguido de un . y el nombre del método. 
             * 
             * El método debe ser "public" de lo contrario no podremos utilizarlo de ninguna
             * forma.
             */

            Console.WriteLine($"Suma: {MyMathClass.Sum(3, 3)}");
            Console.WriteLine($"Resta: {MyMathClass.Substract(3, 3)}");
            Console.WriteLine($"Multiplicación: {MyMathClass.Multiply(3, 3)}");
            Console.WriteLine($"División: {MyMathClass.Divide(3, 3)}");
            // el método Pow de la clase MyMathClass es inaccesible desde cualquier lado que no sea la misma clase
        }
    }
}