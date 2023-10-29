namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo3
{
    public class Facultad
    {
        private string? nombre;
        private Carrera[]? carreras;

        public Facultad(string? nombre, Carrera[]? carreras)
        {
            this.nombre = nombre;
            this.carreras = carreras;
        }

        public string? Nombre { get => nombre; set => nombre = value; }
        public Carrera[]? Carreras { get => carreras; set => carreras = value; }
    }
}
