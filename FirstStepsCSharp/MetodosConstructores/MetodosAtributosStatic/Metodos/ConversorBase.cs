namespace MetodosConstructores.MetodosAtributosStatic.Metodos
{
    public class ConversorBase
    {
        public static string DecimalABinario(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2); // Convierte a binario
        }

        public static int BinarioADecimal(string binario)
        {
            return Convert.ToInt32(binario, 2); // Convierte de binario a decimal
        }

        public static string DecimalAOctal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 8); // Convierte a octal
        }

        public static int OctalADecimal(string octal)
        {
            return Convert.ToInt32(octal, 8); // Convierte de octal a decimal
        }
    }
}
