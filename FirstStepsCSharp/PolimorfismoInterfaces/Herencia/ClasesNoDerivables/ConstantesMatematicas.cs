namespace PolimorfismoInterfaces.Herencia.ClasesNoDerivables
{
    /* Al marcar una clase como 'sealed' evitamos que otras clases puedan heredar de ella. */
    public sealed class ConstantesMatematicas
    {
        public static readonly double RazonAurea = (1 + Math.Sqrt(5))/2;
    }

    /* ERROR DE COMPILACIÓN al intentar heredar de la clase ConstantesMatematicas */
    //class ConstantesMatematicasHija : ConstantesMatematicas
    //{
    //}
}
