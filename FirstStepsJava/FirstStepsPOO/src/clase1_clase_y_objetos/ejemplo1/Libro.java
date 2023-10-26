/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_clase_y_objetos.ejemplo1;

/**
 *
 * @author Wong
 */
public class Libro {
    
    String titulo;
    String autor;
    int añoPublicacion;
    String editorial;

    public String mostrarInformacion() {
        return "Título: " + titulo + ", Autor: " + autor 
                + ", Año de Publicación: " + añoPublicacion + ", Editorial: " + editorial;
    }
}
