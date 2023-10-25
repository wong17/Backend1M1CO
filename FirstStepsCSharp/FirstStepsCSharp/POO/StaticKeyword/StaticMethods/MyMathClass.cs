namespace FirstStepsCSharp.POO.StaticKeyword.StaticMethods
{
    public class MyMathClass
    {
        /* 
         * Para utilizar estos métodos no necesitamos crear objetos de la clase "MyMathClass" 
         * se hace simplemente a traves del nombre de la clase.
         * 
         * Revisar el main de este paquete, StaticMainExample
         */
        public static double Sum(double x, double y) => x + y;

        public static double Substract(double x, double y) => x - y;

        public static double Multiply(double x, double y) => x * y;

        public static double Divide(double x, double y) => x / y;

        /* Este no es accesible desde fuera de la clase, no importa que sea estatico, el método es
         "private".*/
        private static double Power(double x, double y) => Math.Pow(x, y);
    }
}