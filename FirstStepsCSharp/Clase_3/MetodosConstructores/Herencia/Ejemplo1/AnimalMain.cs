namespace MetodosConstructoresHerencia.Herencia.Ejemplo1
{
    public class AnimalMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- AnimalMain ----------------------------------------");
            /*
             * Implicitamente cada clase en este ejemplo tiene un constructor por defecto que a su vez este constructor
             * invoca al constructor de la clase padre con la instrucción :base() para darle un estado
             * inicial a los objetos que heredan de Animal.
             * 
             * En este caso no es necesario ponerlo de forma explicita, veremos en los demás ejemplos que si es necesario.
             */

            // Crear objetos de la sub clases que heredan de Animal
            Perro perro = new();
            Gato gato = new();
            Pajaro pajaro = new();

            // Invocar los métodos heredados de Animal
            Console.WriteLine("Métodos heredados de Animal: ");
            Console.WriteLine("1. Perro: ");
            perro.Comer();
            perro.Respirar();

            Console.WriteLine("\n2. Gato: ");
            gato.Comer();
            gato.Respirar();

            Console.WriteLine("\n3. Pajaro: ");
            pajaro.Comer();
            pajaro.Respirar();

            // Invocar los métodos propios de cada una de las clases hijas
            Console.WriteLine("\nMétodos propios de cada clase hija: ");
            Console.WriteLine("1. Perro: ");
            perro.Ladrar();

            Console.WriteLine("\n2. Gato: ");
            gato.Maullar();

            Console.WriteLine("\n3. Pajaro: ");
            pajaro.Cantar();

            // -------------------------------------------------------------

            /* 
             * Por el principio de sustitución o Regla "es un/una" podemos guardar en un arreglo 
             * de 'Animal' toda aquella clase que herede de esta clase, ya que si una clase hereda de
             * 'Animal' esa clase "es un Animal" tambien.
             * 
             * - Perro 'es un' Animal
             * - Gato 'es un' Animal
             * - Pajaro 'es un' Animal
             *
             * Siempre que una clase hereda de otra y creemos una variable del tipo mas alto de la jerarquia
             * podremos guardar en esa variable una subclase de esta.
             */
            Animal[] animales =
            {
                perro, gato, pajaro,
            };

            /* 
             * Ya que todos heredan de Animal podemos invocar el método Comer y Respirar 
             * de cada subclase
             */
            Console.WriteLine("\nRecorrer arreglo de Animales: ");
            foreach (Animal animal in animales)
            {
                animal.Comer();
                animal.Respirar();
                Console.WriteLine();
            }
        }
    }
}
