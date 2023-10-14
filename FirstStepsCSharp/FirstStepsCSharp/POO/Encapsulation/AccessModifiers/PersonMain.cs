namespace FirstStepsCSharp.POO.Encapsulation.AccessModifiers
{
    public class PersonMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- Person - AccessModifiers --------------------");

            // Creamos un objeto/variable de tipo Person
            Person persona1 = new Person();
            /*
             * Al intentar asignar valor al nombre, número de cedula y altura nos da un error de compilación 
             * porque los atributos son private y solo pueden ser accedidos dentro de la clase "Person" y no 
             * desde ningun otra clase como en la que nos encontramos que se llama "PersonMain"
             */
            //persona1.Name = "Jose";                   // Error
            //persona1.IDNumber = "001-280788-1020U";   // Error
            //persona1.Height = 1.70;                   // Error

            // Solo podemos acceder al atributo Nacionality que es public
            persona1.Nacionality = "Nicaragua";

            Console.WriteLine("Nacionalidad: " + persona1.Nacionality);

            Console.WriteLine();
        }
    }
}