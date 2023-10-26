/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_modificador_acceso.ejemplo2;

/**
 *
 * @author Wong
 */
public class Estudiante {
    
    private String carnet = "20230001";
    private String nombre = "María Pérez";
    private String carrera = "Ingeniería Informática";

    public String obtenerInformación() {
        return "Estudiante{" + "carnet=" + carnet + ", nombre=" + nombre + ", carrera=" + carrera + '}';
    }

    // Getter para el carnet
    public String getCarnet() {
        return carnet;
    }

    // Getter para el nombre
    public String getNombre() {
        return nombre;
    }

    // Getter para la carrera
    public String getCarrera() {
        return carrera;
    }
}

