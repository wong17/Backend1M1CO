namespace PolimorfismoInterfaces.Herencia.SobrescribirMetodos
{
    /* Clase padre Vehiculo */
    public class Vehiculo
    {
        /* 
         * Declarar un método como 'virtual' permite que este pueda ser sobrescrito por
         * las clases que hereden este método. 
         */
        public virtual void Arrancar()
        {
            Console.WriteLine("El vehículo ha arrancado.");
        }
    }
}
