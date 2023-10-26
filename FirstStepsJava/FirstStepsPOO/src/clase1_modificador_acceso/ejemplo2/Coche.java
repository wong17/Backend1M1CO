/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_modificador_acceso.ejemplo2;

/**
 *
 * @author Wong
 */
public class Coche {
    
    private String marca = "Toyota";
    private String modelo = "Camry";
    private int añoFabricacion = 2022;
    private String color = "Gris";

    public String mostrarInformacion() {
        return "Marca: " + marca + ", Modelo: " + modelo 
                + ", Año de Fabricación: " + añoFabricacion + ", Color: " + color;
    }

    // Getter para la marca
    public String getMarca() {
        return marca;
    }

    // Getter para el modelo
    public String getModelo() {
        return modelo;
    }

    // Getter para el año de fabricación
    public int getAñoFabricacion() {
        return añoFabricacion;
    }

    // Getter para el color
    public String getColor() {
        return color;
    }
}