namespace MetodosConstructoresHerencia.Herencia.Ejemplo1
{
    /* 
     * CLASE HIJA que hereda de la CLASE PADRE Animal 
     * - Para llevar a cabo la Herencia utilizamos el 
     *   operador ':' seguido del nombre de la clase
     *   de la cual queremos heredar
     */
    public class Pajaro : Animal
    {
        /*
         * La clase Pajaro hereda los métodos Comer y Respirar
         *
         * Método propio de la clase Pajaro
         */
        public void Cantar()
        {
            Console.WriteLine("Escucha puedo cantar melodiosamente.");
        }
    }
}
