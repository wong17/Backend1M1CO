namespace PolimorfismoInterfaces.Herencia.ClasesAbstractas.MetodosVirtual
{
    public class Rectangulo : FiguraGeometrica
    {
        /* Propiedades */
        public double Largo { get; set; }
        public double Ancho { get; set; }
        /* Constructor */
        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }
        /* Sobrescribir método para calcular area de la clase FiguraGeometrica */
        public override void CalcularArea()
        {
            double area = Largo * Ancho;
            Console.WriteLine($"Área del rectángulo: {area}");
            /* Llamar implementación base del método de la clase abstracta */
            NotificarCalculoTerminado();
        }
    }
}
