﻿namespace PolimorfismoInterfaces.Herencia.PolimorfismoClaseAbstracta
{
    public class PolimorfismoClaseAbstractaMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- Polimorfismo y Clase Abstracta ----------------------------------------");

            // Creación de objetos
            Director director = new() { Nombre = "Juan" };
            Gerente gerente = new() { Nombre = "Maria" };
            Jefe jefe = new() { Nombre = "Carlos" };
            // Invocación del método CalcularSalario
            director.CalcularSalario();
            gerente.CalcularSalario();
            jefe.CalcularSalario();
            Console.WriteLine();

            // Arreglo de empleados, posible gracias al principio de sustitución
            Empleado[] empleados =
            {
                director, gerente, jefe
            };
            // Invocación del método CalcularSalario
            foreach (var element in empleados)
                element.CalcularSalario();
        }
    }
}
