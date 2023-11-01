namespace PolimorfismoInterfaces.Interfaces.Ejemplo2
{
    public class EnviarCorreos
    {
        // Atributo
        private readonly ICorreo servicioCorreos;
        /* 
         * Constructor que recibe como parámetro cualquier clase que 
         * implemente la interfaz ICorreo para enviar un correo utilizando
         * ese servicio.
         */
        public EnviarCorreos(ICorreo servicioCorreos)
        {
            this.servicioCorreos = servicioCorreos;
        }
        // Metodo para enviar correo
        public void EnviarCorreo()
        {
            servicioCorreos.Enviar();
        }
    }
}
