namespace PolimorfismoInterfaces.Interfaces.Ejemplo2
{
    public class OutlookCorreo : ICorreo
    {
        // Atributo
        private readonly string mensaje;
        // Constructor
        public OutlookCorreo(string mensaje)
        {
            this.mensaje = mensaje;
        }
        // Método de la interfaz
        public void Enviar()
        {
            Console.WriteLine($"Mensaje: {mensaje}");
            Console.WriteLine("Correo enviado por servicios de Outlook");
        }
    }
}
