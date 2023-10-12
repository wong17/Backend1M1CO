namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class TernaryOperatorStatement
    {
        public static void Main(string[] args)
        {
            /*
             * Operador ternario, es básicamente un if else pero que retorna un valor
             * 
             * Sintaxis:
             * variable = (condition) ? expressionTrue :  expressionFalse;
             */

            Console.WriteLine("-------------------- TernaryOperatorStatement --------------------");

            // Caso simple
            int age = 18;
            string text = (age >= 18) ? "Eres mayor de edad" : "Eres menor de edad";
            Console.WriteLine("Texto: " + text);

            // Imprimir retorno sin almacenar
            double distance = 100.456;
            Console.WriteLine(distance > 120 ? "Esta lejos" : "No esta tan lejos");

            // Multiples condiciones
            double price = 21; // entra en el caso ':' y luego evalua nuevamente la siguiente condición y entra en '?'
            string message = price == 20 ? "Esta a buen precio" : (price > 20 ? "Esta muy caro" : "Esta barato");
            Console.WriteLine(message);

            // 
            int x = 10, y = 20;
            int result = x > y ? x + 100 : y + 50; // entra en el segundo caso ':' y retorna y + 50
            Console.WriteLine(result);

            Console.WriteLine();
        }
    }
}