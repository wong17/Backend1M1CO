namespace PolimorfismoInterfaces.Herencia.SobrescribirMetodos
{
    public class SobrescribirMain
    {
        public static void Main()
        {
            Console.WriteLine("---------------------------------------- Sobrescribir Métodos ----------------------------------------");

            // Creación de objetos
            Carro carro = new();
            Moto moto = new();
            Camion camion = new();

            /* 
             * Llamar método heredado y luego sobrescrito por cada clase,
             * esto es polimorfismo, cada objeto responde de forma
             * diferente a la llamada del mismo método.
             */
            carro.Arrancar();
            moto.Arrancar();
            camion.Arrancar();

            Console.WriteLine();
            // Arreglo de vehiculos gracias al principio de sustitución
            Vehiculo[] vehiculos =
            {
                new Carro(), new Moto(), new Camion()
            };
            // Llamar método arrancar de cada objeto
            foreach (var element in vehiculos)
                element.Arrancar();
        }
    }
}
