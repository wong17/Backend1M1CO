/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package clase1_getter_setter.ejemplo3;

/**
 *
 * @author Wong
 */
public class Libro {
    
    private String titulo;
    private String autor;
    private int añoPublicacion;
    private String editorial;

    public String mostrarInformacion() {
        return "Título: " + titulo + ", Autor: " + autor 
                + ", Año de Publicación: " + añoPublicacion + ", Editorial: " + editorial;
    }

    // Getter para el título
    public String getTitulo() {
        return titulo;
    }

    // Setter para el título
    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    // Getter para el autor
    public String getAutor() {
        return autor;
    }

    // Setter para el autor
    public void setAutor(String autor) {
        this.autor = autor;
    }

    // Getter para el año de publicación
    public int getAñoPublicacion() {
        return añoPublicacion;
    }

    // Setter para el año de publicación
    public void setAñoPublicacion(int añoPublicacion) {
        this.añoPublicacion = añoPublicacion;
    }

    // Getter para la editorial
    public String getEditorial() {
        return editorial;
    }

    // Setter para la editorial
    public void setEditorial(String editorial) {
        this.editorial = editorial;
    }
}

