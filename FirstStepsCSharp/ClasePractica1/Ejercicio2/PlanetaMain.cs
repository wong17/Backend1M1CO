namespace ClasePractica1.Ejercicio2
{
    public class PlanetaMain
    {
        public static void Main()
        {
            Console.WriteLine("-------------------------------- Ejercicio 2 - Planeta --------------------------------\n");

            // Crear dos planetas
            Planeta planeta1 = new("Marte", 2, 0.64171, 163.18, 6792, (int)1.52 * 149597870, TipoPlaneta.TERRESTRE, true);
            Planeta planeta2 = new("Júpiter", 79, 1898.19, 1431280, 139820, (int)5.2 * 149597870, TipoPlaneta.GASEOSO, true);

            // Mostrar información de los planetas
            planeta1.MostrarInformacion();
            planeta2.MostrarInformacion();

            // Calcular y mostrar la densidad de los planetas
            double densidadPlaneta1 = planeta1.CalcularDensidad();
            double densidadPlaneta2 = planeta2.CalcularDensidad();
            Console.WriteLine($"Densidad de {planeta1.Nombre}: {densidadPlaneta1} g/cm³");
            Console.WriteLine($"Densidad de {planeta2.Nombre}: {densidadPlaneta2} g/cm³");

            // Determinar si los planetas son exteriores
            bool esExteriorPlaneta1 = planeta1.EsPlanetaExterior();
            bool esExteriorPlaneta2 = planeta2.EsPlanetaExterior();
            Console.WriteLine($"{planeta1.Nombre} es un planeta exterior: {esExteriorPlaneta1}");
            Console.WriteLine($"{planeta2.Nombre} es un planeta exterior: {esExteriorPlaneta2}");
        }
    }
}
