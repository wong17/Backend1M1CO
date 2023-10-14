namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class DataTypes
    {
        public static void Main(string[] args)
        {
            /*
             * Tipo de datos primitivos más utilizados
             * 
             * int:       precisión -2,147,483,648 to 2,147,483,647
             * long:      precisión -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
             * 
             * float:     precisión ~6-9 digits 4 bytes
             * double:    precisión ~15-17 digits 8 bytes
             * decimal:   precisión 28-29 digits 16 bytes
             * 
             * bool:   true or false
             * 
             * char
             * string
             */

            Console.WriteLine("-------------------- DataTypes --------------------");

            int age = 18;
            long distance = 999000000000;
            Console.WriteLine("Edad: " + age);
            Console.WriteLine("Distancia: " + distance);
            //
            float discount = 15f; // 'f' al final para indicar que es float
            double value = 25.9876;
            decimal price = 12000233.45m; // 'm' al final para indicar que es decimal
            Console.WriteLine("Descuento: " + discount);
            Console.WriteLine("Valor: " + value);
            Console.WriteLine("Precio" + price);
            //
            bool flag = false;
            Console.WriteLine("Condición: " + flag);
            //
            char letter = 'A';
            string name = "Ruben";
            //
            Console.WriteLine("Letra: " + letter);
            Console.WriteLine("Nombre: " + name);
            //
            const string password = "password"; // 'const' se utiliza para declarar constantes
            const string email = "email";
            Console.WriteLine("Contraseña constante: " + password);
            Console.WriteLine("Correo constante: " + email);
            //
            Console.WriteLine();

            /* Declarar variables utilizando la palabra reservada var 
             * 
             * Podemos declarar variables sin especificar su tipo de datos y automaticamente el compilador de C#
             * lo hara por nosotros, esto lo hace en base al valor que le asignemos a la variable.
             */
            var intVar = 10;
            var longVar = 10000;
            var floatVar = 3000.444f;
            var doubleVar = 5555.6788;
            var decimalVar = 123344.555m;
            var charVar = "x";
            var stringVar = "Computación";
            var boolVar = true;

            Console.WriteLine(intVar);
            Console.WriteLine(longVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(decimalVar); 
            Console.WriteLine(charVar);
            Console.WriteLine(stringVar);
            Console.WriteLine(boolVar);

            Console.WriteLine();
        }
    }
}