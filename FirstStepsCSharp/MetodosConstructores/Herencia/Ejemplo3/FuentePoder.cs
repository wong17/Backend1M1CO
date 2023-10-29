namespace MetodosConstructoresHerencia.Herencia.Ejemplo3
{
    /* 
     * CLASE HIJA que hereda de la CLASE PADRE Componente 
     * - Para llevar a cabo la Herencia utilizamos el operador ':' seguido del nombre de la clase
     *   de la cual queremos heredar
     */
    public class FuentePoder : Componente
    {
        /* Atributos propios de la clase FuentePoder */
        private string? certificacion;
        /* 
         * Constructor de la clase FuentePoder 
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
        public FuentePoder(string nombre, double precio, string fabricante, string? certificacion)
            : base(nombre, precio, fabricante)
        {
            Certificacion = certificacion;
        }
        /* Propiedades getters y setters */
        public string? Certificacion { get => certificacion; set => certificacion = value; }
    }
}
