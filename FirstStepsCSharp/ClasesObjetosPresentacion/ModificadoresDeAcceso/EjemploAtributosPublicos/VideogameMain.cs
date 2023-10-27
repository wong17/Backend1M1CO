namespace ClasesObjetosPresentacion.ModificadoresDeAcceso.EjemploAtributosPublicos
{
    public class VideogameMain
    {
        public static void Main(string[] args)
        {
            // CREACIÓN DE OBJETOS DE TIPO Videogame

            // Creación de tres objetos de tipo Videogame
            Videogame videojuego1 = new Videogame
            {
                nombre = "The Legend of Zelda: Breath of the Wild",
                desarrollador = "Nintendo",
                año = 2017
            };

            Videogame videojuego2 = new Videogame
            {
                nombre = "The Witcher 3: Wild Hunt",
                desarrollador = "CD Projekt Red",
                año = 2015
            };

            Videogame videojuego3 = new Videogame
            {
                nombre = "Red Dead Redemption 2",
                desarrollador = "Rockstar Games",
                año = 2018
            };

            // Mostrar la información de los videojuegos
            Console.WriteLine("Datos del Videojuego 1: " + videojuego1.ObtenerInformacion());
            Console.WriteLine("Datos del Videojuego 2: " + videojuego2.ObtenerInformacion());
            Console.WriteLine("Datos del Videojuego 3: " + videojuego3.ObtenerInformacion());
            Console.WriteLine();
        }
    }
}
