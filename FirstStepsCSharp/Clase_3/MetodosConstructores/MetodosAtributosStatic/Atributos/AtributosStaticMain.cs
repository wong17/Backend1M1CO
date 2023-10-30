using MetodosConstructoresHerencia.MetodosAtributosStatic.Atributos;

namespace MetodosConstructores.MetodosAtributosStatic.Atributos
{
    public class AtributosStaticMain
    {
        public static void Main()
        {
            #region ContadorEstudiante

            Console.WriteLine("-------------------------------------- ContadorEstudiante --------------------------------------");
            Console.WriteLine($"Contador de estudiantes: {ContadorEstudiante.Contador}"); // 0
            ContadorEstudiante c1 = new();
            Console.WriteLine($"Contador de estudiantes: {ContadorEstudiante.Contador}"); // 1
            ContadorEstudiante c2 = new();
            ContadorEstudiante c3 = new();
            ContadorEstudiante c4 = new();
            ContadorEstudiante c5 = new();
            Console.WriteLine($"Contador de estudiantes: {ContadorEstudiante.Contador}\n"); // 5

            // No es posible acceder al contador desde ninguno de los 5 objetos creados

            #endregion

            #region ConstantesMatematicas

            Console.WriteLine("-------------------------------------- ConstantesMatematicas --------------------------------------");
            Console.WriteLine($"PI: {ConstantesMatematicas.PI}");
            Console.WriteLine($"E: {ConstantesMatematicas.E}");
            Console.WriteLine($"PHI: {ConstantesMatematicas.PHI}");
            Console.WriteLine($"RaizDe2: {ConstantesMatematicas.RaizDe2}");
            Console.WriteLine($"RaizDe3: {ConstantesMatematicas.RaizDe3}");
            Console.WriteLine($"Ln10: {ConstantesMatematicas.Ln10}\n");

            ConstantesMatematicas constantesMatematicas = new();
            // No es posible acceder a ninguno de los campos porque no le pertencen a los objetos sino a la clase

            #endregion

            #region Estudiante

            // Creamos 3 estudiantes
            Console.WriteLine("-------------------------------------- Estudiante --------------------------------------");
            Estudiante estudiante1 = new Estudiante("Julian");
            Estudiante estudiante2 = new("David");
            Estudiante estudiante3 = new("Alex");

            Console.WriteLine("Campo UNIVERSIDAD: " + Estudiante.UNIVERSIDAD);
            Console.WriteLine("Contador de Estudiantes: " + Estudiante.Contador);
            Console.WriteLine(estudiante1.Saludo());
            Console.WriteLine(estudiante2.Saludo());
            Console.WriteLine(estudiante3.Saludo() + "\n");

            #endregion
        }
    }
}
