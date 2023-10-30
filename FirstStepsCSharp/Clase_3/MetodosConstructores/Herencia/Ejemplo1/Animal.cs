namespace MetodosConstructoresHerencia.Herencia.Ejemplo1
{
    /* 
     * CLASE PADRE de todos los animales 
     * 
     * Las clases hijas heredaran el método Comer y Respirar
     */
    public class Animal
    {
        /* Métodos que heredaran todas las clases hijas */
        public void Comer()
        {
            Console.WriteLine("Me gusta mucho comer!");
        }

        public void Respirar()
        {
            Console.WriteLine("Puedo respirar!");
        }
    }
}
