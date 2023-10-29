namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAtributosPublicos;

/* 
 * Clase Videogame 
 * 
 */
public class Videogame
{
    /* 
     * Atributos de la clase Videogame 
     * Todos son publicos ahora se podra acceder a ellos desde cualquier parte del código (otro paquete, otras clases)
     */
    public string nombre;
    public string desarrollador;
    public int año;

    /* Método que devuelve la información de los atributos del objeto */
    public string ObtenerInformacion()
    {
        return "Videojuego{" + "nombre=" + nombre + " desarrollador=" + desarrollador + ", año=" + año + '}';
    }
}
