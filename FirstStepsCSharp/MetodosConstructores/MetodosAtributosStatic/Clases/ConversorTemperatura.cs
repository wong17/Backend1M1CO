namespace MetodosConstructores.MetodosAtributosStatic.Clases
{
    /* 
     * Al declarar la clase como 'static' ya no es posible crear objetos de esta clase 
     * esto se suele hacer en clases que contienen todos sus métodos static o que solo tienen
     * constantes static, ya que no tiene utilidad alguna crear objetos que no tienen métodos ni
     * atributos, es decir objetos que no sirven para nada solo para reservar más memoria de forma
     * innecesaria. 
     * 
     * Entonces en este tipo de clases por su naturaleza misma que es la de servir como extensión
     * o utilidades a otras clases se marca como static para que no se puedan crear objetos, como la
     * clase Math por ejemplo.
     */
    public static class ConversorTemperatura
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
