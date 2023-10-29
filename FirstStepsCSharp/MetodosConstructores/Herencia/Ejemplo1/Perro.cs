namespace MetodosConstructoresHerencia.Herencia.Ejemplo1
{
    /* 
     * CLASE HIJA que hereda de la CLASE PADRE Animal 
     * - Para llevar a cabo la Herencia utilizamos el operador ':' seguido del nombre de la clase
     *   de la cual queremos heredar
     */
    public class Perro : Animal
    {
        /* 
         * La clase Perro hereda los métodos Comer y Respirar
         * 
         * Método propio de la clase Perro 
         */
        public void Ladrar()
        {
            Console.WriteLine("Escucha puedo hacer ¡Guau! ¡Guau!");
        }
    }
}
