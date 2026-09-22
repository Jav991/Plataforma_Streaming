using Plataforma_Streaming.Entidades;

namespace Plataforma_Streaming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cancion cancion = new Cancion("pa mi", 180, 1, "ozuna", "urbano");
            cancion.MostrarCancion();
        }
    }
}
