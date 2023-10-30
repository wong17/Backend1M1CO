using MetodosConstructores.MetodosAtributosStatic.Clases;

namespace MetodosConstructoresHerencia.MetodosAtributosStatic.Clases
{
    public class ClasesStaticMain
    {
        public static void Main()
        {
            var suma = Calculadora.Sumar(10, 10);
            var resta = Calculadora.Restar(12, 6);
            var multiplicacion = Calculadora.Multiplicar(2, 6);
            var division = Calculadora.Dividir(15, 3);
            var cuadrado = Calculadora.ElevarAlCuadrado(5.0);
            var raiz = Calculadora.CalcularRaizCuadrada(16.0);
            var potencia = Calculadora.CalcularPotencia(2.0, 3);

            /* 
             * Ya no es posible crear objetos de la clase Calculadora porque la clase ha sido
             * marcada como 'static' de esta forma evitamos crear objetos innecesarios que a parte de
             * no tener ningun uso no ocupan memoria. 
             */
            //Calculadora calculadora = new(); // ERROR DE COMPILACIÓN NO SE PUEDEN CREAR VARIABLES DE CLASES STATIC


            Console.WriteLine("------------------------------ CALCULADORA STATIC ------------------------------");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicacion: {multiplicacion}");
            Console.WriteLine($"Division: {division}");
            Console.WriteLine($"Cuadrado: {cuadrado}");
            Console.WriteLine($"Raiz: {raiz}");
            Console.WriteLine($"Potencia: {potencia}\n");

            // ------------------------------------------------------------------------------------------------

            var temperatura1 = ConversorTemperatura.CelsiusAFahrenheit("20");
            var temperatura2 = ConversorTemperatura.FahrenheitACelsius("43");

            /* 
             * Ya no es posible crear objetos de la clase ConversorTemperatura porque la clase ha sido
             * marcada como 'static' de esta forma evitamos crear objetos innecesarios que a parte de
             * no tener ningun uso no ocupan memoria. 
             */
            //ConversorTemperatura conversorTemperatura = new(); // ERROR DE COMPILACIÓN NO SE PUEDEN CREAR VARIABLES DE CLASES STATIC

            Console.WriteLine("------------------------------ CONVERSOR TEMPERATURA STATIC ------------------------------");
            Console.WriteLine($"Celsius a Fahrenheit: {temperatura1}");
            Console.WriteLine($"Fahrenheit a Celsius: {temperatura2}\n");

        }
    }
}
