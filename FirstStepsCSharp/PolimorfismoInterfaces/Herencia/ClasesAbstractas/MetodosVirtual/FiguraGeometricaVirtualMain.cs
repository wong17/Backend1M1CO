﻿namespace PolimorfismoInterfaces.Herencia.ClasesAbstractas.MetodosVirtual
{
    public class FiguraGeometricaVirtualMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- Figura Geometrica Clase abstracta - Método Virtual ----------------------------");

            /* Crear objetos de clases hijas */
            Circulo circulo = new(5);
            Rectangulo rectangulo = new(4, 6);

            /* Crear objetos de clases hijas, utilizando el principio de sustitución */
            FiguraGeometrica circulo2 = new Circulo(5);
            FiguraGeometrica rectangulo2 = new Rectangulo(4, 6);

            /* Invocar métodos */
            circulo.CalcularArea();
            circulo2.CalcularArea();
            Console.WriteLine();
            rectangulo.CalcularArea();
            rectangulo2.CalcularArea();
        }
    }
}
