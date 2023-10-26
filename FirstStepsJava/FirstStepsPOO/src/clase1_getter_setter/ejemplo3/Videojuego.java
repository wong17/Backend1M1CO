/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_getter_setter.ejemplo3;

/**
 *
 * @author Wong
 */
public class Videojuego {
    private String nombre;
    private String desarrollador;
    private int año;

    public String obtenerInformacion() {
        return "Videojuego{" + "nombre=" + nombre 
                + ", desarrollador=" + desarrollador + ", año=" + año + '}';
    }

    // Getter para el nombre
    public String getNombre() {
        return nombre;
    }

    // Setter para el nombre
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    // Getter para el desarrollador
    public String getDesarrollador() {
        return desarrollador;
    }

    // Setter para el desarrollador
    public void setDesarrollador(String desarrollador) {
        this.desarrollador = desarrollador;
    }

    // Getter para el año
    public int getAño() {
        return año;
    }

    // Setter para el año
    public void setAño(int año) {
        this.año = año;
    }
}

