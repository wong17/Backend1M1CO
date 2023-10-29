namespace ClasesObjetosPresentacion.MetodosGettersSetters
{
    public class Customer
    {
        /*  
         * Simplemente propiedades
         * 
         * Otra forma es simplemente utilizar properties y no un campo de respaldo para cada property.
         * Si la property es publica la podremos utilizar desde cualquier parte, si es privada solo desde la clase.
         */

        // Propiedad Id, solo es posible obtener el valor pero no asignar, por defecto tiene el valor de 1
        public int Id { get; private set; } = 1;
        // Propiedad Nombre, podemos asignar valor y obtenerlo
        public string Nombre { get; set; }
        // Propiedad Telefono, podemos asignar valor y obtenerlo
        public string Telefono { get; set; }
    }
}
