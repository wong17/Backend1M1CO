namespace ClasesObjetosPresentacion.CreacionClases
{
    public class Coche
    {
        string marca;
        string modelo;
        int añoFabricacion;
        string color;

        public string MostrarInformacion()
        {
            return "Marca: " + marca + 
                ", Modelo: " + modelo +
                ", Año de Fabricación: " + añoFabricacion + 
                ", Color: " + color;
        }
    }

}
