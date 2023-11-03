namespace ClasePractica1.Ejercicio2
{
    /* Enum */
    public enum TipoPlaneta 
    { 
        GASEOSO, TERRESTRE, ENANO
    }

    public class Planeta
    {
        /* Atributos */
        private readonly string? nombre = null;
        private readonly int cantidadSatelites = 0;
        private readonly double masa = 0;
        private readonly double volumen = 0;
        private readonly int diametro = 0;
        private readonly int distanciaSol = 0;
        private readonly TipoPlaneta tipoPlaneta;
        private readonly bool esObservable = false;

        /* Constructor */
        public Planeta(string? nombre, int cantidadSatelites, double masa, double volumen, int diametro, int distanciaSol, TipoPlaneta tipoPlaneta, bool esObservable)
        {
            this.nombre = nombre;
            this.cantidadSatelites = cantidadSatelites;
            this.masa = masa;
            this.volumen = volumen;
            this.diametro = diametro;
            this.distanciaSol = distanciaSol;
            this.tipoPlaneta = tipoPlaneta;
            this.esObservable = esObservable;
        }
        /* Métodos */
        public void MostrarInformacion() => Console.WriteLine($"Información del planeta: \nNombre: {nombre}\nCantidad satelites: {cantidadSatelites}\nMasa: {masa}\n" +
            $"Volumen: {volumen}\nDiametro: {diametro}\nDistancia media al sol: {distanciaSol}\nTipo planeta: {tipoPlaneta}\nEs observable: {esObservable}\n");

        public double CalcularDensidad() => volumen != 0 ? masa / volumen : double.NaN;

        public bool EsPlanetaExterior()
        {
            var unidades = distanciaSol / 149597870.0;
            return unidades >= 2.1 && unidades <= 3.4;
        }

        public string? Nombre => nombre;

    }
}
