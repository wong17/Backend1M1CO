namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo2
{
    public class BibliotecaMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- BibliotecaMain ----------------------------------------");
            /* 
             * Para crear un objeto de tipo Biblioteca necesitamos primero crear varios objetos de tipo Libro
             * y su vez para crear un objeto de tipo Libro necesitamos la información de uno o varios Autores, 
             * primero debemos crear objetos de tipo Autor, despues los Libros y finalmente la Biblioteca.
             */

            // Crear objetos de tipo Autor
            Autor autor1 = new("J.K. Rowling", new DateTime(1965, 7, 31), "Britanica");
            Autor autor2 = new("George Orwell", new DateTime(1903, 6, 25), "Britanica");
            Autor autor3 = new("Stephen King", new DateTime(1947, 9, 21), "Estadounidense");
            
            // Crear libros para biblioteca RUSB
            Libro libro1RUSB = new("Libro 1 de RUSB", new Autor[] { autor1 }, 2001, true);
            Libro libro2RUSB = new("Libro 2 de RUSB", new Autor[] { autor1, autor2 }, 1995, true);
            Libro libro3RUSB = new("Libro 3 de RUSB", new Autor[] { autor1, autor2, autor3 }, 2010, false);
            
            // Crear libros para biblioteca RUPAP
            Libro libro1RUPAP = new("Libro 1 de RUPAP", new Autor[] { autor1 }, 1998, true);
            Libro libro2RUPAP = new("Libro 2 de RUPAP", new Autor[] { autor1, autor2 }, 1984, true);
            Libro libro3RUPAP = new("Libro 3 de RUPAP", new Autor[] { autor1, autor2, autor3 }, 2005, false);
            
            // Crear biblioteca RUSB y RUPAP
            Biblioteca bibliotecaRUSB = new(new Libro[] { libro1RUSB, libro2RUSB, libro3RUSB });
            Biblioteca bibliotecaRUPAP = new(new Libro[] { libro1RUPAP, libro2RUPAP, libro3RUPAP });
            
            // Invocar método de cada objeto biblioteca para ver todos los libros
            Console.WriteLine("Biblioteca RUSB:");
            bibliotecaRUSB.MostrarLibros();
            Console.WriteLine("Biblioteca RUPAP:");
            bibliotecaRUPAP.MostrarLibros();
        }
    }
}
