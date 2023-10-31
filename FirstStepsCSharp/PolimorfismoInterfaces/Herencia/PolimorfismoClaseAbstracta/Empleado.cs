namespace PolimorfismoInterfaces.Herencia.PolimorfismoClaseAbstracta
{
    /* 
     * Clase padre abstracta Empleado 
     * 
     * Esta solo debe de contener declaraciones de propiedades y métodos sin implementar,
     * es una plantilla generica para toda clase que herede de ella.
     */
    public abstract class Empleado
    {
        /* Propiedad que solo es accesible por las clases que heredan de Empleado */
        protected string? Nombre { get; set; }
        /* Método publico y abstracto que deben de implementar las clases que hereden de Empleado */
        public abstract void CalcularSalario();
        /* Método protegido y abstracto solo se podra utilizar dentro de cada una de las clases que hereden de Empleado */
        protected abstract void NotificarCalculoSalario();
    }
}
