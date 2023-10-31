namespace PolimorfismoInterfaces.Herencia.ClasesAbstractas.MetodosAbstract
{
    public class FiguraGeometricaAbstractMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- Figura Geometrica Clase abstracta - Método Abstract ----------------------------");

            /* Crear objetos de clases hijas */
            Circulo circulo = new(5);
            Rectangulo rectangulo = new(4, 6);

            /* Crear objetos de clases hijas, utilizando el principio de sustitución */
            FiguraGeometrica circulo2 = new Circulo(5);
            FiguraGeometrica rectangulo2 = new Rectangulo(4, 6);

            /* Invocar métodos */
            circulo.CalcularArea();
            circulo2.CalcularArea();

            rectangulo.CalcularArea();
            rectangulo2.CalcularArea();
        }
    }
}
