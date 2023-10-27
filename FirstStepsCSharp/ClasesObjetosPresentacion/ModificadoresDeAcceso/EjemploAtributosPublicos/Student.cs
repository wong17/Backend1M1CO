namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAtributosPublicos
{
    /* 
     * Clase Student 
     * 
     */
    public class Student
    {
        /* 
         * Atributos de la clase Estudiante 
         * Todos son publicos ahora se podra acceder a ellos desde cualquier parte del código (otro paquete, otras clases)
         */
        public string carnet;
        public string nombre;
        public string carrera;

        /* Método que devuelve la información de los atributos del objeto */
        public string ObtenerInformacion()
        {
            return "Estudiante{" + "carnet=" + carnet + ", nombre=" + nombre + ", carrera=" + carrera + '}';
        }

    }
}
