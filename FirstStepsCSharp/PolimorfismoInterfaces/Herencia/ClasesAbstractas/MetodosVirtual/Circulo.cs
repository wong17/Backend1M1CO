namespace PolimorfismoInterfaces.Herencia.ClasesAbstractas.MetodosVirtual
{
    public class Circulo : FiguraGeometrica
    {
        /* Propiedad */
        public double Radio { get; set; }
        /* Constructor */
        public Circulo(double radio)
        {
            Radio = radio;
        }
        /* Sobrescribir método para calcular area de la clase FiguraGeometrica */
        public override void CalcularArea()
        {
            double area = Math.PI * Radio * Radio;
            Console.WriteLine($"Área del círculo: {area}");
            /* Llamar implementación base del método de la clase abstracta */
            NotificarCalculoTerminado();
        }
    }
}
