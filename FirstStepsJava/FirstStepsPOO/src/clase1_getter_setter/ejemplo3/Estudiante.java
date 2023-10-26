/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_getter_setter.ejemplo3;

/**
 *
 * @author Wong
 */
public class Estudiante {
    
    // Atributos de la clase
    private String carnet;
    private String nombre;
    private String carrera;

    // Método para mostrar información del Estudiante
    public String obtenerInformacion() {
        return "Estudiante{" + "carnet=" + carnet + ", nombre=" + nombre + ", carrera=" + carrera + '}';
    }

    // Getter para el carnet
    public String getCarnet() {
        return carnet;
    }

    // Setter para el carnet
    public void setCarnet(String carnet) {
        this.carnet = carnet;
    }

    // Getter para el nombre
    public String getNombre() {
        return nombre;
    }

    // Setter para el nombre
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    // Getter para la carrera
    public String getCarrera() {
        return carrera;
    }

    // Setter para la carrera
    public void setCarrera(String carrera) {
        this.carrera = carrera;
    }
}
