namespace MetodosConstructoresHerencia.MetodosAtributosStatic.Clases
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
    public static class Calculadora
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
