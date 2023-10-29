namespace MetodosConstructoresHerencia.MetodosAtributosStatic.Atributos
{
    public class Estudiante
    {
        // No podemos modificar el valor de UNIVERSIDAD solo obtenerlo porque es const
        public const string UNIVERSIDAD = "UNI";
        // El contador va aumentando cada vez que se cree un Estudiante
        public static int Contador { get; private set; } = 0;
        // Atributo nombre que se asigna valor desde el constructor en tiempo de ejecución
        private readonly string? nombre;
        // Constructor por defecto
        public Estudiante() { }
        // Constructor para crear Estudiante con el nombre de una vez
        public Estudiante(string? nombre) 
        {
            this.nombre = nombre;
            Contador++;
        }
        public string Saludo() => $"Hola soy {nombre}, estudio en la {UNIVERSIDAD} " +
            $"y en total somos {Contador} estudiantes en mi grupo.";
    }
}
