namespace EstudiantesWebAPI.Models
{
    public class Estudiante
    {
        /* Atributos de la clase Estudiante */
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Carnet { get; set; }
        public string? Carrera { get; set; }
    }
}