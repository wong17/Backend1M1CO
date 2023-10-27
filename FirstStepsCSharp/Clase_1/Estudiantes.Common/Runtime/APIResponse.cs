using System.Net;

namespace EstudiantesWebAPI.Common.Runtime
{
    /* Para que todos los endpoints retornen el mismo tipo de respuesta */
    public class APIResponse
    {
        /* Código de estado HTTP */
        public HttpStatusCode StatusCode { get; set; }
        /* Resultado de la petición HTTP (exito = true, fallo = false) */
        public bool IsSuccess { get; set; } = true;
        /* Mensaje de exito o error asociado a la petición */
        public string? Message { get; set; }
        /* Objeto */
        public object? Result { get; set; }
    }
}
