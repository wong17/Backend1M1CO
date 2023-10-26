/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_modificador_acceso.ejemplo2;

/**
 *
 * @author Wong
 */
public class Empleado {
    
    private int id = 1;
    private float salario = 2500.0f;
    private String nombre = "Juan Perez";
    private String cedula = "123456789";
    private String direccion = "Calle Principal 123";
    private String ciudad = "Ciudad de Ejemplo";
    private String provincia = "Provincia de Ejemplo";
    private String codigoPostal = "12345";

    // Método para mostrar información del Empleado
    public String obtenerInformacion() {
        return "Empleado{" + "id=" + id + ", salario=" + salario + ", nombre=" + nombre + ", "
                + "cedula=" + cedula + ", direccion=" + direccion + ", ciudad=" + ciudad + ", "
                + "provincia=" + provincia + ", codigoPostal=" + codigoPostal + '}';
    }

    // Getter para el ID
    public int getId() {
        return id;
    }

    // Getter para el salario
    public float getSalario() {
        return salario;
    }

    // Getter para el nombre
    public String getNombre() {
        return nombre;
    }

    // Getter para la cédula
    public String getCedula() {
        return cedula;
    }

    // Getter para la dirección
    public String getDireccion() {
        return direccion;
    }

    // Getter para la ciudad
    public String getCiudad() {
        return ciudad;
    }

    // Getter para la provincia
    public String getProvincia() {
        return provincia;
    }

    // Getter para el código postal
    public String getCodigoPostal() {
        return codigoPostal;
    }
}
