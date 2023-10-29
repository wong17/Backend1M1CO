namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo1
{
    public class Cliente
    {
        /* Atributos de la clase */
        private string? correoElectronico;
        private string? direccion;
        private string? nombre;
        /* Propiedades para asignar y obtener valor de los atributos privados */
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public string? CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
    }
}
