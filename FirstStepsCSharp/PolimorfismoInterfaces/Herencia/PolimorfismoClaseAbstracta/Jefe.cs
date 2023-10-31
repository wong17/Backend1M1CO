namespace PolimorfismoInterfaces.Herencia.PolimorfismoClaseAbstracta
{
    /* Clase hija Jefe */
    public class Jefe : Empleado
    {
        /* Sobrescribir el método heredado */
        public override void CalcularSalario()
        {
            Console.WriteLine($"Calcula el salario de Jefe/Jefa: {Nombre}");
            /* Se ejecutara después de llamar al método CalcularSalario() que es público. */
            NotificarCalculoSalario();
        }
        /* Este método es accesible solo para las clases que heredan de Empleado */
        protected override void NotificarCalculoSalario()
        {
            Console.WriteLine("Se ha calculado el salario del Jefe (Método protected)");
        }
    }
}
