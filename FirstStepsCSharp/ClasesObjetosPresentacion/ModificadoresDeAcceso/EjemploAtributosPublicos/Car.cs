namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAtributosPublicos;

/* 
 * Clase Car 
 * 
 */
public class Car
{
    /* 
     * Atributos de la clase Car 
     * Todos son publicos ahora se podra acceder a ellos desde cualquier parte del código (otro paquete, otras clases)
     */
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AñoFabricacion { get; set; }
    public string Color { get; set; }

    /* Método que devuelve la información de los atributos del objeto */
    public string MostrarInformacion()
    {
        return "Marca: " + Marca + ", Modelo: " + Modelo + ", Año de Fabricación: " + AñoFabricacion + ", Color: " + Color;
    }
}
