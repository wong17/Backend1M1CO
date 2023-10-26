/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_clase_y_objetos.ejemplo1;

/**
 *
 * @author Wong
 */
public class Coche {
    
    String marca;
    String modelo;
    int añoFabricacion;
    String color;

    public String mostrarInformacion() {
        return "Marca: " + marca + ", Modelo: " + modelo 
                + ", Año de Fabricación: " + añoFabricacion + ", Color: " + color;
    }
}
