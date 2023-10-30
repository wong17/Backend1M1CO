namespace MetodosConstructoresHerencia.Herencia.Ejemplo2
{
    /*
     * CLASE HIJA que hereda de la CLASE PADRE Animal
     * - Para llevar a cabo la Herencia utilizamos el 
     *   operador ':' seguido del nombre de la clase
     *   de la cual queremos heredar
     */

    public class Gato : Animal
    {
        /* 
         * Constructor de la clase hija Gato 
         * 
         * Recibe un nombre como parámetro y ese es pasado como parámetro al
         * constructor de la clase padre Animal por medio de la instrucción :base(nombre)
         */
        public Gato(string? nombre) : base(nombre)
        {
            // Aqui podria ir más código...
        }

        /*
         * La clase Gato hereda los métodos Comer y Respirar
         *
         * Método propio de la clase Gato
         */
        public void Maullar()
        {
            Console.WriteLine($"{Nombre}: Escucha puedo hacer ¡Miau! ¡Miau!");
        }
    }
}
