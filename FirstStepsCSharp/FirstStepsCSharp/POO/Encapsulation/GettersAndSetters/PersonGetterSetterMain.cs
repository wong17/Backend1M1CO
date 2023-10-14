namespace FirstStepsCSharp.POO.Encapsulation.GettersAndSetters
{
    public class PersonGetterSetterMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- Person - PersonGetterSetterMain --------------------");

            // Crear un objeto de tipo persona
            Person persona = new Person();
            
            /* 
             * Le damos valor a sus atributos privados utilizando los setters ya que estos 
             * son métodos públicos y es la unica forma que tenemos de acceder a esos campos.
             */
            persona.SetName("Goku");
            persona.SetIDNumber("001-540586");
            persona.SetHeight(1.75);

            /* 
             * Obtenemos el valor de esos atributos privados utilizando los getters que de igual
             * forma estos son públicos y es la unica forma que tenemos de acceder al valor de los campos.
             */
            Console.WriteLine($"Nombre: {persona.GetName()}, Númereo de cedula: {persona.GetIDNumber()}, Altura: {persona.GetHeight()}");

            Console.WriteLine();
        }
    }
}