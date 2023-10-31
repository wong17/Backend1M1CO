namespace PolimorfismoInterfaces.Herencia.ClasesAbstractas
{
    public class FiguraGeometricaMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- Figura Geometrica Clase abstracta ----------------------------------------");

            /* Crear objetos de clases hijas */
            Circulo circulo = new(5);
            Rectangulo rectangulo = new(4, 6);
            
            /* Crear objetos de clases hijas utilizando el principio de sustitución */
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
