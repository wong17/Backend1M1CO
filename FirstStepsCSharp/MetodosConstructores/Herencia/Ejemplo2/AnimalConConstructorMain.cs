namespace MetodosConstructoresHerencia.Herencia.Ejemplo2
{
    public class AnimalConConstructorMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- AnimalConConstructorMain ----------------------------------------");
            // Creación de objetos que heredan de Animal
            Perro perro = new("Firulais");
            Gato gato = new("Pelusa");
            Pajaro pajaro = new("Piolin");

            // Creación de arreglo de tipo Animal
            Animal[] animales =
            {
                perro, gato, pajaro
            };

            // Invocar métodos en común
            Console.WriteLine("Métodos heredados de la clase Animal: ");
            foreach (Animal animal in animales)
            {
                animal.Comer();
                animal.Respirar();
            }

            // Invocar métodos propios
            Console.WriteLine("\nMétodos propios de cada clase hija: ");
            perro.Ladrar();
            gato.Maullar();
            pajaro.Cantar();

        }
    }
}
