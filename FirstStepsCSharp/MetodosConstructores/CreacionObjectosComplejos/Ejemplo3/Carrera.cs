namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo3
{
    public class Carrera
    {
        /* Atributos */
        private string? nombre;
        private int duracion;
        /* Constructor de la clase Carrera */
        public Carrera(string? nombre, int duracion)
        {
            Nombre = nombre;
            Duracion = duracion;
        }
        /* Propiedades getters y setters */
        public string? Nombre { get => nombre; set => nombre = value; }
        public int Duracion { get => duracion; set => duracion = value; }
    }
}
