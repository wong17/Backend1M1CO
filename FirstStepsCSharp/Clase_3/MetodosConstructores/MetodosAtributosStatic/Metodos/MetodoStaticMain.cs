namespace MetodosConstructores.MetodosAtributosStatic.Metodos
{
    public class MetodoStaticMain
    {
        public static void Main()
        {
            #region Calculadora

            var suma = Calculadora.Sumar(10, 10);
            var resta = Calculadora.Restar(12, 6);
            var multiplicacion = Calculadora.Multiplicar(2, 6);
            var division = Calculadora.Dividir(15, 3);
            var cuadrado = Calculadora.ElevarAlCuadrado(5.0);
            var raiz = Calculadora.CalcularRaizCuadrada(16.0);
            var potencia = Calculadora.CalcularPotencia(2.0, 3);

            /* 
             * Es posible crear objetos de la clase Calculadora pero no tiene 
             * ningun uso ya que los objetos no tienen métodos ni atributos 
             */
            Calculadora calculadora = new(); // No tiene uso este objeto
            

            Console.WriteLine("------------------------------ CALCULADORA ------------------------------");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicacion: {multiplicacion}");
            Console.WriteLine($"Division: {division}");
            Console.WriteLine($"Cuadrado: {cuadrado}");
            Console.WriteLine($"Raiz: {raiz}");
            Console.WriteLine($"Potencia: {potencia}\n");

            #endregion

            #region ConversorTemperatura

            var temperatura1 = ConversorTemperatura.CelsiusAFahrenheit("20");
            var temperatura2 = ConversorTemperatura.FahrenheitACelsius("43");

            /* 
             * Es posible crear objetos de la clase Calculadora pero no tiene 
             * ningun uso ya que los objetos no tienen métodos ni atributos 
             */
            ConversorTemperatura conversorTemperatura = new(); // No tiene uso el objeto

            Console.WriteLine("------------------------------ CONVERSOR TEMPERATURA ------------------------------");
            Console.WriteLine($"Celsius a Fahrenheit: {temperatura1}");
            Console.WriteLine($"Fahrenheit a Celsius: {temperatura2}\n");

            #endregion

            #region ConversorBase

            int decimalNumber = 10;
            string binario = ConversorBase.DecimalABinario(decimalNumber);
            int decimalDesdeBinario = ConversorBase.BinarioADecimal(binario);
            string octal = ConversorBase.DecimalAOctal(decimalNumber);
            int decimalDesdeOctal = ConversorBase.OctalADecimal(octal);

            /* 
             * Es posible crear objetos de la clase Calculadora pero no tiene 
             * ningun uso ya que los objetos no tienen métodos ni atributos 
             */
            ConversorBase conversorBase = new(); // No tiene uso el objeto

            Console.WriteLine("------------------------------ CONVERSOR BASE ------------------------------");
            Console.WriteLine($"Decimal a binario: {binario}");
            Console.WriteLine($"Binario a decimal: {decimalDesdeBinario}");
            Console.WriteLine($"Decimal a octal: {octal}");
            Console.WriteLine($"Octal a decimal: {decimalDesdeOctal}\n");

            #endregion

            #region GestionFechaHora

            DateTime ahora = GestionFechaHora.ObtenerFechaHoraActual();
            string nombreDiaSemana = GestionFechaHora.ObtenerNombreDiaSemana(ahora);
            int numeroDiaMes = GestionFechaHora.ObtenerNumeroDiaMes(ahora);
            string nombreMes = GestionFechaHora.ObtenerNombreMes(ahora);
            int anio = GestionFechaHora.ObtenerAnio(ahora);
            bool esBisiesto = GestionFechaHora.EsAnioBisiesto(anio);

            /* 
             * Es posible crear objetos de la clase Calculadora pero no tiene 
             * ningun uso ya que los objetos no tienen métodos ni atributos 
             */
            GestionFechaHora gestionFechaHora = new(); // No tiene uso el objeto

            Console.WriteLine("------------------------------ GESTION FECHA Y HORA ------------------------------");
            Console.WriteLine("Fecha y Hora Actual: " + ahora);
            Console.WriteLine("Nombre del Día de la Semana: " + nombreDiaSemana);
            Console.WriteLine("Número del Día en el Mes: " + numeroDiaMes);
            Console.WriteLine("Nombre del Mes: " + nombreMes);
            Console.WriteLine("Año: " + anio);
            Console.WriteLine("¿Es Año Bisiesto? " + esBisiesto + "\n");

            #endregion
        }
    }
}
