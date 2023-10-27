namespace ClasesObjetosPresentacion.CreacionClases
{
    public class Videojuego
    {
        string nombre;
        string desarrollador;
        int año;

        public string ObtenerInformacion()
        {
            return "Videojuego{"
                    + "nombre=" + nombre
                    + " desarrollador=" + desarrollador
                    + ", año=" + año + '}';
        }
    }

}
