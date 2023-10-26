package clase1_clase_y_objetos.ejemplo1;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Wong
 */
public class Main {

    public static void main(String[] args) {

        // Creación de objeto de tipo Estudiante
        Estudiante estudiante = new Estudiante();
        estudiante.nombre = "Diego";
        estudiante.carrera = "Ing. Industrial";
        estudiante.carnet = "2013-1244U";
        System.out.println(estudiante.obtenerInformacion());
        
        // Creación de objeto de tipo Empleado
        Empleado empleado = new Empleado();
        empleado.id = 1;
        empleado.nombre = "Diego";
        empleado.cedula = "001-010190-2089U";
        empleado.direccion = "Una dirección aquí...";
        empleado.codigoPostal = "10010";
        empleado.provincia = "Provincia";
        empleado.ciudad = "Managua";
        System.out.println(empleado.obtenerInformacion());
        
        // Creación de objeto de tipo Videojuego
        Videojuego videojuego = new Videojuego();
        videojuego.nombre = "GTA SA";
        videojuego.año = 2004;
        videojuego.desarrollador = "Rockstar Games";
        System.out.println(videojuego.obtenerInformacion());
        
        // Crea un objeto de tipo Coche
        Coche coche = new Coche();
        coche.marca = "Toyota";
        coche.modelo = "Camry";
        coche.añoFabricacion = 2022;
        coche.color = "Gris";
        System.out.println(coche.mostrarInformacion());

        // Crear un objeto de tipo Libro
        Libro libro = new Libro();
        libro.titulo = "El Principito";
        libro.autor = "Antoine de Saint-Exupéry";
        libro.añoPublicacion = 1943;
        libro.editorial = "Harper & Brothers";
        System.out.println(coche.mostrarInformacion());
    }
}
