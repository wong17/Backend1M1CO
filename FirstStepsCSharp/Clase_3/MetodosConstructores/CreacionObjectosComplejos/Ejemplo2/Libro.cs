namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo2
{
    public class Libro
    {
        /* Atributos de la clase Libro */
        private string? titulo;
        private Autor[]? autor;
        private int anioPublicacion;
        private bool disponible;
        /* Constructor de la clase Libro */
        public Libro(string? titulo, Autor[]? autor, int anioPublicacion, bool disponible)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anioPublicacion = anioPublicacion;
            this.disponible = disponible;
        }
        /* Propiedades que nos sirven de getter y setters */
        public string? Titulo 
        { 
            get => titulo; 
            set => titulo = value; 
        }
        public Autor[]? Autor 
        { 
            get => autor; 
            set => autor = value; 
        }
        public int AnioPublicacion 
        { 
            get => anioPublicacion; 
            set => anioPublicacion = value; 
        }
        public bool Disponible 
        { 
            get => disponible; 
            set => disponible = value; 
        }
    }
}
