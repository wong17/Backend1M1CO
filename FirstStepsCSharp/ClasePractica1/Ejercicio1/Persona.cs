namespace ClasePractica1.Ejercicio1
{
    public class Persona
    {
        /* Atributos */
        private readonly string? nombre;
        private readonly string? apellido;
        private readonly string? numeroDocumentoIdentidad;
        private readonly int anioNacimiento;
        /* Constructor */
        public Persona(string? nombre, string? apellido, string? numeroDocumentoIdentidad, int anioNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroDocumentoIdentidad = numeroDocumentoIdentidad;
            this.anioNacimiento = anioNacimiento;
        }
        /* Método para imprimir datos */
        public void ImprimirDatos() => Console.WriteLine($"Información de la persona:\nNombre: {nombre}\nApellido: " +
            $"{apellido}\nCedula: {numeroDocumentoIdentidad}\nAño nacimiento: {anioNacimiento}\n");
    }
}
