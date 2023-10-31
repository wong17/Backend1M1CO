namespace PolimorfismoInterfaces.Herencia.ClasesAbstractas.MetodosAbstract
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
            NotificarCalculoTerminado();
        }

        protected override void NotificarCalculoTerminado()
        {
            Console.WriteLine("Área del rectangulo calculada.");
        }
    }
}
