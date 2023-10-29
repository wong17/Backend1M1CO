namespace MetodosConstructoresHerencia.Herencia.Ejemplo3
{
    /* 
     * CLASE PADRE de todos los componentes de la Computadora 
     * 
     * Las clases hijas heredaran 3 atributos y tendran que proporcionar un constructor 
     * para poder inicializar estos 3 atributos al momento de crear una instancia de esa clase.
     */
    public class Componente
    {
        /* Atributos de la clase Componente */
        private string? modelo;
        private double precio;
        private string? fabricante;
        /* Constructor de la clase componente */
        public Componente(string? modelo, double precio, string? fabricante)
        {
            this.modelo = modelo;
            this.precio = precio;
            this.fabricante = fabricante;
        }
        /* Propiedades getter y setter para obtener y asignar valor a los atributos privados */
        public string? Modelo { get => modelo; set => modelo = value; }
        public double Precio { get => precio; set => precio = value; }
        public string? Fabricante { get => fabricante; set => fabricante = value; }
    }
}
