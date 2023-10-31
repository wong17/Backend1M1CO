﻿namespace PolimorfismoInterfaces.Herencia.ClasesAbstractas
{
    public class Rectangulo : FiguraGeometrica
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

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
        }
    }
}