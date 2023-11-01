namespace PolimorfismoInterfaces.Interfaces.Ejemplo1
{
    /* 
     * Las interfaces se utilizan para extender el funcionamiento de una clase sin modificar dicha clase,
     * es uno de los principios SOLID. https://www.freecodecamp.org/news/solid-principles-explained-in-plain-english/
     */
    public interface IReproductorMultimedia
    {
        /* Por defecto son 'abstract' no hace falta poner la palabra en la declaración */
        void Reproducir();
        void Pausar();
        void Detener();
    }
}
