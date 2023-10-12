namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class StringMethods
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- StringMethods --------------------");

            string text = "aeiou";
            // longitud del texto
            Console.WriteLine(text.Length);
            // convertir a minuscula el texto
            Console.WriteLine(text.ToLower());
            // convertir a mayuscula el texto
            Console.WriteLine(text.ToUpper());
            // reemplaza una letra o texto por otro (reemplaza las 'a' por 'u')
            Console.WriteLine(text.Replace("a", "u"));
            // devuelve true o false si contiene la letra 'a'
            Console.WriteLine(text.Contains("a"));
            // devuelve el caracter en la posición '2'
            Console.WriteLine(text.ElementAt(2));
            // devuelve el primer elemento
            Console.WriteLine(text.First());
            // devuelve el ultimo elemento
            Console.WriteLine(text.Last());
            // devuelve el indice del caracter indicado
            Console.WriteLine(text.IndexOf("u"));
            // etc...

            Console.WriteLine();
        }
    }
}