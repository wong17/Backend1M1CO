namespace PolimorfismoInterfaces.Herencia.ClasesAbstractas
{
    /* 
     * Clase abstracta
     * 
     * Las clases abstractas se utilizan como clases padre, ya que sirven como una plantilla generica
     * que contiene atributos y la definición o prototipo de métodos que tienen en comun todos esos
     * objetos que hereden de ella. Se suelen utilizar este tipo de clases como padre porque ayudan a 
     * establecer una mejor jerarquia con las demas clases hijas. 
     * 
     * Los métodos deben de ser 'abstract' tambien y cada clase hija que herede debe de implementar cada
     * uno de los métodos utilizando la palabra 'override' en vez de 'abstract'.
     */
    public abstract class FiguraGeometrica
    {
        /* Método abstracto */
        public abstract void CalcularArea();
    }
}
