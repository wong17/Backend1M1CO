namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class StringInterpolation
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- StringInterpolation --------------------");

            /*
             * Otra forma de concatenar variables y texto para imprimir por consola, es utilizar
             * la interpolación, para ello utilizamos el signo '$' seguido de comillas dobles $"" y
             * donde vayamos a insertar el contenido de la variable ponemos llaves {variable}, ej:
             */

            int age = 42;
            string name = "David";
            string email = "david@gmail.com";

            Console.WriteLine($"Hola, me llamo {name}, tengo la edad de {age} años y este es mi correo {email}");

            /* 
             * Tambien podemos realizar operaciones aritmeticas o logicas, es decir evaluar 
             * condiciones utilizando el operador ternario.
             */
            int a = 10, b = 5;
            Console.WriteLine($"La suma entre a y b es { a + b }");

            int distance = 10; // 10 km
            // Resultado: La universidad esta lejos de mi casa.
            Console.WriteLine($"La universidad esta { (distance >= 5 ? "lejos" : "cerca")} de mi casa.");

            // Tipo de dato DateTime para almacenar fechas, es una clase.
            // Tambien se puede especificar un formato de la cadena al hacer interpolación, en este caso
            // para darle formato a la fecha lo hacemos de esta forma:
            // {<variable-interpolacion>:<formato-cadena>}
            var date = new DateTime(1731, 11, 25);
            Console.WriteLine($"El {date:dddd, MMMM dd, yyyy} L. Euler utilizo la letra e para nombrar la constante {Math.E}.");

            Console.WriteLine();
        }
    }
}
