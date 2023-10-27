namespace ClasesObjetosPresentacion.CreacionClases
{
    public class Libro
    {
        string titulo;
        string autor;
        int añoPublicacion;
        string editorial;

        public string MostrarInformacion()
        {
            return "Título: " + titulo
                    + ", Autor: " + autor
                    + ", Año de Publicación: " + añoPublicacion
                    + ", Editorial: " + editorial;
        }
    }

}
