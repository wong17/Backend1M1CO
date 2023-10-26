/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_clase_y_objetos.ejemplo1;

/**
 *
 * @author Wong
 */
public class Empleado {
    // Atributos del empleado
    int id;
    float salario;
    String nombre;
    String cedula;
    String direccion;
    String ciudad;
    String provincia;
    String codigoPostal;

    // Método para mostrar información del Empleado
    public String obtenerInformacion() {
        return "Empleado{" + "id=" + id + ", salario=" + salario + ", nombre=" + nombre + ", "
                + "cedula=" + cedula + ", direccion=" + direccion + ", ciudad=" + ciudad + ", "
                + "provincia=" + provincia + ", codigoPostal=" + codigoPostal + '}';
    }
    
}
