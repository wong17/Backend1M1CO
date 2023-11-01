namespace PolimorfismoInterfaces.Interfaces.Ejemplo2
{
    public class GmailCorreo : ICorreo
    {
        // Atributo
        private readonly string mensaje;
        // Constructor
        public GmailCorreo(string mensaje)
        {
            this.mensaje = mensaje;
        }
        // Método de la interfaz
        public void Enviar()
        {
            Console.WriteLine($"Mensaje: {mensaje}");
            Console.WriteLine("Correo enviado por servicios de Gmail");
        }
    }
}
