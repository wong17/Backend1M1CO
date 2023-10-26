/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_modificador_acceso.ejemplo2;

/**
 *
 * @author Wong
 */
public class Videojuego {
    
    private String nombre = "Videojuego de Ejemplo";
    private String desarrollador = "Desarrollador de Ejemplo";
    private int año = 2000;

    public String obtenerInformacion() {
        return "Videojuego{" + "nombre=" + nombre + ", desarrollador=" + desarrollador + ", año=" + año + '}';
    }

    // Getter para el nombre
    public String getNombre() {
        return nombre;
    }

    // Getter para el desarrollador
    public String getDesarrollador() {
        return desarrollador;
    }

    // Getter para el año
    public int getAño() {
        return año;
    }
}
