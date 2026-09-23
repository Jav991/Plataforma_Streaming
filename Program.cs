using Plataforma_Streaming.Entidades;

namespace Plataforma_Streaming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cancion cancion = new Cancion("pa mi", 180, 1, "ozuna", "urbano");
            cancion.MostrarCancion();

            Podcast p = new Podcast("Aprendiendo C#", 45, 0, "Programación", "Juan", 12);
            p.mostrarPodcast();

            Audiolibro audiolibro = new Audiolibro("El misterio de la ciudad", 50, 120, "Ana lopez", "pedro martin");
            audiolibro.Reproducir();

            Audiolibro a = new Audiolibro("El Sistema de la Ciudad", 50, 120, "Ana Lopez", "Pedro Martín");
            a.Reproducir();

            cancion.descargar();
            cancion.eliminarDescarga();

            audiolibro.descargar();
            audiolibro.eliminarDescarga();


        }
    }
}
