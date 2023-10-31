namespace PolimorfismoInterfaces.Herencia.SobrescribirMetodos
{
    /* Clase hija Camion */
    public class Camion : Vehiculo
    {
        /* 
        * La palabra 'override' indica que se esta sobrescribiendo un método heredado.
        * Si se omoite entonces no se sobrescribe el método heredado y se toma como un nuevo método
        * de la clase hija.
        */
        public override void Arrancar()
        {
            Console.WriteLine("El camión ha arrancado y se pone en marcha lentamente.");
        }
    }
}
