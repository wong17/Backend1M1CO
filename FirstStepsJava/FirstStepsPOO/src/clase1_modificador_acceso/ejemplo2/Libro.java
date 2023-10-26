/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_modificador_acceso.ejemplo2;

/**
 *
 * @author Wong
 */
public class Libro {
    
    private String titulo = "Libro de Ejemplo";
    private String autor = "Autor de Ejemplo";
    private int añoPublicacion = 2000;
    private String editorial = "Editorial de Ejemplo";

    public String mostrarInformacion() {
        return "Título: " + titulo + ", Autor: " + autor 
                + ", Año de Publicación: " + añoPublicacion + ", Editorial: " + editorial;
    }

    // Getter para el título
    public String getTitulo() {
        return titulo;
    }

    // Getter para el autor
    public String getAutor() {
        return autor;
    }

    // Getter para el año de publicación
    public int getAñoPublicacion() {
        return añoPublicacion;
    }

    // Getter para la editorial
    public String getEditorial() {
        return editorial;
    }
}

