namespace PolimorfismoInterfaces.Interfaces.Ejemplo1
{
    /* Para implementar una interfaz utilizamos el operador ':' seguido del nombre de la interfaz. */
    public class ReproductorAudio : IReproductorMultimedia
    {
        /* Implementación de los métodos abstractos de la interfaz */
        public void Detener()
        {
            Console.WriteLine("El reproductor de audio se detuvo.");
        }

        public void Pausar()
        {
            Console.WriteLine("El reproductor de audio se pausó.");
        }

        public void Reproducir()
        {
            Console.WriteLine("El reproductor de audio empezo a sonar.");
        }
    }
}
