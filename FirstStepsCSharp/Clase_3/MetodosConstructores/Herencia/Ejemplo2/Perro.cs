namespace MetodosConstructoresHerencia.Herencia.Ejemplo2
{
    /* 
     * CLASE HIJA que hereda de la CLASE PADRE Animal 
     * - Para llevar a cabo la Herencia utilizamos el 
     *   operador ':' seguido del nombre de la clase
     *   de la cual queremos heredar
     */
    public class Perro : Animal
    {
        /* 
         * Constructor de la clase hija Perro 
         * 
         * Recibe un nombre como parámetro y ese es pasado como parámetro al
         * constructor de la clase padre Animal por medio de la instrucción :base(nombre)
         */
        public Perro(string? nombre) : base(nombre)
        {
            // Aquí podria ir más código...
        }

        /* 
         * La clase Perro hereda los métodos Comer y Respirar
         * 
         * Método propio de la clase Perro 
         */
        public void Ladrar()
        {
            Console.WriteLine($"{Nombre}: Escucha puedo hacer ¡Guau! ¡Guau!");
        }
    }
}
