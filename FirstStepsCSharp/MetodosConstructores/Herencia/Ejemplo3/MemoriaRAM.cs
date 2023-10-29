namespace MetodosConstructoresHerencia.Herencia.Ejemplo3
{
    /* 
     * CLASE HIJA que hereda de la CLASE PADRE Componente 
     * - Para llevar a cabo la Herencia utilizamos el operador ':' seguido del nombre de la clase
     *   de la cual queremos heredar
     */
    public class MemoriaRAM : Componente
    {
        /* Atributos propios de la clase MemoriaRAM */
        private int capacidadGB;
        private int velocidadMHz;
        /* 
         * Constructor de la clase MemoriaRAM 
         * 
         * - Recibe como parámetros sus propios atributos y los heredados, al momento de hacer la herencia
         *   es OBLIGATORIO que las clases hijas tengan un constructor que reciba como parámetro los mismos
         *   atributos que recibe el constructor de la clase padre, en el mismo orden.
         * 
         *   Esto se hace para que 'primero se inicialice la clase padre' y despúes lo haga la clase hija, de lo
         *   contrario el IDE nos marcara un error diciendo que debemos de crear un constructor para inicializar
         *   la clase padre siempre de primero al momento de crear un objeto de la clase hija.
         *   
         *   Para ello utilizamos la palabra 'base' seguido de los parámetros del constructor de la clase padre,
         *   'base(parametro, parametro, parametro..)' para que primero se inicialice la clase padre.
         */
        public MemoriaRAM(string nombre, double precio, string fabricante, int capacidadGB, int velocidadMHz)
            : base(nombre, precio, fabricante)
        {
            CapacidadGB = capacidadGB;
            VelocidadMHz = velocidadMHz;
        }
        /* Propiedades getters y setters */
        public int CapacidadGB { get => capacidadGB; set => capacidadGB = value; }
        public int VelocidadMHz { get => velocidadMHz; set => velocidadMHz = value; }
    }
}
