namespace FirstStepsCSharp.Basic.BasicCSharp
{
    public class SwitchStatement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- SwitchStatement --------------------");

            int option = 5;
            // switch
            switch(option)
            {
                case 0: 
                    Console.WriteLine("Opción 0"); break;
                case 1:
                    Console.WriteLine("Opción 1"); break;
                case 2:
                    Console.WriteLine("Opción 2"); break;
                case 3:
                    Console.WriteLine("Opción 3"); break;
                case 4:
                    Console.WriteLine("Opción 4"); break;
                case 5:
                    Console.WriteLine("Opción 5"); break;
                default: 
                    Console.WriteLine("Entró en el caso por defecto"); break;
            }

            // Asignar un valor utilizando un switch
            string text = option switch
            {
               0 => "Opción 0",
               1 => "Opción 1",
               2 => "Opción 2",
               3 => "Opción 3",
               4 => "Opción 4",
               5 => "Opción 5",
               _ => "Default"
            };
            Console.WriteLine(text);

            Console.WriteLine();
        }
    }
}