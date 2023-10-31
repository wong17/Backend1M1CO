namespace PolimorfismoInterfaces.Herencia.PolimorfismoClaseAbstracta
{
    /* Clase hija Director */
    public class Director : Empleado
    {
        /* Sobrescribir el método heredado */
        public override void CalcularSalario()
        {
            Console.WriteLine("Calcula el salario de un Director");
            /* Se ejecutara después de llamar al método CalcularSalario() que es público. */
            NotificarCalculoSalario();
        }
        /* Este método es accesible solo para las clases que heredan de Empleado */
        protected override void NotificarCalculoSalario()
        {
            Console.WriteLine("Se ha calculado el salario del Director (Método protected)");
        }
    }
}
