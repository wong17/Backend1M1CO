namespace FirstStepsCSharp.POO.ClassesAndObjects
{
    /* 
     * Para crear una nueva clase en Visual Studio, pulsamos sobre la carpeta donde se quiera crear la clase
     * Click derecho -> "Add" -> "New item..." -> "Class" o bien 
     * Click derecho -> "Add" -> "Class..."
     *                  
     * En este ejemplo creamos la clase "Student" de la forma más sencilla posible (no del todo correcta)
     * luego crearemos algunos objetos de la clase "Student" y mostraremos su información por consola desde
     * el "Program.cs" invocando el método Main que contiene esta clase.
     */

    // Nombre de la clase empieza con la primera letra en mayúscula y en singular.
    public class Student
    {
        // Atributos de la clase Student
        string Name;
        string Carnet;

        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- Student - ClassesAndObjects --------------------");

            // palabra reservada 'new' => se utiliza para crear/instanciar un objeto (básicamente crear una varible de tipo Student)

            Student estudiante = new Student();
            estudiante.Name = "Jose";
            estudiante.Carnet = "2017-0222U";
            // mostramos datos del estudiante
            Console.WriteLine("Nombre: " + estudiante.Name + " Carnet: " + estudiante.Carnet);
            Console.WriteLine($"Nombre: { estudiante.Name } Carnet: { estudiante.Carnet }"); // utilizando interpolación de string

            // Otra forma de hacerlo, primero "declaramos la variable" y despues la "instanciamos"
            Student estudiante2;
            estudiante2 = new Student();
            estudiante2.Name = "Kevin";
            estudiante2.Carnet = "2018-2234I";
            Console.WriteLine($"Nombre: {estudiante2.Name} Carnet: {estudiante2.Carnet}");

            // Otra forma de hacerlo un poco mas corta
            Student estudiante3 = new();
            estudiante3.Name = "Romario";
            estudiante3.Carnet = "1994-2345U";
            Console.WriteLine($"Nombre: {estudiante3.Name} Carnet: {estudiante3.Carnet}");

            // Una forma mas de hacerlo
            Student estudiante4 = new()
            {
                Name = "Vegeta",
                Carnet = "2005-3456U"
            };
            Console.WriteLine($"Nombre: {estudiante4.Name} Carnet: {estudiante4.Carnet}");

            // Cualquiera de las forma anteriores hace exactamente lo mismo para este ejemplo con la clase Student
            Console.WriteLine();
        }
    }
}