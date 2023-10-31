namespace PolimorfismoInterfaces.Herencia.ClasesAbstractas.MetodosVirtual
{
    /* 
     * Clase abstracta
     * 
     * Las clases abstractas se utilizan como clases padre, ya que sirven como una plantilla generica
     * que contiene atributos y la definición o prototipo de métodos que tienen en comun todos esos
     * objetos que hereden de ella. Se suelen utilizar este tipo de clases como padre porque ayudan a 
     * establecer una mejor jerarquia con las demas clases hijas. 
     * 
     * Si los métodos son 'abstract' cada clase hija que herede debe de implementar cada
     * uno de los métodos utilizando la palabra 'override' en vez de 'abstract'.
     * 
     * Si los métodos son 'virtual' la clase abstracta puede proveer una implementación base y las clases
     * que hereden opcionalmente pueden sobrescribir el método.
     */
    public abstract class FiguraGeometrica
    {
        /* Método abstracto */
        public abstract void CalcularArea();
        protected virtual void NotificarCalculoTerminado()
        {
            Console.WriteLine("El área de la figura se ha calculado.");
        }
    }
}
