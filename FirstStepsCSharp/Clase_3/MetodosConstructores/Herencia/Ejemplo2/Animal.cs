namespace MetodosConstructoresHerencia.Herencia.Ejemplo2
{
    /* 
     * CLASE PADRE de todos los animales 
     * 
     * Las clases hijas heredaran el método Comer y Respirar, además 
     * podran tener un nombre para ello cada clase hija debera de proporcionar 
     * un constructor que reciba como parámetro un nombre y que a su vez invoque 
     * al constructor de la clase padre (esta clase) y le pase el nombre, ya que 
     * la clase padre se debe de inicializar primero que la clase hija.
     */
    public class Animal
    {
        /* Atributo de la clase Animal */
        private readonly string? nombre;
        /* Constructor de la clase Animal */
        public Animal(string? nombre)
        {
            this.nombre = nombre;
        }

        /* Métodos que heredaran todas las clases hijas */
        public void Comer()
        {
            Console.WriteLine($"Me llamo {nombre} y me gusta mucho comer!");
        }

        public void Respirar()
        {
            Console.WriteLine($"{nombre}: Puedo respirar!");
        }

        /* Propiedad Getter para obtener el nombre desde cualquier clase hija */
        public string? Nombre => nombre;
    }
}
