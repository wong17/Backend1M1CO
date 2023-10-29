namespace MetodosConstructoresHerencia.Herencia.Ejemplo3
{
    public class ComputadoraMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- ComputadoraMain ----------------------------------------");

            // Crear componentes para la computadora 1
            var procesador1 = new Procesador("Intel Core i9", 300, "Intel", 3.6, 14);
            var almacenamiento1 = new Almacenamiento("SSD Samsung", 150, "Samsung", 1000, "SSD");
            var memoriaRAM1 = new MemoriaRAM("Corsair DDR4", 80, "Corsair", 16, 3200);
            var fuentePoder1 = new FuentePoder("EVGA 750W", 90, "EVGA", "80+ Gold");
            var case1 = new Case("NZXT H510", 100, "NZXT", "Mid-Tower");
            var tarjetaMadre1 = new TarjetaMadre("ASUS ROG Strix", 200, "ASUS", true);

            // Crear componentes para la computadora 2
            var procesador2 = new Procesador("AMD Ryzen 7", 250, "AMD", 3.8, 7);
            var almacenamiento2 = new Almacenamiento("HDD Seagate", 60, "Seagate", 2000, "HDD");
            var memoriaRAM2 = new MemoriaRAM("Kingston DDR4", 70, "Kingston", 8, 2666);
            var fuentePoder2 = new FuentePoder("Corsair 650W", 80, "Corsair", "80+ Bronze");
            var case2 = new Case("Cooler Master MasterBox", 80, "Cooler Master", "Mid-Tower");
            var tarjetaMadre2 = new TarjetaMadre("MSI B450 TOMAHAWK", 120, "MSI", false);

            // Crear arreglo de componentes para computadora 1
            Componente[] componentes1 =
            {
                procesador1, almacenamiento1, memoriaRAM1, fuentePoder1, case1, tarjetaMadre1
            };

            // Crear arreglo de componentes para computadora 2
            Componente[] componentes2 =
            {
                procesador2, almacenamiento2, memoriaRAM2, fuentePoder2, case2, tarjetaMadre2
            };

            // Armar computadora 1
            Computadora computadora1 = new(componentes1);
            // Armar computadora 2
            Computadora computadora2 = new(componentes2);

            // Mostrar componentes y precio total de cada una de las computadoras
            Console.WriteLine(" ----- Computadora 1: ----- ");
            computadora1.MostrarComponentes();
            Console.WriteLine(" ----- Computadora 2: -----");
            computadora2.MostrarComponentes();
        }
    }
}
