namespace PolimorfismoInterfaces.Interfaces.Ejemplo2
{
    public class EnviarCorreosMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- EnviarCorreosMain - Interfaces ejemplo 2 ----------------------------");

            // Enviar correo utilizando una de las clases que implementan la interfaz ICorreo
            EnviarCorreos enviarServicioGmail = new(new GmailCorreo("Este es un mensaje desde Gmail"));
            enviarServicioGmail.EnviarCorreo();
            Console.WriteLine();

            EnviarCorreos enviarServicioOutlook = new(new OutlookCorreo("Este es un mensaje desde Outlook"));
            enviarServicioOutlook.EnviarCorreo();
        }
    }
}
