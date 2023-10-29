namespace MetodosConstructores.MetodosAtributosStatic.Metodos
{
    public class Calculadora
    {
        /* 
         * Los métodos static le pertenecen a la clase y no a los objetos que se puedan
         * crear a partir de esta clase, es por eso que se invocan utilizando el nombre
         * de la clase y no apartir de un objeto.
         */
        public static double Sumar(double a, double b) => a + b;

        public static double Restar(double a, double b) => a - b;

        public static double Multiplicar(double a, double b) => a * b;

        public static double Dividir(double a, double b) => (b != 0) ? a / b : double.NaN;

        public static double ElevarAlCuadrado(double a) => a * a;

        public static double CalcularRaizCuadrada(double a) => (a >= 0) ? Math.Sqrt(a) : double.NaN;

        public static double CalcularPotencia(double baseNumber, int exponente) => Math.Pow(baseNumber, exponente);
    }
}
