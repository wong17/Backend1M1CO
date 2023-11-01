namespace PolimorfismoInterfaces.Interfaces.Ejemplo1
{
    public class ReproductorMultimediaMain
    {
        public static void Main()
        {
            Console.WriteLine("\n---------------------------------------- Reproductor Multimedia - Interfaces ejemplo 1 ----------------------------");
            
            // Creación de objetos
            ReproductorAudio reproductorAudio = new();
            ReproductorVideo reproductorVideo = new();

            // Invocar métodos
            reproductorAudio.Reproducir();
            reproductorAudio.Pausar();
            reproductorAudio.Detener();
            reproductorVideo.Reproducir();
            reproductorVideo.Pausar();
            reproductorVideo.Detener();
            Console.WriteLine();
            
            // Crear más objetos
            IReproductorMultimedia reproductorAudio2 = new ReproductorAudio();
            IReproductorMultimedia reproductorVideo2 = new ReproductorVideo();
            
            // Invocar métodos
            reproductorAudio2.Reproducir();
            reproductorAudio2.Pausar();
            reproductorAudio2.Detener();
            reproductorVideo2.Reproducir();
            reproductorVideo2.Pausar();
            reproductorVideo2.Detener();
        }
    }
}
