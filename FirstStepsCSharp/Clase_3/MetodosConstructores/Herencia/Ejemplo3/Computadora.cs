using System.Text.Json.Serialization;
using System.Text.Json;

namespace MetodosConstructoresHerencia.Herencia.Ejemplo3
{
    public class Computadora
    {
        /* 
         * Arreglo que contiene todos los componentes de la computadora 
         * 
         * Gracias al principio de sustitución y la regla "es un/una" de la herencia,
         * dentro de este arreglo de tipo Componente[] podremos almacenar objetos de 
         * toda clase hija que herede de Componente, ya que por herencia si una clase 
         * hereda de Componente esa clase "es un Componente" tambien. 
         * 
         * Siempre donde se espere un objeto de una clase padre podra tambien asignarse
         * un objeto de una clase que herede de esta, como en este caso.
         */
        private Componente[] componentes;
        /* 
         * Precio total de la computadora, se calcula en base al precio de cada componente,
         * este no puede ser modificado desde fuera de la clase, por eso el setter es privado,
         * se calcula internamente y solo se puede obtener por medio de un getter.
         */
        public double PrecioTotal { get; private set; }
        /* Constructor para crear una computadora pasandole todos los componentes de una vez */
        public Computadora(Componente[] componentes)
        {
            this.componentes = componentes;
            // Una vez se crea la computadora se invoca el método calcular total
            CalcularPrecioTotal();
        }
        /* Propiedad getter y setter para dar y obtener valor a la lista de componentes */
        public Componente[] Componentes { get => componentes; set => componentes = value; }
        /* Este método calcula el precio total de la computadora */
        private void CalcularPrecioTotal()
        {
            /* 
             * Recorremos la lista de componentes de la computadora y gracias a que todos heredan de
             * 'Componente' todos tienen un campo 'Precio', solo tenemos que recorrer, obtener el valor
             * de ese campo e ir sumando para finalmente guardarlo en 'PrecioTotal'.
             */

            foreach (var componente in componentes)
                PrecioTotal += componente.Precio;
        }
        /* Imprime por consola todos los componentes de la computadora incluyendo el precio total */
        public void MostrarComponentes()
        {
            /* Por legibilidad convertimos el objeto a formato JSON y lo mostramos por consola */
            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            string json = JsonSerializer.Serialize(this, options);
            Console.WriteLine("\n" + json);
        }
    }
}
