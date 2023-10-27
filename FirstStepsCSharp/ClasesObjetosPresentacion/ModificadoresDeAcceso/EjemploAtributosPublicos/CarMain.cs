namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAtributosPublicos
{
    public class CarMain
    {
        public static void Main(string[] args)
        {
            // 1. Primera forma de crear un objeto "new Car"
            Car coche1 = new Car
            {
                Marca = "Toyota",
                Modelo = "Camry",
                AñoFabricacion = 2022,
                Color = "Rojo"
            };

            // 2. Segunda forma de crear un objeto "new()"
            Car coche2 = new()
            {
                Marca = "Ford",
                Modelo = "Mustang",
                AñoFabricacion = 2023,
                Color = "Negro"
            };

            // 3. Tercera forma de crear un objeto
            Car coche3 = new Car();
            coche3.Marca = "Ford";
            coche3.Modelo = "Mustang";
            coche3.AñoFabricacion = 2023;
            coche3.Color = "Negro";

            // 4. Cuarta forma de crear un objeto
            Car coche4;   // Declarar la variable de tipo Car
            coche4 = new()  // Instanciar/crear objeto con la palabra "new"
            {
                Marca = "Chevrolet",
                Modelo = "Cruze",
                AñoFabricacion = 2022,
                Color = "Plateado"
            };

            // Mostrar información de sus atributos
            Console.WriteLine(coche1.MostrarInformacion());
            Console.WriteLine(coche2.MostrarInformacion());
            Console.WriteLine(coche3.MostrarInformacion());
            Console.WriteLine(coche4.MostrarInformacion());
            Console.WriteLine();
        }
    }
}
