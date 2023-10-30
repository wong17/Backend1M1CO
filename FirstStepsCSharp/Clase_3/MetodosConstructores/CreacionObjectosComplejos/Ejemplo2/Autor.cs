namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo2
{
    public class Autor
    {
        /* Atributos de la clase Libro */
        private string? nombre;
        private DateTime fechaNacimiento;
        private string? nacionalidad;
        /* Constructor de la clase Autor */
        public Autor(string? nombre, DateTime fechaNacimiento, string? nacionalidad)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.nacionalidad = nacionalidad;
        }
        /* Propiedades que nos sirven de getter y setters */
        public string? Nombre 
        { 
            get => nombre; 
            set => nombre = value; 
        }
        public DateTime FechaNacimiento 
        { 
            get => fechaNacimiento; 
            set => fechaNacimiento = value; 
        }
        public string? Nacionalidad 
        { 
            get => nacionalidad; 
            set => nacionalidad = value; 
        }
    }
}
