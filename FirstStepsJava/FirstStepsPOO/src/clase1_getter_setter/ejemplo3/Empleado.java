/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_getter_setter.ejemplo3;

/**
 *
 * @author Wong
 */
public class Empleado {
    
    // Atributos del empleado
    private int id;
    private float salario;
    private String nombre;
    private String cedula;
    private String direccion;
    private String ciudad;
    private String provincia;
    private String codigoPostal;

    // Método para mostrar información del Empleado
    public String obtenerInformacion() {
        return "Empleado{" + "id=" + id + ", salario=" + salario + ", nombre=" + nombre + ", "
                + "cedula=" + cedula + ", direccion=" + direccion + ", ciudad=" + ciudad + ", "
                + "provincia=" + provincia + ", codigoPostal=" + codigoPostal + '}';
    }

    // Getter para el id
    public int getId() {
        return id;
    }

    // Setter para el id
    public void setId(int id) {
        this.id = id;
    }

    // Getter para el salario
    public float getSalario() {
        return salario;
    }

    // Setter para el salario
    public void setSalario(float salario) {
        this.salario = salario;
    }

    // Getter para el nombre
    public String getNombre() {
        return nombre;
    }

    // Setter para el nombre
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    // Getter para la cedula
    public String getCedula() {
        return cedula;
    }

    // Setter para la cedula
    public void setCedula(String cedula) {
        this.cedula = cedula;
    }

    // Getter para la direccion
    public String getDireccion() {
        return direccion;
    }

    // Setter para la direccion
    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    // Getter para la ciudad
    public String getCiudad() {
        return ciudad;
    }

    // Setter para la ciudad
    public void setCiudad(String ciudad) {
        this.ciudad = ciudad;
    }

    // Getter para la provincia
    public String getProvincia() {
        return provincia;
    }

    // Setter para la provincia
    public void setProvincia(String provincia) {
        this.provincia = provincia;
    }

    // Getter para el codigoPostal
    public String getCodigoPostal() {
        return codigoPostal;
    }

    // Setter para el codigoPostal
    public void setCodigoPostal(String codigoPostal) {
        this.codigoPostal = codigoPostal;
    }
}

