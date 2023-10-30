namespace MetodosConstructores.MetodosAtributosStatic.Metodos
{
    public class ConversorTemperatura
    {
        public static double CelsiusAFahrenheit(string temperaturaCelsius)
        {
            // Convertir texto a double para operar
            double celsius = double.Parse(temperaturaCelsius);

            // Convertir de Celsius a Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitACelsius(string temperaturaFahrenheit)
        {
            // Convertir texto a double para operar
            double fahrenheit = Double.Parse(temperaturaFahrenheit);

            // Convertir de Fahrenheit a Celsius.
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }
}
