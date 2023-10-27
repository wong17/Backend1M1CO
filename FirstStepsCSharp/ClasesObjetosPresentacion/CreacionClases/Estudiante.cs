namespace ClasesObjetosPresentacion.CreacionClases
{
    public class Estudiante
    {
        // Atributos de la clase
        string carnet;
        string nombre;
        string carrera;

        // Método para obtener información del estudiante
        public string ObtenerInformacion()
        {
            return "Estudiante{"
                    + "carnet=" + carnet
                    + ", nombre=" + nombre
                    + ", carrera=" + carrera + '}';
        }
    }

}
