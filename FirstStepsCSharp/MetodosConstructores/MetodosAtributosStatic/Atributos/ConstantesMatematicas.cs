namespace MetodosConstructoresHerencia.MetodosAtributosStatic.Atributos
{
    public class ConstantesMatematicas
    {
        /* Esta clase contiene solo atributos static, estos pertenecen a la clase y no a los objetos de esta clase */

        /* 
         * const: 
         * - Por defecto un campo declarado como const es static (no debemos poner static al campo)
         * - Sirve para crear constantes y se debe conocer el valor a tiempo de compilación
         */
        public const double PI = 3.14159265358979323846;
        public const double E = 2.71828182845904523536;
        public const double PHI = 1.61803398874989484820;

        /* 
         * readonly: 
         * - Por defecto un campo readonly no es static (debemos poner la palabra si queremos que lo sea)
         * - Sirve para crear constantes en tiempo de ejecución, la variable tomara un valor la primera vez
         *   y ese valor lo mantendra por el resto de tiempo que se ejecute el programa.
         * - Tambien puede ser asignado su valor dentro de un constructor, son mas flexibles que const
         */
        public static readonly double RaizDe2 = 1.41421356237309504880;
        public static readonly double RaizDe3 = 1.73205080756887729352;
        public static readonly double Ln10 = 2.30258509299404568402;
    }
}
