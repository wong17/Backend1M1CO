namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class ForEachLoop
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- ForEachLoop --------------------");

            /* 
             * El bucle foreach nos sirve para recorrer un arreglo sin declarar condición alguna ya que
             * por defecto se recorre desde el primer elemento hasta el ultimo y tampoco necesitamos
             * declarar una variable para el indice del arreglo.
             * 
             * Debemos crear una variable del mismo tipo del arreglo y en cada iteración en esta variable que
             * declaramos se ira almacenando el elemento de la posición actual del arreglo.
             */

            string[] array = new string[3] { "Hola", "Mundo", "Nuevamente desde C#" };
            // variable de tipo string 'str' para recorrer arreglo string 'array'
            foreach (string str in array)
            {
                Console.WriteLine(str); // imprimimos cada uno de los elementos ["Hola", "Mundo", "Nuevamente desde C#"]
            }
        }
    }
}