/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_clase_y_objetos.ejemplo1;

/**
 *
 * @author Wong
 */
public class Estudiante {
    
    /* Atributos de la clase, sino se especifica modificador de acceso son "public" dentro del mismo
    paquete, "package clase1_clase_y_objetos"*/
    String carnet;
    String nombre;
    String carrera;

    public String obtenerInformacion() {
        return "Estudiante{" + "carnet=" + carnet 
                + ", nombre=" + nombre + ", carrera=" + carrera + '}';
    }
    
}
