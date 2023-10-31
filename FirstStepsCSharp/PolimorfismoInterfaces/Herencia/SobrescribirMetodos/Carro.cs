namespace PolimorfismoInterfaces.Herencia.SobrescribirMetodos
{
    /* Clase hija Carro */
    public class Carro : Vehiculo
    {
        /* 
         * La palabra 'override' indica que se esta sobrescribiendo un método heredado.
         * Si se omoite entonces no se sobrescribe el método heredado y se toma como un nuevo método
         * de la clase hija.
         */
        public override void Arrancar()
        {
            Console.WriteLine("El carro ha arrancado y está listo para conducir.");
        }
    }
}
