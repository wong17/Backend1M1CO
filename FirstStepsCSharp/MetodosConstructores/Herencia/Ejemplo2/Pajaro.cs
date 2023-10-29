namespace MetodosConstructoresHerencia.Herencia.Ejemplo2
{
    /* 
     * CLASE HIJA que hereda de la CLASE PADRE Animal 
     * - Para llevar a cabo la Herencia utilizamos el operador ':' seguido del nombre de la clase
     *   de la cual queremos heredar
     */
    public class Pajaro : Animal
    {
        /* 
         * Constructor de la clase hija Pajaro 
         * 
         * Recibe un nombre como parámetro y ese es pasado como parámetro al
         * constructor de la clase padre Animal por medio de la instrucción :base(nombre)
         */
        public Pajaro(string? nombre) : base(nombre)
        {
            // Aqui podria ir más código...
        }

        /*
         * La clase Pajaro hereda los métodos Comer y Respirar
         *
         * Método propio de la clase Pajaro
         */
        public void Cantar()
        {
            Console.WriteLine($"{Nombre}: Escucha puedo cantar melodiosamente.");
        }
    }
}
