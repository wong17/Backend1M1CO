namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo3
{
    public class UniversidadMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- UniversidadMain ----------------------------------------");
            // Crear carreras
            Carrera ingSistemas = new("Ingeniería en Sistemas", 5);
            Carrera ingComputacion = new("Ingeniería en Computación", 5);
            Carrera ingElectrica = new("Ingeniería Eléctrica", 5);
            Carrera ingElectronica = new("Ingeniería Electrónica", 5);

            // Crear facultades y asignar carreras
            Facultad cienciasSistemas = new("Ciencias y Sistemas", new Carrera[] { ingSistemas });
            Facultad electrotecniaComputacion = new("Electrotecnia y Computación", new Carrera[] { ingComputacion, ingElectrica, ingElectronica });

            // Crear la universidad y asignar facultades
            Universidad uni = new("Universidad Nacional de Ingeniería", new Facultad[] { cienciasSistemas, electrotecniaComputacion });

            // Mostrar la información de la universidad con sus facultades y carreras
            uni.MostrarFacultadesCarreras();
        }
    }
}
