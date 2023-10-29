namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAtributosPublicos
{
    public class StudentMain
    {
        public static void Main(string[] args)
        {
            // CREACIÓN DE OBJETOS DE TIPO ESTUDIANTE

            Student estudiante1 = new Student
            {
                carnet = "2021001",
                nombre = "Juan Perez",
                carrera = "Ingeniería Informática"
            };

            Student estudiante2 = new()
            {
                carnet = "2021002",
                nombre = "Ana Rodriguez",
                carrera = "Ciencias de la Computación"
            };

            Student estudiante3 = new Student();
            estudiante3.carnet = "2021003";
            estudiante3.nombre = "Carlos González";
            estudiante3.carrera = "Ingeniería Eléctrica";

            // Mostrar información de sus atributos
            Console.WriteLine("Datos del Estudiante 1: " + estudiante1.ObtenerInformacion());
            Console.WriteLine("Datos del Estudiante 2: " + estudiante2.ObtenerInformacion());
            Console.WriteLine("Datos del Estudiante 3: " + estudiante3.ObtenerInformacion());
            Console.WriteLine();
        }
    }
}
