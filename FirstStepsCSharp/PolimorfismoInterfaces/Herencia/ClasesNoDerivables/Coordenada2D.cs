namespace PolimorfismoInterfaces.Herencia.ClasesNoDerivables
{
    /* Al marcar una clase como 'sealed' evitamos que otras clases puedan heredar de ella. */
    public sealed class Coordenada2D
    {
        public int X { get; }
        public int Y { get; }

        public Coordenada2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    /* ERROR DE COMPILACIÓN al intentar heredar de la clase ConstantesMatematicas */
    //class Coordenada2DHija : Coordenada2D
    //{
    //}
}
