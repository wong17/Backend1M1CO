namespace FirstStepsCSharp.POO.Encapsulation.AccessModifiers
{
    public class Person
    {
        /* 
         * Modificadores de acceso:
         *  public: Se puede acceder al atributo desde cualquier parte del código al momento de crear el objeto, 
         *          es decir desde cualquier otra clase.
         *  private: Solo se puede acceder al atributo desde dentro de la clase que contiene ese atributo.
         * 
         * Los atributos de una clase son privados por defecto sino se pone el modificador de acceso "private"
         * y seran publicos solo si se pone el modificador de acceso "public".
         * 
         * Aunque se recomienda siempre poner el modificador para evitar ambiguedades y que otros programadores a simple
         * vista se den cuenta del alcance de esos atributos en caso de que no sepan el modificador de acceso que le asigna
         * el lenguaje por defecto.
         */
        private string Name;        // equivalente a: string name;
        private string IDNumber;    // equivalente a: string IDNumber;
        double Height;              // es private, preferiblemente escribir: private double Height;
        public string Nacionality;  // atributo público 

        // Revisar clase PersonMain.cs del mismo paquete POO.Encapsulation, ahi continua el ejemplo.
    }
}