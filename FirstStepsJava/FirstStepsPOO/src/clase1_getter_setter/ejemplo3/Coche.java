/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_getter_setter.ejemplo3;

/**
 *
 * @author Wong
 */
public class Coche {
    
    private String marca;
    private String modelo;
    private int añoFabricacion;
    private String color;

    public String mostrarInformacion() {
        return "Marca: " + marca + ", Modelo: " + modelo 
                + ", Año de Fabricación: " + añoFabricacion + ", Color: " + color;
    }

    // Getter para la marca
    public String getMarca() {
        return marca;
    }

    // Setter para la marca
    public void setMarca(String marca) {
        this.marca = marca;
    }

    // Getter para el modelo
    public String getModelo() {
        return modelo;
    }

    // Setter para el modelo
    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    // Getter para el año de fabricación
    public int getAñoFabricacion() {
        return añoFabricacion;
    }

    // Setter para el año de fabricación
    public void setAñoFabricacion(int añoFabricacion) {
        this.añoFabricacion = añoFabricacion;
    }

    // Getter para el color
    public String getColor() {
        return color;
    }

    // Setter para el color
    public void setColor(String color) {
        this.color = color;
    }
}

