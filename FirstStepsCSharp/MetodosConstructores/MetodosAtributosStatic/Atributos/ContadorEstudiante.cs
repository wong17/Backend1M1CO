namespace MetodosConstructores.MetodosAtributosStatic.Atributos
{
    public class ContadorEstudiante
    {
        /*
         * La propiedad Contador le pertenece a la clase y no a los objetos que creemos
         * a partir de esta clase, el contador ira aumentado automaticamente cada vez 
         * que creemos un nuevo Estudiante.
         * 
         * En este ejemplo tampoco es posible cambiar su valor ya que el setter es privado, 
         * solo podemos obtener el valor para ver cuantos Estudiantes se han registrado,
         * poner el setter privado tiene sentido en este caso ya que solo se debe de poder
         * modificar desde la clase y no cada estudiante que se registre.
         *
         */
        public static int Contador { get; private set; } = 0; // Se inicia en 0

        public ContadorEstudiante()
        {
            Contador++; // Cada vez que se cree un objeto de esta clase aumenta 1
        }

    }
}
